using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics;
using Terraria.Utilities;

namespace Terraria.GameContent.Drawing;

[Cpp2IlInjected.Token(Token = "0x200066C")]
public class TileDrawing
{
	[Cpp2IlInjected.Token(Token = "0x2000A55")]
	public enum TileCounterType
	{
		[Cpp2IlInjected.Token(Token = "0x4008E10")]
		Tree,
		[Cpp2IlInjected.Token(Token = "0x4008E11")]
		DisplayDoll,
		[Cpp2IlInjected.Token(Token = "0x4008E12")]
		HatRack,
		[Cpp2IlInjected.Token(Token = "0x4008E13")]
		WindyGrass,
		[Cpp2IlInjected.Token(Token = "0x4008E14")]
		MultiTileGrass,
		[Cpp2IlInjected.Token(Token = "0x4008E15")]
		MultiTileVine,
		[Cpp2IlInjected.Token(Token = "0x4008E16")]
		Vine,
		[Cpp2IlInjected.Token(Token = "0x4008E17")]
		BiomeGrass,
		[Cpp2IlInjected.Token(Token = "0x4008E18")]
		VoidLens,
		[Cpp2IlInjected.Token(Token = "0x4008E19")]
		ReverseVine,
		[Cpp2IlInjected.Token(Token = "0x4008E1A")]
		TeleportationPylon,
		[Cpp2IlInjected.Token(Token = "0x4008E1B")]
		MasterTrophy,
		[Cpp2IlInjected.Token(Token = "0x4008E1C")]
		AnyDirectionalGrass,
		[Cpp2IlInjected.Token(Token = "0x4008E1D")]
		Count
	}

	[Cpp2IlInjected.Token(Token = "0x2000A56")]
	private struct TileFlameData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008E1E")]
		public Texture2D flameTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E1F")]
		public ulong flameSeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008E20")]
		public int flameCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008E21")]
		public Color flameColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008E22")]
		public int flameRangeXMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008E23")]
		public int flameRangeXMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008E24")]
		public int flameRangeYMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008E25")]
		public int flameRangeYMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008E26")]
		public float flameRangeMultX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008E27")]
		public float flameRangeMultY;
	}

	[Cpp2IlInjected.Token(Token = "0x4006D4A")]
	public const int MAX_SPECIALS = 9000;

	[Cpp2IlInjected.Token(Token = "0x4006D4B")]
	private const int MAX_SPECIALS_LEGACY = 1000;

	[Cpp2IlInjected.Token(Token = "0x4006D4C")]
	private const float FORCE_FOR_MIN_WIND = 0.08f;

	[Cpp2IlInjected.Token(Token = "0x4006D4D")]
	private const float FORCE_FOR_MAX_WIND = 1.2f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006D4E")]
	private bool[] cacheSpecialDrawTree;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006D4F")]
	private int _leafFrequency;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006D50")]
	private object specialLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006D51")]
	private int _specialTilesCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006D52")]
	private int[] _specialTileX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006D53")]
	private int[] _specialTileY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006D54")]
	private object _specialLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006D55")]
	private double _treeWindCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006D56")]
	private double _grassWindCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006D57")]
	private double _sunflowerWindCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006D58")]
	private double _vineWindCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4006D59")]
	private TilePaintSystemV2 _paintSystem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4006D5A")]
	private ThreadedRenderManager _threadManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4006D5B")]
	private Color _martianGlow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4006D5C")]
	private Color _meteorGlow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4006D5D")]
	private Color _lavaMossGlow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4006D5E")]
	private Color _kryptonMossGlow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4006D5F")]
	private Color _xenonMossGlow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4006D60")]
	private Color _argonMossGlow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4006D61")]
	private Color _violetMossGlow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4006D62")]
	private bool _isActiveAndNotPaused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4006D63")]
	private Player _localPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4006D64")]
	private Color _highQualityLightingRequirement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4006D65")]
	private Color _mediumQualityLightingRequirement;

	[Cpp2IlInjected.Token(Token = "0x4006D66")]
	private static readonly Vector2 _zero;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4006D67")]
	private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4006D68")]
	private Vector3[] _glowPaintColorSlices;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4006D69")]
	private VertexColors LiquidBehindTileColors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4006D6A")]
	private VertexColors LiquidBehindTileColors2;

	[Cpp2IlInjected.Token(Token = "0x4006D6B")]
	private static WorldGen.GetTreeFoliageDataMethod GetCommonTreeFoliageDataInstance;

	[Cpp2IlInjected.Token(Token = "0x4006D6C")]
	private static WorldGen.GetTreeFoliageDataMethod GetGemTreeFoliageDataInstance;

	[Cpp2IlInjected.Token(Token = "0x4006D6D")]
	private static WorldGen.GetTreeFoliageDataMethod GetVanityTreeFoliageDataInstance;

	[Cpp2IlInjected.Token(Token = "0x4006D6E")]
	private static WorldGen.GetTreeFoliageDataMethod GetAshTreeFoliageDataInstance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4006D6F")]
	private List<DrawData> _voidLensData;

	[Cpp2IlInjected.Token(Token = "0x1700077B")]
	private int[] _specialsCount
	{
		[Cpp2IlInjected.Token(Token = "0x600408D")]
		[Cpp2IlInjected.Address(RVA = "0xD8B080", Offset = "0xD8B080", VA = "0xD8B080")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600408E")]
		[Cpp2IlInjected.Address(RVA = "0xD8B0FC", Offset = "0xD8B0FC", VA = "0xD8B0FC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700077C")]
	private Point[][] _specialPositions
	{
		[Cpp2IlInjected.Token(Token = "0x600408F")]
		[Cpp2IlInjected.Address(RVA = "0xD8B17C", Offset = "0xD8B17C", VA = "0xD8B17C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004090")]
		[Cpp2IlInjected.Address(RVA = "0xD8B1F8", Offset = "0xD8B1F8", VA = "0xD8B1F8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700077D")]
	private Dictionary<Point, int> _displayDollTileEntityPositions
	{
		[Cpp2IlInjected.Token(Token = "0x6004092")]
		[Cpp2IlInjected.Address(RVA = "0xD8B2E8", Offset = "0xD8B2E8", VA = "0xD8B2E8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700077E")]
	private Dictionary<Point, int> _hatRackTileEntityPositions
	{
		[Cpp2IlInjected.Token(Token = "0x6004093")]
		[Cpp2IlInjected.Address(RVA = "0xD8B3C0", Offset = "0xD8B3C0", VA = "0xD8B3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700077F")]
	private Dictionary<Point, int> _trainingDummyTileEntityPositions
	{
		[Cpp2IlInjected.Token(Token = "0x6004094")]
		[Cpp2IlInjected.Address(RVA = "0xD8B41C", Offset = "0xD8B41C", VA = "0xD8B41C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000780")]
	private Dictionary<Point, int> _itemFrameTileEntityPositions
	{
		[Cpp2IlInjected.Token(Token = "0x6004095")]
		[Cpp2IlInjected.Address(RVA = "0xD8B478", Offset = "0xD8B478", VA = "0xD8B478")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000781")]
	private Dictionary<Point, int> _foodPlatterTileEntityPositions
	{
		[Cpp2IlInjected.Token(Token = "0x6004096")]
		[Cpp2IlInjected.Address(RVA = "0xD8B4D4", Offset = "0xD8B4D4", VA = "0xD8B4D4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000782")]
	private Dictionary<Point, int> _weaponRackTileEntityPositions
	{
		[Cpp2IlInjected.Token(Token = "0x6004097")]
		[Cpp2IlInjected.Address(RVA = "0xD8B530", Offset = "0xD8B530", VA = "0xD8B530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000783")]
	private Dictionary<Point, int> _chestPositions
	{
		[Cpp2IlInjected.Token(Token = "0x6004098")]
		[Cpp2IlInjected.Address(RVA = "0xD8B58C", Offset = "0xD8B58C", VA = "0xD8B58C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000784")]
	private UnifiedRandom _rand
	{
		[Cpp2IlInjected.Token(Token = "0x6004099")]
		[Cpp2IlInjected.Address(RVA = "0xD8B5E8", Offset = "0xD8B5E8", VA = "0xD8B5E8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000785")]
	private WindGrid _windGrid
	{
		[Cpp2IlInjected.Token(Token = "0x600409A")]
		[Cpp2IlInjected.Address(RVA = "0xD8B644", Offset = "0xD8B644", VA = "0xD8B644")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600409B")]
		[Cpp2IlInjected.Address(RVA = "0xD8B6C0", Offset = "0xD8B6C0", VA = "0xD8B6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000786")]
	private bool _shouldShowInvisibleBlocks
	{
		[Cpp2IlInjected.Token(Token = "0x600409C")]
		[Cpp2IlInjected.Address(RVA = "0xD8B740", Offset = "0xD8B740", VA = "0xD8B740")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600409D")]
		[Cpp2IlInjected.Address(RVA = "0xD8B7BC", Offset = "0xD8B7BC", VA = "0xD8B7BC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000787")]
	private bool _shouldShowInvisibleBlocks_LastFrame
	{
		[Cpp2IlInjected.Token(Token = "0x600409E")]
		[Cpp2IlInjected.Address(RVA = "0xD8B83C", Offset = "0xD8B83C", VA = "0xD8B83C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600409F")]
		[Cpp2IlInjected.Address(RVA = "0xD8B8B8", Offset = "0xD8B8B8", VA = "0xD8B8B8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000788")]
	private bool[] _tileSolid
	{
		[Cpp2IlInjected.Token(Token = "0x60040A0")]
		[Cpp2IlInjected.Address(RVA = "0xD8B938", Offset = "0xD8B938", VA = "0xD8B938")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000789")]
	private bool[] _tileSolidTop
	{
		[Cpp2IlInjected.Token(Token = "0x60040A1")]
		[Cpp2IlInjected.Address(RVA = "0xD8B9B0", Offset = "0xD8B9B0", VA = "0xD8B9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700078A")]
	private Dust[] _dust
	{
		[Cpp2IlInjected.Token(Token = "0x60040A2")]
		[Cpp2IlInjected.Address(RVA = "0xD8BA28", Offset = "0xD8BA28", VA = "0xD8BA28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700078B")]
	private Gore[] _gore
	{
		[Cpp2IlInjected.Token(Token = "0x60040A3")]
		[Cpp2IlInjected.Address(RVA = "0xD8BAA0", Offset = "0xD8BAA0", VA = "0xD8BAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700078C")]
	public ThreadLocal<TileDrawInfo> _currentTileDrawInfo
	{
		[Cpp2IlInjected.Token(Token = "0x60040AA")]
		[Cpp2IlInjected.Address(RVA = "0xD8B344", Offset = "0xD8B344", VA = "0xD8B344")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60040AB")]
		[Cpp2IlInjected.Address(RVA = "0xD93AF0", Offset = "0xD93AF0", VA = "0xD93AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700078D")]
	private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
	{
		[Cpp2IlInjected.Token(Token = "0x60040AE")]
		[Cpp2IlInjected.Address(RVA = "0xD9E268", Offset = "0xD9E268", VA = "0xD9E268")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004091")]
	[Cpp2IlInjected.Address(RVA = "0xD8B278", Offset = "0xD8B278", VA = "0xD8B278")]
	private void AddSpecialPoint(int x, int y, TileCounterType type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040A4")]
	[Cpp2IlInjected.Address(RVA = "0xD8BB18", Offset = "0xD8BB18", VA = "0xD8BB18")]
	public TileDrawing(TilePaintSystemV2 paintSystem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040A5")]
	[Cpp2IlInjected.Address(RVA = "0xD8C29C", Offset = "0xD8C29C", VA = "0xD8C29C")]
	public void PreparePaintForTilesOnScreen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040A6")]
	[Cpp2IlInjected.Address(RVA = "0xD8C920", Offset = "0xD8C920", VA = "0xD8C920")]
	public void PrepareForAreaDrawing(int firstTileX, int lastTileX, int firstTileY, int lastTileY, bool prepareLazily)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040A7")]
	[Cpp2IlInjected.Address(RVA = "0xD8CB58", Offset = "0xD8CB58", VA = "0xD8CB58")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040A8")]
	[Cpp2IlInjected.Address(RVA = "0xD8D400", Offset = "0xD8D400", VA = "0xD8D400")]
	public void PreDrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040A9")]
	[Cpp2IlInjected.Address(RVA = "0xD8D4E8", Offset = "0xD8D4E8", VA = "0xD8D4E8")]
	public void PostDrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040AC")]
	[Cpp2IlInjected.Address(RVA = "0xD93B70", Offset = "0xD93B70", VA = "0xD93B70")]
	private int DrawTilesThreaded(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040AD")]
	[Cpp2IlInjected.Address(RVA = "0xD9E21C", Offset = "0xD9E21C", VA = "0xD9E21C")]
	private void ProcessBatchFinished(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040AF")]
	[Cpp2IlInjected.Address(RVA = "0xD9E2F8", Offset = "0xD9E2F8", VA = "0xD9E2F8")]
	private void MergeDictionary(Dictionary<Point, int> dest, Dictionary<Point, int> src)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040B0")]
	[Cpp2IlInjected.Address(RVA = "0xD9E43C", Offset = "0xD9E43C", VA = "0xD9E43C")]
	private void WaitDrawThreads(int numThreads)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040B1")]
	[Cpp2IlInjected.Address(RVA = "0xD941E8", Offset = "0xD941E8", VA = "0xD941E8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395D14", Offset = "0x395D14")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395D14", Offset = "0x395D14")]
	public void DrawTiles(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040B2")]
	[Cpp2IlInjected.Address(RVA = "0xDBA30C", Offset = "0xDBA30C", VA = "0xDBA30C")]
	public void DrawLiquidBehindTiles(int waterStyleOverride = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040B3")]
	[Cpp2IlInjected.Address(RVA = "0xDBA910", Offset = "0xDBA910", VA = "0xDBA910")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395DC8", Offset = "0x395DC8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395DC8", Offset = "0x395DC8")]
	public void Draw(bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040B4")]
	[Cpp2IlInjected.Address(RVA = "0xDA013C", Offset = "0xDA013C", VA = "0xDA013C")]
	private void CrawlToTopOfVineAndAddSpecialPoint(int j, int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040B5")]
	[Cpp2IlInjected.Address(RVA = "0xDA02BC", Offset = "0xDA02BC", VA = "0xDA02BC")]
	private void CrawlToBottomOfReverseVineAndAddSpecialPoint(int j, int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040B6")]
	[Cpp2IlInjected.Address(RVA = "0xDBDB1C", Offset = "0xDBDB1C", VA = "0xDBDB1C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395E7C", Offset = "0x395E7C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395E7C", Offset = "0x395E7C")]
	public Texture2D GetTileDrawTexture(TileDrawInfo drawInfo, int worldWidth, out EffectPass pass)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60040B7")]
	[Cpp2IlInjected.Address(RVA = "0xDA619C", Offset = "0xDA619C", VA = "0xDA619C")]
	private bool IsVisible(Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60040B8")]
	[Cpp2IlInjected.Address(RVA = "0xDAD86C", Offset = "0xDAD86C", VA = "0xDAD86C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395F30", Offset = "0x395F30")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395F30", Offset = "0x395F30")]
	public Texture2D GetTileDrawTexture(TileDrawInfo drawInfo, int tileX, int tileY, out EffectPass pass)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60040B9")]
	[Cpp2IlInjected.Address(RVA = "0xDBDFCC", Offset = "0xDBDFCC", VA = "0xDBDFCC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395FE4", Offset = "0x395FE4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x395FE4", Offset = "0x395FE4")]
	public Texture2D GetTileDrawTexture(int tileX, int tileY, ushort tileType, short frameX, short frameY, byte tileColor, out EffectPass pass)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60040BA")]
	[Cpp2IlInjected.Address(RVA = "0xDAF8D0", Offset = "0xDAF8D0", VA = "0xDAF8D0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x396098", Offset = "0x396098")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x396098", Offset = "0x396098")]
	private Texture2D GetTileDrawTexture(Tile tile, int tileX, int tileY, out EffectPass pass)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60040BB")]
	[Cpp2IlInjected.Address(RVA = "0xDBE1C0", Offset = "0xDBE1C0", VA = "0xDBE1C0")]
	private Texture2D GetTileDrawTexture(Tile tile, int tileX, int tileY, int paintOverride, out EffectPass pass)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60040BC")]
	[Cpp2IlInjected.Address(RVA = "0xDA6444", Offset = "0xDA6444", VA = "0xDA6444")]
	private int GetPalmTreeBiome(TileDrawInfo drawInfo, int worldWidth)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040BD")]
	[Cpp2IlInjected.Address(RVA = "0xDBDEA4", Offset = "0xDBDEA4", VA = "0xDBDEA4")]
	private int GetPalmTreeBiome(int tileX, int tileY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040BE")]
	[Cpp2IlInjected.Address(RVA = "0xDA6234", Offset = "0xDA6234", VA = "0xDA6234")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39614C", Offset = "0x39614C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39614C", Offset = "0x39614C")]
	private int GetTreeBiome(TileDrawInfo drawInfo, int worldWidth)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040BF")]
	[Cpp2IlInjected.Address(RVA = "0xDBDC94", Offset = "0xDBDC94", VA = "0xDBDC94")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x396200", Offset = "0x396200")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x396200", Offset = "0x396200")]
	private static int GetTreeBiome(int tileX, int tileY, int tileFrameX, int tileFrameY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040C0")]
	[Cpp2IlInjected.Address(RVA = "0xDBE72C", Offset = "0xDBE72C", VA = "0xDBE72C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3962B4", Offset = "0x3962B4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3962B4", Offset = "0x3962B4")]
	public static int GetTreeVariant(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040C1")]
	[Cpp2IlInjected.Address(RVA = "0xDBE920", Offset = "0xDBE920", VA = "0xDBE920")]
	private TileFlameData GetTileFlameData(int tileX, int tileY, int type, int tileFrameY)
	{
		return default(TileFlameData);
	}

	[Cpp2IlInjected.Token(Token = "0x60040C2")]
	[Cpp2IlInjected.Address(RVA = "0xDAFAEC", Offset = "0xDAFAEC", VA = "0xDAFAEC")]
	private void DrawSingleTile_Flames(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040C3")]
	[Cpp2IlInjected.Address(RVA = "0xDBE3E0", Offset = "0xDBE3E0", VA = "0xDBE3E0")]
	private int GetPalmTreeVariant(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040C4")]
	[Cpp2IlInjected.Address(RVA = "0xDAEC14", Offset = "0xDAEC14", VA = "0xDAEC14")]
	private void DrawXmasTree(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040C5")]
	[Cpp2IlInjected.Address(RVA = "0xDADA30", Offset = "0xDADA30", VA = "0xDADA30")]
	private void DrawTile_MinecartTrack(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040C6")]
	[Cpp2IlInjected.Address(RVA = "0xD9E94C", Offset = "0xD9E94C", VA = "0xD9E94C")]
	private void DrawTile_LiquidBehindTile(bool solidLayer, bool inFrontOfPlayers, int waterStyleOverride, Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040C7")]
	[Cpp2IlInjected.Address(RVA = "0xDBFA64", Offset = "0xDBFA64", VA = "0xDBFA64")]
	private void CacheSpecialDraws(int tileX, int tileY, ushort typeCache, short tileFrameX, short tileFrameY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040C8")]
	[Cpp2IlInjected.Address(RVA = "0xDBF728", Offset = "0xDBF728", VA = "0xDBF728")]
	private static Color GetFinalLight(TileDrawInfo tileDrawInfo, ushort typeCache, Color tileLight)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60040C9")]
	[Cpp2IlInjected.Address(RVA = "0xDC011C", Offset = "0xDC011C", VA = "0xDC011C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x396368", Offset = "0x396368")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x396368", Offset = "0x396368")]
	private static bool ShouldTileShine(ushort type, short frameX)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60040CA")]
	[Cpp2IlInjected.Address(RVA = "0xDA0CE8", Offset = "0xDA0CE8", VA = "0xDA0CE8")]
	private static bool IsTileDangerous(Player localPlayer, short sTileHeader, ushort typeCache, short tileFrameX)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60040CB")]
	[Cpp2IlInjected.Address(RVA = "0xDC0280", Offset = "0xDC0280", VA = "0xDC0280")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39641C", Offset = "0x39641C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39641C", Offset = "0x39641C")]
	private bool IsTileDrawLayerSolid(ushort typeCache)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60040CC")]
	[Cpp2IlInjected.Address(RVA = "0xDAD6FC", Offset = "0xDAD6FC", VA = "0xDAD6FC")]
	private void GetTileOutlineInfo(int x, int y, ushort typeCache, ref Color tileLight, ref Texture2D highlightTexture, ref Color highlightColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040CD")]
	[Cpp2IlInjected.Address(RVA = "0xDBF884", Offset = "0xDBF884", VA = "0xDBF884")]
	private void DrawPartialLiquid(SpriteBatch spriteBatch, bool behindBlocks, TileDrawInfo tileCache, ref Vector2 position, ref Rectangle liquidSize, int liquidType, ref VertexColors colors)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040CE")]
	[Cpp2IlInjected.Address(RVA = "0xDC0350", Offset = "0xDC0350", VA = "0xDC0350")]
	private bool InAPlaceWithWind(int x, int y, int width, int height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60040CF")]
	[Cpp2IlInjected.Address(RVA = "0xDA65A0", Offset = "0xDA65A0", VA = "0xDA65A0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3964D0", Offset = "0x3964D0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3964D0", Offset = "0x3964D0")]
	private void GetTileDrawData(int x, int y, TileDrawInfo tileCache, ushort typeCache, ref short tileFrameX, ref short tileFrameY, out int tileWidth, out int tileHeight, out int tileTop, out int halfBrickHeight, out int addFrX, out int addFrY, out SpriteEffects tileSpriteEffect, out Texture2D glowTexture, out Rectangle glowSourceRect, out Color glowColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040D0")]
	[Cpp2IlInjected.Address(RVA = "0xDC0670", Offset = "0xDC0670", VA = "0xDC0670")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x396584", Offset = "0x396584")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x396584", Offset = "0x396584")]
	private void GetTileDrawData(int x, int y, bool halfBrick, ushort typeCache, ref short tileFrameX, ref short tileFrameY, out int tileWidth, out int tileHeight, out int tileTop, out int halfBrickHeight, out int addFrX, out int addFrY, out SpriteEffects tileSpriteEffect, out Texture2D glowTexture, out Rectangle glowSourceRect, out Color glowColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040D1")]
	[Cpp2IlInjected.Address(RVA = "0xDC770C", Offset = "0xDC770C", VA = "0xDC770C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x396638", Offset = "0x396638")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x396638", Offset = "0x396638")]
	private void GetTileDrawData(int x, int y, Tile tileCache, ushort typeCache, ref short tileFrameX, ref short tileFrameY, out int tileWidth, out int tileHeight, out int tileTop, out int halfBrickHeight, out int addFrX, out int addFrY, out SpriteEffects tileSpriteEffect, out Texture2D glowTexture, out Rectangle glowSourceRect, out Color glowColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040D2")]
	[Cpp2IlInjected.Address(RVA = "0xDCDA0C", Offset = "0xDCDA0C", VA = "0xDCDA0C")]
	private bool IsWindBlocked(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60040D3")]
	[Cpp2IlInjected.Address(RVA = "0xDC059C", Offset = "0xDC059C", VA = "0xDC059C")]
	private int GetWaterAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040D4")]
	[Cpp2IlInjected.Address(RVA = "0xDC04C8", Offset = "0xDC04C8", VA = "0xDC04C8")]
	private int GetSmallAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040D5")]
	[Cpp2IlInjected.Address(RVA = "0xDC03F0", Offset = "0xDC03F0", VA = "0xDC03F0")]
	private int GetBigAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040D6")]
	[Cpp2IlInjected.Address(RVA = "0xD8C5A0", Offset = "0xD8C5A0", VA = "0xD8C5A0")]
	private void GetScreenDrawArea(Vector2 screenPosition, Vector2 offSet, out int firstTileX, out int lastTileX, out int firstTileY, out int lastTileY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040D7")]
	[Cpp2IlInjected.Address(RVA = "0xDBB478", Offset = "0xDBB478", VA = "0xDBB478")]
	public void ClearCachedTileDraws(bool solidLayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040D8")]
	[Cpp2IlInjected.Address(RVA = "0xDA0C60", Offset = "0xDA0C60", VA = "0xDA0C60")]
	private void AddSpecialLegacyPoint(Point p)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040D9")]
	[Cpp2IlInjected.Address(RVA = "0xDA0CA4", Offset = "0xDA0CA4", VA = "0xDA0CA4")]
	private void AddSpecialLegacyPoint(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040DA")]
	[Cpp2IlInjected.Address(RVA = "0xDBB3E4", Offset = "0xDBB3E4", VA = "0xDBB3E4")]
	private void ClearLegacyCachedDraws()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040DB")]
	[Cpp2IlInjected.Address(RVA = "0xDCDB64", Offset = "0xDCDB64", VA = "0xDCDB64")]
	private Color DrawTiles_GetLightOverride(int j, int i, short sTileHeader, ushort typeCache, short tileFrameX, short tileFrameY, Color tileLight, bool fullBrightBlock)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60040DC")]
	[Cpp2IlInjected.Address(RVA = "0xDA0FC8", Offset = "0xDA0FC8", VA = "0xDA0FC8")]
	private void DrawTiles_EmitParticles(int j, int i, ushort typeCache, short tileFrameX, short tileFrameY, Color tileLight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040DD")]
	[Cpp2IlInjected.Address(RVA = "0xDCDDEC", Offset = "0xDCDDEC", VA = "0xDCDDEC")]
	private void EmitLivingTreeLeaf(int i, int j, int leafGoreType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040DE")]
	[Cpp2IlInjected.Address(RVA = "0xDCEC28", Offset = "0xDCEC28", VA = "0xDCEC28")]
	private void EmitLivingTreeLeaf_Below(int x, int y, int leafGoreType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040DF")]
	[Cpp2IlInjected.Address(RVA = "0xDCF134", Offset = "0xDCF134", VA = "0xDCF134")]
	private void EmitLivingTreeLeaf_Sideways(int x, int y, int leafGoreType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040E0")]
	[Cpp2IlInjected.Address(RVA = "0xDA042C", Offset = "0xDA042C", VA = "0xDA042C")]
	private void EmitLiquidDrops(int j, int i, byte liquid, ushort typeCache)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040E1")]
	[Cpp2IlInjected.Address(RVA = "0xDCF4E0", Offset = "0xDCF4E0", VA = "0xDCF4E0")]
	private float GetWindCycle(int x, int y, double windCounter)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60040E2")]
	[Cpp2IlInjected.Address(RVA = "0xDCF850", Offset = "0xDCF850", VA = "0xDCF850")]
	private bool ShouldSwayInWind(int x, int y, ushort tileType, short frameX)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60040E3")]
	[Cpp2IlInjected.Address(RVA = "0xD8CF04", Offset = "0xD8CF04", VA = "0xD8CF04")]
	private void UpdateLeafFrequency()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040E4")]
	[Cpp2IlInjected.Address(RVA = "0xD8D1AC", Offset = "0xD8D1AC", VA = "0xD8D1AC")]
	private void EnsureWindGridSize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040E5")]
	[Cpp2IlInjected.Address(RVA = "0xDCF960", Offset = "0xDCF960", VA = "0xDCF960")]
	private void EmitTreeLeaves(int tilePosX, int tilePosY, int grassPosX, int grassPosY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040E6")]
	[Cpp2IlInjected.Address(RVA = "0xDBB4F4", Offset = "0xDBB4F4", VA = "0xDBB4F4")]
	private void DrawSpecialTilesLegacy(Vector2 screenPosition, Vector2 offSet)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040E7")]
	[Cpp2IlInjected.Address(RVA = "0xD936A4", Offset = "0xD936A4", VA = "0xD936A4")]
	private void DrawEntities_DisplayDolls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040E8")]
	[Cpp2IlInjected.Address(RVA = "0xD93270", Offset = "0xD93270", VA = "0xD93270")]
	private void DrawEntities_HatRacks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040E9")]
	[Cpp2IlInjected.Address(RVA = "0xD90BCC", Offset = "0xD90BCC", VA = "0xD90BCC")]
	private void DrawTrees()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040EA")]
	[Cpp2IlInjected.Address(RVA = "0xDD005C", Offset = "0xDD005C", VA = "0xDD005C")]
	private Texture2D GetTreeTopTexture(int treeTextureIndex, int treeTextureStyle, byte tileColor, out EffectPass pass)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60040EB")]
	[Cpp2IlInjected.Address(RVA = "0xDD0120", Offset = "0xDD0120", VA = "0xDD0120")]
	private Texture2D GetTreeBranchTexture(int treeTextureIndex, int treeTextureStyle, byte tileColor, out EffectPass pass)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60040EC")]
	[Cpp2IlInjected.Address(RVA = "0xD8F5F4", Offset = "0xD8F5F4", VA = "0xD8F5F4")]
	private void DrawGrass()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040ED")]
	[Cpp2IlInjected.Address(RVA = "0xD8FF84", Offset = "0xD8FF84", VA = "0xD8FF84")]
	private void DrawAnyDirectionalGrass()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040EE")]
	[Cpp2IlInjected.Address(RVA = "0xDD01E4", Offset = "0xDD01E4", VA = "0xDD01E4")]
	private void DrawAnimatedTile_AdjustForVisionChangers(int i, int j, short tileSHeader, ushort typeCache, short tileFrameX, short tileFrameY, ref Color tileLight, bool canDoDust)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040EF")]
	[Cpp2IlInjected.Address(RVA = "0xDD0CD0", Offset = "0xDD0CD0", VA = "0xDD0CD0")]
	private float GetWindGridPush(int i, int j, int pushAnimationTimeTotal, float pushForcePerFrame)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60040F0")]
	[Cpp2IlInjected.Address(RVA = "0xDD0D60", Offset = "0xDD0D60", VA = "0xDD0D60")]
	private void GetWindGridPush2Axis(int i, int j, int pushAnimationTimeTotal, float pushForcePerFrame, out float pushX, out float pushY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040F1")]
	[Cpp2IlInjected.Address(RVA = "0xDD0E0C", Offset = "0xDD0E0C", VA = "0xDD0E0C")]
	private float GetWindGridPushComplex(int i, int j, int pushAnimationTimeTotal, float totalPushForce, int loops, bool flipDirectionPerLoop)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60040F2")]
	[Cpp2IlInjected.Address(RVA = "0xD8EDE8", Offset = "0xD8EDE8", VA = "0xD8EDE8")]
	private void DrawMasterTrophies()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040F3")]
	[Cpp2IlInjected.Address(RVA = "0xD8E218", Offset = "0xD8E218", VA = "0xD8E218")]
	private void DrawTeleportationPylons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040F4")]
	[Cpp2IlInjected.Address(RVA = "0xD8DED0", Offset = "0xD8DED0", VA = "0xD8DED0")]
	private void DrawVoidLenses()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040F5")]
	[Cpp2IlInjected.Address(RVA = "0xD8DB10", Offset = "0xD8DB10", VA = "0xD8DB10")]
	private void DrawMultiTileGrass()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040F6")]
	[Cpp2IlInjected.Address(RVA = "0xDD0F2C", Offset = "0xDD0F2C", VA = "0xDD0F2C")]
	private int ClimbCatTail(int originx, int originy)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60040F7")]
	[Cpp2IlInjected.Address(RVA = "0xD8D7CC", Offset = "0xD8D7CC", VA = "0xD8D7CC")]
	private void DrawMultiTileVines()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040F8")]
	[Cpp2IlInjected.Address(RVA = "0xD92F08", Offset = "0xD92F08", VA = "0xD92F08")]
	private void DrawVines()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040F9")]
	[Cpp2IlInjected.Address(RVA = "0xD930BC", Offset = "0xD930BC", VA = "0xD930BC")]
	private void DrawReverseVines()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040FA")]
	[Cpp2IlInjected.Address(RVA = "0xDD1038", Offset = "0xDD1038", VA = "0xDD1038")]
	private void DrawMultiTileGrassInWind(Vector2 screenPosition, Vector2 offSet, int topLeftX, int topLeftY, int sizeX, int sizeY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040FB")]
	[Cpp2IlInjected.Address(RVA = "0xDD34AC", Offset = "0xDD34AC", VA = "0xDD34AC")]
	private void DrawVineStrip(Vector2 screenPosition, Vector2 offSet, int x, int startY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040FC")]
	[Cpp2IlInjected.Address(RVA = "0xDD46F0", Offset = "0xDD46F0", VA = "0xDD46F0")]
	private void DrawRisingVineStrip(Vector2 screenPosition, Vector2 offSet, int x, int startY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60040FD")]
	[Cpp2IlInjected.Address(RVA = "0xDD507C", Offset = "0xDD507C", VA = "0xDD507C")]
	private float GetAverageWindGridPush(int topLeftX, int topLeftY, int sizeX, int sizeY, int totalPushTime, float pushForcePerFrame)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60040FE")]
	[Cpp2IlInjected.Address(RVA = "0xDD515C", Offset = "0xDD515C", VA = "0xDD515C")]
	private float GetHighestWindGridPushComplex(int topLeftX, int topLeftY, int sizeX, int sizeY, int totalPushTime, float pushForcePerFrame, int loops, bool swapLoopDir)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60040FF")]
	[Cpp2IlInjected.Address(RVA = "0xDD1E04", Offset = "0xDD1E04", VA = "0xDD1E04")]
	private void DrawMultiTileVinesInWind(Vector2 screenPosition, Vector2 offSet, int topLeftX, int topLeftY, int sizeX, int sizeY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004100")]
	[Cpp2IlInjected.Address(RVA = "0xDCDE38", Offset = "0xDCDE38", VA = "0xDCDE38")]
	private void EmitAlchemyHerbParticles(int j, int i, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004101")]
	[Cpp2IlInjected.Address(RVA = "0xDA5EF0", Offset = "0xDA5EF0", VA = "0xDA5EF0")]
	private bool IsAlchemyPlantHarvestable(int style)
	{
		return default(bool);
	}
}
