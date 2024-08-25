using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Net;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200061A")]
	public static class BufferPool
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DAFE0", Offset = "0x13DAFE0", Length = "0x38C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BufferPool), Member = "Request", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(CachedBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetPacket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedBuffer), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Dequeue", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static CachedBuffer Request(int size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DB48C", Offset = "0x13DB48C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferPool), Member = "Request", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CachedBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static CachedBuffer Request(byte[] data, int offset, int size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DB518", Offset = "0x13DB518", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CachedBuffer), Member = "Recycle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Enqueue", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void Recycle(CachedBuffer buffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DB6E8", Offset = "0x13DB6E8", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void PrintBufferSizes()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60035C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DB944", Offset = "0x13DB944", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static BufferPool()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007693")]
		private const int SMALL_BUFFER_SIZE = 32;

		[global::Cpp2ILInjected.Token(Token = "0x4007694")]
		private const int MEDIUM_BUFFER_SIZE = 256;

		[global::Cpp2ILInjected.Token(Token = "0x4007695")]
		private const int LARGE_BUFFER_SIZE = 16384;

		[global::Cpp2ILInjected.Token(Token = "0x4007696")]
		private static object bufferLock;

		[global::Cpp2ILInjected.Token(Token = "0x4007697")]
		private static Queue<CachedBuffer> SmallBufferQueue;

		[global::Cpp2ILInjected.Token(Token = "0x4007698")]
		private static Queue<CachedBuffer> MediumBufferQueue;

		[global::Cpp2ILInjected.Token(Token = "0x4007699")]
		private static Queue<CachedBuffer> LargeBufferQueue;
	}
}
