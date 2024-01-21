using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x20000E6")]
public class GUIInstance
{
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	public static GUIInstance Active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	public XNAUnityRunner.ForcedInputMode LastPrimaryInputMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	public InterfaceProfile_Layout _active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	public bool UseLargeMinimap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	public GUIControllerNavigationController GUIControllerNavigationController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	public GUIControllerPageRedirect GUIControllerPageRedirect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	public GUIVirtualInputController GUIVirtualInputController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	public GUIAccessoryInfo GUIAccessoryInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	public GUIMenuNameEdit GUIMenuNameEdit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	public GUIReforgePopup GUIReforgePopup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	public GUIAmmo GUIAmmo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	public GUIBossBar GUIBossBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	public GUIBuffs GUIBuffs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	public GUIButtonBar GUIButtonBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	public GUIChest GUIChest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	public GUIChestQuickStack GUIChestQuickStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	public GUIChestSplitStack GUIChestSplitStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	public GUIClothesWindow GUIClothesWindow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	public GUICoins GUICoins;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	public GUIControlsBanner GUIControlsBanner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	public GUIControlsStatusIndicators GUIControlsStatusIndicators;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	public GUICraftGuide GUICraftGuide;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	public GUICraftGuidePopup GUICraftGuidePopup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400059A")]
	public GUICrafting GUICrafting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	public GUIDisplayDoll GUIDisplayDoll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	public GUIEmotesWindow GUIEmotesWindow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	public GUIEquipment GUIEquipment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	public GUIEquipmentUtility GUIEquipmentUtility;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	public GUIEvents GUIEvents;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40005A0")]
	public GUIHairWindow GUIHairWindow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	public GUIHatRack GUIHatRack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	public GUIResearchPage GUIResearchPage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	public GUIHearts GUIHearts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	public GUIHotbar GUIHotbar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	public GUIHousingMenu GUIHousingMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40005A6")]
	public GUIInventory GUIInventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40005A7")]
	public GUIWiresUI GUIWiresUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005A8")]
	public GUIRubbleMaker GUIRubbleMaker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40005A9")]
	public GUIInventorySplitStack GUIInventorySplitStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005AA")]
	public GUIInventoryTransactions GUIInventoryTransactions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40005AB")]
	public GUIItemDuplication GUIItemDuplication;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	public GUIMagnify GUIMagnify;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	public GUIMana GUIMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	public GUIMap GUIMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	public GUIMouseItem GUIMouseItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	public GUIMultiplayerChat GUIMultiplayerChat;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	public GUIMultiplayerChat GUIMultiplayerChatPage;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	public GUINetplayStatusText GUINetplayStatusText;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	public GUINPCDialogue GUINPCDialogue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	public GUIPageIcons GUIPageIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	public GUIProfileSwitch GUIProfileSwitch;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	public GUIPVPIcons GUIPVPIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	public GUIReforge GUIReforge;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	public GUIScrollControl GUIScrollControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	public GUIJourneyModeSettings GUIJourneyModeSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	public GUISettings GUISettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	public GUISettingsPauseMenu GUISettingsPauseMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	public GUIShop GUIShop;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	public GUITrashCan GUITrashCan;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	public GUIWorldOperationProgress GUIWorldOperationProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	public GUIZoom GUIZoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	public GUIAchievementsMenu GUIAchievementsMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	public GUICredits GUICredits;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	public GUIDeleteDedicatedServer GUIDeleteDedicatedServer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	public GUIDeletePlayer GUIDeletePlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	public GUIDeleteWorld GUIDeleteWorld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	public GUIErrorScreen GUIErrorScreen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	public GUIFileSyncInProgress GUIFileSyncInProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	public GUIInterfaceEdit GUIInterfaceEdit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	public GUILogo GUILogo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	public GUILowDiskSpacePopup GUILowDiskSpacePopup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	public GUILowMemoryPopup GUILowMemoryPopup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	public GUILowMemorySetttings GUILowMemorySetttings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	public GUIMainMenu GUIMainMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	public GUIMultiplayerHost GUIMultiplayerHost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	public GUIMultiplayerJoin GUIMultiplayerJoin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	public GUIMultiplayerLobby GUIMultiplayerLobby;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	public GUIMultiplayerMenu GUIMultiplayerMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	public GUIMultiplayerServerIP GUIMultiplayerServerIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	public GUIMultiplayerServerPassword GUIMultiplayerServerPassword;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	public GUIMultiplayerServerPort GUIMultiplayerServerPort;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	public GUIMultiplayerServerRequestedPassword GUIMultiplayerServerRequestedPassword;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	public GUIMultiplayerWaitingHost GUIMultiplayerWaitingHost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	public GUINetPlayStatusMenu GUINetPlayStatusMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public GUIPlayerAndGameModeMismatch GUIPlayerAndGameModeMismatch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public GUIPlayerCreateMenu GUIPlayerCreateMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public GUIPlayerNameMenu GUIPlayerNameMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	public GUIPlayerSelectMenu GUIPlayerSelectMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	public GUIQuitConfirm GUIQuitConfirm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	public GUIResetSettings GUIResetSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	public GUISafeRegionEdit GUISafeRegionEdit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	public GUISettingsOverlay GUISettingsOverlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	public GUIStatusMenu GUIStatusMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	public GUIVirtualInputControllerEdit GUIVirtualInputControllerEdit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	public GUIPageGroupEdit GUIPageGroupEdit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	public GUIWorldCreateMenu GUIWorldCreateMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	public GUIWorldGenerateMenu GUIWorldGenerateMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	public GUIWorldLoadBackup GUIWorldLoadBackup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	public GUIWorldNameMenu GUIWorldNameMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	public GUIWorldNoBackup GUIWorldNoBackup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	public GUIWorldSelectMenu GUIWorldSelectMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	public GUIPageOptions GUIPageOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public GUITalkerList GUITalkerList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public GUIControllerDisconnected GUIControllerDisconnected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public GUIAccessoryInfoToggles GUIAccessoryInfoToggles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public GUIEquipmentLoadout GUIEquipmentLoadout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public GUIControllerMappings GUIControllerMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public VirtualControllerInputState VirtualControllerInputState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	public GUIResearch GUIResearch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	public GUIKeyboardMappings GUIKeyboardMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	public GUIBestiary GUIBestiary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	public GUIBuilderAccToggles GUIBuilderAccToggles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	public GUIPS4MultiplayerChecks GUIPS4MultiplayerChecks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public GUIReturnToTouch GUIReturnToTouch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public Rectangle BottomCentre_Root;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	public Rectangle BottomCentre_ChatUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	public Rectangle BottomCentre_BossBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	public Rectangle BottomCentre_EventBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	public Rectangle BottomCentre_ProgressIndicator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	public Rectangle BottomCentre_Notification;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40005FB")]
	public Rectangle Right_Root;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Cpp2IlInjected.Token(Token = "0x40005FC")]
	public Rectangle Right_MainUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
	[Cpp2IlInjected.Token(Token = "0x40005FD")]
	public Rectangle Right_TextNotifications;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	public Rectangle Right_Event;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	public Rectangle Right_BossBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	public Rectangle Right_StatusIndicator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	public Rectangle Right_InfoAccessories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29C")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	public Rectangle Right_InfoAccessories2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	public Rectangle Right_AchievementNotifiations;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	public Rectangle _gridItemRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	public Rectangle PageGroupRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	public Rectangle PageContentRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	public Rectangle _leftPageRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	public Rectangle _rightPageRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	public Rectangle _selectedItemRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	public Rectangle _buttonRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	public Rectangle _mainMenuPageRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	public Vector2 LeftInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	public Vector2 RightInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	public bool AllowSecondRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34D")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	public bool UseCollpasedCoinsAmmo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	public int AllowRowHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	public bool AllowDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	public int currentFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	public int BottomCentreHUDUpdateFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	public WiresUI.Settings.MultiToolMode ToolMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	public int _lastActuatorEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	public List<int> optionRedirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	public Vector3 mouseHSL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	public Vector3 mouseBorderHSL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	public Vector3 controllerHSL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	public Vector3 controllerBorderHSL;

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0xDDF198", Offset = "0xDDF198", VA = "0xDDF198")]
	public void ClosePopups()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0xDDF218", Offset = "0xDDF218", VA = "0xDDF218")]
	public void CloseDialoguesAndPopups()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0xDDF2FC", Offset = "0xDDF2FC", VA = "0xDDF2FC")]
	public void CloseNonPageDialogues()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0xDDF3A0", Offset = "0xDDF3A0", VA = "0xDDF3A0")]
	public GUIInstance()
	{
	}
}
