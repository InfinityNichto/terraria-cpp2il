using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004F RID: 79
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000060")]
	internal static class DateTimeUtils
	{
		// Token: 0x06000333 RID: 819 RVA: 0x00002A14 File Offset: 0x00000C14
		[global::Cpp2ILInjected.Token(Token = "0x6000355")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4884", Offset = "0x1CD4884", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static DateTimeUtils()
		{
			throw null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002A17 File Offset: 0x00000C17
		[global::Cpp2ILInjected.Token(Token = "0x6000356")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4970", Offset = "0x1CD4970", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZone), Member = "get_CurrentTimeZone", ReturnType = typeof(TimeZone))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static TimeSpan GetUtcOffset(this DateTime d)
		{
			throw null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002A1A File Offset: 0x00000C1A
		[global::Cpp2ILInjected.Token(Token = "0x6000357")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4994", Offset = "0x1CD4994", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ConvertTokenToXmlValue", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(ArgumentOutOfRangeException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			throw null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002A1D File Offset: 0x00000C1D
		[global::Cpp2ILInjected.Token(Token = "0x6000358")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4A14", Offset = "0x1CD4A14", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadDateTimeString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateFormatHandling),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeIso", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeMicrosoft", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "SwitchToLocalTime", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "SwitchToUtcTime", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
		{
			throw null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002A20 File Offset: 0x00000C20
		[global::Cpp2ILInjected.Token(Token = "0x6000359")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4B38", Offset = "0x1CD4B38", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		private static DateTime SwitchToLocalTime(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002A23 File Offset: 0x00000C23
		[global::Cpp2ILInjected.Token(Token = "0x600035A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4BB0", Offset = "0x1CD4BB0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
		private static DateTime SwitchToUtcTime(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002A26 File Offset: 0x00000C26
		[global::Cpp2ILInjected.Token(Token = "0x600035B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4C28", Offset = "0x1CD4C28", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(bool)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZone), Member = "get_CurrentTimeZone", ReturnType = typeof(TimeZone))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ToUniversalTicks", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static long ToUniversalTicks(DateTime dateTime)
		{
			throw null;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002A29 File Offset: 0x00000C29
		[global::Cpp2ILInjected.Token(Token = "0x600035C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4CC4", Offset = "0x1CD4CC4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "ToUniversalTicks", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002A2C File Offset: 0x00000C2C
		[global::Cpp2ILInjected.Token(Token = "0x600035D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4DCC", Offset = "0x1CD4DCC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(DateTime),
			typeof(TimeSpan?),
			typeof(DateTimeKind),
			typeof(DateFormatHandling)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ToUniversalTicks", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002A2F File Offset: 0x00000C2F
		[global::Cpp2ILInjected.Token(Token = "0x600035E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4EB0", Offset = "0x1CD4EB0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JavaScriptDateTimeConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			throw null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002A32 File Offset: 0x00000C32
		[global::Cpp2ILInjected.Token(Token = "0x600035F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4F08", Offset = "0x1CD4F08", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ToUniversalTicks", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "UniversialTicksToJavaScriptTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			throw null;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002A35 File Offset: 0x00000C35
		[global::Cpp2ILInjected.Token(Token = "0x6000360")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4E34", Offset = "0x1CD4E34", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(bool)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static long UniversialTicksToJavaScriptTicks(long universialTicks)
		{
			throw null;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002A38 File Offset: 0x00000C38
		[global::Cpp2ILInjected.Token(Token = "0x6000361")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC4C4", Offset = "0x1CCC4C4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteConstructorDate", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeMicrosoft", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JavaScriptDateTimeConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadType", MemberParameters = new object[] { typeof(BsonType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			throw null;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002A3B File Offset: 0x00000C3B
		[global::Cpp2ILInjected.Token(Token = "0x6000362")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD4FA0", Offset = "0x1CD4FA0", Length = "0x38C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "CreateDateTime", MemberParameters = new object[] { typeof(DateTimeParser) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZone), Member = "get_CurrentTimeZone", ReturnType = typeof(TimeZone))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			throw null;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002A3E File Offset: 0x00000C3E
		[global::Cpp2ILInjected.Token(Token = "0x6000363")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD53AC", Offset = "0x1CD53AC", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "CreateDateTime", MemberParameters = new object[] { typeof(DateTimeParser) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt)
		{
			throw null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002A41 File Offset: 0x00000C41
		[global::Cpp2ILInjected.Token(Token = "0x6000364")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD532C", Offset = "0x1CD532C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeIso", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetIso", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(DateTime))]
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser)
		{
			throw null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002A44 File Offset: 0x00000C44
		[global::Cpp2ILInjected.Token(Token = "0x6000365")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD5570", Offset = "0x1CD5570", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ReadType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReferenceExtensions), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReferenceExtensions), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeMicrosoft", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeIso", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			throw null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002A47 File Offset: 0x00000C47
		[global::Cpp2ILInjected.Token(Token = "0x6000366")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD59C0", Offset = "0x1CD59C0", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadDateTimeString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeMicrosoft", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			throw null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002A4A File Offset: 0x00000C4A
		[global::Cpp2ILInjected.Token(Token = "0x6000367")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD5C6C", Offset = "0x1CD5C6C", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ReadType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReferenceExtensions), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReferenceExtensions), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetIso", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			throw null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002A4D File Offset: 0x00000C4D
		[global::Cpp2ILInjected.Token(Token = "0x6000368")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD6040", Offset = "0x1CD6040", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadDateTimeOffsetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetIso", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			throw null;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002A50 File Offset: 0x00000C50
		[global::Cpp2ILInjected.Token(Token = "0x6000369")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD62EC", Offset = "0x1CD62EC", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeMicrosoft", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReferenceExtensions), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryReadOffset", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(int),
			typeof(ref TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "Int64TryParse", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(ref long)
		}, ReturnType = typeof(ParseResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind)
		{
			throw null;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002A53 File Offset: 0x00000C53
		[global::Cpp2ILInjected.Token(Token = "0x600036A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD5774", Offset = "0x1CD5774", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseMicrosoftDate", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref long),
			typeof(ref TimeSpan),
			typeof(ref DateTimeKind)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "SpecifyKind", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeKind)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			throw null;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002A56 File Offset: 0x00000C56
		[global::Cpp2ILInjected.Token(Token = "0x600036B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD58D8", Offset = "0x1CD58D8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			throw null;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002A59 File Offset: 0x00000C59
		[global::Cpp2ILInjected.Token(Token = "0x600036C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD5E58", Offset = "0x1CD5E58", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseMicrosoftDate", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref long),
			typeof(ref TimeSpan),
			typeof(ref DateTimeKind)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "op_Implicit", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt)
		{
			throw null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002A5C File Offset: 0x00000C5C
		[global::Cpp2ILInjected.Token(Token = "0x600036D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD5F90", Offset = "0x1CD5F90", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			throw null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002A5F File Offset: 0x00000C5F
		[global::Cpp2ILInjected.Token(Token = "0x600036E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD6460", Offset = "0x1CD6460", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseMicrosoftDate", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref long),
			typeof(ref TimeSpan),
			typeof(ref DateTimeKind)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "Int32TryParse", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(ParseResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromHours", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromMinutes", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "Negate", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002A62 File Offset: 0x00000C62
		[global::Cpp2ILInjected.Token(Token = "0x600036F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD65B8", Offset = "0x1CD65B8", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateFormatHandling),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanQueryExpression), Member = "EqualsWithStringCoercion", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JValue)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(DateTime),
			typeof(TimeSpan?),
			typeof(DateTimeKind),
			typeof(DateFormatHandling)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002A65 File Offset: 0x00000C65
		[global::Cpp2ILInjected.Token(Token = "0x6000370")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD66E4", Offset = "0x1CD66E4", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(DateTime),
			typeof(DateFormatHandling),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeOffsetString", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(DateTimeOffset),
			typeof(DateFormatHandling),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeZone), Member = "get_CurrentTimeZone", ReturnType = typeof(TimeZone))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeOffset", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(TimeSpan),
			typeof(DateFormatHandling)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDefaultIsoDate", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format)
		{
			throw null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002A68 File Offset: 0x00000C68
		[global::Cpp2ILInjected.Token(Token = "0x6000371")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD6B8C", Offset = "0x1CD6B8C", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(DateTime),
			typeof(TimeSpan?),
			typeof(DateTimeKind),
			typeof(DateFormatHandling)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "GetDateValues", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
		{
			throw null;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002A6B File Offset: 0x00000C6B
		[global::Cpp2ILInjected.Token(Token = "0x6000372")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD711C", Offset = "0x1CD711C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
		{
			throw null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002A6E File Offset: 0x00000C6E
		[global::Cpp2ILInjected.Token(Token = "0x6000373")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD69E4", Offset = "0x1CD69E4", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(DateTime),
			typeof(TimeSpan?),
			typeof(DateTimeKind),
			typeof(DateFormatHandling)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format)
		{
			throw null;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002A71 File Offset: 0x00000C71
		[global::Cpp2ILInjected.Token(Token = "0x6000374")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD7164", Offset = "0x1CD7164", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(DateFormatHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanQueryExpression), Member = "EqualsWithStringCoercion", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JValue)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan?), Member = ".ctor", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(DateTime),
			typeof(TimeSpan?),
			typeof(DateTimeKind),
			typeof(DateFormatHandling)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002A74 File Offset: 0x00000C74
		[global::Cpp2ILInjected.Token(Token = "0x6000375")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD6F44", Offset = "0x1CD6F44", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDefaultIsoDate", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void GetDateValues(DateTime td, out int year, out int month, out int day)
		{
			throw null;
		}

		// Token: 0x040001A9 RID: 425
		[global::Cpp2ILInjected.Token(Token = "0x40001DB")]
		internal static readonly long InitialJavaScriptDateTicks;

		// Token: 0x040001AA RID: 426
		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		private const string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK";

		// Token: 0x040001AB RID: 427
		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		private const int DaysPer100Years = 36524;

		// Token: 0x040001AC RID: 428
		[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
		private const int DaysPer400Years = 146097;

		// Token: 0x040001AD RID: 429
		[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
		private const int DaysPer4Years = 1461;

		// Token: 0x040001AE RID: 430
		[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
		private const int DaysPerYear = 365;

		// Token: 0x040001AF RID: 431
		[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
		private const long TicksPerDay = 864000000000L;

		// Token: 0x040001B0 RID: 432
		[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
		private static readonly int[] DaysToMonth365;

		// Token: 0x040001B1 RID: 433
		[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
		private static readonly int[] DaysToMonth366;
	}
}
