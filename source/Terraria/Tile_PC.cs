using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200034F")]
public class Tile_PC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002F9B")]
	public ushort type;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4002F9C")]
	public ushort wall;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002F9D")]
	public byte liquid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4002F9E")]
	public short sTileHeader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002F9F")]
	public byte bTileHeader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4002FA0")]
	public byte bTileHeader2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4002FA1")]
	public byte bTileHeader3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002FA2")]
	public short frameX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4002FA3")]
	public short frameY;

	[Cpp2IlInjected.Token(Token = "0x4002FA4")]
	public const int Type_Solid = 0;

	[Cpp2IlInjected.Token(Token = "0x4002FA5")]
	public const int Type_Halfbrick = 1;

	[Cpp2IlInjected.Token(Token = "0x4002FA6")]
	public const int Type_SlopeDownRight = 2;

	[Cpp2IlInjected.Token(Token = "0x4002FA7")]
	public const int Type_SlopeDownLeft = 3;

	[Cpp2IlInjected.Token(Token = "0x4002FA8")]
	public const int Type_SlopeUpRight = 4;

	[Cpp2IlInjected.Token(Token = "0x4002FA9")]
	public const int Type_SlopeUpLeft = 5;

	[Cpp2IlInjected.Token(Token = "0x4002FAA")]
	public const int Liquid_Water = 0;

	[Cpp2IlInjected.Token(Token = "0x4002FAB")]
	public const int Liquid_Lava = 1;

	[Cpp2IlInjected.Token(Token = "0x4002FAC")]
	public const int Liquid_Honey = 2;

	[Cpp2IlInjected.Token(Token = "0x1700058F")]
	public int collisionType
	{
		[Cpp2IlInjected.Token(Token = "0x600286F")]
		[Cpp2IlInjected.Address(RVA = "0x14B09D0", Offset = "0x14B09D0", VA = "0x14B09D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002869")]
	[Cpp2IlInjected.Address(RVA = "0x14B07C0", Offset = "0x14B07C0", VA = "0x14B07C0")]
	public Tile_PC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600286A")]
	[Cpp2IlInjected.Address(RVA = "0x14B07F0", Offset = "0x14B07F0", VA = "0x14B07F0")]
	public Tile_PC(Tile_PC copy)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600286B")]
	[Cpp2IlInjected.Address(RVA = "0x14B0878", Offset = "0x14B0878", VA = "0x14B0878")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600286C")]
	[Cpp2IlInjected.Address(RVA = "0x14B0880", Offset = "0x14B0880", VA = "0x14B0880")]
	public void ClearEverything()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600286D")]
	[Cpp2IlInjected.Address(RVA = "0x14B089C", Offset = "0x14B089C", VA = "0x14B089C")]
	public void ClearTile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600286E")]
	[Cpp2IlInjected.Address(RVA = "0x14B0920", Offset = "0x14B0920", VA = "0x14B0920")]
	public void CopyFrom(Tile from)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002870")]
	[Cpp2IlInjected.Address(RVA = "0x14B0AF8", Offset = "0x14B0AF8", VA = "0x14B0AF8")]
	public bool isTheSameAs(Tile compTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002871")]
	[Cpp2IlInjected.Address(RVA = "0x14B0CF8", Offset = "0x14B0CF8", VA = "0x14B0CF8")]
	public int blockType()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002872")]
	[Cpp2IlInjected.Address(RVA = "0x14B0D18", Offset = "0x14B0D18", VA = "0x14B0D18")]
	public void liquidType(int liquidType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002873")]
	[Cpp2IlInjected.Address(RVA = "0x14B0D98", Offset = "0x14B0D98", VA = "0x14B0D98")]
	public byte liquidType()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002874")]
	[Cpp2IlInjected.Address(RVA = "0x14B0DA4", Offset = "0x14B0DA4", VA = "0x14B0DA4")]
	public bool nactive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002875")]
	[Cpp2IlInjected.Address(RVA = "0x14B0DBC", Offset = "0x14B0DBC", VA = "0x14B0DBC")]
	public void ResetToType(ushort type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002876")]
	[Cpp2IlInjected.Address(RVA = "0x14B0DDC", Offset = "0x14B0DDC", VA = "0x14B0DDC")]
	internal void ClearMetadata()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002877")]
	[Cpp2IlInjected.Address(RVA = "0x14B0DF8", Offset = "0x14B0DF8", VA = "0x14B0DF8")]
	public Color actColor(Color oldColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002878")]
	[Cpp2IlInjected.Address(RVA = "0x14B0EA4", Offset = "0x14B0EA4", VA = "0x14B0EA4")]
	public void actColor(ref Vector3 oldColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002879")]
	[Cpp2IlInjected.Address(RVA = "0x14B0F68", Offset = "0x14B0F68", VA = "0x14B0F68")]
	public bool topSlope()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600287A")]
	[Cpp2IlInjected.Address(RVA = "0x14B0F88", Offset = "0x14B0F88", VA = "0x14B0F88")]
	public bool bottomSlope()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600287B")]
	[Cpp2IlInjected.Address(RVA = "0x14B0FA8", Offset = "0x14B0FA8", VA = "0x14B0FA8")]
	public bool leftSlope()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600287C")]
	[Cpp2IlInjected.Address(RVA = "0x14B0FD0", Offset = "0x14B0FD0", VA = "0x14B0FD0")]
	public bool rightSlope()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600287D")]
	[Cpp2IlInjected.Address(RVA = "0x14B0FF0", Offset = "0x14B0FF0", VA = "0x14B0FF0")]
	public bool HasSameSlope(Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600287E")]
	[Cpp2IlInjected.Address(RVA = "0x14B0CD8", Offset = "0x14B0CD8", VA = "0x14B0CD8")]
	public byte wallColor()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600287F")]
	[Cpp2IlInjected.Address(RVA = "0x14B1028", Offset = "0x14B1028", VA = "0x14B1028")]
	public void wallColor(byte wallColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002880")]
	[Cpp2IlInjected.Address(RVA = "0x14B103C", Offset = "0x14B103C", VA = "0x14B103C")]
	public bool lava()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002881")]
	[Cpp2IlInjected.Address(RVA = "0x14B0D60", Offset = "0x14B0D60", VA = "0x14B0D60")]
	public void lava(bool lava)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002882")]
	[Cpp2IlInjected.Address(RVA = "0x14B1048", Offset = "0x14B1048", VA = "0x14B1048")]
	public bool honey()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002883")]
	[Cpp2IlInjected.Address(RVA = "0x14B0D7C", Offset = "0x14B0D7C", VA = "0x14B0D7C")]
	public void honey(bool honey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002884")]
	[Cpp2IlInjected.Address(RVA = "0x14B0CE4", Offset = "0x14B0CE4", VA = "0x14B0CE4")]
	public bool wire4()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002885")]
	[Cpp2IlInjected.Address(RVA = "0x14B1054", Offset = "0x14B1054", VA = "0x14B1054")]
	public void wire4(bool wire4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002886")]
	[Cpp2IlInjected.Address(RVA = "0x14B106C", Offset = "0x14B106C", VA = "0x14B106C")]
	public int wallFrameX()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002887")]
	[Cpp2IlInjected.Address(RVA = "0x14B1080", Offset = "0x14B1080", VA = "0x14B1080")]
	public void wallFrameX(int wallFrameX)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002888")]
	[Cpp2IlInjected.Address(RVA = "0x14B10AC", Offset = "0x14B10AC", VA = "0x14B10AC")]
	public byte frameNumber()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002889")]
	[Cpp2IlInjected.Address(RVA = "0x14B10B8", Offset = "0x14B10B8", VA = "0x14B10B8")]
	public void frameNumber(byte frameNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600288A")]
	[Cpp2IlInjected.Address(RVA = "0x14B10D0", Offset = "0x14B10D0", VA = "0x14B10D0")]
	public byte wallFrameNumber()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600288B")]
	[Cpp2IlInjected.Address(RVA = "0x14B10DC", Offset = "0x14B10DC", VA = "0x14B10DC")]
	public void wallFrameNumber(byte wallFrameNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600288C")]
	[Cpp2IlInjected.Address(RVA = "0x14B10F0", Offset = "0x14B10F0", VA = "0x14B10F0")]
	public int wallFrameY()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600288D")]
	[Cpp2IlInjected.Address(RVA = "0x14B1108", Offset = "0x14B1108", VA = "0x14B1108")]
	public void wallFrameY(int wallFrameY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600288E")]
	[Cpp2IlInjected.Address(RVA = "0x14B1134", Offset = "0x14B1134", VA = "0x14B1134")]
	public bool checkingLiquid()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600288F")]
	[Cpp2IlInjected.Address(RVA = "0x14B1140", Offset = "0x14B1140", VA = "0x14B1140")]
	public void checkingLiquid(bool checkingLiquid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002890")]
	[Cpp2IlInjected.Address(RVA = "0x14B1158", Offset = "0x14B1158", VA = "0x14B1158")]
	public bool skipLiquid()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002891")]
	[Cpp2IlInjected.Address(RVA = "0x14B1164", Offset = "0x14B1164", VA = "0x14B1164")]
	public void skipLiquid(bool skipLiquid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002892")]
	[Cpp2IlInjected.Address(RVA = "0x14B117C", Offset = "0x14B117C", VA = "0x14B117C")]
	public byte color()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002893")]
	[Cpp2IlInjected.Address(RVA = "0x14B1188", Offset = "0x14B1188", VA = "0x14B1188")]
	public void color(byte color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002894")]
	[Cpp2IlInjected.Address(RVA = "0x14B0AD4", Offset = "0x14B0AD4", VA = "0x14B0AD4")]
	public bool active()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002895")]
	[Cpp2IlInjected.Address(RVA = "0x14B08E8", Offset = "0x14B08E8", VA = "0x14B08E8")]
	public void active(bool active)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002896")]
	[Cpp2IlInjected.Address(RVA = "0x14B0E98", Offset = "0x14B0E98", VA = "0x14B0E98")]
	public bool inActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002897")]
	[Cpp2IlInjected.Address(RVA = "0x14B0904", Offset = "0x14B0904", VA = "0x14B0904")]
	public void inActive(bool inActive)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002898")]
	[Cpp2IlInjected.Address(RVA = "0x14B11A0", Offset = "0x14B11A0", VA = "0x14B11A0")]
	public bool wire()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002899")]
	[Cpp2IlInjected.Address(RVA = "0x14B11AC", Offset = "0x14B11AC", VA = "0x14B11AC")]
	public void wire(bool wire)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600289A")]
	[Cpp2IlInjected.Address(RVA = "0x14B11C8", Offset = "0x14B11C8", VA = "0x14B11C8")]
	public bool wire2()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600289B")]
	[Cpp2IlInjected.Address(RVA = "0x14B11D4", Offset = "0x14B11D4", VA = "0x14B11D4")]
	public void wire2(bool wire2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600289C")]
	[Cpp2IlInjected.Address(RVA = "0x14B11F0", Offset = "0x14B11F0", VA = "0x14B11F0")]
	public bool wire3()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600289D")]
	[Cpp2IlInjected.Address(RVA = "0x14B11FC", Offset = "0x14B11FC", VA = "0x14B11FC")]
	public void wire3(bool wire3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600289E")]
	[Cpp2IlInjected.Address(RVA = "0x14B0AE0", Offset = "0x14B0AE0", VA = "0x14B0AE0")]
	public bool halfBrick()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600289F")]
	[Cpp2IlInjected.Address(RVA = "0x14B08CC", Offset = "0x14B08CC", VA = "0x14B08CC")]
	public void halfBrick(bool halfBrick)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028A0")]
	[Cpp2IlInjected.Address(RVA = "0x14B1218", Offset = "0x14B1218", VA = "0x14B1218")]
	public bool actuator()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60028A1")]
	[Cpp2IlInjected.Address(RVA = "0x14B1224", Offset = "0x14B1224", VA = "0x14B1224")]
	public void actuator(bool actuator)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028A2")]
	[Cpp2IlInjected.Address(RVA = "0x14B0AEC", Offset = "0x14B0AEC", VA = "0x14B0AEC")]
	public byte slope()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60028A3")]
	[Cpp2IlInjected.Address(RVA = "0x14B08B0", Offset = "0x14B08B0", VA = "0x14B08B0")]
	public void slope(byte slope)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028A4")]
	[Cpp2IlInjected.Address(RVA = "0x14B1240", Offset = "0x14B1240", VA = "0x14B1240")]
	public void Clear(TileDataType types)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028A5")]
	[Cpp2IlInjected.Address(RVA = "0x14B1328", Offset = "0x14B1328", VA = "0x14B1328")]
	public static void SmoothSlope(int x, int y, bool applyToNeighbors = true, bool sync = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028A6")]
	[Cpp2IlInjected.Address(RVA = "0x14B1824", Offset = "0x14B1824", VA = "0x14B1824", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
