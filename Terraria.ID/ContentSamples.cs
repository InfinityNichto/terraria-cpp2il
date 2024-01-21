using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.GameContent.Bestiary;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x20003E7")]
public static class ContentSamples
{
	[Cpp2IlInjected.Token(Token = "0x2000911")]
	public static class CommonlyUsedContentSamples
	{
		[Cpp2IlInjected.Token(Token = "0x400894E")]
		public static int TeamDyeShaderIndex;

		[Cpp2IlInjected.Token(Token = "0x400894F")]
		public static int ColorOnlyShaderIndex;

		[Cpp2IlInjected.Token(Token = "0x6004C9A")]
		[Cpp2IlInjected.Address(RVA = "0x14135F8", Offset = "0x14135F8", VA = "0x14135F8")]
		public static void PrepareAfterEverythingElseLoaded()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000912")]
	public static class CreativeHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000B6B")]
		public enum ItemGroup
		{
			[Cpp2IlInjected.Token(Token = "0x4009034")]
			Coin = 10,
			[Cpp2IlInjected.Token(Token = "0x4009035")]
			CraftingObjects = 11,
			[Cpp2IlInjected.Token(Token = "0x4009036")]
			Torches = 20,
			[Cpp2IlInjected.Token(Token = "0x4009037")]
			Glowsticks = 25,
			[Cpp2IlInjected.Token(Token = "0x4009038")]
			Wood = 30,
			[Cpp2IlInjected.Token(Token = "0x4009039")]
			Bombs = 40,
			[Cpp2IlInjected.Token(Token = "0x400903A")]
			LifePotions = 50,
			[Cpp2IlInjected.Token(Token = "0x400903B")]
			ManaPotions = 51,
			[Cpp2IlInjected.Token(Token = "0x400903C")]
			BuffPotion = 52,
			[Cpp2IlInjected.Token(Token = "0x400903D")]
			Flask = 53,
			[Cpp2IlInjected.Token(Token = "0x400903E")]
			Food = 54,
			[Cpp2IlInjected.Token(Token = "0x400903F")]
			Crates = 60,
			[Cpp2IlInjected.Token(Token = "0x4009040")]
			BossBags = 70,
			[Cpp2IlInjected.Token(Token = "0x4009041")]
			GoodieBags = 80,
			[Cpp2IlInjected.Token(Token = "0x4009042")]
			AlchemyPlants = 83,
			[Cpp2IlInjected.Token(Token = "0x4009043")]
			AlchemySeeds = 84,
			[Cpp2IlInjected.Token(Token = "0x4009044")]
			DyeMaterial = 87,
			[Cpp2IlInjected.Token(Token = "0x4009045")]
			BossItem = 90,
			[Cpp2IlInjected.Token(Token = "0x4009046")]
			EventItem = 91,
			[Cpp2IlInjected.Token(Token = "0x4009047")]
			ConsumableThatDoesNotDamage = 94,
			[Cpp2IlInjected.Token(Token = "0x4009048")]
			Solutions = 95,
			[Cpp2IlInjected.Token(Token = "0x4009049")]
			Ammo = 96,
			[Cpp2IlInjected.Token(Token = "0x400904A")]
			ConsumableThatDamages = 97,
			[Cpp2IlInjected.Token(Token = "0x400904B")]
			PlacableObjects = 100,
			[Cpp2IlInjected.Token(Token = "0x400904C")]
			Blocks = 120,
			[Cpp2IlInjected.Token(Token = "0x400904D")]
			Wands = 130,
			[Cpp2IlInjected.Token(Token = "0x400904E")]
			Rope = 140,
			[Cpp2IlInjected.Token(Token = "0x400904F")]
			Walls = 150,
			[Cpp2IlInjected.Token(Token = "0x4009050")]
			Wiring = 200,
			[Cpp2IlInjected.Token(Token = "0x4009051")]
			Pickaxe = 500,
			[Cpp2IlInjected.Token(Token = "0x4009052")]
			Axe = 510,
			[Cpp2IlInjected.Token(Token = "0x4009053")]
			Hammer = 520,
			[Cpp2IlInjected.Token(Token = "0x4009054")]
			MeleeWeapon = 530,
			[Cpp2IlInjected.Token(Token = "0x4009055")]
			RangedWeapon = 540,
			[Cpp2IlInjected.Token(Token = "0x4009056")]
			MagicWeapon = 550,
			[Cpp2IlInjected.Token(Token = "0x4009057")]
			SummonWeapon = 560,
			[Cpp2IlInjected.Token(Token = "0x4009058")]
			Headgear = 600,
			[Cpp2IlInjected.Token(Token = "0x4009059")]
			Torso = 610,
			[Cpp2IlInjected.Token(Token = "0x400905A")]
			Pants = 620,
			[Cpp2IlInjected.Token(Token = "0x400905B")]
			Accessories = 630,
			[Cpp2IlInjected.Token(Token = "0x400905C")]
			Hook = 700,
			[Cpp2IlInjected.Token(Token = "0x400905D")]
			Mount = 710,
			[Cpp2IlInjected.Token(Token = "0x400905E")]
			Minecart = 720,
			[Cpp2IlInjected.Token(Token = "0x400905F")]
			VanityPet = 800,
			[Cpp2IlInjected.Token(Token = "0x4009060")]
			LightPet = 810,
			[Cpp2IlInjected.Token(Token = "0x4009061")]
			Golf = 900,
			[Cpp2IlInjected.Token(Token = "0x4009062")]
			BossSpawners = 901,
			[Cpp2IlInjected.Token(Token = "0x4009063")]
			Dye = 910,
			[Cpp2IlInjected.Token(Token = "0x4009064")]
			HairDye = 920,
			[Cpp2IlInjected.Token(Token = "0x4009065")]
			Paint = 930,
			[Cpp2IlInjected.Token(Token = "0x4009066")]
			FishingRods = 1000,
			[Cpp2IlInjected.Token(Token = "0x4009067")]
			FishingQuestFish = 1010,
			[Cpp2IlInjected.Token(Token = "0x4009068")]
			Fish = 1015,
			[Cpp2IlInjected.Token(Token = "0x4009069")]
			FishingBait = 1020,
			[Cpp2IlInjected.Token(Token = "0x400906A")]
			Critters = 1030,
			[Cpp2IlInjected.Token(Token = "0x400906B")]
			Keys = 2000,
			[Cpp2IlInjected.Token(Token = "0x400906C")]
			RemainingUseItems = 5000,
			[Cpp2IlInjected.Token(Token = "0x400906D")]
			Material = 10000,
			[Cpp2IlInjected.Token(Token = "0x400906E")]
			EverythingElse = 11000
		}

		[Cpp2IlInjected.Token(Token = "0x2000B6C")]
		public struct ItemGroupAndOrderInGroup
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400906F")]
			public int ItemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4009070")]
			public ItemGroup Group;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009071")]
			public int OrderInGroup;

			[Cpp2IlInjected.Token(Token = "0x600539B")]
			[Cpp2IlInjected.Address(RVA = "0x39EF90", Offset = "0x39EF90", VA = "0x39EF90")]
			public ItemGroupAndOrderInGroup(Item item)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4008950")]
		private static List<int> _manualEventItemsOrder;

		[Cpp2IlInjected.Token(Token = "0x4008951")]
		private static List<int> _manualBossSpawnItemsOrder;

		[Cpp2IlInjected.Token(Token = "0x4008952")]
		public static List<int> _manualCraftingStations;

		[Cpp2IlInjected.Token(Token = "0x4008953")]
		private static List<int> _manualGolfItemsOrder;

		[Cpp2IlInjected.Token(Token = "0x6004C9C")]
		[Cpp2IlInjected.Address(RVA = "0x1413744", Offset = "0x1413744", VA = "0x1413744")]
		public static ItemGroup GetItemGroup(Item item, out int orderInGroup)
		{
			return default(ItemGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C9D")]
		[Cpp2IlInjected.Address(RVA = "0x1412178", Offset = "0x1412178", VA = "0x1412178")]
		public static void SetCreativeMenuOrder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004C9E")]
		[Cpp2IlInjected.Address(RVA = "0x1414914", Offset = "0x1414914", VA = "0x1414914")]
		public static bool ShouldRemoveFromList(Item item)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000913")]
	public static class BestiaryHelper
	{
		[Cpp2IlInjected.Token(Token = "0x6004CA0")]
		[Cpp2IlInjected.Address(RVA = "0x1411780", Offset = "0x1411780", VA = "0x1411780")]
		public static List<KeyValuePair<int, NPC>> GetSortedBestiaryEntriesList(BestiaryDatabase database)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA1")]
		[Cpp2IlInjected.Address(RVA = "0x1412DAC", Offset = "0x1412DAC", VA = "0x1412DAC")]
		public static int GetLowestBiomeGroupIndex(NPC npc, BestiaryDatabase database, List<IBestiaryInfoElement> commonElements)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA2")]
		[Cpp2IlInjected.Address(RVA = "0x1412E6C", Offset = "0x1412E6C", VA = "0x1412E6C")]
		public static bool ShouldHideBestiaryEntry(NPC npc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA3")]
		[Cpp2IlInjected.Address(RVA = "0x1412F28", Offset = "0x1412F28", VA = "0x1412F28")]
		public static float GetBestiaryPowerLevel(NPC npc)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA4")]
		[Cpp2IlInjected.Address(RVA = "0x1412F54", Offset = "0x1412F54", VA = "0x1412F54")]
		public static int GetBestiaryTownPriority(NPC npc)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA5")]
		[Cpp2IlInjected.Address(RVA = "0x1412FF0", Offset = "0x1412FF0", VA = "0x1412FF0")]
		public static int GetBestiaryNormalGoldCritterPriority(NPC npc)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA6")]
		[Cpp2IlInjected.Address(RVA = "0x141308C", Offset = "0x141308C", VA = "0x141308C")]
		public static int GetBestiaryBossPriority(NPC npc)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CA7")]
		[Cpp2IlInjected.Address(RVA = "0x1413120", Offset = "0x1413120", VA = "0x1413120")]
		public static int GetBestiaryStarsPriority(NPC npc)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400357E")]
	public static Dictionary<int, NPC> NpcsByNetId;

	[Cpp2IlInjected.Token(Token = "0x400357F")]
	public static Dictionary<int, Item> ItemsByType;

	[Cpp2IlInjected.Token(Token = "0x4003580")]
	public static Dictionary<string, int> ItemNetIdsByPersistentIds;

	[Cpp2IlInjected.Token(Token = "0x4003581")]
	public static Dictionary<int, string> ItemPersistentIdsByNetIds;

	[Cpp2IlInjected.Token(Token = "0x4003582")]
	public static Dictionary<int, int> CreativeResearchItemPersistentIdOverride;

	[Cpp2IlInjected.Token(Token = "0x4003583")]
	public static Dictionary<string, int> NpcNetIdsByPersistentIds;

	[Cpp2IlInjected.Token(Token = "0x4003584")]
	public static Dictionary<int, string> NpcPersistentIdsByNetIds;

	[Cpp2IlInjected.Token(Token = "0x4003585")]
	public static Dictionary<int, int> NpcBestiarySortingId;

	[Cpp2IlInjected.Token(Token = "0x4003586")]
	public static Dictionary<int, int> NpcBestiaryRarityStars;

	[Cpp2IlInjected.Token(Token = "0x4003587")]
	public static Dictionary<int, string> NpcBestiaryCreditIdsByNpcNetIds;

	[Cpp2IlInjected.Token(Token = "0x4003588")]
	public static Dictionary<int, CreativeHelper.ItemGroupAndOrderInGroup> ItemCreativeSortingId;

	[Cpp2IlInjected.Token(Token = "0x600307A")]
	[Cpp2IlInjected.Address(RVA = "0x140E72C", Offset = "0x140E72C", VA = "0x140E72C")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600307B")]
	[Cpp2IlInjected.Address(RVA = "0x1410EDC", Offset = "0x1410EDC", VA = "0x1410EDC")]
	public static void ResetItemTooltips()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600307C")]
	[Cpp2IlInjected.Address(RVA = "0x141103C", Offset = "0x141103C", VA = "0x141103C")]
	public static void RefreshItemsOnWorldLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600307D")]
	[Cpp2IlInjected.Address(RVA = "0x140FD14", Offset = "0x140FD14", VA = "0x140FD14")]
	private static void FillResearchItemOverrides()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600307E")]
	[Cpp2IlInjected.Address(RVA = "0x141119C", Offset = "0x141119C", VA = "0x141119C")]
	private static void AddItemResearchOverride(int itemTypeToUnlock, params int[] itemsThatWillResearchTheItemToUnlock)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600307F")]
	[Cpp2IlInjected.Address(RVA = "0x1411244", Offset = "0x1411244", VA = "0x1411244")]
	private static void AddItemResearchOverride_Inner(int itemTypeToSacrifice, int itemTypeToUnlock)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003080")]
	[Cpp2IlInjected.Address(RVA = "0x14112E0", Offset = "0x14112E0", VA = "0x14112E0")]
	public static void FixItemsAfterRecipesAreAdded()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003081")]
	[Cpp2IlInjected.Address(RVA = "0x1411470", Offset = "0x1411470", VA = "0x1411470")]
	public static void RebuildBestiarySortingIDsByBestiaryDatabaseContents(BestiaryDatabase database)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003082")]
	[Cpp2IlInjected.Address(RVA = "0x1411680", Offset = "0x1411680", VA = "0x1411680")]
	public static void RebuildItemCreativeSortingIDsAfterRecipesAreSetUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003083")]
	[Cpp2IlInjected.Address(RVA = "0x140ECF8", Offset = "0x140ECF8", VA = "0x140ECF8")]
	private static void ModifyNPCIds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003084")]
	[Cpp2IlInjected.Address(RVA = "0x1411508", Offset = "0x1411508", VA = "0x1411508")]
	private static void CreateBestiarySortingIds(BestiaryDatabase database)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003085")]
	[Cpp2IlInjected.Address(RVA = "0x140FE90", Offset = "0x140FE90", VA = "0x140FE90")]
	private static void FillNpcRarities()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003086")]
	[Cpp2IlInjected.Address(RVA = "0x1412050", Offset = "0x1412050", VA = "0x1412050")]
	private static int GetNPCBestiaryRarityStarsCount(NPC npc)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003087")]
	[Cpp2IlInjected.Address(RVA = "0x1411710", Offset = "0x1411710", VA = "0x1411710")]
	private static void CreateCreativeItemSortingIds()
	{
	}
}
