using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.Modules;

namespace Terraria.ObjectData;

[Cpp2IlInjected.Token(Token = "0x20003A9")]
public class TileObjectData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003206")]
	private TileObjectData _parent;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003207")]
	private bool _linkedAlternates;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4003208")]
	private bool _usesCustomCanPlace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003209")]
	private TileObjectAlternatesModule _alternates;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400320A")]
	private AnchorDataModule _anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400320B")]
	private AnchorTypesModule _anchorTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400320C")]
	private LiquidDeathModule _liquidDeath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400320D")]
	private LiquidPlacementModule _liquidPlacement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400320E")]
	private TilePlacementHooksModule _placementHooks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400320F")]
	private TileObjectSubTilesModule _subTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4003210")]
	private TileObjectDrawModule _tileObjectDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4003211")]
	private TileObjectStyleModule _tileObjectStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4003212")]
	private TileObjectBaseModule _tileObjectBase;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4003213")]
	private TileObjectCoordinatesModule _tileObjectCoords;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4003214")]
	private bool _hasOwnAlternates;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
	[Cpp2IlInjected.Token(Token = "0x4003215")]
	private bool _hasOwnAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
	[Cpp2IlInjected.Token(Token = "0x4003216")]
	private bool _hasOwnAnchorTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F")]
	[Cpp2IlInjected.Token(Token = "0x4003217")]
	private bool _hasOwnLiquidDeath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4003218")]
	private bool _hasOwnLiquidPlacement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4003219")]
	private bool _hasOwnPlacementHooks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x400321A")]
	private bool _hasOwnSubTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
	[Cpp2IlInjected.Token(Token = "0x400321B")]
	private bool _hasOwnTileObjectBase;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400321C")]
	private bool _hasOwnTileObjectDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400321D")]
	private bool _hasOwnTileObjectStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400321E")]
	private bool _hasOwnTileObjectCoords;

	[Cpp2IlInjected.Token(Token = "0x400321F")]
	private static List<TileObjectData> _data;

	[Cpp2IlInjected.Token(Token = "0x4003220")]
	private static TileObjectData _baseObject;

	[Cpp2IlInjected.Token(Token = "0x4003221")]
	private static bool readOnlyData;

	[Cpp2IlInjected.Token(Token = "0x4003222")]
	private static TileObjectData newTile;

	[Cpp2IlInjected.Token(Token = "0x4003223")]
	private static TileObjectData newSubTile;

	[Cpp2IlInjected.Token(Token = "0x4003224")]
	private static TileObjectData newAlternate;

	[Cpp2IlInjected.Token(Token = "0x4003225")]
	private static TileObjectData StyleSwitch;

	[Cpp2IlInjected.Token(Token = "0x4003226")]
	private static TileObjectData StyleTorch;

	[Cpp2IlInjected.Token(Token = "0x4003227")]
	private static TileObjectData Style4x2;

	[Cpp2IlInjected.Token(Token = "0x4003228")]
	private static TileObjectData Style2x2;

	[Cpp2IlInjected.Token(Token = "0x4003229")]
	private static TileObjectData Style1x2;

	[Cpp2IlInjected.Token(Token = "0x400322A")]
	private static TileObjectData Style1x1;

	[Cpp2IlInjected.Token(Token = "0x400322B")]
	private static TileObjectData StyleAlch;

	[Cpp2IlInjected.Token(Token = "0x400322C")]
	private static TileObjectData StyleDye;

	[Cpp2IlInjected.Token(Token = "0x400322D")]
	private static TileObjectData Style2x1;

	[Cpp2IlInjected.Token(Token = "0x400322E")]
	private static TileObjectData Style6x3;

	[Cpp2IlInjected.Token(Token = "0x400322F")]
	private static TileObjectData StyleSmallCage;

	[Cpp2IlInjected.Token(Token = "0x4003230")]
	private static TileObjectData StyleOnTable1x1;

	[Cpp2IlInjected.Token(Token = "0x4003231")]
	private static TileObjectData Style1x2Top;

	[Cpp2IlInjected.Token(Token = "0x4003232")]
	private static TileObjectData Style1xX;

	[Cpp2IlInjected.Token(Token = "0x4003233")]
	private static TileObjectData Style2xX;

	[Cpp2IlInjected.Token(Token = "0x4003234")]
	private static TileObjectData Style3x2;

	[Cpp2IlInjected.Token(Token = "0x4003235")]
	private static TileObjectData Style3x3;

	[Cpp2IlInjected.Token(Token = "0x4003236")]
	private static TileObjectData Style3x4;

	[Cpp2IlInjected.Token(Token = "0x4003237")]
	private static TileObjectData Style5x4;

	[Cpp2IlInjected.Token(Token = "0x4003238")]
	private static TileObjectData Style3x3Wall;

	[Cpp2IlInjected.Token(Token = "0x170005BD")]
	private bool LinkedAlternates
	{
		[Cpp2IlInjected.Token(Token = "0x6002E4D")]
		[Cpp2IlInjected.Address(RVA = "0x149ADA8", Offset = "0x149ADA8", VA = "0x149ADA8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E4E")]
		[Cpp2IlInjected.Address(RVA = "0x149ADB0", Offset = "0x149ADB0", VA = "0x149ADB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005BE")]
	public bool UsesCustomCanPlace
	{
		[Cpp2IlInjected.Token(Token = "0x6002E4F")]
		[Cpp2IlInjected.Address(RVA = "0x149AE48", Offset = "0x149AE48", VA = "0x149AE48")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E50")]
		[Cpp2IlInjected.Address(RVA = "0x149AE50", Offset = "0x149AE50", VA = "0x149AE50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005BF")]
	private List<TileObjectData> Alternates
	{
		[Cpp2IlInjected.Token(Token = "0x6002E51")]
		[Cpp2IlInjected.Address(RVA = "0x149AE6C", Offset = "0x149AE6C", VA = "0x149AE6C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E52")]
		[Cpp2IlInjected.Address(RVA = "0x1498154", Offset = "0x1498154", VA = "0x1498154")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005C0")]
	public AnchorData AnchorTop
	{
		[Cpp2IlInjected.Token(Token = "0x6002E53")]
		[Cpp2IlInjected.Address(RVA = "0x149AEE4", Offset = "0x149AEE4", VA = "0x149AEE4")]
		get
		{
			return default(AnchorData);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E54")]
		[Cpp2IlInjected.Address(RVA = "0x14981E8", Offset = "0x14981E8", VA = "0x14981E8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005C1")]
	public AnchorData AnchorBottom
	{
		[Cpp2IlInjected.Token(Token = "0x6002E55")]
		[Cpp2IlInjected.Address(RVA = "0x149AF6C", Offset = "0x149AF6C", VA = "0x149AF6C")]
		get
		{
			return default(AnchorData);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E56")]
		[Cpp2IlInjected.Address(RVA = "0x1498360", Offset = "0x1498360", VA = "0x1498360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005C2")]
	public AnchorData AnchorLeft
	{
		[Cpp2IlInjected.Token(Token = "0x6002E57")]
		[Cpp2IlInjected.Address(RVA = "0x149AFF4", Offset = "0x149AFF4", VA = "0x149AFF4")]
		get
		{
			return default(AnchorData);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E58")]
		[Cpp2IlInjected.Address(RVA = "0x14984D8", Offset = "0x14984D8", VA = "0x14984D8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005C3")]
	public AnchorData AnchorRight
	{
		[Cpp2IlInjected.Token(Token = "0x6002E59")]
		[Cpp2IlInjected.Address(RVA = "0x149B07C", Offset = "0x149B07C", VA = "0x149B07C")]
		get
		{
			return default(AnchorData);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E5A")]
		[Cpp2IlInjected.Address(RVA = "0x1498650", Offset = "0x1498650", VA = "0x1498650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005C4")]
	public bool AnchorWall
	{
		[Cpp2IlInjected.Token(Token = "0x6002E5B")]
		[Cpp2IlInjected.Address(RVA = "0x149B104", Offset = "0x149B104", VA = "0x149B104")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E5C")]
		[Cpp2IlInjected.Address(RVA = "0x14987C8", Offset = "0x14987C8", VA = "0x14987C8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005C5")]
	public int[] AnchorValidTiles
	{
		[Cpp2IlInjected.Token(Token = "0x6002E5D")]
		[Cpp2IlInjected.Address(RVA = "0x149B17C", Offset = "0x149B17C", VA = "0x149B17C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E5E")]
		[Cpp2IlInjected.Address(RVA = "0x14988D8", Offset = "0x14988D8", VA = "0x14988D8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005C6")]
	public int[] AnchorInvalidTiles
	{
		[Cpp2IlInjected.Token(Token = "0x6002E5F")]
		[Cpp2IlInjected.Address(RVA = "0x149B1F4", Offset = "0x149B1F4", VA = "0x149B1F4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E60")]
		[Cpp2IlInjected.Address(RVA = "0x1498A84", Offset = "0x1498A84", VA = "0x1498A84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005C7")]
	public int[] AnchorAlternateTiles
	{
		[Cpp2IlInjected.Token(Token = "0x6002E61")]
		[Cpp2IlInjected.Address(RVA = "0x149B26C", Offset = "0x149B26C", VA = "0x149B26C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E62")]
		[Cpp2IlInjected.Address(RVA = "0x1498C30", Offset = "0x1498C30", VA = "0x1498C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005C8")]
	public int[] AnchorValidWalls
	{
		[Cpp2IlInjected.Token(Token = "0x6002E63")]
		[Cpp2IlInjected.Address(RVA = "0x149B2E4", Offset = "0x149B2E4", VA = "0x149B2E4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E64")]
		[Cpp2IlInjected.Address(RVA = "0x1498DDC", Offset = "0x1498DDC", VA = "0x1498DDC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005C9")]
	public bool WaterDeath
	{
		[Cpp2IlInjected.Token(Token = "0x6002E65")]
		[Cpp2IlInjected.Address(RVA = "0x149B35C", Offset = "0x149B35C", VA = "0x149B35C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E66")]
		[Cpp2IlInjected.Address(RVA = "0x1498F44", Offset = "0x1498F44", VA = "0x1498F44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005CA")]
	public bool LavaDeath
	{
		[Cpp2IlInjected.Token(Token = "0x6002E67")]
		[Cpp2IlInjected.Address(RVA = "0x149B3D4", Offset = "0x149B3D4", VA = "0x149B3D4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E68")]
		[Cpp2IlInjected.Address(RVA = "0x1499054", Offset = "0x1499054", VA = "0x1499054")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005CB")]
	public LiquidPlacement WaterPlacement
	{
		[Cpp2IlInjected.Token(Token = "0x6002E69")]
		[Cpp2IlInjected.Address(RVA = "0x149B44C", Offset = "0x149B44C", VA = "0x149B44C")]
		get
		{
			return default(LiquidPlacement);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E6A")]
		[Cpp2IlInjected.Address(RVA = "0x1499164", Offset = "0x1499164", VA = "0x1499164")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005CC")]
	public LiquidPlacement LavaPlacement
	{
		[Cpp2IlInjected.Token(Token = "0x6002E6B")]
		[Cpp2IlInjected.Address(RVA = "0x149B4C4", Offset = "0x149B4C4", VA = "0x149B4C4")]
		get
		{
			return default(LiquidPlacement);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E6C")]
		[Cpp2IlInjected.Address(RVA = "0x1499268", Offset = "0x1499268", VA = "0x1499268")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005CD")]
	public PlacementHook HookCheckIfCanPlace
	{
		[Cpp2IlInjected.Token(Token = "0x6002E6D")]
		[Cpp2IlInjected.Address(RVA = "0x149B53C", Offset = "0x149B53C", VA = "0x149B53C")]
		get
		{
			return default(PlacementHook);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E6E")]
		[Cpp2IlInjected.Address(RVA = "0x149936C", Offset = "0x149936C", VA = "0x149936C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005CE")]
	public PlacementHook HookPostPlaceEveryone
	{
		[Cpp2IlInjected.Token(Token = "0x6002E6F")]
		[Cpp2IlInjected.Address(RVA = "0x149B5C0", Offset = "0x149B5C0", VA = "0x149B5C0")]
		get
		{
			return default(PlacementHook);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E70")]
		[Cpp2IlInjected.Address(RVA = "0x1499420", Offset = "0x1499420", VA = "0x1499420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005CF")]
	public PlacementHook HookPostPlaceMyPlayer
	{
		[Cpp2IlInjected.Token(Token = "0x6002E71")]
		[Cpp2IlInjected.Address(RVA = "0x149B644", Offset = "0x149B644", VA = "0x149B644")]
		get
		{
			return default(PlacementHook);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E72")]
		[Cpp2IlInjected.Address(RVA = "0x14994D4", Offset = "0x14994D4", VA = "0x14994D4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005D0")]
	public PlacementHook HookPlaceOverride
	{
		[Cpp2IlInjected.Token(Token = "0x6002E73")]
		[Cpp2IlInjected.Address(RVA = "0x149B6C8", Offset = "0x149B6C8", VA = "0x149B6C8")]
		get
		{
			return default(PlacementHook);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E74")]
		[Cpp2IlInjected.Address(RVA = "0x1499588", Offset = "0x1499588", VA = "0x1499588")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005D1")]
	private List<TileObjectData> SubTiles
	{
		[Cpp2IlInjected.Token(Token = "0x6002E75")]
		[Cpp2IlInjected.Address(RVA = "0x149B74C", Offset = "0x149B74C", VA = "0x149B74C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E76")]
		[Cpp2IlInjected.Address(RVA = "0x149963C", Offset = "0x149963C", VA = "0x149963C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005D2")]
	public int DrawYOffset
	{
		[Cpp2IlInjected.Token(Token = "0x6002E77")]
		[Cpp2IlInjected.Address(RVA = "0x149B7C4", Offset = "0x149B7C4", VA = "0x149B7C4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E78")]
		[Cpp2IlInjected.Address(RVA = "0x149A2F8", Offset = "0x149A2F8", VA = "0x149A2F8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005D3")]
	public int DrawXOffset
	{
		[Cpp2IlInjected.Token(Token = "0x6002E79")]
		[Cpp2IlInjected.Address(RVA = "0x149B7D8", Offset = "0x149B7D8", VA = "0x149B7D8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E7A")]
		[Cpp2IlInjected.Address(RVA = "0x149B7EC", Offset = "0x149B7EC", VA = "0x149B7EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005D4")]
	public bool DrawFlipHorizontal
	{
		[Cpp2IlInjected.Token(Token = "0x6002E7B")]
		[Cpp2IlInjected.Address(RVA = "0x149B8F0", Offset = "0x149B8F0", VA = "0x149B8F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E7C")]
		[Cpp2IlInjected.Address(RVA = "0x149A3FC", Offset = "0x149A3FC", VA = "0x149A3FC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005D5")]
	public bool DrawFlipVertical
	{
		[Cpp2IlInjected.Token(Token = "0x6002E7D")]
		[Cpp2IlInjected.Address(RVA = "0x149B904", Offset = "0x149B904", VA = "0x149B904")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E7E")]
		[Cpp2IlInjected.Address(RVA = "0x149A50C", Offset = "0x149A50C", VA = "0x149A50C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005D6")]
	public int DrawStepDown
	{
		[Cpp2IlInjected.Token(Token = "0x6002E7F")]
		[Cpp2IlInjected.Address(RVA = "0x149B918", Offset = "0x149B918", VA = "0x149B918")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E80")]
		[Cpp2IlInjected.Address(RVA = "0x149A61C", Offset = "0x149A61C", VA = "0x149A61C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005D7")]
	public bool StyleHorizontal
	{
		[Cpp2IlInjected.Token(Token = "0x6002E81")]
		[Cpp2IlInjected.Address(RVA = "0x149B92C", Offset = "0x149B92C", VA = "0x149B92C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E82")]
		[Cpp2IlInjected.Address(RVA = "0x149A824", Offset = "0x149A824", VA = "0x149A824")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005D8")]
	public int Style
	{
		[Cpp2IlInjected.Token(Token = "0x6002E83")]
		[Cpp2IlInjected.Address(RVA = "0x149B940", Offset = "0x149B940", VA = "0x149B940")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E84")]
		[Cpp2IlInjected.Address(RVA = "0x149A720", Offset = "0x149A720", VA = "0x149A720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005D9")]
	public int StyleWrapLimit
	{
		[Cpp2IlInjected.Token(Token = "0x6002E85")]
		[Cpp2IlInjected.Address(RVA = "0x149B9B8", Offset = "0x149B9B8", VA = "0x149B9B8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E86")]
		[Cpp2IlInjected.Address(RVA = "0x149A934", Offset = "0x149A934", VA = "0x149A934")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005DA")]
	public int? StyleWrapLimitVisualOverride
	{
		[Cpp2IlInjected.Token(Token = "0x6002E87")]
		[Cpp2IlInjected.Address(RVA = "0x149BA30", Offset = "0x149BA30", VA = "0x149BA30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E88")]
		[Cpp2IlInjected.Address(RVA = "0x149BAB8", Offset = "0x149BAB8", VA = "0x149BAB8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005DB")]
	public int? styleLineSkipVisualOverride
	{
		[Cpp2IlInjected.Token(Token = "0x6002E89")]
		[Cpp2IlInjected.Address(RVA = "0x149BBE8", Offset = "0x149BBE8", VA = "0x149BBE8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E8A")]
		[Cpp2IlInjected.Address(RVA = "0x149BC70", Offset = "0x149BC70", VA = "0x149BC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005DC")]
	public int StyleLineSkip
	{
		[Cpp2IlInjected.Token(Token = "0x6002E8B")]
		[Cpp2IlInjected.Address(RVA = "0x149BDA0", Offset = "0x149BDA0", VA = "0x149BDA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E8C")]
		[Cpp2IlInjected.Address(RVA = "0x149BE18", Offset = "0x149BE18", VA = "0x149BE18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005DD")]
	public int StyleMultiplier
	{
		[Cpp2IlInjected.Token(Token = "0x6002E8D")]
		[Cpp2IlInjected.Address(RVA = "0x149BF1C", Offset = "0x149BF1C", VA = "0x149BF1C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E8E")]
		[Cpp2IlInjected.Address(RVA = "0x149AA38", Offset = "0x149AA38", VA = "0x149AA38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005DE")]
	public int Width
	{
		[Cpp2IlInjected.Token(Token = "0x6002E8F")]
		[Cpp2IlInjected.Address(RVA = "0x149AC28", Offset = "0x149AC28", VA = "0x149AC28")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E90")]
		[Cpp2IlInjected.Address(RVA = "0x14996D0", Offset = "0x14996D0", VA = "0x14996D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005DF")]
	public int Height
	{
		[Cpp2IlInjected.Token(Token = "0x6002E91")]
		[Cpp2IlInjected.Address(RVA = "0x149BF94", Offset = "0x149BF94", VA = "0x149BF94")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E92")]
		[Cpp2IlInjected.Address(RVA = "0x1499820", Offset = "0x1499820", VA = "0x1499820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005E0")]
	public Point16 Origin
	{
		[Cpp2IlInjected.Token(Token = "0x6002E93")]
		[Cpp2IlInjected.Address(RVA = "0x149C00C", Offset = "0x149C00C", VA = "0x149C00C")]
		get
		{
			return default(Point16);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E94")]
		[Cpp2IlInjected.Address(RVA = "0x1499970", Offset = "0x1499970", VA = "0x1499970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005E1")]
	public TileObjectDirection Direction
	{
		[Cpp2IlInjected.Token(Token = "0x6002E95")]
		[Cpp2IlInjected.Address(RVA = "0x149C084", Offset = "0x149C084", VA = "0x149C084")]
		get
		{
			return default(TileObjectDirection);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E96")]
		[Cpp2IlInjected.Address(RVA = "0x1499AAC", Offset = "0x1499AAC", VA = "0x1499AAC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005E2")]
	public int RandomStyleRange
	{
		[Cpp2IlInjected.Token(Token = "0x6002E97")]
		[Cpp2IlInjected.Address(RVA = "0x149C0FC", Offset = "0x149C0FC", VA = "0x149C0FC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E98")]
		[Cpp2IlInjected.Address(RVA = "0x1499BB0", Offset = "0x1499BB0", VA = "0x1499BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005E3")]
	public int[] SpecificRandomStyles
	{
		[Cpp2IlInjected.Token(Token = "0x6002E99")]
		[Cpp2IlInjected.Address(RVA = "0x149C174", Offset = "0x149C174", VA = "0x149C174")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E9A")]
		[Cpp2IlInjected.Address(RVA = "0x149C1EC", Offset = "0x149C1EC", VA = "0x149C1EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005E4")]
	public bool FlattenAnchors
	{
		[Cpp2IlInjected.Token(Token = "0x6002E9B")]
		[Cpp2IlInjected.Address(RVA = "0x149C2F0", Offset = "0x149C2F0", VA = "0x149C2F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002E9C")]
		[Cpp2IlInjected.Address(RVA = "0x1499CB4", Offset = "0x1499CB4", VA = "0x1499CB4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005E5")]
	public int[] CoordinateHeights
	{
		[Cpp2IlInjected.Token(Token = "0x6002E9D")]
		[Cpp2IlInjected.Address(RVA = "0x149C368", Offset = "0x149C368", VA = "0x149C368")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002E9E")]
		[Cpp2IlInjected.Address(RVA = "0x1499DC4", Offset = "0x1499DC4", VA = "0x1499DC4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005E6")]
	public int CoordinateWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6002E9F")]
		[Cpp2IlInjected.Address(RVA = "0x149C3E0", Offset = "0x149C3E0", VA = "0x149C3E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002EA0")]
		[Cpp2IlInjected.Address(RVA = "0x1499F84", Offset = "0x1499F84", VA = "0x1499F84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005E7")]
	public int CoordinatePadding
	{
		[Cpp2IlInjected.Token(Token = "0x6002EA1")]
		[Cpp2IlInjected.Address(RVA = "0x149C458", Offset = "0x149C458", VA = "0x149C458")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002EA2")]
		[Cpp2IlInjected.Address(RVA = "0x149A098", Offset = "0x149A098", VA = "0x149A098")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005E8")]
	public Point16 CoordinatePaddingFix
	{
		[Cpp2IlInjected.Token(Token = "0x6002EA3")]
		[Cpp2IlInjected.Address(RVA = "0x149C4D0", Offset = "0x149C4D0", VA = "0x149C4D0")]
		get
		{
			return default(Point16);
		}
		[Cpp2IlInjected.Token(Token = "0x6002EA4")]
		[Cpp2IlInjected.Address(RVA = "0x149A1AC", Offset = "0x149A1AC", VA = "0x149A1AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005E9")]
	public int CoordinateFullWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6002EA5")]
		[Cpp2IlInjected.Address(RVA = "0x149C548", Offset = "0x149C548", VA = "0x149C548")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005EA")]
	public int CoordinateFullHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6002EA6")]
		[Cpp2IlInjected.Address(RVA = "0x149C5D8", Offset = "0x149C5D8", VA = "0x149C5D8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005EB")]
	public int DrawStyleOffset
	{
		[Cpp2IlInjected.Token(Token = "0x6002EA7")]
		[Cpp2IlInjected.Address(RVA = "0x149C668", Offset = "0x149C668", VA = "0x149C668")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002EA8")]
		[Cpp2IlInjected.Address(RVA = "0x149C6E0", Offset = "0x149C6E0", VA = "0x149C6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005EC")]
	public int AlternatesCount
	{
		[Cpp2IlInjected.Token(Token = "0x6002EAA")]
		[Cpp2IlInjected.Address(RVA = "0x149C918", Offset = "0x149C918", VA = "0x149C918")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002E45")]
	[Cpp2IlInjected.Address(RVA = "0x1497900", Offset = "0x1497900", VA = "0x1497900")]
	public TileObjectData([Optional] TileObjectData copyFrom)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E46")]
	[Cpp2IlInjected.Address(RVA = "0x1497960", Offset = "0x1497960", VA = "0x1497960")]
	public void CopyFrom(TileObjectData copy)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E47")]
	[Cpp2IlInjected.Address(RVA = "0x14979C4", Offset = "0x14979C4", VA = "0x14979C4")]
	public void FullCopyFrom(ushort tileType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E48")]
	[Cpp2IlInjected.Address(RVA = "0x1497BA4", Offset = "0x1497BA4", VA = "0x1497BA4")]
	public void FullCopyFrom(TileObjectData copy)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E49")]
	[Cpp2IlInjected.Address(RVA = "0x1497C84", Offset = "0x1497C84", VA = "0x1497C84")]
	private void SetupBaseObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E4A")]
	[Cpp2IlInjected.Address(RVA = "0x149AB3C", Offset = "0x149AB3C", VA = "0x149AB3C")]
	private void Calculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E4B")]
	[Cpp2IlInjected.Address(RVA = "0x149ACA0", Offset = "0x149ACA0", VA = "0x149ACA0")]
	private void WriteCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002E4C")]
	[Cpp2IlInjected.Address(RVA = "0x149AD4C", Offset = "0x149AD4C", VA = "0x149AD4C")]
	private void LockWrites()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EA9")]
	[Cpp2IlInjected.Address(RVA = "0x149C7F4", Offset = "0x149C7F4", VA = "0x149C7F4")]
	public bool LiquidPlace(Tile checkTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EAB")]
	[Cpp2IlInjected.Address(RVA = "0x149C968", Offset = "0x149C968", VA = "0x149C968")]
	public bool isValidTileAnchor(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EAC")]
	[Cpp2IlInjected.Address(RVA = "0x149C9F8", Offset = "0x149C9F8", VA = "0x149C9F8")]
	public bool isValidWallAnchor(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EAD")]
	[Cpp2IlInjected.Address(RVA = "0x149CA54", Offset = "0x149CA54", VA = "0x149CA54")]
	public bool isValidAlternateAnchor(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EAE")]
	[Cpp2IlInjected.Address(RVA = "0x149CAA8", Offset = "0x149CAA8", VA = "0x149CAA8")]
	public int CalculatePlacementStyle(int style, int alternate, int random)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EAF")]
	[Cpp2IlInjected.Address(RVA = "0x149CADC", Offset = "0x149CADC", VA = "0x149CADC")]
	private static void addBaseTile(out TileObjectData baseTile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EB0")]
	[Cpp2IlInjected.Address(RVA = "0x149CB80", Offset = "0x149CB80", VA = "0x149CB80")]
	private static void addTile(int tileType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EB1")]
	[Cpp2IlInjected.Address(RVA = "0x149CC30", Offset = "0x149CC30", VA = "0x149CC30")]
	private static void addSubTile(params int[] styles)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EB2")]
	[Cpp2IlInjected.Address(RVA = "0x149CDBC", Offset = "0x149CDBC", VA = "0x149CDBC")]
	private static void addSubTile(int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EB3")]
	[Cpp2IlInjected.Address(RVA = "0x149CF1C", Offset = "0x149CF1C", VA = "0x149CF1C")]
	private static void addAlternate(int baseStyle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EB4")]
	[Cpp2IlInjected.Address(RVA = "0x149D04C", Offset = "0x149D04C", VA = "0x149D04C")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EB5")]
	[Cpp2IlInjected.Address(RVA = "0x14AB5B0", Offset = "0x14AB5B0", VA = "0x14AB5B0")]
	public static bool CustomPlace(int type, int style)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EB6")]
	[Cpp2IlInjected.Address(RVA = "0x14AB6A8", Offset = "0x14AB6A8", VA = "0x14AB6A8")]
	public static bool CheckLiquidPlacement(int type, int style, Tile checkTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EB7")]
	[Cpp2IlInjected.Address(RVA = "0x14AB6E4", Offset = "0x14AB6E4", VA = "0x14AB6E4")]
	public static bool LiquidPlace(int type, Tile checkTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EB8")]
	[Cpp2IlInjected.Address(RVA = "0x14AB800", Offset = "0x14AB800", VA = "0x14AB800")]
	public static bool CheckWaterDeath(int type, int style)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EB9")]
	[Cpp2IlInjected.Address(RVA = "0x14AB8A8", Offset = "0x14AB8A8", VA = "0x14AB8A8")]
	public static bool CheckWaterDeath(Tile checkTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EBA")]
	[Cpp2IlInjected.Address(RVA = "0x14ABCB0", Offset = "0x14ABCB0", VA = "0x14ABCB0")]
	public static bool CheckLavaDeath(int type, int style)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EBB")]
	[Cpp2IlInjected.Address(RVA = "0x14ABD58", Offset = "0x14ABD58", VA = "0x14ABD58")]
	public static bool CheckLavaDeath(Tile checkTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EBC")]
	[Cpp2IlInjected.Address(RVA = "0x14ABE30", Offset = "0x14ABE30", VA = "0x14ABE30")]
	public static int PlatformFrameWidth()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EBD")]
	[Cpp2IlInjected.Address(RVA = "0x14979F0", Offset = "0x14979F0", VA = "0x14979F0")]
	public static TileObjectData GetTileData(int type, int style, int alternate = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EBE")]
	[Cpp2IlInjected.Address(RVA = "0x14AB980", Offset = "0x14AB980", VA = "0x14AB980")]
	public static TileObjectData GetTileData(Tile getTile)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EBF")]
	[Cpp2IlInjected.Address(RVA = "0x14ABEA8", Offset = "0x14ABEA8", VA = "0x14ABEA8")]
	public static void SyncObjectPlacement(int tileX, int tileY, int type, int style, int dir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002EC0")]
	[Cpp2IlInjected.Address(RVA = "0x14ABF90", Offset = "0x14ABF90", VA = "0x14ABF90")]
	public static bool CallPostPlacementPlayerHook(int tileX, int tileY, int type, int style, int dir, int alternate, TileObject data)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EC1")]
	[Cpp2IlInjected.Address(RVA = "0x14AC098", Offset = "0x14AC098", VA = "0x14AC098")]
	public static void OriginToTopLeft(int type, int style, ref Point16 baseCoords)
	{
	}
}
