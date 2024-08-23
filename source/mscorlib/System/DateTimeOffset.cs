using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000076 RID: 118
	[global::Cpp2ILInjected.Token(Token = "0x200009D")]
	[global::System.Serializable]
	[StructLayout(3)]
	public readonly struct DateTimeOffset : global::System.IComparable, global::System.IFormattable, global::System.IComparable<global::System.DateTimeOffset>, global::System.IEquatable<global::System.DateTimeOffset>, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback, global::System.ISpanFormattable
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x00015587 File Offset: 0x00013787
		[global::Cpp2ILInjected.Token(Token = "0x6000614")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1AA40", Offset = "0x1C1AA40", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "FromUnixTimeSeconds", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateOffset", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateDate", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DateTimeOffset(long ticks, global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0001558A File Offset: 0x0001378A
		[global::Cpp2ILInjected.Token(Token = "0x6000615")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1AC84", Offset = "0x1C1AC84", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "FromFileTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "ToLocalTime", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "ToUniversalTime", ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlDateTimeConverter", Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDateTimeOffset", ReturnType = "System.Nullable`1<DateTimeOffset>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<DateTimeOffset>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(global::System.Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.JavaScriptDateTimeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(global::System.Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateOffset", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateDate", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public DateTimeOffset(global::System.DateTime dateTime)
		{
			throw null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0001558D File Offset: 0x0001378D
		[global::Cpp2ILInjected.Token(Token = "0x6000616")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1AD48", Offset = "0x1C1AD48", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetIso", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateOffset", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateDate", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public DateTimeOffset(global::System.DateTime dateTime, global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00015590 File Offset: 0x00013790
		[global::Cpp2ILInjected.Token(Token = "0x6000617")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1AEF4", Offset = "0x1C1AEF4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateOffset", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateDate", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00015593 File Offset: 0x00013793
		[global::Cpp2ILInjected.Token(Token = "0x6000618")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1AFC0", Offset = "0x1C1AFC0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateOffset", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateDate", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00015596 File Offset: 0x00013796
		[global::Cpp2ILInjected.Token(Token = "0x6000619")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1B09C", Offset = "0x1C1B09C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateOffset", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.Calendar)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateDate", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, global::System.Globalization.Calendar calendar, global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00015599 File Offset: 0x00013799
		[global::Cpp2ILInjected.Token(Token = "0x17000078")]
		public global::System.DateTime DateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B180", Offset = "0x1C1B180", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTimeOffset),
				"System.Xml.Schema.XsdDateTimeFlags"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(global::System.DateTimeOffset) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDateTime", ReturnType = "System.Nullable`1<DateTime>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffsetString", MemberParameters = new object[]
			{
				typeof(global::System.IO.TextWriter),
				typeof(global::System.DateTimeOffset),
				"Newtonsoft.Json.DateFormatHandling",
				typeof(string),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<DateTime>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
			{
				"Newtonsoft.Json.Linq.JTokenType",
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonReader",
				typeof(global::System.Type),
				typeof(object),
				"Newtonsoft.Json.JsonSerializer"
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0001559C File Offset: 0x0001379C
		[global::Cpp2ILInjected.Token(Token = "0x17000079")]
		public global::System.DateTime UtcDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B224", Offset = "0x1C1B224", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(long),
				typeof(global::System.DateTimeKind)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0001559F File Offset: 0x0001379F
		[global::Cpp2ILInjected.Token(Token = "0x1700007A")]
		public global::System.DateTime LocalDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B298", Offset = "0x1C1B298", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.File), Member = "GetCreationTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.File), Member = "GetLastAccessTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.File), Member = "GetLastWriteTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DateTimeOffsetToDateTime", MemberParameters = new object[] { typeof(global::System.DateTimeOffset) }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlDateTimeConverter", Member = "ToDateTime", MemberParameters = new object[] { typeof(global::System.DateTimeOffset) }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToLocalTime", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x000155A2 File Offset: 0x000137A2
		[global::Cpp2ILInjected.Token(Token = "0x1700007B")]
		private global::System.DateTime ClockDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B184", Offset = "0x1C1B184", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Hour", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Millisecond", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Minute", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Second", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Ticks", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_TimeOfDay", ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "ToString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.IFormatProvider)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "TryFormat", MemberParameters = new object[]
			{
				typeof(global::System.Span<char>),
				typeof(ref int),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.IFormatProvider)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan)
			}, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(long),
				typeof(global::System.DateTimeKind)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x000155A5 File Offset: 0x000137A5
		[global::Cpp2ILInjected.Token(Token = "0x1700007C")]
		public int Day
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B2E4", Offset = "0x1C1B2E4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetDatePart", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x000155A8 File Offset: 0x000137A8
		[global::Cpp2ILInjected.Token(Token = "0x1700007D")]
		public int Hour
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B304", Offset = "0x1C1B304", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x000155AB File Offset: 0x000137AB
		[global::Cpp2ILInjected.Token(Token = "0x1700007E")]
		public int Millisecond
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000620")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B348", Offset = "0x1C1B348", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x000155AE File Offset: 0x000137AE
		[global::Cpp2ILInjected.Token(Token = "0x1700007F")]
		public int Minute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000621")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B398", Offset = "0x1C1B398", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x000155B1 File Offset: 0x000137B1
		[global::Cpp2ILInjected.Token(Token = "0x17000080")]
		public int Month
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000622")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B3DC", Offset = "0x1C1B3DC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetDatePart", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000155B4 File Offset: 0x000137B4
		[global::Cpp2ILInjected.Token(Token = "0x17000081")]
		public global::System.TimeSpan Offset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000623")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B2B8", Offset = "0x1C1B2B8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTimeOffset),
				"System.Xml.Schema.XsdDateTimeFlags"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(global::System.DateTimeOffset) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffsetString", MemberParameters = new object[]
			{
				typeof(global::System.IO.TextWriter),
				typeof(global::System.DateTimeOffset),
				"Newtonsoft.Json.DateFormatHandling",
				typeof(string),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new object[] { "Newtonsoft.Json.Bson.BsonToken" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x000155B7 File Offset: 0x000137B7
		[global::Cpp2ILInjected.Token(Token = "0x17000082")]
		public int Second
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000624")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B3FC", Offset = "0x1C1B3FC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x000155BA File Offset: 0x000137BA
		[global::Cpp2ILInjected.Token(Token = "0x17000083")]
		public long Ticks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000625")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B440", Offset = "0x1C1B440", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x000155BD File Offset: 0x000137BD
		[global::Cpp2ILInjected.Token(Token = "0x17000084")]
		public global::System.TimeSpan TimeOfDay
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000626")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B454", Offset = "0x1C1B454", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x000155C0 File Offset: 0x000137C0
		[global::Cpp2ILInjected.Token(Token = "0x17000085")]
		public int Year
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000627")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1B490", Offset = "0x1C1B490", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetDatePart", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000155C3 File Offset: 0x000137C3
		[global::Cpp2ILInjected.Token(Token = "0x6000628")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1B4B0", Offset = "0x1C1B4B0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "UnixTimeToDateTimeOffset", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		public global::System.DateTimeOffset AddTicks(long ticks)
		{
			throw null;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000155C6 File Offset: 0x000137C6
		[global::Cpp2ILInjected.Token(Token = "0x6000629")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1B520", Offset = "0x1C1B520", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private int System.IComparable.CompareTo(object obj)
		{
			throw null;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000155C9 File Offset: 0x000137C9
		[global::Cpp2ILInjected.Token(Token = "0x600062A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1B64C", Offset = "0x1C1B64C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int CompareTo(global::System.DateTimeOffset other)
		{
			throw null;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000155CC File Offset: 0x000137CC
		[global::Cpp2ILInjected.Token(Token = "0x600062B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1B6F4", Offset = "0x1C1B6F4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000155CF File Offset: 0x000137CF
		[global::Cpp2ILInjected.Token(Token = "0x600062C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1B7B0", Offset = "0x1C1B7B0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
		public bool Equals(global::System.DateTimeOffset other)
		{
			throw null;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000155D2 File Offset: 0x000137D2
		[global::Cpp2ILInjected.Token(Token = "0x600062D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1B7E4", Offset = "0x1C1B7E4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "GetCreationTime", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "GetLastAccessTime", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "GetLastWriteTime", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "FromFileTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.DateTimeOffset FromFileTime(long fileTime)
		{
			throw null;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000155D5 File Offset: 0x000137D5
		[global::Cpp2ILInjected.Token(Token = "0x600062E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1B858", Offset = "0x1C1B858", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_UnixTimeToDateTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "UnixTimeToDateTimeOffset", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static global::System.DateTimeOffset FromUnixTimeSeconds(long seconds)
		{
			throw null;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000155D8 File Offset: 0x000137D8
		[global::Cpp2ILInjected.Token(Token = "0x600062F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1B9C8", Offset = "0x1C1B9C8", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateOffset", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateDate", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000155DB File Offset: 0x000137DB
		[global::Cpp2ILInjected.Token(Token = "0x6000630")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1BB44", Offset = "0x1C1BB44", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000155DE File Offset: 0x000137DE
		[global::Cpp2ILInjected.Token(Token = "0x6000631")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1BC0C", Offset = "0x1C1BC0C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private DateTimeOffset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000155E1 File Offset: 0x000137E1
		[global::Cpp2ILInjected.Token(Token = "0x6000632")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1BDBC", Offset = "0x1C1BDBC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000155E4 File Offset: 0x000137E4
		[global::Cpp2ILInjected.Token(Token = "0x6000633")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1BDD4", Offset = "0x1C1BDD4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<DateTimeOffset>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.DateTimeOffset Parse(string input, global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000155E7 File Offset: 0x000137E7
		[global::Cpp2ILInjected.Token(Token = "0x6000634")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1BE44", Offset = "0x1C1BE44", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(global::System.Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateStyles", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(string)
		}, ReturnType = typeof(global::System.Globalization.DateTimeStyles))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static global::System.DateTimeOffset Parse(string input, global::System.IFormatProvider formatProvider, global::System.Globalization.DateTimeStyles styles)
		{
			throw null;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000155EA File Offset: 0x000137EA
		[global::Cpp2ILInjected.Token(Token = "0x6000635")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1C184", Offset = "0x1C1C184", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(global::System.Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateStyles", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(string)
		}, ReturnType = typeof(global::System.Globalization.DateTimeStyles))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static global::System.DateTimeOffset ParseExact(string input, string format, global::System.IFormatProvider formatProvider, global::System.Globalization.DateTimeStyles styles)
		{
			throw null;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000155ED File Offset: 0x000137ED
		[global::Cpp2ILInjected.Token(Token = "0x6000636")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1C4B0", Offset = "0x1C1C4B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "UnixTimeToDateTimeOffset", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public global::System.DateTimeOffset ToLocalTime()
		{
			throw null;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000155F0 File Offset: 0x000137F0
		[global::Cpp2ILInjected.Token(Token = "0x6000637")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1C4B8", Offset = "0x1C1C4B8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToLocalTime", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		internal global::System.DateTimeOffset ToLocalTime(bool throwOnOverflow)
		{
			throw null;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000155F3 File Offset: 0x000137F3
		[global::Cpp2ILInjected.Token(Token = "0x6000638")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1C4F8", Offset = "0x1C1C4F8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000155F6 File Offset: 0x000137F6
		[global::Cpp2ILInjected.Token(Token = "0x6000639")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1C858", Offset = "0x1C1C858", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000155F9 File Offset: 0x000137F9
		[global::Cpp2ILInjected.Token(Token = "0x600063A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1C8F4", Offset = "0x1C1C8F4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(global::System.DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffsetString", MemberParameters = new object[]
		{
			typeof(global::System.IO.TextWriter),
			typeof(global::System.DateTimeOffset),
			"Newtonsoft.Json.DateFormatHandling",
			typeof(string),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "WriteJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(string format, global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000155FC File Offset: 0x000137FC
		[global::Cpp2ILInjected.Token(Token = "0x600063B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1C99C", Offset = "0x1C1C99C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format = default(global::System.ReadOnlySpan<char>), global::System.IFormatProvider formatProvider = null)
		{
			throw null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000155FF File Offset: 0x000137FF
		[global::Cpp2ILInjected.Token(Token = "0x600063C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1CC80", Offset = "0x1C1CC80", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "WriteJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.JavaScriptDateTimeConverter", Member = "WriteJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		public global::System.DateTimeOffset ToUniversalTime()
		{
			throw null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00015602 File Offset: 0x00013802
		[global::Cpp2ILInjected.Token(Token = "0x600063D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1CCAC", Offset = "0x1C1CCAC", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadDateTimeOffsetString", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Nullable`1<DateTimeOffset>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateStyles", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(string)
		}, ReturnType = typeof(global::System.Globalization.DateTimeStyles))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTime),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static bool TryParse(string input, global::System.IFormatProvider formatProvider, global::System.Globalization.DateTimeStyles styles, out global::System.DateTimeOffset result)
		{
			throw null;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00015605 File Offset: 0x00013805
		[global::Cpp2ILInjected.Token(Token = "0x600063E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1CFA0", Offset = "0x1C1CFA0", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ValidateStyles", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(string)
		}, ReturnType = typeof(global::System.Globalization.DateTimeStyles))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTime),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool TryParseExact(string input, string format, global::System.IFormatProvider formatProvider, global::System.Globalization.DateTimeStyles styles, out global::System.DateTimeOffset result)
		{
			throw null;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00015608 File Offset: 0x00013808
		[global::Cpp2ILInjected.Token(Token = "0x600063F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1AAD4", Offset = "0x1C1AAD4", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.Calendar),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static short ValidateOffset(global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0001560B File Offset: 0x0001380B
		[global::Cpp2ILInjected.Token(Token = "0x6000640")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1ABE0", Offset = "0x1C1ABE0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.Calendar),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static global::System.DateTime ValidateDate(global::System.DateTime dateTime, global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0001560E File Offset: 0x0001380E
		[global::Cpp2ILInjected.Token(Token = "0x6000641")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1BFB0", Offset = "0x1C1BFB0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static global::System.Globalization.DateTimeStyles ValidateStyles(global::System.Globalization.DateTimeStyles style, string parameterName)
		{
			throw null;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00015611 File Offset: 0x00013811
		[global::Cpp2ILInjected.Token(Token = "0x6000642")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1D2EC", Offset = "0x1C1D2EC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "GetCreationTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "GetLastAccessTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "GetLastWriteTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlDateTimeConverter", Member = "ToDateTimeOffset", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		public static implicit operator global::System.DateTimeOffset(global::System.DateTime dateTime)
		{
			throw null;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00015614 File Offset: 0x00013814
		[global::Cpp2ILInjected.Token(Token = "0x6000643")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1D314", Offset = "0x1C1D314", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator ==(global::System.DateTimeOffset left, global::System.DateTimeOffset right)
		{
			throw null;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00015617 File Offset: 0x00013817
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000644")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1D398", Offset = "0x1C1D398", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static DateTimeOffset()
		{
			throw null;
		}

		// Token: 0x04000170 RID: 368
		[global::Cpp2ILInjected.Token(Token = "0x4000257")]
		public static readonly global::System.DateTimeOffset MinValue;

		// Token: 0x04000171 RID: 369
		[global::Cpp2ILInjected.Token(Token = "0x4000258")]
		public static readonly global::System.DateTimeOffset MaxValue;

		// Token: 0x04000172 RID: 370
		[global::Cpp2ILInjected.Token(Token = "0x4000259")]
		public static readonly global::System.DateTimeOffset UnixEpoch;

		// Token: 0x04000173 RID: 371
		[global::Cpp2ILInjected.Token(Token = "0x400025A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.DateTime _dateTime;

		// Token: 0x04000174 RID: 372
		[global::Cpp2ILInjected.Token(Token = "0x400025B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly short _offsetMinutes;
	}
}
