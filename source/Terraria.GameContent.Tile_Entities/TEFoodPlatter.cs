using System.IO;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities;

[Cpp2IlInjected.Token(Token = "0x200057C")]
public class TEFoodPlatter : TileEntity, IFixLoadedData
{
	[Cpp2IlInjected.Token(Token = "0x4006AE6")]
	private static byte _myEntityID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006AE7")]
	public Item item;

	[Cpp2IlInjected.Token(Token = "0x6003B2F")]
	[Cpp2IlInjected.Address(RVA = "0x127EC7C", Offset = "0x127EC7C", VA = "0x127EC7C", Slot = "13")]
	public override void RegisterTileEntityID(int assignedID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B30")]
	[Cpp2IlInjected.Address(RVA = "0x127ECD8", Offset = "0x127ECD8", VA = "0x127ECD8", Slot = "14")]
	public override void NetPlaceEntityAttempt(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B31")]
	[Cpp2IlInjected.Address(RVA = "0x127ECE4", Offset = "0x127ECE4", VA = "0x127ECE4")]
	public static void NetPlaceEntity(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B32")]
	[Cpp2IlInjected.Address(RVA = "0x127EF84", Offset = "0x127EF84", VA = "0x127EF84", Slot = "16")]
	public override TileEntity GenerateInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B33")]
	[Cpp2IlInjected.Address(RVA = "0x127EFE4", Offset = "0x127EFE4", VA = "0x127EFE4")]
	public TEFoodPlatter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B34")]
	[Cpp2IlInjected.Address(RVA = "0x127EDB8", Offset = "0x127EDB8", VA = "0x127EDB8")]
	public static int Place(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B35")]
	[Cpp2IlInjected.Address(RVA = "0x127F084", Offset = "0x127F084", VA = "0x127F084", Slot = "15")]
	public override bool IsTileValidForEntity(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B36")]
	[Cpp2IlInjected.Address(RVA = "0x127F1F8", Offset = "0x127F1F8", VA = "0x127F1F8")]
	public static int Hook_AfterPlacement(int x, int y, int type = 520, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B37")]
	[Cpp2IlInjected.Address(RVA = "0x127F414", Offset = "0x127F414", VA = "0x127F414")]
	public static void Kill(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B38")]
	[Cpp2IlInjected.Address(RVA = "0x127F614", Offset = "0x127F614", VA = "0x127F614")]
	public static int Find(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B39")]
	[Cpp2IlInjected.Address(RVA = "0x127F090", Offset = "0x127F090", VA = "0x127F090")]
	public static bool ValidTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B3A")]
	[Cpp2IlInjected.Address(RVA = "0x127F70C", Offset = "0x127F70C", VA = "0x127F70C", Slot = "5")]
	public override void WriteExtraData(BinaryWriter writer, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B3B")]
	[Cpp2IlInjected.Address(RVA = "0x127F778", Offset = "0x127F778", VA = "0x127F778", Slot = "6")]
	public override void ReadExtraData(BinaryReader reader, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B3C")]
	[Cpp2IlInjected.Address(RVA = "0x127F84C", Offset = "0x127F84C", VA = "0x127F84C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B3D")]
	[Cpp2IlInjected.Address(RVA = "0x127FA10", Offset = "0x127FA10", VA = "0x127FA10")]
	public void DropItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B3E")]
	[Cpp2IlInjected.Address(RVA = "0x127FB74", Offset = "0x127FB74", VA = "0x127FB74")]
	public static void TryPlacing(int x, int y, int netid, int prefix, int stack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B3F")]
	[Cpp2IlInjected.Address(RVA = "0x127FF1C", Offset = "0x127FF1C", VA = "0x127FF1C")]
	public static void OnPlayerInteraction(Player player, int clickX, int clickY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B40")]
	[Cpp2IlInjected.Address(RVA = "0x1280200", Offset = "0x1280200", VA = "0x1280200")]
	public static bool FitsFoodPlatter(Item i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B41")]
	[Cpp2IlInjected.Address(RVA = "0x12802A4", Offset = "0x12802A4", VA = "0x12802A4")]
	public static void PlaceItemInFrame(Player player, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B42")]
	[Cpp2IlInjected.Address(RVA = "0x1280750", Offset = "0x1280750", VA = "0x1280750", Slot = "17")]
	public void FixLoadedData()
	{
	}
}
