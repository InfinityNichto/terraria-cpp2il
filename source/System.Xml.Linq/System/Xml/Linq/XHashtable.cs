using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x0200000B RID: 11
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	internal sealed class XHashtable<TValue>
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00002176 File Offset: 0x00000376
		[global::Cpp2ILInjected.Token(Token = "0x6000073")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E5614", Offset = "0x18E5614", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XHashtable(XHashtable<TValue>.ExtractKeyDelegate extractKey, int capacity)
		{
			throw null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002179 File Offset: 0x00000379
		[global::Cpp2ILInjected.Token(Token = "0x6000074")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E5688", Offset = "0x18E5688", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryGetValue(string key, int index, int count, out TValue value)
		{
			throw null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000217C File Offset: 0x0000037C
		[global::Cpp2ILInjected.Token(Token = "0x6000075")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E56A0", Offset = "0x18E56A0", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public TValue Add(TValue value)
		{
			throw null;
		}

		// Token: 0x04000010 RID: 16
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private XHashtable<TValue>.XHashtableState _state;

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x060000D7 RID: 215
		[global::Cpp2ILInjected.Token(Token = "0x200000E")]
		public delegate string ExtractKeyDelegate(TValue value);

		// Token: 0x0200002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x200000F")]
		private sealed class XHashtableState
		{
			// Token: 0x060000D8 RID: 216 RVA: 0x000022C6 File Offset: 0x000004C6
			[global::Cpp2ILInjected.Token(Token = "0x6000078")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E4F68", Offset = "0x18E4F68", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public XHashtableState(XHashtable<TValue>.ExtractKeyDelegate extractKey, int capacity)
			{
				throw null;
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x000022C9 File Offset: 0x000004C9
			[global::Cpp2ILInjected.Token(Token = "0x6000079")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E5008", Offset = "0x18E5008", Length = "0x1FC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public XHashtable<TValue>.XHashtableState Resize()
			{
				throw null;
			}

			// Token: 0x060000DA RID: 218 RVA: 0x000022CC File Offset: 0x000004CC
			[global::Cpp2ILInjected.Token(Token = "0x600007A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E5204", Offset = "0x18E5204", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool TryGetValue(string key, int index, int count, out TValue value)
			{
				throw null;
			}

			// Token: 0x060000DB RID: 219 RVA: 0x000022CF File Offset: 0x000004CF
			[global::Cpp2ILInjected.Token(Token = "0x600007B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E52B8", Offset = "0x18E52B8", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			public bool TryAdd(TValue value, out TValue newValue)
			{
				throw null;
			}

			// Token: 0x060000DC RID: 220 RVA: 0x000022D2 File Offset: 0x000004D2
			[global::Cpp2ILInjected.Token(Token = "0x600007C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E5420", Offset = "0x18E5420", Length = "0x180")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(string),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex)
			{
				throw null;
			}

			// Token: 0x060000DD RID: 221 RVA: 0x000022D5 File Offset: 0x000004D5
			[global::Cpp2ILInjected.Token(Token = "0x600007D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E55A0", Offset = "0x18E55A0", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			private static int ComputeHashCode(string key, int index, int count)
			{
				throw null;
			}

			// Token: 0x04000057 RID: 87
			[global::Cpp2ILInjected.Token(Token = "0x400001D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int[] _buckets;

			// Token: 0x04000058 RID: 88
			[global::Cpp2ILInjected.Token(Token = "0x400001E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private XHashtable<TValue>.XHashtableState.Entry[] _entries;

			// Token: 0x04000059 RID: 89
			[global::Cpp2ILInjected.Token(Token = "0x400001F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _numEntries;

			// Token: 0x0400005A RID: 90
			[global::Cpp2ILInjected.Token(Token = "0x4000020")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private XHashtable<TValue>.ExtractKeyDelegate _extractKey;

			// Token: 0x0200002C RID: 44
			[global::Cpp2ILInjected.Token(Token = "0x2000010")]
			private struct Entry
			{
				// Token: 0x0400005F RID: 95
				[global::Cpp2ILInjected.Token(Token = "0x4000021")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public TValue Value;

				// Token: 0x04000060 RID: 96
				[global::Cpp2ILInjected.Token(Token = "0x4000022")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public int HashCode;

				// Token: 0x04000061 RID: 97
				[global::Cpp2ILInjected.Token(Token = "0x4000023")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public int Next;
			}
		}
	}
}
