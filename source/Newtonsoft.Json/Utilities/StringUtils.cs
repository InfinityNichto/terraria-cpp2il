using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005C RID: 92
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000074")]
	internal static class StringUtils
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x00002C1B File Offset: 0x00000E1B
		[global::Cpp2ILInjected.Token(Token = "0x6000425")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCEA24", Offset = "0x1CCEA24", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 172)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0)
		{
			throw null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002C1E File Offset: 0x00000E1E
		[global::Cpp2ILInjected.Token(Token = "0x6000426")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC998", Offset = "0x1CCC998", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 51)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1)
		{
			throw null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002C21 File Offset: 0x00000E21
		[global::Cpp2ILInjected.Token(Token = "0x6000427")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDEF3C", Offset = "0x1CDEF3C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "IsValidCallback", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(ParameterInfo[]),
			typeof(Type),
			typeof(MethodInfo),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ShouldDeserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldSerialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "IsSpecified", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2)
		{
			throw null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002C24 File Offset: 0x00000E24
		[global::Cpp2ILInjected.Token(Token = "0x6000428")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF018", Offset = "0x1CDF018", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "IsValidCallback", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(ParameterInfo[]),
			typeof(Type),
			typeof(MethodInfo),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			throw null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002C27 File Offset: 0x00000E27
		[global::Cpp2ILInjected.Token(Token = "0x6000429")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDEED0", Offset = "0x1CDEED0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string FormatWith(this string format, IFormatProvider provider, params object[] args)
		{
			throw null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002C2A File Offset: 0x00000E2A
		[global::Cpp2ILInjected.Token(Token = "0x600042A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCEC70", Offset = "0x1CCEC70", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool IsWhiteSpace(string s)
		{
			throw null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002C2D File Offset: 0x00000E2D
		[global::Cpp2ILInjected.Token(Token = "0x600042B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF11C", Offset = "0x1CDF11C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IsoDateTimeConverter), Member = "set_DateTimeFormat", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		public static string NullEmptyString(string s)
		{
			throw null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002C30 File Offset: 0x00000E30
		[global::Cpp2ILInjected.Token(Token = "0x600042C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9A10", Offset = "0x1CD9A10", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateFormatHandling),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(DateFormatHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(bool),
			typeof(StringEscapeHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanQueryExpression), Member = "EqualsWithStringCoercion", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JValue)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(IFormatProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static StringWriter CreateStringWriter(int capacity)
		{
			throw null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002C33 File Offset: 0x00000E33
		[global::Cpp2ILInjected.Token(Token = "0x600042D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD99A8", Offset = "0x1CD99A8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(bool),
			typeof(StringEscapeHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static int? GetLength(string value)
		{
			throw null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002C36 File Offset: 0x00000E36
		[global::Cpp2ILInjected.Token(Token = "0x600042E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9700", Offset = "0x1CD9700", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptString", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(string),
			typeof(char),
			typeof(bool),
			typeof(bool[]),
			typeof(StringEscapeHandling),
			typeof(IArrayPool<char>),
			typeof(ref char[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
			throw null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002C39 File Offset: 0x00000E39
		[global::Cpp2ILInjected.Token(Token = "0x600042F")]
		[global::Cpp2ILInjected.Address(RVA = "0x159FB94", Offset = "0x159FB94", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			throw null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002C3C File Offset: 0x00000E3C
		[global::Cpp2ILInjected.Token(Token = "0x6000430")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD8004", Offset = "0x1CD8004", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumUtils), Member = "ToEnumName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CamelCasePropertyNamesContractResolver), Member = "ResolvePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new object[]
		{
			typeof(char),
			typeof(CultureInfo)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string ToCamelCase(string s)
		{
			throw null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002C3F File Offset: 0x00000E3F
		[global::Cpp2ILInjected.Token(Token = "0x6000431")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF13C", Offset = "0x1CDF13C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsHighSurrogate(char c)
		{
			throw null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002C42 File Offset: 0x00000E42
		[global::Cpp2ILInjected.Token(Token = "0x6000432")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF194", Offset = "0x1CDF194", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsLowSurrogate(char c)
		{
			throw null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002C45 File Offset: 0x00000E45
		[global::Cpp2ILInjected.Token(Token = "0x6000433")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF1EC", Offset = "0x1CDF1EC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode),
			typeof(string),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public static bool StartsWith(this string source, char value)
		{
			throw null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002C48 File Offset: 0x00000E48
		[global::Cpp2ILInjected.Token(Token = "0x6000434")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF228", Offset = "0x1CDF228", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public static bool EndsWith(this string source, char value)
		{
			throw null;
		}

		// Token: 0x040001C0 RID: 448
		[global::Cpp2ILInjected.Token(Token = "0x4000203")]
		public const string CarriageReturnLineFeed = "\r\n";

		// Token: 0x040001C1 RID: 449
		[global::Cpp2ILInjected.Token(Token = "0x4000204")]
		public const string Empty = "";

		// Token: 0x040001C2 RID: 450
		[global::Cpp2ILInjected.Token(Token = "0x4000205")]
		public const char CarriageReturn = '\r';

		// Token: 0x040001C3 RID: 451
		[global::Cpp2ILInjected.Token(Token = "0x4000206")]
		public const char LineFeed = '\n';

		// Token: 0x040001C4 RID: 452
		[global::Cpp2ILInjected.Token(Token = "0x4000207")]
		public const char Tab = '\t';

		// Token: 0x0200010A RID: 266
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000075")]
		private sealed class <>c__DisplayClass15_0<TSource>
		{
			// Token: 0x06000AC6 RID: 2758 RVA: 0x00003FCE File Offset: 0x000021CE
			[global::Cpp2ILInjected.Token(Token = "0x6000435")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B2498", Offset = "0x15B2498", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass15_0()
			{
				throw null;
			}

			// Token: 0x06000AC7 RID: 2759 RVA: 0x00003FD1 File Offset: 0x000021D1
			[global::Cpp2ILInjected.Token(Token = "0x6000436")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B24A0", Offset = "0x15B24A0", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(bool))]
			internal bool <ForgivingCaseSensitiveFind>b__0(TSource s)
			{
				throw null;
			}

			// Token: 0x06000AC8 RID: 2760 RVA: 0x00003FD4 File Offset: 0x000021D4
			[global::Cpp2ILInjected.Token(Token = "0x6000437")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B24D4", Offset = "0x15B24D4", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(bool))]
			internal bool <ForgivingCaseSensitiveFind>b__1(TSource s)
			{
				throw null;
			}

			// Token: 0x040003A7 RID: 935
			[global::Cpp2ILInjected.Token(Token = "0x4000208")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Func<TSource, string> valueSelector;

			// Token: 0x040003A8 RID: 936
			[global::Cpp2ILInjected.Token(Token = "0x4000209")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public string testValue;
		}
	}
}
