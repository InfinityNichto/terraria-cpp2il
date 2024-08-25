using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

namespace Terraria.GameContent.Items
{
	[global::Cpp2ILInjected.Token(Token = "0x2000867")]
	public static class ItemVariants
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x400819A")]
		private static List<ItemVariants.VariantEntry>[] _variants;

		[global::Cpp2ILInjected.Token(Token = "0x400819B")]
		public static ItemVariant StrongerVariant;

		[global::Cpp2ILInjected.Token(Token = "0x400819C")]
		public static ItemVariant WeakerVariant;

		[global::Cpp2ILInjected.Token(Token = "0x400819D")]
		public static ItemVariant RebalancedVariant;

		[global::Cpp2ILInjected.Token(Token = "0x400819E")]
		public static ItemVariant EnabledVariant;

		[global::Cpp2ILInjected.Token(Token = "0x400819F")]
		public static ItemVariant DisabledBossSummonVariant;

		[global::Cpp2ILInjected.Token(Token = "0x40081A0")]
		public static ItemVariantCondition RemixWorld;

		[global::Cpp2ILInjected.Token(Token = "0x40081A1")]
		public static ItemVariantCondition GetGoodWorld;

		[global::Cpp2ILInjected.Token(Token = "0x40081A2")]
		public static ItemVariantCondition EverythingWorld;

		[global::Cpp2ILInjected.Token(Token = "0x2000868")]
		public class VariantEntry
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x40081A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly ItemVariant Variant;

			[global::Cpp2ILInjected.Token(Token = "0x40081A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly List<ItemVariantCondition> _conditions;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000869")]
			[Serializable]
			private sealed class <>c
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x60043B7")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A6120", Offset = "0x7A6120", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x60043B8")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A6128", Offset = "0x7A6128", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <AnyConditionMet>b__6_0(ItemVariantCondition c)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40081A5")]
				public static readonly ItemVariants.VariantEntry.<>c <>9;

				[global::Cpp2ILInjected.Token(Token = "0x40081A6")]
				public static Func<ItemVariantCondition, bool> <>9__6_0;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200086A")]
		private sealed class <>c__DisplayClass3_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60043B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A4C38", Offset = "0x7A4C38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass3_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60043BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A613C", Offset = "0x7A613C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <GetEntry>b__0(ItemVariants.VariantEntry v)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40081A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ItemVariant variant;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200086B")]
		[Serializable]
		private sealed class <>c
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60043BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A61AC", Offset = "0x7A61AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60043BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A61B4", Offset = "0x7A61B4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <.cctor>b__15_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60043BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A620C", Offset = "0x7A620C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <.cctor>b__15_1()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60043BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A6264", Offset = "0x7A6264", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <.cctor>b__15_2()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40081A8")]
			public static readonly ItemVariants.<>c <>9;
		}
	}
}
