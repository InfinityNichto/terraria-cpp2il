using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200003D RID: 61
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000040")]
	internal class Base64Encoder
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x000028C1 File Offset: 0x00000AC1
		[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF988", Offset = "0x1CCF988", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "get_Base64Encoder", ReturnType = typeof(Base64Encoder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Base64Encoder(TextWriter writer)
		{
			throw null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000028C4 File Offset: 0x00000AC4
		[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCFA14", Offset = "0x1CCFA14", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void Encode(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000028C7 File Offset: 0x00000AC7
		[global::Cpp2ILInjected.Token(Token = "0x60002BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCFD3C", Offset = "0x1CCFD3C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Flush()
		{
			throw null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000028CA File Offset: 0x00000ACA
		[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCFD28", Offset = "0x1CCFD28", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void WriteChars(char[] chars, int index, int count)
		{
			throw null;
		}

		// Token: 0x04000157 RID: 343
		[global::Cpp2ILInjected.Token(Token = "0x4000171")]
		private const int Base64LineSize = 76;

		// Token: 0x04000158 RID: 344
		[global::Cpp2ILInjected.Token(Token = "0x4000172")]
		private const int LineSizeInBytes = 57;

		// Token: 0x04000159 RID: 345
		[global::Cpp2ILInjected.Token(Token = "0x4000173")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly char[] _charsLine;

		// Token: 0x0400015A RID: 346
		[global::Cpp2ILInjected.Token(Token = "0x4000174")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly TextWriter _writer;

		// Token: 0x0400015B RID: 347
		[global::Cpp2ILInjected.Token(Token = "0x4000175")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] _leftOverBytes;

		// Token: 0x0400015C RID: 348
		[global::Cpp2ILInjected.Token(Token = "0x4000176")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _leftOverBytesCount;
	}
}
