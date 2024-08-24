using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Reflection;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x020005B6 RID: 1462
	[global::Cpp2ILInjected.Token(Token = "0x200085A")]
	public class LootSimulationItemCounter
	{
		// Token: 0x06003C2E RID: 15406 RVA: 0x0002CC00 File Offset: 0x0002AE00
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

		// Token: 0x06003C2F RID: 15407 RVA: 0x0002CC03 File Offset: 0x0002AE03
		[global::Cpp2ILInjected.Token(Token = "0x600436E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3044", Offset = "0x7A3044", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AddItem(int itemId, int amount, bool expert)
		{
			throw null;
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0002CC06 File Offset: 0x0002AE06
		[global::Cpp2ILInjected.Token(Token = "0x600436F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A29B8", Offset = "0x7A29B8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Exclude(params int[] itemIds)
		{
			throw null;
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x0002CC09 File Offset: 0x0002AE09
		[global::Cpp2ILInjected.Token(Token = "0x6004370")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A2998", Offset = "0x7A2998", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void IncreaseTimesAttempted(int amount, bool expert)
		{
			throw null;
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x0002CC0C File Offset: 0x0002AE0C
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

		// Token: 0x04006B63 RID: 27491
		[global::Cpp2ILInjected.Token(Token = "0x4008178")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private long[] _itemCountsObtained;

		// Token: 0x04006B64 RID: 27492
		[global::Cpp2ILInjected.Token(Token = "0x4008179")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private long[] _itemCountsObtainedExpert;

		// Token: 0x04006B65 RID: 27493
		[global::Cpp2ILInjected.Token(Token = "0x400817A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private long _totalTimesAttempted;

		// Token: 0x04006B66 RID: 27494
		[global::Cpp2ILInjected.Token(Token = "0x400817B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private long _totalTimesAttemptedExpert;

		// Token: 0x020009AF RID: 2479
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200085B")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004E14 RID: 19988 RVA: 0x0002FC78 File Offset: 0x0002DE78
			[global::Cpp2ILInjected.Token(Token = "0x6004372")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A307C", Offset = "0x7A307C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass8_0()
			{
				throw null;
			}

			// Token: 0x06004E15 RID: 19989 RVA: 0x0002FC7B File Offset: 0x0002DE7B
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

			// Token: 0x04008CCA RID: 36042
			[global::Cpp2ILInjected.Token(Token = "0x400817C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public long[] collectionToUse;

			// Token: 0x04008CCB RID: 36043
			[global::Cpp2ILInjected.Token(Token = "0x400817D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public long totalDropsAttempted;
		}

		// Token: 0x020009B0 RID: 2480
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200085C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E16 RID: 19990 RVA: 0x0002FC7E File Offset: 0x0002DE7E
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

			// Token: 0x06004E17 RID: 19991 RVA: 0x0002FC81 File Offset: 0x0002DE81
			[global::Cpp2ILInjected.Token(Token = "0x6004375")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A31D8", Offset = "0x7A31D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004E18 RID: 19992 RVA: 0x0002FC84 File Offset: 0x0002DE84
			[global::Cpp2ILInjected.Token(Token = "0x6004376")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A31E0", Offset = "0x7A31E0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType3<, >), Member = ".ctor", MemberParameters = new object[] { "<itemId>j__TPar", "<count>j__TPar" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal <>f__AnonymousType3<int, long> <PrintCollectedItems>b__8_0(long count, int itemId)
			{
				throw null;
			}

			// Token: 0x06004E19 RID: 19993 RVA: 0x0002FC87 File Offset: 0x0002DE87
			[global::Cpp2ILInjected.Token(Token = "0x6004377")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A3260", Offset = "0x7A3260", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <PrintCollectedItems>b__8_1(<>f__AnonymousType3<int, long> entry)
			{
				throw null;
			}

			// Token: 0x06004E1A RID: 19994 RVA: 0x0002FC8A File Offset: 0x0002DE8A
			[global::Cpp2ILInjected.Token(Token = "0x6004378")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A32A4", Offset = "0x7A32A4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal int <PrintCollectedItems>b__8_2(<>f__AnonymousType3<int, long> entry)
			{
				throw null;
			}

			// Token: 0x04008CCC RID: 36044
			[global::Cpp2ILInjected.Token(Token = "0x400817E")]
			public static readonly LootSimulationItemCounter.<>c <>9;

			// Token: 0x04008CCD RID: 36045
			[global::Cpp2ILInjected.Token(Token = "0x400817F")]
			public static Func<long, int, <>f__AnonymousType3<int, long>> <>9__8_0;

			// Token: 0x04008CCE RID: 36046
			[global::Cpp2ILInjected.Token(Token = "0x4008180")]
			public static Func<<>f__AnonymousType3<int, long>, bool> <>9__8_1;

			// Token: 0x04008CCF RID: 36047
			[global::Cpp2ILInjected.Token(Token = "0x4008181")]
			public static Func<<>f__AnonymousType3<int, long>, int> <>9__8_2;
		}
	}
}
