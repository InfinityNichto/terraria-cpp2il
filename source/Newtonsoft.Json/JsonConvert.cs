using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000031 RID: 49
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000033")]
	public static class JsonConvert
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000257F File Offset: 0x0000077F
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002582 File Offset: 0x00000782
		[global::Cpp2ILInjected.Token(Token = "0x17000064")]
		public static Func<JsonSerializerSettings> DefaultSettings
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC440C", Offset = "0x1CC440C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC4464", Offset = "0x1CC4464", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002585 File Offset: 0x00000785
		[global::Cpp2ILInjected.Token(Token = "0x60001A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC44C0", Offset = "0x1CC44C0", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static JsonConvert()
		{
			throw null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002588 File Offset: 0x00000788
		[global::Cpp2ILInjected.Token(Token = "0x60001A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4698", Offset = "0x1CC4698", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static JsonSerializerSettings GetDefaultSettings()
		{
			throw null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000258B File Offset: 0x0000078B
		[global::Cpp2ILInjected.Token(Token = "0x60001A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC46F0", Offset = "0x1CC46F0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(DateTime value)
		{
			throw null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000258E File Offset: 0x0000078E
		[global::Cpp2ILInjected.Token(Token = "0x60001A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC474C", Offset = "0x1CC474C", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "CreateStringWriter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(DateTime),
			typeof(DateFormatHandling),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling)
		{
			throw null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002591 File Offset: 0x00000791
		[global::Cpp2ILInjected.Token(Token = "0x60001A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC49B0", Offset = "0x1CC49B0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002594 File Offset: 0x00000794
		[global::Cpp2ILInjected.Token(Token = "0x60001A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4A18", Offset = "0x1CC4A18", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "CreateStringWriter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeOffsetString", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(DateTimeOffset),
			typeof(DateFormatHandling),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static string ToString(DateTimeOffset value, DateFormatHandling format)
		{
			throw null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002597 File Offset: 0x00000797
		[global::Cpp2ILInjected.Token(Token = "0x60001A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC10C8", Offset = "0x1CC10C8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(bool value)
		{
			throw null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000259A File Offset: 0x0000079A
		[global::Cpp2ILInjected.Token(Token = "0x60001AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1220", Offset = "0x1CC1220", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string ToString(char value)
		{
			throw null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000259D File Offset: 0x0000079D
		[global::Cpp2ILInjected.Token(Token = "0x60001AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4CB4", Offset = "0x1CC4CB4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string ToString(Enum value)
		{
			throw null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000025A0 File Offset: 0x000007A0
		[global::Cpp2ILInjected.Token(Token = "0x60001AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4D00", Offset = "0x1CC4D00", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(int value)
		{
			throw null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000025A3 File Offset: 0x000007A3
		[global::Cpp2ILInjected.Token(Token = "0x60001AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4D6C", Offset = "0x1CC4D6C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(short value)
		{
			throw null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000025A6 File Offset: 0x000007A6
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4DD8", Offset = "0x1CC4DD8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(ushort value)
		{
			throw null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000025A9 File Offset: 0x000007A9
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60001AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4E44", Offset = "0x1CC4E44", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(uint value)
		{
			throw null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000025AC File Offset: 0x000007AC
		[global::Cpp2ILInjected.Token(Token = "0x60001B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4EB0", Offset = "0x1CC4EB0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(long value)
		{
			throw null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000025AF File Offset: 0x000007AF
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60001B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4F1C", Offset = "0x1CC4F1C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(ulong value)
		{
			throw null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000025B2 File Offset: 0x000007B2
		[global::Cpp2ILInjected.Token(Token = "0x60001B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4F88", Offset = "0x1CC4F88", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "EnsureDecimalPlace", MemberParameters = new object[]
		{
			typeof(double),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string ToString(float value)
		{
			throw null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000025B5 File Offset: 0x000007B5
		[global::Cpp2ILInjected.Token(Token = "0x60001B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0BE4", Offset = "0x1CC0BE4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(float?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "EnsureDecimalPlace", MemberParameters = new object[]
		{
			typeof(double),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "EnsureFloatFormat", MemberParameters = new object[]
		{
			typeof(double),
			typeof(string),
			typeof(FloatFormatHandling),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			throw null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000025B8 File Offset: 0x000007B8
		[global::Cpp2ILInjected.Token(Token = "0x60001B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC519C", Offset = "0x1CC519C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(float),
			typeof(FloatFormatHandling),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(double),
			typeof(FloatFormatHandling),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			throw null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000025BB File Offset: 0x000007BB
		[global::Cpp2ILInjected.Token(Token = "0x60001B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC5320", Offset = "0x1CC5320", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "EnsureDecimalPlace", MemberParameters = new object[]
		{
			typeof(double),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string ToString(double value)
		{
			throw null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000025BE File Offset: 0x000007BE
		[global::Cpp2ILInjected.Token(Token = "0x60001B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0E5C", Offset = "0x1CC0E5C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(double?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "EnsureDecimalPlace", MemberParameters = new object[]
		{
			typeof(double),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "EnsureFloatFormat", MemberParameters = new object[]
		{
			typeof(double),
			typeof(string),
			typeof(FloatFormatHandling),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			throw null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000025C1 File Offset: 0x000007C1
		[global::Cpp2ILInjected.Token(Token = "0x60001B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC5054", Offset = "0x1CC5054", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(float),
			typeof(FloatFormatHandling),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(double),
			typeof(FloatFormatHandling),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static string EnsureDecimalPlace(double value, string text)
		{
			throw null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000025C4 File Offset: 0x000007C4
		[global::Cpp2ILInjected.Token(Token = "0x60001B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC53E8", Offset = "0x1CC53E8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string EnsureDecimalPlace(string text)
		{
			throw null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000025C7 File Offset: 0x000007C7
		[global::Cpp2ILInjected.Token(Token = "0x60001B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC545C", Offset = "0x1CC545C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(byte value)
		{
			throw null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000025CA File Offset: 0x000007CA
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC54C8", Offset = "0x1CC54C8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(sbyte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(sbyte value)
		{
			throw null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000025CD File Offset: 0x000007CD
		[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC13A0", Offset = "0x1CC13A0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "EnsureDecimalPlace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string ToString(decimal value)
		{
			throw null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000025D0 File Offset: 0x000007D0
		[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC5534", Offset = "0x1CC5534", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(Guid value)
		{
			throw null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000025D3 File Offset: 0x000007D3
		[global::Cpp2ILInjected.Token(Token = "0x60001BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC559C", Offset = "0x1CC559C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static string ToString(Guid value, char quoteChar)
		{
			throw null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000025D6 File Offset: 0x000007D6
		[global::Cpp2ILInjected.Token(Token = "0x60001BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC5654", Offset = "0x1CC5654", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(TimeSpan value)
		{
			throw null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000025D9 File Offset: 0x000007D9
		[global::Cpp2ILInjected.Token(Token = "0x60001BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC56AC", Offset = "0x1CC56AC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string ToString(TimeSpan value, char quoteChar)
		{
			throw null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000025DC File Offset: 0x000007DC
		[global::Cpp2ILInjected.Token(Token = "0x60001C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC5790", Offset = "0x1CC5790", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string ToString(Uri value)
		{
			throw null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000025DF File Offset: 0x000007DF
		[global::Cpp2ILInjected.Token(Token = "0x60001C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC5844", Offset = "0x1CC5844", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string ToString(Uri value, char quoteChar)
		{
			throw null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000025E2 File Offset: 0x000007E2
		[global::Cpp2ILInjected.Token(Token = "0x60001C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4C5C", Offset = "0x1CC4C5C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(string value)
		{
			throw null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000025E5 File Offset: 0x000007E5
		[global::Cpp2ILInjected.Token(Token = "0x60001C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC5728", Offset = "0x1CC5728", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(StringEscapeHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(string value, char delimiter)
		{
			throw null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000025E8 File Offset: 0x000007E8
		[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC58BC", Offset = "0x1CC58BC", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(bool),
			typeof(StringEscapeHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			throw null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000025EB File Offset: 0x000007EB
		[global::Cpp2ILInjected.Token(Token = "0x60001C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC59A0", Offset = "0x1CC59A0", Length = "0x798")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 68)]
		public static string ToString(object value)
		{
			throw null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000025EE File Offset: 0x000007EE
		[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6138", Offset = "0x1CC6138", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string SerializeObject(object value)
		{
			throw null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000025F1 File Offset: 0x000007F1
		[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6210", Offset = "0x1CC6210", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.FavoritesFile", Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string SerializeObject(object value, Formatting formatting)
		{
			throw null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000025F4 File Offset: 0x000007F4
		[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC62E8", Offset = "0x1CC62E8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string SerializeObject(object value, params JsonConverter[] converters)
		{
			throw null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000025F7 File Offset: 0x000007F7
		[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC638C", Offset = "0x1CC638C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeXmlNode", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(Formatting)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeXmlNode", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(Formatting),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeXNode", MemberParameters = new object[]
		{
			typeof(XObject),
			typeof(Formatting),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string SerializeObject(object value, Formatting formatting, params JsonConverter[] converters)
		{
			throw null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000025FA File Offset: 0x000007FA
		[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC64D0", Offset = "0x1CC64D0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string SerializeObject(object value, JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000025FD File Offset: 0x000007FD
		[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6194", Offset = "0x1CC6194", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonConverter[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(JsonSerializer)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string SerializeObject(object value, Type type, JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002600 File Offset: 0x00000800
		[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6278", Offset = "0x1CC6278", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceStyles_Layout", Member = "SaveConfiguration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControlsStyles_Layout", Member = "SaveConfiguration", MemberParameters = new object[] { "Terraria.IO.Preferences" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Save", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(Formatting),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002603 File Offset: 0x00000803
		[global::Cpp2ILInjected.Token(Token = "0x60001CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6438", Offset = "0x1CC6438", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Formatting),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(JsonSerializer)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002606 File Offset: 0x00000806
		[global::Cpp2ILInjected.Token(Token = "0x60001CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC656C", Offset = "0x1CC656C", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(Formatting),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(IFormatProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "set_Formatting", MemberParameters = new object[] { typeof(Formatting) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer)
		{
			throw null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002609 File Offset: 0x00000809
		[global::Cpp2ILInjected.Token(Token = "0x60001CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC67F8", Offset = "0x1CC67F8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static object DeserializeObject(string value)
		{
			throw null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000260C File Offset: 0x0000080C
		[global::Cpp2ILInjected.Token(Token = "0x60001D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6AAC", Offset = "0x1CC6AAC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static object DeserializeObject(string value, JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000260F File Offset: 0x0000080F
		[global::Cpp2ILInjected.Token(Token = "0x60001D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6B14", Offset = "0x1CC6B14", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static object DeserializeObject(string value, Type type)
		{
			throw null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002612 File Offset: 0x00000812
		[global::Cpp2ILInjected.Token(Token = "0x60001D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C824", Offset = "0x158C824", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static T DeserializeObject<T>(string value)
		{
			throw null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002615 File Offset: 0x00000815
		[global::Cpp2ILInjected.Token(Token = "0x60001D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C744", Offset = "0x158C744", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
		{
			throw null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002618 File Offset: 0x00000818
		[global::Cpp2ILInjected.Token(Token = "0x60001D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C7B0", Offset = "0x158C7B0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000261B File Offset: 0x0000081B
		[global::Cpp2ILInjected.Token(Token = "0x60001D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x158CBD4", Offset = "0x158CBD4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(JsonConverter[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static T DeserializeObject<T>(string value, params JsonConverter[] converters)
		{
			throw null;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000261E File Offset: 0x0000081E
		[global::Cpp2ILInjected.Token(Token = "0x60001D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C9E4", Offset = "0x158C9E4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002621 File Offset: 0x00000821
		[global::Cpp2ILInjected.Token(Token = "0x60001D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6B7C", Offset = "0x1CC6B7C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(JsonConverter[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXmlNode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(XmlDocument))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXNode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(XDocument))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
		{
			throw null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002624 File Offset: 0x00000824
		[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6854", Offset = "0x1CC6854", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(JsonSerializerSettings)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(JsonConverter[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new object[] { typeof(TextReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002627 File Offset: 0x00000827
		[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6C70", Offset = "0x1CC6C70", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void PopulateObject(string value, object target)
		{
			throw null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000262A File Offset: 0x0000082A
		[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6CD8", Offset = "0x1CC6CD8", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceStyles_Layout", Member = "LoadConfiguration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControlsStyles_Layout", Member = "LoadConfiguration", MemberParameters = new object[] { "Terraria.IO.Preferences" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new object[] { typeof(TextReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static void PopulateObject(string value, object target, JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000262D File Offset: 0x0000082D
		[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6F50", Offset = "0x1CC6F50", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string SerializeXmlNode(XmlNode node)
		{
			throw null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002630 File Offset: 0x00000830
		[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6FA8", Offset = "0x1CC6FA8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Formatting),
			typeof(JsonConverter[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static string SerializeXmlNode(XmlNode node, Formatting formatting)
		{
			throw null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002633 File Offset: 0x00000833
		[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC7084", Offset = "0x1CC7084", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Formatting),
			typeof(JsonConverter[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject)
		{
			throw null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002636 File Offset: 0x00000836
		[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC7174", Offset = "0x1CC7174", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XmlDocument DeserializeXmlNode(string value)
		{
			throw null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002639 File Offset: 0x00000839
		[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC71CC", Offset = "0x1CC71CC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName)
		{
			throw null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000263C File Offset: 0x0000083C
		[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC7234", Offset = "0x1CC7234", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(JsonConverter[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			throw null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000263F File Offset: 0x0000083F
		[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC73C4", Offset = "0x1CC73C4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string SerializeXNode(XObject node)
		{
			throw null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002642 File Offset: 0x00000842
		[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC741C", Offset = "0x1CC741C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string SerializeXNode(XObject node, Formatting formatting)
		{
			throw null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002645 File Offset: 0x00000845
		[global::Cpp2ILInjected.Token(Token = "0x60001E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC7484", Offset = "0x1CC7484", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Formatting),
			typeof(JsonConverter[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static string SerializeXNode(XObject node, Formatting formatting, bool omitRootObject)
		{
			throw null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002648 File Offset: 0x00000848
		[global::Cpp2ILInjected.Token(Token = "0x60001E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC7574", Offset = "0x1CC7574", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XDocument DeserializeXNode(string value)
		{
			throw null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000264B File Offset: 0x0000084B
		[global::Cpp2ILInjected.Token(Token = "0x60001E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC75CC", Offset = "0x1CC75CC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XDocument DeserializeXNode(string value, string deserializeRootElementName)
		{
			throw null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000264E File Offset: 0x0000084E
		[global::Cpp2ILInjected.Token(Token = "0x60001E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC7634", Offset = "0x1CC7634", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(JsonConverter[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			throw null;
		}

		// Token: 0x040000D7 RID: 215
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
		private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField;

		// Token: 0x040000D8 RID: 216
		[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
		public static readonly string True;

		// Token: 0x040000D9 RID: 217
		[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
		public static readonly string False;

		// Token: 0x040000DA RID: 218
		[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
		public static readonly string Null;

		// Token: 0x040000DB RID: 219
		[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
		public static readonly string Undefined;

		// Token: 0x040000DC RID: 220
		[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
		public static readonly string PositiveInfinity;

		// Token: 0x040000DD RID: 221
		[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
		public static readonly string NegativeInfinity;

		// Token: 0x040000DE RID: 222
		[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
		public static readonly string NaN;

		// Token: 0x040000DF RID: 223
		[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
		private static readonly JsonSerializerSettings InitialSerializerSettings;
	}
}
