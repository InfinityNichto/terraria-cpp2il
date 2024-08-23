using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000150 RID: 336
	[global::Cpp2ILInjected.Token(Token = "0x20001E3")]
	internal class BufferOffsetSize
	{
		// Token: 0x06000AD8 RID: 2776 RVA: 0x00004D00 File Offset: 0x00002F00
		[global::Cpp2ILInjected.Token(Token = "0x6000C03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F23EE4", Offset = "0x1F23EE4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SplitWritesState), Member = "GetNextBuffers", ReturnType = typeof(BufferOffsetSize[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<<GetRewriteHandler>b__271_0>d", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = "GetWriteBuffer", ReturnType = typeof(BufferOffsetSize))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<InitReadAsync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer)
		{
			throw null;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00004D03 File Offset: 0x00002F03
		[global::Cpp2ILInjected.Token(Token = "0x6000C04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F23F90", Offset = "0x1F23F90", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<InitReadAsync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal BufferOffsetSize(byte[] buffer, bool copyBuffer)
		{
			throw null;
		}

		// Token: 0x040007EC RID: 2028
		[global::Cpp2ILInjected.Token(Token = "0x4000A30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal byte[] Buffer;

		// Token: 0x040007ED RID: 2029
		[global::Cpp2ILInjected.Token(Token = "0x4000A31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int Offset;

		// Token: 0x040007EE RID: 2030
		[global::Cpp2ILInjected.Token(Token = "0x4000A32")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal int Size;
	}
}
