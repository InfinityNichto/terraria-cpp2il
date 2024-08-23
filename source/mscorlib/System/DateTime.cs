using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000074 RID: 116
	[global::Cpp2ILInjected.Token(Token = "0x200009B")]
	[global::System.Serializable]
	[StructLayout(3)]
	public readonly struct DateTime : global::System.IComparable, global::System.IFormattable, global::System.IConvertible, global::System.IComparable<global::System.DateTime>, global::System.IEquatable<global::System.DateTime>, global::System.Runtime.Serialization.ISerializable, global::System.ISpanFormattable
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x00015455 File Offset: 0x00013655
		[global::Cpp2ILInjected.Token(Token = "0x60005AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C16808", Offset = "0x1C16808", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationBroadcast", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationFinder", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationState", Member = "ReadWorldFileData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ServerAutoFinder", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertUtcToTimeZone", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.HijriCalendar), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public DateTime(long ticks)
		{
			throw null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00015458 File Offset: 0x00013658
		[global::Cpp2ILInjected.Token(Token = "0x60005AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C16894", Offset = "0x1C16894", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private DateTime(ulong dateData)
		{
			throw null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0001545B File Offset: 0x0001365B
		[global::Cpp2ILInjected.Token(Token = "0x60005AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1689C", Offset = "0x1C1689C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public DateTime(long ticks, global::System.DateTimeKind kind)
		{
			throw null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0001545E File Offset: 0x0001365E
		[global::Cpp2ILInjected.Token(Token = "0x60005B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1697C", Offset = "0x1C1697C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions),
			"System.TimeZoneInfo.CachedData"
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "FromBinary", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "get_Now", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ToLocalTime", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal DateTime(long ticks, global::System.DateTimeKind kind, bool isAmbiguousDst)
		{
			throw null;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00015461 File Offset: 0x00013661
		[global::Cpp2ILInjected.Token(Token = "0x60005B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C16A1C", Offset = "0x1C16A1C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.EraInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.EraInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.HijriCalendar), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.JapaneseCalendar), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TaiwanCalendar), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar.DateMapping), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = "InitDateMapping", ReturnType = typeof(global::System.Globalization.UmAlQuraCalendar.DateMapping[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "DateToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DateTime(int year, int month, int day)
		{
			throw null;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00015464 File Offset: 0x00013664
		[global::Cpp2ILInjected.Token(Token = "0x60005B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C16C24", Offset = "0x1C16C24", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRules", ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ParseTimeOfDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "InitiateXsdDateTime", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime.Parser" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "CreateDateTime", MemberParameters = new object[] { "Newtonsoft.Json.Utilities.DateTimeParser" }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "DateToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DateTime(int year, int month, int day, int hour, int minute, int second)
		{
			throw null;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00015467 File Offset: 0x00013667
		[global::Cpp2ILInjected.Token(Token = "0x60005B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C16DA4", Offset = "0x1C16DA4", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.GZipStream", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "DateToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public DateTime(int year, int month, int day, int hour, int minute, int second, global::System.DateTimeKind kind)
		{
			throw null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001546A File Offset: 0x0001366A
		[global::Cpp2ILInjected.Token(Token = "0x60005B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C16EBC", Offset = "0x1C16EBC", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.TransitionTime)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.GregorianCalendar), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetLastModifiedFrom213Response", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpDateParse", Member = "ParseHttpDate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "PackedToDateTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "DateToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			throw null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001546D File Offset: 0x0001366D
		[global::Cpp2ILInjected.Token(Token = "0x60005B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1708C", Offset = "0x1C1708C", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, global::System.Globalization.Calendar calendar)
		{
			throw null;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00015470 File Offset: 0x00013670
		[global::Cpp2ILInjected.Token(Token = "0x60005B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17234", Offset = "0x1C17234", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private DateTime(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00015473 File Offset: 0x00013673
		[global::Cpp2ILInjected.Token(Token = "0x17000068")]
		internal long InternalTicks
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C174C8", Offset = "0x1C174C8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00015476 File Offset: 0x00013676
		[global::Cpp2ILInjected.Token(Token = "0x17000069")]
		private ulong InternalKind
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C174D4", Offset = "0x1C174D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00015479 File Offset: 0x00013679
		[global::Cpp2ILInjected.Token(Token = "0x60005B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C174E0", Offset = "0x1C174E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public global::System.DateTime Add(global::System.TimeSpan value)
		{
			throw null;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001547C File Offset: 0x0001367C
		[global::Cpp2ILInjected.Token(Token = "0x60005BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17590", Offset = "0x1C17590", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "AddDays", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "AddHours", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "AddMilliseconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "AddSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private global::System.DateTime Add(double value, int scale)
		{
			throw null;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001547F File Offset: 0x0001367F
		[global::Cpp2ILInjected.Token(Token = "0x60005BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17660", Offset = "0x1C17660", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.TransitionTime)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "CreateDateTime", MemberParameters = new object[] { "Newtonsoft.Json.Utilities.DateTimeParser" }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SocialPlatforms.Local", Member = "PopulateStaticData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "Add", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		public global::System.DateTime AddDays(double value)
		{
			throw null;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00015482 File Offset: 0x00013682
		[global::Cpp2ILInjected.Token(Token = "0x60005BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1766C", Offset = "0x1C1766C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpDateParse", Member = "ParseHttpDate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "Add", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		public global::System.DateTime AddHours(double value)
		{
			throw null;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00015485 File Offset: 0x00013685
		[global::Cpp2ILInjected.Token(Token = "0x60005BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17678", Offset = "0x1C17678", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(global::System.TimeSpan),
			typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "Add", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		public global::System.DateTime AddMilliseconds(double value)
		{
			throw null;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00015488 File Offset: 0x00013688
		[global::Cpp2ILInjected.Token(Token = "0x60005BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17680", Offset = "0x1C17680", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "AddYears", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetDatePart", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "DaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "DateToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public global::System.DateTime AddMonths(int months)
		{
			throw null;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0001548B File Offset: 0x0001368B
		[global::Cpp2ILInjected.Token(Token = "0x60005BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17B8C", Offset = "0x1C17B8C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "getDPS", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordJoinToServerRequest", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieParser", Member = "Get", ReturnType = "System.Net.Cookie")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.<>c__DisplayClass4", Member = "<ProcessExtraFieldUnixTimes>b__3", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ProcessExtraFieldInfoZipTimes", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibBaseStream", Member = "_ReadAndValidateGzipHeader", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "Add", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		public global::System.DateTime AddSeconds(double value)
		{
			throw null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0001548E File Offset: 0x0001368E
		[global::Cpp2ILInjected.Token(Token = "0x60005C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C174E4", Offset = "0x1C174E4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(global::System.TimeSpan),
			typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "Add", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseISO8601", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.__DTString),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "InitiateXsdDateTime", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime.Parser" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "CreateDateTime", MemberParameters = new object[] { "Newtonsoft.Json.Utilities.DateTimeParser" }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public global::System.DateTime AddTicks(long value)
		{
			throw null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00015491 File Offset: 0x00013691
		[global::Cpp2ILInjected.Token(Token = "0x60005C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17B94", Offset = "0x1C17B94", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddMonths", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public global::System.DateTime AddYears(int value)
		{
			throw null;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00015494 File Offset: 0x00013694
		[global::Cpp2ILInjected.Token(Token = "0x60005C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17C18", Offset = "0x1C17C18", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordJoinToServerRequest", Member = "IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int Compare(global::System.DateTime t1, global::System.DateTime t2)
		{
			throw null;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00015497 File Offset: 0x00013697
		[global::Cpp2ILInjected.Token(Token = "0x60005C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17C38", Offset = "0x1C17C38", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public int CompareTo(object value)
		{
			throw null;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0001549A File Offset: 0x0001369A
		[global::Cpp2ILInjected.Token(Token = "0x60005C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17D34", Offset = "0x1C17D34", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.CreativePowers.APerPlayerSliderPower", Member = "AttemptPushingChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.CreativePowers.ASharedSliderPower", Member = "AttemptPushingChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.TimeZoneInfo.<>c", Member = "<CreateLocalUnity>b__161_0", MemberParameters = new object[]
		{
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_dateTimeBase", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int CompareTo(global::System.DateTime value)
		{
			throw null;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0001549D File Offset: 0x0001369D
		[global::Cpp2ILInjected.Token(Token = "0x60005C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C16A9C", Offset = "0x1C16A9C", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "AddMonths", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "IsLeapYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static long DateToTicks(int year, int month, int day)
		{
			throw null;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000154A0 File Offset: 0x000136A0
		[global::Cpp2ILInjected.Token(Token = "0x60005C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C16CD0", Offset = "0x1C16CD0", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static long TimeToTicks(int hour, int minute, int second)
		{
			throw null;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000154A3 File Offset: 0x000136A3
		[global::Cpp2ILInjected.Token(Token = "0x60005C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17A80", Offset = "0x1C17A80", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.TransitionTime)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "AddMonths", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime.Parser", Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			"System.Xml.Schema.XsdDateTimeFlags"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime.Parser", Member = "ParseDate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeParser", Member = "ParseDate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "IsLeapYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static int DaysInMonth(int year, int month)
		{
			throw null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000154A6 File Offset: 0x000136A6
		[global::Cpp2ILInjected.Token(Token = "0x60005C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17E70", Offset = "0x1C17E70", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000154A9 File Offset: 0x000136A9
		[global::Cpp2ILInjected.Token(Token = "0x60005C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17EEC", Offset = "0x1C17EEC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool Equals(global::System.DateTime value)
		{
			throw null;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000154AC File Offset: 0x000136AC
		[global::Cpp2ILInjected.Token(Token = "0x60005CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17F00", Offset = "0x1C17F00", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "LoadHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "LoadHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "GetTutorialMetadata", ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "GetAllMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "LoadHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref global::System.Resources.ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "FromBinaryRaw", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "get_Local", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static global::System.DateTime FromBinary(long dateData)
		{
			throw null;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000154AF File Offset: 0x000136AF
		[global::Cpp2ILInjected.Token(Token = "0x60005CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18130", Offset = "0x1C18130", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "FromBinary", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryParser), Member = "ReadDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static global::System.DateTime FromBinaryRaw(long dateData)
		{
			throw null;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000154B2 File Offset: 0x000136B2
		[global::Cpp2ILInjected.Token(Token = "0x60005CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C181B4", Offset = "0x1C181B4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "FromFileTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "FromFileTimeUtc", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToLocalTime", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.DateTime FromFileTime(long fileTime)
		{
			throw null;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000154B5 File Offset: 0x000136B5
		[global::Cpp2ILInjected.Token(Token = "0x60005CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18228", Offset = "0x1C18228", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "FromFileTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ProcessExtraFieldWindowsTimes", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
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
		public static global::System.DateTime FromFileTimeUtc(long fileTime)
		{
			throw null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000154B8 File Offset: 0x000136B8
		[global::Cpp2ILInjected.Token(Token = "0x60005CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C182DC", Offset = "0x1C182DC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000154BB File Offset: 0x000136BB
		[global::Cpp2ILInjected.Token(Token = "0x60005CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C183A8", Offset = "0x1C183A8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "AdjustTime_Reverse", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "get_Local", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool IsDaylightSavingTime()
		{
			throw null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000154BE File Offset: 0x000136BE
		[global::Cpp2ILInjected.Token(Token = "0x60005D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1842C", Offset = "0x1C1842C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeMicrosoft", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			"Newtonsoft.Json.DateTimeZoneHandling",
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "ReadType", MemberParameters = new object[] { "Newtonsoft.Json.Bson.BsonType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "PackedToDateTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "set_LastModified", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		public static global::System.DateTime SpecifyKind(global::System.DateTime value, global::System.DateTimeKind kind)
		{
			throw null;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000154C1 File Offset: 0x000136C1
		[global::Cpp2ILInjected.Token(Token = "0x60005D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18450", Offset = "0x1C18450", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "InternalSavePlayerFile", MemberParameters = new object[] { "Terraria.IO.PlayerFileData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "LoadTutorialPlayer", ReturnType = "Terraria.IO.PlayerFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = "Terraria.IO.PlayerFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "AdjustRespawnTimerForWorldJoining", MemberParameters = new object[] { "Terraria.Player" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "SaveWorldHeader", MemberParameters = new object[] { typeof(global::System.IO.BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public long ToBinary()
		{
			throw null;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x000154C4 File Offset: 0x000136C4
		[global::Cpp2ILInjected.Token(Token = "0x1700006A")]
		public global::System.DateTime Date
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C184E8", Offset = "0x1C184E8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRules", ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(bool),
				typeof(ref int?)
			}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000154C7 File Offset: 0x000136C7
		[global::Cpp2ILInjected.Token(Token = "0x60005D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18524", Offset = "0x1C18524", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "CreateDaylightChanges", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.DaylightTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "GetUtcOffset", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatO", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int GetDatePart(int part)
		{
			throw null;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000154CA File Offset: 0x000136CA
		[global::Cpp2ILInjected.Token(Token = "0x60005D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C178BC", Offset = "0x1C178BC", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.DayOfWeek)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "AddMonths", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatR", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void GetDatePart(out int year, out int month, out int day)
		{
			throw null;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x000154CD File Offset: 0x000136CD
		[global::Cpp2ILInjected.Token(Token = "0x1700006B")]
		public int Day
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C186F4", Offset = "0x1C186F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "checkXMas", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "checkHalloween", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureSettings", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRules", ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref long[]),
				typeof(ref string[]),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "FormatDate", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Day", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintDate", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "DateTimeToPacked", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetDatePart", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x000154D0 File Offset: 0x000136D0
		[global::Cpp2ILInjected.Token(Token = "0x1700006C")]
		public global::System.DayOfWeek DayOfWeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C186FC", Offset = "0x1C186FC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(global::System.TimeZoneInfo.TransitionTime)
			}, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000154D3 File Offset: 0x000136D3
		[global::Cpp2ILInjected.Token(Token = "0x60005D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18748", Offset = "0x1C18748", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x000154D6 File Offset: 0x000136D6
		[global::Cpp2ILInjected.Token(Token = "0x1700006D")]
		public int Hour
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C18758", Offset = "0x1C18758", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureSettings", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRules", ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(global::System.TimeZoneInfo.TransitionTime)
			}, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Hour", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDefaultIsoDate", MemberParameters = new object[]
			{
				"System.Char[]",
				typeof(int),
				typeof(global::System.DateTime)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "DateTimeToPacked", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000154D9 File Offset: 0x000136D9
		[global::Cpp2ILInjected.Token(Token = "0x60005D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18794", Offset = "0x1C18794", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZone), Member = "CalculateUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Globalization.DaylightTime)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal bool IsAmbiguousDaylightSavingTime()
		{
			throw null;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x000154DC File Offset: 0x000136DC
		[global::Cpp2ILInjected.Token(Token = "0x1700006E")]
		public global::System.DateTimeKind Kind
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C161E4", Offset = "0x1C161E4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 42)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000154DF File Offset: 0x000136DF
		[global::Cpp2ILInjected.Token(Token = "0x1700006F")]
		public int Millisecond
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C187A8", Offset = "0x1C187A8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.PlayerDrawLayers", Member = "DrawPlayer_12_1_BalloonFronts", MemberParameters = new object[] { "Terraria.DataStructures.PlayerDrawSet&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.PlayerDrawLayers", Member = "DrawPlayer_11_Balloons", MemberParameters = new object[] { "Terraria.DataStructures.PlayerDrawSet&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(global::System.TimeZoneInfo.TransitionTime)
			}, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x000154E2 File Offset: 0x000136E2
		[global::Cpp2ILInjected.Token(Token = "0x17000070")]
		public int Minute
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C187F0", Offset = "0x1C187F0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureSettings", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRules", ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(global::System.TimeZoneInfo.TransitionTime)
			}, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Minute", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDefaultIsoDate", MemberParameters = new object[]
			{
				"System.Char[]",
				typeof(int),
				typeof(global::System.DateTime)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "DateTimeToPacked", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x000154E5 File Offset: 0x000136E5
		[global::Cpp2ILInjected.Token(Token = "0x17000071")]
		public int Month
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1882C", Offset = "0x1C1882C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "checkXMas", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "checkHalloween", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureSettings", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRules", ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref long[]),
				typeof(ref string[]),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "FormatDate", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Month", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintDate", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "DateTimeToPacked", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetDatePart", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x000154E8 File Offset: 0x000136E8
		[global::Cpp2ILInjected.Token(Token = "0x17000072")]
		public static global::System.DateTime Now
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C18834", Offset = "0x1C18834", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 211)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_UtcNow", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(ref bool)
			}, ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(long),
				typeof(global::System.DateTimeKind),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x000154EB File Offset: 0x000136EB
		[global::Cpp2ILInjected.Token(Token = "0x17000073")]
		public int Second
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1898C", Offset = "0x1C1898C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureSettings", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRules", ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new object[]
			{
				typeof(int),
				typeof(global::System.TimeZoneInfo.TransitionTime)
			}, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Second", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDefaultIsoDate", MemberParameters = new object[]
			{
				"System.Char[]",
				typeof(int),
				typeof(global::System.DateTime)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "DateTimeToPacked", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x000154EE File Offset: 0x000136EE
		[global::Cpp2ILInjected.Token(Token = "0x17000074")]
		public long Ticks
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C17228", Offset = "0x1C17228", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 93)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x000154F1 File Offset: 0x000136F1
		[global::Cpp2ILInjected.Token(Token = "0x17000075")]
		public global::System.TimeSpan TimeOfDay
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C189C8", Offset = "0x1C189C8", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref long[]),
				typeof(ref string[]),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(global::System.Globalization.CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x000154F4 File Offset: 0x000136F4
		[global::Cpp2ILInjected.Token(Token = "0x17000076")]
		public int Year
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C16128", Offset = "0x1C16128", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 49)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetDatePart", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000154F7 File Offset: 0x000136F7
		[global::Cpp2ILInjected.Token(Token = "0x60005E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C17DA8", Offset = "0x1C17DA8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "DateToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "DaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool IsLeapYear(int year)
		{
			throw null;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000154FA File Offset: 0x000136FA
		[global::Cpp2ILInjected.Token(Token = "0x60005E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C189FC", Offset = "0x1C189FC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static global::System.DateTime Parse(string s, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000154FD File Offset: 0x000136FD
		[global::Cpp2ILInjected.Token(Token = "0x60005E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18BE0", Offset = "0x1C18BE0", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(global::System.Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static global::System.DateTime Parse(string s, global::System.IFormatProvider provider, global::System.Globalization.DateTimeStyles styles)
		{
			throw null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00015500 File Offset: 0x00013700
		[global::Cpp2ILInjected.Token(Token = "0x60005E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18D10", Offset = "0x1C18D10", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "get_Date", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static global::System.DateTime ParseExact(string s, string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00015503 File Offset: 0x00013703
		[global::Cpp2ILInjected.Token(Token = "0x60005E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C18F7C", Offset = "0x1C18F7C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(global::System.Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1Convert", Member = "ToDateTime", MemberParameters = new object[] { "Mono.Security.ASN1" }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeParse), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static global::System.DateTime ParseExact(string s, string format, global::System.IFormatProvider provider, global::System.Globalization.DateTimeStyles style)
		{
			throw null;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00015506 File Offset: 0x00013706
		[global::Cpp2ILInjected.Token(Token = "0x60005E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1911C", Offset = "0x1C1911C", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoHttpDate", Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static global::System.DateTime ParseExact(string s, string[] formats, global::System.IFormatProvider provider, global::System.Globalization.DateTimeStyles style)
		{
			throw null;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00015509 File Offset: 0x00013709
		[global::Cpp2ILInjected.Token(Token = "0x60005E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19354", Offset = "0x1C19354", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordJoinToServerRequest", Member = "GetUserWrapperText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public global::System.TimeSpan Subtract(global::System.DateTime value)
		{
			throw null;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0001550C File Offset: 0x0001370C
		[global::Cpp2ILInjected.Token(Token = "0x60005EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19368", Offset = "0x1C19368", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ConstructExtraField", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.NetCfFile", Member = "SetTimes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.NetCfFile", Member = "SetLastWriteTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToUniversalTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToFileTimeUtc", ReturnType = typeof(long))]
		public long ToFileTime()
		{
			throw null;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0001550F File Offset: 0x0001370F
		[global::Cpp2ILInjected.Token(Token = "0x60005EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C193E4", Offset = "0x1C193E4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ToFileTime", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToUniversalTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public long ToFileTimeUtc()
		{
			throw null;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00015512 File Offset: 0x00013712
		[global::Cpp2ILInjected.Token(Token = "0x60005EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C182D4", Offset = "0x1C182D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToLocalTime", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.DateTime))]
		public global::System.DateTime ToLocalTime()
		{
			throw null;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00015515 File Offset: 0x00013715
		[global::Cpp2ILInjected.Token(Token = "0x60005ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19468", Offset = "0x1C19468", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "FromFileTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ToLocalTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_LocalDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "ToLocalTime", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "get_Local", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal global::System.DateTime ToLocalTime(bool throwOnOverflow)
		{
			throw null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00015518 File Offset: 0x00013718
		[global::Cpp2ILInjected.Token(Token = "0x60005EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C195B8", Offset = "0x1C195B8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "SavePlayer", MemberParameters = new object[]
		{
			"Terraria.IO.PlayerFileData",
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "InternalSavePlayerFile", MemberParameters = new object[] { "Terraria.IO.PlayerFileData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "InternalSaveMap", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "SaveWorld", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			"Terraria.IO.WorldFile.WorldSaveContext"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SocialPlatforms.Impl.Score", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0001551B File Offset: 0x0001371B
		[global::Cpp2ILInjected.Token(Token = "0x60005EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19690", Offset = "0x1C19690", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "DropTombstone", MemberParameters = new object[]
		{
			typeof(long),
			"Terraria.Localization.NetworkText",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "_InternalExtractAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(string format)
		{
			throw null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0001551E File Offset: 0x0001371E
		[global::Cpp2ILInjected.Token(Token = "0x60005F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C196FC", Offset = "0x1C196FC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "FormatDate", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00015521 File Offset: 0x00013721
		[global::Cpp2ILInjected.Token(Token = "0x60005F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19768", Offset = "0x1C19768", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMultiplayerHost", Member = "WorldDraw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIWorldSelectMenu", Member = "WorldDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISaveSynchronisation_FileList", Member = "WorldDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashDump", Member = "CreateDumpName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceListener", Member = "WriteFooter", MemberParameters = new object[] { "System.Diagnostics.TraceEventCache" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpProtocolUtils", Member = "date2string", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerResponse", Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.IO.MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "set_IfModifiedSince", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(global::System.IO.TextWriter),
			typeof(global::System.DateTime),
			"Newtonsoft.Json.DateFormatHandling",
			typeof(string),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "Trace", MemberParameters = new object[]
		{
			"System.Diagnostics.TraceLevel",
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "WriteJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1Convert", Member = "FromDateTime", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = "Mono.Security.ASN1")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00015524 File Offset: 0x00013724
		[global::Cpp2ILInjected.Token(Token = "0x60005F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C197D8", Offset = "0x1C197D8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format = default(global::System.ReadOnlySpan<char>), global::System.IFormatProvider provider = null)
		{
			throw null;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00015527 File Offset: 0x00013727
		[global::Cpp2ILInjected.Token(Token = "0x60005F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19384", Offset = "0x1C19384", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ToFileTime", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ToFileTimeUtc", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.DateTime),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpProtocolUtils", Member = "date2string", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpDateParse", Member = "ParseHttpDate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "set_IfModifiedSince", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "SwitchToUtcTime", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_dateTimeBase", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "SwitchToUtcTime", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DateTime))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new object[] { "Newtonsoft.Json.Bson.BsonToken" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "set_LastModified", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "SetEntryTimes", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			"Ionic.Zip.ZipEntrySource",
			typeof(object),
			typeof(object)
		}, ReturnType = "Ionic.Zip.ZipEntry")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1Convert", Member = "FromDateTime", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = "Mono.Security.ASN1")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.DateTime ToUniversalTime()
		{
			throw null;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0001552A File Offset: 0x0001372A
		[global::Cpp2ILInjected.Token(Token = "0x60005F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19930", Offset = "0x1C19930", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieParser", Member = "Get", ReturnType = "System.Net.Cookie")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadDateTimeString", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Nullable`1<DateTime>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool TryParse(string s, global::System.IFormatProvider provider, global::System.Globalization.DateTimeStyles styles, out global::System.DateTime result)
		{
			throw null;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0001552D File Offset: 0x0001372D
		[global::Cpp2ILInjected.Token(Token = "0x60005F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19B8C", Offset = "0x1C19B8C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadTime", MemberParameters = new object[]
		{
			"System.Security.Cryptography.DerSequenceReader.DerTag",
			typeof(string)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(string),
			"Newtonsoft.Json.DateTimeZoneHandling",
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeExact", MemberParameters = new object[]
		{
			typeof(string),
			"Newtonsoft.Json.DateTimeZoneHandling",
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static bool TryParseExact(string s, string format, global::System.IFormatProvider provider, global::System.Globalization.DateTimeStyles style, out global::System.DateTime result)
		{
			throw null;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00015530 File Offset: 0x00013730
		[global::Cpp2ILInjected.Token(Token = "0x60005F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19E4C", Offset = "0x1C19E4C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
		{
			"SoundChannel",
			"SoundDefinition",
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "Restart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "set_CurrentPosition", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityServerUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ParseTimeOfDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(ref int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZone), Member = "CalculateUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Globalization.DaylightTime)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.Lease), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.Lease), Member = "Renew", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePoint", Member = "get_HasTimedOut", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection", Member = "StartOperation", MemberParameters = new object[]
		{
			"System.Net.WebOperation",
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "AdjustTime_Reverse", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static global::System.DateTime operator +(global::System.DateTime d, global::System.TimeSpan t)
		{
			throw null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00015533 File Offset: 0x00013733
		[global::Cpp2ILInjected.Token(Token = "0x60005F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19EEC", Offset = "0x1C19EEC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityServerUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.DateTime),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatR", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZone), Member = "CalculateUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Globalization.DaylightTime)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "AdjustTime_Reverse", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static global::System.DateTime operator -(global::System.DateTime d, global::System.TimeSpan t)
		{
			throw null;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00015536 File Offset: 0x00013736
		[global::Cpp2ILInjected.Token(Token = "0x60005F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19F84", Offset = "0x1C19F84", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 77)]
		public static global::System.TimeSpan operator -(global::System.DateTime d1, global::System.DateTime d2)
		{
			throw null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00015539 File Offset: 0x00013739
		[global::Cpp2ILInjected.Token(Token = "0x60005F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19F94", Offset = "0x1C19F94", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIAchievementsMenu", Member = "AchievementOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIPlayerSelectMenu", Member = "PlayerDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIWorldSelectMenu", Member = "WorldDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISaveSynchronisation_FileList", Member = "PlayerDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISaveSynchronisation_FileList", Member = "WorldDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.AdjustmentRule) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.TransitionTime) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(global::System.TimeSpan),
			typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "GetNotAfter", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "GetNotBefore", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceEventCache", Member = "get_DateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "AgeCookies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "SetDateHeaderHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "ToUniversalTicks", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "SetEntryTimes", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "WasCurrent", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		public static bool operator ==(global::System.DateTime d1, global::System.DateTime d2)
		{
			throw null;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0001553C File Offset: 0x0001373C
		[global::Cpp2ILInjected.Token(Token = "0x60005FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19FA4", Offset = "0x1C19FA4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "get_Expired", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "ToServerString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			"System.Char[]",
			typeof(int),
			typeof(global::System.DateTime),
			"System.Nullable`1<TimeSpan>",
			typeof(global::System.DateTimeKind),
			"Newtonsoft.Json.DateFormatHandling"
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public static bool operator !=(global::System.DateTime d1, global::System.DateTime d2)
		{
			throw null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001553F File Offset: 0x0001373F
		[global::Cpp2ILInjected.Token(Token = "0x60005FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19FB4", Offset = "0x1C19FB4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "UpdateFade", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Audio.SoundEffectInstance", Member = "get_State", ReturnType = "Microsoft.Xna.Framework.Audio.SoundState")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZone), Member = "CalculateUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Globalization.DaylightTime)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509Certificate2",
			"System.Security.Cryptography.X509Certificates.X509Certificate2",
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "AgeCookies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestClient", Member = "CheckExpired", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePoint", Member = "get_HasTimedOut", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		public static bool operator <(global::System.DateTime t1, global::System.DateTime t2)
		{
			throw null;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00015542 File Offset: 0x00013742
		[global::Cpp2ILInjected.Token(Token = "0x60005FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19FC8", Offset = "0x1C19FC8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundManager", Member = "GetChannel", MemberParameters = new object[] { "SoundDefinition" }, ReturnType = "SoundChannel")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundManager", Member = "StopAllSoundsOnChannels", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundManager", Member = "IsPlaying", MemberParameters = new object[] { "SoundDefinition" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new object[]
		{
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509Certificate2",
			"System.Security.Cryptography.X509Certificates.X509Certificate2",
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "get_Expired", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "WasCurrent", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "WasCurrent", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		public static bool operator <=(global::System.DateTime t1, global::System.DateTime t2)
		{
			throw null;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00015545 File Offset: 0x00013745
		[global::Cpp2ILInjected.Token(Token = "0x60005FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19FDC", Offset = "0x1C19FDC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "StartFade", MemberParameters = new object[]
		{
			typeof(float),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundManager", Member = "GetChannel", MemberParameters = new object[] { "SoundDefinition" }, ReturnType = "SoundChannel")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIAchievementsMenu", Member = "AchievementOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIPlayerSelectMenu", Member = "PlayerDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIWorldSelectMenu", Member = "WorldDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISaveSynchronisation_FileList", Member = "PlayerDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISaveSynchronisation_FileList", Member = "WorldDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZone), Member = "CalculateUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Globalization.DaylightTime)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.Lease), Member = "Renew", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.ConnectionGroup", Member = "FindIdleConnection", MemberParameters = new object[] { "System.Net.WebOperation" }, ReturnType = "System.Net.WebConnection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "WasCurrent", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		public static bool operator >(global::System.DateTime t1, global::System.DateTime t2)
		{
			throw null;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00015548 File Offset: 0x00013748
		[global::Cpp2ILInjected.Token(Token = "0x60005FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C19FF0", Offset = "0x1C19FF0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "UpdateFade", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new object[]
		{
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZone), Member = "CalculateUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Globalization.DaylightTime)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "WasCurrent", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		public static bool operator >=(global::System.DateTime t1, global::System.DateTime t2)
		{
			throw null;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0001554B File Offset: 0x0001374B
		[global::Cpp2ILInjected.Token(Token = "0x60005FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A004", Offset = "0x1C1A004", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0001554E File Offset: 0x0001374E
		[global::Cpp2ILInjected.Token(Token = "0x6000600")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A00C", Offset = "0x1C1A00C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00015551 File Offset: 0x00013751
		[global::Cpp2ILInjected.Token(Token = "0x6000601")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A090", Offset = "0x1C1A090", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00015554 File Offset: 0x00013754
		[global::Cpp2ILInjected.Token(Token = "0x6000602")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A114", Offset = "0x1C1A114", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00015557 File Offset: 0x00013757
		[global::Cpp2ILInjected.Token(Token = "0x6000603")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A198", Offset = "0x1C1A198", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001555A File Offset: 0x0001375A
		[global::Cpp2ILInjected.Token(Token = "0x6000604")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A21C", Offset = "0x1C1A21C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0001555D File Offset: 0x0001375D
		[global::Cpp2ILInjected.Token(Token = "0x6000605")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A2A0", Offset = "0x1C1A2A0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00015560 File Offset: 0x00013760
		[global::Cpp2ILInjected.Token(Token = "0x6000606")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A324", Offset = "0x1C1A324", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00015563 File Offset: 0x00013763
		[global::Cpp2ILInjected.Token(Token = "0x6000607")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A3A8", Offset = "0x1C1A3A8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00015566 File Offset: 0x00013766
		[global::Cpp2ILInjected.Token(Token = "0x6000608")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A42C", Offset = "0x1C1A42C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00015569 File Offset: 0x00013769
		[global::Cpp2ILInjected.Token(Token = "0x6000609")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A4B0", Offset = "0x1C1A4B0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0001556C File Offset: 0x0001376C
		[global::Cpp2ILInjected.Token(Token = "0x600060A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A534", Offset = "0x1C1A534", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001556F File Offset: 0x0001376F
		[global::Cpp2ILInjected.Token(Token = "0x600060B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A5B8", Offset = "0x1C1A5B8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00015572 File Offset: 0x00013772
		[global::Cpp2ILInjected.Token(Token = "0x600060C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A63C", Offset = "0x1C1A63C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00015575 File Offset: 0x00013775
		[global::Cpp2ILInjected.Token(Token = "0x600060D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A6C0", Offset = "0x1C1A6C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private global::System.DateTime System.IConvertible.ToDateTime(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00015578 File Offset: 0x00013778
		[global::Cpp2ILInjected.Token(Token = "0x600060E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A6C8", Offset = "0x1C1A6C8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0001557B File Offset: 0x0001377B
		[global::Cpp2ILInjected.Token(Token = "0x600060F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A774", Offset = "0x1C1A774", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.GregorianCalendar), Member = "TryToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "IsLeapYear", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "DateToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out global::System.DateTime result)
		{
			throw null;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001557E File Offset: 0x0001377E
		[global::Cpp2ILInjected.Token(Token = "0x17000077")]
		public static global::System.DateTime UtcNow
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000610")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C18928", Offset = "0x1C18928", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 59)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000577 RID: 1399
		[global::Cpp2ILInjected.Token(Token = "0x6000611")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A944", Offset = "0x1C1A944", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern long GetSystemTimeAsFileTime();

		// Token: 0x06000578 RID: 1400 RVA: 0x00015581 File Offset: 0x00013781
		[global::Cpp2ILInjected.Token(Token = "0x6000612")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A948", Offset = "0x1C1A948", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal long ToBinaryRaw()
		{
			throw null;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00015584 File Offset: 0x00013784
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000613")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1A950", Offset = "0x1C1A950", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static DateTime()
		{
			throw null;
		}

		// Token: 0x0400013D RID: 317
		[global::Cpp2ILInjected.Token(Token = "0x4000224")]
		private const long TicksPerMillisecond = 10000L;

		// Token: 0x0400013E RID: 318
		[global::Cpp2ILInjected.Token(Token = "0x4000225")]
		private const long TicksPerSecond = 10000000L;

		// Token: 0x0400013F RID: 319
		[global::Cpp2ILInjected.Token(Token = "0x4000226")]
		private const long TicksPerMinute = 600000000L;

		// Token: 0x04000140 RID: 320
		[global::Cpp2ILInjected.Token(Token = "0x4000227")]
		private const long TicksPerHour = 36000000000L;

		// Token: 0x04000141 RID: 321
		[global::Cpp2ILInjected.Token(Token = "0x4000228")]
		private const long TicksPerDay = 864000000000L;

		// Token: 0x04000142 RID: 322
		[global::Cpp2ILInjected.Token(Token = "0x4000229")]
		private const int MillisPerSecond = 1000;

		// Token: 0x04000143 RID: 323
		[global::Cpp2ILInjected.Token(Token = "0x400022A")]
		private const int MillisPerMinute = 60000;

		// Token: 0x04000144 RID: 324
		[global::Cpp2ILInjected.Token(Token = "0x400022B")]
		private const int MillisPerHour = 3600000;

		// Token: 0x04000145 RID: 325
		[global::Cpp2ILInjected.Token(Token = "0x400022C")]
		private const int MillisPerDay = 86400000;

		// Token: 0x04000146 RID: 326
		[global::Cpp2ILInjected.Token(Token = "0x400022D")]
		private const int DaysPerYear = 365;

		// Token: 0x04000147 RID: 327
		[global::Cpp2ILInjected.Token(Token = "0x400022E")]
		private const int DaysPer4Years = 1461;

		// Token: 0x04000148 RID: 328
		[global::Cpp2ILInjected.Token(Token = "0x400022F")]
		private const int DaysPer100Years = 36524;

		// Token: 0x04000149 RID: 329
		[global::Cpp2ILInjected.Token(Token = "0x4000230")]
		private const int DaysPer400Years = 146097;

		// Token: 0x0400014A RID: 330
		[global::Cpp2ILInjected.Token(Token = "0x4000231")]
		private const int DaysTo1601 = 584388;

		// Token: 0x0400014B RID: 331
		[global::Cpp2ILInjected.Token(Token = "0x4000232")]
		private const int DaysTo1899 = 693593;

		// Token: 0x0400014C RID: 332
		[global::Cpp2ILInjected.Token(Token = "0x4000233")]
		internal const int DaysTo1970 = 719162;

		// Token: 0x0400014D RID: 333
		[global::Cpp2ILInjected.Token(Token = "0x4000234")]
		private const int DaysTo10000 = 3652059;

		// Token: 0x0400014E RID: 334
		[global::Cpp2ILInjected.Token(Token = "0x4000235")]
		internal const long MinTicks = 0L;

		// Token: 0x0400014F RID: 335
		[global::Cpp2ILInjected.Token(Token = "0x4000236")]
		internal const long MaxTicks = 3155378975999999999L;

		// Token: 0x04000150 RID: 336
		[global::Cpp2ILInjected.Token(Token = "0x4000237")]
		private const long MaxMillis = 315537897600000L;

		// Token: 0x04000151 RID: 337
		[global::Cpp2ILInjected.Token(Token = "0x4000238")]
		internal const long UnixEpochTicks = 621355968000000000L;

		// Token: 0x04000152 RID: 338
		[global::Cpp2ILInjected.Token(Token = "0x4000239")]
		private const long FileTimeOffset = 504911232000000000L;

		// Token: 0x04000153 RID: 339
		[global::Cpp2ILInjected.Token(Token = "0x400023A")]
		private const long DoubleDateOffset = 599264352000000000L;

		// Token: 0x04000154 RID: 340
		[global::Cpp2ILInjected.Token(Token = "0x400023B")]
		private const long OADateMinAsTicks = 31241376000000000L;

		// Token: 0x04000155 RID: 341
		[global::Cpp2ILInjected.Token(Token = "0x400023C")]
		private const double OADateMinAsDouble = -657435.0;

		// Token: 0x04000156 RID: 342
		[global::Cpp2ILInjected.Token(Token = "0x400023D")]
		private const double OADateMaxAsDouble = 2958466.0;

		// Token: 0x04000157 RID: 343
		[global::Cpp2ILInjected.Token(Token = "0x400023E")]
		private const int DatePartYear = 0;

		// Token: 0x04000158 RID: 344
		[global::Cpp2ILInjected.Token(Token = "0x400023F")]
		private const int DatePartDayOfYear = 1;

		// Token: 0x04000159 RID: 345
		[global::Cpp2ILInjected.Token(Token = "0x4000240")]
		private const int DatePartMonth = 2;

		// Token: 0x0400015A RID: 346
		[global::Cpp2ILInjected.Token(Token = "0x4000241")]
		private const int DatePartDay = 3;

		// Token: 0x0400015B RID: 347
		[global::Cpp2ILInjected.Token(Token = "0x4000242")]
		private static readonly int[] s_daysToMonth365;

		// Token: 0x0400015C RID: 348
		[global::Cpp2ILInjected.Token(Token = "0x4000243")]
		private static readonly int[] s_daysToMonth366;

		// Token: 0x0400015D RID: 349
		[global::Cpp2ILInjected.Token(Token = "0x4000244")]
		public static readonly global::System.DateTime MinValue;

		// Token: 0x0400015E RID: 350
		[global::Cpp2ILInjected.Token(Token = "0x4000245")]
		public static readonly global::System.DateTime MaxValue;

		// Token: 0x0400015F RID: 351
		[global::Cpp2ILInjected.Token(Token = "0x4000246")]
		public static readonly global::System.DateTime UnixEpoch;

		// Token: 0x04000160 RID: 352
		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		private const ulong TicksMask = 4611686018427387903UL;

		// Token: 0x04000161 RID: 353
		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		private const ulong FlagsMask = 13835058055282163712UL;

		// Token: 0x04000162 RID: 354
		[global::Cpp2ILInjected.Token(Token = "0x4000249")]
		private const ulong LocalMask = 9223372036854775808UL;

		// Token: 0x04000163 RID: 355
		[global::Cpp2ILInjected.Token(Token = "0x400024A")]
		private const long TicksCeiling = 4611686018427387904L;

		// Token: 0x04000164 RID: 356
		[global::Cpp2ILInjected.Token(Token = "0x400024B")]
		private const ulong KindUnspecified = 0UL;

		// Token: 0x04000165 RID: 357
		[global::Cpp2ILInjected.Token(Token = "0x400024C")]
		private const ulong KindUtc = 4611686018427387904UL;

		// Token: 0x04000166 RID: 358
		[global::Cpp2ILInjected.Token(Token = "0x400024D")]
		private const ulong KindLocal = 9223372036854775808UL;

		// Token: 0x04000167 RID: 359
		[global::Cpp2ILInjected.Token(Token = "0x400024E")]
		private const ulong KindLocalAmbiguousDst = 13835058055282163712UL;

		// Token: 0x04000168 RID: 360
		[global::Cpp2ILInjected.Token(Token = "0x400024F")]
		private const int KindShift = 62;

		// Token: 0x04000169 RID: 361
		[global::Cpp2ILInjected.Token(Token = "0x4000250")]
		private const string TicksField = "ticks";

		// Token: 0x0400016A RID: 362
		[global::Cpp2ILInjected.Token(Token = "0x4000251")]
		private const string DateDataField = "dateData";

		// Token: 0x0400016B RID: 363
		[global::Cpp2ILInjected.Token(Token = "0x4000252")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly ulong _dateData;
	}
}
