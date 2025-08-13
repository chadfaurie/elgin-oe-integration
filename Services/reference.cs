using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElginOeIntegration.Models;
using ElginOeIntegration.Exceptions;
using ACCPAC.Advantage;

public class Demo
{
	protected View OEORD1header;
	protected ViewFields OEORD1headerFields;

	protected View OEORD1detail1;
	protected ViewFields OEORD1detail1Fields;

	protected View OEORD1detail2;
	protected ViewFields OEORD1detail2Fields;

	protected View OEORD1detail3;
	protected ViewFields OEORD1detail3Fields;

	protected View OEORD1detail4;
	protected ViewFields OEORD1detail4Fields;

	protected View OEORD1detail5;
	protected ViewFields OEORD1detail5Fields;

	protected View OEORD1detail6;
	protected ViewFields OEORD1detail6Fields;

	protected View OEORD1detail7;
	protected ViewFields OEORD1detail7Fields;

	protected View OEORD1detail8;
	protected ViewFields OEORD1detail8Fields;

	protected View OEORD1detail9;
	protected ViewFields OEORD1detail9Fields;

	protected View OEORD1detail10;
	protected ViewFields OEORD1detail10Fields;

	protected View OEORD1detail11;
	protected ViewFields OEORD1detail11Fields;

	protected View OEORD1detail12;
	protected ViewFields OEORD1detail12Fields;

	public void doThing()
	{
		var temp = false;

		

		Dim OEORD2header As AccpacCOMAPI.AccpacView
		Dim OEORD2headerFields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0520", OEORD2header
Set OEORD2headerFields = OEORD2header.Fields

Dim OEORD2detail1 As AccpacCOMAPI.AccpacView
Dim OEORD2detail1Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0500", OEORD2detail1
Set OEORD2detail1Fields = OEORD2detail1.Fields

Dim OEORD2detail2 As AccpacCOMAPI.AccpacView
Dim OEORD2detail2Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0740", OEORD2detail2
Set OEORD2detail2Fields = OEORD2detail2.Fields

Dim OEORD2detail3 As AccpacCOMAPI.AccpacView
Dim OEORD2detail3Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0180", OEORD2detail3
Set OEORD2detail3Fields = OEORD2detail3.Fields

Dim OEORD2detail4 As AccpacCOMAPI.AccpacView
Dim OEORD2detail4Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0526", OEORD2detail4
Set OEORD2detail4Fields = OEORD2detail4.Fields

Dim OEORD2detail5 As AccpacCOMAPI.AccpacView
Dim OEORD2detail5Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0522", OEORD2detail5
Set OEORD2detail5Fields = OEORD2detail5.Fields

Dim OEORD2detail6 As AccpacCOMAPI.AccpacView
Dim OEORD2detail6Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0508", OEORD2detail6
Set OEORD2detail6Fields = OEORD2detail6.Fields

Dim OEORD2detail7 As AccpacCOMAPI.AccpacView
Dim OEORD2detail7Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0507", OEORD2detail7
Set OEORD2detail7Fields = OEORD2detail7.Fields

Dim OEORD2detail8 As AccpacCOMAPI.AccpacView
Dim OEORD2detail8Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0501", OEORD2detail8
Set OEORD2detail8Fields = OEORD2detail8.Fields

Dim OEORD2detail9 As AccpacCOMAPI.AccpacView
Dim OEORD2detail9Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0502", OEORD2detail9
Set OEORD2detail9Fields = OEORD2detail9.Fields

Dim OEORD2detail10 As AccpacCOMAPI.AccpacView
Dim OEORD2detail10Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0504", OEORD2detail10
Set OEORD2detail10Fields = OEORD2detail10.Fields

Dim OEORD2detail11 As AccpacCOMAPI.AccpacView
Dim OEORD2detail11Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0506", OEORD2detail11
Set OEORD2detail11Fields = OEORD2detail11.Fields

Dim OEORD2detail12 As AccpacCOMAPI.AccpacView
Dim OEORD2detail12Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0503", OEORD2detail12
Set OEORD2detail12Fields = OEORD2detail12.Fields

OEORD2header.Compose Array(OEORD2detail1, Nothing, OEORD2detail3, OEORD2detail2, OEORD2detail4, OEORD2detail5)

OEORD2detail1.Compose Array(OEORD2header, OEORD2detail8, OEORD2detail12, OEORD2detail9, OEORD2detail6, OEORD2detail7)

OEORD2detail2.Compose Array(OEORD2header)

OEORD2detail3.Compose Array(OEORD2header, OEORD2detail1)

OEORD2detail4.Compose Array(OEORD2header)

OEORD2detail5.Compose Array(OEORD2header)

OEORD2detail6.Compose Array(OEORD2detail1)

OEORD2detail7.Compose Array(OEORD2detail1)

OEORD2detail8.Compose Array(OEORD2detail1)

OEORD2detail9.Compose Array(OEORD2detail1, OEORD2detail10, OEORD2detail11)

OEORD2detail10.Compose Array(OEORD2detail9)

OEORD2detail11.Compose Array(OEORD2detail9)

OEORD2detail12.Compose Array(OEORD2detail1)



OEORD2headerFields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI

		OEORD2detail1Fields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI
		OEORD2header.Cancel();
		OEORD2header.Cancel();
		OEORD2header.Init
OEORD2detail2.Browse("", true);
		OEORD2detail2.Fetch(false);
		OEORD2headerFields.FieldByName("CUSTOMER").SetValue("WOOL001", true); // Customer Number
		OEORD2detail2.Browse("", true);

		OEORD2detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD2detail2.Browse("", false);
		OEORD2detail2.Fetch(false);
		OEORD2headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command
		OEORD2header.Process();

		OEORD2headerFields.FieldByName("PONUMBER").SetValue("70300443 VA", true); // Purchase Order Number
		OEORD2headerFields.FieldByName("REQUESDATE").SetValue(DateSerial(2025, 8, 6), true); // Date Requested
		OEORD2headerFields.FieldByName("EXPDATE").SetValue(DateSerial(2025, 8, 6), true); // Expected Ship Date
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordClear
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV1701", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("79.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV0099", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("35.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-2", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV0130NUOM", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("32.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-3", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV1943", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("63.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-4", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV2099", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("95.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-5", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV1850", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("14.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-6", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV0350NUOM2", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("214.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-7", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV0370NUOM2", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("170.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-8", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV0352", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("65.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-9", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV1906", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("68.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-10", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV1907", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("91.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-11", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV1822", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("55.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-12", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV1821", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("82.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-13", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV0185", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("20.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-14", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV1751", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("30.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-15", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV1750", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("43.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-16", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV0901", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("57.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-17", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV0754", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("15.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-18", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ITEM").SetValue("S.WWV1300", true); // Item
		OEORD2detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD2detail1.Process();
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD2detail1Fields.FieldByName("QTYORDERED").SetValue("16.0000", true); // Quantity Ordered

		temp = OEORD2detail1.Exists;
		OEORD2detail1.Insert();
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;

		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-19", false); // Line Number

		OEORD2detail1.Read(true);
		temp = OEORD2detail1.Exists;
		temp = OEORD2detail1.Exists;
		OEORD2detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD2detail1.Exists;
		OEORD2detail1.Browse "", 0

OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD2detail1.Read(true);
		OEORD2detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD2detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD2detail5.Read(true);

		OEORD2detail5Fields.FieldByName("VALIFBOOL").SetValue("1", true); // Yes/No Value

		temp = OEORD2detail5.Exists;
		OEORD2detail5.Update();

		OEORD2detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD2detail5.Read(true);

		OEORD2detail5Fields.FieldByName("VALIFTEXT").SetValue("WWTRANS", true); // Text Value

		OEORD2detail5.Update();

		OEORD2detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD2detail5.Read(true);
		OEORD2headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command

		OEORD2headerFields.FieldByName("REFERENCE").SetValue("WW PORTAL", false); // Order Reference
		OEORD2headerFields.FieldByName("DESC").SetValue("70300443 VA", false); // Order Description

		OEORD2header.Process();
		OEORD2header.Insert();
		OEORD2header.Order = 1;
		OEORD2header.Read(true);
		OEORD2header.Order = 0;
		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
		OEORD2detail1.Browse("", true);
		OEORD2detail1.Fetch(false);
		OEORD2detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

		OEORD2detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

		OEORD2detail9.Browse("", true);
		OEORD2detail9.Fetch(false);
		OEORD2detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
		OEORD2detail3.Browse("", true);
		OEORD2detail3.Fetch(false);
		OEORD2detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
		OEORD2detail2.Browse("", false);
		OEORD2detail2.Fetch(false);

		OEORD2detail2Fields.FieldByName("PAYMENT").SetValue("-1", false); // Payment Number
		OEORD2detail2.Browse("", true);

		OEORD2detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD2detail2.Browse("", false);
		OEORD2detail2.Fetch(false);
		temp = OEORD2header.Exists;
		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("32", false); // Line Number
		OEORD2detail1.Read(true);
		OEORD2headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command
		OEORD2header.Process();
		temp = OEORD2header.Exists;
		OEORD2header.Update();
		OEORD2header.Order = 1;
		OEORD2header.Read(true);
		OEORD2header.Order = 0;
		OEORD2detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
		OEORD2detail1.Browse("", true);
		OEORD2detail1.Fetch(false);
		OEORD2detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

		OEORD2detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

		OEORD2detail9.Browse("", true);
		OEORD2detail9.Fetch(false);
		OEORD2detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
		OEORD2detail3.Browse("", true);
		OEORD2detail3.Fetch(false);
		OEORD2detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
		OEORD2detail2.Browse("", false);
		OEORD2detail2.Fetch(false);
		OEORD2detail2.Browse("", true);

		OEORD2detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD2detail2.Browse("", false);
		OEORD2detail2.Fetch(false);
		temp = OEORD2header.Exists;

		Dim OEORD3header As AccpacCOMAPI.AccpacView
		Dim OEORD3headerFields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0520", OEORD3header
Set OEORD3headerFields = OEORD3header.Fields

Dim OEORD3detail1 As AccpacCOMAPI.AccpacView
Dim OEORD3detail1Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0500", OEORD3detail1
Set OEORD3detail1Fields = OEORD3detail1.Fields

Dim OEORD3detail2 As AccpacCOMAPI.AccpacView
Dim OEORD3detail2Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0740", OEORD3detail2
Set OEORD3detail2Fields = OEORD3detail2.Fields

Dim OEORD3detail3 As AccpacCOMAPI.AccpacView
Dim OEORD3detail3Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0180", OEORD3detail3
Set OEORD3detail3Fields = OEORD3detail3.Fields

Dim OEORD3detail4 As AccpacCOMAPI.AccpacView
Dim OEORD3detail4Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0526", OEORD3detail4
Set OEORD3detail4Fields = OEORD3detail4.Fields

Dim OEORD3detail5 As AccpacCOMAPI.AccpacView
Dim OEORD3detail5Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0522", OEORD3detail5
Set OEORD3detail5Fields = OEORD3detail5.Fields

Dim OEORD3detail6 As AccpacCOMAPI.AccpacView
Dim OEORD3detail6Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0508", OEORD3detail6
Set OEORD3detail6Fields = OEORD3detail6.Fields

Dim OEORD3detail7 As AccpacCOMAPI.AccpacView
Dim OEORD3detail7Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0507", OEORD3detail7
Set OEORD3detail7Fields = OEORD3detail7.Fields

Dim OEORD3detail8 As AccpacCOMAPI.AccpacView
Dim OEORD3detail8Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0501", OEORD3detail8
Set OEORD3detail8Fields = OEORD3detail8.Fields

Dim OEORD3detail9 As AccpacCOMAPI.AccpacView
Dim OEORD3detail9Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0502", OEORD3detail9
Set OEORD3detail9Fields = OEORD3detail9.Fields

Dim OEORD3detail10 As AccpacCOMAPI.AccpacView
Dim OEORD3detail10Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0504", OEORD3detail10
Set OEORD3detail10Fields = OEORD3detail10.Fields

Dim OEORD3detail11 As AccpacCOMAPI.AccpacView
Dim OEORD3detail11Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0506", OEORD3detail11
Set OEORD3detail11Fields = OEORD3detail11.Fields

Dim OEORD3detail12 As AccpacCOMAPI.AccpacView
Dim OEORD3detail12Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0503", OEORD3detail12
Set OEORD3detail12Fields = OEORD3detail12.Fields

OEORD3header.Compose Array(OEORD3detail1, Nothing, OEORD3detail3, OEORD3detail2, OEORD3detail4, OEORD3detail5)

OEORD3detail1.Compose Array(OEORD3header, OEORD3detail8, OEORD3detail12, OEORD3detail9, OEORD3detail6, OEORD3detail7)

OEORD3detail2.Compose Array(OEORD3header)

OEORD3detail3.Compose Array(OEORD3header, OEORD3detail1)

OEORD3detail4.Compose Array(OEORD3header)

OEORD3detail5.Compose Array(OEORD3header)

OEORD3detail6.Compose Array(OEORD3detail1)

OEORD3detail7.Compose Array(OEORD3detail1)

OEORD3detail8.Compose Array(OEORD3detail1)

OEORD3detail9.Compose Array(OEORD3detail1, OEORD3detail10, OEORD3detail11)

OEORD3detail10.Compose Array(OEORD3detail9)

OEORD3detail11.Compose Array(OEORD3detail9)

OEORD3detail12.Compose Array(OEORD3detail1)



OEORD3headerFields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI

		OEORD3detail1Fields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI
		OEORD3header.Cancel();
		OEORD3header.Cancel();
		OEORD3header.Init
OEORD3detail2.Browse("", true);
		OEORD3detail2.Fetch(false);
		OEORD3headerFields.FieldByName("CUSTOMER").SetValue("WOOL001", true); // Customer Number
		OEORD3detail2.Browse("", true);

		OEORD3detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD3detail2.Browse("", false);
		OEORD3detail2.Fetch(false);
		OEORD3headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command
		OEORD3header.Process();

		OEORD3headerFields.FieldByName("PONUMBER").SetValue("70300446 HOT WC", true); // Purchase Order Number
		OEORD3headerFields.FieldByName("REQUESDATE").SetValue(DateSerial(2025, 8, 6), true); // Date Requested
		OEORD3headerFields.FieldByName("EXPDATE").SetValue(DateSerial(2025, 8, 6), true); // Expected Ship Date
		temp = OEORD3detail1.Exists;
		OEORD3detail1.RecordClear
		temp = OEORD3detail1.Exists;
		OEORD3detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ITEM").SetValue("S.WWP1603", true); // Item
		OEORD3detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD3detail1.Process();
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD3detail1Fields.FieldByName("QTYORDERED").SetValue("101.0000", true); // Quantity Ordered

		temp = OEORD3detail1.Exists;
		OEORD3detail1.Insert();
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD3detail1.Read(true);
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;
		OEORD3detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ITEM").SetValue("S.WWV0320", true); // Item
		OEORD3detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD3detail1.Process();
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD3detail1Fields.FieldByName("QTYORDERED").SetValue("31.0000", true); // Quantity Ordered

		temp = OEORD3detail1.Exists;
		OEORD3detail1.Insert();
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("LINENUM").SetValue("-2", false); // Line Number

		OEORD3detail1.Read(true);
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;
		OEORD3detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ITEM").SetValue("S.WWV1988", true); // Item
		OEORD3detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD3detail1.Process();
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD3detail1Fields.FieldByName("QTYORDERED").SetValue("40.0000", true); // Quantity Ordered

		temp = OEORD3detail1.Exists;
		OEORD3detail1.Insert();
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("LINENUM").SetValue("-3", false); // Line Number

		OEORD3detail1.Read(true);
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;
		OEORD3detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ITEM").SetValue("S.WWV1860", true); // Item
		OEORD3detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD3detail1.Process();
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD3detail1Fields.FieldByName("QTYORDERED").SetValue("4.0000", true); // Quantity Ordered

		temp = OEORD3detail1.Exists;
		OEORD3detail1.Insert();
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("LINENUM").SetValue("-4", false); // Line Number

		OEORD3detail1.Read(true);
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;
		OEORD3detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ITEM").SetValue("S.WWV0329", true); // Item
		OEORD3detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD3detail1.Process();
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD3detail1Fields.FieldByName("QTYORDERED").SetValue("18.0000", true); // Quantity Ordered

		temp = OEORD3detail1.Exists;
		OEORD3detail1.Insert();
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("LINENUM").SetValue("-5", false); // Line Number

		OEORD3detail1.Read(true);
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;
		OEORD3detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ITEM").SetValue("S.WWV0330", true); // Item
		OEORD3detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD3detail1.Process();
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD3detail1Fields.FieldByName("QTYORDERED").SetValue("12.0000", true); // Quantity Ordered

		temp = OEORD3detail1.Exists;
		OEORD3detail1.Insert();
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;

		OEORD3detail1Fields.FieldByName("LINENUM").SetValue("-6", false); // Line Number

		OEORD3detail1.Read(true);
		temp = OEORD3detail1.Exists;
		temp = OEORD3detail1.Exists;
		OEORD3detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD3detail1.Exists;
		OEORD3detail1.Browse("", true);

		OEORD3detail1Fields.FieldByName("LINENUM").SetValue("-6", false); // Line Number

		OEORD3detail1.Read(true);
		OEORD3detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD3detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD3detail5.Read(true);

		OEORD3detail5Fields.FieldByName("VALIFBOOL").SetValue("1", true); // Yes/No Value

		temp = OEORD3detail5.Exists;
		OEORD3detail5.Update();

		OEORD3detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD3detail5.Read(true);

		OEORD3detail5Fields.FieldByName("VALIFTEXT").SetValue("WWTRANS", true); // Text Value

		OEORD3detail5.Update();

		OEORD3detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD3detail5.Read(true);
		OEORD3headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command

		OEORD3headerFields.FieldByName("REFERENCE").SetValue("WW PORTAL", false); // Order Reference
		OEORD3headerFields.FieldByName("DESC").SetValue("70300446 HOT WC", false); // Order Description

		OEORD3header.Process();
		OEORD3header.Insert();
		OEORD3header.Order = 1;
		OEORD3header.Read(true);
		OEORD3header.Order = 0;
		OEORD3detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
		OEORD3detail1.Browse("", true);
		OEORD3detail1.Fetch(false);
		OEORD3detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

		OEORD3detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

		OEORD3detail9.Browse("", true);
		OEORD3detail9.Fetch(false);
		OEORD3detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
		OEORD3detail3.Browse("", true);
		OEORD3detail3.Fetch(false);
		OEORD3detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
		OEORD3detail2.Browse("", false);
		OEORD3detail2.Fetch(false);

		OEORD3detail2Fields.FieldByName("PAYMENT").SetValue("-1", false); // Payment Number
		OEORD3detail2.Browse("", true);

		OEORD3detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD3detail2.Browse("", false);
		OEORD3detail2.Fetch(false);
		temp = OEORD3header.Exists;

		Dim OEORD4header As AccpacCOMAPI.AccpacView
		Dim OEORD4headerFields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0520", OEORD4header
Set OEORD4headerFields = OEORD4header.Fields

Dim OEORD4detail1 As AccpacCOMAPI.AccpacView
Dim OEORD4detail1Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0500", OEORD4detail1
Set OEORD4detail1Fields = OEORD4detail1.Fields

Dim OEORD4detail2 As AccpacCOMAPI.AccpacView
Dim OEORD4detail2Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0740", OEORD4detail2
Set OEORD4detail2Fields = OEORD4detail2.Fields

Dim OEORD4detail3 As AccpacCOMAPI.AccpacView
Dim OEORD4detail3Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0180", OEORD4detail3
Set OEORD4detail3Fields = OEORD4detail3.Fields

Dim OEORD4detail4 As AccpacCOMAPI.AccpacView
Dim OEORD4detail4Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0526", OEORD4detail4
Set OEORD4detail4Fields = OEORD4detail4.Fields

Dim OEORD4detail5 As AccpacCOMAPI.AccpacView
Dim OEORD4detail5Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0522", OEORD4detail5
Set OEORD4detail5Fields = OEORD4detail5.Fields

Dim OEORD4detail6 As AccpacCOMAPI.AccpacView
Dim OEORD4detail6Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0508", OEORD4detail6
Set OEORD4detail6Fields = OEORD4detail6.Fields

Dim OEORD4detail7 As AccpacCOMAPI.AccpacView
Dim OEORD4detail7Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0507", OEORD4detail7
Set OEORD4detail7Fields = OEORD4detail7.Fields

Dim OEORD4detail8 As AccpacCOMAPI.AccpacView
Dim OEORD4detail8Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0501", OEORD4detail8
Set OEORD4detail8Fields = OEORD4detail8.Fields

Dim OEORD4detail9 As AccpacCOMAPI.AccpacView
Dim OEORD4detail9Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0502", OEORD4detail9
Set OEORD4detail9Fields = OEORD4detail9.Fields

Dim OEORD4detail10 As AccpacCOMAPI.AccpacView
Dim OEORD4detail10Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0504", OEORD4detail10
Set OEORD4detail10Fields = OEORD4detail10.Fields

Dim OEORD4detail11 As AccpacCOMAPI.AccpacView
Dim OEORD4detail11Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0506", OEORD4detail11
Set OEORD4detail11Fields = OEORD4detail11.Fields

Dim OEORD4detail12 As AccpacCOMAPI.AccpacView
Dim OEORD4detail12Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0503", OEORD4detail12
Set OEORD4detail12Fields = OEORD4detail12.Fields

OEORD4header.Compose Array(OEORD4detail1, Nothing, OEORD4detail3, OEORD4detail2, OEORD4detail4, OEORD4detail5)

OEORD4detail1.Compose Array(OEORD4header, OEORD4detail8, OEORD4detail12, OEORD4detail9, OEORD4detail6, OEORD4detail7)

OEORD4detail2.Compose Array(OEORD4header)

OEORD4detail3.Compose Array(OEORD4header, OEORD4detail1)

OEORD4detail4.Compose Array(OEORD4header)

OEORD4detail5.Compose Array(OEORD4header)

OEORD4detail6.Compose Array(OEORD4detail1)

OEORD4detail7.Compose Array(OEORD4detail1)

OEORD4detail8.Compose Array(OEORD4detail1)

OEORD4detail9.Compose Array(OEORD4detail1, OEORD4detail10, OEORD4detail11)

OEORD4detail10.Compose Array(OEORD4detail9)

OEORD4detail11.Compose Array(OEORD4detail9)

OEORD4detail12.Compose Array(OEORD4detail1)



OEORD4headerFields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI

		OEORD4detail1Fields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI
		OEORD4header.Cancel();
		OEORD4header.Cancel();
		OEORD4header.Init
OEORD4detail2.Browse("", true);
		OEORD4detail2.Fetch(false);
		OEORD4headerFields.FieldByName("CUSTOMER").SetValue("WOOL001", true); // Customer Number
		OEORD4detail2.Browse("", true);

		OEORD4detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD4detail2.Browse("", false);
		OEORD4detail2.Fetch(false);
		OEORD4headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command
		OEORD4header.Process();

		OEORD4headerFields.FieldByName("PONUMBER").SetValue("70300448 PRIMAL WC", true); // Purchase Order Number
		OEORD4headerFields.FieldByName("REQUESDATE").SetValue(DateSerial(2025, 8, 6), true); // Date Requested
		OEORD4headerFields.FieldByName("EXPDATE").SetValue(DateSerial(2025, 8, 6), true); // Expected Ship Date
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordClear
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWV0110", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("31.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWV0111", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("33.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-2", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWV0112", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("28.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-3", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWV0805", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("34.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-4", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWV0810", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("17.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-5", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWV0655", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("46.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-6", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWV0656", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("20.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-7", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP1200", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("170.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-8", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP1700", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("114.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-9", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP2000NUOM", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("25.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-10", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP2200", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("97.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-11", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP1800NUOM", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("167.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-12", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP2050", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("33.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-13", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP2300", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("61.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-14", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP0300", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("232.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-15", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP3100NUOM1", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("110.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-16", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP0600NUOM", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("95.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-17", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP2900", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("71.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-18", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP0200", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("24.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-19", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP3300", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("28.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-20", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP1450", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("28.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-21", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP0400", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("125.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-22", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP1500NUOM1", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("107.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-23", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP0800", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("21.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-24", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP3218", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("63.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-25", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP1505NUOM", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("10.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-26", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWP3001", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("108.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-27", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWT1800", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("39.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-28", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWT1810", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("23.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-29", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWT1830", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("19.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-30", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWT1801", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("34.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-31", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWT1820", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("18.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-32", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWT1803", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("13.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-33", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ITEM").SetValue("S.WWT1804", true); // Item
		OEORD4detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD4detail1.Process();
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD4detail1Fields.FieldByName("QTYORDERED").SetValue("18.0000", true); // Quantity Ordered

		temp = OEORD4detail1.Exists;
		OEORD4detail1.Insert();
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;

		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-34", false); // Line Number

		OEORD4detail1.Read(true);
		temp = OEORD4detail1.Exists;
		temp = OEORD4detail1.Exists;
		OEORD4detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD4detail1.Exists;
		OEORD4detail1.Browse "", 0

OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-20", false); // Line Number

		OEORD4detail1.Read(true);
		OEORD4detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD4detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD4detail5.Read(true);

		OEORD4detail5Fields.FieldByName("VALIFBOOL").SetValue("1", true); // Yes/No Value

		temp = OEORD4detail5.Exists;
		OEORD4detail5.Update();

		OEORD4detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD4detail5.Read(true);

		OEORD4detail5Fields.FieldByName("VALIFTEXT").SetValue("WWTRANS", true); // Text Value

		OEORD4detail5.Update();

		OEORD4detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD4detail5.Read(true);
		OEORD4headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command

		OEORD4headerFields.FieldByName("REFERENCE").SetValue("WW PORTAL", false); // Order Reference
		OEORD4headerFields.FieldByName("DESC").SetValue("70300448 PRIMAL WC", false); // Order Description

		OEORD4header.Process();
		OEORD4header.Insert();
		OEORD4header.Order = 1;
		OEORD4header.Read(true);
		OEORD4header.Order = 0;
		OEORD4detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
		OEORD4detail1.Browse("", true);
		OEORD4detail1.Fetch(false);
		OEORD4detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

		OEORD4detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

		OEORD4detail9.Browse("", true);
		OEORD4detail9.Fetch(false);
		OEORD4detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
		OEORD4detail3.Browse("", true);
		OEORD4detail3.Fetch(false);
		OEORD4detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
		OEORD4detail2.Browse("", false);
		OEORD4detail2.Fetch(false);

		OEORD4detail2Fields.FieldByName("PAYMENT").SetValue("-1", false); // Payment Number
		OEORD4detail2.Browse("", true);

		OEORD4detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD4detail2.Browse("", false);
		OEORD4detail2.Fetch(false);
		temp = OEORD4header.Exists;

		Dim OEORD5header As AccpacCOMAPI.AccpacView
		Dim OEORD5headerFields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0520", OEORD5header
Set OEORD5headerFields = OEORD5header.Fields

Dim OEORD5detail1 As AccpacCOMAPI.AccpacView
Dim OEORD5detail1Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0500", OEORD5detail1
Set OEORD5detail1Fields = OEORD5detail1.Fields

Dim OEORD5detail2 As AccpacCOMAPI.AccpacView
Dim OEORD5detail2Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0740", OEORD5detail2
Set OEORD5detail2Fields = OEORD5detail2.Fields

Dim OEORD5detail3 As AccpacCOMAPI.AccpacView
Dim OEORD5detail3Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0180", OEORD5detail3
Set OEORD5detail3Fields = OEORD5detail3.Fields

Dim OEORD5detail4 As AccpacCOMAPI.AccpacView
Dim OEORD5detail4Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0526", OEORD5detail4
Set OEORD5detail4Fields = OEORD5detail4.Fields

Dim OEORD5detail5 As AccpacCOMAPI.AccpacView
Dim OEORD5detail5Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0522", OEORD5detail5
Set OEORD5detail5Fields = OEORD5detail5.Fields

Dim OEORD5detail6 As AccpacCOMAPI.AccpacView
Dim OEORD5detail6Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0508", OEORD5detail6
Set OEORD5detail6Fields = OEORD5detail6.Fields

Dim OEORD5detail7 As AccpacCOMAPI.AccpacView
Dim OEORD5detail7Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0507", OEORD5detail7
Set OEORD5detail7Fields = OEORD5detail7.Fields

Dim OEORD5detail8 As AccpacCOMAPI.AccpacView
Dim OEORD5detail8Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0501", OEORD5detail8
Set OEORD5detail8Fields = OEORD5detail8.Fields

Dim OEORD5detail9 As AccpacCOMAPI.AccpacView
Dim OEORD5detail9Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0502", OEORD5detail9
Set OEORD5detail9Fields = OEORD5detail9.Fields

Dim OEORD5detail10 As AccpacCOMAPI.AccpacView
Dim OEORD5detail10Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0504", OEORD5detail10
Set OEORD5detail10Fields = OEORD5detail10.Fields

Dim OEORD5detail11 As AccpacCOMAPI.AccpacView
Dim OEORD5detail11Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0506", OEORD5detail11
Set OEORD5detail11Fields = OEORD5detail11.Fields

Dim OEORD5detail12 As AccpacCOMAPI.AccpacView
Dim OEORD5detail12Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0503", OEORD5detail12
Set OEORD5detail12Fields = OEORD5detail12.Fields

OEORD5header.Compose Array(OEORD5detail1, Nothing, OEORD5detail3, OEORD5detail2, OEORD5detail4, OEORD5detail5)

OEORD5detail1.Compose Array(OEORD5header, OEORD5detail8, OEORD5detail12, OEORD5detail9, OEORD5detail6, OEORD5detail7)

OEORD5detail2.Compose Array(OEORD5header)

OEORD5detail3.Compose Array(OEORD5header, OEORD5detail1)

OEORD5detail4.Compose Array(OEORD5header)

OEORD5detail5.Compose Array(OEORD5header)

OEORD5detail6.Compose Array(OEORD5detail1)

OEORD5detail7.Compose Array(OEORD5detail1)

OEORD5detail8.Compose Array(OEORD5detail1)

OEORD5detail9.Compose Array(OEORD5detail1, OEORD5detail10, OEORD5detail11)

OEORD5detail10.Compose Array(OEORD5detail9)

OEORD5detail11.Compose Array(OEORD5detail9)

OEORD5detail12.Compose Array(OEORD5detail1)



OEORD5headerFields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI

		OEORD5detail1Fields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI
		OEORD5header.Cancel();
		OEORD5header.Cancel();
		OEORD5header.Init
OEORD5detail2.Browse("", true);
		OEORD5detail2.Fetch(false);
		OEORD5headerFields.FieldByName("CUSTOMER").SetValue("WOOL001", true); // Customer Number
		OEORD5detail2.Browse("", true);

		OEORD5detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD5detail2.Browse("", false);
		OEORD5detail2.Fetch(false);
		OEORD5headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command
		OEORD5header.Process();

		OEORD5headerFields.FieldByName("PONUMBER").SetValue("70300453 FOOD GTG", true); // Purchase Order Number
		OEORD5headerFields.FieldByName("REQUESDATE").SetValue(DateSerial(2025, 8, 6), true); // Date Requested
		OEORD5headerFields.FieldByName("EXPDATE").SetValue(DateSerial(2025, 8, 6), true); // Expected Ship Date

		OEORD5headerFields.FieldByName("SHIPTO").SetValue("WWGTG", true); // Ship-To Location Code
		OEORD5headerFields.FieldByName("GOFCALCTAX").SetValue("1", false); // Perform Forced Tax Calculation
		OEORD5headerFields.FieldByName("DESC").SetValue("70300453 FOOD GTG", false); // Order Description

		OEORD5header.Process();

		OEORD5headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command

		OEORD5header.Process();
		temp = OEORD5detail1.Exists;
		OEORD5detail1.RecordClear
		temp = OEORD5detail1.Exists;
		OEORD5detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD5detail1.Exists;

		OEORD5detail1Fields.FieldByName("ITEM").SetValue("S.WWP1875", true); // Item
		OEORD5detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD5detail1.Process();
		temp = OEORD5detail1.Exists;

		OEORD5detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD5detail1Fields.FieldByName("QTYORDERED").SetValue("28.0000", true); // Quantity Ordered

		temp = OEORD5detail1.Exists;
		OEORD5detail1.Insert();
		temp = OEORD5detail1.Exists;
		temp = OEORD5detail1.Exists;

		OEORD5detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD5detail1.Read(true);
		temp = OEORD5detail1.Exists;
		temp = OEORD5detail1.Exists;
		OEORD5detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD5detail1.Exists;

		OEORD5detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD5detail1.Read(true);
		OEORD5detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD5detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD5detail5.Read(true);

		OEORD5detail5Fields.FieldByName("VALIFBOOL").SetValue("1", true); // Yes/No Value

		temp = OEORD5detail5.Exists;
		OEORD5detail5.Update();

		OEORD5detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD5detail5.Read(true);

		OEORD5detail5Fields.FieldByName("VALIFTEXT").SetValue("WWTRANS", true); // Text Value

		OEORD5detail5.Update();

		OEORD5detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD5detail5.Read(true);
		OEORD5headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command

		OEORD5headerFields.FieldByName("REFERENCE").SetValue("WW PORTAL", false); // Order Reference

		OEORD5header.Process();
		OEORD5header.Insert();
		OEORD5header.Order = 1;
		OEORD5header.Read(true);
		OEORD5header.Order = 0;
		OEORD5detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
		OEORD5detail1.Browse("", true);
		OEORD5detail1.Fetch(false);
		OEORD5detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

		OEORD5detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

		OEORD5detail9.Browse("", true);
		OEORD5detail9.Fetch(false);
		OEORD5detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
		OEORD5detail3.Browse("", true);
		OEORD5detail3.Fetch(false);
		OEORD5detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
		OEORD5detail2.Browse("", false);
		OEORD5detail2.Fetch(false);

		OEORD5detail2Fields.FieldByName("PAYMENT").SetValue("-1", false); // Payment Number
		OEORD5detail2.Browse("", true);

		OEORD5detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD5detail2.Browse("", false);
		OEORD5detail2.Fetch(false);
		temp = OEORD5header.Exists;

		Dim OEORD6header As AccpacCOMAPI.AccpacView
		Dim OEORD6headerFields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0520", OEORD6header
Set OEORD6headerFields = OEORD6header.Fields

Dim OEORD6detail1 As AccpacCOMAPI.AccpacView
Dim OEORD6detail1Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0500", OEORD6detail1
Set OEORD6detail1Fields = OEORD6detail1.Fields

Dim OEORD6detail2 As AccpacCOMAPI.AccpacView
Dim OEORD6detail2Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0740", OEORD6detail2
Set OEORD6detail2Fields = OEORD6detail2.Fields

Dim OEORD6detail3 As AccpacCOMAPI.AccpacView
Dim OEORD6detail3Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0180", OEORD6detail3
Set OEORD6detail3Fields = OEORD6detail3.Fields

Dim OEORD6detail4 As AccpacCOMAPI.AccpacView
Dim OEORD6detail4Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0526", OEORD6detail4
Set OEORD6detail4Fields = OEORD6detail4.Fields

Dim OEORD6detail5 As AccpacCOMAPI.AccpacView
Dim OEORD6detail5Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0522", OEORD6detail5
Set OEORD6detail5Fields = OEORD6detail5.Fields

Dim OEORD6detail6 As AccpacCOMAPI.AccpacView
Dim OEORD6detail6Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0508", OEORD6detail6
Set OEORD6detail6Fields = OEORD6detail6.Fields

Dim OEORD6detail7 As AccpacCOMAPI.AccpacView
Dim OEORD6detail7Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0507", OEORD6detail7
Set OEORD6detail7Fields = OEORD6detail7.Fields

Dim OEORD6detail8 As AccpacCOMAPI.AccpacView
Dim OEORD6detail8Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0501", OEORD6detail8
Set OEORD6detail8Fields = OEORD6detail8.Fields

Dim OEORD6detail9 As AccpacCOMAPI.AccpacView
Dim OEORD6detail9Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0502", OEORD6detail9
Set OEORD6detail9Fields = OEORD6detail9.Fields

Dim OEORD6detail10 As AccpacCOMAPI.AccpacView
Dim OEORD6detail10Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0504", OEORD6detail10
Set OEORD6detail10Fields = OEORD6detail10.Fields

Dim OEORD6detail11 As AccpacCOMAPI.AccpacView
Dim OEORD6detail11Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0506", OEORD6detail11
Set OEORD6detail11Fields = OEORD6detail11.Fields

Dim OEORD6detail12 As AccpacCOMAPI.AccpacView
Dim OEORD6detail12Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0503", OEORD6detail12
Set OEORD6detail12Fields = OEORD6detail12.Fields

OEORD6header.Compose Array(OEORD6detail1, Nothing, OEORD6detail3, OEORD6detail2, OEORD6detail4, OEORD6detail5)

OEORD6detail1.Compose Array(OEORD6header, OEORD6detail8, OEORD6detail12, OEORD6detail9, OEORD6detail6, OEORD6detail7)

OEORD6detail2.Compose Array(OEORD6header)

OEORD6detail3.Compose Array(OEORD6header, OEORD6detail1)

OEORD6detail4.Compose Array(OEORD6header)

OEORD6detail5.Compose Array(OEORD6header)

OEORD6detail6.Compose Array(OEORD6detail1)

OEORD6detail7.Compose Array(OEORD6detail1)

OEORD6detail8.Compose Array(OEORD6detail1)

OEORD6detail9.Compose Array(OEORD6detail1, OEORD6detail10, OEORD6detail11)

OEORD6detail10.Compose Array(OEORD6detail9)

OEORD6detail11.Compose Array(OEORD6detail9)

OEORD6detail12.Compose Array(OEORD6detail1)



OEORD6headerFields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI

		OEORD6detail1Fields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI
		OEORD6header.Cancel();
		OEORD6header.Cancel();
		OEORD6header.Init
OEORD6detail2.Browse("", true);
		OEORD6detail2.Fetch(false);
		OEORD6headerFields.FieldByName("CUSTOMER").SetValue("WOOL001", true); // Customer Number
		OEORD6detail2.Browse("", true);

		OEORD6detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD6detail2.Browse("", false);
		OEORD6detail2.Fetch(false);
		OEORD6headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command
		OEORD6header.Process();

		OEORD6headerFields.FieldByName("PONUMBER").SetValue("70300455 HOT GTG", true); // Purchase Order Number
		OEORD6headerFields.FieldByName("REQUESDATE").SetValue(DateSerial(2025, 8, 6), true); // Date Requested
		OEORD6headerFields.FieldByName("EXPDATE").SetValue(DateSerial(2025, 8, 6), true); // Expected Ship Date

		OEORD6headerFields.FieldByName("SHIPTO").SetValue("WWGTG", true); // Ship-To Location Code
		OEORD6headerFields.FieldByName("GOFCALCTAX").SetValue("1", false); // Perform Forced Tax Calculation
		OEORD6headerFields.FieldByName("DESC").SetValue("70300455 HOT GTG", false); // Order Description

		OEORD6header.Process();

		OEORD6headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command

		OEORD6header.Process();
		temp = OEORD6detail1.Exists;
		OEORD6detail1.RecordClear
		temp = OEORD6detail1.Exists;
		OEORD6detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("ITEM").SetValue("S.WWP1605", true); // Item
		OEORD6detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD6detail1.Process();
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD6detail1Fields.FieldByName("QTYORDERED").SetValue("221.0000", true); // Quantity Ordered

		temp = OEORD6detail1.Exists;
		OEORD6detail1.Insert();
		temp = OEORD6detail1.Exists;
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD6detail1.Read(true);
		temp = OEORD6detail1.Exists;
		temp = OEORD6detail1.Exists;
		OEORD6detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("ITEM").SetValue("S.WWP1603", true); // Item
		OEORD6detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD6detail1.Process();
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD6detail1Fields.FieldByName("QTYORDERED").SetValue("90.0000", true); // Quantity Ordered

		temp = OEORD6detail1.Exists;
		OEORD6detail1.Insert();
		temp = OEORD6detail1.Exists;
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("LINENUM").SetValue("-2", false); // Line Number

		OEORD6detail1.Read(true);
		temp = OEORD6detail1.Exists;
		temp = OEORD6detail1.Exists;
		OEORD6detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("ITEM").SetValue("S.WWV1988", true); // Item
		OEORD6detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD6detail1.Process();
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD6detail1Fields.FieldByName("QTYORDERED").SetValue("102.0000", true); // Quantity Ordered

		temp = OEORD6detail1.Exists;
		OEORD6detail1.Insert();
		temp = OEORD6detail1.Exists;
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("LINENUM").SetValue("-3", false); // Line Number

		OEORD6detail1.Read(true);
		temp = OEORD6detail1.Exists;
		temp = OEORD6detail1.Exists;
		OEORD6detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("ITEM").SetValue("S.WWV0330", true); // Item
		OEORD6detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD6detail1.Process();
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD6detail1Fields.FieldByName("QTYORDERED").SetValue("7.0000", true); // Quantity Ordered

		temp = OEORD6detail1.Exists;
		OEORD6detail1.Insert();
		temp = OEORD6detail1.Exists;
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("LINENUM").SetValue("-4", false); // Line Number

		OEORD6detail1.Read(true);
		temp = OEORD6detail1.Exists;
		temp = OEORD6detail1.Exists;
		OEORD6detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD6detail1.Exists;

		OEORD6detail1Fields.FieldByName("LINENUM").SetValue("-4", false); // Line Number

		OEORD6detail1.Read(true);
		OEORD6detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD6detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD6detail5.Read(true);

		OEORD6detail5Fields.FieldByName("VALIFBOOL").SetValue("1", true); // Yes/No Value

		temp = OEORD6detail5.Exists;
		OEORD6detail5.Update();

		OEORD6detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD6detail5.Read(true);

		OEORD6detail5Fields.FieldByName("VALIFTEXT").SetValue("WWTRANS", true); // Text Value

		OEORD6detail5.Update();

		OEORD6detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD6detail5.Read(true);
		OEORD6headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command

		OEORD6headerFields.FieldByName("REFERENCE").SetValue("WW PORTAL", false); // Order Reference

		OEORD6header.Process();
		OEORD6header.Insert();
		OEORD6header.Order = 1;
		OEORD6header.Read(true);
		OEORD6header.Order = 0;
		OEORD6detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
		OEORD6detail1.Browse("", true);
		OEORD6detail1.Fetch(false);
		OEORD6detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

		OEORD6detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

		OEORD6detail9.Browse("", true);
		OEORD6detail9.Fetch(false);
		OEORD6detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
		OEORD6detail3.Browse("", true);
		OEORD6detail3.Fetch(false);
		OEORD6detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
		OEORD6detail2.Browse("", false);
		OEORD6detail2.Fetch(false);

		OEORD6detail2Fields.FieldByName("PAYMENT").SetValue("-1", false); // Payment Number
		OEORD6detail2.Browse("", true);

		OEORD6detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD6detail2.Browse("", false);
		OEORD6detail2.Fetch(false);
		temp = OEORD6header.Exists;

		Dim OEORD7header As AccpacCOMAPI.AccpacView
		Dim OEORD7headerFields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0520", OEORD7header
Set OEORD7headerFields = OEORD7header.Fields

Dim OEORD7detail1 As AccpacCOMAPI.AccpacView
Dim OEORD7detail1Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0500", OEORD7detail1
Set OEORD7detail1Fields = OEORD7detail1.Fields

Dim OEORD7detail2 As AccpacCOMAPI.AccpacView
Dim OEORD7detail2Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0740", OEORD7detail2
Set OEORD7detail2Fields = OEORD7detail2.Fields

Dim OEORD7detail3 As AccpacCOMAPI.AccpacView
Dim OEORD7detail3Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0180", OEORD7detail3
Set OEORD7detail3Fields = OEORD7detail3.Fields

Dim OEORD7detail4 As AccpacCOMAPI.AccpacView
Dim OEORD7detail4Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0526", OEORD7detail4
Set OEORD7detail4Fields = OEORD7detail4.Fields

Dim OEORD7detail5 As AccpacCOMAPI.AccpacView
Dim OEORD7detail5Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0522", OEORD7detail5
Set OEORD7detail5Fields = OEORD7detail5.Fields

Dim OEORD7detail6 As AccpacCOMAPI.AccpacView
Dim OEORD7detail6Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0508", OEORD7detail6
Set OEORD7detail6Fields = OEORD7detail6.Fields

Dim OEORD7detail7 As AccpacCOMAPI.AccpacView
Dim OEORD7detail7Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0507", OEORD7detail7
Set OEORD7detail7Fields = OEORD7detail7.Fields

Dim OEORD7detail8 As AccpacCOMAPI.AccpacView
Dim OEORD7detail8Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0501", OEORD7detail8
Set OEORD7detail8Fields = OEORD7detail8.Fields

Dim OEORD7detail9 As AccpacCOMAPI.AccpacView
Dim OEORD7detail9Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0502", OEORD7detail9
Set OEORD7detail9Fields = OEORD7detail9.Fields

Dim OEORD7detail10 As AccpacCOMAPI.AccpacView
Dim OEORD7detail10Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0504", OEORD7detail10
Set OEORD7detail10Fields = OEORD7detail10.Fields

Dim OEORD7detail11 As AccpacCOMAPI.AccpacView
Dim OEORD7detail11Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0506", OEORD7detail11
Set OEORD7detail11Fields = OEORD7detail11.Fields

Dim OEORD7detail12 As AccpacCOMAPI.AccpacView
Dim OEORD7detail12Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0503", OEORD7detail12
Set OEORD7detail12Fields = OEORD7detail12.Fields

OEORD7header.Compose Array(OEORD7detail1, Nothing, OEORD7detail3, OEORD7detail2, OEORD7detail4, OEORD7detail5)

OEORD7detail1.Compose Array(OEORD7header, OEORD7detail8, OEORD7detail12, OEORD7detail9, OEORD7detail6, OEORD7detail7)

OEORD7detail2.Compose Array(OEORD7header)

OEORD7detail3.Compose Array(OEORD7header, OEORD7detail1)

OEORD7detail4.Compose Array(OEORD7header)

OEORD7detail5.Compose Array(OEORD7header)

OEORD7detail6.Compose Array(OEORD7detail1)

OEORD7detail7.Compose Array(OEORD7detail1)

OEORD7detail8.Compose Array(OEORD7detail1)

OEORD7detail9.Compose Array(OEORD7detail1, OEORD7detail10, OEORD7detail11)

OEORD7detail10.Compose Array(OEORD7detail9)

OEORD7detail11.Compose Array(OEORD7detail9)

OEORD7detail12.Compose Array(OEORD7detail1)



OEORD7headerFields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI

		OEORD7detail1Fields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI
		OEORD7header.Cancel();
		OEORD7header.Cancel();
		OEORD7header.Init
OEORD7detail2.Browse("", true);
		OEORD7detail2.Fetch(false);
		OEORD7headerFields.FieldByName("CUSTOMER").SetValue("WOOL001", true); // Customer Number
		OEORD7detail2.Browse("", true);

		OEORD7detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD7detail2.Browse("", false);
		OEORD7detail2.Fetch(false);
		OEORD7headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command
		OEORD7header.Process();

		OEORD7headerFields.FieldByName("PONUMBER").SetValue("70300457 PRIMAL GTG", true); // Purchase Order Number
		OEORD7headerFields.FieldByName("REQUESDATE").SetValue(DateSerial(2025, 8, 6), true); // Date Requested
		OEORD7headerFields.FieldByName("EXPDATE").SetValue(DateSerial(2025, 8, 6), true); // Expected Ship Date

		OEORD7headerFields.FieldByName("SHIPTO").SetValue("WWGTG", true); // Ship-To Location Code
		OEORD7headerFields.FieldByName("GOFCALCTAX").SetValue("1", false); // Perform Forced Tax Calculation
		OEORD7headerFields.FieldByName("DESC").SetValue("70300457 PRIMAL GTG", false); // Order Description

		OEORD7header.Process();

		OEORD7headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command

		OEORD7header.Process();
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordClear
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ITEM").SetValue("S.WWV0110", true); // Item
		OEORD7detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD7detail1.Process();
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD7detail1Fields.FieldByName("QTYORDERED").SetValue("56.0000", true); // Quantity Ordered

		temp = OEORD7detail1.Exists;
		OEORD7detail1.Insert();
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD7detail1.Read(true);
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ITEM").SetValue("S.WWV0111", true); // Item
		OEORD7detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD7detail1.Process();
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD7detail1Fields.FieldByName("QTYORDERED").SetValue("35.0000", true); // Quantity Ordered

		temp = OEORD7detail1.Exists;
		OEORD7detail1.Insert();
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-2", false); // Line Number

		OEORD7detail1.Read(true);
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ITEM").SetValue("S.WWV0112", true); // Item
		OEORD7detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD7detail1.Process();
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD7detail1Fields.FieldByName("QTYORDERED").SetValue("31.0000", true); // Quantity Ordered

		temp = OEORD7detail1.Exists;
		OEORD7detail1.Insert();
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-3", false); // Line Number

		OEORD7detail1.Read(true);
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ITEM").SetValue("S.WWV0805", true); // Item
		OEORD7detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD7detail1.Process();
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD7detail1Fields.FieldByName("QTYORDERED").SetValue("54.0000", true); // Quantity Ordered

		temp = OEORD7detail1.Exists;
		OEORD7detail1.Insert();
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-4", false); // Line Number

		OEORD7detail1.Read(true);
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ITEM").SetValue("S.WWV0810", true); // Item
		OEORD7detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD7detail1.Process();
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD7detail1Fields.FieldByName("QTYORDERED").SetValue("27.0000", true); // Quantity Ordered

		temp = OEORD7detail1.Exists;
		OEORD7detail1.Insert();
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-5", false); // Line Number

		OEORD7detail1.Read(true);
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ITEM").SetValue("S.WWV0655", true); // Item
		OEORD7detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD7detail1.Process();
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD7detail1Fields.FieldByName("QTYORDERED").SetValue("49.0000", true); // Quantity Ordered

		temp = OEORD7detail1.Exists;
		OEORD7detail1.Insert();
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-6", false); // Line Number

		OEORD7detail1.Read(true);
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ITEM").SetValue("S.WWV0656", true); // Item
		OEORD7detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD7detail1.Process();
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD7detail1Fields.FieldByName("QTYORDERED").SetValue("29.0000", true); // Quantity Ordered

		temp = OEORD7detail1.Exists;
		OEORD7detail1.Insert();
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-7", false); // Line Number

		OEORD7detail1.Read(true);
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ITEM").SetValue("S.WWT1810", true); // Item
		OEORD7detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD7detail1.Process();
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD7detail1Fields.FieldByName("QTYORDERED").SetValue("15.0000", true); // Quantity Ordered

		temp = OEORD7detail1.Exists;
		OEORD7detail1.Insert();
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-8", false); // Line Number

		OEORD7detail1.Read(true);
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ITEM").SetValue("S.WWT1830", true); // Item
		OEORD7detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD7detail1.Process();
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD7detail1Fields.FieldByName("QTYORDERED").SetValue("6.0000", true); // Quantity Ordered

		temp = OEORD7detail1.Exists;
		OEORD7detail1.Insert();
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-9", false); // Line Number

		OEORD7detail1.Read(true);
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ITEM").SetValue("S.WWT1820", true); // Item
		OEORD7detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD7detail1.Process();
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD7detail1Fields.FieldByName("QTYORDERED").SetValue("7.0000", true); // Quantity Ordered

		temp = OEORD7detail1.Exists;
		OEORD7detail1.Insert();
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-10", false); // Line Number

		OEORD7detail1.Read(true);
		temp = OEORD7detail1.Exists;
		temp = OEORD7detail1.Exists;
		OEORD7detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD7detail1.Exists;
		OEORD7detail1.Browse("", true);

		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-10", false); // Line Number

		OEORD7detail1.Read(true);
		OEORD7detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD7detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD7detail5.Read(true);

		OEORD7detail5Fields.FieldByName("VALIFBOOL").SetValue("1", true); // Yes/No Value

		temp = OEORD7detail5.Exists;
		OEORD7detail5.Update();

		OEORD7detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD7detail5.Read(true);

		OEORD7detail5Fields.FieldByName("VALIFTEXT").SetValue("WWTRANS", true); // Text Value

		OEORD7detail5.Update();

		OEORD7detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD7detail5.Read(true);
		OEORD7headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command

		OEORD7headerFields.FieldByName("REFERENCE").SetValue("WW PORTAL", false); // Order Reference

		OEORD7header.Process();
		OEORD7header.Insert();
		OEORD7header.Order = 1;
		OEORD7header.Read(true);
		OEORD7header.Order = 0;
		OEORD7detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
		OEORD7detail1.Browse("", true);
		OEORD7detail1.Fetch(false);
		OEORD7detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

		OEORD7detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

		OEORD7detail9.Browse("", true);
		OEORD7detail9.Fetch(false);
		OEORD7detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
		OEORD7detail3.Browse("", true);
		OEORD7detail3.Fetch(false);
		OEORD7detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
		OEORD7detail2.Browse("", false);
		OEORD7detail2.Fetch(false);

		OEORD7detail2Fields.FieldByName("PAYMENT").SetValue("-1", false); // Payment Number
		OEORD7detail2.Browse("", true);

		OEORD7detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD7detail2.Browse("", false);
		OEORD7detail2.Fetch(false);
		temp = OEORD7header.Exists;

		Dim OEORD8header As AccpacCOMAPI.AccpacView
		Dim OEORD8headerFields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0520", OEORD8header
Set OEORD8headerFields = OEORD8header.Fields

Dim OEORD8detail1 As AccpacCOMAPI.AccpacView
Dim OEORD8detail1Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0500", OEORD8detail1
Set OEORD8detail1Fields = OEORD8detail1.Fields

Dim OEORD8detail2 As AccpacCOMAPI.AccpacView
Dim OEORD8detail2Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0740", OEORD8detail2
Set OEORD8detail2Fields = OEORD8detail2.Fields

Dim OEORD8detail3 As AccpacCOMAPI.AccpacView
Dim OEORD8detail3Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0180", OEORD8detail3
Set OEORD8detail3Fields = OEORD8detail3.Fields

Dim OEORD8detail4 As AccpacCOMAPI.AccpacView
Dim OEORD8detail4Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0526", OEORD8detail4
Set OEORD8detail4Fields = OEORD8detail4.Fields

Dim OEORD8detail5 As AccpacCOMAPI.AccpacView
Dim OEORD8detail5Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0522", OEORD8detail5
Set OEORD8detail5Fields = OEORD8detail5.Fields

Dim OEORD8detail6 As AccpacCOMAPI.AccpacView
Dim OEORD8detail6Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0508", OEORD8detail6
Set OEORD8detail6Fields = OEORD8detail6.Fields

Dim OEORD8detail7 As AccpacCOMAPI.AccpacView
Dim OEORD8detail7Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0507", OEORD8detail7
Set OEORD8detail7Fields = OEORD8detail7.Fields

Dim OEORD8detail8 As AccpacCOMAPI.AccpacView
Dim OEORD8detail8Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0501", OEORD8detail8
Set OEORD8detail8Fields = OEORD8detail8.Fields

Dim OEORD8detail9 As AccpacCOMAPI.AccpacView
Dim OEORD8detail9Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0502", OEORD8detail9
Set OEORD8detail9Fields = OEORD8detail9.Fields

Dim OEORD8detail10 As AccpacCOMAPI.AccpacView
Dim OEORD8detail10Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0504", OEORD8detail10
Set OEORD8detail10Fields = OEORD8detail10.Fields

Dim OEORD8detail11 As AccpacCOMAPI.AccpacView
Dim OEORD8detail11Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0506", OEORD8detail11
Set OEORD8detail11Fields = OEORD8detail11.Fields

Dim OEORD8detail12 As AccpacCOMAPI.AccpacView
Dim OEORD8detail12Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0503", OEORD8detail12
Set OEORD8detail12Fields = OEORD8detail12.Fields

OEORD8header.Compose Array(OEORD8detail1, Nothing, OEORD8detail3, OEORD8detail2, OEORD8detail4, OEORD8detail5)

OEORD8detail1.Compose Array(OEORD8header, OEORD8detail8, OEORD8detail12, OEORD8detail9, OEORD8detail6, OEORD8detail7)

OEORD8detail2.Compose Array(OEORD8header)

OEORD8detail3.Compose Array(OEORD8header, OEORD8detail1)

OEORD8detail4.Compose Array(OEORD8header)

OEORD8detail5.Compose Array(OEORD8header)

OEORD8detail6.Compose Array(OEORD8detail1)

OEORD8detail7.Compose Array(OEORD8detail1)

OEORD8detail8.Compose Array(OEORD8detail1)

OEORD8detail9.Compose Array(OEORD8detail1, OEORD8detail10, OEORD8detail11)

OEORD8detail10.Compose Array(OEORD8detail9)

OEORD8detail11.Compose Array(OEORD8detail9)

OEORD8detail12.Compose Array(OEORD8detail1)



OEORD8headerFields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI

		OEORD8detail1Fields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI
		OEORD8header.Cancel();
		OEORD8header.Cancel();
		OEORD8header.Init
OEORD8detail2.Browse("", true);
		OEORD8detail2.Fetch(false);
		OEORD8headerFields.FieldByName("CUSTOMER").SetValue("WOOL001", true); // Customer Number
		OEORD8detail2.Browse("", true);

		OEORD8detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD8detail2.Browse("", false);
		OEORD8detail2.Fetch(false);
		OEORD8headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command
		OEORD8header.Process();

		OEORD8headerFields.FieldByName("PONUMBER").SetValue("70300461 FOOD KZN", true); // Purchase Order Number
		OEORD8headerFields.FieldByName("REQUESDATE").SetValue(DateSerial(2025, 8, 6), true); // Date Requested
		OEORD8headerFields.FieldByName("EXPDATE").SetValue(DateSerial(2025, 8, 6), true); // Expected Ship Date

		OEORD8headerFields.FieldByName("SHIPTO").SetValue("WWKZN", true); // Ship-To Location Code
		OEORD8headerFields.FieldByName("GOFCALCTAX").SetValue("1", false); // Perform Forced Tax Calculation
		OEORD8headerFields.FieldByName("DESC").SetValue("70300461 FOOD KZN", false); // Order Description

		OEORD8header.Process();

		OEORD8headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command

		OEORD8header.Process();
		temp = OEORD8detail1.Exists;
		OEORD8detail1.RecordClear
		temp = OEORD8detail1.Exists;
		OEORD8detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD8detail1.Exists;

		OEORD8detail1Fields.FieldByName("ITEM").SetValue("S.WWP1875", true); // Item
		OEORD8detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD8detail1.Process();
		temp = OEORD8detail1.Exists;

		OEORD8detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD8detail1Fields.FieldByName("QTYORDERED").SetValue("3.0000", true); // Quantity Ordered

		temp = OEORD8detail1.Exists;
		OEORD8detail1.Insert();
		temp = OEORD8detail1.Exists;
		temp = OEORD8detail1.Exists;

		OEORD8detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD8detail1.Read(true);
		temp = OEORD8detail1.Exists;
		temp = OEORD8detail1.Exists;
		OEORD8detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD8detail1.Exists;

		OEORD8detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD8detail1.Read(true);
		OEORD8detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD8detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD8detail5.Read(true);

		OEORD8detail5Fields.FieldByName("VALIFBOOL").SetValue("1", true); // Yes/No Value

		temp = OEORD8detail5.Exists;
		OEORD8detail5.Update();

		OEORD8detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD8detail5.Read(true);

		OEORD8detail5Fields.FieldByName("VALIFTEXT").SetValue("WWTRANS", true); // Text Value

		OEORD8detail5.Update();

		OEORD8detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD8detail5.Read(true);
		OEORD8headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command

		OEORD8headerFields.FieldByName("REFERENCE").SetValue("WW PORTAL", false); // Order Reference

		OEORD8header.Process();
		OEORD8header.Insert();
		OEORD8header.Order = 1;
		OEORD8header.Read(true);
		OEORD8header.Order = 0;
		OEORD8detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
		OEORD8detail1.Browse("", true);
		OEORD8detail1.Fetch(false);
		OEORD8detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

		OEORD8detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

		OEORD8detail9.Browse("", true);
		OEORD8detail9.Fetch(false);
		OEORD8detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
		OEORD8detail3.Browse("", true);
		OEORD8detail3.Fetch(false);
		OEORD8detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
		OEORD8detail2.Browse("", false);
		OEORD8detail2.Fetch(false);

		OEORD8detail2Fields.FieldByName("PAYMENT").SetValue("-1", false); // Payment Number
		OEORD8detail2.Browse("", true);

		OEORD8detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD8detail2.Browse("", false);
		OEORD8detail2.Fetch(false);
		temp = OEORD8header.Exists;

		Dim OEORD9header As AccpacCOMAPI.AccpacView
		Dim OEORD9headerFields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0520", OEORD9header
Set OEORD9headerFields = OEORD9header.Fields

Dim OEORD9detail1 As AccpacCOMAPI.AccpacView
Dim OEORD9detail1Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0500", OEORD9detail1
Set OEORD9detail1Fields = OEORD9detail1.Fields

Dim OEORD9detail2 As AccpacCOMAPI.AccpacView
Dim OEORD9detail2Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0740", OEORD9detail2
Set OEORD9detail2Fields = OEORD9detail2.Fields

Dim OEORD9detail3 As AccpacCOMAPI.AccpacView
Dim OEORD9detail3Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0180", OEORD9detail3
Set OEORD9detail3Fields = OEORD9detail3.Fields

Dim OEORD9detail4 As AccpacCOMAPI.AccpacView
Dim OEORD9detail4Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0526", OEORD9detail4
Set OEORD9detail4Fields = OEORD9detail4.Fields

Dim OEORD9detail5 As AccpacCOMAPI.AccpacView
Dim OEORD9detail5Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0522", OEORD9detail5
Set OEORD9detail5Fields = OEORD9detail5.Fields

Dim OEORD9detail6 As AccpacCOMAPI.AccpacView
Dim OEORD9detail6Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0508", OEORD9detail6
Set OEORD9detail6Fields = OEORD9detail6.Fields

Dim OEORD9detail7 As AccpacCOMAPI.AccpacView
Dim OEORD9detail7Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0507", OEORD9detail7
Set OEORD9detail7Fields = OEORD9detail7.Fields

Dim OEORD9detail8 As AccpacCOMAPI.AccpacView
Dim OEORD9detail8Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0501", OEORD9detail8
Set OEORD9detail8Fields = OEORD9detail8.Fields

Dim OEORD9detail9 As AccpacCOMAPI.AccpacView
Dim OEORD9detail9Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0502", OEORD9detail9
Set OEORD9detail9Fields = OEORD9detail9.Fields

Dim OEORD9detail10 As AccpacCOMAPI.AccpacView
Dim OEORD9detail10Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0504", OEORD9detail10
Set OEORD9detail10Fields = OEORD9detail10.Fields

Dim OEORD9detail11 As AccpacCOMAPI.AccpacView
Dim OEORD9detail11Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0506", OEORD9detail11
Set OEORD9detail11Fields = OEORD9detail11.Fields

Dim OEORD9detail12 As AccpacCOMAPI.AccpacView
Dim OEORD9detail12Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0503", OEORD9detail12
Set OEORD9detail12Fields = OEORD9detail12.Fields

OEORD9header.Compose Array(OEORD9detail1, Nothing, OEORD9detail3, OEORD9detail2, OEORD9detail4, OEORD9detail5)

OEORD9detail1.Compose Array(OEORD9header, OEORD9detail8, OEORD9detail12, OEORD9detail9, OEORD9detail6, OEORD9detail7)

OEORD9detail2.Compose Array(OEORD9header)

OEORD9detail3.Compose Array(OEORD9header, OEORD9detail1)

OEORD9detail4.Compose Array(OEORD9header)

OEORD9detail5.Compose Array(OEORD9header)

OEORD9detail6.Compose Array(OEORD9detail1)

OEORD9detail7.Compose Array(OEORD9detail1)

OEORD9detail8.Compose Array(OEORD9detail1)

OEORD9detail9.Compose Array(OEORD9detail1, OEORD9detail10, OEORD9detail11)

OEORD9detail10.Compose Array(OEORD9detail9)

OEORD9detail11.Compose Array(OEORD9detail9)

OEORD9detail12.Compose Array(OEORD9detail1)



OEORD9headerFields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI

		OEORD9detail1Fields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI
		OEORD9header.Cancel();
		OEORD9header.Cancel();
		OEORD9header.Init
OEORD9detail2.Browse("", true);
		OEORD9detail2.Fetch(false);
		OEORD9headerFields.FieldByName("CUSTOMER").SetValue("WOOL001", true); // Customer Number
		OEORD9detail2.Browse("", true);

		OEORD9detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD9detail2.Browse("", false);
		OEORD9detail2.Fetch(false);
		OEORD9headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command
		OEORD9header.Process();

		OEORD9headerFields.FieldByName("PONUMBER").SetValue("70300462 HOT KZN", true); // Purchase Order Number

		OEORD9headerFields.FieldByName("SHIPTO").SetValue("WWKZN", true); // Ship-To Location Code
		OEORD9headerFields.FieldByName("GOFCALCTAX").SetValue("1", false); // Perform Forced Tax Calculation
		OEORD9headerFields.FieldByName("DESC").SetValue("70300462 HOT KZN", false); // Order Description

		OEORD9header.Process();

		OEORD9headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command

		OEORD9header.Process();

		OEORD9headerFields.FieldByName("REQUESDATE").SetValue(DateSerial(2025, 8, 6), true); // Date Requested
		OEORD9headerFields.FieldByName("EXPDATE").SetValue(DateSerial(2025, 8, 6), true); // Expected Ship Date
		temp = OEORD9detail1.Exists;
		OEORD9detail1.RecordClear
		temp = OEORD9detail1.Exists;
		OEORD9detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD9detail1.Exists;

		OEORD9detail1Fields.FieldByName("ITEM").SetValue("S.WWP1603", true); // Item
		OEORD9detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD9detail1.Process();
		temp = OEORD9detail1.Exists;

		OEORD9detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD9detail1Fields.FieldByName("QTYORDERED").SetValue("7.0000", true); // Quantity Ordered

		temp = OEORD9detail1.Exists;
		OEORD9detail1.Insert();
		temp = OEORD9detail1.Exists;
		temp = OEORD9detail1.Exists;

		OEORD9detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD9detail1.Read(true);
		temp = OEORD9detail1.Exists;
		temp = OEORD9detail1.Exists;
		OEORD9detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD9detail1.Exists;

		OEORD9detail1Fields.FieldByName("ITEM").SetValue("S.WWV1988", true); // Item
		OEORD9detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD9detail1.Process();
		temp = OEORD9detail1.Exists;

		OEORD9detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD9detail1Fields.FieldByName("QTYORDERED").SetValue("26.0000", true); // Quantity Ordered

		temp = OEORD9detail1.Exists;
		OEORD9detail1.Insert();
		temp = OEORD9detail1.Exists;
		temp = OEORD9detail1.Exists;

		OEORD9detail1Fields.FieldByName("LINENUM").SetValue("-2", false); // Line Number

		OEORD9detail1.Read(true);
		temp = OEORD9detail1.Exists;
		temp = OEORD9detail1.Exists;
		OEORD9detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD9detail1.Exists;

		OEORD9detail1Fields.FieldByName("LINENUM").SetValue("-2", false); // Line Number

		OEORD9detail1.Read(true);
		OEORD9detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD9detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD9detail5.Read(true);

		OEORD9detail5Fields.FieldByName("VALIFBOOL").SetValue("1", true); // Yes/No Value

		temp = OEORD9detail5.Exists;
		OEORD9detail5.Update();

		OEORD9detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD9detail5.Read(true);

		OEORD9detail5Fields.FieldByName("VALIFTEXT").SetValue("WWTRANS", true); // Text Value

		OEORD9detail5.Update();

		OEORD9detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD9detail5.Read(true);
		OEORD9headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command

		OEORD9headerFields.FieldByName("REFERENCE").SetValue("WW PORTAL", false); // Order Reference

		OEORD9header.Process();
		OEORD9header.Insert();
		OEORD9header.Order = 1;
		OEORD9header.Read(true);
		OEORD9header.Order = 0;
		OEORD9detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
		OEORD9detail1.Browse("", true);
		OEORD9detail1.Fetch(false);
		OEORD9detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

		OEORD9detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

		OEORD9detail9.Browse("", true);
		OEORD9detail9.Fetch(false);
		OEORD9detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
		OEORD9detail3.Browse("", true);
		OEORD9detail3.Fetch(false);
		OEORD9detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
		OEORD9detail2.Browse("", false);
		OEORD9detail2.Fetch(false);

		OEORD9detail2Fields.FieldByName("PAYMENT").SetValue("-1", false); // Payment Number
		OEORD9detail2.Browse("", true);

		OEORD9detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD9detail2.Browse("", false);
		OEORD9detail2.Fetch(false);
		temp = OEORD9header.Exists;

		Dim OEORD10header As AccpacCOMAPI.AccpacView
		Dim OEORD10headerFields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0520", OEORD10header
Set OEORD10headerFields = OEORD10header.Fields

Dim OEORD10detail1 As AccpacCOMAPI.AccpacView
Dim OEORD10detail1Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0500", OEORD10detail1
Set OEORD10detail1Fields = OEORD10detail1.Fields

Dim OEORD10detail2 As AccpacCOMAPI.AccpacView
Dim OEORD10detail2Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0740", OEORD10detail2
Set OEORD10detail2Fields = OEORD10detail2.Fields

Dim OEORD10detail3 As AccpacCOMAPI.AccpacView
Dim OEORD10detail3Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0180", OEORD10detail3
Set OEORD10detail3Fields = OEORD10detail3.Fields

Dim OEORD10detail4 As AccpacCOMAPI.AccpacView
Dim OEORD10detail4Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0526", OEORD10detail4
Set OEORD10detail4Fields = OEORD10detail4.Fields

Dim OEORD10detail5 As AccpacCOMAPI.AccpacView
Dim OEORD10detail5Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0522", OEORD10detail5
Set OEORD10detail5Fields = OEORD10detail5.Fields

Dim OEORD10detail6 As AccpacCOMAPI.AccpacView
Dim OEORD10detail6Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0508", OEORD10detail6
Set OEORD10detail6Fields = OEORD10detail6.Fields

Dim OEORD10detail7 As AccpacCOMAPI.AccpacView
Dim OEORD10detail7Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0507", OEORD10detail7
Set OEORD10detail7Fields = OEORD10detail7.Fields

Dim OEORD10detail8 As AccpacCOMAPI.AccpacView
Dim OEORD10detail8Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0501", OEORD10detail8
Set OEORD10detail8Fields = OEORD10detail8.Fields

Dim OEORD10detail9 As AccpacCOMAPI.AccpacView
Dim OEORD10detail9Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0502", OEORD10detail9
Set OEORD10detail9Fields = OEORD10detail9.Fields

Dim OEORD10detail10 As AccpacCOMAPI.AccpacView
Dim OEORD10detail10Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0504", OEORD10detail10
Set OEORD10detail10Fields = OEORD10detail10.Fields

Dim OEORD10detail11 As AccpacCOMAPI.AccpacView
Dim OEORD10detail11Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0506", OEORD10detail11
Set OEORD10detail11Fields = OEORD10detail11.Fields

Dim OEORD10detail12 As AccpacCOMAPI.AccpacView
Dim OEORD10detail12Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0503", OEORD10detail12
Set OEORD10detail12Fields = OEORD10detail12.Fields

OEORD10header.Compose Array(OEORD10detail1, Nothing, OEORD10detail3, OEORD10detail2, OEORD10detail4, OEORD10detail5)

OEORD10detail1.Compose Array(OEORD10header, OEORD10detail8, OEORD10detail12, OEORD10detail9, OEORD10detail6, OEORD10detail7)

OEORD10detail2.Compose Array(OEORD10header)

OEORD10detail3.Compose Array(OEORD10header, OEORD10detail1)

OEORD10detail4.Compose Array(OEORD10header)

OEORD10detail5.Compose Array(OEORD10header)

OEORD10detail6.Compose Array(OEORD10detail1)

OEORD10detail7.Compose Array(OEORD10detail1)

OEORD10detail8.Compose Array(OEORD10detail1)

OEORD10detail9.Compose Array(OEORD10detail1, OEORD10detail10, OEORD10detail11)

OEORD10detail10.Compose Array(OEORD10detail9)

OEORD10detail11.Compose Array(OEORD10detail9)

OEORD10detail12.Compose Array(OEORD10detail1)



OEORD10headerFields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI

		OEORD10detail1Fields.FieldByName("DRIVENBYUI").SetValue("1", true); // Driven by UI
		OEORD10header.Cancel();
		OEORD10header.Cancel();
		OEORD10header.Init
OEORD10detail2.Browse("", true);
		OEORD10detail2.Fetch(false);
		OEORD10headerFields.FieldByName("CUSTOMER").SetValue("WOOL001", true); // Customer Number
		OEORD10detail2.Browse("", true);

		OEORD10detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD10detail2.Browse("", false);
		OEORD10detail2.Fetch(false);
		OEORD10headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command
		OEORD10header.Process();

		OEORD10headerFields.FieldByName("PONUMBER").SetValue("70300464 PRIMAL KZN", true); // Purchase Order Number
		OEORD10headerFields.FieldByName("REQUESDATE").SetValue(DateSerial(2025, 8, 6), true); // Date Requested
		OEORD10headerFields.FieldByName("EXPDATE").SetValue(DateSerial(2025, 8, 6), true); // Expected Ship Date

		OEORD10headerFields.FieldByName("SHIPTO").SetValue("WWKZN", true); // Ship-To Location Code
		OEORD10headerFields.FieldByName("GOFCALCTAX").SetValue("1", false); // Perform Forced Tax Calculation
		OEORD10headerFields.FieldByName("DESC").SetValue("70300464 PRIMAL KZN", false); // Order Description

		OEORD10header.Process();

		OEORD10headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command

		OEORD10header.Process();
		temp = OEORD10detail1.Exists;
		OEORD10detail1.RecordClear
		temp = OEORD10detail1.Exists;
		OEORD10detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ITEM").SetValue("S.WWV0110", true); // Item
		OEORD10detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD10detail1.Process();
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD10detail1Fields.FieldByName("QTYORDERED").SetValue("16.0000", true); // Quantity Ordered

		temp = OEORD10detail1.Exists;
		OEORD10detail1.Insert();
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

		OEORD10detail1.Read(true);
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;
		OEORD10detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ITEM").SetValue("S.WWV0111", true); // Item
		OEORD10detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD10detail1.Process();
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD10detail1Fields.FieldByName("QTYORDERED").SetValue("13.0000", true); // Quantity Ordered

		temp = OEORD10detail1.Exists;
		OEORD10detail1.Insert();
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("LINENUM").SetValue("-2", false); // Line Number

		OEORD10detail1.Read(true);
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;
		OEORD10detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ITEM").SetValue("S.WWV0112", true); // Item
		OEORD10detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD10detail1.Process();
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD10detail1Fields.FieldByName("QTYORDERED").SetValue("5.0000", true); // Quantity Ordered

		temp = OEORD10detail1.Exists;
		OEORD10detail1.Insert();
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("LINENUM").SetValue("-3", false); // Line Number

		OEORD10detail1.Read(true);
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;
		OEORD10detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ITEM").SetValue("S.WWV0805", true); // Item
		OEORD10detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD10detail1.Process();
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD10detail1Fields.FieldByName("QTYORDERED").SetValue("20.0000", true); // Quantity Ordered

		temp = OEORD10detail1.Exists;
		OEORD10detail1.Insert();
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("LINENUM").SetValue("-4", false); // Line Number

		OEORD10detail1.Read(true);
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;
		OEORD10detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ITEM").SetValue("S.WWV0655", true); // Item
		OEORD10detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD10detail1.Process();
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD10detail1Fields.FieldByName("QTYORDERED").SetValue("12.0000", true); // Quantity Ordered

		temp = OEORD10detail1.Exists;
		OEORD10detail1.Insert();
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("LINENUM").SetValue("-5", false); // Line Number

		OEORD10detail1.Read(true);
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;
		OEORD10detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ITEM").SetValue("S.WWV0656", true); // Item
		OEORD10detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

		OEORD10detail1.Process();
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
		OEORD10detail1Fields.FieldByName("QTYORDERED").SetValue("4.0000", true); // Quantity Ordered

		temp = OEORD10detail1.Exists;
		OEORD10detail1.Insert();
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;

		OEORD10detail1Fields.FieldByName("LINENUM").SetValue("-6", false); // Line Number

		OEORD10detail1.Read(true);
		temp = OEORD10detail1.Exists;
		temp = OEORD10detail1.Exists;
		OEORD10detail1.RecordCreate(ViewRecordCreate.NoInsert);
		temp = OEORD10detail1.Exists;
		OEORD10detail1.Browse("", true);

		OEORD10detail1Fields.FieldByName("LINENUM").SetValue("-5", false); // Line Number

		OEORD10detail1.Read(true);
		OEORD10detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD10detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

		OEORD10detail5.Read(true);

		OEORD10detail5Fields.FieldByName("VALIFBOOL").SetValue("1", true); // Yes/No Value

		temp = OEORD10detail5.Exists;
		OEORD10detail5.Update();

		OEORD10detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD10detail5.Read(true);

		OEORD10detail5Fields.FieldByName("VALIFTEXT").SetValue("WWTRANS", true); // Text Value

		OEORD10detail5.Update();

		OEORD10detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

		OEORD10detail5.Read(true);
		OEORD10headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command

		OEORD10headerFields.FieldByName("REFERENCE").SetValue("WW PORTAL", false); // Order Reference

		OEORD10header.Process();
		OEORD10header.Insert();
		OEORD10header.Order = 1;
		OEORD10header.Read(true);
		OEORD10header.Order = 0;
		OEORD10detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
		OEORD10detail1.Browse("", true);
		OEORD10detail1.Fetch(false);
		OEORD10detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

		OEORD10detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

		OEORD10detail9.Browse("", true);
		OEORD10detail9.Fetch(false);
		OEORD10detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
		OEORD10detail3.Browse("", true);
		OEORD10detail3.Fetch(false);
		OEORD10detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
		OEORD10detail2.Browse("", false);
		OEORD10detail2.Fetch(false);

		OEORD10detail2Fields.FieldByName("PAYMENT").SetValue("-1", false); // Payment Number
		OEORD10detail2.Browse("", true);

		OEORD10detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

		OEORD10detail2.Browse("", false);
		OEORD10detail2.Fetch(false);
		temp = OEORD10header.Exists;


		Exit Sub

ACCPACErrorHandler:
		Dim lCount As Long
  Dim lIndex As Long

  If Errors Is Nothing Then
	   MsgBox Err.Description
  Else

	  lCount = Errors.Count


	  If lCount = 0 Then
		  MsgBox Err.Description
	  Else

		  For lIndex = 0 To lCount -1

			  MsgBox Errors.Item(lIndex)

		  Next

		  Errors.Clear
	  End If
	  Resume Next

  End If

End Sub

	}
}