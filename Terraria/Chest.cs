using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000314")]
public class Chest : IFixLoadedData
{
	[Cpp2IlInjected.Token(Token = "0x4002182")]
	private static HashSet<int> _chestInUse;

	[Cpp2IlInjected.Token(Token = "0x4002183")]
	public const float chestStackRange = 600f;

	[Cpp2IlInjected.Token(Token = "0x4002184")]
	public const int maxChestTypes = 52;

	[Cpp2IlInjected.Token(Token = "0x4002185")]
	public static int[] chestTypeToIcon;

	[Cpp2IlInjected.Token(Token = "0x4002186")]
	public static int[] chestItemSpawn;

	[Cpp2IlInjected.Token(Token = "0x4002187")]
	public const int maxChestTypes2 = 17;

	[Cpp2IlInjected.Token(Token = "0x4002188")]
	public static int[] chestTypeToIcon2;

	[Cpp2IlInjected.Token(Token = "0x4002189")]
	public static int[] chestItemSpawn2;

	[Cpp2IlInjected.Token(Token = "0x400218A")]
	public const int maxDresserTypes = 43;

	[Cpp2IlInjected.Token(Token = "0x400218B")]
	public static int[] dresserTypeToIcon;

	[Cpp2IlInjected.Token(Token = "0x400218C")]
	public static int[] dresserItemSpawn;

	[Cpp2IlInjected.Token(Token = "0x400218D")]
	public const int maxItems = 40;

	[Cpp2IlInjected.Token(Token = "0x400218E")]
	public const int MaxNameLength = 29;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400218F")]
	public Item[] item;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002190")]
	public int x;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002191")]
	public int y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002192")]
	public bool bankChest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002193")]
	public string name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002194")]
	public int frameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002195")]
	public int frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002196")]
	public int eatingAnimationTime;

	[Cpp2IlInjected.Token(Token = "0x4002197")]
	private static Item[] bartenderResort;

	[Cpp2IlInjected.Token(Token = "0x4002198")]
	private static int forcedDDTier;

	[Cpp2IlInjected.Token(Token = "0x6001952")]
	[Cpp2IlInjected.Address(RVA = "0x11CFE70", Offset = "0x11CFE70", VA = "0x11CFE70")]
	public Chest(bool bank = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001953")]
	[Cpp2IlInjected.Address(RVA = "0x11CFF00", Offset = "0x11CFF00", VA = "0x11CFF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001954")]
	[Cpp2IlInjected.Address(RVA = "0x11CFFFC", Offset = "0x11CFFFC", VA = "0x11CFFFC")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001955")]
	[Cpp2IlInjected.Address(RVA = "0x11D0868", Offset = "0x11D0868", VA = "0x11D0868")]
	private static bool IsPlayerInChest(int i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001956")]
	[Cpp2IlInjected.Address(RVA = "0x11D094C", Offset = "0x11D094C", VA = "0x11D094C")]
	public static List<int> GetCurrentlyOpenChests()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001957")]
	[Cpp2IlInjected.Address(RVA = "0x11D0A98", Offset = "0x11D0A98", VA = "0x11D0A98")]
	public static bool IsLocked(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001958")]
	[Cpp2IlInjected.Address(RVA = "0x11D0B60", Offset = "0x11D0B60", VA = "0x11D0B60")]
	public static bool IsLocked(Tile t)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001959")]
	[Cpp2IlInjected.Address(RVA = "0x11D0CE8", Offset = "0x11D0CE8", VA = "0x11D0CE8")]
	public static void ServerPlaceItem(int plr, int slot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600195A")]
	[Cpp2IlInjected.Address(RVA = "0x11D1034", Offset = "0x11D1034", VA = "0x11D1034")]
	public static Item PutItemInNearbyChest(Item item, Vector2 position)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600195B")]
	[Cpp2IlInjected.Address(RVA = "0x11D16E0", Offset = "0x11D16E0", VA = "0x11D16E0")]
	public static void VisualizeChestTransfer(Vector2 position, Vector2 chestPosition, Item item, int amountMoved)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600195C")]
	[Cpp2IlInjected.Address(RVA = "0x11D17DC", Offset = "0x11D17DC", VA = "0x11D17DC")]
	public static void VisualizeChestTransfer_CoinsBatch(Vector2 position, Vector2 chestPosition, long coinsMoved)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600195D")]
	[Cpp2IlInjected.Address(RVA = "0x11D195C", Offset = "0x11D195C", VA = "0x11D195C")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600195E")]
	[Cpp2IlInjected.Address(RVA = "0x11D1964", Offset = "0x11D1964", VA = "0x11D1964")]
	public static bool Unlock(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600195F")]
	[Cpp2IlInjected.Address(RVA = "0x11D1D98", Offset = "0x11D1D98", VA = "0x11D1D98")]
	public static bool Lock(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001960")]
	[Cpp2IlInjected.Address(RVA = "0x11D20C4", Offset = "0x11D20C4", VA = "0x11D20C4")]
	public static int UsingChest(int i)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001961")]
	[Cpp2IlInjected.Address(RVA = "0x11D221C", Offset = "0x11D221C", VA = "0x11D221C")]
	public static int FindChest(int X, int Y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001962")]
	[Cpp2IlInjected.Address(RVA = "0x11D2340", Offset = "0x11D2340", VA = "0x11D2340")]
	public static int FindChestByGuessing(int X, int Y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001963")]
	[Cpp2IlInjected.Address(RVA = "0x11D24E4", Offset = "0x11D24E4", VA = "0x11D24E4")]
	public static int FindEmptyChest(int x, int y, int type = 21, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001964")]
	[Cpp2IlInjected.Address(RVA = "0x11D25B8", Offset = "0x11D25B8", VA = "0x11D25B8")]
	public static bool NearOtherChests(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001965")]
	[Cpp2IlInjected.Address(RVA = "0x11D26E0", Offset = "0x11D26E0", VA = "0x11D26E0")]
	public static int AfterPlacement_Hook(int x, int y, int type = 21, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001966")]
	[Cpp2IlInjected.Address(RVA = "0x11D2A58", Offset = "0x11D2A58", VA = "0x11D2A58")]
	public static int CreateChest(int X, int Y, int id = -1)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001967")]
	[Cpp2IlInjected.Address(RVA = "0x11D2C98", Offset = "0x11D2C98", VA = "0x11D2C98")]
	public static bool CanDestroyChest(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001968")]
	[Cpp2IlInjected.Address(RVA = "0x11D2DA0", Offset = "0x11D2DA0", VA = "0x11D2DA0")]
	public static bool DestroyChest(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001969")]
	[Cpp2IlInjected.Address(RVA = "0x11D2F88", Offset = "0x11D2F88", VA = "0x11D2F88")]
	public static void DestroyChestDirect(int X, int Y, int id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600196A")]
	[Cpp2IlInjected.Address(RVA = "0x11D31D0", Offset = "0x11D31D0", VA = "0x11D31D0")]
	public void AddItemToShop(Item newItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600196B")]
	[Cpp2IlInjected.Address(RVA = "0x11D331C", Offset = "0x11D331C", VA = "0x11D331C")]
	public static void SetupTravelShop_AddToShop(int it, ref int added, ref int count)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600196C")]
	[Cpp2IlInjected.Address(RVA = "0x11D393C", Offset = "0x11D393C", VA = "0x11D393C")]
	public static bool SetupTravelShop_CanAddItemToShop(int it)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600196D")]
	[Cpp2IlInjected.Address(RVA = "0x11D3A4C", Offset = "0x11D3A4C", VA = "0x11D3A4C")]
	public static void SetupTravelShop_GetPainting(Player playerWithHighestLuck, int[] rarity, ref int it, int minimumRarity = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600196E")]
	[Cpp2IlInjected.Address(RVA = "0x11D4344", Offset = "0x11D4344", VA = "0x11D4344")]
	public static void SetupTravelShop_AdjustSlotRarities(int slotItemAttempts, ref int[] rarity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600196F")]
	[Cpp2IlInjected.Address(RVA = "0x11D43F0", Offset = "0x11D43F0", VA = "0x11D43F0")]
	public static void SetupTravelShop_GetItem(Player playerWithHighestLuck, int[] rarity, ref int it, int minimumRarity = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001970")]
	[Cpp2IlInjected.Address(RVA = "0x11D5008", Offset = "0x11D5008", VA = "0x11D5008")]
	public static void SetupTravelShop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001971")]
	[Cpp2IlInjected.Address(RVA = "0x11D55B8", Offset = "0x11D55B8", VA = "0x11D55B8")]
	public void SetupShop(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001972")]
	[Cpp2IlInjected.Address(RVA = "0x11DF510", Offset = "0x11DF510", VA = "0x11DF510")]
	private static bool BestiaryGirl_IsFairyTorchAvailable()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001973")]
	[Cpp2IlInjected.Address(RVA = "0x11DF5EC", Offset = "0x11DF5EC", VA = "0x11DF5EC")]
	private static bool DidDiscoverBestiaryEntry(int npcId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001974")]
	[Cpp2IlInjected.Address(RVA = "0x11DF70C", Offset = "0x11DF70C", VA = "0x11DF70C")]
	public static void AskForChestToEatItem(Vector2 worldPosition, int duration)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001975")]
	[Cpp2IlInjected.Address(RVA = "0x11DF82C", Offset = "0x11DF82C", VA = "0x11DF82C")]
	public static void UpdateChestFrames()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001976")]
	[Cpp2IlInjected.Address(RVA = "0x11DFBEC", Offset = "0x11DFBEC", VA = "0x11DFBEC", Slot = "4")]
	public void FixLoadedData()
	{
	}
}
