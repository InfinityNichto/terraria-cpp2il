using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000346")]
public class SceneMetrics
{
	[Cpp2IlInjected.Token(Token = "0x4002F18")]
	public static int ShimmerTileThreshold;

	[Cpp2IlInjected.Token(Token = "0x4002F19")]
	public static int CorruptionTileThreshold;

	[Cpp2IlInjected.Token(Token = "0x4002F1A")]
	public static int CorruptionTileMax;

	[Cpp2IlInjected.Token(Token = "0x4002F1B")]
	public static int CrimsonTileThreshold;

	[Cpp2IlInjected.Token(Token = "0x4002F1C")]
	public static int CrimsonTileMax;

	[Cpp2IlInjected.Token(Token = "0x4002F1D")]
	public static int HallowTileThreshold;

	[Cpp2IlInjected.Token(Token = "0x4002F1E")]
	public static int HallowTileMax;

	[Cpp2IlInjected.Token(Token = "0x4002F1F")]
	public static int JungleTileThreshold;

	[Cpp2IlInjected.Token(Token = "0x4002F20")]
	public static int JungleTileMax;

	[Cpp2IlInjected.Token(Token = "0x4002F21")]
	public static int SnowTileThreshold;

	[Cpp2IlInjected.Token(Token = "0x4002F22")]
	public static int SnowTileMax;

	[Cpp2IlInjected.Token(Token = "0x4002F23")]
	public static int DesertTileThreshold;

	[Cpp2IlInjected.Token(Token = "0x4002F24")]
	public static int MushroomTileThreshold;

	[Cpp2IlInjected.Token(Token = "0x4002F25")]
	public static int MushroomTileMax;

	[Cpp2IlInjected.Token(Token = "0x4002F26")]
	public static int MeteorTileThreshold;

	[Cpp2IlInjected.Token(Token = "0x4002F27")]
	public static int GraveyardTileMax;

	[Cpp2IlInjected.Token(Token = "0x4002F28")]
	public static int GraveyardTileMin;

	[Cpp2IlInjected.Token(Token = "0x4002F29")]
	public static int GraveyardTileThreshold;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4002F48")]
	public bool CanPlayCreditsRoll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4002F49")]
	public bool[] NPCBannerBuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4002F4A")]
	public bool hasBanner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4002F4B")]
	private readonly int[] _tileCounts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4002F4C")]
	private readonly int[] _liquidCounts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4002F4D")]
	private readonly List<Point> _oreFinderTileLocations;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4002F4E")]
	public int bestOre;

	[Cpp2IlInjected.Token(Token = "0x17000558")]
	public Point? ClosestOrePosition
	{
		[Cpp2IlInjected.Token(Token = "0x600275B")]
		[Cpp2IlInjected.Address(RVA = "0x14DC55C", Offset = "0x14DC55C", VA = "0x14DC55C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600275C")]
		[Cpp2IlInjected.Address(RVA = "0x14DC570", Offset = "0x14DC570", VA = "0x14DC570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000559")]
	public int ShimmerTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x600275D")]
		[Cpp2IlInjected.Address(RVA = "0x14DC57C", Offset = "0x14DC57C", VA = "0x14DC57C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600275E")]
		[Cpp2IlInjected.Address(RVA = "0x14DC584", Offset = "0x14DC584", VA = "0x14DC584")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700055A")]
	public int EvilTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x600275F")]
		[Cpp2IlInjected.Address(RVA = "0x14DC58C", Offset = "0x14DC58C", VA = "0x14DC58C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002760")]
		[Cpp2IlInjected.Address(RVA = "0x14DC594", Offset = "0x14DC594", VA = "0x14DC594")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700055B")]
	public int HolyTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002761")]
		[Cpp2IlInjected.Address(RVA = "0x14DC59C", Offset = "0x14DC59C", VA = "0x14DC59C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002762")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5A4", Offset = "0x14DC5A4", VA = "0x14DC5A4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700055C")]
	public int HoneyBlockCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002763")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5AC", Offset = "0x14DC5AC", VA = "0x14DC5AC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002764")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5B4", Offset = "0x14DC5B4", VA = "0x14DC5B4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700055D")]
	public int ActiveMusicBox
	{
		[Cpp2IlInjected.Token(Token = "0x6002765")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5BC", Offset = "0x14DC5BC", VA = "0x14DC5BC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002766")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5C4", Offset = "0x14DC5C4", VA = "0x14DC5C4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700055E")]
	public int SandTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002767")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5CC", Offset = "0x14DC5CC", VA = "0x14DC5CC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002768")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5D4", Offset = "0x14DC5D4", VA = "0x14DC5D4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700055F")]
	public int MushroomTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002769")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5DC", Offset = "0x14DC5DC", VA = "0x14DC5DC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600276A")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5E4", Offset = "0x14DC5E4", VA = "0x14DC5E4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000560")]
	public int SnowTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x600276B")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5EC", Offset = "0x14DC5EC", VA = "0x14DC5EC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600276C")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5F4", Offset = "0x14DC5F4", VA = "0x14DC5F4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000561")]
	public int WaterCandleCount
	{
		[Cpp2IlInjected.Token(Token = "0x600276D")]
		[Cpp2IlInjected.Address(RVA = "0x14DC5FC", Offset = "0x14DC5FC", VA = "0x14DC5FC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600276E")]
		[Cpp2IlInjected.Address(RVA = "0x14DC604", Offset = "0x14DC604", VA = "0x14DC604")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000562")]
	public int PeaceCandleCount
	{
		[Cpp2IlInjected.Token(Token = "0x600276F")]
		[Cpp2IlInjected.Address(RVA = "0x14DC60C", Offset = "0x14DC60C", VA = "0x14DC60C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002770")]
		[Cpp2IlInjected.Address(RVA = "0x14DC614", Offset = "0x14DC614", VA = "0x14DC614")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000563")]
	public int ShadowCandleCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002771")]
		[Cpp2IlInjected.Address(RVA = "0x14DC61C", Offset = "0x14DC61C", VA = "0x14DC61C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002772")]
		[Cpp2IlInjected.Address(RVA = "0x14DC624", Offset = "0x14DC624", VA = "0x14DC624")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000564")]
	public int PartyMonolithCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002773")]
		[Cpp2IlInjected.Address(RVA = "0x14DC62C", Offset = "0x14DC62C", VA = "0x14DC62C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002774")]
		[Cpp2IlInjected.Address(RVA = "0x14DC634", Offset = "0x14DC634", VA = "0x14DC634")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000565")]
	public int MeteorTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002775")]
		[Cpp2IlInjected.Address(RVA = "0x14DC63C", Offset = "0x14DC63C", VA = "0x14DC63C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002776")]
		[Cpp2IlInjected.Address(RVA = "0x14DC644", Offset = "0x14DC644", VA = "0x14DC644")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000566")]
	public int BloodTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002777")]
		[Cpp2IlInjected.Address(RVA = "0x14DC64C", Offset = "0x14DC64C", VA = "0x14DC64C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002778")]
		[Cpp2IlInjected.Address(RVA = "0x14DC654", Offset = "0x14DC654", VA = "0x14DC654")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000567")]
	public int JungleTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002779")]
		[Cpp2IlInjected.Address(RVA = "0x14DC65C", Offset = "0x14DC65C", VA = "0x14DC65C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600277A")]
		[Cpp2IlInjected.Address(RVA = "0x14DC664", Offset = "0x14DC664", VA = "0x14DC664")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000568")]
	public int DungeonTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x600277B")]
		[Cpp2IlInjected.Address(RVA = "0x14DC66C", Offset = "0x14DC66C", VA = "0x14DC66C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600277C")]
		[Cpp2IlInjected.Address(RVA = "0x14DC674", Offset = "0x14DC674", VA = "0x14DC674")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000569")]
	public bool HasSunflower
	{
		[Cpp2IlInjected.Token(Token = "0x600277D")]
		[Cpp2IlInjected.Address(RVA = "0x14DC67C", Offset = "0x14DC67C", VA = "0x14DC67C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600277E")]
		[Cpp2IlInjected.Address(RVA = "0x14DC684", Offset = "0x14DC684", VA = "0x14DC684")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700056A")]
	public bool HasGardenGnome
	{
		[Cpp2IlInjected.Token(Token = "0x600277F")]
		[Cpp2IlInjected.Address(RVA = "0x14DC68C", Offset = "0x14DC68C", VA = "0x14DC68C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002780")]
		[Cpp2IlInjected.Address(RVA = "0x14DC694", Offset = "0x14DC694", VA = "0x14DC694")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700056B")]
	public bool HasClock
	{
		[Cpp2IlInjected.Token(Token = "0x6002781")]
		[Cpp2IlInjected.Address(RVA = "0x14DC69C", Offset = "0x14DC69C", VA = "0x14DC69C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002782")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6A4", Offset = "0x14DC6A4", VA = "0x14DC6A4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700056C")]
	public bool HasCampfire
	{
		[Cpp2IlInjected.Token(Token = "0x6002783")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6AC", Offset = "0x14DC6AC", VA = "0x14DC6AC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002784")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6B4", Offset = "0x14DC6B4", VA = "0x14DC6B4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700056D")]
	public bool HasStarInBottle
	{
		[Cpp2IlInjected.Token(Token = "0x6002785")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6BC", Offset = "0x14DC6BC", VA = "0x14DC6BC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002786")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6C4", Offset = "0x14DC6C4", VA = "0x14DC6C4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700056E")]
	public bool HasHeartLantern
	{
		[Cpp2IlInjected.Token(Token = "0x6002787")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6CC", Offset = "0x14DC6CC", VA = "0x14DC6CC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002788")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6D4", Offset = "0x14DC6D4", VA = "0x14DC6D4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700056F")]
	public int ActiveFountainColor
	{
		[Cpp2IlInjected.Token(Token = "0x6002789")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6DC", Offset = "0x14DC6DC", VA = "0x14DC6DC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600278A")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6E4", Offset = "0x14DC6E4", VA = "0x14DC6E4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000570")]
	public int ActiveMonolithType
	{
		[Cpp2IlInjected.Token(Token = "0x600278B")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6EC", Offset = "0x14DC6EC", VA = "0x14DC6EC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600278C")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6F4", Offset = "0x14DC6F4", VA = "0x14DC6F4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000571")]
	public bool BloodMoonMonolith
	{
		[Cpp2IlInjected.Token(Token = "0x600278D")]
		[Cpp2IlInjected.Address(RVA = "0x14DC6FC", Offset = "0x14DC6FC", VA = "0x14DC6FC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600278E")]
		[Cpp2IlInjected.Address(RVA = "0x14DC704", Offset = "0x14DC704", VA = "0x14DC704")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000572")]
	public bool MoonLordMonolith
	{
		[Cpp2IlInjected.Token(Token = "0x600278F")]
		[Cpp2IlInjected.Address(RVA = "0x14DC70C", Offset = "0x14DC70C", VA = "0x14DC70C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002790")]
		[Cpp2IlInjected.Address(RVA = "0x14DC714", Offset = "0x14DC714", VA = "0x14DC714")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000573")]
	public bool EchoMonolith
	{
		[Cpp2IlInjected.Token(Token = "0x6002791")]
		[Cpp2IlInjected.Address(RVA = "0x14DC71C", Offset = "0x14DC71C", VA = "0x14DC71C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002792")]
		[Cpp2IlInjected.Address(RVA = "0x14DC724", Offset = "0x14DC724", VA = "0x14DC724")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000574")]
	public int ShimmerMonolithState
	{
		[Cpp2IlInjected.Token(Token = "0x6002793")]
		[Cpp2IlInjected.Address(RVA = "0x14DC72C", Offset = "0x14DC72C", VA = "0x14DC72C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002794")]
		[Cpp2IlInjected.Address(RVA = "0x14DC734", Offset = "0x14DC734", VA = "0x14DC734")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000575")]
	public bool HasCatBast
	{
		[Cpp2IlInjected.Token(Token = "0x6002795")]
		[Cpp2IlInjected.Address(RVA = "0x14DC73C", Offset = "0x14DC73C", VA = "0x14DC73C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002796")]
		[Cpp2IlInjected.Address(RVA = "0x14DC744", Offset = "0x14DC744", VA = "0x14DC744")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000576")]
	public int GraveyardTileCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002797")]
		[Cpp2IlInjected.Address(RVA = "0x14DC74C", Offset = "0x14DC74C", VA = "0x14DC74C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002798")]
		[Cpp2IlInjected.Address(RVA = "0x14DC754", Offset = "0x14DC754", VA = "0x14DC754")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000577")]
	public bool EnoughTilesForShimmer
	{
		[Cpp2IlInjected.Token(Token = "0x6002799")]
		[Cpp2IlInjected.Address(RVA = "0x14DC75C", Offset = "0x14DC75C", VA = "0x14DC75C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000578")]
	public bool EnoughTilesForJungle
	{
		[Cpp2IlInjected.Token(Token = "0x600279A")]
		[Cpp2IlInjected.Address(RVA = "0x14DC7E8", Offset = "0x14DC7E8", VA = "0x14DC7E8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000579")]
	public bool EnoughTilesForHallow
	{
		[Cpp2IlInjected.Token(Token = "0x600279B")]
		[Cpp2IlInjected.Address(RVA = "0x14DC874", Offset = "0x14DC874", VA = "0x14DC874")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700057A")]
	public bool EnoughTilesForSnow
	{
		[Cpp2IlInjected.Token(Token = "0x600279C")]
		[Cpp2IlInjected.Address(RVA = "0x14DC900", Offset = "0x14DC900", VA = "0x14DC900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700057B")]
	public bool EnoughTilesForGlowingMushroom
	{
		[Cpp2IlInjected.Token(Token = "0x600279D")]
		[Cpp2IlInjected.Address(RVA = "0x14DC98C", Offset = "0x14DC98C", VA = "0x14DC98C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700057C")]
	public bool EnoughTilesForDesert
	{
		[Cpp2IlInjected.Token(Token = "0x600279E")]
		[Cpp2IlInjected.Address(RVA = "0x14DCA18", Offset = "0x14DCA18", VA = "0x14DCA18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700057D")]
	public bool EnoughTilesForCorruption
	{
		[Cpp2IlInjected.Token(Token = "0x600279F")]
		[Cpp2IlInjected.Address(RVA = "0x14DCAA4", Offset = "0x14DCAA4", VA = "0x14DCAA4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700057E")]
	public bool EnoughTilesForCrimson
	{
		[Cpp2IlInjected.Token(Token = "0x60027A0")]
		[Cpp2IlInjected.Address(RVA = "0x14DCB30", Offset = "0x14DCB30", VA = "0x14DCB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700057F")]
	public bool EnoughTilesForMeteor
	{
		[Cpp2IlInjected.Token(Token = "0x60027A1")]
		[Cpp2IlInjected.Address(RVA = "0x14DCBBC", Offset = "0x14DCBBC", VA = "0x14DCBBC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000580")]
	public bool EnoughTilesForGraveyard
	{
		[Cpp2IlInjected.Token(Token = "0x60027A2")]
		[Cpp2IlInjected.Address(RVA = "0x14DCC48", Offset = "0x14DCC48", VA = "0x14DCC48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60027A3")]
	[Cpp2IlInjected.Address(RVA = "0x14DCCD4", Offset = "0x14DCCD4", VA = "0x14DCCD4")]
	public SceneMetrics()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027A4")]
	[Cpp2IlInjected.Address(RVA = "0x14DCE8C", Offset = "0x14DCE8C", VA = "0x14DCE8C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390E28", Offset = "0x390E28")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390E28", Offset = "0x390E28")]
	public void ScanAndExportToMain(SceneMetricsScanSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027A5")]
	[Cpp2IlInjected.Address(RVA = "0x14DDB60", Offset = "0x14DDB60", VA = "0x14DDB60")]
	private void ExportTileCountsToMain()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027A6")]
	[Cpp2IlInjected.Address(RVA = "0x14DE29C", Offset = "0x14DE29C", VA = "0x14DE29C")]
	public int GetTileCount(ushort tileId)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60027A7")]
	[Cpp2IlInjected.Address(RVA = "0x14DCDE0", Offset = "0x14DCDE0", VA = "0x14DCDE0")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027A8")]
	[Cpp2IlInjected.Address(RVA = "0x14DE000", Offset = "0x14DE000", VA = "0x14DE000")]
	private void UpdateOreFinderData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027A9")]
	[Cpp2IlInjected.Address(RVA = "0x14DE35C", Offset = "0x14DE35C", VA = "0x14DE35C")]
	public static bool IsValidForOreFinder(Tile t)
	{
		return default(bool);
	}
}
