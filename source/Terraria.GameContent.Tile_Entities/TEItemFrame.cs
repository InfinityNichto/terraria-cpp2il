using System.IO;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities;

[Cpp2IlInjected.Token(Token = "0x200057F")]
public class TEItemFrame : TileEntity, IFixLoadedData
{
	[Cpp2IlInjected.Token(Token = "0x4006AF3")]
	private static byte _myEntityID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006AF4")]
	public Item item;

	[Cpp2IlInjected.Token(Token = "0x6003B5F")]
	[Cpp2IlInjected.Address(RVA = "0x1283AC4", Offset = "0x1283AC4", VA = "0x1283AC4", Slot = "13")]
	public override void RegisterTileEntityID(int assignedID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B60")]
	[Cpp2IlInjected.Address(RVA = "0x1283B20", Offset = "0x1283B20", VA = "0x1283B20", Slot = "14")]
	public override void NetPlaceEntityAttempt(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B61")]
	[Cpp2IlInjected.Address(RVA = "0x1283B2C", Offset = "0x1283B2C", VA = "0x1283B2C")]
	public static void NetPlaceEntity(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B62")]
	[Cpp2IlInjected.Address(RVA = "0x1283DCC", Offset = "0x1283DCC", VA = "0x1283DCC", Slot = "16")]
	public override TileEntity GenerateInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B63")]
	[Cpp2IlInjected.Address(RVA = "0x1283E2C", Offset = "0x1283E2C", VA = "0x1283E2C")]
	public TEItemFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B64")]
	[Cpp2IlInjected.Address(RVA = "0x1283C00", Offset = "0x1283C00", VA = "0x1283C00")]
	public static int Place(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B65")]
	[Cpp2IlInjected.Address(RVA = "0x1283ECC", Offset = "0x1283ECC", VA = "0x1283ECC", Slot = "15")]
	public override bool IsTileValidForEntity(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B66")]
	[Cpp2IlInjected.Address(RVA = "0x12840B8", Offset = "0x12840B8", VA = "0x12840B8")]
	public static int Hook_AfterPlacement(int x, int y, int type = 395, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B67")]
	[Cpp2IlInjected.Address(RVA = "0x12842E4", Offset = "0x12842E4", VA = "0x12842E4")]
	public static void Kill(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B68")]
	[Cpp2IlInjected.Address(RVA = "0x12844E4", Offset = "0x12844E4", VA = "0x12844E4")]
	public static int Find(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B69")]
	[Cpp2IlInjected.Address(RVA = "0x1283ED8", Offset = "0x1283ED8", VA = "0x1283ED8")]
	public static bool ValidTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B6A")]
	[Cpp2IlInjected.Address(RVA = "0x12845DC", Offset = "0x12845DC", VA = "0x12845DC", Slot = "5")]
	public override void WriteExtraData(BinaryWriter writer, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B6B")]
	[Cpp2IlInjected.Address(RVA = "0x1284648", Offset = "0x1284648", VA = "0x1284648", Slot = "6")]
	public override void ReadExtraData(BinaryReader reader, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B6C")]
	[Cpp2IlInjected.Address(RVA = "0x128471C", Offset = "0x128471C", VA = "0x128471C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B6D")]
	[Cpp2IlInjected.Address(RVA = "0x12848E0", Offset = "0x12848E0", VA = "0x12848E0")]
	public void DropItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B6E")]
	[Cpp2IlInjected.Address(RVA = "0x1284A44", Offset = "0x1284A44", VA = "0x1284A44")]
	public static void TryPlacing(int x, int y, int netid, int prefix, int stack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B6F")]
	[Cpp2IlInjected.Address(RVA = "0x1284DEC", Offset = "0x1284DEC", VA = "0x1284DEC")]
	public static void OnPlayerInteraction(Player player, int clickX, int clickY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B70")]
	[Cpp2IlInjected.Address(RVA = "0x12851BC", Offset = "0x12851BC", VA = "0x12851BC")]
	public static bool FitsItemFrame(Item i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B71")]
	[Cpp2IlInjected.Address(RVA = "0x12851D0", Offset = "0x12851D0", VA = "0x12851D0")]
	public static void PlaceItemInFrame(Player player, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B72")]
	[Cpp2IlInjected.Address(RVA = "0x1285748", Offset = "0x1285748", VA = "0x1285748", Slot = "17")]
	public void FixLoadedData()
	{
	}
}
