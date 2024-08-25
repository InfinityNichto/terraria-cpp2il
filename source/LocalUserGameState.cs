using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Achievements;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Golf;
using Terraria.GameContent.UI.BigProgressBar;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Light;
using Terraria.IO;
using Terraria.Map;

[global::Cpp2ILInjected.Token(Token = "0x20002B9")]
public class LocalUserGameState
{
	[global::Cpp2ILInjected.Token(Token = "0x1700018D")]
	public FavoritesFile LocalFavoriteData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001028")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4063C", Offset = "0xA4063C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_LocalFavoriteData", ReturnType = typeof(FavoritesFile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700018E")]
	public WaterfallManager waterfallManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001029")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40760", Offset = "0xA40760", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_waterfallManager", ReturnType = typeof(WaterfallManager))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterfallManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600102A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA407C4", Offset = "0xA407C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700018F")]
	public LightingEngine NewEngine
	{
		[global::Cpp2ILInjected.Token(Token = "0x600102B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA407CC", Offset = "0xA407CC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "get_NewEngine", ReturnType = typeof(LightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000190")]
	public LegacyLighting LegacyEngine
	{
		[global::Cpp2ILInjected.Token(Token = "0x600102C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40830", Offset = "0xA40830", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "get_LegacyEngine", ReturnType = typeof(LegacyLighting))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting), Member = ".ctor", MemberParameters = new object[] { typeof(Camera) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000191")]
	public ILightingEngine _activeEngine
	{
		[global::Cpp2ILInjected.Token(Token = "0x600102D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA408CC", Offset = "0xA408CC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserGameState), Member = "get_NewEngine", ReturnType = typeof(LightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserGameState), Member = "get_LegacyEngine", ReturnType = typeof(LegacyLighting))]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600102E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40904", Offset = "0xA40904", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600102F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3D9D0", Offset = "0xA3D9D0", Length = "0xAA4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectPreviewData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemShopSellbackHelper), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigProgressBarSystem), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, bool>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DroneCameraTracker), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersPack), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindGrid), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = ".ctor", MemberParameters = new object[] { "System.Func`1<T>" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 91)]
	public LocalUserGameState()
	{
		throw null;
	}

	[ThreadStatic]
	[global::Cpp2ILInjected.Token(Token = "0x4001DBE")]
	public static LocalUserGameState Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001DBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public AchievementManager _achievements;

	[global::Cpp2ILInjected.Token(Token = "0x4001DC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public CreativePowerManager CreativePowerManager;

	[global::Cpp2ILInjected.Token(Token = "0x4001DC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool CreativePowerManager_initialized;

	[global::Cpp2ILInjected.Token(Token = "0x4001DC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
	public bool SwapBumpersTriggers;

	[global::Cpp2ILInjected.Token(Token = "0x4001DC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public object MapHelperIOLock;

	[global::Cpp2ILInjected.Token(Token = "0x4001DC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float ScrollSensitivity;

	[global::Cpp2ILInjected.Token(Token = "0x4001DC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public LockOnHelperStaticData LockOnHelperStaticData;

	[global::Cpp2ILInjected.Token(Token = "0x4001DC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TileObjectPreviewData objectPreview;

	[global::Cpp2ILInjected.Token(Token = "0x4001DC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public bool flushLighting;

	[global::Cpp2ILInjected.Token(Token = "0x4001DC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public MinimapFrame ActiveMinimapFrame;

	[global::Cpp2ILInjected.Token(Token = "0x4001DC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public IPlayerResourcesDisplaySet ActivePlayerResourcesSet;

	[global::Cpp2ILInjected.Token(Token = "0x4001DCA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public int mapDelay;

	[global::Cpp2ILInjected.Token(Token = "0x4001DCB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public bool InReforgeMenu;

	[global::Cpp2ILInjected.Token(Token = "0x4001DCC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x65")]
	public bool InGuideCraftMenu;

	[global::Cpp2ILInjected.Token(Token = "0x4001DCD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x66")]
	public bool anglerQuestFinished;

	[global::Cpp2ILInjected.Token(Token = "0x4001DCE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x67")]
	public bool HoveringOverAnNPC;

	[global::Cpp2ILInjected.Token(Token = "0x4001DCF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public int currentNPCShowingChatBubble;

	[global::Cpp2ILInjected.Token(Token = "0x4001DD0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public float hBar;

	[global::Cpp2ILInjected.Token(Token = "0x4001DD1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public float sBar;

	[global::Cpp2ILInjected.Token(Token = "0x4001DD2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public float lBar;

	[global::Cpp2ILInjected.Token(Token = "0x4001DD3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public float aBar;

	[global::Cpp2ILInjected.Token(Token = "0x4001DD4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public int mouseNPCIndex;

	[global::Cpp2ILInjected.Token(Token = "0x4001DD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public int mouseNPCType;

	[global::Cpp2ILInjected.Token(Token = "0x4001DD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public int firstTileX;

	[global::Cpp2ILInjected.Token(Token = "0x4001DD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public int lastTileX;

	[global::Cpp2ILInjected.Token(Token = "0x4001DD8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public int firstTileY;

	[global::Cpp2ILInjected.Token(Token = "0x4001DD9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public int lastTileY;

	[global::Cpp2ILInjected.Token(Token = "0x4001DDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public int rare;

	[global::Cpp2ILInjected.Token(Token = "0x4001DDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public int hairStart;

	[global::Cpp2ILInjected.Token(Token = "0x4001DDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	public int oldHairStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4001DDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Color oldHairColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001DDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public int selClothes;

	[global::Cpp2ILInjected.Token(Token = "0x4001DDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Color[] oldClothesColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001DE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public int oldClothesStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4001DE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public int interactedDresserTopLeftX;

	[global::Cpp2ILInjected.Token(Token = "0x4001DE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public int interactedDresserTopLeftY;

	[global::Cpp2ILInjected.Token(Token = "0x4001DE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public Vector2 _itemIconCacheScreenPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001DE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public int _itemIconCacheSelectedItemID;

	[global::Cpp2ILInjected.Token(Token = "0x4001DE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public int _itemIconCacheTime;

	[global::Cpp2ILInjected.Token(Token = "0x4001DE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Player dresserInterfaceDummy;

	[global::Cpp2ILInjected.Token(Token = "0x4001DE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Color selColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001DE8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	public int waterStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4001DE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public bool drewLava;

	[global::Cpp2ILInjected.Token(Token = "0x4001DEA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public float[] liquidAlpha;

	[global::Cpp2ILInjected.Token(Token = "0x4001DEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public int[] activeLiquidAlpha;

	[global::Cpp2ILInjected.Token(Token = "0x4001DEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public int numActiveLiquidAlpha;

	[global::Cpp2ILInjected.Token(Token = "0x4001DED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	public bool SettingsUnlock_WorldEvil;

	[global::Cpp2ILInjected.Token(Token = "0x4001DEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFD")]
	public bool SettingsEnabled_MinersWobble;

	[global::Cpp2ILInjected.Token(Token = "0x4001DEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFE")]
	public bool SettingBlockGamepadsEntirely;

	[global::Cpp2ILInjected.Token(Token = "0x4001DF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFF")]
	public bool SettingDontScaleMainMenuUp;

	[global::Cpp2ILInjected.Token(Token = "0x4001DF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public bool SettingsEnabled_OpaqueBoxBehindTooltips;

	[global::Cpp2ILInjected.Token(Token = "0x4001DF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
	public int tooltipTime;

	[global::Cpp2ILInjected.Token(Token = "0x4001DF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public int inventoryTooltipTime;

	[global::Cpp2ILInjected.Token(Token = "0x4001DF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
	public bool SettingMusicReplayDelayEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4001DF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10D")]
	public bool MouseShowBuildingGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001DF6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public float MouseBuildingGridAlpha;

	[global::Cpp2ILInjected.Token(Token = "0x4001DF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
	public float GraveyardVisualIntensity;

	[global::Cpp2ILInjected.Token(Token = "0x4001DF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public bool ScreenPostProcessor_Enabled;

	[global::Cpp2ILInjected.Token(Token = "0x4001DF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public List<ScreenPostProcessor> ScreenPostProcessor_Instances;

	[global::Cpp2ILInjected.Token(Token = "0x4001DFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public List<ScreenPostProcessor> ScreenPostProcessor_UIInstances;

	[global::Cpp2ILInjected.Token(Token = "0x4001DFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public List<Filter> ScreenPostProcessor_Filters;

	[global::Cpp2ILInjected.Token(Token = "0x4001DFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public int ScreenPostProcessor_countUpdate;

	[global::Cpp2ILInjected.Token(Token = "0x4001DFD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x13C")]
	public int ScreenPostProcessor_renderCheck;

	[global::Cpp2ILInjected.Token(Token = "0x4001DFE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public ItemShopSellbackHelper shopSellbackHelper;

	[global::Cpp2ILInjected.Token(Token = "0x4001DFF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Chest[] shop;

	[global::Cpp2ILInjected.Token(Token = "0x4001E00")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public int npcChatCornerItem;

	[global::Cpp2ILInjected.Token(Token = "0x4001E01")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
	public int npcShop;

	[global::Cpp2ILInjected.Token(Token = "0x4001E02")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public bool npcChatFocus1;

	[global::Cpp2ILInjected.Token(Token = "0x4001E03")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x159")]
	public bool npcChatFocus2;

	[global::Cpp2ILInjected.Token(Token = "0x4001E04")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15A")]
	public bool npcChatFocus3;

	[global::Cpp2ILInjected.Token(Token = "0x4001E05")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15B")]
	public bool npcChatFocus4;

	[global::Cpp2ILInjected.Token(Token = "0x4001E06")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public string npcChatText;

	[global::Cpp2ILInjected.Token(Token = "0x4001E07")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public string defaultChestName;

	[global::Cpp2ILInjected.Token(Token = "0x4001E08")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public string blockKey;

	[global::Cpp2ILInjected.Token(Token = "0x4001E09")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public bool blockInput;

	[global::Cpp2ILInjected.Token(Token = "0x4001E0A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public string _savePath;

	[global::Cpp2ILInjected.Token(Token = "0x4001E0B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public string _oldSavePath;

	[global::Cpp2ILInjected.Token(Token = "0x4001E0C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public bool StateInitialised;

	[global::Cpp2ILInjected.Token(Token = "0x4001E0D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public Camera Camera;

	[global::Cpp2ILInjected.Token(Token = "0x4001E0E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public FavoritesFile _localFavoriteData;

	[global::Cpp2ILInjected.Token(Token = "0x4001E0F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public Preferences _configuration;

	[global::Cpp2ILInjected.Token(Token = "0x4001E10")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public Preferences _inputProfiles;

	[global::Cpp2ILInjected.Token(Token = "0x4001E11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public WorldSections sectionManager;

	[global::Cpp2ILInjected.Token(Token = "0x4001E12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public BigProgressBarSystem BigBossProgressBar;

	[global::Cpp2ILInjected.Token(Token = "0x4001E13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public float hellBlackBoxBottom;

	[global::Cpp2ILInjected.Token(Token = "0x4001E14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public int[] backTexture;

	[global::Cpp2ILInjected.Token(Token = "0x4001E15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public int[] oldBackTexture;

	[global::Cpp2ILInjected.Token(Token = "0x4001E16")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public Texture2D[] backTextureValues;

	[global::Cpp2ILInjected.Token(Token = "0x4001E17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public Texture2D[] oldBackTextureValues;

	[global::Cpp2ILInjected.Token(Token = "0x4001E18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public FileMetadata MapFileMetadata;

	[global::Cpp2ILInjected.Token(Token = "0x4001E19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public Main.MouseTextCache _mouseTextCache;

	[global::Cpp2ILInjected.Token(Token = "0x4001E1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
	private WaterfallManager _waterfallManager;

	[global::Cpp2ILInjected.Token(Token = "0x4001E1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
	public Rain[] rain;

	[global::Cpp2ILInjected.Token(Token = "0x4001E1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
	public PopupText[] popupText;

	[global::Cpp2ILInjected.Token(Token = "0x4001E1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
	public int mouseX;

	[global::Cpp2ILInjected.Token(Token = "0x4001E1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x244")]
	public int mouseY;

	[global::Cpp2ILInjected.Token(Token = "0x4001E1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
	public int worldMouseX;

	[global::Cpp2ILInjected.Token(Token = "0x4001E20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24C")]
	public int worldMouseY;

	[global::Cpp2ILInjected.Token(Token = "0x4001E21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
	public int lastMouseX;

	[global::Cpp2ILInjected.Token(Token = "0x4001E22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x254")]
	public int lastMouseY;

	[global::Cpp2ILInjected.Token(Token = "0x4001E23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
	public bool mouseLeft;

	[global::Cpp2ILInjected.Token(Token = "0x4001E24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x259")]
	public bool mouseRight;

	[global::Cpp2ILInjected.Token(Token = "0x4001E25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25A")]
	public bool worldMouseLeft;

	[global::Cpp2ILInjected.Token(Token = "0x4001E26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25B")]
	public bool worldMouseRight;

	[global::Cpp2ILInjected.Token(Token = "0x4001E27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25C")]
	public bool worldMouseLeftRelease;

	[global::Cpp2ILInjected.Token(Token = "0x4001E28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25D")]
	public bool worldMouseRightRelease;

	[global::Cpp2ILInjected.Token(Token = "0x4001E29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25E")]
	public bool isMouseLeftConsumedByUI;

	[global::Cpp2ILInjected.Token(Token = "0x4001E2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25F")]
	public bool hairWindow;

	[global::Cpp2ILInjected.Token(Token = "0x4001E2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
	public bool clothesWindow;

	[global::Cpp2ILInjected.Token(Token = "0x4001E2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x261")]
	public bool ingameOptionsWindow;

	[global::Cpp2ILInjected.Token(Token = "0x4001E2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x262")]
	public bool inFancyUI;

	[global::Cpp2ILInjected.Token(Token = "0x4001E2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x263")]
	public byte gFade;

	[global::Cpp2ILInjected.Token(Token = "0x4001E2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x264")]
	public float gFader;

	[global::Cpp2ILInjected.Token(Token = "0x4001E30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x268")]
	public byte gFadeDir;

	[global::Cpp2ILInjected.Token(Token = "0x4001E31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x26C")]
	public float startScreenYOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001E32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x270")]
	public float targetScreenYOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001E33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x274")]
	public int CameraMovementMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001E34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x278")]
	public float screenYOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001E35")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x27C")]
	public float cameraOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001E36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x280")]
	public Vector2 screenPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001E37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x288")]
	public Vector2 screenLastPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001E38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x290")]
	public int screenWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4001E39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x294")]
	public int screenHeight;

	[global::Cpp2ILInjected.Token(Token = "0x4001E3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x298")]
	public bool mouseLeftRelease;

	[global::Cpp2ILInjected.Token(Token = "0x4001E3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x299")]
	public bool mouseRightRelease;

	[global::Cpp2ILInjected.Token(Token = "0x4001E3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29A")]
	public bool playerInventory;

	[global::Cpp2ILInjected.Token(Token = "0x4001E3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29C")]
	public int stackSplit;

	[global::Cpp2ILInjected.Token(Token = "0x4001E3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A0")]
	public bool preventStackSplitReset;

	[global::Cpp2ILInjected.Token(Token = "0x4001E3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A4")]
	public int stackCounter;

	[global::Cpp2ILInjected.Token(Token = "0x4001E40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A8")]
	public int stackDelay;

	[global::Cpp2ILInjected.Token(Token = "0x4001E41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2AC")]
	public int superFastStack;

	[global::Cpp2ILInjected.Token(Token = "0x4001E42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B0")]
	public int timesTriedToFastStack;

	[global::Cpp2ILInjected.Token(Token = "0x4001E43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
	public Item mouseItem;

	[global::Cpp2ILInjected.Token(Token = "0x4001E44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
	public float mouseItemTime;

	[global::Cpp2ILInjected.Token(Token = "0x4001E45")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C8")]
	public Item[] mouseItemSource;

	[global::Cpp2ILInjected.Token(Token = "0x4001E46")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
	public int mouseItemSourceIndex;

	[global::Cpp2ILInjected.Token(Token = "0x4001E47")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D4")]
	public int mouseItemSourceContext;

	[global::Cpp2ILInjected.Token(Token = "0x4001E48")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D8")]
	public Item guideItem;

	[global::Cpp2ILInjected.Token(Token = "0x4001E49")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
	public Item reforgeItem;

	[global::Cpp2ILInjected.Token(Token = "0x4001E4A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E8")]
	public float inventoryScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001E4B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2EC")]
	public Point rulerLineDisplayValues;

	[global::Cpp2ILInjected.Token(Token = "0x4001E4C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F8")]
	public int[] availableRecipe;

	[global::Cpp2ILInjected.Token(Token = "0x4001E4D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x300")]
	public int lastRecipeUpdateId;

	[global::Cpp2ILInjected.Token(Token = "0x4001E4E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x304")]
	public int numAvailableRecipes;

	[global::Cpp2ILInjected.Token(Token = "0x4001E4F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x308")]
	public int focusRecipe;

	[global::Cpp2ILInjected.Token(Token = "0x4001E50")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30C")]
	public int myPlayer;

	[global::Cpp2ILInjected.Token(Token = "0x4001E51")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x310")]
	public int spawnTileX;

	[global::Cpp2ILInjected.Token(Token = "0x4001E52")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x314")]
	public int spawnTileY;

	[global::Cpp2ILInjected.Token(Token = "0x4001E53")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x318")]
	public bool npcChatRelease;

	[global::Cpp2ILInjected.Token(Token = "0x4001E54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x319")]
	public bool editSign;

	[global::Cpp2ILInjected.Token(Token = "0x4001E55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31A")]
	public bool editChest;

	[global::Cpp2ILInjected.Token(Token = "0x4001E56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31C")]
	public int oldNPCShop;

	[global::Cpp2ILInjected.Token(Token = "0x4001E57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x320")]
	public bool gameMenu;

	[global::Cpp2ILInjected.Token(Token = "0x4001E58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x324")]
	public int menuMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001E59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x328")]
	public bool Quitting;

	[global::Cpp2ILInjected.Token(Token = "0x4001E5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x330")]
	public List<PlayerFileData> PlayerList;

	[global::Cpp2ILInjected.Token(Token = "0x4001E5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x338")]
	public PlayerFileData ActivePlayerFileData;

	[global::Cpp2ILInjected.Token(Token = "0x4001E5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x340")]
	public Player PendingPlayer;

	[global::Cpp2ILInjected.Token(Token = "0x4001E5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x348")]
	public bool SmartCursorShowing;

	[global::Cpp2ILInjected.Token(Token = "0x4001E5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34C")]
	public int SmartCursorX;

	[global::Cpp2ILInjected.Token(Token = "0x4001E5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x350")]
	public int SmartCursorY;

	[global::Cpp2ILInjected.Token(Token = "0x4001E60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x354")]
	public bool SmartInteractShowingGenuine;

	[global::Cpp2ILInjected.Token(Token = "0x4001E61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x355")]
	public bool SmartInteractShowingFake;

	[global::Cpp2ILInjected.Token(Token = "0x4001E62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x358")]
	public int SmartInteractX;

	[global::Cpp2ILInjected.Token(Token = "0x4001E63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x35C")]
	public int SmartInteractY;

	[global::Cpp2ILInjected.Token(Token = "0x4001E64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x360")]
	public int SmartInteractNPC;

	[global::Cpp2ILInjected.Token(Token = "0x4001E65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x364")]
	public int SmartInteractProj;

	[global::Cpp2ILInjected.Token(Token = "0x4001E66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x368")]
	public bool SmartInteractPotionOfReturn;

	[global::Cpp2ILInjected.Token(Token = "0x4001E67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x370")]
	public Dictionary<int, bool> SmartInteractTileCoords;

	[global::Cpp2ILInjected.Token(Token = "0x4001E68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x378")]
	public Dictionary<int, bool> SmartInteractTileCoordsSelected;

	[global::Cpp2ILInjected.Token(Token = "0x4001E69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x380")]
	public int TileInteractionLX;

	[global::Cpp2ILInjected.Token(Token = "0x4001E6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x384")]
	public int TileInteractionLY;

	[global::Cpp2ILInjected.Token(Token = "0x4001E6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x388")]
	public int TileInteractionHX;

	[global::Cpp2ILInjected.Token(Token = "0x4001E6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38C")]
	public int TileInteractionHY;

	[global::Cpp2ILInjected.Token(Token = "0x4001E6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x390")]
	public int cursorOverride;

	[global::Cpp2ILInjected.Token(Token = "0x4001E6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x394")]
	public int signHover;

	[global::Cpp2ILInjected.Token(Token = "0x4001E6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x398")]
	public int lastSignHover;

	[global::Cpp2ILInjected.Token(Token = "0x4001E70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x39C")]
	public float GamepadCursorAlpha;

	[global::Cpp2ILInjected.Token(Token = "0x4001E71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A0")]
	public int overloadedMousePositionX;

	[global::Cpp2ILInjected.Token(Token = "0x4001E72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A4")]
	public int overloadedMousePositionY;

	[global::Cpp2ILInjected.Token(Token = "0x4001E73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A8")]
	public Color mouseColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001E74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3AC")]
	public Color MouseBorderColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001E75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B0")]
	public Color ControllerColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001E76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B4")]
	public Color ControllerBorderColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001E77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B8")]
	public Color cursorColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001E78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3BC")]
	public int cursorColorDirection;

	[global::Cpp2ILInjected.Token(Token = "0x4001E79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C0")]
	public float cursorAlpha;

	[global::Cpp2ILInjected.Token(Token = "0x4001E7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C4")]
	public float cursorScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001E7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C8")]
	public bool signBubble;

	[global::Cpp2ILInjected.Token(Token = "0x4001E7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3CC")]
	public int signX;

	[global::Cpp2ILInjected.Token(Token = "0x4001E7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D0")]
	public int signY;

	[global::Cpp2ILInjected.Token(Token = "0x4001E7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D4")]
	public bool hideUI;

	[global::Cpp2ILInjected.Token(Token = "0x4001E7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D5")]
	public bool releaseUI;

	[global::Cpp2ILInjected.Token(Token = "0x4001E80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D6")]
	public bool renderNow;

	[global::Cpp2ILInjected.Token(Token = "0x4001E81")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D8")]
	public int renderCount;

	[global::Cpp2ILInjected.Token(Token = "0x4001E82")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3DC")]
	public bool render;

	[global::Cpp2ILInjected.Token(Token = "0x4001E83")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E0")]
	public Stopwatch saveTime;

	[global::Cpp2ILInjected.Token(Token = "0x4001E84")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E8")]
	public bool BackgroundEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4001E85")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F0")]
	public SceneMetrics SceneMetrics;

	[global::Cpp2ILInjected.Token(Token = "0x4001E86")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F8")]
	public int instantBGTransitionCounter;

	[global::Cpp2ILInjected.Token(Token = "0x4001E87")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3FC")]
	public int bgDelay;

	[global::Cpp2ILInjected.Token(Token = "0x4001E88")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x400")]
	public int background;

	[global::Cpp2ILInjected.Token(Token = "0x4001E89")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x404")]
	public int caveBackground;

	[global::Cpp2ILInjected.Token(Token = "0x4001E8A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x408")]
	public GolfState LocalGolfState;

	[global::Cpp2ILInjected.Token(Token = "0x4001E8B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x410")]
	public DroneCameraTracker DroneCameraTracker;

	[global::Cpp2ILInjected.Token(Token = "0x4001E8C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x418")]
	public Vector2 CurrentPan;

	[global::Cpp2ILInjected.Token(Token = "0x4001E8D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x420")]
	public float sunCircle;

	[global::Cpp2ILInjected.Token(Token = "0x4001E8E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x424")]
	public int BlackFadeIn;

	[global::Cpp2ILInjected.Token(Token = "0x4001E8F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x428")]
	public float ugBackTransition;

	[global::Cpp2ILInjected.Token(Token = "0x4001E90")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x42C")]
	public int undergroundBackground;

	[global::Cpp2ILInjected.Token(Token = "0x4001E91")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x430")]
	public int oldUndergroundBackground;

	[global::Cpp2ILInjected.Token(Token = "0x4001E92")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x434")]
	public int bgStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4001E93")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x438")]
	public float[] bgAlphaFrontLayer;

	[global::Cpp2ILInjected.Token(Token = "0x4001E94")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x440")]
	public float[] bgAlphaFarBackLayer;

	[global::Cpp2ILInjected.Token(Token = "0x4001E95")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x448")]
	public int[] bgFrame;

	[global::Cpp2ILInjected.Token(Token = "0x4001E96")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x450")]
	public int[] bgFrameCounter;

	[global::Cpp2ILInjected.Token(Token = "0x4001E97")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x458")]
	public bool mapEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4001E98")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x45C")]
	public int invasionProgressMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001E99")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x460")]
	public bool invasionProgressNearInvasion;

	[global::Cpp2ILInjected.Token(Token = "0x4001E9A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x461")]
	public bool placementPreview;

	[global::Cpp2ILInjected.Token(Token = "0x4001E9B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x462")]
	public bool autoSave;

	[global::Cpp2ILInjected.Token(Token = "0x4001E9C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x464")]
	public Main.AutoPauseMode autoPause;

	[global::Cpp2ILInjected.Token(Token = "0x4001E9D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x468")]
	public bool DisableIntenseVisualEffects;

	[global::Cpp2ILInjected.Token(Token = "0x4001E9E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x46C")]
	public int WaveQuality;

	[global::Cpp2ILInjected.Token(Token = "0x4001E9F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x470")]
	public bool UseStormEffects;

	[global::Cpp2ILInjected.Token(Token = "0x4001EA0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x471")]
	public bool UseHeatDistortion;

	[global::Cpp2ILInjected.Token(Token = "0x4001EA1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x474")]
	public float musicVolume;

	[global::Cpp2ILInjected.Token(Token = "0x4001EA2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x478")]
	public float ambientVolume;

	[global::Cpp2ILInjected.Token(Token = "0x4001EA3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x47C")]
	public float soundVolume;

	[global::Cpp2ILInjected.Token(Token = "0x4001EA4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x480")]
	public bool TOWMusicUnlocked;

	[global::Cpp2ILInjected.Token(Token = "0x4001EA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x484")]
	public int qaStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4001EA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x488")]
	public float caveParallax;

	[global::Cpp2ILInjected.Token(Token = "0x4001EA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48C")]
	public int bgScroll;

	[global::Cpp2ILInjected.Token(Token = "0x4001EA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x490")]
	public bool showItemText;

	[global::Cpp2ILInjected.Token(Token = "0x4001EA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x491")]
	public bool HidePassword;

	[global::Cpp2ILInjected.Token(Token = "0x4001EAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x492")]
	public bool ReversedUpDownArmorSetBonuses;

	[global::Cpp2ILInjected.Token(Token = "0x4001EAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x493")]
	public bool SettingsEnabled_TilesSwayInWind;

	[global::Cpp2ILInjected.Token(Token = "0x4001EAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x494")]
	public bool cSmartCursorModeIsToggleAndNotHold;

	[global::Cpp2ILInjected.Token(Token = "0x4001EAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x498")]
	public float gfxQuality;

	[global::Cpp2ILInjected.Token(Token = "0x4001EAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x49C")]
	public float gfxRate;

	[global::Cpp2ILInjected.Token(Token = "0x4001EAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A0")]
	public int teamCooldown;

	[global::Cpp2ILInjected.Token(Token = "0x4001EB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A4")]
	public bool showFrameRate;

	[global::Cpp2ILInjected.Token(Token = "0x4001EB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A5")]
	public bool SettingsSavePending;

	[global::Cpp2ILInjected.Token(Token = "0x4001EB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A8")]
	public WorldMap Map;

	[global::Cpp2ILInjected.Token(Token = "0x4001EB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B0")]
	public bool refreshMap;

	[global::Cpp2ILInjected.Token(Token = "0x4001EB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B4")]
	public int loadMapLastX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B8")]
	public bool loadMapLock;

	[global::Cpp2ILInjected.Token(Token = "0x4001EB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B9")]
	public bool loadMap;

	[global::Cpp2ILInjected.Token(Token = "0x4001EB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4BA")]
	public bool loadMapSections;

	[global::Cpp2ILInjected.Token(Token = "0x4001EB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4BB")]
	public bool mapReady;

	[global::Cpp2ILInjected.Token(Token = "0x4001EB9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4BC")]
	public bool updateMap;

	[global::Cpp2ILInjected.Token(Token = "0x4001EBA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C0")]
	public int mapMinX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EBB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C4")]
	public int mapMaxX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EBC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C8")]
	public int mapMinY;

	[global::Cpp2ILInjected.Token(Token = "0x4001EBD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4CC")]
	public int mapMaxY;

	[global::Cpp2ILInjected.Token(Token = "0x4001EBE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D0")]
	public int mapTimeMax;

	[global::Cpp2ILInjected.Token(Token = "0x4001EBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D4")]
	public int mapTime;

	[global::Cpp2ILInjected.Token(Token = "0x4001EC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D8")]
	public bool clearMap;

	[global::Cpp2ILInjected.Token(Token = "0x4001EC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D9")]
	public bool mapInit;

	[global::Cpp2ILInjected.Token(Token = "0x4001EC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4DC")]
	public int mapStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4001EC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E0")]
	public float grabMapX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E4")]
	public float grabMapY;

	[global::Cpp2ILInjected.Token(Token = "0x4001EC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E8")]
	public float grabMapInitialX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4EC")]
	public float grabMapInitialY;

	[global::Cpp2ILInjected.Token(Token = "0x4001EC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F0")]
	public bool grabMapInProgress;

	[global::Cpp2ILInjected.Token(Token = "0x4001EC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F4")]
	public int miniMapX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F8")]
	public int miniMapY;

	[global::Cpp2ILInjected.Token(Token = "0x4001ECA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4FC")]
	public int miniMapWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4001ECB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x500")]
	public int miniMapHeight;

	[global::Cpp2ILInjected.Token(Token = "0x4001ECC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x504")]
	public float mapMinimapScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001ECD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x508")]
	public float mapMinimapAlpha;

	[global::Cpp2ILInjected.Token(Token = "0x4001ECE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50C")]
	public float mapOverlayScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001ECF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x510")]
	public float mapOverlayAlpha;

	[global::Cpp2ILInjected.Token(Token = "0x4001ED0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x514")]
	public bool mapFullscreen;

	[global::Cpp2ILInjected.Token(Token = "0x4001ED1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x515")]
	public bool resetMapFull;

	[global::Cpp2ILInjected.Token(Token = "0x4001ED2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x518")]
	public int resetMapFullCharacter;

	[global::Cpp2ILInjected.Token(Token = "0x4001ED3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x51C")]
	public float mapFullscreenScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001ED4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x520")]
	public Vector2 mapFullscreenPos;

	[global::Cpp2ILInjected.Token(Token = "0x4001ED5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x528")]
	public bool _MouseOversCanClear;

	[global::Cpp2ILInjected.Token(Token = "0x4001ED6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x530")]
	public TriggersPack Triggers;

	[global::Cpp2ILInjected.Token(Token = "0x4001ED7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x538")]
	public MouseState MouseInfo;

	[global::Cpp2ILInjected.Token(Token = "0x4001ED8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x55C")]
	public MouseState MouseInfoOld;

	[global::Cpp2ILInjected.Token(Token = "0x4001ED9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x580")]
	public int MouseX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x584")]
	public int MouseY;

	[global::Cpp2ILInjected.Token(Token = "0x4001EDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x588")]
	public bool LockGamepadTileUseButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001EDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58C")]
	public int PreUIX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x590")]
	public int PreUIY;

	[global::Cpp2ILInjected.Token(Token = "0x4001EDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x594")]
	public int PreLockOnX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x598")]
	public int PreLockOnY;

	[global::Cpp2ILInjected.Token(Token = "0x4001EE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x59C")]
	public int ScrollWheelValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001EE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A0")]
	public int ScrollWheelValueOld;

	[global::Cpp2ILInjected.Token(Token = "0x4001EE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A4")]
	public int ScrollWheelDelta;

	[global::Cpp2ILInjected.Token(Token = "0x4001EE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A8")]
	public int taxRate;

	[global::Cpp2ILInjected.Token(Token = "0x4001EE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5AC")]
	public int tileRangeX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5B0")]
	public int tileRangeY;

	[global::Cpp2ILInjected.Token(Token = "0x4001EE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5B4")]
	public int tileTargetX;

	[global::Cpp2ILInjected.Token(Token = "0x4001EE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5B8")]
	public int tileTargetY;

	[global::Cpp2ILInjected.Token(Token = "0x4001EE8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5BC")]
	public int jumpHeight;

	[global::Cpp2ILInjected.Token(Token = "0x4001EE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C0")]
	public float jumpSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x4001EEA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C4")]
	public int BlockInteractionWithProjectiles;

	[global::Cpp2ILInjected.Token(Token = "0x4001EEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C8")]
	public bool lastPound;

	[global::Cpp2ILInjected.Token(Token = "0x4001EEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5CC")]
	public int musicNotes;

	[global::Cpp2ILInjected.Token(Token = "0x4001EED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D0")]
	public bool SmartBlocksEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4001EEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D1")]
	public bool SmartAxeAfterPickaxe;

	[global::Cpp2ILInjected.Token(Token = "0x4001EEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D8")]
	public int[] _specialsCount;

	[global::Cpp2ILInjected.Token(Token = "0x4001EF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5E0")]
	public Point[][] _specialPositions;

	[global::Cpp2ILInjected.Token(Token = "0x4001EF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5E8")]
	public WindGrid _windGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001EF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5F0")]
	public bool _shouldShowInvisibleBlocks;

	[global::Cpp2ILInjected.Token(Token = "0x4001EF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5F1")]
	public bool _shouldShowInvisibleBlocks_LastFrame;

	[global::Cpp2ILInjected.Token(Token = "0x4001EF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5F8")]
	public ThreadLocal<TileDrawInfo> _currentTileDrawInfo;

	[global::Cpp2ILInjected.Token(Token = "0x4001EF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x600")]
	public LightMode _mode;

	[global::Cpp2ILInjected.Token(Token = "0x4001EF6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x608")]
	private LightingEngine _newEngine;

	[global::Cpp2ILInjected.Token(Token = "0x4001EF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x610")]
	private LegacyLighting _legacyEngine;

	[global::Cpp2ILInjected.Token(Token = "0x4001EF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x618")]
	private ILightingEngine _activeEngineVal;

	[global::Cpp2ILInjected.Token(Token = "0x4001EF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x620")]
	public bool DisableLeftShiftTrashCan;

	[global::Cpp2ILInjected.Token(Token = "0x4001EFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x621")]
	public bool HighlightNewItems;

	[global::Cpp2ILInjected.Token(Token = "0x4001EFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x622")]
	public bool DisableQuickTrash;

	[global::Cpp2ILInjected.Token(Token = "0x4001EFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x623")]
	public bool ChildSafetyDisabled;

	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20002BA")]
	[Serializable]
	private sealed class <>c
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001030")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4090C", Offset = "0xA4090C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static <>c()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001031")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40968", Offset = "0xA40968", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <>c()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001032")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40970", Offset = "0xA40970", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal TileDrawInfo <.ctor>b__331_0()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001EFD")]
		public static readonly LocalUserGameState.<>c <>9;

		[global::Cpp2ILInjected.Token(Token = "0x4001EFE")]
		public static Func<TileDrawInfo> <>9__331_0;
	}
}
