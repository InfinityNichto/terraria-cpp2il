using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000215")]
[Serializable]
public class SettingsOverlayOptionCategories_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CC4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFECC", Offset = "0x9CFECC", Length = "0x450")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "SetCategory", MemberParameters = new object[] { typeof(SettingsOverlayOptionCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void GetCategorySetup(GUISettingID id, out SettingsOverlayOptionCategories_Layout.Category category, out int sortOrder)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CC5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D031C", Offset = "0x9D031C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlayOptionCategories_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40013DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public SettingsOverlayOptionCategories_Layout.Setting InventoryPageMode;

	[global::Cpp2ILInjected.Token(Token = "0x40013DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public SettingsOverlayOptionCategories_Layout.Setting InterfaceProfile;

	[global::Cpp2ILInjected.Token(Token = "0x40013DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerAimSensitivity;

	[global::Cpp2ILInjected.Token(Token = "0x40013DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerInterfaceMovementDelay;

	[global::Cpp2ILInjected.Token(Token = "0x40013E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerInterfaceMovementRepeatDelay;

	[global::Cpp2ILInjected.Token(Token = "0x40013E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerSwapShoulderButtons;

	[global::Cpp2ILInjected.Token(Token = "0x40013E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerShowControlsBanner;

	[global::Cpp2ILInjected.Token(Token = "0x40013E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerSmartCursorMode;

	[global::Cpp2ILInjected.Token(Token = "0x40013E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerAimAndUseMode;

	[global::Cpp2ILInjected.Token(Token = "0x40013E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public SettingsOverlayOptionCategories_Layout.Setting HorizontalInventory;

	[global::Cpp2ILInjected.Token(Token = "0x40013E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public SettingsOverlayOptionCategories_Layout.Setting PageOrientation;

	[global::Cpp2ILInjected.Token(Token = "0x40013E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public SettingsOverlayOptionCategories_Layout.Setting MiniMapBorderStyle;

	[global::Cpp2ILInjected.Token(Token = "0x40013E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public SettingsOverlayOptionCategories_Layout.Setting MiniMapSize;

	[global::Cpp2ILInjected.Token(Token = "0x40013E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public SettingsOverlayOptionCategories_Layout.Setting PlayerBarStyle;

	[global::Cpp2ILInjected.Token(Token = "0x40013EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public SettingsOverlayOptionCategories_Layout.Setting ActiveVCProfile;

	[global::Cpp2ILInjected.Token(Token = "0x40013EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public SettingsOverlayOptionCategories_Layout.Setting Sound;

	[global::Cpp2ILInjected.Token(Token = "0x40013EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public SettingsOverlayOptionCategories_Layout.Setting Ambient;

	[global::Cpp2ILInjected.Token(Token = "0x40013ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public SettingsOverlayOptionCategories_Layout.Setting Music;

	[global::Cpp2ILInjected.Token(Token = "0x40013EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSave;

	[global::Cpp2ILInjected.Token(Token = "0x40013EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public SettingsOverlayOptionCategories_Layout.Setting HighlightNewItems;

	[global::Cpp2ILInjected.Token(Token = "0x40013F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public SettingsOverlayOptionCategories_Layout.Setting ShiftQuickTrash;

	[global::Cpp2ILInjected.Token(Token = "0x40013F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public SettingsOverlayOptionCategories_Layout.Setting EnableDoubleClick;

	[global::Cpp2ILInjected.Token(Token = "0x40013F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public SettingsOverlayOptionCategories_Layout.Setting EnableDoubleTap;

	[global::Cpp2ILInjected.Token(Token = "0x40013F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public SettingsOverlayOptionCategories_Layout.Setting PickupText;

	[global::Cpp2ILInjected.Token(Token = "0x40013F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public SettingsOverlayOptionCategories_Layout.Setting PlacementPreview;

	[global::Cpp2ILInjected.Token(Token = "0x40013F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public SettingsOverlayOptionCategories_Layout.Setting GoreVisuals;

	[global::Cpp2ILInjected.Token(Token = "0x40013F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public SettingsOverlayOptionCategories_Layout.Setting MapEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x40013F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public SettingsOverlayOptionCategories_Layout.Setting EventProgressBar;

	[global::Cpp2ILInjected.Token(Token = "0x40013F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public SettingsOverlayOptionCategories_Layout.Setting LockOn;

	[global::Cpp2ILInjected.Token(Token = "0x40013F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public SettingsOverlayOptionCategories_Layout.Setting Magnify;

	[global::Cpp2ILInjected.Token(Token = "0x40013FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public SettingsOverlayOptionCategories_Layout.Setting TooltipTime;

	[global::Cpp2ILInjected.Token(Token = "0x40013FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public SettingsOverlayOptionCategories_Layout.Setting TooltipFadeTime;

	[global::Cpp2ILInjected.Token(Token = "0x40013FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public SettingsOverlayOptionCategories_Layout.Setting Parallex;

	[global::Cpp2ILInjected.Token(Token = "0x40013FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public SettingsOverlayOptionCategories_Layout.Setting TooltipBackings;

	[global::Cpp2ILInjected.Token(Token = "0x40013FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public SettingsOverlayOptionCategories_Layout.Setting FrameSkip;

	[global::Cpp2ILInjected.Token(Token = "0x40013FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public SettingsOverlayOptionCategories_Layout.Setting BatterySavingMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001400")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public SettingsOverlayOptionCategories_Layout.Setting ScreenEffects;

	[global::Cpp2ILInjected.Token(Token = "0x4001401")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public SettingsOverlayOptionCategories_Layout.Setting ShowFPS;

	[global::Cpp2ILInjected.Token(Token = "0x4001402")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public SettingsOverlayOptionCategories_Layout.Setting BackgroundEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4001403")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoPause;

	[global::Cpp2ILInjected.Token(Token = "0x4001404")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public SettingsOverlayOptionCategories_Layout.Setting LockTutorials;

	[global::Cpp2ILInjected.Token(Token = "0x4001405")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public SettingsOverlayOptionCategories_Layout.Setting LeftStickAiming;

	[global::Cpp2ILInjected.Token(Token = "0x4001406")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public SettingsOverlayOptionCategories_Layout.Setting Language;

	[global::Cpp2ILInjected.Token(Token = "0x4001407")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public SettingsOverlayOptionCategories_Layout.Setting WikiButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001408")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public SettingsOverlayOptionCategories_Layout.Setting ForumButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001409")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public SettingsOverlayOptionCategories_Layout.Setting DiscordButton;

	[global::Cpp2ILInjected.Token(Token = "0x400140A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public SettingsOverlayOptionCategories_Layout.Setting SupportButton;

	[global::Cpp2ILInjected.Token(Token = "0x400140B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public SettingsOverlayOptionCategories_Layout.Setting YoutubeButton;

	[global::Cpp2ILInjected.Token(Token = "0x400140C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public SettingsOverlayOptionCategories_Layout.Setting TwitterButton;

	[global::Cpp2ILInjected.Token(Token = "0x400140D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public SettingsOverlayOptionCategories_Layout.Setting PrivacyButton;

	[global::Cpp2ILInjected.Token(Token = "0x400140E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public SettingsOverlayOptionCategories_Layout.Setting FacebookButton;

	[global::Cpp2ILInjected.Token(Token = "0x400140F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public SettingsOverlayOptionCategories_Layout.Setting EditInterface;

	[global::Cpp2ILInjected.Token(Token = "0x4001410")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public SettingsOverlayOptionCategories_Layout.Setting ResetCursorModes;

	[global::Cpp2ILInjected.Token(Token = "0x4001411")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public SettingsOverlayOptionCategories_Layout.Setting BugReportButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001412")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public SettingsOverlayOptionCategories_Layout.Setting Credits;

	[global::Cpp2ILInjected.Token(Token = "0x4001413")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public SettingsOverlayOptionCategories_Layout.Setting RedditButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001414")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public SettingsOverlayOptionCategories_Layout.Setting LeftStickJump;

	[global::Cpp2ILInjected.Token(Token = "0x4001415")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSwing;

	[global::Cpp2ILInjected.Token(Token = "0x4001416")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public SettingsOverlayOptionCategories_Layout.Setting UITexturesHigh;

	[global::Cpp2ILInjected.Token(Token = "0x4001417")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public SettingsOverlayOptionCategories_Layout.Setting CharacterTexturesHigh;

	[global::Cpp2ILInjected.Token(Token = "0x4001418")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public SettingsOverlayOptionCategories_Layout.Setting ProjectilesTexturesHigh;

	[global::Cpp2ILInjected.Token(Token = "0x4001419")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public SettingsOverlayOptionCategories_Layout.Setting BackgroundTexturesHigh;

	[global::Cpp2ILInjected.Token(Token = "0x400141A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public SettingsOverlayOptionCategories_Layout.Setting GoreTexturesHigh;

	[global::Cpp2ILInjected.Token(Token = "0x400141B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	public SettingsOverlayOptionCategories_Layout.Setting GlowTexturesHigh;

	[global::Cpp2ILInjected.Token(Token = "0x400141C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
	public SettingsOverlayOptionCategories_Layout.Setting EnvironmentTexturesHigh;

	[global::Cpp2ILInjected.Token(Token = "0x400141D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
	public SettingsOverlayOptionCategories_Layout.Setting Controls;

	[global::Cpp2ILInjected.Token(Token = "0x400141E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
	public SettingsOverlayOptionCategories_Layout.Setting EditControllerMappings;

	[global::Cpp2ILInjected.Token(Token = "0x400141F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
	public SettingsOverlayOptionCategories_Layout.Setting ChatOrder;

	[global::Cpp2ILInjected.Token(Token = "0x4001420")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
	public SettingsOverlayOptionCategories_Layout.Setting PasswordVisibility;

	[global::Cpp2ILInjected.Token(Token = "0x4001421")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
	public SettingsOverlayOptionCategories_Layout.Setting PinchZoom;

	[global::Cpp2ILInjected.Token(Token = "0x4001422")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
	public SettingsOverlayOptionCategories_Layout.Setting PinchZoomMap;

	[global::Cpp2ILInjected.Token(Token = "0x4001423")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchPadPinchZoom;

	[global::Cpp2ILInjected.Token(Token = "0x4001424")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchPadPinchZoomMap;

	[global::Cpp2ILInjected.Token(Token = "0x4001425")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchAimSensitivity;

	[global::Cpp2ILInjected.Token(Token = "0x4001426")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchSmartCursorMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001427")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x268")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchAimAndUseMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001428")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x270")]
	public SettingsOverlayOptionCategories_Layout.Setting EditVirtualControls;

	[global::Cpp2ILInjected.Token(Token = "0x4001429")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x278")]
	public SettingsOverlayOptionCategories_Layout.Setting KeyboardMouse;

	[global::Cpp2ILInjected.Token(Token = "0x400142A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x280")]
	public SettingsOverlayOptionCategories_Layout.Setting EditKeyboardMappings;

	[global::Cpp2ILInjected.Token(Token = "0x400142B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x288")]
	public SettingsOverlayOptionCategories_Layout.Setting EditControllerProfile;

	[global::Cpp2ILInjected.Token(Token = "0x400142C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x290")]
	public SettingsOverlayOptionCategories_Layout.Setting LightingMode;

	[global::Cpp2ILInjected.Token(Token = "0x400142D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x298")]
	public SettingsOverlayOptionCategories_Layout.Setting GraphicsQuality;

	[global::Cpp2ILInjected.Token(Token = "0x400142E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A0")]
	public SettingsOverlayOptionCategories_Layout.Setting EscapeKeyMode;

	[global::Cpp2ILInjected.Token(Token = "0x400142F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A8")]
	public SettingsOverlayOptionCategories_Layout.Setting EditTextureSettings;

	[global::Cpp2ILInjected.Token(Token = "0x4001430")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B0")]
	public SettingsOverlayOptionCategories_Layout.Setting ViewSocial;

	[global::Cpp2ILInjected.Token(Token = "0x4001431")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
	public SettingsOverlayOptionCategories_Layout.Setting ViewMoreInfo;

	[global::Cpp2ILInjected.Token(Token = "0x4001432")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
	public SettingsOverlayOptionCategories_Layout.Setting SplitscreenPrimarySplit;

	[global::Cpp2ILInjected.Token(Token = "0x4001433")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C8")]
	public SettingsOverlayOptionCategories_Layout.Setting SmartCursorModeToggleHold;

	[global::Cpp2ILInjected.Token(Token = "0x4001434")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
	public SettingsOverlayOptionCategories_Layout.Setting SmartCursorPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4001435")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D8")]
	public SettingsOverlayOptionCategories_Layout.Setting SmartCursorBlockPlacement;

	[global::Cpp2ILInjected.Token(Token = "0x4001436")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
	public SettingsOverlayOptionCategories_Layout.Setting PlacementGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001437")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E8")]
	public SettingsOverlayOptionCategories_Layout.Setting MinersWobble;

	[global::Cpp2ILInjected.Token(Token = "0x4001438")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F0")]
	public SettingsOverlayOptionCategories_Layout.Setting WindyEnvironment;

	[global::Cpp2ILInjected.Token(Token = "0x4001439")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F8")]
	public SettingsOverlayOptionCategories_Layout.Setting KeyboardMouseSmartCursorMode;

	[global::Cpp2ILInjected.Token(Token = "0x400143A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x300")]
	public SettingsOverlayOptionCategories_Layout.Setting WaterQuality;

	[global::Cpp2ILInjected.Token(Token = "0x400143B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x308")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSaveFrequency;

	[global::Cpp2ILInjected.Token(Token = "0x400143C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x310")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerCraftToInventory;

	[global::Cpp2ILInjected.Token(Token = "0x400143D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x318")]
	public SettingsOverlayOptionCategories_Layout.Setting EditSafeRegion;

	[global::Cpp2ILInjected.Token(Token = "0x400143E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x320")]
	public SettingsOverlayOptionCategories_Layout.Setting BuildGridSnap;

	[global::Cpp2ILInjected.Token(Token = "0x400143F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x328")]
	public SettingsOverlayOptionCategories_Layout.Setting InterfaceAdvanced;

	[global::Cpp2ILInjected.Token(Token = "0x4001440")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x330")]
	public SettingsOverlayOptionCategories_Layout.Setting VideoAdvanced;

	[global::Cpp2ILInjected.Token(Token = "0x4001441")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x338")]
	public SettingsOverlayOptionCategories_Layout.Setting GameplayControlsAdvanced;

	[global::Cpp2ILInjected.Token(Token = "0x4001442")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x340")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchAdvanced;

	[global::Cpp2ILInjected.Token(Token = "0x4001443")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x348")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerAdvanced;

	[global::Cpp2ILInjected.Token(Token = "0x4001444")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x350")]
	public SettingsOverlayOptionCategories_Layout.Setting KeyboardMouseAdvanced;

	[global::Cpp2ILInjected.Token(Token = "0x4001445")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x358")]
	public SettingsOverlayOptionCategories_Layout.Setting MouseCursor;

	[global::Cpp2ILInjected.Token(Token = "0x4001446")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x360")]
	public SettingsOverlayOptionCategories_Layout.Setting MouseCursorValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001447")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x368")]
	public SettingsOverlayOptionCategories_Layout.Setting MouseCursorBorderValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001448")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x370")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchCursor;

	[global::Cpp2ILInjected.Token(Token = "0x4001449")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x378")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchCursorValue;

	[global::Cpp2ILInjected.Token(Token = "0x400144A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x380")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchCursorBorderValue;

	[global::Cpp2ILInjected.Token(Token = "0x400144B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x388")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerCursor;

	[global::Cpp2ILInjected.Token(Token = "0x400144C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x390")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerCursorValue;

	[global::Cpp2ILInjected.Token(Token = "0x400144D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x398")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerCursorBorderValue;

	[global::Cpp2ILInjected.Token(Token = "0x400144E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A0")]
	public SettingsOverlayOptionCategories_Layout.Setting PageCollapseMode;

	[global::Cpp2ILInjected.Token(Token = "0x400144F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A8")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSelectModeTouch;

	[global::Cpp2ILInjected.Token(Token = "0x4001450")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B0")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSelectModeController;

	[global::Cpp2ILInjected.Token(Token = "0x4001451")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B8")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSelectModeKeyboard;

	[global::Cpp2ILInjected.Token(Token = "0x4001452")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C0")]
	public SettingsOverlayOptionCategories_Layout.Setting InventoryCameraMovement;

	[global::Cpp2ILInjected.Token(Token = "0x4001453")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C8")]
	public SettingsOverlayOptionCategories_Layout.Setting PrimaryInput;

	[global::Cpp2ILInjected.Token(Token = "0x4001454")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D0")]
	public SettingsOverlayOptionCategories_Layout.Setting ScrollSensitivity;

	[global::Cpp2ILInjected.Token(Token = "0x4001455")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D8")]
	public SettingsOverlayOptionCategories_Layout.Setting ResetAll;

	[global::Cpp2ILInjected.Token(Token = "0x2000216")]
	public enum Category
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001457")]
		General,
		[global::Cpp2ILInjected.Token(Token = "0x4001458")]
		Video,
		[global::Cpp2ILInjected.Token(Token = "0x4001459")]
		Interface,
		[global::Cpp2ILInjected.Token(Token = "0x400145A")]
		Links,
		[global::Cpp2ILInjected.Token(Token = "0x400145B")]
		Touch,
		[global::Cpp2ILInjected.Token(Token = "0x400145C")]
		Controller,
		[global::Cpp2ILInjected.Token(Token = "0x400145D")]
		Sound,
		[global::Cpp2ILInjected.Token(Token = "0x400145E")]
		MoreInfo,
		[global::Cpp2ILInjected.Token(Token = "0x400145F")]
		TextureQuality,
		[global::Cpp2ILInjected.Token(Token = "0x4001460")]
		KeyboardMouse,
		[global::Cpp2ILInjected.Token(Token = "0x4001461")]
		GameplayControls,
		[global::Cpp2ILInjected.Token(Token = "0x4001462")]
		InterfaceAdvanced,
		[global::Cpp2ILInjected.Token(Token = "0x4001463")]
		VideoAdvanced,
		[global::Cpp2ILInjected.Token(Token = "0x4001464")]
		GameplayControlsAdvanced,
		[global::Cpp2ILInjected.Token(Token = "0x4001465")]
		TouchAdvanced,
		[global::Cpp2ILInjected.Token(Token = "0x4001466")]
		ControllerAdvanced,
		[global::Cpp2ILInjected.Token(Token = "0x4001467")]
		KeyboardMouseAdvanced,
		[global::Cpp2ILInjected.Token(Token = "0x4001468")]
		KeyboardMouseCursor,
		[global::Cpp2ILInjected.Token(Token = "0x4001469")]
		ControllerCursor,
		[global::Cpp2ILInjected.Token(Token = "0x400146A")]
		TouchCursor
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000217")]
	[Serializable]
	public class Setting
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D0324", Offset = "0x9D0324", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Setting()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400146B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public SettingsOverlayOptionCategories_Layout.Category Category;

		[global::Cpp2ILInjected.Token(Token = "0x400146C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int SortOrder;
	}
}
