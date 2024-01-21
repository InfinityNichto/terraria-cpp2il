using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities;

[Cpp2IlInjected.Token(Token = "0x2000581")]
public class TETeleportationPylon : TileEntity
{
	[Cpp2IlInjected.Token(Token = "0x4006AFE")]
	private static byte _myEntityID;

	[Cpp2IlInjected.Token(Token = "0x4006AFF")]
	private const int MyTileID = 597;

	[Cpp2IlInjected.Token(Token = "0x4006B00")]
	private const int entityTileWidth = 3;

	[Cpp2IlInjected.Token(Token = "0x4006B01")]
	private const int entityTileHeight = 4;

	[Cpp2IlInjected.Token(Token = "0x6003B8C")]
	[Cpp2IlInjected.Address(RVA = "0x12885B0", Offset = "0x12885B0", VA = "0x12885B0", Slot = "13")]
	public override void RegisterTileEntityID(int assignedID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B8D")]
	[Cpp2IlInjected.Address(RVA = "0x128860C", Offset = "0x128860C", VA = "0x128860C")]
	public TETeleportationPylon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B8E")]
	[Cpp2IlInjected.Address(RVA = "0x1288688", Offset = "0x1288688", VA = "0x1288688", Slot = "16")]
	public override TileEntity GenerateInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B8F")]
	[Cpp2IlInjected.Address(RVA = "0x12886E8", Offset = "0x12886E8", VA = "0x12886E8", Slot = "14")]
	public override void NetPlaceEntityAttempt(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B90")]
	[Cpp2IlInjected.Address(RVA = "0x1277D80", Offset = "0x1277D80", VA = "0x1277D80")]
	public bool TryGetPylonType(out TeleportPylonType pylonType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B91")]
	[Cpp2IlInjected.Address(RVA = "0x128893C", Offset = "0x128893C", VA = "0x128893C")]
	private static void RejectPlacementFromNet(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B92")]
	[Cpp2IlInjected.Address(RVA = "0x1288A88", Offset = "0x1288A88", VA = "0x1288A88")]
	public static int Place(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B93")]
	[Cpp2IlInjected.Address(RVA = "0x1288C90", Offset = "0x1288C90", VA = "0x1288C90")]
	public static void Kill(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B94")]
	[Cpp2IlInjected.Address(RVA = "0x1288ECC", Offset = "0x1288ECC", VA = "0x1288ECC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B95")]
	[Cpp2IlInjected.Address(RVA = "0x128905C", Offset = "0x128905C", VA = "0x128905C")]
	public static void Framing_CheckTile(int callX, int callY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B96")]
	[Cpp2IlInjected.Address(RVA = "0x12895FC", Offset = "0x12895FC", VA = "0x12895FC")]
	public static int GetPylonStyleFromTile(Tile tile)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B97")]
	[Cpp2IlInjected.Address(RVA = "0x1289638", Offset = "0x1289638", VA = "0x1289638")]
	public static int GetPylonItemTypeFromTileStyle(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B98")]
	[Cpp2IlInjected.Address(RVA = "0x128965C", Offset = "0x128965C", VA = "0x128965C", Slot = "15")]
	public override bool IsTileValidForEntity(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B99")]
	[Cpp2IlInjected.Address(RVA = "0x128983C", Offset = "0x128983C", VA = "0x128983C")]
	public static int PlacementPreviewHook_AfterPlacement(int x, int y, int type = 597, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B9A")]
	[Cpp2IlInjected.Address(RVA = "0x1289A78", Offset = "0x1289A78", VA = "0x1289A78")]
	public static int PlacementPreviewHook_CheckIfCanPlace(int x, int y, int type = 597, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B9B")]
	[Cpp2IlInjected.Address(RVA = "0x1288834", Offset = "0x1288834", VA = "0x1288834")]
	private bool TryGetPylonTypeFromTileCoords(int x, int y, out TeleportPylonType pylonType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B9C")]
	[Cpp2IlInjected.Address(RVA = "0x1289AFC", Offset = "0x1289AFC", VA = "0x1289AFC")]
	private static TeleportPylonType GetPylonTypeFromPylonTileStyle(int pylonStyle)
	{
		return default(TeleportPylonType);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B9D")]
	[Cpp2IlInjected.Address(RVA = "0x1289B04", Offset = "0x1289B04", VA = "0x1289B04")]
	public static int Find(int x, int y)
	{
		return default(int);
	}
}
