using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ID;

namespace Terraria.GameContent.Prefixes
{
	[global::Cpp2ILInjected.Token(Token = "0x2000829")]
	public class PrefixLegacy
	{
		[global::Cpp2ILInjected.Token(Token = "0x60042DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x79BA8C", Offset = "0x79BA8C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PrefixLegacy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200082A")]
		public class Prefixes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60042DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x79BA94", Offset = "0x79BA94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Prefixes()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60042DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x79BA9C", Offset = "0x79BA9C", Length = "0x1F8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			static Prefixes()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400811E")]
			public static int[] PrefixesForSwords;

			[global::Cpp2ILInjected.Token(Token = "0x400811F")]
			public static int[] PrefixesForSpears;

			[global::Cpp2ILInjected.Token(Token = "0x4008120")]
			public static int[] PrefixesForGunsBows;

			[global::Cpp2ILInjected.Token(Token = "0x4008121")]
			public static int[] PrefixesForMagicAndSummons;

			[global::Cpp2ILInjected.Token(Token = "0x4008122")]
			public static int[] PrefixesForBoomeransAndChakrums;

			[global::Cpp2ILInjected.Token(Token = "0x4008123")]
			public static int[] PrefixesForBoomeransAndChakrums_TerrarianYoyo;

			[global::Cpp2ILInjected.Token(Token = "0x4008124")]
			public static int[] PrefixesForAccessories;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200082B")]
		public class ItemSets
		{
			[global::Cpp2ILInjected.Token(Token = "0x60042DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x79BC94", Offset = "0x79BC94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ItemSets()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60042DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x79BC9C", Offset = "0x79BC9C", Length = "0x26C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(bool[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			static ItemSets()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008125")]
			public static SetFactory Factory;

			[global::Cpp2ILInjected.Token(Token = "0x4008126")]
			public static bool[] BoomerangsChakrams;

			[global::Cpp2ILInjected.Token(Token = "0x4008127")]
			public static bool[] ItemsThatCanHaveLegendary2;

			[global::Cpp2ILInjected.Token(Token = "0x4008128")]
			public static bool[] MagicAndSummon;

			[global::Cpp2ILInjected.Token(Token = "0x4008129")]
			public static bool[] GunsBows;

			[global::Cpp2ILInjected.Token(Token = "0x400812A")]
			public static bool[] SpearsMacesChainsawsDrillsPunchCannon;

			[global::Cpp2ILInjected.Token(Token = "0x400812B")]
			public static bool[] SwordsHammersAxesPicks;
		}
	}
}
