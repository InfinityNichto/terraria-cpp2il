using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse;

[Cpp2IlInjected.Token(Token = "0x200060C")]
public class HouseBuilder
{
	[Cpp2IlInjected.Token(Token = "0x4006C16")]
	private const int VERTICAL_EXIT_WIDTH = 3;

	[Cpp2IlInjected.Token(Token = "0x4006C17")]
	public static readonly HouseBuilder Invalid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C18")]
	public readonly HouseType Type;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C19")]
	public readonly bool IsValid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4006C29")]
	protected ushort[] SkipTilesDuringWallAging;

	[Cpp2IlInjected.Token(Token = "0x1700074F")]
	public double ChestChance
	{
		[Cpp2IlInjected.Token(Token = "0x6003E20")]
		[Cpp2IlInjected.Address(RVA = "0x1108E48", Offset = "0x1108E48", VA = "0x1108E48")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E21")]
		[Cpp2IlInjected.Address(RVA = "0x1108E54", Offset = "0x1108E54", VA = "0x1108E54")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000750")]
	public ushort TileType
	{
		[Cpp2IlInjected.Token(Token = "0x6003E22")]
		[Cpp2IlInjected.Address(RVA = "0x1108E64", Offset = "0x1108E64", VA = "0x1108E64")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E23")]
		[Cpp2IlInjected.Address(RVA = "0x1108E6C", Offset = "0x1108E6C", VA = "0x1108E6C")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000751")]
	public ushort WallType
	{
		[Cpp2IlInjected.Token(Token = "0x6003E24")]
		[Cpp2IlInjected.Address(RVA = "0x1108E74", Offset = "0x1108E74", VA = "0x1108E74")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E25")]
		[Cpp2IlInjected.Address(RVA = "0x1108E7C", Offset = "0x1108E7C", VA = "0x1108E7C")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000752")]
	public ushort BeamType
	{
		[Cpp2IlInjected.Token(Token = "0x6003E26")]
		[Cpp2IlInjected.Address(RVA = "0x1108E84", Offset = "0x1108E84", VA = "0x1108E84")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E27")]
		[Cpp2IlInjected.Address(RVA = "0x1108E8C", Offset = "0x1108E8C", VA = "0x1108E8C")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000753")]
	public int PlatformStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6003E28")]
		[Cpp2IlInjected.Address(RVA = "0x1108E94", Offset = "0x1108E94", VA = "0x1108E94")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E29")]
		[Cpp2IlInjected.Address(RVA = "0x1108E9C", Offset = "0x1108E9C", VA = "0x1108E9C")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000754")]
	public int DoorStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6003E2A")]
		[Cpp2IlInjected.Address(RVA = "0x1108EA4", Offset = "0x1108EA4", VA = "0x1108EA4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E2B")]
		[Cpp2IlInjected.Address(RVA = "0x1108EAC", Offset = "0x1108EAC", VA = "0x1108EAC")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000755")]
	public int TableStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6003E2C")]
		[Cpp2IlInjected.Address(RVA = "0x1108EB4", Offset = "0x1108EB4", VA = "0x1108EB4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E2D")]
		[Cpp2IlInjected.Address(RVA = "0x1108EBC", Offset = "0x1108EBC", VA = "0x1108EBC")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000756")]
	public bool UsesTables2
	{
		[Cpp2IlInjected.Token(Token = "0x6003E2E")]
		[Cpp2IlInjected.Address(RVA = "0x1108EC4", Offset = "0x1108EC4", VA = "0x1108EC4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E2F")]
		[Cpp2IlInjected.Address(RVA = "0x1108ECC", Offset = "0x1108ECC", VA = "0x1108ECC")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000757")]
	public int WorkbenchStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6003E30")]
		[Cpp2IlInjected.Address(RVA = "0x1108ED4", Offset = "0x1108ED4", VA = "0x1108ED4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E31")]
		[Cpp2IlInjected.Address(RVA = "0x1108EDC", Offset = "0x1108EDC", VA = "0x1108EDC")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000758")]
	public int PianoStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6003E32")]
		[Cpp2IlInjected.Address(RVA = "0x1108EE4", Offset = "0x1108EE4", VA = "0x1108EE4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E33")]
		[Cpp2IlInjected.Address(RVA = "0x1108EEC", Offset = "0x1108EEC", VA = "0x1108EEC")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000759")]
	public int BookcaseStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6003E34")]
		[Cpp2IlInjected.Address(RVA = "0x1108EF4", Offset = "0x1108EF4", VA = "0x1108EF4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E35")]
		[Cpp2IlInjected.Address(RVA = "0x1108EFC", Offset = "0x1108EFC", VA = "0x1108EFC")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700075A")]
	public int ChairStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6003E36")]
		[Cpp2IlInjected.Address(RVA = "0x1108F04", Offset = "0x1108F04", VA = "0x1108F04")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E37")]
		[Cpp2IlInjected.Address(RVA = "0x1108F0C", Offset = "0x1108F0C", VA = "0x1108F0C")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700075B")]
	public int ChestStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6003E38")]
		[Cpp2IlInjected.Address(RVA = "0x1108F14", Offset = "0x1108F14", VA = "0x1108F14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E39")]
		[Cpp2IlInjected.Address(RVA = "0x1108F1C", Offset = "0x1108F1C", VA = "0x1108F1C")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700075C")]
	public bool UsesContainers2
	{
		[Cpp2IlInjected.Token(Token = "0x6003E3A")]
		[Cpp2IlInjected.Address(RVA = "0x1108F24", Offset = "0x1108F24", VA = "0x1108F24")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E3B")]
		[Cpp2IlInjected.Address(RVA = "0x1108F2C", Offset = "0x1108F2C", VA = "0x1108F2C")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700075D")]
	public ReadOnlyCollection<Rectangle> Rooms
	{
		[Cpp2IlInjected.Token(Token = "0x6003E3C")]
		[Cpp2IlInjected.Address(RVA = "0x1108F34", Offset = "0x1108F34", VA = "0x1108F34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003E3D")]
		[Cpp2IlInjected.Address(RVA = "0x1108F3C", Offset = "0x1108F3C", VA = "0x1108F3C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700075E")]
	public Rectangle TopRoom
	{
		[Cpp2IlInjected.Token(Token = "0x6003E3E")]
		[Cpp2IlInjected.Address(RVA = "0x1108F44", Offset = "0x1108F44", VA = "0x1108F44")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700075F")]
	public Rectangle BottomRoom
	{
		[Cpp2IlInjected.Token(Token = "0x6003E3F")]
		[Cpp2IlInjected.Address(RVA = "0x1108FA8", Offset = "0x1108FA8", VA = "0x1108FA8")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000760")]
	private UnifiedRandom _random
	{
		[Cpp2IlInjected.Token(Token = "0x6003E40")]
		[Cpp2IlInjected.Address(RVA = "0x110900C", Offset = "0x110900C", VA = "0x110900C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000761")]
	private TileData _tiles
	{
		[Cpp2IlInjected.Token(Token = "0x6003E41")]
		[Cpp2IlInjected.Address(RVA = "0x1109080", Offset = "0x1109080", VA = "0x1109080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003E42")]
	[Cpp2IlInjected.Address(RVA = "0x11090F8", Offset = "0x11090F8", VA = "0x11090F8")]
	private HouseBuilder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E43")]
	[Cpp2IlInjected.Address(RVA = "0x11079BC", Offset = "0x11079BC", VA = "0x11079BC")]
	protected HouseBuilder(HouseType type, IEnumerable<Rectangle> rooms)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E44")]
	[Cpp2IlInjected.Address(RVA = "0x110918C", Offset = "0x110918C", VA = "0x110918C", Slot = "4")]
	protected virtual void AgeRoom(Rectangle room)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E45")]
	[Cpp2IlInjected.Address(RVA = "0x1109190", Offset = "0x1109190", VA = "0x1109190", Slot = "5")]
	public virtual void Place(HouseBuilderContext context, StructureMap structures)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E46")]
	[Cpp2IlInjected.Address(RVA = "0x11096C0", Offset = "0x11096C0", VA = "0x11096C0")]
	private void PlaceEmptyRooms()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E47")]
	[Cpp2IlInjected.Address(RVA = "0x110B580", Offset = "0x110B580", VA = "0x110B580")]
	private void FillRooms()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E48")]
	[Cpp2IlInjected.Address(RVA = "0x1109BE0", Offset = "0x1109BE0", VA = "0x1109BE0")]
	private void PlaceStairs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E49")]
	[Cpp2IlInjected.Address(RVA = "0x110D534", Offset = "0x110D534", VA = "0x110D534")]
	private List<Tuple<Point, Point>> CreateStairsList()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E4A")]
	[Cpp2IlInjected.Address(RVA = "0x110A128", Offset = "0x110A128", VA = "0x110A128")]
	private void PlaceDoors()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E4B")]
	[Cpp2IlInjected.Address(RVA = "0x110D750", Offset = "0x110D750", VA = "0x110D750")]
	private List<Point> CreateDoorList()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E4C")]
	[Cpp2IlInjected.Address(RVA = "0x110A314", Offset = "0x110A314", VA = "0x110A314")]
	private void PlacePlatforms()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E4D")]
	[Cpp2IlInjected.Address(RVA = "0x110DCD8", Offset = "0x110DCD8", VA = "0x110DCD8")]
	private List<Point> CreatePlatformsList()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E4E")]
	[Cpp2IlInjected.Address(RVA = "0x110A5C8", Offset = "0x110A5C8", VA = "0x110A5C8")]
	private void PlaceSupportBeams()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E4F")]
	[Cpp2IlInjected.Address(RVA = "0x110E070", Offset = "0x110E070", VA = "0x110E070")]
	private List<Rectangle> CreateSupportBeamList()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E50")]
	[Cpp2IlInjected.Address(RVA = "0x110DF00", Offset = "0x110DF00", VA = "0x110DF00")]
	private static bool FindVerticalExit(Rectangle wall, bool isUp, out int exitX)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003E51")]
	[Cpp2IlInjected.Address(RVA = "0x110DB68", Offset = "0x110DB68", VA = "0x110DB68")]
	private static bool FindSideExit(Rectangle wall, bool isLeft, out int exitY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003E52")]
	[Cpp2IlInjected.Address(RVA = "0x110C04C", Offset = "0x110C04C", VA = "0x110C04C")]
	private void PlaceChests()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E53")]
	[Cpp2IlInjected.Address(RVA = "0x110A9DC", Offset = "0x110A9DC", VA = "0x110A9DC")]
	private void PlaceBiomeSpecificPriorityTool(HouseBuilderContext context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E54")]
	[Cpp2IlInjected.Address(RVA = "0x110CA80", Offset = "0x110CA80", VA = "0x110CA80")]
	private void PlaceBiomeSpecificTool(HouseBuilderContext context)
	{
	}
}
