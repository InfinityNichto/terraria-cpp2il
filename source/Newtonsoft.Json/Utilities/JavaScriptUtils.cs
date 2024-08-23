using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000055 RID: 85
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	internal static class JavaScriptUtils
	{
		// Token: 0x06000385 RID: 901 RVA: 0x00002B07 File Offset: 0x00000D07
		[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD85E4", Offset = "0x1CD85E4", Length = "0xB64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<char>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Union", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		static JavaScriptUtils()
		{
			throw null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002B0A File Offset: 0x00000D0A
		[global::Cpp2ILInjected.Token(Token = "0x60003BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9148", Offset = "0x1CD9148", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "UpdateCharEscapeFlags", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(bool),
			typeof(StringEscapeHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			throw null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002B0D File Offset: 0x00000D0D
		[global::Cpp2ILInjected.Token(Token = "0x60003BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD91E0", Offset = "0x1CD91E0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonProperty), Member = "set_PropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags)
		{
			throw null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002B10 File Offset: 0x00000D10
		[global::Cpp2ILInjected.Token(Token = "0x60003BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9254", Offset = "0x1CD9254", Length = "0x4AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(bool),
			typeof(StringEscapeHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "EnsureBufferSize", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int),
			typeof(char[])
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "ToCharAsUnicode", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(char[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer)
		{
			throw null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002B13 File Offset: 0x00000D13
		[global::Cpp2ILInjected.Token(Token = "0x60003BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9768", Offset = "0x1CD9768", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(StringEscapeHandling)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JavaScriptUtils), Member = "GetCharEscapeFlags", MemberParameters = new object[]
		{
			typeof(StringEscapeHandling),
			typeof(char)
		}, ReturnType = typeof(bool[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "GetLength", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "CreateStringWriter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptString", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			throw null;
		}

		// Token: 0x040001B8 RID: 440
		[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
		internal static readonly bool[] SingleQuoteCharEscapeFlags;

		// Token: 0x040001B9 RID: 441
		[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
		internal static readonly bool[] DoubleQuoteCharEscapeFlags;

		// Token: 0x040001BA RID: 442
		[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
		internal static readonly bool[] HtmlCharEscapeFlags;

		// Token: 0x040001BB RID: 443
		[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
		private const int UnicodeTextLength = 6;

		// Token: 0x040001BC RID: 444
		[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
		private const string EscapedUnicodeText = "!";
	}
}
