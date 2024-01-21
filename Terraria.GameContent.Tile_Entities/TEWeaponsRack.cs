using System.IO;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities;

[Cpp2IlInjected.Token(Token = "0x2000583")]
public class TEWeaponsRack : TileEntity, IFixLoadedData
{
	[Cpp2IlInjected.Token(Token = "0x4006B06")]
	private static byte _myEntityID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006B07")]
	public Item item;

	[Cpp2IlInjected.Token(Token = "0x4006B08")]
	private const int MyTileID = 471;

	[Cpp2IlInjected.Token(Token = "0x6003BB2")]
	[Cpp2IlInjected.Address(RVA = "0x128B584", Offset = "0x128B584", VA = "0x128B584")]
	public TEWeaponsRack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BB3")]
	[Cpp2IlInjected.Address(RVA = "0x128B624", Offset = "0x128B624", VA = "0x128B624", Slot = "13")]
	public override void RegisterTileEntityID(int assignedID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BB4")]
	[Cpp2IlInjected.Address(RVA = "0x128B680", Offset = "0x128B680", VA = "0x128B680", Slot = "16")]
	public override TileEntity GenerateInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003BB5")]
	[Cpp2IlInjected.Address(RVA = "0x128B6E0", Offset = "0x128B6E0", VA = "0x128B6E0", Slot = "14")]
	public override void NetPlaceEntityAttempt(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BB6")]
	[Cpp2IlInjected.Address(RVA = "0x128B6EC", Offset = "0x128B6EC", VA = "0x128B6EC")]
	public static void NetPlaceEntity(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BB7")]
	[Cpp2IlInjected.Address(RVA = "0x128B98C", Offset = "0x128B98C", VA = "0x128B98C", Slot = "15")]
	public override bool IsTileValidForEntity(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BB8")]
	[Cpp2IlInjected.Address(RVA = "0x128B998", Offset = "0x128B998", VA = "0x128B998")]
	public static bool ValidTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BB9")]
	[Cpp2IlInjected.Address(RVA = "0x128B7C0", Offset = "0x128B7C0", VA = "0x128B7C0")]
	public static int Place(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BBA")]
	[Cpp2IlInjected.Address(RVA = "0x128BB78", Offset = "0x128BB78", VA = "0x128BB78")]
	public static int Hook_AfterPlacement(int x, int y, int type = 471, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BBB")]
	[Cpp2IlInjected.Address(RVA = "0x128BDA4", Offset = "0x128BDA4", VA = "0x128BDA4")]
	public static void Kill(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BBC")]
	[Cpp2IlInjected.Address(RVA = "0x128BFA4", Offset = "0x128BFA4", VA = "0x128BFA4")]
	public static int Find(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BBD")]
	[Cpp2IlInjected.Address(RVA = "0x128C09C", Offset = "0x128C09C", VA = "0x128C09C", Slot = "5")]
	public override void WriteExtraData(BinaryWriter writer, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BBE")]
	[Cpp2IlInjected.Address(RVA = "0x128C108", Offset = "0x128C108", VA = "0x128C108", Slot = "6")]
	public override void ReadExtraData(BinaryReader reader, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BBF")]
	[Cpp2IlInjected.Address(RVA = "0x128C1DC", Offset = "0x128C1DC", VA = "0x128C1DC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003BC0")]
	[Cpp2IlInjected.Address(RVA = "0x128C3A0", Offset = "0x128C3A0", VA = "0x128C3A0")]
	public static void Framing_CheckTile(int callX, int callY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BC1")]
	[Cpp2IlInjected.Address(RVA = "0x128CA6C", Offset = "0x128CA6C", VA = "0x128CA6C")]
	public void DropItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BC2")]
	[Cpp2IlInjected.Address(RVA = "0x128CBD0", Offset = "0x128CBD0", VA = "0x128CBD0")]
	public static void TryPlacing(int x, int y, int netid, int prefix, int stack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BC3")]
	[Cpp2IlInjected.Address(RVA = "0x128CF78", Offset = "0x128CF78", VA = "0x128CF78")]
	public static void OnPlayerInteraction(Player player, int clickX, int clickY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BC4")]
	[Cpp2IlInjected.Address(RVA = "0x128D354", Offset = "0x128D354", VA = "0x128D354")]
	public static bool FitsWeaponFrame(Item i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BC5")]
	[Cpp2IlInjected.Address(RVA = "0x128D444", Offset = "0x128D444", VA = "0x128D444")]
	private static void PlaceItemInFrame(Player player, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BC6")]
	[Cpp2IlInjected.Address(RVA = "0x128D9E4", Offset = "0x128D9E4", VA = "0x128D9E4", Slot = "17")]
	public void FixLoadedData()
	{
	}
}
