using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cpp2IlInjected;
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

[Cpp2IlInjected.Token(Token = "0x2000214")]
public class LocalUserGameState
{
	[Cpp2IlInjected.Token(Token = "0x400189B")]
	[ThreadStatic]
	public static LocalUserGameState Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400189C")]
	public AchievementManager _achievements;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400189D")]
	public CreativePowerManager CreativePowerManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400189E")]
	public bool CreativePowerManager_initialized;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400189F")]
	public bool SwapBumpersTriggers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40018A0")]
	public object MapHelperIOLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40018A1")]
	public float ScrollSensitivity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40018A2")]
	public LockOnHelperStaticData LockOnHelperStaticData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40018A3")]
	public TileObjectPreviewData objectPreview;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40018A4")]
	public bool flushLighting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40018A5")]
	public MinimapFrame ActiveMinimapFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40018A6")]
	public IPlayerResourcesDisplaySet ActivePlayerResourcesSet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40018A7")]
	public int mapDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40018A8")]
	public bool InReforgeMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x40018A9")]
	public bool InGuideCraftMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x40018AA")]
	public bool anglerQuestFinished;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
	[Cpp2IlInjected.Token(Token = "0x40018AB")]
	public bool HoveringOverAnNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40018AC")]
	public int currentNPCShowingChatBubble;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40018AD")]
	public float hBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40018AE")]
	public float sBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40018AF")]
	public float lBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40018B0")]
	public float aBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40018B1")]
	public int mouseNPCIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40018B2")]
	public int mouseNPCType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40018B3")]
	public int firstTileX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40018B4")]
	public int lastTileX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40018B5")]
	public int firstTileY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40018B6")]
	public int lastTileY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40018B7")]
	public int rare;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40018B8")]
	public int hairStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40018B9")]
	public int oldHairStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40018BA")]
	public Color oldHairColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40018BB")]
	public int selClothes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40018BC")]
	public Color[] oldClothesColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40018BD")]
	public int oldClothesStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40018BE")]
	public int interactedDresserTopLeftX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40018BF")]
	public int interactedDresserTopLeftY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40018C0")]
	public Vector2 _itemIconCacheScreenPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40018C1")]
	public int _itemIconCacheSelectedItemID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40018C2")]
	public int _itemIconCacheTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40018C3")]
	public Player dresserInterfaceDummy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40018C4")]
	public Color selColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40018C5")]
	public int waterStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40018C6")]
	public bool drewLava;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40018C7")]
	public float[] liquidAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40018C8")]
	public int[] activeLiquidAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40018C9")]
	public int numActiveLiquidAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40018CA")]
	public bool SettingsUnlock_WorldEvil;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB5")]
	[Cpp2IlInjected.Token(Token = "0x40018CB")]
	public bool SettingsEnabled_MinersWobble;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB6")]
	[Cpp2IlInjected.Token(Token = "0x40018CC")]
	public bool SettingBlockGamepadsEntirely;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB7")]
	[Cpp2IlInjected.Token(Token = "0x40018CD")]
	public bool SettingDontScaleMainMenuUp;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40018CE")]
	public bool SettingsEnabled_OpaqueBoxBehindTooltips;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40018CF")]
	public int tooltipTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40018D0")]
	public int inventoryTooltipTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40018D1")]
	public bool SettingMusicReplayDelayEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
	[Cpp2IlInjected.Token(Token = "0x40018D2")]
	public bool MouseShowBuildingGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40018D3")]
	public float MouseBuildingGridAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40018D4")]
	public float GraveyardVisualIntensity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40018D5")]
	public bool ScreenPostProcessor_Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40018D6")]
	public List<ScreenPostProcessor> ScreenPostProcessor_Instances;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40018D7")]
	public List<ScreenPostProcessor> ScreenPostProcessor_UIInstances;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40018D8")]
	public List<Filter> ScreenPostProcessor_Filters;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40018D9")]
	public int ScreenPostProcessor_countUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40018DA")]
	public int ScreenPostProcessor_renderCheck;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40018DB")]
	public ItemShopSellbackHelper shopSellbackHelper;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40018DC")]
	public Chest[] shop;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40018DD")]
	public int npcChatCornerItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40018DE")]
	public int npcShop;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40018DF")]
	public bool npcChatFocus1;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF9")]
	[Cpp2IlInjected.Token(Token = "0x40018E0")]
	public bool npcChatFocus2;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFA")]
	[Cpp2IlInjected.Token(Token = "0x40018E1")]
	public bool npcChatFocus3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFB")]
	[Cpp2IlInjected.Token(Token = "0x40018E2")]
	public bool npcChatFocus4;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40018E3")]
	public string npcChatText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40018E4")]
	public string defaultChestName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40018E5")]
	public string blockKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40018E6")]
	public bool blockInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40018E7")]
	public string _savePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40018E8")]
	public string _oldSavePath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40018E9")]
	public bool StateInitialised;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40018EA")]
	public Camera Camera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40018EB")]
	public FavoritesFile _localFavoriteData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40018EC")]
	public Preferences _configuration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40018ED")]
	public Preferences _inputProfiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40018EE")]
	public WorldSections sectionManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40018EF")]
	public BigProgressBarSystem BigBossProgressBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40018F0")]
	public float hellBlackBoxBottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40018F1")]
	public int[] backTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40018F2")]
	public int[] oldBackTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40018F3")]
	public Texture2D[] backTextureValues;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40018F4")]
	public Texture2D[] oldBackTextureValues;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40018F5")]
	public FileMetadata MapFileMetadata;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40018F6")]
	public Main.MouseTextCache _mouseTextCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x40018F7")]
	private WaterfallManager _waterfallManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40018F8")]
	public Rain[] rain;

	[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Cpp2IlInjected.Token(Token = "0x40018F9")]
	public PopupText[] popupText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40018FA")]
	public int mouseX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x40018FB")]
	public int mouseY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40018FC")]
	public int worldMouseX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40018FD")]
	public int worldMouseY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40018FE")]
	public int lastMouseX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40018FF")]
	public int lastMouseY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4001900")]
	public bool mouseLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
	[Cpp2IlInjected.Token(Token = "0x4001901")]
	public bool mouseRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x192")]
	[Cpp2IlInjected.Token(Token = "0x4001902")]
	public bool worldMouseLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x193")]
	[Cpp2IlInjected.Token(Token = "0x4001903")]
	public bool worldMouseRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4001904")]
	public bool worldMouseLeftRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x195")]
	[Cpp2IlInjected.Token(Token = "0x4001905")]
	public bool worldMouseRightRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x196")]
	[Cpp2IlInjected.Token(Token = "0x4001906")]
	public bool isMouseLeftConsumedByUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x197")]
	[Cpp2IlInjected.Token(Token = "0x4001907")]
	public bool hairWindow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4001908")]
	public bool clothesWindow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
	[Cpp2IlInjected.Token(Token = "0x4001909")]
	public bool ingameOptionsWindow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19A")]
	[Cpp2IlInjected.Token(Token = "0x400190A")]
	public bool inFancyUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19B")]
	[Cpp2IlInjected.Token(Token = "0x400190B")]
	public byte gFade;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x400190C")]
	public float gFader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400190D")]
	public byte gFadeDir;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400190E")]
	public float startScreenYOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400190F")]
	public float targetScreenYOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4001910")]
	public int CameraMovementMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4001911")]
	public float screenYOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4001912")]
	public float cameraOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4001913")]
	public Vector2 screenPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4001914")]
	public Vector2 screenLastPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4001915")]
	public int screenWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x4001916")]
	public int screenHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4001917")]
	public bool mouseLeftRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D1")]
	[Cpp2IlInjected.Token(Token = "0x4001918")]
	public bool mouseRightRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D2")]
	[Cpp2IlInjected.Token(Token = "0x4001919")]
	public bool playerInventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
	[Cpp2IlInjected.Token(Token = "0x400191A")]
	public int stackSplit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x400191B")]
	public bool preventStackSplitReset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Cpp2IlInjected.Token(Token = "0x400191C")]
	public int stackCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x400191D")]
	public int stackDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
	[Cpp2IlInjected.Token(Token = "0x400191E")]
	public int superFastStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x400191F")]
	public int timesTriedToFastStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
	[Cpp2IlInjected.Token(Token = "0x4001920")]
	public Item mouseItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4001921")]
	public float mouseItemTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
	[Cpp2IlInjected.Token(Token = "0x4001922")]
	public Item[] mouseItemSource;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x4001923")]
	public int mouseItemSourceIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
	[Cpp2IlInjected.Token(Token = "0x4001924")]
	public int mouseItemSourceContext;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x4001925")]
	public Item guideItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x4001926")]
	public Item reforgeItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x4001927")]
	public float inventoryScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
	[Cpp2IlInjected.Token(Token = "0x4001928")]
	public Point rulerLineDisplayValues;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x4001929")]
	public int[] availableRecipe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x400192A")]
	public int lastRecipeUpdateId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
	[Cpp2IlInjected.Token(Token = "0x400192B")]
	public int numAvailableRecipes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x400192C")]
	public int focusRecipe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
	[Cpp2IlInjected.Token(Token = "0x400192D")]
	public int myPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x400192E")]
	public int spawnTileX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x400192F")]
	public int spawnTileY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4001930")]
	public bool npcChatRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x231")]
	[Cpp2IlInjected.Token(Token = "0x4001931")]
	public bool editSign;

	[Cpp2IlInjected.FieldOffset(Offset = "0x232")]
	[Cpp2IlInjected.Token(Token = "0x4001932")]
	public bool editChest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x4001933")]
	public int oldNPCShop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x4001934")]
	public bool gameMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Cpp2IlInjected.Token(Token = "0x4001935")]
	public int menuMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4001936")]
	public bool Quitting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
	[Cpp2IlInjected.Token(Token = "0x4001937")]
	public List<PlayerFileData> PlayerList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4001938")]
	public PlayerFileData ActivePlayerFileData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
	[Cpp2IlInjected.Token(Token = "0x4001939")]
	public Player PendingPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400193A")]
	public bool SmartCursorShowing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
	[Cpp2IlInjected.Token(Token = "0x400193B")]
	public int SmartCursorX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x400193C")]
	public int SmartCursorY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x400193D")]
	public bool SmartInteractShowingGenuine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25D")]
	[Cpp2IlInjected.Token(Token = "0x400193E")]
	public bool SmartInteractShowingFake;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x400193F")]
	public int SmartInteractX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
	[Cpp2IlInjected.Token(Token = "0x4001940")]
	public int SmartInteractY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4001941")]
	public int SmartInteractNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
	[Cpp2IlInjected.Token(Token = "0x4001942")]
	public int SmartInteractProj;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4001943")]
	public bool SmartInteractPotionOfReturn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x4001944")]
	public Dictionary<int, bool> SmartInteractTileCoords;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4001945")]
	public Dictionary<int, bool> SmartInteractTileCoordsSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x4001946")]
	public int TileInteractionLX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4001947")]
	public int TileInteractionLY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x4001948")]
	public int TileInteractionHX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4001949")]
	public int TileInteractionHY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x400194A")]
	public int cursorOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x400194B")]
	public int signHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x400194C")]
	public int lastSignHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x400194D")]
	public float GamepadCursorAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29C")]
	[Cpp2IlInjected.Token(Token = "0x400194E")]
	public int overloadedMousePositionX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x400194F")]
	public int overloadedMousePositionY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
	[Cpp2IlInjected.Token(Token = "0x4001950")]
	public Color mouseColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4001951")]
	public Color MouseBorderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x4001952")]
	public Color ControllerColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4001953")]
	public Color ControllerBorderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x4001954")]
	public Color cursorColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4001955")]
	public int cursorColorDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
	[Cpp2IlInjected.Token(Token = "0x4001956")]
	public float cursorAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x4001957")]
	public float cursorScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x4001958")]
	public bool signBubble;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4001959")]
	public int signX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
	[Cpp2IlInjected.Token(Token = "0x400195A")]
	public int signY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x400195B")]
	public bool hideUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D1")]
	[Cpp2IlInjected.Token(Token = "0x400195C")]
	public bool releaseUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D2")]
	[Cpp2IlInjected.Token(Token = "0x400195D")]
	public bool renderNow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x400195E")]
	public int renderCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x400195F")]
	public bool render;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x4001960")]
	public Stopwatch saveTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4001961")]
	public bool BackgroundEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
	[Cpp2IlInjected.Token(Token = "0x4001962")]
	public SceneMetrics SceneMetrics;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4001963")]
	public int instantBGTransitionCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
	[Cpp2IlInjected.Token(Token = "0x4001964")]
	public int bgDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4001965")]
	public int background;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
	[Cpp2IlInjected.Token(Token = "0x4001966")]
	public int caveBackground;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4001967")]
	public GolfState LocalGolfState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
	[Cpp2IlInjected.Token(Token = "0x4001968")]
	public DroneCameraTracker DroneCameraTracker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4001969")]
	public Vector2 CurrentPan;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x400196A")]
	public float sunCircle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x400196B")]
	public int BlackFadeIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400196C")]
	public float ugBackTransition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400196D")]
	public int undergroundBackground;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400196E")]
	public int oldUndergroundBackground;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
	[Cpp2IlInjected.Token(Token = "0x400196F")]
	public int bgStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4001970")]
	public float[] bgAlphaFrontLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x4001971")]
	public float[] bgAlphaFarBackLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4001972")]
	public int[] bgFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x4001973")]
	public int[] bgFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4001974")]
	public bool mapEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4001975")]
	public int invasionProgressMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x4001976")]
	public bool invasionProgressNearInvasion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x339")]
	[Cpp2IlInjected.Token(Token = "0x4001977")]
	public bool placementPreview;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33A")]
	[Cpp2IlInjected.Token(Token = "0x4001978")]
	public bool autoSave;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x4001979")]
	public Main.AutoPauseMode autoPause;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400197A")]
	public bool DisableIntenseVisualEffects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x400197B")]
	public int WaveQuality;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x400197C")]
	public bool UseStormEffects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x349")]
	[Cpp2IlInjected.Token(Token = "0x400197D")]
	public bool UseHeatDistortion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x400197E")]
	public float musicVolume;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x400197F")]
	public float ambientVolume;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4001980")]
	public float soundVolume;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4001981")]
	public bool TOWMusicUnlocked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
	[Cpp2IlInjected.Token(Token = "0x4001982")]
	public int qaStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4001983")]
	public float caveParallax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
	[Cpp2IlInjected.Token(Token = "0x4001984")]
	public int bgScroll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4001985")]
	public bool showItemText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x369")]
	[Cpp2IlInjected.Token(Token = "0x4001986")]
	public bool HidePassword;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36A")]
	[Cpp2IlInjected.Token(Token = "0x4001987")]
	public bool ReversedUpDownArmorSetBonuses;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36B")]
	[Cpp2IlInjected.Token(Token = "0x4001988")]
	public bool SettingsEnabled_TilesSwayInWind;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
	[Cpp2IlInjected.Token(Token = "0x4001989")]
	public bool cSmartCursorModeIsToggleAndNotHold;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400198A")]
	public float gfxQuality;

	[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
	[Cpp2IlInjected.Token(Token = "0x400198B")]
	public float gfxRate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400198C")]
	public int teamCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400198D")]
	public bool showFrameRate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37D")]
	[Cpp2IlInjected.Token(Token = "0x400198E")]
	public bool SettingsSavePending;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400198F")]
	public WorldMap Map;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4001990")]
	public bool refreshMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4001991")]
	public int loadMapLastX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
	[Cpp2IlInjected.Token(Token = "0x4001992")]
	public bool loadMapLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38D")]
	[Cpp2IlInjected.Token(Token = "0x4001993")]
	public bool loadMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38E")]
	[Cpp2IlInjected.Token(Token = "0x4001994")]
	public bool loadMapSections;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38F")]
	[Cpp2IlInjected.Token(Token = "0x4001995")]
	public bool mapReady;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4001996")]
	public bool updateMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x4001997")]
	public int mapMinX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x4001998")]
	public int mapMaxX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4001999")]
	public int mapMinY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x400199A")]
	public int mapMaxY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x400199B")]
	public int mapTimeMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x400199C")]
	public int mapTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x400199D")]
	public bool clearMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AD")]
	[Cpp2IlInjected.Token(Token = "0x400199E")]
	public bool mapInit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400199F")]
	public int mapStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
	[Cpp2IlInjected.Token(Token = "0x40019A0")]
	public float grabMapX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x40019A1")]
	public float grabMapY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
	[Cpp2IlInjected.Token(Token = "0x40019A2")]
	public float grabMapInitialX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x40019A3")]
	public float grabMapInitialY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
	[Cpp2IlInjected.Token(Token = "0x40019A4")]
	public bool grabMapInProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x40019A5")]
	public int miniMapX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
	[Cpp2IlInjected.Token(Token = "0x40019A6")]
	public int miniMapY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
	[Cpp2IlInjected.Token(Token = "0x40019A7")]
	public int miniMapWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
	[Cpp2IlInjected.Token(Token = "0x40019A8")]
	public int miniMapHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x40019A9")]
	public float mapMinimapScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
	[Cpp2IlInjected.Token(Token = "0x40019AA")]
	public float mapMinimapAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x40019AB")]
	public float mapOverlayScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
	[Cpp2IlInjected.Token(Token = "0x40019AC")]
	public float mapOverlayAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
	[Cpp2IlInjected.Token(Token = "0x40019AD")]
	public bool mapFullscreen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E9")]
	[Cpp2IlInjected.Token(Token = "0x40019AE")]
	public bool resetMapFull;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
	[Cpp2IlInjected.Token(Token = "0x40019AF")]
	public int resetMapFullCharacter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
	[Cpp2IlInjected.Token(Token = "0x40019B0")]
	public float mapFullscreenScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
	[Cpp2IlInjected.Token(Token = "0x40019B1")]
	public Vector2 mapFullscreenPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
	[Cpp2IlInjected.Token(Token = "0x40019B2")]
	public bool _MouseOversCanClear;

	[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
	[Cpp2IlInjected.Token(Token = "0x40019B3")]
	public TriggersPack Triggers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
	[Cpp2IlInjected.Token(Token = "0x40019B4")]
	public MouseState MouseInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
	[Cpp2IlInjected.Token(Token = "0x40019B5")]
	public MouseState MouseInfoOld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
	[Cpp2IlInjected.Token(Token = "0x40019B6")]
	public int MouseX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
	[Cpp2IlInjected.Token(Token = "0x40019B7")]
	public int MouseY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
	[Cpp2IlInjected.Token(Token = "0x40019B8")]
	public bool LockGamepadTileUseButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
	[Cpp2IlInjected.Token(Token = "0x40019B9")]
	public int PreUIX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
	[Cpp2IlInjected.Token(Token = "0x40019BA")]
	public int PreUIY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
	[Cpp2IlInjected.Token(Token = "0x40019BB")]
	public int PreLockOnX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x464")]
	[Cpp2IlInjected.Token(Token = "0x40019BC")]
	public int PreLockOnY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
	[Cpp2IlInjected.Token(Token = "0x40019BD")]
	public int ScrollWheelValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
	[Cpp2IlInjected.Token(Token = "0x40019BE")]
	public int ScrollWheelValueOld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
	[Cpp2IlInjected.Token(Token = "0x40019BF")]
	public int ScrollWheelDelta;

	[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
	[Cpp2IlInjected.Token(Token = "0x40019C0")]
	public int taxRate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
	[Cpp2IlInjected.Token(Token = "0x40019C1")]
	public int tileRangeX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
	[Cpp2IlInjected.Token(Token = "0x40019C2")]
	public int tileRangeY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
	[Cpp2IlInjected.Token(Token = "0x40019C3")]
	public int tileTargetX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x484")]
	[Cpp2IlInjected.Token(Token = "0x40019C4")]
	public int tileTargetY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
	[Cpp2IlInjected.Token(Token = "0x40019C5")]
	public int jumpHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48C")]
	[Cpp2IlInjected.Token(Token = "0x40019C6")]
	public float jumpSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
	[Cpp2IlInjected.Token(Token = "0x40019C7")]
	public int BlockInteractionWithProjectiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x494")]
	[Cpp2IlInjected.Token(Token = "0x40019C8")]
	public bool lastPound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
	[Cpp2IlInjected.Token(Token = "0x40019C9")]
	public int musicNotes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49C")]
	[Cpp2IlInjected.Token(Token = "0x40019CA")]
	public bool SmartBlocksEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49D")]
	[Cpp2IlInjected.Token(Token = "0x40019CB")]
	public bool SmartAxeAfterPickaxe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
	[Cpp2IlInjected.Token(Token = "0x40019CC")]
	public int[] _specialsCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A4")]
	[Cpp2IlInjected.Token(Token = "0x40019CD")]
	public Point[][] _specialPositions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
	[Cpp2IlInjected.Token(Token = "0x40019CE")]
	public WindGrid _windGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4AC")]
	[Cpp2IlInjected.Token(Token = "0x40019CF")]
	public bool _shouldShowInvisibleBlocks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4AD")]
	[Cpp2IlInjected.Token(Token = "0x40019D0")]
	public bool _shouldShowInvisibleBlocks_LastFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
	[Cpp2IlInjected.Token(Token = "0x40019D1")]
	public ThreadLocal<TileDrawInfo> _currentTileDrawInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B4")]
	[Cpp2IlInjected.Token(Token = "0x40019D2")]
	public LightMode _mode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
	[Cpp2IlInjected.Token(Token = "0x40019D3")]
	private LightingEngine _newEngine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4BC")]
	[Cpp2IlInjected.Token(Token = "0x40019D4")]
	private LegacyLighting _legacyEngine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
	[Cpp2IlInjected.Token(Token = "0x40019D5")]
	private ILightingEngine _activeEngineVal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C4")]
	[Cpp2IlInjected.Token(Token = "0x40019D6")]
	public bool DisableLeftShiftTrashCan;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C5")]
	[Cpp2IlInjected.Token(Token = "0x40019D7")]
	public bool HighlightNewItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C6")]
	[Cpp2IlInjected.Token(Token = "0x40019D8")]
	public bool DisableQuickTrash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C7")]
	[Cpp2IlInjected.Token(Token = "0x40019D9")]
	public bool ChildSafetyDisabled;

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public FavoritesFile LocalFavoriteData
	{
		[Cpp2IlInjected.Token(Token = "0x6000F0B")]
		[Cpp2IlInjected.Address(RVA = "0x12DEFD4", Offset = "0x12DEFD4", VA = "0x12DEFD4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public WaterfallManager waterfallManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000F0C")]
		[Cpp2IlInjected.Address(RVA = "0x12DF108", Offset = "0x12DF108", VA = "0x12DF108")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000F0D")]
		[Cpp2IlInjected.Address(RVA = "0x12DF180", Offset = "0x12DF180", VA = "0x12DF180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public LightingEngine NewEngine
	{
		[Cpp2IlInjected.Token(Token = "0x6000F0E")]
		[Cpp2IlInjected.Address(RVA = "0x12DF188", Offset = "0x12DF188", VA = "0x12DF188")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public LegacyLighting LegacyEngine
	{
		[Cpp2IlInjected.Token(Token = "0x6000F0F")]
		[Cpp2IlInjected.Address(RVA = "0x12DF200", Offset = "0x12DF200", VA = "0x12DF200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public ILightingEngine _activeEngine
	{
		[Cpp2IlInjected.Token(Token = "0x6000F10")]
		[Cpp2IlInjected.Address(RVA = "0x12DF2B4", Offset = "0x12DF2B4", VA = "0x12DF2B4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000F11")]
		[Cpp2IlInjected.Address(RVA = "0x12DF2F4", Offset = "0x12DF2F4", VA = "0x12DF2F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000F12")]
	[Cpp2IlInjected.Address(RVA = "0x12DBF58", Offset = "0x12DBF58", VA = "0x12DBF58")]
	public LocalUserGameState()
	{
	}
}
