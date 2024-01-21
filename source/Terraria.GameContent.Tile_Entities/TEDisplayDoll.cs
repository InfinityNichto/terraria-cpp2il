using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities;

[Cpp2IlInjected.Token(Token = "0x200057A")]
public class TEDisplayDoll : TileEntity, IFixLoadedData
{
	[Cpp2IlInjected.Token(Token = "0x4006AD5")]
	private static byte _myEntityID;

	[Cpp2IlInjected.Token(Token = "0x4006AD6")]
	private const int MyTileID = 470;

	[Cpp2IlInjected.Token(Token = "0x4006AD7")]
	private const int entityTileWidth = 2;

	[Cpp2IlInjected.Token(Token = "0x4006AD8")]
	private const int entityTileHeight = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006AD9")]
	public Player _dollPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006ADA")]
	public Item[] _items;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006ADB")]
	public Item[] _dyes;

	[Cpp2IlInjected.Token(Token = "0x4006ADC")]
	private static int accessoryTargetSlot;

	[Cpp2IlInjected.Token(Token = "0x6003B11")]
	[Cpp2IlInjected.Address(RVA = "0x127B0C4", Offset = "0x127B0C4", VA = "0x127B0C4")]
	public TEDisplayDoll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B12")]
	[Cpp2IlInjected.Address(RVA = "0x127B2DC", Offset = "0x127B2DC", VA = "0x127B2DC", Slot = "13")]
	public override void RegisterTileEntityID(int assignedID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B13")]
	[Cpp2IlInjected.Address(RVA = "0x127B358", Offset = "0x127B358", VA = "0x127B358", Slot = "16")]
	public override TileEntity GenerateInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B14")]
	[Cpp2IlInjected.Address(RVA = "0x127B3B8", Offset = "0x127B3B8", VA = "0x127B3B8", Slot = "14")]
	public override void NetPlaceEntityAttempt(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B15")]
	[Cpp2IlInjected.Address(RVA = "0x127B4B8", Offset = "0x127B4B8", VA = "0x127B4B8")]
	public static int Place(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B16")]
	[Cpp2IlInjected.Address(RVA = "0x127B6A8", Offset = "0x127B6A8", VA = "0x127B6A8")]
	public static int Hook_AfterPlacement(int x, int y, int type = 470, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B17")]
	[Cpp2IlInjected.Address(RVA = "0x127B92C", Offset = "0x127B92C", VA = "0x127B92C")]
	public static void Kill(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B18")]
	[Cpp2IlInjected.Address(RVA = "0x127BB4C", Offset = "0x127BB4C", VA = "0x127BB4C")]
	public static int Find(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B19")]
	[Cpp2IlInjected.Address(RVA = "0x127BC68", Offset = "0x127BC68", VA = "0x127BC68", Slot = "5")]
	public override void WriteExtraData(BinaryWriter writer, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B1A")]
	[Cpp2IlInjected.Address(RVA = "0x127C00C", Offset = "0x127C00C", VA = "0x127C00C", Slot = "6")]
	public override void ReadExtraData(BinaryReader reader, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B1B")]
	[Cpp2IlInjected.Address(RVA = "0x127C260", Offset = "0x127C260", VA = "0x127C260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B1C")]
	[Cpp2IlInjected.Address(RVA = "0x127C50C", Offset = "0x127C50C", VA = "0x127C50C")]
	public static void Framing_CheckTile(int callX, int callY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B1D")]
	[Cpp2IlInjected.Address(RVA = "0x127CAE4", Offset = "0x127CAE4", VA = "0x127CAE4")]
	public void Draw(int tileLeftX, int tileTopY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B1E")]
	[Cpp2IlInjected.Address(RVA = "0x127CF14", Offset = "0x127CF14", VA = "0x127CF14", Slot = "7")]
	public override void OnPlayerUpdate(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B1F")]
	[Cpp2IlInjected.Address(RVA = "0x127D050", Offset = "0x127D050", VA = "0x127D050")]
	public static void OnPlayerInteraction(Player player, int clickX, int clickY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B20")]
	[Cpp2IlInjected.Address(RVA = "0x127D24C", Offset = "0x127D24C", VA = "0x127D24C", Slot = "10")]
	public override bool TryGetItemGamepadOverrideInstructions(Item[] inv, int context, int slot, out string instruction)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B21")]
	[Cpp2IlInjected.Address(RVA = "0x127D4AC", Offset = "0x127D4AC", VA = "0x127D4AC")]
	private void DrawInner(Player player, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B22")]
	[Cpp2IlInjected.Address(RVA = "0x127D59C", Offset = "0x127D59C", VA = "0x127D59C")]
	private void DrawSlotPairSet(Player player, SpriteBatch spriteBatch, int slotsToShowLine, int slotsArrayOffset, float offsetX, float offsetY, int inventoryContextTarget)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B23")]
	[Cpp2IlInjected.Address(RVA = "0x127D974", Offset = "0x127D974", VA = "0x127D974", Slot = "11")]
	public override bool OverrideItemSlotHover(Item[] inv, int context = 0, int slot = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B24")]
	[Cpp2IlInjected.Address(RVA = "0x127DB60", Offset = "0x127DB60", VA = "0x127DB60", Slot = "12")]
	public override bool OverrideItemSlotLeftClick(Item[] inv, int context = 0, int slot = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B25")]
	[Cpp2IlInjected.Address(RVA = "0x127D460", Offset = "0x127D460", VA = "0x127D460")]
	public static bool FitsDisplayDoll(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B26")]
	[Cpp2IlInjected.Address(RVA = "0x127DF74", Offset = "0x127DF74", VA = "0x127DF74")]
	private bool TryFitting(Item[] inv, int context = 0, int slot = 0, bool justCheck = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B27")]
	[Cpp2IlInjected.Address(RVA = "0x127E3F8", Offset = "0x127E3F8", VA = "0x127E3F8")]
	public void WriteItem(int itemIndex, BinaryWriter writer, bool dye)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B28")]
	[Cpp2IlInjected.Address(RVA = "0x127E46C", Offset = "0x127E46C", VA = "0x127E46C")]
	public void ReadItem(int itemIndex, BinaryReader reader, bool dye)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B29")]
	[Cpp2IlInjected.Address(RVA = "0x127E50C", Offset = "0x127E50C", VA = "0x127E50C", Slot = "15")]
	public override bool IsTileValidForEntity(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B2A")]
	[Cpp2IlInjected.Address(RVA = "0x127E6EC", Offset = "0x127E6EC", VA = "0x127E6EC")]
	public void SetInventoryFromMannequin(int headFrame, int shirtFrame, int legFrame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B2B")]
	[Cpp2IlInjected.Address(RVA = "0x127E928", Offset = "0x127E928", VA = "0x127E928")]
	public static bool IsBreakable(int clickX, int clickY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B2C")]
	[Cpp2IlInjected.Address(RVA = "0x127EB44", Offset = "0x127EB44", VA = "0x127EB44")]
	public bool ContainsItems()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B2D")]
	[Cpp2IlInjected.Address(RVA = "0x127EBA8", Offset = "0x127EBA8", VA = "0x127EBA8", Slot = "17")]
	public void FixLoadedData()
	{
	}
}
