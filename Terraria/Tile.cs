using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200034B")]
public struct Tile
{
	[Cpp2IlInjected.Token(Token = "0x4002F65")]
	public static Tile s_Null;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002F66")]
	private int _tileOffset;

	[Cpp2IlInjected.Token(Token = "0x4002F67")]
	public static ushort CurrentSearchUID;

	[Cpp2IlInjected.Token(Token = "0x4002F68")]
	public static ushort MaxSearchUID;

	[Cpp2IlInjected.Token(Token = "0x4002F69")]
	public const int Type_Solid = 0;

	[Cpp2IlInjected.Token(Token = "0x4002F6A")]
	public const int Type_Halfbrick = 1;

	[Cpp2IlInjected.Token(Token = "0x4002F6B")]
	public const int Type_SlopeDownRight = 2;

	[Cpp2IlInjected.Token(Token = "0x4002F6C")]
	public const int Type_SlopeDownLeft = 3;

	[Cpp2IlInjected.Token(Token = "0x4002F6D")]
	public const int Type_SlopeUpRight = 4;

	[Cpp2IlInjected.Token(Token = "0x4002F6E")]
	public const int Type_SlopeUpLeft = 5;

	[Cpp2IlInjected.Token(Token = "0x4002F6F")]
	public const int Liquid_Water = 0;

	[Cpp2IlInjected.Token(Token = "0x4002F70")]
	public const int Liquid_Lava = 1;

	[Cpp2IlInjected.Token(Token = "0x4002F71")]
	public const int Liquid_Honey = 2;

	[Cpp2IlInjected.Token(Token = "0x4002F72")]
	public const int Liquid_Shimmer = 3;

	[Cpp2IlInjected.Token(Token = "0x17000581")]
	public bool IsLoaded
	{
		[Cpp2IlInjected.Token(Token = "0x60027C1")]
		[Cpp2IlInjected.Address(RVA = "0x39FCE0", Offset = "0x39FCE0", VA = "0x39FCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000582")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3993D8", Offset = "0x3993D8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3993D8", Offset = "0x3993D8")]
	public ushort type
	{
		[Cpp2IlInjected.Token(Token = "0x60027C3")]
		[Cpp2IlInjected.Address(RVA = "0x39FCF0", Offset = "0x39FCF0", VA = "0x39FCF0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60027C4")]
		[Cpp2IlInjected.Address(RVA = "0x39FCF8", Offset = "0x39FCF8", VA = "0x39FCF8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000583")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39948C", Offset = "0x39948C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39948C", Offset = "0x39948C")]
	public ushort wall
	{
		[Cpp2IlInjected.Token(Token = "0x60027C6")]
		[Cpp2IlInjected.Address(RVA = "0x39FD08", Offset = "0x39FD08", VA = "0x39FD08")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60027C7")]
		[Cpp2IlInjected.Address(RVA = "0x39FD10", Offset = "0x39FD10", VA = "0x39FD10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000584")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x399540", Offset = "0x399540")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x399540", Offset = "0x399540")]
	public byte liquid
	{
		[Cpp2IlInjected.Token(Token = "0x60027C9")]
		[Cpp2IlInjected.Address(RVA = "0x39FD20", Offset = "0x39FD20", VA = "0x39FD20")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60027CA")]
		[Cpp2IlInjected.Address(RVA = "0x39FD28", Offset = "0x39FD28", VA = "0x39FD28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000585")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3995F4", Offset = "0x3995F4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3995F4", Offset = "0x3995F4")]
	public short sTileHeader
	{
		[Cpp2IlInjected.Token(Token = "0x60027CC")]
		[Cpp2IlInjected.Address(RVA = "0x39FD38", Offset = "0x39FD38", VA = "0x39FD38")]
		get
		{
			return default(short);
		}
		[Cpp2IlInjected.Token(Token = "0x60027CD")]
		[Cpp2IlInjected.Address(RVA = "0x39FD40", Offset = "0x39FD40", VA = "0x39FD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000586")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3996A8", Offset = "0x3996A8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3996A8", Offset = "0x3996A8")]
	public byte bTileHeader
	{
		[Cpp2IlInjected.Token(Token = "0x60027CF")]
		[Cpp2IlInjected.Address(RVA = "0x39FD50", Offset = "0x39FD50", VA = "0x39FD50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60027D0")]
		[Cpp2IlInjected.Address(RVA = "0x39FD58", Offset = "0x39FD58", VA = "0x39FD58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000587")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39975C", Offset = "0x39975C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39975C", Offset = "0x39975C")]
	public byte bTileHeader2
	{
		[Cpp2IlInjected.Token(Token = "0x60027D2")]
		[Cpp2IlInjected.Address(RVA = "0x39FD68", Offset = "0x39FD68", VA = "0x39FD68")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60027D3")]
		[Cpp2IlInjected.Address(RVA = "0x39FD70", Offset = "0x39FD70", VA = "0x39FD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000588")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x399810", Offset = "0x399810")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x399810", Offset = "0x399810")]
	public byte bTileHeader3
	{
		[Cpp2IlInjected.Token(Token = "0x60027D5")]
		[Cpp2IlInjected.Address(RVA = "0x39FD80", Offset = "0x39FD80", VA = "0x39FD80")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60027D6")]
		[Cpp2IlInjected.Address(RVA = "0x39FD88", Offset = "0x39FD88", VA = "0x39FD88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000589")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3998C4", Offset = "0x3998C4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3998C4", Offset = "0x3998C4")]
	public short frameX
	{
		[Cpp2IlInjected.Token(Token = "0x60027D8")]
		[Cpp2IlInjected.Address(RVA = "0x39FD98", Offset = "0x39FD98", VA = "0x39FD98")]
		get
		{
			return default(short);
		}
		[Cpp2IlInjected.Token(Token = "0x60027D9")]
		[Cpp2IlInjected.Address(RVA = "0x39FDA0", Offset = "0x39FDA0", VA = "0x39FDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700058A")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x399978", Offset = "0x399978")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x399978", Offset = "0x399978")]
	public short frameY
	{
		[Cpp2IlInjected.Token(Token = "0x60027DD")]
		[Cpp2IlInjected.Address(RVA = "0x39FDC0", Offset = "0x39FDC0", VA = "0x39FDC0")]
		get
		{
			return default(short);
		}
		[Cpp2IlInjected.Token(Token = "0x60027DE")]
		[Cpp2IlInjected.Address(RVA = "0x39FDC8", Offset = "0x39FDC8", VA = "0x39FDC8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700058B")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x399A2C", Offset = "0x399A2C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x399A2C", Offset = "0x399A2C")]
	public ushort TileSeachUID
	{
		[Cpp2IlInjected.Token(Token = "0x60027E2")]
		[Cpp2IlInjected.Address(RVA = "0x39FDE8", Offset = "0x39FDE8", VA = "0x39FDE8")]
		get
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700058C")]
	public int collisionType
	{
		[Cpp2IlInjected.Token(Token = "0x60027E9")]
		[Cpp2IlInjected.Address(RVA = "0x39FE7C", Offset = "0x39FE7C", VA = "0x39FE7C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60027BE")]
	[Cpp2IlInjected.Address(RVA = "0x14E94B0", Offset = "0x14E94B0", VA = "0x14E94B0")]
	public static bool operator ==(Tile a, Tile b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027BF")]
	[Cpp2IlInjected.Address(RVA = "0x14E94C0", Offset = "0x14E94C0", VA = "0x14E94C0")]
	public static bool operator !=(Tile a, Tile b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027C0")]
	[Cpp2IlInjected.Address(RVA = "0x39FCD8", Offset = "0x39FCD8", VA = "0x39FCD8")]
	public Tile(int tileOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027C2")]
	[Cpp2IlInjected.Address(RVA = "0x39FCE8", Offset = "0x39FCE8", VA = "0x39FCE8")]
	public void ReregisterTile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027C5")]
	[Cpp2IlInjected.Address(RVA = "0x39FD00", Offset = "0x39FD00", VA = "0x39FD00")]
	public void SetType(ushort type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027C8")]
	[Cpp2IlInjected.Address(RVA = "0x39FD18", Offset = "0x39FD18", VA = "0x39FD18")]
	public void SetWall(ushort wall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027CB")]
	[Cpp2IlInjected.Address(RVA = "0x39FD30", Offset = "0x39FD30", VA = "0x39FD30")]
	public void SetLiquid(byte liquid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027CE")]
	[Cpp2IlInjected.Address(RVA = "0x39FD48", Offset = "0x39FD48", VA = "0x39FD48")]
	public void SetSTileHeader(short value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027D1")]
	[Cpp2IlInjected.Address(RVA = "0x39FD60", Offset = "0x39FD60", VA = "0x39FD60")]
	public void SetBTileHeader(byte value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027D4")]
	[Cpp2IlInjected.Address(RVA = "0x39FD78", Offset = "0x39FD78", VA = "0x39FD78")]
	public void SetBTileHeader2(byte value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027D7")]
	[Cpp2IlInjected.Address(RVA = "0x39FD90", Offset = "0x39FD90", VA = "0x39FD90")]
	public void SetBTileHeader3(byte value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027DA")]
	[Cpp2IlInjected.Address(RVA = "0x39FDA8", Offset = "0x39FDA8", VA = "0x39FDA8")]
	public void SetFrameX(short value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027DB")]
	[Cpp2IlInjected.Address(RVA = "0x39FDB0", Offset = "0x39FDB0", VA = "0x39FDB0")]
	public void SetFrameXY(short xValue, short yValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027DC")]
	[Cpp2IlInjected.Address(RVA = "0x39FDB8", Offset = "0x39FDB8", VA = "0x39FDB8")]
	public void OffsetFrameX(short value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027DF")]
	[Cpp2IlInjected.Address(RVA = "0x39FDD0", Offset = "0x39FDD0", VA = "0x39FDD0")]
	public void SetFrameY(short value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027E0")]
	[Cpp2IlInjected.Address(RVA = "0x39FDD8", Offset = "0x39FDD8", VA = "0x39FDD8")]
	public void OffsetFrameY(short value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027E1")]
	[Cpp2IlInjected.Address(RVA = "0x39FDE0", Offset = "0x39FDE0", VA = "0x39FDE0")]
	public void BitWiseOrFrameY(short value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027E3")]
	[Cpp2IlInjected.Address(RVA = "0x39FDF0", Offset = "0x39FDF0", VA = "0x39FDF0")]
	public void SetTileSeachUID(ushort value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027E4")]
	[Cpp2IlInjected.Address(RVA = "0x14EB7DC", Offset = "0x14EB7DC", VA = "0x14EB7DC")]
	public static void StartNewSearch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027E5")]
	[Cpp2IlInjected.Address(RVA = "0x39FDF8", Offset = "0x39FDF8", VA = "0x39FDF8")]
	public void ClearEverything()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027E6")]
	[Cpp2IlInjected.Address(RVA = "0x39FE00", Offset = "0x39FE00", VA = "0x39FE00")]
	public void SetEverything(ushort tileType, short tileSHeader, short frameX, short frameY, byte tileBHeader, byte tileBHeader2, byte tileBHeader3, byte wall, byte liquid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027E7")]
	[Cpp2IlInjected.Address(RVA = "0x39FE48", Offset = "0x39FE48", VA = "0x39FE48")]
	public void ClearTile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027E8")]
	[Cpp2IlInjected.Address(RVA = "0x39FE74", Offset = "0x39FE74", VA = "0x39FE74")]
	public void CopyFrom(Tile from)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027EA")]
	[Cpp2IlInjected.Address(RVA = "0x39FE84", Offset = "0x39FE84", VA = "0x39FE84")]
	public bool isTheSameAs(Tile compTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027EB")]
	[Cpp2IlInjected.Address(RVA = "0x39FE8C", Offset = "0x39FE8C", VA = "0x39FE8C")]
	public int wallFrameX()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60027EC")]
	[Cpp2IlInjected.Address(RVA = "0x39FEAC", Offset = "0x39FEAC", VA = "0x39FEAC")]
	public void wallFrameX(int wallFrameX)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027ED")]
	[Cpp2IlInjected.Address(RVA = "0x39FEEC", Offset = "0x39FEEC", VA = "0x39FEEC")]
	public int wallFrameY()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60027EE")]
	[Cpp2IlInjected.Address(RVA = "0x39FF10", Offset = "0x39FF10", VA = "0x39FF10")]
	public void wallFrameY(int wallFrameY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027EF")]
	[Cpp2IlInjected.Address(RVA = "0x39FF50", Offset = "0x39FF50", VA = "0x39FF50")]
	public bool invisibleBlock()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027F0")]
	[Cpp2IlInjected.Address(RVA = "0x39FF68", Offset = "0x39FF68", VA = "0x39FF68")]
	public void invisibleBlock(bool invisibleBlock)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027F1")]
	[Cpp2IlInjected.Address(RVA = "0x39FF70", Offset = "0x39FF70", VA = "0x39FF70")]
	public bool invisibleWall()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027F2")]
	[Cpp2IlInjected.Address(RVA = "0x39FF88", Offset = "0x39FF88", VA = "0x39FF88")]
	public void invisibleWall(bool invisibleWall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027F3")]
	[Cpp2IlInjected.Address(RVA = "0x39FF90", Offset = "0x39FF90", VA = "0x39FF90")]
	public bool fullbrightBlock()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027F4")]
	[Cpp2IlInjected.Address(RVA = "0x39FFA8", Offset = "0x39FFA8", VA = "0x39FFA8")]
	public void fullbrightBlock(bool fullbrightBlock)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027F5")]
	[Cpp2IlInjected.Address(RVA = "0x39FFB0", Offset = "0x39FFB0", VA = "0x39FFB0")]
	public bool fullbrightWall()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027F6")]
	[Cpp2IlInjected.Address(RVA = "0x39FFD4", Offset = "0x39FFD4", VA = "0x39FFD4")]
	public void fullbrightWall(bool fullbrightWall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027F7")]
	[Cpp2IlInjected.Address(RVA = "0x39FFDC", Offset = "0x39FFDC", VA = "0x39FFDC")]
	public byte frameNumber()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60027F8")]
	[Cpp2IlInjected.Address(RVA = "0x39FFF4", Offset = "0x39FFF4", VA = "0x39FFF4")]
	public void frameNumber(byte frameNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A0024", Offset = "0x3A0024", VA = "0x3A0024")]
	public byte wallFrameNumber()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60027FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A003C", Offset = "0x3A003C", VA = "0x3A003C")]
	public void wallFrameNumber(byte wallFrameNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A006C", Offset = "0x3A006C", VA = "0x3A006C")]
	public bool topSlope()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A0098", Offset = "0x3A0098", VA = "0x3A0098")]
	public bool bottomSlope()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A00C4", Offset = "0x3A00C4", VA = "0x3A00C4")]
	public bool leftSlope()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A00F8", Offset = "0x3A00F8", VA = "0x3A00F8")]
	public bool rightSlope()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60027FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A0124", Offset = "0x3A0124", VA = "0x3A0124")]
	public byte slope()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002800")]
	[Cpp2IlInjected.Address(RVA = "0x3A013C", Offset = "0x3A013C", VA = "0x3A013C")]
	public bool HasSameSlope(Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002801")]
	[Cpp2IlInjected.Address(RVA = "0x3A0178", Offset = "0x3A0178", VA = "0x3A0178")]
	public void slope(byte slope)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002802")]
	[Cpp2IlInjected.Address(RVA = "0x3A01A8", Offset = "0x3A01A8", VA = "0x3A01A8")]
	public int blockType()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002803")]
	[Cpp2IlInjected.Address(RVA = "0x3A01B0", Offset = "0x3A01B0", VA = "0x3A01B0")]
	public byte color()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002804")]
	[Cpp2IlInjected.Address(RVA = "0x3A01C8", Offset = "0x3A01C8", VA = "0x3A01C8")]
	public void color(byte color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002805")]
	[Cpp2IlInjected.Address(RVA = "0x3A01F4", Offset = "0x3A01F4", VA = "0x3A01F4")]
	public byte wallColor()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002806")]
	[Cpp2IlInjected.Address(RVA = "0x3A020C", Offset = "0x3A020C", VA = "0x3A020C")]
	public void wallColor(byte wallColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002807")]
	[Cpp2IlInjected.Address(RVA = "0x3A0214", Offset = "0x3A0214", VA = "0x3A0214")]
	public bool lava()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002808")]
	[Cpp2IlInjected.Address(RVA = "0x3A0238", Offset = "0x3A0238", VA = "0x3A0238")]
	public void lava(bool lava)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002809")]
	[Cpp2IlInjected.Address(RVA = "0x3A0240", Offset = "0x3A0240", VA = "0x3A0240")]
	public bool honey()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600280A")]
	[Cpp2IlInjected.Address(RVA = "0x3A0264", Offset = "0x3A0264", VA = "0x3A0264")]
	public void honey(bool honey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600280B")]
	[Cpp2IlInjected.Address(RVA = "0x3A026C", Offset = "0x3A026C", VA = "0x3A026C")]
	public bool shimmer()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600280C")]
	[Cpp2IlInjected.Address(RVA = "0x3A0290", Offset = "0x3A0290", VA = "0x3A0290")]
	public void shimmer(bool shimmer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600280D")]
	[Cpp2IlInjected.Address(RVA = "0x3A0298", Offset = "0x3A0298", VA = "0x3A0298")]
	public void liquidType(int liquidType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600280E")]
	[Cpp2IlInjected.Address(RVA = "0x3A02A0", Offset = "0x3A02A0", VA = "0x3A02A0")]
	public byte liquidType()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600280F")]
	[Cpp2IlInjected.Address(RVA = "0x3A02B8", Offset = "0x3A02B8", VA = "0x3A02B8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390EDC", Offset = "0x390EDC")]
	public bool checkingLiquid()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002810")]
	[Cpp2IlInjected.Address(RVA = "0x3A02C0", Offset = "0x3A02C0", VA = "0x3A02C0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390F64", Offset = "0x390F64")]
	public void checkingLiquid(bool checkingLiquid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002811")]
	[Cpp2IlInjected.Address(RVA = "0x3A02C8", Offset = "0x3A02C8", VA = "0x3A02C8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390FEC", Offset = "0x390FEC")]
	public bool skipLiquid()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002812")]
	[Cpp2IlInjected.Address(RVA = "0x3A02D0", Offset = "0x3A02D0", VA = "0x3A02D0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391074", Offset = "0x391074")]
	public void skipLiquid(bool skipLiquid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002813")]
	[Cpp2IlInjected.Address(RVA = "0x3A02D8", Offset = "0x3A02D8", VA = "0x3A02D8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3910FC", Offset = "0x3910FC")]
	public bool TileFramed()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002814")]
	[Cpp2IlInjected.Address(RVA = "0x3A02E0", Offset = "0x3A02E0", VA = "0x3A02E0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391184", Offset = "0x391184")]
	public void TileFramed(bool framed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002815")]
	[Cpp2IlInjected.Address(RVA = "0x3A02E8", Offset = "0x3A02E8", VA = "0x3A02E8")]
	public bool wire()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002816")]
	[Cpp2IlInjected.Address(RVA = "0x3A0300", Offset = "0x3A0300", VA = "0x3A0300")]
	public void wire(bool wire)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002817")]
	[Cpp2IlInjected.Address(RVA = "0x3A0308", Offset = "0x3A0308", VA = "0x3A0308")]
	public bool wire2()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002818")]
	[Cpp2IlInjected.Address(RVA = "0x3A0320", Offset = "0x3A0320", VA = "0x3A0320")]
	public void wire2(bool wire2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002819")]
	[Cpp2IlInjected.Address(RVA = "0x3A0328", Offset = "0x3A0328", VA = "0x3A0328")]
	public bool wire3()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600281A")]
	[Cpp2IlInjected.Address(RVA = "0x3A0340", Offset = "0x3A0340", VA = "0x3A0340")]
	public void wire3(bool wire3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600281B")]
	[Cpp2IlInjected.Address(RVA = "0x3A0348", Offset = "0x3A0348", VA = "0x3A0348")]
	public bool wire4()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600281C")]
	[Cpp2IlInjected.Address(RVA = "0x3A036C", Offset = "0x3A036C", VA = "0x3A036C")]
	public void wire4(bool wire4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600281D")]
	[Cpp2IlInjected.Address(RVA = "0x3A0374", Offset = "0x3A0374", VA = "0x3A0374")]
	public bool halfBrick()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600281E")]
	[Cpp2IlInjected.Address(RVA = "0x3A038C", Offset = "0x3A038C", VA = "0x3A038C")]
	public void halfBrick(bool halfBrick)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600281F")]
	[Cpp2IlInjected.Address(RVA = "0x3A0394", Offset = "0x3A0394", VA = "0x3A0394")]
	public bool actuator()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002820")]
	[Cpp2IlInjected.Address(RVA = "0x3A03AC", Offset = "0x3A03AC", VA = "0x3A03AC")]
	public void actuator(bool actuator)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002821")]
	[Cpp2IlInjected.Address(RVA = "0x3A03B4", Offset = "0x3A03B4", VA = "0x3A03B4")]
	public bool nactive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002822")]
	[Cpp2IlInjected.Address(RVA = "0x3A03E4", Offset = "0x3A03E4", VA = "0x3A03E4")]
	public bool inActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002823")]
	[Cpp2IlInjected.Address(RVA = "0x3A03FC", Offset = "0x3A03FC", VA = "0x3A03FC")]
	public void inActive(bool inActive)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002824")]
	[Cpp2IlInjected.Address(RVA = "0x3A0404", Offset = "0x3A0404", VA = "0x3A0404")]
	public bool active()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002825")]
	[Cpp2IlInjected.Address(RVA = "0x3A0428", Offset = "0x3A0428", VA = "0x3A0428")]
	public bool activeSafe()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002826")]
	[Cpp2IlInjected.Address(RVA = "0x3A0440", Offset = "0x3A0440", VA = "0x3A0440")]
	public void active(bool active)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002827")]
	[Cpp2IlInjected.Address(RVA = "0x3A0448", Offset = "0x3A0448", VA = "0x3A0448")]
	public void ResetToType(ushort type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002828")]
	[Cpp2IlInjected.Address(RVA = "0x3A0450", Offset = "0x3A0450", VA = "0x3A0450")]
	public Color actColor(Color oldColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002829")]
	[Cpp2IlInjected.Address(RVA = "0x3A0458", Offset = "0x3A0458", VA = "0x3A0458")]
	public void actColor(ref Vector3 oldColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600282A")]
	[Cpp2IlInjected.Address(RVA = "0x3A0460", Offset = "0x3A0460", VA = "0x3A0460")]
	public void Clear(TileDataType types)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600282B")]
	[Cpp2IlInjected.Address(RVA = "0x14EDBAC", Offset = "0x14EDBAC", VA = "0x14EDBAC")]
	public static void SmoothSlope(int x, int y, bool applyToNeighbors = true, bool sync = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600282C")]
	[Cpp2IlInjected.Address(RVA = "0x3A0468", Offset = "0x3A0468", VA = "0x3A0468")]
	public void CopyPaintAndCoating(Tile other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600282D")]
	[Cpp2IlInjected.Address(RVA = "0x3A0470", Offset = "0x3A0470", VA = "0x3A0470")]
	public TileColorCache BlockColorAndCoating()
	{
		return default(TileColorCache);
	}

	[Cpp2IlInjected.Token(Token = "0x600282E")]
	[Cpp2IlInjected.Address(RVA = "0x3A0488", Offset = "0x3A0488", VA = "0x3A0488")]
	public TileColorCache WallColorAndCoating()
	{
		return default(TileColorCache);
	}

	[Cpp2IlInjected.Token(Token = "0x600282F")]
	[Cpp2IlInjected.Address(RVA = "0x3A04A0", Offset = "0x3A04A0", VA = "0x3A04A0")]
	public void UseBlockColors(TileColorCache cache)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002830")]
	[Cpp2IlInjected.Address(RVA = "0x3A04CC", Offset = "0x3A04CC", VA = "0x3A04CC")]
	public void UseWallColors(TileColorCache cache)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002831")]
	[Cpp2IlInjected.Address(RVA = "0x3A04F8", Offset = "0x3A04F8", VA = "0x3A04F8")]
	public void ClearBlockPaintAndCoating()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002832")]
	[Cpp2IlInjected.Address(RVA = "0x3A0500", Offset = "0x3A0500", VA = "0x3A0500")]
	public void ClearWallPaintAndCoating()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002833")]
	[Cpp2IlInjected.Address(RVA = "0x3A0508", Offset = "0x3A0508", VA = "0x3A0508")]
	internal void ClearMetadata()
	{
	}
}
