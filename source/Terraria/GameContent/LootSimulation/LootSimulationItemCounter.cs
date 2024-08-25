using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Reflection;

namespace Terraria.GameContent.LootSimulation
{
	[global::Cpp2ILInjected.Token(Token = "0x200085A")]
	public class LootSimulationItemCounter
	{
		[global::Cpp2ILInjected.Token(Token = "0x600436D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A2930", Offset = "0x7A2930", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LootSimulator), Member = "TryGettingLootFor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public LootSimulationItemCounter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600436E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3044", Offset = "0x7A3044", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AddItem(int itemId, int amount, bool expert)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600436F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A29B8", Offset = "0x7A29B8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Exclude(params int[] itemIds)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004370")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A2998", Offset = "0x7A2998", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void IncreaseTimesAttempted(int amount, bool expert)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004371")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A29F8", Offset = "0x7A29F8", Length = "0x360")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LootSimulator), Member = "TryGettingLootFor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<long, int, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(long),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<long>),
			typeof(Func<long, int, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, int>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<int>),
			typeof(Func<int, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IEnumerable<string>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public string PrintCollectedItems(bool expert)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008178")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private long[] _itemCountsObtained;

		[global::Cpp2ILInjected.Token(Token = "0x4008179")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private long[] _itemCountsObtainedExpert;

		[global::Cpp2ILInjected.Token(Token = "0x400817A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private long _totalTimesAttempted;

		[global::Cpp2ILInjected.Token(Token = "0x400817B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private long _totalTimesAttemptedExpert;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200085B")]
		private sealed class <>c__DisplayClass8_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004372")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A307C", Offset = "0x7A307C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass8_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004373")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A3084", Offset = "0x7A3084", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "GetName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal string <PrintCollectedItems>b__3(int itemId)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400817C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public long[] collectionToUse;

			[global::Cpp2ILInjected.Token(Token = "0x400817D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public long totalDropsAttempted;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200085C")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004374")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A317C", Offset = "0x7A317C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004375")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A31D8", Offset = "0x7A31D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004376")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A31E0", Offset = "0x7A31E0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType3<, >), Member = ".ctor", MemberParameters = new object[] { "<itemId>j__TPar", "<count>j__TPar" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal <>f__AnonymousType3<int, long> <PrintCollectedItems>b__8_0(long count, int itemId)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004377")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A3260", Offset = "0x7A3260", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <PrintCollectedItems>b__8_1(<>f__AnonymousType3<int, long> entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004378")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A32A4", Offset = "0x7A32A4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal int <PrintCollectedItems>b__8_2(<>f__AnonymousType3<int, long> entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400817E")]
			public static readonly LootSimulationItemCounter.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x400817F")]
			public static Func<long, int, <>f__AnonymousType3<int, long>> <>9__8_0;

			[global::Cpp2ILInjected.Token(Token = "0x4008180")]
			public static Func<<>f__AnonymousType3<int, long>, bool> <>9__8_1;

			[global::Cpp2ILInjected.Token(Token = "0x4008181")]
			public static Func<<>f__AnonymousType3<int, long>, int> <>9__8_2;
		}
	}
}
