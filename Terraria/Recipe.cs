using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000344")]
public class Recipe
{
	[Cpp2IlInjected.Token(Token = "0x2000864")]
	private struct RequiredItemEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007F68")]
		public int itemIdOrRecipeGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007F69")]
		public int stack;
	}

	[Cpp2IlInjected.Token(Token = "0x4002EFA")]
	public const int maxRequirements = 15;

	[Cpp2IlInjected.Token(Token = "0x4002EFB")]
	public const int maxRecipes = 3000;

	[Cpp2IlInjected.Token(Token = "0x4002EFC")]
	public static int numRecipes;

	[Cpp2IlInjected.Token(Token = "0x4002EFD")]
	private static Recipe currentRecipe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002EFE")]
	public Item createItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002EFF")]
	public Item[] requiredItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002F00")]
	public int[] requiredTile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002F01")]
	public int[] acceptedGroups;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002F02")]
	private RequiredItemEntry[] requiredItemQuickLookup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002F03")]
	public List<Item> customShimmerResults;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002F04")]
	public bool needHoney;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4002F05")]
	public bool needWater;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4002F06")]
	public bool needLava;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4002F07")]
	public bool anyWood;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002F08")]
	public bool anyIronBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4002F09")]
	public bool anyPressurePlate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x4002F0A")]
	public bool anySand;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
	[Cpp2IlInjected.Token(Token = "0x4002F0B")]
	public bool anyFragment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002F0C")]
	public bool alchemy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4002F0D")]
	public bool needSnowBiome;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4002F0E")]
	public bool needGraveyardBiome;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4002F0F")]
	public bool needEverythingSeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002F10")]
	public bool notDecraftable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4002F11")]
	public bool crimson;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4002F12")]
	public bool corruption;

	[Cpp2IlInjected.Token(Token = "0x4002F13")]
	private static Item defaultRecipeItem;

	[Cpp2IlInjected.Token(Token = "0x4002F14")]
	private static bool _hasDelayedFindRecipes;

	[Cpp2IlInjected.Token(Token = "0x4002F15")]
	private static Dictionary<int, int> _ownedItems;

	[Cpp2IlInjected.Token(Token = "0x6002722")]
	[Cpp2IlInjected.Address(RVA = "0xC93C14", Offset = "0xC93C14", VA = "0xC93C14")]
	public void RequireGroup(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002723")]
	[Cpp2IlInjected.Address(RVA = "0xC93CFC", Offset = "0xC93CFC", VA = "0xC93CFC")]
	public void RequireGroup(int id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002724")]
	[Cpp2IlInjected.Address(RVA = "0xC93D30", Offset = "0xC93D30", VA = "0xC93D30")]
	public bool ProcessGroupsForText(int type, out string theText)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002725")]
	[Cpp2IlInjected.Address(RVA = "0xC93E98", Offset = "0xC93E98", VA = "0xC93E98")]
	public bool AcceptsGroup(int groupId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002726")]
	[Cpp2IlInjected.Address(RVA = "0xC93ED8", Offset = "0xC93ED8", VA = "0xC93ED8")]
	public bool AcceptedByItemGroups(int invType, int reqType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002727")]
	[Cpp2IlInjected.Address(RVA = "0xC94030", Offset = "0xC94030", VA = "0xC94030")]
	public Item AddCustomShimmerResult(int itemType, int itemStack = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002728")]
	[Cpp2IlInjected.Address(RVA = "0xC94110", Offset = "0xC94110", VA = "0xC94110")]
	public Recipe()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002729")]
	[Cpp2IlInjected.Address(RVA = "0xC94254", Offset = "0xC94254", VA = "0xC94254")]
	public void Create()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600272A")]
	[Cpp2IlInjected.Address(RVA = "0xC95298", Offset = "0xC95298", VA = "0xC95298")]
	public bool useWood(int invType, int reqType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600272B")]
	[Cpp2IlInjected.Address(RVA = "0xC95458", Offset = "0xC95458", VA = "0xC95458")]
	public bool useIronBar(int invType, int reqType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600272C")]
	[Cpp2IlInjected.Address(RVA = "0xC95354", Offset = "0xC95354", VA = "0xC95354")]
	public bool useSand(int invType, int reqType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600272D")]
	[Cpp2IlInjected.Address(RVA = "0xC95424", Offset = "0xC95424", VA = "0xC95424")]
	public bool useFragment(int invType, int reqType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600272E")]
	[Cpp2IlInjected.Address(RVA = "0xC95484", Offset = "0xC95484", VA = "0xC95484")]
	public bool usePressurePlate(int invType, int reqType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600272F")]
	[Cpp2IlInjected.Address(RVA = "0xC95808", Offset = "0xC95808", VA = "0xC95808")]
	public static void GetThroughDelayedFindRecipes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002730")]
	[Cpp2IlInjected.Address(RVA = "0xC95538", Offset = "0xC95538", VA = "0xC95538")]
	public static void FindRecipes(bool canDelayCheck = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002731")]
	[Cpp2IlInjected.Address(RVA = "0xC95E44", Offset = "0xC95E44", VA = "0xC95E44")]
	private static void AddToAvailableRecipes(int recipeIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002732")]
	[Cpp2IlInjected.Address(RVA = "0xC961B4", Offset = "0xC961B4", VA = "0xC961B4")]
	public static bool CollectedEnoughItemsToCraftRecipeOld(Recipe tempRec)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002733")]
	[Cpp2IlInjected.Address(RVA = "0xC95D48", Offset = "0xC95D48", VA = "0xC95D48")]
	public static bool CollectedEnoughItemsToCraftRecipeNew(Recipe tempRec)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002734")]
	[Cpp2IlInjected.Address(RVA = "0xC95BD8", Offset = "0xC95BD8", VA = "0xC95BD8")]
	private static bool PlayerMeetsEnvironmentConditions(Player player, Recipe tempRec)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002735")]
	[Cpp2IlInjected.Address(RVA = "0xC95B80", Offset = "0xC95B80", VA = "0xC95B80")]
	private static bool PlayerMeetsTileRequirements(Player player, Recipe tempRec)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002736")]
	[Cpp2IlInjected.Address(RVA = "0xC9598C", Offset = "0xC9598C", VA = "0xC9598C")]
	private static void CollectItemsToCraftWithFrom(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002737")]
	[Cpp2IlInjected.Address(RVA = "0xC966B8", Offset = "0xC966B8", VA = "0xC966B8")]
	private static void AddFakeCountsForItemGroups()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002738")]
	[Cpp2IlInjected.Address(RVA = "0xC96588", Offset = "0xC96588", VA = "0xC96588")]
	private static void CollectItems(Item[] currentInventory, int slotCap)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002739")]
	[Cpp2IlInjected.Address(RVA = "0xC96880", Offset = "0xC96880", VA = "0xC96880")]
	private static void CollectGuideRecipes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600273A")]
	[Cpp2IlInjected.Address(RVA = "0xC958C4", Offset = "0xC958C4", VA = "0xC958C4")]
	public static void ClearAvailableRecipes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600273B")]
	[Cpp2IlInjected.Address(RVA = "0xC960C8", Offset = "0xC960C8", VA = "0xC960C8")]
	private static void VisuallyRepositionRecipes(float focusY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600273C")]
	[Cpp2IlInjected.Address(RVA = "0xC95EE4", Offset = "0xC95EE4", VA = "0xC95EE4")]
	private static void TryRefocusingRecipe(int oldRecipe)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600273D")]
	[Cpp2IlInjected.Address(RVA = "0xC96AC8", Offset = "0xC96AC8", VA = "0xC96AC8")]
	public static void SetupRecipeGroups()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600273E")]
	[Cpp2IlInjected.Address(RVA = "0xC98B9C", Offset = "0xC98B9C", VA = "0xC98B9C")]
	public static void UpdateItemVariants()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600273F")]
	[Cpp2IlInjected.Address(RVA = "0xC98D64", Offset = "0xC98D64", VA = "0xC98D64")]
	public static void SetupRecipes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002740")]
	[Cpp2IlInjected.Address(RVA = "0xCF601C", Offset = "0xCF601C", VA = "0xCF601C")]
	private static void ReplaceItemUseFlagsWithRecipeGroups()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002741")]
	[Cpp2IlInjected.Address(RVA = "0xCF6494", Offset = "0xCF6494", VA = "0xCF6494")]
	private void ReplaceItemUseFlagWithGroup(ref bool flag, int groupId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002742")]
	[Cpp2IlInjected.Address(RVA = "0xCF627C", Offset = "0xCF627C", VA = "0xCF627C")]
	private static void CreateRequiredItemQuickLookups()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002743")]
	[Cpp2IlInjected.Address(RVA = "0xCF5DF4", Offset = "0xCF5DF4", VA = "0xCF5DF4")]
	private static void UpdateMaterialFieldForAllRecipes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002744")]
	[Cpp2IlInjected.Address(RVA = "0xCF5B44", Offset = "0xCF5B44", VA = "0xCF5B44")]
	public static void UpdateWhichItemsAreMaterials()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002745")]
	[Cpp2IlInjected.Address(RVA = "0xCF5B48", Offset = "0xCF5B48", VA = "0xCF5B48")]
	public static void UpdateWhichItemsAreCrafted()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002746")]
	[Cpp2IlInjected.Address(RVA = "0xCEDA90", Offset = "0xCEDA90", VA = "0xCEDA90")]
	private static void AddSolarFurniture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002747")]
	[Cpp2IlInjected.Address(RVA = "0xCEE97C", Offset = "0xCEE97C", VA = "0xCEE97C")]
	private static void AddVortexFurniture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002748")]
	[Cpp2IlInjected.Address(RVA = "0xCEF868", Offset = "0xCEF868", VA = "0xCEF868")]
	private static void AddNebulaFurniture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002749")]
	[Cpp2IlInjected.Address(RVA = "0xCF0754", Offset = "0xCF0754", VA = "0xCF0754")]
	private static void AddStardustFurniture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600274A")]
	[Cpp2IlInjected.Address(RVA = "0xCEBAB0", Offset = "0xCEBAB0", VA = "0xCEBAB0")]
	private static void AddSpiderFurniture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600274B")]
	[Cpp2IlInjected.Address(RVA = "0xCEC958", Offset = "0xCEC958", VA = "0xCEC958")]
	private static void AddLesionFurniture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600274C")]
	[Cpp2IlInjected.Address(RVA = "0xCF1640", Offset = "0xCF1640", VA = "0xCF1640")]
	private static void AddSandstoneFurniture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600274D")]
	[Cpp2IlInjected.Address(RVA = "0xCF2420", Offset = "0xCF2420", VA = "0xCF2420")]
	private static void AddBambooFurniture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600274E")]
	[Cpp2IlInjected.Address(RVA = "0xCF314C", Offset = "0xCF314C", VA = "0xCF314C")]
	private static void AddCoralFurniture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600274F")]
	[Cpp2IlInjected.Address(RVA = "0xCF3E78", Offset = "0xCF3E78", VA = "0xCF3E78")]
	private static void AddBalloonFurniture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002750")]
	[Cpp2IlInjected.Address(RVA = "0xCEA9C0", Offset = "0xCEA9C0", VA = "0xCEA9C0")]
	private static void AddAshWoodFurnitureArmorAndItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002751")]
	[Cpp2IlInjected.Address(RVA = "0xCF5600", Offset = "0xCF5600", VA = "0xCF5600")]
	private static void CreateReversePlatformRecipes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002752")]
	[Cpp2IlInjected.Address(RVA = "0xCF5134", Offset = "0xCF5134", VA = "0xCF5134")]
	private static void CreateReverseWallRecipes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002753")]
	[Cpp2IlInjected.Address(RVA = "0xCEA840", Offset = "0xCEA840", VA = "0xCEA840")]
	public void SetIngredients(params int[] ingredients)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002754")]
	[Cpp2IlInjected.Address(RVA = "0xCEA98C", Offset = "0xCEA98C", VA = "0xCEA98C")]
	public void SetCraftingStation(params int[] tileIDs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002755")]
	[Cpp2IlInjected.Address(RVA = "0xCEA604", Offset = "0xCEA604", VA = "0xCEA604")]
	private static void AddRecipe()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002756")]
	[Cpp2IlInjected.Address(RVA = "0xCF64D4", Offset = "0xCF64D4", VA = "0xCF64D4")]
	public static int GetRequiredTileStyle(int tileID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002757")]
	[Cpp2IlInjected.Address(RVA = "0xCF6560", Offset = "0xCF6560", VA = "0xCF6560")]
	public bool ContainsIngredient(int itemType)
	{
		return default(bool);
	}
}
