using System;
using System.Globalization;
using System.IO;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001E0")]
	public static class WebUtility
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20F78", Offset = "0x1F20F78", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "IndexOfHtmlEncodingChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static string HtmlEncode(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F211DC", Offset = "0x1F211DC", Length = "0x3B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "IndexOfHtmlEncodingChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "get_HtmlEncodeConformance", ReturnType = typeof(UnicodeEncodingConformance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "GetNextUnicodeScalarValueFromUtf16Surrogate", MemberParameters = new object[]
		{
			typeof(ref char*),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public unsafe static void HtmlEncode(string value, TextWriter output)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F21728", Offset = "0x1F21728", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "StringRequiresHtmlDecoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "HtmlDecode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string HtmlDecode(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F21938", Offset = "0x1F21938", Length = "0x408")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "HtmlDecode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "StringRequiresHtmlDecoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "get_HtmlDecodeConformance", ReturnType = typeof(UnicodeDecodingConformance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility.HtmlEntities), Member = "Lookup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void HtmlDecode(string value, TextWriter output)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F21090", Offset = "0x1F21090", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "get_HtmlEncodeConformance", ReturnType = typeof(UnicodeEncodingConformance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int IndexOfHtmlEncodingChars(string s, int startPos)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000277")]
		private static UnicodeDecodingConformance HtmlDecodeConformance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F21D40", Offset = "0x1F21D40", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "HtmlDecode", MemberParameters = new object[]
			{
				typeof(string),
				typeof(TextWriter)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "StringRequiresHtmlDecoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000278")]
		private static UnicodeEncodingConformance HtmlEncodeConformance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2158C", Offset = "0x1F2158C", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new object[]
			{
				typeof(string),
				typeof(TextWriter)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "IndexOfHtmlEncodingChars", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F21E5C", Offset = "0x1F21E5C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlEncodeToBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static byte[] UrlEncode(byte[] bytes, int offset, int count, bool alwaysCreateNewReturnValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F21F2C", Offset = "0x1F21F2C", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "ValidateUrlEncodingParameters", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static byte[] UrlEncode(byte[] bytes, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F22368", Offset = "0x1F22368", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string UrlEncode(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F22424", Offset = "0x1F22424", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] UrlEncodeToBytes(byte[] value, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F22494", Offset = "0x1F22494", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlDecode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility.UrlDecoder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility.UrlDecoder), Member = "AddChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility.UrlDecoder), Member = "AddByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility.UrlDecoder), Member = "GetString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string UrlDecodeInternal(string value, Encoding encoding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F22700", Offset = "0x1F22700", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlDecodeToBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "ValidateUrlEncodingParameters", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static byte[] UrlDecodeInternal(byte[] bytes, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F22914", Offset = "0x1F22914", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref ListenerPrefix)
		}, ReturnType = typeof(HttpListener))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "CreateQueryString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Encoding)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string UrlDecode(string encodedValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F22990", Offset = "0x1F22990", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F21E24", Offset = "0x1F21E24", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void ConvertSmpToUtf16(uint smpChar, out char leadingSurrogate, out char trailingSurrogate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F21670", Offset = "0x1F21670", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogatePair", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static int GetNextUnicodeScalarValueFromUtf16Surrogate(ref char* pch, ref int charsRemaining)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F226B0", Offset = "0x1F226B0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int HexToInt(char h)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F22350", Offset = "0x1F22350", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static char IntToHex(int n)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F222DC", Offset = "0x1F222DC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsUrlSafeChar(char ch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F22200", Offset = "0x1F22200", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool ValidateUrlEncodingParameters(byte[] bytes, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F21838", Offset = "0x1F21838", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "HtmlDecode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "HtmlDecode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "get_HtmlDecodeConformance", ReturnType = typeof(UnicodeDecodingConformance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool StringRequiresHtmlDecoding(string s)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000BFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F229FC", Offset = "0x1F229FC", Length = "0x1094")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static WebUtility()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000A1E")]
		private const char HIGH_SURROGATE_START = '\ud800';

		[global::Cpp2ILInjected.Token(Token = "0x4000A1F")]
		private const char LOW_SURROGATE_START = '\udc00';

		[global::Cpp2ILInjected.Token(Token = "0x4000A20")]
		private const char LOW_SURROGATE_END = '\udfff';

		[global::Cpp2ILInjected.Token(Token = "0x4000A21")]
		private const int UNICODE_PLANE00_END = 65535;

		[global::Cpp2ILInjected.Token(Token = "0x4000A22")]
		private const int UNICODE_PLANE01_START = 65536;

		[global::Cpp2ILInjected.Token(Token = "0x4000A23")]
		private const int UNICODE_PLANE16_END = 1114111;

		[global::Cpp2ILInjected.Token(Token = "0x4000A24")]
		private const int UnicodeReplacementChar = 65533;

		[global::Cpp2ILInjected.Token(Token = "0x4000A25")]
		private static readonly char[] _htmlEntityEndingChars;

		[global::Cpp2ILInjected.Token(Token = "0x4000A26")]
		private static UnicodeDecodingConformance _htmlDecodeConformance;

		[global::Cpp2ILInjected.Token(Token = "0x4000A27")]
		private static UnicodeEncodingConformance _htmlEncodeConformance;

		[global::Cpp2ILInjected.Token(Token = "0x20001E1")]
		private class UrlDecoder
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F23A90", Offset = "0x1F23A90", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility.UrlDecoder), Member = "AddChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility.UrlDecoder), Member = "GetString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			private void FlushBytes()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000BFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F23AE8", Offset = "0x1F23AE8", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Encoding)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal UrlDecoder(int bufferSize, Encoding encoding)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000BFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F23B5C", Offset = "0x1F23B5C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Encoding)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility.UrlDecoder), Member = "FlushBytes", ReturnType = typeof(void))]
			internal void AddChar(char ch)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000BFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F23BA4", Offset = "0x1F23BA4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Encoding)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void AddByte(byte b)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000BFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F23C14", Offset = "0x1F23C14", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Encoding)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility.UrlDecoder), Member = "FlushBytes", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string GetString()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000A28")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int _bufferSize;

			[global::Cpp2ILInjected.Token(Token = "0x4000A29")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private int _numChars;

			[global::Cpp2ILInjected.Token(Token = "0x4000A2A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private char[] _charBuffer;

			[global::Cpp2ILInjected.Token(Token = "0x4000A2B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _numBytes;

			[global::Cpp2ILInjected.Token(Token = "0x4000A2C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private byte[] _byteBuffer;

			[global::Cpp2ILInjected.Token(Token = "0x4000A2D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Encoding _encoding;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20001E2")]
		private static class HtmlEntities
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C00")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F23C9C", Offset = "0x1F23C9C", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility), Member = "HtmlDecode", MemberParameters = new object[]
			{
				typeof(string),
				typeof(TextWriter)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility.HtmlEntities), Member = "CalculateKeyValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]", "T" }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public static char Lookup(string entity)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000C01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F23D6C", Offset = "0x1F23D6C", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebUtility.HtmlEntities), Member = "Lookup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			private static long CalculateKeyValue(string s)
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000C02")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F23DF8", Offset = "0x1F23DF8", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			static HtmlEntities()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000A2E")]
			private static readonly long[] entities;

			[global::Cpp2ILInjected.Token(Token = "0x4000A2F")]
			private static readonly char[] entities_values;
		}
	}
}
