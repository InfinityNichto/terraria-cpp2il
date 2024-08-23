using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

namespace Terraria.GameContent.Items
{
	// Token: 0x020005BF RID: 1471
	[global::Cpp2ILInjected.Token(Token = "0x2000867")]
	public static class ItemVariants
	{
		// Token: 0x06003C4C RID: 15436 RVA: 0x0002CC51 File Offset: 0x0002AE51
		[global::Cpp2ILInjected.Token(Token = "0x60043AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4A04", Offset = "0x7A4A04", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemVariants), Member = "GetEntry", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ItemVariant)
		}, ReturnType = typeof(ItemVariants.VariantEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static IEnumerable<ItemVariants.VariantEntry> GetVariants(int itemId)
		{
			throw null;
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x0002CC54 File Offset: 0x0002AE54
		[global::Cpp2ILInjected.Token(Token = "0x60043AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4B34", Offset = "0x7A4B34", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemVariants), Member = "AddVariant", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ItemVariant),
			typeof(ItemVariantCondition[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemVariants), Member = "HasVariant", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ItemVariant)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariants), Member = "GetVariants", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEnumerable<ItemVariants.VariantEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static ItemVariants.VariantEntry GetEntry(int itemId, ItemVariant variant)
		{
			throw null;
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x0002CC57 File Offset: 0x0002AE57
		[global::Cpp2ILInjected.Token(Token = "0x60043AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4C40", Offset = "0x7A4C40", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemVariants), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariants), Member = "GetEntry", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ItemVariant)
		}, ReturnType = typeof(ItemVariants.VariantEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariants.VariantEntry), Member = ".ctor", MemberParameters = new object[] { typeof(ItemVariant) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariants.VariantEntry), Member = "AddConditions", MemberParameters = new object[] { typeof(IEnumerable<ItemVariantCondition>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void AddVariant(int itemId, ItemVariant variant, params ItemVariantCondition[] conditions)
		{
			throw null;
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x0002CC5A File Offset: 0x0002AE5A
		[global::Cpp2ILInjected.Token(Token = "0x60043AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4EE0", Offset = "0x7A4EE0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariants), Member = "GetEntry", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ItemVariant)
		}, ReturnType = typeof(ItemVariants.VariantEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool HasVariant(int itemId, ItemVariant variant)
		{
			throw null;
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x0002CC5D File Offset: 0x0002AE5D
		[global::Cpp2ILInjected.Token(Token = "0x60043B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4F50", Offset = "0x7A4F50", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "Refresh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariants.VariantEntry), Member = "AnyConditionMet", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static ItemVariant SelectVariant(int itemId)
		{
			throw null;
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x0002CC60 File Offset: 0x0002AE60
		[global::Cpp2ILInjected.Token(Token = "0x60043B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A524C", Offset = "0x7A524C", Length = "0xE70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariantCondition.Condition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemVariants), Member = "AddVariant", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ItemVariant),
			typeof(ItemVariantCondition[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 110)]
		static ItemVariants()
		{
			throw null;
		}

		// Token: 0x04006B7E RID: 27518
		[global::Cpp2ILInjected.Token(Token = "0x400819A")]
		private static List<ItemVariants.VariantEntry>[] _variants;

		// Token: 0x04006B7F RID: 27519
		[global::Cpp2ILInjected.Token(Token = "0x400819B")]
		public static ItemVariant StrongerVariant;

		// Token: 0x04006B80 RID: 27520
		[global::Cpp2ILInjected.Token(Token = "0x400819C")]
		public static ItemVariant WeakerVariant;

		// Token: 0x04006B81 RID: 27521
		[global::Cpp2ILInjected.Token(Token = "0x400819D")]
		public static ItemVariant RebalancedVariant;

		// Token: 0x04006B82 RID: 27522
		[global::Cpp2ILInjected.Token(Token = "0x400819E")]
		public static ItemVariant EnabledVariant;

		// Token: 0x04006B83 RID: 27523
		[global::Cpp2ILInjected.Token(Token = "0x400819F")]
		public static ItemVariant DisabledBossSummonVariant;

		// Token: 0x04006B84 RID: 27524
		[global::Cpp2ILInjected.Token(Token = "0x40081A0")]
		public static ItemVariantCondition RemixWorld;

		// Token: 0x04006B85 RID: 27525
		[global::Cpp2ILInjected.Token(Token = "0x40081A1")]
		public static ItemVariantCondition GetGoodWorld;

		// Token: 0x04006B86 RID: 27526
		[global::Cpp2ILInjected.Token(Token = "0x40081A2")]
		public static ItemVariantCondition EverythingWorld;

		// Token: 0x020009B3 RID: 2483
		[global::Cpp2ILInjected.Token(Token = "0x2000868")]
		public class VariantEntry
		{
			// Token: 0x170008C4 RID: 2244
			// (get) Token: 0x06004E35 RID: 20021 RVA: 0x0002FCCF File Offset: 0x0002DECF
			[global::Cpp2ILInjected.Token(Token = "0x170007D1")]
			public IEnumerable<ItemVariantCondition> Conditions
			{
				[global::Cpp2ILInjected.Token(Token = "0x60043B2")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A60BC", Offset = "0x7A60BC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004E36 RID: 20022 RVA: 0x0002FCD2 File Offset: 0x0002DED2
			[global::Cpp2ILInjected.Token(Token = "0x60043B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A4E00", Offset = "0x7A4E00", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemVariants), Member = "AddVariant", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ItemVariant),
				typeof(ItemVariantCondition[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public VariantEntry(ItemVariant variant)
			{
				throw null;
			}

			// Token: 0x06004E37 RID: 20023 RVA: 0x0002FCD5 File Offset: 0x0002DED5
			[global::Cpp2ILInjected.Token(Token = "0x60043B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A4E88", Offset = "0x7A4E88", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemVariants), Member = "AddVariant", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ItemVariant),
				typeof(ItemVariantCondition[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void AddConditions(IEnumerable<ItemVariantCondition> conditions)
			{
				throw null;
			}

			// Token: 0x06004E38 RID: 20024 RVA: 0x0002FCD8 File Offset: 0x0002DED8
			[global::Cpp2ILInjected.Token(Token = "0x60043B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A5150", Offset = "0x7A5150", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemVariants), Member = "SelectVariant", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ItemVariant))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public bool AnyConditionMet()
			{
				throw null;
			}

			// Token: 0x04008CD1 RID: 36049
			[global::Cpp2ILInjected.Token(Token = "0x40081A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly ItemVariant Variant;

			// Token: 0x04008CD2 RID: 36050
			[global::Cpp2ILInjected.Token(Token = "0x40081A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly List<ItemVariantCondition> _conditions;

			// Token: 0x02000BAA RID: 2986
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000869")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x0600541C RID: 21532 RVA: 0x00030D3A File Offset: 0x0002EF3A
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x60043B6")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A60C4", Offset = "0x7A60C4", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x0600541D RID: 21533 RVA: 0x00030D3D File Offset: 0x0002EF3D
				[global::Cpp2ILInjected.Token(Token = "0x60043B7")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A6120", Offset = "0x7A6120", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x0600541E RID: 21534 RVA: 0x00030D40 File Offset: 0x0002EF40
				[global::Cpp2ILInjected.Token(Token = "0x60043B8")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A6128", Offset = "0x7A6128", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <AnyConditionMet>b__6_0(ItemVariantCondition c)
				{
					throw null;
				}

				// Token: 0x04009101 RID: 37121
				[global::Cpp2ILInjected.Token(Token = "0x40081A5")]
				public static readonly ItemVariants.VariantEntry.<>c <>9;

				// Token: 0x04009102 RID: 37122
				[global::Cpp2ILInjected.Token(Token = "0x40081A6")]
				public static Func<ItemVariantCondition, bool> <>9__6_0;
			}
		}

		// Token: 0x020009B4 RID: 2484
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200086A")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004E39 RID: 20025 RVA: 0x0002FCDB File Offset: 0x0002DEDB
			[global::Cpp2ILInjected.Token(Token = "0x60043B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A4C38", Offset = "0x7A4C38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass3_0()
			{
				throw null;
			}

			// Token: 0x06004E3A RID: 20026 RVA: 0x0002FCDE File Offset: 0x0002DEDE
			[global::Cpp2ILInjected.Token(Token = "0x60043BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A613C", Offset = "0x7A613C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <GetEntry>b__0(ItemVariants.VariantEntry v)
			{
				throw null;
			}

			// Token: 0x04008CD3 RID: 36051
			[global::Cpp2ILInjected.Token(Token = "0x40081A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ItemVariant variant;
		}

		// Token: 0x020009B5 RID: 2485
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200086B")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E3B RID: 20027 RVA: 0x0002FCE1 File Offset: 0x0002DEE1
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60043BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A6150", Offset = "0x7A6150", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004E3C RID: 20028 RVA: 0x0002FCE4 File Offset: 0x0002DEE4
			[global::Cpp2ILInjected.Token(Token = "0x60043BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A61AC", Offset = "0x7A61AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004E3D RID: 20029 RVA: 0x0002FCE7 File Offset: 0x0002DEE7
			[global::Cpp2ILInjected.Token(Token = "0x60043BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A61B4", Offset = "0x7A61B4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <.cctor>b__15_0()
			{
				throw null;
			}

			// Token: 0x06004E3E RID: 20030 RVA: 0x0002FCEA File Offset: 0x0002DEEA
			[global::Cpp2ILInjected.Token(Token = "0x60043BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A620C", Offset = "0x7A620C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <.cctor>b__15_1()
			{
				throw null;
			}

			// Token: 0x06004E3F RID: 20031 RVA: 0x0002FCED File Offset: 0x0002DEED
			[global::Cpp2ILInjected.Token(Token = "0x60043BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A6264", Offset = "0x7A6264", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <.cctor>b__15_2()
			{
				throw null;
			}

			// Token: 0x04008CD4 RID: 36052
			[global::Cpp2ILInjected.Token(Token = "0x40081A8")]
			public static readonly ItemVariants.<>c <>9;
		}
	}
}
