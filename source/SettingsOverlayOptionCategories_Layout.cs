using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200018B RID: 395
[global::Cpp2ILInjected.Token(Token = "0x2000215")]
[Serializable]
public class SettingsOverlayOptionCategories_Layout
{
	// Token: 0x06000BAF RID: 2991 RVA: 0x00023E52 File Offset: 0x00022052
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

	// Token: 0x06000BB0 RID: 2992 RVA: 0x00023E55 File Offset: 0x00022055
	[global::Cpp2ILInjected.Token(Token = "0x6000CC5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D031C", Offset = "0x9D031C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlayOptionCategories_Layout()
	{
		throw null;
	}

	// Token: 0x04000F8F RID: 3983
	[global::Cpp2ILInjected.Token(Token = "0x40013DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public SettingsOverlayOptionCategories_Layout.Setting InventoryPageMode;

	// Token: 0x04000F90 RID: 3984
	[global::Cpp2ILInjected.Token(Token = "0x40013DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public SettingsOverlayOptionCategories_Layout.Setting InterfaceProfile;

	// Token: 0x04000F91 RID: 3985
	[global::Cpp2ILInjected.Token(Token = "0x40013DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerAimSensitivity;

	// Token: 0x04000F92 RID: 3986
	[global::Cpp2ILInjected.Token(Token = "0x40013DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerInterfaceMovementDelay;

	// Token: 0x04000F93 RID: 3987
	[global::Cpp2ILInjected.Token(Token = "0x40013E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerInterfaceMovementRepeatDelay;

	// Token: 0x04000F94 RID: 3988
	[global::Cpp2ILInjected.Token(Token = "0x40013E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerSwapShoulderButtons;

	// Token: 0x04000F95 RID: 3989
	[global::Cpp2ILInjected.Token(Token = "0x40013E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerShowControlsBanner;

	// Token: 0x04000F96 RID: 3990
	[global::Cpp2ILInjected.Token(Token = "0x40013E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerSmartCursorMode;

	// Token: 0x04000F97 RID: 3991
	[global::Cpp2ILInjected.Token(Token = "0x40013E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerAimAndUseMode;

	// Token: 0x04000F98 RID: 3992
	[global::Cpp2ILInjected.Token(Token = "0x40013E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public SettingsOverlayOptionCategories_Layout.Setting HorizontalInventory;

	// Token: 0x04000F99 RID: 3993
	[global::Cpp2ILInjected.Token(Token = "0x40013E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public SettingsOverlayOptionCategories_Layout.Setting PageOrientation;

	// Token: 0x04000F9A RID: 3994
	[global::Cpp2ILInjected.Token(Token = "0x40013E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public SettingsOverlayOptionCategories_Layout.Setting MiniMapBorderStyle;

	// Token: 0x04000F9B RID: 3995
	[global::Cpp2ILInjected.Token(Token = "0x40013E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public SettingsOverlayOptionCategories_Layout.Setting MiniMapSize;

	// Token: 0x04000F9C RID: 3996
	[global::Cpp2ILInjected.Token(Token = "0x40013E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public SettingsOverlayOptionCategories_Layout.Setting PlayerBarStyle;

	// Token: 0x04000F9D RID: 3997
	[global::Cpp2ILInjected.Token(Token = "0x40013EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public SettingsOverlayOptionCategories_Layout.Setting ActiveVCProfile;

	// Token: 0x04000F9E RID: 3998
	[global::Cpp2ILInjected.Token(Token = "0x40013EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public SettingsOverlayOptionCategories_Layout.Setting Sound;

	// Token: 0x04000F9F RID: 3999
	[global::Cpp2ILInjected.Token(Token = "0x40013EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public SettingsOverlayOptionCategories_Layout.Setting Ambient;

	// Token: 0x04000FA0 RID: 4000
	[global::Cpp2ILInjected.Token(Token = "0x40013ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public SettingsOverlayOptionCategories_Layout.Setting Music;

	// Token: 0x04000FA1 RID: 4001
	[global::Cpp2ILInjected.Token(Token = "0x40013EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSave;

	// Token: 0x04000FA2 RID: 4002
	[global::Cpp2ILInjected.Token(Token = "0x40013EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public SettingsOverlayOptionCategories_Layout.Setting HighlightNewItems;

	// Token: 0x04000FA3 RID: 4003
	[global::Cpp2ILInjected.Token(Token = "0x40013F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public SettingsOverlayOptionCategories_Layout.Setting ShiftQuickTrash;

	// Token: 0x04000FA4 RID: 4004
	[global::Cpp2ILInjected.Token(Token = "0x40013F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public SettingsOverlayOptionCategories_Layout.Setting EnableDoubleClick;

	// Token: 0x04000FA5 RID: 4005
	[global::Cpp2ILInjected.Token(Token = "0x40013F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public SettingsOverlayOptionCategories_Layout.Setting EnableDoubleTap;

	// Token: 0x04000FA6 RID: 4006
	[global::Cpp2ILInjected.Token(Token = "0x40013F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public SettingsOverlayOptionCategories_Layout.Setting PickupText;

	// Token: 0x04000FA7 RID: 4007
	[global::Cpp2ILInjected.Token(Token = "0x40013F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public SettingsOverlayOptionCategories_Layout.Setting PlacementPreview;

	// Token: 0x04000FA8 RID: 4008
	[global::Cpp2ILInjected.Token(Token = "0x40013F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public SettingsOverlayOptionCategories_Layout.Setting GoreVisuals;

	// Token: 0x04000FA9 RID: 4009
	[global::Cpp2ILInjected.Token(Token = "0x40013F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public SettingsOverlayOptionCategories_Layout.Setting MapEnabled;

	// Token: 0x04000FAA RID: 4010
	[global::Cpp2ILInjected.Token(Token = "0x40013F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public SettingsOverlayOptionCategories_Layout.Setting EventProgressBar;

	// Token: 0x04000FAB RID: 4011
	[global::Cpp2ILInjected.Token(Token = "0x40013F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public SettingsOverlayOptionCategories_Layout.Setting LockOn;

	// Token: 0x04000FAC RID: 4012
	[global::Cpp2ILInjected.Token(Token = "0x40013F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public SettingsOverlayOptionCategories_Layout.Setting Magnify;

	// Token: 0x04000FAD RID: 4013
	[global::Cpp2ILInjected.Token(Token = "0x40013FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public SettingsOverlayOptionCategories_Layout.Setting TooltipTime;

	// Token: 0x04000FAE RID: 4014
	[global::Cpp2ILInjected.Token(Token = "0x40013FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public SettingsOverlayOptionCategories_Layout.Setting TooltipFadeTime;

	// Token: 0x04000FAF RID: 4015
	[global::Cpp2ILInjected.Token(Token = "0x40013FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public SettingsOverlayOptionCategories_Layout.Setting Parallex;

	// Token: 0x04000FB0 RID: 4016
	[global::Cpp2ILInjected.Token(Token = "0x40013FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public SettingsOverlayOptionCategories_Layout.Setting TooltipBackings;

	// Token: 0x04000FB1 RID: 4017
	[global::Cpp2ILInjected.Token(Token = "0x40013FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public SettingsOverlayOptionCategories_Layout.Setting FrameSkip;

	// Token: 0x04000FB2 RID: 4018
	[global::Cpp2ILInjected.Token(Token = "0x40013FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public SettingsOverlayOptionCategories_Layout.Setting BatterySavingMode;

	// Token: 0x04000FB3 RID: 4019
	[global::Cpp2ILInjected.Token(Token = "0x4001400")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public SettingsOverlayOptionCategories_Layout.Setting ScreenEffects;

	// Token: 0x04000FB4 RID: 4020
	[global::Cpp2ILInjected.Token(Token = "0x4001401")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public SettingsOverlayOptionCategories_Layout.Setting ShowFPS;

	// Token: 0x04000FB5 RID: 4021
	[global::Cpp2ILInjected.Token(Token = "0x4001402")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public SettingsOverlayOptionCategories_Layout.Setting BackgroundEnabled;

	// Token: 0x04000FB6 RID: 4022
	[global::Cpp2ILInjected.Token(Token = "0x4001403")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoPause;

	// Token: 0x04000FB7 RID: 4023
	[global::Cpp2ILInjected.Token(Token = "0x4001404")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public SettingsOverlayOptionCategories_Layout.Setting LockTutorials;

	// Token: 0x04000FB8 RID: 4024
	[global::Cpp2ILInjected.Token(Token = "0x4001405")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public SettingsOverlayOptionCategories_Layout.Setting LeftStickAiming;

	// Token: 0x04000FB9 RID: 4025
	[global::Cpp2ILInjected.Token(Token = "0x4001406")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public SettingsOverlayOptionCategories_Layout.Setting Language;

	// Token: 0x04000FBA RID: 4026
	[global::Cpp2ILInjected.Token(Token = "0x4001407")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public SettingsOverlayOptionCategories_Layout.Setting WikiButton;

	// Token: 0x04000FBB RID: 4027
	[global::Cpp2ILInjected.Token(Token = "0x4001408")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public SettingsOverlayOptionCategories_Layout.Setting ForumButton;

	// Token: 0x04000FBC RID: 4028
	[global::Cpp2ILInjected.Token(Token = "0x4001409")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public SettingsOverlayOptionCategories_Layout.Setting DiscordButton;

	// Token: 0x04000FBD RID: 4029
	[global::Cpp2ILInjected.Token(Token = "0x400140A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public SettingsOverlayOptionCategories_Layout.Setting SupportButton;

	// Token: 0x04000FBE RID: 4030
	[global::Cpp2ILInjected.Token(Token = "0x400140B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public SettingsOverlayOptionCategories_Layout.Setting YoutubeButton;

	// Token: 0x04000FBF RID: 4031
	[global::Cpp2ILInjected.Token(Token = "0x400140C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public SettingsOverlayOptionCategories_Layout.Setting TwitterButton;

	// Token: 0x04000FC0 RID: 4032
	[global::Cpp2ILInjected.Token(Token = "0x400140D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public SettingsOverlayOptionCategories_Layout.Setting PrivacyButton;

	// Token: 0x04000FC1 RID: 4033
	[global::Cpp2ILInjected.Token(Token = "0x400140E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public SettingsOverlayOptionCategories_Layout.Setting FacebookButton;

	// Token: 0x04000FC2 RID: 4034
	[global::Cpp2ILInjected.Token(Token = "0x400140F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public SettingsOverlayOptionCategories_Layout.Setting EditInterface;

	// Token: 0x04000FC3 RID: 4035
	[global::Cpp2ILInjected.Token(Token = "0x4001410")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public SettingsOverlayOptionCategories_Layout.Setting ResetCursorModes;

	// Token: 0x04000FC4 RID: 4036
	[global::Cpp2ILInjected.Token(Token = "0x4001411")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public SettingsOverlayOptionCategories_Layout.Setting BugReportButton;

	// Token: 0x04000FC5 RID: 4037
	[global::Cpp2ILInjected.Token(Token = "0x4001412")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public SettingsOverlayOptionCategories_Layout.Setting Credits;

	// Token: 0x04000FC6 RID: 4038
	[global::Cpp2ILInjected.Token(Token = "0x4001413")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public SettingsOverlayOptionCategories_Layout.Setting RedditButton;

	// Token: 0x04000FC7 RID: 4039
	[global::Cpp2ILInjected.Token(Token = "0x4001414")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public SettingsOverlayOptionCategories_Layout.Setting LeftStickJump;

	// Token: 0x04000FC8 RID: 4040
	[global::Cpp2ILInjected.Token(Token = "0x4001415")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSwing;

	// Token: 0x04000FC9 RID: 4041
	[global::Cpp2ILInjected.Token(Token = "0x4001416")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public SettingsOverlayOptionCategories_Layout.Setting UITexturesHigh;

	// Token: 0x04000FCA RID: 4042
	[global::Cpp2ILInjected.Token(Token = "0x4001417")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public SettingsOverlayOptionCategories_Layout.Setting CharacterTexturesHigh;

	// Token: 0x04000FCB RID: 4043
	[global::Cpp2ILInjected.Token(Token = "0x4001418")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public SettingsOverlayOptionCategories_Layout.Setting ProjectilesTexturesHigh;

	// Token: 0x04000FCC RID: 4044
	[global::Cpp2ILInjected.Token(Token = "0x4001419")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public SettingsOverlayOptionCategories_Layout.Setting BackgroundTexturesHigh;

	// Token: 0x04000FCD RID: 4045
	[global::Cpp2ILInjected.Token(Token = "0x400141A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public SettingsOverlayOptionCategories_Layout.Setting GoreTexturesHigh;

	// Token: 0x04000FCE RID: 4046
	[global::Cpp2ILInjected.Token(Token = "0x400141B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	public SettingsOverlayOptionCategories_Layout.Setting GlowTexturesHigh;

	// Token: 0x04000FCF RID: 4047
	[global::Cpp2ILInjected.Token(Token = "0x400141C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
	public SettingsOverlayOptionCategories_Layout.Setting EnvironmentTexturesHigh;

	// Token: 0x04000FD0 RID: 4048
	[global::Cpp2ILInjected.Token(Token = "0x400141D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
	public SettingsOverlayOptionCategories_Layout.Setting Controls;

	// Token: 0x04000FD1 RID: 4049
	[global::Cpp2ILInjected.Token(Token = "0x400141E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
	public SettingsOverlayOptionCategories_Layout.Setting EditControllerMappings;

	// Token: 0x04000FD2 RID: 4050
	[global::Cpp2ILInjected.Token(Token = "0x400141F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
	public SettingsOverlayOptionCategories_Layout.Setting ChatOrder;

	// Token: 0x04000FD3 RID: 4051
	[global::Cpp2ILInjected.Token(Token = "0x4001420")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
	public SettingsOverlayOptionCategories_Layout.Setting PasswordVisibility;

	// Token: 0x04000FD4 RID: 4052
	[global::Cpp2ILInjected.Token(Token = "0x4001421")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
	public SettingsOverlayOptionCategories_Layout.Setting PinchZoom;

	// Token: 0x04000FD5 RID: 4053
	[global::Cpp2ILInjected.Token(Token = "0x4001422")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
	public SettingsOverlayOptionCategories_Layout.Setting PinchZoomMap;

	// Token: 0x04000FD6 RID: 4054
	[global::Cpp2ILInjected.Token(Token = "0x4001423")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchPadPinchZoom;

	// Token: 0x04000FD7 RID: 4055
	[global::Cpp2ILInjected.Token(Token = "0x4001424")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchPadPinchZoomMap;

	// Token: 0x04000FD8 RID: 4056
	[global::Cpp2ILInjected.Token(Token = "0x4001425")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchAimSensitivity;

	// Token: 0x04000FD9 RID: 4057
	[global::Cpp2ILInjected.Token(Token = "0x4001426")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchSmartCursorMode;

	// Token: 0x04000FDA RID: 4058
	[global::Cpp2ILInjected.Token(Token = "0x4001427")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x268")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchAimAndUseMode;

	// Token: 0x04000FDB RID: 4059
	[global::Cpp2ILInjected.Token(Token = "0x4001428")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x270")]
	public SettingsOverlayOptionCategories_Layout.Setting EditVirtualControls;

	// Token: 0x04000FDC RID: 4060
	[global::Cpp2ILInjected.Token(Token = "0x4001429")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x278")]
	public SettingsOverlayOptionCategories_Layout.Setting KeyboardMouse;

	// Token: 0x04000FDD RID: 4061
	[global::Cpp2ILInjected.Token(Token = "0x400142A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x280")]
	public SettingsOverlayOptionCategories_Layout.Setting EditKeyboardMappings;

	// Token: 0x04000FDE RID: 4062
	[global::Cpp2ILInjected.Token(Token = "0x400142B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x288")]
	public SettingsOverlayOptionCategories_Layout.Setting EditControllerProfile;

	// Token: 0x04000FDF RID: 4063
	[global::Cpp2ILInjected.Token(Token = "0x400142C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x290")]
	public SettingsOverlayOptionCategories_Layout.Setting LightingMode;

	// Token: 0x04000FE0 RID: 4064
	[global::Cpp2ILInjected.Token(Token = "0x400142D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x298")]
	public SettingsOverlayOptionCategories_Layout.Setting GraphicsQuality;

	// Token: 0x04000FE1 RID: 4065
	[global::Cpp2ILInjected.Token(Token = "0x400142E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A0")]
	public SettingsOverlayOptionCategories_Layout.Setting EscapeKeyMode;

	// Token: 0x04000FE2 RID: 4066
	[global::Cpp2ILInjected.Token(Token = "0x400142F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A8")]
	public SettingsOverlayOptionCategories_Layout.Setting EditTextureSettings;

	// Token: 0x04000FE3 RID: 4067
	[global::Cpp2ILInjected.Token(Token = "0x4001430")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B0")]
	public SettingsOverlayOptionCategories_Layout.Setting ViewSocial;

	// Token: 0x04000FE4 RID: 4068
	[global::Cpp2ILInjected.Token(Token = "0x4001431")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
	public SettingsOverlayOptionCategories_Layout.Setting ViewMoreInfo;

	// Token: 0x04000FE5 RID: 4069
	[global::Cpp2ILInjected.Token(Token = "0x4001432")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
	public SettingsOverlayOptionCategories_Layout.Setting SplitscreenPrimarySplit;

	// Token: 0x04000FE6 RID: 4070
	[global::Cpp2ILInjected.Token(Token = "0x4001433")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C8")]
	public SettingsOverlayOptionCategories_Layout.Setting SmartCursorModeToggleHold;

	// Token: 0x04000FE7 RID: 4071
	[global::Cpp2ILInjected.Token(Token = "0x4001434")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
	public SettingsOverlayOptionCategories_Layout.Setting SmartCursorPriority;

	// Token: 0x04000FE8 RID: 4072
	[global::Cpp2ILInjected.Token(Token = "0x4001435")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D8")]
	public SettingsOverlayOptionCategories_Layout.Setting SmartCursorBlockPlacement;

	// Token: 0x04000FE9 RID: 4073
	[global::Cpp2ILInjected.Token(Token = "0x4001436")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
	public SettingsOverlayOptionCategories_Layout.Setting PlacementGrid;

	// Token: 0x04000FEA RID: 4074
	[global::Cpp2ILInjected.Token(Token = "0x4001437")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E8")]
	public SettingsOverlayOptionCategories_Layout.Setting MinersWobble;

	// Token: 0x04000FEB RID: 4075
	[global::Cpp2ILInjected.Token(Token = "0x4001438")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F0")]
	public SettingsOverlayOptionCategories_Layout.Setting WindyEnvironment;

	// Token: 0x04000FEC RID: 4076
	[global::Cpp2ILInjected.Token(Token = "0x4001439")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F8")]
	public SettingsOverlayOptionCategories_Layout.Setting KeyboardMouseSmartCursorMode;

	// Token: 0x04000FED RID: 4077
	[global::Cpp2ILInjected.Token(Token = "0x400143A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x300")]
	public SettingsOverlayOptionCategories_Layout.Setting WaterQuality;

	// Token: 0x04000FEE RID: 4078
	[global::Cpp2ILInjected.Token(Token = "0x400143B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x308")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSaveFrequency;

	// Token: 0x04000FEF RID: 4079
	[global::Cpp2ILInjected.Token(Token = "0x400143C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x310")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerCraftToInventory;

	// Token: 0x04000FF0 RID: 4080
	[global::Cpp2ILInjected.Token(Token = "0x400143D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x318")]
	public SettingsOverlayOptionCategories_Layout.Setting EditSafeRegion;

	// Token: 0x04000FF1 RID: 4081
	[global::Cpp2ILInjected.Token(Token = "0x400143E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x320")]
	public SettingsOverlayOptionCategories_Layout.Setting BuildGridSnap;

	// Token: 0x04000FF2 RID: 4082
	[global::Cpp2ILInjected.Token(Token = "0x400143F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x328")]
	public SettingsOverlayOptionCategories_Layout.Setting InterfaceAdvanced;

	// Token: 0x04000FF3 RID: 4083
	[global::Cpp2ILInjected.Token(Token = "0x4001440")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x330")]
	public SettingsOverlayOptionCategories_Layout.Setting VideoAdvanced;

	// Token: 0x04000FF4 RID: 4084
	[global::Cpp2ILInjected.Token(Token = "0x4001441")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x338")]
	public SettingsOverlayOptionCategories_Layout.Setting GameplayControlsAdvanced;

	// Token: 0x04000FF5 RID: 4085
	[global::Cpp2ILInjected.Token(Token = "0x4001442")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x340")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchAdvanced;

	// Token: 0x04000FF6 RID: 4086
	[global::Cpp2ILInjected.Token(Token = "0x4001443")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x348")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerAdvanced;

	// Token: 0x04000FF7 RID: 4087
	[global::Cpp2ILInjected.Token(Token = "0x4001444")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x350")]
	public SettingsOverlayOptionCategories_Layout.Setting KeyboardMouseAdvanced;

	// Token: 0x04000FF8 RID: 4088
	[global::Cpp2ILInjected.Token(Token = "0x4001445")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x358")]
	public SettingsOverlayOptionCategories_Layout.Setting MouseCursor;

	// Token: 0x04000FF9 RID: 4089
	[global::Cpp2ILInjected.Token(Token = "0x4001446")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x360")]
	public SettingsOverlayOptionCategories_Layout.Setting MouseCursorValue;

	// Token: 0x04000FFA RID: 4090
	[global::Cpp2ILInjected.Token(Token = "0x4001447")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x368")]
	public SettingsOverlayOptionCategories_Layout.Setting MouseCursorBorderValue;

	// Token: 0x04000FFB RID: 4091
	[global::Cpp2ILInjected.Token(Token = "0x4001448")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x370")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchCursor;

	// Token: 0x04000FFC RID: 4092
	[global::Cpp2ILInjected.Token(Token = "0x4001449")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x378")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchCursorValue;

	// Token: 0x04000FFD RID: 4093
	[global::Cpp2ILInjected.Token(Token = "0x400144A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x380")]
	public SettingsOverlayOptionCategories_Layout.Setting TouchCursorBorderValue;

	// Token: 0x04000FFE RID: 4094
	[global::Cpp2ILInjected.Token(Token = "0x400144B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x388")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerCursor;

	// Token: 0x04000FFF RID: 4095
	[global::Cpp2ILInjected.Token(Token = "0x400144C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x390")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerCursorValue;

	// Token: 0x04001000 RID: 4096
	[global::Cpp2ILInjected.Token(Token = "0x400144D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x398")]
	public SettingsOverlayOptionCategories_Layout.Setting ControllerCursorBorderValue;

	// Token: 0x04001001 RID: 4097
	[global::Cpp2ILInjected.Token(Token = "0x400144E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A0")]
	public SettingsOverlayOptionCategories_Layout.Setting PageCollapseMode;

	// Token: 0x04001002 RID: 4098
	[global::Cpp2ILInjected.Token(Token = "0x400144F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A8")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSelectModeTouch;

	// Token: 0x04001003 RID: 4099
	[global::Cpp2ILInjected.Token(Token = "0x4001450")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B0")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSelectModeController;

	// Token: 0x04001004 RID: 4100
	[global::Cpp2ILInjected.Token(Token = "0x4001451")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B8")]
	public SettingsOverlayOptionCategories_Layout.Setting AutoSelectModeKeyboard;

	// Token: 0x04001005 RID: 4101
	[global::Cpp2ILInjected.Token(Token = "0x4001452")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C0")]
	public SettingsOverlayOptionCategories_Layout.Setting InventoryCameraMovement;

	// Token: 0x04001006 RID: 4102
	[global::Cpp2ILInjected.Token(Token = "0x4001453")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C8")]
	public SettingsOverlayOptionCategories_Layout.Setting PrimaryInput;

	// Token: 0x04001007 RID: 4103
	[global::Cpp2ILInjected.Token(Token = "0x4001454")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D0")]
	public SettingsOverlayOptionCategories_Layout.Setting ScrollSensitivity;

	// Token: 0x04001008 RID: 4104
	[global::Cpp2ILInjected.Token(Token = "0x4001455")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D8")]
	public SettingsOverlayOptionCategories_Layout.Setting ResetAll;

	// Token: 0x020007EB RID: 2027
	[global::Cpp2ILInjected.Token(Token = "0x2000216")]
	public enum Category
	{
		// Token: 0x04007C18 RID: 31768
		[global::Cpp2ILInjected.Token(Token = "0x4001457")]
		General,
		// Token: 0x04007C19 RID: 31769
		[global::Cpp2ILInjected.Token(Token = "0x4001458")]
		Video,
		// Token: 0x04007C1A RID: 31770
		[global::Cpp2ILInjected.Token(Token = "0x4001459")]
		Interface,
		// Token: 0x04007C1B RID: 31771
		[global::Cpp2ILInjected.Token(Token = "0x400145A")]
		Links,
		// Token: 0x04007C1C RID: 31772
		[global::Cpp2ILInjected.Token(Token = "0x400145B")]
		Touch,
		// Token: 0x04007C1D RID: 31773
		[global::Cpp2ILInjected.Token(Token = "0x400145C")]
		Controller,
		// Token: 0x04007C1E RID: 31774
		[global::Cpp2ILInjected.Token(Token = "0x400145D")]
		Sound,
		// Token: 0x04007C1F RID: 31775
		[global::Cpp2ILInjected.Token(Token = "0x400145E")]
		MoreInfo,
		// Token: 0x04007C20 RID: 31776
		[global::Cpp2ILInjected.Token(Token = "0x400145F")]
		TextureQuality,
		// Token: 0x04007C21 RID: 31777
		[global::Cpp2ILInjected.Token(Token = "0x4001460")]
		KeyboardMouse,
		// Token: 0x04007C22 RID: 31778
		[global::Cpp2ILInjected.Token(Token = "0x4001461")]
		GameplayControls,
		// Token: 0x04007C23 RID: 31779
		[global::Cpp2ILInjected.Token(Token = "0x4001462")]
		InterfaceAdvanced,
		// Token: 0x04007C24 RID: 31780
		[global::Cpp2ILInjected.Token(Token = "0x4001463")]
		VideoAdvanced,
		// Token: 0x04007C25 RID: 31781
		[global::Cpp2ILInjected.Token(Token = "0x4001464")]
		GameplayControlsAdvanced,
		// Token: 0x04007C26 RID: 31782
		[global::Cpp2ILInjected.Token(Token = "0x4001465")]
		TouchAdvanced,
		// Token: 0x04007C27 RID: 31783
		[global::Cpp2ILInjected.Token(Token = "0x4001466")]
		ControllerAdvanced,
		// Token: 0x04007C28 RID: 31784
		[global::Cpp2ILInjected.Token(Token = "0x4001467")]
		KeyboardMouseAdvanced,
		// Token: 0x04007C29 RID: 31785
		[global::Cpp2ILInjected.Token(Token = "0x4001468")]
		KeyboardMouseCursor,
		// Token: 0x04007C2A RID: 31786
		[global::Cpp2ILInjected.Token(Token = "0x4001469")]
		ControllerCursor,
		// Token: 0x04007C2B RID: 31787
		[global::Cpp2ILInjected.Token(Token = "0x400146A")]
		TouchCursor
	}

	// Token: 0x020007EC RID: 2028
	[global::Cpp2ILInjected.Token(Token = "0x2000217")]
	[Serializable]
	public class Setting
	{
		// Token: 0x060048E8 RID: 18664 RVA: 0x0002EF0D File Offset: 0x0002D10D
		[global::Cpp2ILInjected.Token(Token = "0x6000CC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D0324", Offset = "0x9D0324", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Setting()
		{
			throw null;
		}

		// Token: 0x04007C2C RID: 31788
		[global::Cpp2ILInjected.Token(Token = "0x400146B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public SettingsOverlayOptionCategories_Layout.Category Category;

		// Token: 0x04007C2D RID: 31789
		[global::Cpp2ILInjected.Token(Token = "0x400146C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int SortOrder;
	}
}
