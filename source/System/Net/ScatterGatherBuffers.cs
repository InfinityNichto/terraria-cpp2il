using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000166 RID: 358
	[global::Cpp2ILInjected.Token(Token = "0x20001FB")]
	internal class ScatterGatherBuffers
	{
		// Token: 0x06000B42 RID: 2882 RVA: 0x00004E29 File Offset: 0x00003029
		[global::Cpp2ILInjected.Token(Token = "0x6000C74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2800C", Offset = "0x1F2800C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ScatterGatherBuffers()
		{
			throw null;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00004E2C File Offset: 0x0000302C
		[global::Cpp2ILInjected.Token(Token = "0x6000C75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2801C", Offset = "0x1F2801C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScatterGatherBuffers), Member = "AllocateMemoryChunk", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ScatterGatherBuffers.MemoryChunk))]
		internal ScatterGatherBuffers(long totalSize)
		{
			throw null;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00004E2F File Offset: 0x0000302F
		[global::Cpp2ILInjected.Token(Token = "0x6000C76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28100", Offset = "0x1F28100", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal BufferOffsetSize[] GetBuffers()
		{
			throw null;
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00004E32 File Offset: 0x00003032
		[global::Cpp2ILInjected.Token(Token = "0x1700028B")]
		private bool Empty
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2822C", Offset = "0x1F2822C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x00004E35 File Offset: 0x00003035
		[global::Cpp2ILInjected.Token(Token = "0x1700028C")]
		internal int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C78")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2824C", Offset = "0x1F2824C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00004E38 File Offset: 0x00003038
		[global::Cpp2ILInjected.Token(Token = "0x6000C79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28254", Offset = "0x1F28254", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScatterGatherBuffers), Member = "AllocateMemoryChunk", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ScatterGatherBuffers.MemoryChunk))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00004E3B File Offset: 0x0000303B
		[global::Cpp2ILInjected.Token(Token = "0x6000C7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28068", Offset = "0x1F28068", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScatterGatherBuffers), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScatterGatherBuffers), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScatterGatherBuffers.MemoryChunk), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ScatterGatherBuffers.MemoryChunk AllocateMemoryChunk(int newSize)
		{
			throw null;
		}

		// Token: 0x04000867 RID: 2151
		[global::Cpp2ILInjected.Token(Token = "0x4000AB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ScatterGatherBuffers.MemoryChunk headChunk;

		// Token: 0x04000868 RID: 2152
		[global::Cpp2ILInjected.Token(Token = "0x4000AB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ScatterGatherBuffers.MemoryChunk currentChunk;

		// Token: 0x04000869 RID: 2153
		[global::Cpp2ILInjected.Token(Token = "0x4000AB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int nextChunkLength;

		// Token: 0x0400086A RID: 2154
		[global::Cpp2ILInjected.Token(Token = "0x4000AB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int totalLength;

		// Token: 0x0400086B RID: 2155
		[global::Cpp2ILInjected.Token(Token = "0x4000AB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int chunkCount;

		// Token: 0x020003FD RID: 1021
		[global::Cpp2ILInjected.Token(Token = "0x20001FC")]
		private class MemoryChunk
		{
			// Token: 0x06001DD6 RID: 7638 RVA: 0x0000826A File Offset: 0x0000646A
			[global::Cpp2ILInjected.Token(Token = "0x6000C7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F28320", Offset = "0x1F28320", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScatterGatherBuffers), Member = "AllocateMemoryChunk", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ScatterGatherBuffers.MemoryChunk))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal MemoryChunk(int bufferSize)
			{
				throw null;
			}

			// Token: 0x040011FA RID: 4602
			[global::Cpp2ILInjected.Token(Token = "0x4000AB5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal byte[] Buffer;

			// Token: 0x040011FB RID: 4603
			[global::Cpp2ILInjected.Token(Token = "0x4000AB6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int FreeOffset;

			// Token: 0x040011FC RID: 4604
			[global::Cpp2ILInjected.Token(Token = "0x4000AB7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal ScatterGatherBuffers.MemoryChunk Next;
		}
	}
}
