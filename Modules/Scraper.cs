using System;
using System.Threading.Tasks;
using PuppeteerSharp;

namespace ElginOeIntegration.Modules
{
    public class ScraperOptions
    {
        public string DownloadPath { get; set; } = "./downloads";
    }

    public abstract class ScraperService
    {
        protected readonly int Timeout = 10_000; // Default timeout for operations
        
        private IBrowser _browser;
        private IPage _page;
        private readonly ScraperOptions _options;

        protected IBrowser Browser
        {
            get
            {
                if (_browser == null)
                {
                    throw new InvalidOperationException("Browser is not initialized. Call StartBrowserAsync() first.");
                }
                return _browser;
            }
        }

        protected IPage Page
        {
            get
            {
                if (_page == null)
                {
                    throw new InvalidOperationException("Page is not initialized. Call InitPageAsync() first.");
                }
                return _page;
            }
        }

        protected ScraperService(ScraperOptions options = null)
        {
            _options = options ?? new ScraperOptions();
        }

        protected void LogDebug(string message)
        {
            Console.WriteLine($"[DEBUG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetType().Name}: {message}");
        }

        protected async Task<IBrowser> StartBrowserAsync()
        {
            // Download Chromium if not already downloaded
            await new BrowserFetcher().DownloadAsync();

            // Launch the browser and open a new blank page
            _browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Args = new[] { "--disable-features=HttpsFirstBalancedModeAutoEnable" },
                Headless = false,
                DefaultViewport = null
            });

            LogDebug("Browser launched successfully");

            return _browser;
        }

        protected async Task CloseBrowserAsync()
        {
            if (_browser != null)
            {
                await _browser.CloseAsync();
                LogDebug("Browser closed successfully");
                _browser = null;
                _page = null;
            }
        }

        protected async Task<IPage> InitPageAsync(string url)
        {
            if (_page == null)
            {
                _page = await Browser.NewPageAsync();
                
                // Set up download behavior
                await _page.Client.SendAsync("Page.setDownloadBehavior", new
                {
                    behavior = "allow",
                    downloadPath = _options.DownloadPath
                });
            }

            // Navigate the page to a URL
            await _page.GoToAsync(url, new NavigationOptions 
            { 
                WaitUntil = new[] { WaitUntilNavigation.Networkidle2 } 
            });

            // Set screen size
            await _page.SetViewportAsync(new ViewPortOptions 
            { 
                Width = 1080, 
                Height = 1024 
            });

            LogDebug($"Navigated to {url}");

            return _page;
        }

        protected async Task<string> GetElementTypeAsync(string selector)
        {
            // Check if it's a select element
            var elementType = await Page.EvaluateFunctionAsync<string>(@"(sel) => {
                const element = document.querySelector(sel);
                return element ? element.tagName.toLowerCase() : 'not found';
            }", selector);

            return elementType;
        }

        protected async Task SetInputElementAsync(string selector, string value)
        {
            // Wait for the element to be present and visible
            await Page.WaitForSelectorAsync(selector, new WaitForSelectorOptions
            {
                Timeout = Timeout
            });

            LogDebug($"Found {selector}");

            // Check if it's a select element
            var elementType = await GetElementTypeAsync(selector);

            LogDebug($"Element type: {elementType}");

            if (elementType == "select")
            {
                // If it's a select element, use select instead of type
                await Page.SelectAsync(selector, value);
                LogDebug($"Selected {value} in dropdown");
            }
            else
            {
                // Clear existing content first
                await Page.ClickAsync(selector, new ClickOptions { ClickCount = 3 });
                await Page.Keyboard.PressAsync("Backspace");
                
                // If it's an input, use type
                await Page.TypeAsync(selector, value);
                LogDebug($"Typed {value} in input field");
            }
        }

        protected async Task ClickButtonAsync(string selector)
        {
            await Page.WaitForSelectorAsync(selector, new WaitForSelectorOptions
            {
                Timeout = Timeout
            });

            LogDebug($"Clicking button with selector: {selector}");

            await Page.ClickAsync(selector);

            LogDebug($"Button with selector {selector} clicked");
        }

        protected async Task WaitForSelectorAsync(string selector, int? timeoutMs = null)
        {
            await Page.WaitForSelectorAsync(selector, new WaitForSelectorOptions
            {
                Timeout = timeoutMs ?? Timeout
            });
        }

        protected async Task<string> GetTextContentAsync(string selector)
        {
            var element = await Page.WaitForSelectorAsync(selector, new WaitForSelectorOptions
            {
                Timeout = Timeout
            });

            return await Page.EvaluateFunctionAsync<string>("element => element.textContent", element);
        }

        protected async Task<string> GetAttributeAsync(string selector, string attribute)
        {
            var element = await Page.WaitForSelectorAsync(selector, new WaitForSelectorOptions
            {
                Timeout = Timeout
            });

            return await Page.EvaluateFunctionAsync<string>($"element => element.getAttribute('{attribute}')", element);
        }

        protected async Task WaitAsync(int milliseconds)
        {
            await Task.Delay(milliseconds);
        }

        protected async Task TakeScreenshotAsync(string path)
        {
            await Page.ScreenshotAsync(path);
            LogDebug($"Screenshot saved to {path}");
        }

        // Dispose pattern for proper cleanup
        public virtual async Task DisposeAsync()
        {
            await CloseBrowserAsync();
        }
    }
}
