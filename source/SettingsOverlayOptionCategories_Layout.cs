using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200018C")]
public class SettingsOverlayOptionCategories_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007E2")]
	public enum Category
	{
		[Cpp2IlInjected.Token(Token = "0x4007C05")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4007C06")]
		Video,
		[Cpp2IlInjected.Token(Token = "0x4007C07")]
		Interface,
		[Cpp2IlInjected.Token(Token = "0x4007C08")]
		Links,
		[Cpp2IlInjected.Token(Token = "0x4007C09")]
		Touch,
		[Cpp2IlInjected.Token(Token = "0x4007C0A")]
		Controller,
		[Cpp2IlInjected.Token(Token = "0x4007C0B")]
		Sound,
		[Cpp2IlInjected.Token(Token = "0x4007C0C")]
		MoreInfo,
		[Cpp2IlInjected.Token(Token = "0x4007C0D")]
		TextureQuality,
		[Cpp2IlInjected.Token(Token = "0x4007C0E")]
		KeyboardMouse,
		[Cpp2IlInjected.Token(Token = "0x4007C0F")]
		GameplayControls,
		[Cpp2IlInjected.Token(Token = "0x4007C10")]
		InterfaceAdvanced,
		[Cpp2IlInjected.Token(Token = "0x4007C11")]
		VideoAdvanced,
		[Cpp2IlInjected.Token(Token = "0x4007C12")]
		GameplayControlsAdvanced,
		[Cpp2IlInjected.Token(Token = "0x4007C13")]
		TouchAdvanced,
		[Cpp2IlInjected.Token(Token = "0x4007C14")]
		ControllerAdvanced,
		[Cpp2IlInjected.Token(Token = "0x4007C15")]
		KeyboardMouseAdvanced,
		[Cpp2IlInjected.Token(Token = "0x4007C16")]
		KeyboardMouseCursor,
		[Cpp2IlInjected.Token(Token = "0x4007C17")]
		ControllerCursor,
		[Cpp2IlInjected.Token(Token = "0x4007C18")]
		TouchCursor
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007E3")]
	public class Setting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007C19")]
		public Category Category;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007C1A")]
		public int SortOrder;

		[Cpp2IlInjected.Token(Token = "0x600491E")]
		[Cpp2IlInjected.Address(RVA = "0x105F528", Offset = "0x105F528", VA = "0x105F528")]
		public Setting()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000F98")]
	public Setting InventoryPageMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000F99")]
	public Setting InterfaceProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000F9A")]
	public Setting ControllerAimSensitivity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000F9B")]
	public Setting ControllerInterfaceMovementDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000F9C")]
	public Setting ControllerInterfaceMovementRepeatDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000F9D")]
	public Setting ControllerSwapShoulderButtons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000F9E")]
	public Setting ControllerShowControlsBanner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000F9F")]
	public Setting ControllerSmartCursorMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000FA0")]
	public Setting ControllerAimAndUseMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000FA1")]
	public Setting HorizontalInventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000FA2")]
	public Setting PageOrientation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000FA3")]
	public Setting MiniMapBorderStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000FA4")]
	public Setting MiniMapSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000FA5")]
	public Setting PlayerBarStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000FA6")]
	public Setting ActiveVCProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000FA7")]
	public Setting Sound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000FA8")]
	public Setting Ambient;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000FA9")]
	public Setting Music;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000FAA")]
	public Setting AutoSave;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000FAB")]
	public Setting HighlightNewItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000FAC")]
	public Setting ShiftQuickTrash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000FAD")]
	public Setting EnableDoubleClick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000FAE")]
	public Setting EnableDoubleTap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000FAF")]
	public Setting PickupText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000FB0")]
	public Setting PlacementPreview;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000FB1")]
	public Setting GoreVisuals;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000FB2")]
	public Setting MapEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000FB3")]
	public Setting EventProgressBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000FB4")]
	public Setting LockOn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000FB5")]
	public Setting Magnify;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000FB6")]
	public Setting TooltipTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000FB7")]
	public Setting TooltipFadeTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000FB8")]
	public Setting Parallex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000FB9")]
	public Setting TooltipBackings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000FBA")]
	public Setting FrameSkip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000FBB")]
	public Setting BatterySavingMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000FBC")]
	public Setting ScreenEffects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000FBD")]
	public Setting ShowFPS;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000FBE")]
	public Setting BackgroundEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000FBF")]
	public Setting AutoPause;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000FC0")]
	public Setting LockTutorials;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000FC1")]
	public Setting LeftStickAiming;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000FC2")]
	public Setting Language;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000FC3")]
	public Setting WikiButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000FC4")]
	public Setting ForumButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000FC5")]
	public Setting DiscordButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000FC6")]
	public Setting SupportButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000FC7")]
	public Setting YoutubeButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000FC8")]
	public Setting TwitterButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000FC9")]
	public Setting PrivacyButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000FCA")]
	public Setting FacebookButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000FCB")]
	public Setting EditInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000FCC")]
	public Setting ResetCursorModes;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000FCD")]
	public Setting BugReportButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000FCE")]
	public Setting Credits;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000FCF")]
	public Setting RedditButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000FD0")]
	public Setting LeftStickJump;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000FD1")]
	public Setting AutoSwing;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000FD2")]
	public Setting UITexturesHigh;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4000FD3")]
	public Setting CharacterTexturesHigh;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000FD4")]
	public Setting ProjectilesTexturesHigh;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000FD5")]
	public Setting BackgroundTexturesHigh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000FD6")]
	public Setting GoreTexturesHigh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4000FD7")]
	public Setting GlowTexturesHigh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000FD8")]
	public Setting EnvironmentTexturesHigh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000FD9")]
	public Setting Controls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000FDA")]
	public Setting EditControllerMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4000FDB")]
	public Setting ChatOrder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000FDC")]
	public Setting PasswordVisibility;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4000FDD")]
	public Setting PinchZoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000FDE")]
	public Setting PinchZoomMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000FDF")]
	public Setting TouchPadPinchZoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000FE0")]
	public Setting TouchPadPinchZoomMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4000FE1")]
	public Setting TouchAimSensitivity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000FE2")]
	public Setting TouchSmartCursorMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000FE3")]
	public Setting TouchAimAndUseMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000FE4")]
	public Setting EditVirtualControls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x4000FE5")]
	public Setting KeyboardMouse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000FE6")]
	public Setting EditKeyboardMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000FE7")]
	public Setting EditControllerProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000FE8")]
	public Setting LightingMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x4000FE9")]
	public Setting GraphicsQuality;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000FEA")]
	public Setting EscapeKeyMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000FEB")]
	public Setting EditTextureSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000FEC")]
	public Setting ViewSocial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x4000FED")]
	public Setting ViewMoreInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000FEE")]
	public Setting SplitscreenPrimarySplit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x4000FEF")]
	public Setting SmartCursorModeToggleHold;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000FF0")]
	public Setting SmartCursorPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x4000FF1")]
	public Setting SmartCursorBlockPlacement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000FF2")]
	public Setting PlacementGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Cpp2IlInjected.Token(Token = "0x4000FF3")]
	public Setting MinersWobble;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000FF4")]
	public Setting WindyEnvironment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000FF5")]
	public Setting KeyboardMouseSmartCursorMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000FF6")]
	public Setting WaterQuality;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000FF7")]
	public Setting AutoSaveFrequency;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000FF8")]
	public Setting ControllerCraftToInventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000FF9")]
	public Setting EditSafeRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000FFA")]
	public Setting BuildGridSnap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000FFB")]
	public Setting InterfaceAdvanced;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000FFC")]
	public Setting VideoAdvanced;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000FFD")]
	public Setting GameplayControlsAdvanced;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000FFE")]
	public Setting TouchAdvanced;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000FFF")]
	public Setting ControllerAdvanced;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4001000")]
	public Setting KeyboardMouseAdvanced;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4001001")]
	public Setting MouseCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4001002")]
	public Setting MouseCursorValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4001003")]
	public Setting MouseCursorBorderValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4001004")]
	public Setting TouchCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4001005")]
	public Setting TouchCursorValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4001006")]
	public Setting TouchCursorBorderValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4001007")]
	public Setting ControllerCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4001008")]
	public Setting ControllerCursorValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x4001009")]
	public Setting ControllerCursorBorderValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400100A")]
	public Setting PageCollapseMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
	[Cpp2IlInjected.Token(Token = "0x400100B")]
	public Setting AutoSelectModeTouch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x400100C")]
	public Setting AutoSelectModeController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Cpp2IlInjected.Token(Token = "0x400100D")]
	public Setting AutoSelectModeKeyboard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x400100E")]
	public Setting InventoryCameraMovement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
	[Cpp2IlInjected.Token(Token = "0x400100F")]
	public Setting PrimaryInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x4001010")]
	public Setting ScrollSensitivity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
	[Cpp2IlInjected.Token(Token = "0x4001011")]
	public Setting ResetAll;

	[Cpp2IlInjected.Token(Token = "0x6000BC1")]
	[Cpp2IlInjected.Address(RVA = "0xFA78D8", Offset = "0xFA78D8", VA = "0xFA78D8")]
	public void GetCategorySetup(GUISettingID id, out Category category, out int sortOrder)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC2")]
	[Cpp2IlInjected.Address(RVA = "0xFA7FE4", Offset = "0xFA7FE4", VA = "0xFA7FE4")]
	public SettingsOverlayOptionCategories_Layout()
	{
	}
}
