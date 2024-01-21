using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities;

[Cpp2IlInjected.Token(Token = "0x200057D")]
public class TEHatRack : TileEntity, IFixLoadedData
{
	[Cpp2IlInjected.Token(Token = "0x4006AE8")]
	private static byte _myEntityID;

	[Cpp2IlInjected.Token(Token = "0x4006AE9")]
	private const int MyTileID = 475;

	[Cpp2IlInjected.Token(Token = "0x4006AEA")]
	private const int entityTileWidth = 3;

	[Cpp2IlInjected.Token(Token = "0x4006AEB")]
	private const int entityTileHeight = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006AEC")]
	private Player _dollPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006AED")]
	public Item[] _items;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006AEE")]
	public Item[] _dyes;

	[Cpp2IlInjected.Token(Token = "0x4006AEF")]
	private static int hatTargetSlot;

	[Cpp2IlInjected.Token(Token = "0x6003B43")]
	[Cpp2IlInjected.Address(RVA = "0x128075C", Offset = "0x128075C", VA = "0x128075C")]
	public TEHatRack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B44")]
	[Cpp2IlInjected.Address(RVA = "0x1280974", Offset = "0x1280974", VA = "0x1280974", Slot = "13")]
	public override void RegisterTileEntityID(int assignedID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B45")]
	[Cpp2IlInjected.Address(RVA = "0x12809D0", Offset = "0x12809D0", VA = "0x12809D0", Slot = "16")]
	public override TileEntity GenerateInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B46")]
	[Cpp2IlInjected.Address(RVA = "0x1280A30", Offset = "0x1280A30", VA = "0x1280A30", Slot = "14")]
	public override void NetPlaceEntityAttempt(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B47")]
	[Cpp2IlInjected.Address(RVA = "0x1280B04", Offset = "0x1280B04", VA = "0x1280B04")]
	public static int Place(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B48")]
	[Cpp2IlInjected.Address(RVA = "0x1280CD0", Offset = "0x1280CD0", VA = "0x1280CD0")]
	public static int Hook_AfterPlacement(int x, int y, int type = 475, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B49")]
	[Cpp2IlInjected.Address(RVA = "0x1280F0C", Offset = "0x1280F0C", VA = "0x1280F0C")]
	public static void Kill(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B4A")]
	[Cpp2IlInjected.Address(RVA = "0x128110C", Offset = "0x128110C", VA = "0x128110C")]
	public static int Find(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B4B")]
	[Cpp2IlInjected.Address(RVA = "0x1281204", Offset = "0x1281204", VA = "0x1281204", Slot = "5")]
	public override void WriteExtraData(BinaryWriter writer, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B4C")]
	[Cpp2IlInjected.Address(RVA = "0x12813CC", Offset = "0x12813CC", VA = "0x12813CC", Slot = "6")]
	public override void ReadExtraData(BinaryReader reader, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B4D")]
	[Cpp2IlInjected.Address(RVA = "0x1281600", Offset = "0x1281600", VA = "0x1281600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B4E")]
	[Cpp2IlInjected.Address(RVA = "0x1281840", Offset = "0x1281840", VA = "0x1281840")]
	public static void Framing_CheckTile(int callX, int callY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B4F")]
	[Cpp2IlInjected.Address(RVA = "0x1281D8C", Offset = "0x1281D8C", VA = "0x1281D8C")]
	public void Draw(int tileLeftX, int tileTopY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B50")]
	[Cpp2IlInjected.Address(RVA = "0x1282408", Offset = "0x1282408", VA = "0x1282408", Slot = "10")]
	public override bool TryGetItemGamepadOverrideInstructions(Item[] inv, int context, int slot, out string instruction)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B51")]
	[Cpp2IlInjected.Address(RVA = "0x12825F4", Offset = "0x12825F4", VA = "0x12825F4", Slot = "7")]
	public override void OnPlayerUpdate(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B52")]
	[Cpp2IlInjected.Address(RVA = "0x1282730", Offset = "0x1282730", VA = "0x1282730")]
	public static void OnPlayerInteraction(Player player, int clickX, int clickY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B53")]
	[Cpp2IlInjected.Address(RVA = "0x12828C4", Offset = "0x12828C4", VA = "0x12828C4")]
	private void DrawInner(Player player, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B54")]
	[Cpp2IlInjected.Address(RVA = "0x128298C", Offset = "0x128298C", VA = "0x128298C")]
	private void DrawSlotPairSet(Player player, SpriteBatch spriteBatch, int slotsToShowLine, int slotsArrayOffset, float offsetX, float offsetY, int inventoryContextTarget)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B55")]
	[Cpp2IlInjected.Address(RVA = "0x1282D64", Offset = "0x1282D64", VA = "0x1282D64", Slot = "11")]
	public override bool OverrideItemSlotHover(Item[] inv, int context = 0, int slot = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B56")]
	[Cpp2IlInjected.Address(RVA = "0x1282F00", Offset = "0x1282F00", VA = "0x1282F00", Slot = "12")]
	public override bool OverrideItemSlotLeftClick(Item[] inv, int context = 0, int slot = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B57")]
	[Cpp2IlInjected.Address(RVA = "0x12825CC", Offset = "0x12825CC", VA = "0x12825CC")]
	public static bool FitsHatRack(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B58")]
	[Cpp2IlInjected.Address(RVA = "0x128326C", Offset = "0x128326C", VA = "0x128326C")]
	private bool TryFitting(Item[] inv, int context = 0, int slot = 0, bool justCheck = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B59")]
	[Cpp2IlInjected.Address(RVA = "0x128350C", Offset = "0x128350C", VA = "0x128350C")]
	public void WriteItem(int itemIndex, BinaryWriter writer, bool dye)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B5A")]
	[Cpp2IlInjected.Address(RVA = "0x1283580", Offset = "0x1283580", VA = "0x1283580")]
	public void ReadItem(int itemIndex, BinaryReader reader, bool dye)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B5B")]
	[Cpp2IlInjected.Address(RVA = "0x1283620", Offset = "0x1283620", VA = "0x1283620", Slot = "15")]
	public override bool IsTileValidForEntity(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B5C")]
	[Cpp2IlInjected.Address(RVA = "0x1283800", Offset = "0x1283800", VA = "0x1283800")]
	public static bool IsBreakable(int clickX, int clickY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B5D")]
	[Cpp2IlInjected.Address(RVA = "0x12839E8", Offset = "0x12839E8", VA = "0x12839E8")]
	public bool ContainsItems()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B5E")]
	[Cpp2IlInjected.Address(RVA = "0x1283A4C", Offset = "0x1283A4C", VA = "0x1283A4C", Slot = "17")]
	public void FixLoadedData()
	{
	}
}
