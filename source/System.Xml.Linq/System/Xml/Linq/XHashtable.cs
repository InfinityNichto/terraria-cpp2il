using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	internal sealed class XHashtable<TValue>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private XHashtable<TValue>.XHashtableState _state;

		[global::Cpp2ILInjected.Token(Token = "0x200000E")]
		public delegate string ExtractKeyDelegate(TValue value);

		[global::Cpp2ILInjected.Token(Token = "0x200000F")]
		private sealed class XHashtableState
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600007A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E5204", Offset = "0x18E5204", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool TryGetValue(string key, int index, int count, out TValue value)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x400001D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int[] _buckets;

			[global::Cpp2ILInjected.Token(Token = "0x400001E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private XHashtable<TValue>.XHashtableState.Entry[] _entries;

			[global::Cpp2ILInjected.Token(Token = "0x400001F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _numEntries;

			[global::Cpp2ILInjected.Token(Token = "0x4000020")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private XHashtable<TValue>.ExtractKeyDelegate _extractKey;

			[global::Cpp2ILInjected.Token(Token = "0x2000010")]
			private struct Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x4000021")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public TValue Value;

				[global::Cpp2ILInjected.Token(Token = "0x4000022")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public int HashCode;

				[global::Cpp2ILInjected.Token(Token = "0x4000023")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public int Next;
			}
		}
	}
}
