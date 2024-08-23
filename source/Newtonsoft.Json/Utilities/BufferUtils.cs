using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000054 RID: 84
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000069")]
	internal static class BufferUtils
	{
		// Token: 0x06000382 RID: 898 RVA: 0x00002AFE File Offset: 0x00000CFE
		[global::Cpp2ILInjected.Token(Token = "0x60003B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD8330", Offset = "0x1CD8330", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "EnsureBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "EnsureWriteBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuffer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuffer), Member = "EnsureSize", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize)
		{
			throw null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002B01 File Offset: 0x00000D01
		[global::Cpp2ILInjected.Token(Token = "0x60003B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD83F8", Offset = "0x1CD83F8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "Close", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuffer), Member = "Clear", MemberParameters = new object[] { typeof(IArrayPool<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuffer), Member = "EnsureSize", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer)
		{
			throw null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002B04 File Offset: 0x00000D04
		[global::Cpp2ILInjected.Token(Token = "0x60003B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD84A8", Offset = "0x1CD84A8", Length = "0x13C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer)
		{
			throw null;
		}
	}
}
