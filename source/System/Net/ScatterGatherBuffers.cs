using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001FB")]
	internal class ScatterGatherBuffers
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2800C", Offset = "0x1F2800C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ScatterGatherBuffers()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000C76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28100", Offset = "0x1F28100", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal BufferOffsetSize[] GetBuffers()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000AB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ScatterGatherBuffers.MemoryChunk headChunk;

		[global::Cpp2ILInjected.Token(Token = "0x4000AB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ScatterGatherBuffers.MemoryChunk currentChunk;

		[global::Cpp2ILInjected.Token(Token = "0x4000AB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int nextChunkLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000AB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int totalLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000AB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int chunkCount;

		[global::Cpp2ILInjected.Token(Token = "0x20001FC")]
		private class MemoryChunk
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x4000AB5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal byte[] Buffer;

			[global::Cpp2ILInjected.Token(Token = "0x4000AB6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int FreeOffset;

			[global::Cpp2ILInjected.Token(Token = "0x4000AB7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal ScatterGatherBuffers.MemoryChunk Next;
		}
	}
}
