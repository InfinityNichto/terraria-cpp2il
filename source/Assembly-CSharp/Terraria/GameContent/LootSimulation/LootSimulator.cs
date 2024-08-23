using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Reflection;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x020005B4 RID: 1460
	[global::Cpp2ILInjected.Token(Token = "0x2000857")]
	public class LootSimulator
	{
		// Token: 0x06003C24 RID: 15396 RVA: 0x0002CBE2 File Offset: 0x0002ADE2
		[global::Cpp2ILInjected.Token(Token = "0x600435B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A1740", Offset = "0x7A1740", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LootSimulator), Member = "FillDesiredTestConditions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LootSimulator), Member = "FillItemExclusions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public LootSimulator()
		{
			throw null;
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x0002CBE5 File Offset: 0x0002ADE5
		[global::Cpp2ILInjected.Token(Token = "0x600435C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A1BD8", Offset = "0x7A1BD8", Length = "0x53C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LootSimulator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<, , >), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new object[] { "TSource", "TResult" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`3<TSource, Int32, TResult>" }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		private void FillItemExclusions()
		{
			throw null;
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
		[global::Cpp2ILInjected.Token(Token = "0x600435D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A17F0", Offset = "0x7A17F0", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LootSimulator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void FillDesiredTestConditions()
		{
			throw null;
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x0002CBEB File Offset: 0x0002ADEB
		[global::Cpp2ILInjected.Token(Token = "0x600435E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A2114", Offset = "0x7A2114", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LootSimulator), Member = "SetCleanSlateWorldConditions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LootSimulator), Member = "TryGettingLootFor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Run()
		{
			throw null;
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x0002CBEE File Offset: 0x0002ADEE
		[global::Cpp2ILInjected.Token(Token = "0x600435F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A2288", Offset = "0x7A2288", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LootSimulator), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LootSimulator), Member = "TryGettingLootFor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_GameMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void SetCleanSlateWorldConditions()
		{
			throw null;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x0002CBF1 File Offset: 0x0002ADF1
		[global::Cpp2ILInjected.Token(Token = "0x6004360")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A234C", Offset = "0x7A234C", Length = "0x52C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LootSimulator), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimulatorInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LootSimulationItemCounter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NPCLoot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LootSimulator), Member = "SetCleanSlateWorldConditions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LootSimulationItemCounter), Member = "PrintCollectedItems", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "GetName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private bool TryGettingLootFor(int npcNetId, int timesMultiplier, out string outputText)
		{
			throw null;
		}

		// Token: 0x04006B5A RID: 27482
		[global::Cpp2ILInjected.Token(Token = "0x4008168")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<ISimulationConditionSetter> _neededTestConditions;

		// Token: 0x04006B5B RID: 27483
		[global::Cpp2ILInjected.Token(Token = "0x4008169")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int[] _excludedItemIds;

		// Token: 0x020009AE RID: 2478
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000858")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E0C RID: 19980 RVA: 0x0002FC60 File Offset: 0x0002DE60
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004361")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A2D58", Offset = "0x7A2D58", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004E0D RID: 19981 RVA: 0x0002FC63 File Offset: 0x0002DE63
			[global::Cpp2ILInjected.Token(Token = "0x6004362")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A2DB4", Offset = "0x7A2DB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004E0E RID: 19982 RVA: 0x0002FC66 File Offset: 0x0002DE66
			[global::Cpp2ILInjected.Token(Token = "0x6004363")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A2DBC", Offset = "0x7A2DBC", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType2<, >), Member = ".ctor", MemberParameters = new object[] { "<index>j__TPar", "<state>j__TPar" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal <>f__AnonymousType2<int, bool> <FillItemExclusions>b__3_0(bool state, int index)
			{
				throw null;
			}

			// Token: 0x06004E0F RID: 19983 RVA: 0x0002FC69 File Offset: 0x0002DE69
			[global::Cpp2ILInjected.Token(Token = "0x6004364")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A2E3C", Offset = "0x7A2E3C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <FillItemExclusions>b__3_1(<>f__AnonymousType2<int, bool> tuple)
			{
				throw null;
			}

			// Token: 0x06004E10 RID: 19984 RVA: 0x0002FC6C File Offset: 0x0002DE6C
			[global::Cpp2ILInjected.Token(Token = "0x6004365")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A2E78", Offset = "0x7A2E78", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal int <FillItemExclusions>b__3_2(<>f__AnonymousType2<int, bool> tuple)
			{
				throw null;
			}

			// Token: 0x06004E11 RID: 19985 RVA: 0x0002FC6F File Offset: 0x0002DE6F
			[global::Cpp2ILInjected.Token(Token = "0x6004366")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A2EB4", Offset = "0x7A2EB4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType2<, >), Member = ".ctor", MemberParameters = new object[] { "<index>j__TPar", "<state>j__TPar" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal <>f__AnonymousType2<int, bool> <FillItemExclusions>b__3_3(bool state, int index)
			{
				throw null;
			}

			// Token: 0x06004E12 RID: 19986 RVA: 0x0002FC72 File Offset: 0x0002DE72
			[global::Cpp2ILInjected.Token(Token = "0x6004367")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A2F34", Offset = "0x7A2F34", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <FillItemExclusions>b__3_4(<>f__AnonymousType2<int, bool> tuple)
			{
				throw null;
			}

			// Token: 0x06004E13 RID: 19987 RVA: 0x0002FC75 File Offset: 0x0002DE75
			[global::Cpp2ILInjected.Token(Token = "0x6004368")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A2F70", Offset = "0x7A2F70", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal int <FillItemExclusions>b__3_5(<>f__AnonymousType2<int, bool> tuple)
			{
				throw null;
			}

			// Token: 0x04008CC3 RID: 36035
			[global::Cpp2ILInjected.Token(Token = "0x400816A")]
			public static readonly LootSimulator.<>c <>9;

			// Token: 0x04008CC4 RID: 36036
			[global::Cpp2ILInjected.Token(Token = "0x400816B")]
			public static Func<bool, int, <>f__AnonymousType2<int, bool>> <>9__3_0;

			// Token: 0x04008CC5 RID: 36037
			[global::Cpp2ILInjected.Token(Token = "0x400816C")]
			public static Func<<>f__AnonymousType2<int, bool>, bool> <>9__3_1;

			// Token: 0x04008CC6 RID: 36038
			[global::Cpp2ILInjected.Token(Token = "0x400816D")]
			public static Func<<>f__AnonymousType2<int, bool>, int> <>9__3_2;

			// Token: 0x04008CC7 RID: 36039
			[global::Cpp2ILInjected.Token(Token = "0x400816E")]
			public static Func<bool, int, <>f__AnonymousType2<int, bool>> <>9__3_3;

			// Token: 0x04008CC8 RID: 36040
			[global::Cpp2ILInjected.Token(Token = "0x400816F")]
			public static Func<<>f__AnonymousType2<int, bool>, bool> <>9__3_4;

			// Token: 0x04008CC9 RID: 36041
			[global::Cpp2ILInjected.Token(Token = "0x4008170")]
			public static Func<<>f__AnonymousType2<int, bool>, int> <>9__3_5;
		}
	}
}
