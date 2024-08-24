using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Net
{
	// Token: 0x02000497 RID: 1175
	[global::Cpp2ILInjected.Token(Token = "0x20006A0")]
	public class LegacyNetBufferPool
	{
		// Token: 0x0600334E RID: 13134 RVA: 0x0002B2C2 File Offset: 0x000294C2
		[global::Cpp2ILInjected.Token(Token = "0x6003889")]
		[global::Cpp2ILInjected.Address(RVA = "0x143BE88", Offset = "0x143BE88", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyNetBufferPool), Member = "RequestBuffer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Dequeue", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static byte[] RequestBuffer(int size)
		{
			throw null;
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x0002B2C5 File Offset: 0x000294C5
		[global::Cpp2ILInjected.Token(Token = "0x600388A")]
		[global::Cpp2ILInjected.Address(RVA = "0x143C190", Offset = "0x143C190", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyNetBufferPool), Member = "RequestBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] RequestBuffer(byte[] data, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x0002B2C8 File Offset: 0x000294C8
		[global::Cpp2ILInjected.Token(Token = "0x600388B")]
		[global::Cpp2ILInjected.Address(RVA = "0x143C21C", Offset = "0x143C21C", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Enqueue", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void ReturnBuffer(byte[] buffer)
		{
			throw null;
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x0002B2CB File Offset: 0x000294CB
		[global::Cpp2ILInjected.Token(Token = "0x600388C")]
		[global::Cpp2ILInjected.Address(RVA = "0x143C3DC", Offset = "0x143C3DC", Length = "0x334")]
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
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void DisplayBufferSizes()
		{
			throw null;
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x0002B2CE File Offset: 0x000294CE
		[global::Cpp2ILInjected.Token(Token = "0x600388D")]
		[global::Cpp2ILInjected.Address(RVA = "0x143C710", Offset = "0x143C710", Length = "0x324")]
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
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static void PrintBufferSizes()
		{
			throw null;
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x0002B2D1 File Offset: 0x000294D1
		[global::Cpp2ILInjected.Token(Token = "0x600388E")]
		[global::Cpp2ILInjected.Address(RVA = "0x143CA34", Offset = "0x143CA34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LegacyNetBufferPool()
		{
			throw null;
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x0002B2D4 File Offset: 0x000294D4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600388F")]
		[global::Cpp2ILInjected.Address(RVA = "0x143CA3C", Offset = "0x143CA3C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static LegacyNetBufferPool()
		{
			throw null;
		}

		// Token: 0x0400653E RID: 25918
		[global::Cpp2ILInjected.Token(Token = "0x400793D")]
		private const int SMALL_BUFFER_SIZE = 256;

		// Token: 0x0400653F RID: 25919
		[global::Cpp2ILInjected.Token(Token = "0x400793E")]
		private const int MEDIUM_BUFFER_SIZE = 1024;

		// Token: 0x04006540 RID: 25920
		[global::Cpp2ILInjected.Token(Token = "0x400793F")]
		private const int LARGE_BUFFER_SIZE = 16384;

		// Token: 0x04006541 RID: 25921
		[global::Cpp2ILInjected.Token(Token = "0x4007940")]
		private static object bufferLock;

		// Token: 0x04006542 RID: 25922
		[global::Cpp2ILInjected.Token(Token = "0x4007941")]
		private static Queue<byte[]> _smallBufferQueue;

		// Token: 0x04006543 RID: 25923
		[global::Cpp2ILInjected.Token(Token = "0x4007942")]
		private static Queue<byte[]> _mediumBufferQueue;

		// Token: 0x04006544 RID: 25924
		[global::Cpp2ILInjected.Token(Token = "0x4007943")]
		private static Queue<byte[]> _largeBufferQueue;

		// Token: 0x04006545 RID: 25925
		[global::Cpp2ILInjected.Token(Token = "0x4007944")]
		private static int _smallBufferCount;

		// Token: 0x04006546 RID: 25926
		[global::Cpp2ILInjected.Token(Token = "0x4007945")]
		private static int _mediumBufferCount;

		// Token: 0x04006547 RID: 25927
		[global::Cpp2ILInjected.Token(Token = "0x4007946")]
		private static int _largeBufferCount;

		// Token: 0x04006548 RID: 25928
		[global::Cpp2ILInjected.Token(Token = "0x4007947")]
		private static int _customBufferCount;
	}
}
