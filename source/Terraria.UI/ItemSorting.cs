using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004C7")]
public class ItemSorting
{
	[Cpp2IlInjected.Token(Token = "0x200094D")]
	private class ItemSortingLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008B40")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008B41")]
		public readonly Func<ItemSortingLayer, Item[], List<int>, List<int>> SortingMethod;

		[Cpp2IlInjected.Token(Token = "0x6004D46")]
		[Cpp2IlInjected.Address(RVA = "0x1338FD0", Offset = "0x1338FD0", VA = "0x1338FD0")]
		public ItemSortingLayer(string name, Func<ItemSortingLayer, Item[], List<int>, List<int>> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D47")]
		[Cpp2IlInjected.Address(RVA = "0x1338FF8", Offset = "0x1338FF8", VA = "0x1338FF8")]
		public void Validate(ref List<int> indexesSortable, Item[] inv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D48")]
		[Cpp2IlInjected.Address(RVA = "0x1339148", Offset = "0x1339148", VA = "0x1339148", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200094E")]
	private class ItemSortingLayers
	{
		[Cpp2IlInjected.Token(Token = "0x4008B42")]
		public static ItemSortingLayer WeaponsMelee;

		[Cpp2IlInjected.Token(Token = "0x4008B43")]
		public static ItemSortingLayer WeaponsRanged;

		[Cpp2IlInjected.Token(Token = "0x4008B44")]
		public static ItemSortingLayer WeaponsMagic;

		[Cpp2IlInjected.Token(Token = "0x4008B45")]
		public static ItemSortingLayer WeaponsMinions;

		[Cpp2IlInjected.Token(Token = "0x4008B46")]
		public static ItemSortingLayer WeaponsAssorted;

		[Cpp2IlInjected.Token(Token = "0x4008B47")]
		public static ItemSortingLayer WeaponsAmmo;

		[Cpp2IlInjected.Token(Token = "0x4008B48")]
		public static ItemSortingLayer ToolsPicksaws;

		[Cpp2IlInjected.Token(Token = "0x4008B49")]
		public static ItemSortingLayer ToolsHamaxes;

		[Cpp2IlInjected.Token(Token = "0x4008B4A")]
		public static ItemSortingLayer ToolsPickaxes;

		[Cpp2IlInjected.Token(Token = "0x4008B4B")]
		public static ItemSortingLayer ToolsAxes;

		[Cpp2IlInjected.Token(Token = "0x4008B4C")]
		public static ItemSortingLayer ToolsHammers;

		[Cpp2IlInjected.Token(Token = "0x4008B4D")]
		public static ItemSortingLayer ToolsTerraforming;

		[Cpp2IlInjected.Token(Token = "0x4008B4E")]
		public static ItemSortingLayer ToolsAmmoLeftovers;

		[Cpp2IlInjected.Token(Token = "0x4008B4F")]
		public static ItemSortingLayer ArmorCombat;

		[Cpp2IlInjected.Token(Token = "0x4008B50")]
		public static ItemSortingLayer ArmorVanity;

		[Cpp2IlInjected.Token(Token = "0x4008B51")]
		public static ItemSortingLayer ArmorAccessories;

		[Cpp2IlInjected.Token(Token = "0x4008B52")]
		public static ItemSortingLayer EquipGrapple;

		[Cpp2IlInjected.Token(Token = "0x4008B53")]
		public static ItemSortingLayer EquipMount;

		[Cpp2IlInjected.Token(Token = "0x4008B54")]
		public static ItemSortingLayer EquipCart;

		[Cpp2IlInjected.Token(Token = "0x4008B55")]
		public static ItemSortingLayer EquipLightPet;

		[Cpp2IlInjected.Token(Token = "0x4008B56")]
		public static ItemSortingLayer EquipVanityPet;

		[Cpp2IlInjected.Token(Token = "0x4008B57")]
		public static ItemSortingLayer PotionsLife;

		[Cpp2IlInjected.Token(Token = "0x4008B58")]
		public static ItemSortingLayer PotionsMana;

		[Cpp2IlInjected.Token(Token = "0x4008B59")]
		public static ItemSortingLayer PotionsElixirs;

		[Cpp2IlInjected.Token(Token = "0x4008B5A")]
		public static ItemSortingLayer PotionsBuffs;

		[Cpp2IlInjected.Token(Token = "0x4008B5B")]
		public static ItemSortingLayer PotionsDyes;

		[Cpp2IlInjected.Token(Token = "0x4008B5C")]
		public static ItemSortingLayer PotionsHairDyes;

		[Cpp2IlInjected.Token(Token = "0x4008B5D")]
		public static ItemSortingLayer MiscValuables;

		[Cpp2IlInjected.Token(Token = "0x4008B5E")]
		public static ItemSortingLayer MiscWiring;

		[Cpp2IlInjected.Token(Token = "0x4008B5F")]
		public static ItemSortingLayer MiscMaterials;

		[Cpp2IlInjected.Token(Token = "0x4008B60")]
		public static ItemSortingLayer MiscExtractinator;

		[Cpp2IlInjected.Token(Token = "0x4008B61")]
		public static ItemSortingLayer MiscPainting;

		[Cpp2IlInjected.Token(Token = "0x4008B62")]
		public static ItemSortingLayer MiscRopes;

		[Cpp2IlInjected.Token(Token = "0x4008B63")]
		public static ItemSortingLayer LastMaterials;

		[Cpp2IlInjected.Token(Token = "0x4008B64")]
		public static ItemSortingLayer LastTilesImportant;

		[Cpp2IlInjected.Token(Token = "0x4008B65")]
		public static ItemSortingLayer LastTilesCommon;

		[Cpp2IlInjected.Token(Token = "0x4008B66")]
		public static ItemSortingLayer LastNotTrash;

		[Cpp2IlInjected.Token(Token = "0x4008B67")]
		public static ItemSortingLayer LastTrash;

		[Cpp2IlInjected.Token(Token = "0x6004D49")]
		[Cpp2IlInjected.Address(RVA = "0x13391C0", Offset = "0x13391C0", VA = "0x13391C0")]
		public ItemSortingLayers()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006693")]
	private static List<ItemSortingLayer> _layerList;

	[Cpp2IlInjected.Token(Token = "0x4006694")]
	private static Dictionary<string, List<int>> _layerWhiteLists;

	[Cpp2IlInjected.Token(Token = "0x60035DF")]
	[Cpp2IlInjected.Address(RVA = "0x1334F04", Offset = "0x1334F04", VA = "0x1334F04")]
	public static void SetupWhiteLists()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035E0")]
	[Cpp2IlInjected.Address(RVA = "0x1336690", Offset = "0x1336690", VA = "0x1336690")]
	private static void SetupSortingPriorities()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035E1")]
	[Cpp2IlInjected.Address(RVA = "0x133723C", Offset = "0x133723C", VA = "0x133723C")]
	private static void Sort(Item[] inv, bool fromChest, params int[] ignoreSlots)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035E2")]
	[Cpp2IlInjected.Address(RVA = "0x1337B50", Offset = "0x1337B50", VA = "0x1337B50")]
	public static void SortInventory()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035E3")]
	[Cpp2IlInjected.Address(RVA = "0x13380E4", Offset = "0x13380E4", VA = "0x13380E4")]
	public static void SortChest()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035E4")]
	[Cpp2IlInjected.Address(RVA = "0x1338070", Offset = "0x1338070", VA = "0x1338070")]
	public static void SortAmmo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035E5")]
	[Cpp2IlInjected.Address(RVA = "0x1338870", Offset = "0x1338870", VA = "0x1338870")]
	public static void FillAmmoFromInventory()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035E6")]
	[Cpp2IlInjected.Address(RVA = "0x13386D0", Offset = "0x13386D0", VA = "0x13386D0")]
	public static void ClearAmmoSlotSpaces()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035E7")]
	[Cpp2IlInjected.Address(RVA = "0x1337CC0", Offset = "0x1337CC0", VA = "0x1337CC0")]
	private static void SortCoins()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035E8")]
	[Cpp2IlInjected.Address(RVA = "0x1338D04", Offset = "0x1338D04", VA = "0x1338D04")]
	private static void RefillItemStack(Item[] inv, Item itemToRefill, int loopStartIndex, int loopEndIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035E9")]
	[Cpp2IlInjected.Address(RVA = "0x1338DA4", Offset = "0x1338DA4", VA = "0x1338DA4")]
	private static void TrySlidingUp(Item[] inv, int slot, int minimumIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035EA")]
	[Cpp2IlInjected.Address(RVA = "0x1338E6C", Offset = "0x1338E6C", VA = "0x1338E6C")]
	public ItemSorting()
	{
	}
}
