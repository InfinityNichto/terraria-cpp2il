using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ID;

namespace Terraria.GameContent.Prefixes
{
	// Token: 0x0200058E RID: 1422
	[global::Cpp2ILInjected.Token(Token = "0x2000829")]
	public class PrefixLegacy
	{
		// Token: 0x06003BBC RID: 15292 RVA: 0x0002CACB File Offset: 0x0002ACCB
		[global::Cpp2ILInjected.Token(Token = "0x60042DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x79BA8C", Offset = "0x79BA8C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PrefixLegacy()
		{
			throw null;
		}

		// Token: 0x020009A6 RID: 2470
		[global::Cpp2ILInjected.Token(Token = "0x200082A")]
		public class Prefixes
		{
			// Token: 0x06004DF3 RID: 19955 RVA: 0x0002FC15 File Offset: 0x0002DE15
			[global::Cpp2ILInjected.Token(Token = "0x60042DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x79BA94", Offset = "0x79BA94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Prefixes()
			{
				throw null;
			}

			// Token: 0x06004DF4 RID: 19956 RVA: 0x0002FC18 File Offset: 0x0002DE18
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

			// Token: 0x04008CA2 RID: 36002
			[global::Cpp2ILInjected.Token(Token = "0x400811E")]
			public static int[] PrefixesForSwords;

			// Token: 0x04008CA3 RID: 36003
			[global::Cpp2ILInjected.Token(Token = "0x400811F")]
			public static int[] PrefixesForSpears;

			// Token: 0x04008CA4 RID: 36004
			[global::Cpp2ILInjected.Token(Token = "0x4008120")]
			public static int[] PrefixesForGunsBows;

			// Token: 0x04008CA5 RID: 36005
			[global::Cpp2ILInjected.Token(Token = "0x4008121")]
			public static int[] PrefixesForMagicAndSummons;

			// Token: 0x04008CA6 RID: 36006
			[global::Cpp2ILInjected.Token(Token = "0x4008122")]
			public static int[] PrefixesForBoomeransAndChakrums;

			// Token: 0x04008CA7 RID: 36007
			[global::Cpp2ILInjected.Token(Token = "0x4008123")]
			public static int[] PrefixesForBoomeransAndChakrums_TerrarianYoyo;

			// Token: 0x04008CA8 RID: 36008
			[global::Cpp2ILInjected.Token(Token = "0x4008124")]
			public static int[] PrefixesForAccessories;
		}

		// Token: 0x020009A7 RID: 2471
		[global::Cpp2ILInjected.Token(Token = "0x200082B")]
		public class ItemSets
		{
			// Token: 0x06004DF5 RID: 19957 RVA: 0x0002FC1B File Offset: 0x0002DE1B
			[global::Cpp2ILInjected.Token(Token = "0x60042DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x79BC94", Offset = "0x79BC94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ItemSets()
			{
				throw null;
			}

			// Token: 0x06004DF6 RID: 19958 RVA: 0x0002FC1E File Offset: 0x0002DE1E
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

			// Token: 0x04008CA9 RID: 36009
			[global::Cpp2ILInjected.Token(Token = "0x4008125")]
			public static SetFactory Factory;

			// Token: 0x04008CAA RID: 36010
			[global::Cpp2ILInjected.Token(Token = "0x4008126")]
			public static bool[] BoomerangsChakrams;

			// Token: 0x04008CAB RID: 36011
			[global::Cpp2ILInjected.Token(Token = "0x4008127")]
			public static bool[] ItemsThatCanHaveLegendary2;

			// Token: 0x04008CAC RID: 36012
			[global::Cpp2ILInjected.Token(Token = "0x4008128")]
			public static bool[] MagicAndSummon;

			// Token: 0x04008CAD RID: 36013
			[global::Cpp2ILInjected.Token(Token = "0x4008129")]
			public static bool[] GunsBows;

			// Token: 0x04008CAE RID: 36014
			[global::Cpp2ILInjected.Token(Token = "0x400812A")]
			public static bool[] SpearsMacesChainsawsDrillsPunchCannon;

			// Token: 0x04008CAF RID: 36015
			[global::Cpp2ILInjected.Token(Token = "0x400812B")]
			public static bool[] SwordsHammersAxesPicks;
		}
	}
}
