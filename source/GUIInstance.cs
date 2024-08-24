using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.UI;

// Token: 0x020000E5 RID: 229
[global::Cpp2ILInjected.Token(Token = "0x200014A")]
public class GUIInstance
{
	// Token: 0x06000802 RID: 2050 RVA: 0x0002334B File Offset: 0x0002154B
	[global::Cpp2ILInjected.Token(Token = "0x60008FC")]
	[global::Cpp2ILInjected.Address(RVA = "0x91461C", Offset = "0x91461C", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChestSplitStack), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuilderAccToggles), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAccessoryInfoToggles), Member = "CloseExpandedFilter", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipmentLoadout), Member = "CloseExpandedFilter", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemFilter), Member = "CloseExpandedFilter", ReturnType = typeof(void))]
	public void ClosePopups()
	{
		throw null;
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x0002334E File Offset: 0x0002154E
	[global::Cpp2ILInjected.Token(Token = "0x60008FD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9146F8", Offset = "0x9146F8", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "OpenPopup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "SetDisplayingEmotes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "PlayerOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforgePopup), Member = "OpenPopup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "Open", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "Draw", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "DrawHUD", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "HandleNetworkLost", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "KillMe", MemberParameters = new object[]
	{
		typeof(PlayerDeathReason),
		typeof(double),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWiresUI), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIResearch), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReforgePopup), Member = "ClosePopup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "ClosePopup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "SetDisplayingEmotes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CancelClothesWindow", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CancelHairWindow", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void CloseDialoguesAndPopups()
	{
		throw null;
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00023351 File Offset: 0x00021551
	[global::Cpp2ILInjected.Token(Token = "0x60008FE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9147B4", Offset = "0x9147B4", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "PageOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CancelClothesWindow", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CancelHairWindow", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINPCDialogue), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void CloseNonPageDialogues()
	{
		throw null;
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00023354 File Offset: 0x00021554
	[global::Cpp2ILInjected.Token(Token = "0x60008FF")]
	[global::Cpp2ILInjected.Address(RVA = "0x91483C", Offset = "0x91483C", Length = "0x1510")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAccessoryInfo), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMenuNameEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReforgePopup), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAmmo), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBossBar), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuffs), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButtonBar), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChestQuickStack), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChestSplitStack), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIClothesWindow), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICoins), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsStatusIndicators), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuide), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICrafting), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDisplayDoll), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipmentUtility), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEvents), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHairWindow), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHatRack), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIResearchPage), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHotbar), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWiresUI), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventorySplitStack), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemDuplication), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerChat), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINetplayStatusText), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINPCDialogue), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIProfileSwitch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPVPIcons), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReforge), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIScrollControl), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsPauseMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIShop), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITrashCan), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldOperationProgress), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIZoom), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICredits), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDeleteDedicatedServer), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDeletePlayer), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDeleteWorld), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIErrorScreen), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIFileSyncInProgress), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILogo), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowDiskSpacePopup), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowMemoryPopup), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowMemorySetttings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMainMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerHost), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerJoin), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerServerIP), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerServerPassword), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerServerPort), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerServerRequestedPassword), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerWaitingHost), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINetPlayStatusMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerAndGameModeMismatch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerNameMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuitConfirm), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIResetSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISafeRegionEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStatusMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageGroupEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldCreateMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldGenerateMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldLoadBackup), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldNameMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldNoBackup), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITalkerList), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDisconnected), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAccessoryInfoToggles), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipmentLoadout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIResearch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuilderAccToggles), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPS4MultiplayerChecks), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReturnToTouch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 228)]
	public GUIInstance()
	{
		throw null;
	}

	// Token: 0x0400057A RID: 1402
	[global::Cpp2ILInjected.Token(Token = "0x40007D5")]
	public static GUIInstance Active;

	// Token: 0x0400057B RID: 1403
	[global::Cpp2ILInjected.Token(Token = "0x40007D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public XNAUnityRunner.ForcedInputMode LastPrimaryInputMode;

	// Token: 0x0400057C RID: 1404
	[global::Cpp2ILInjected.Token(Token = "0x40007D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public InterfaceProfile_Layout _active;

	// Token: 0x0400057D RID: 1405
	[global::Cpp2ILInjected.Token(Token = "0x40007D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool UseLargeMinimap;

	// Token: 0x0400057E RID: 1406
	[global::Cpp2ILInjected.Token(Token = "0x40007D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public GUIControllerNavigationController GUIControllerNavigationController;

	// Token: 0x0400057F RID: 1407
	[global::Cpp2ILInjected.Token(Token = "0x40007DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIControllerPageRedirect GUIControllerPageRedirect;

	// Token: 0x04000580 RID: 1408
	[global::Cpp2ILInjected.Token(Token = "0x40007DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public GUIVirtualInputController GUIVirtualInputController;

	// Token: 0x04000581 RID: 1409
	[global::Cpp2ILInjected.Token(Token = "0x40007DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public GUIAccessoryInfo GUIAccessoryInfo;

	// Token: 0x04000582 RID: 1410
	[global::Cpp2ILInjected.Token(Token = "0x40007DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public GUIMenuNameEdit GUIMenuNameEdit;

	// Token: 0x04000583 RID: 1411
	[global::Cpp2ILInjected.Token(Token = "0x40007DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public GUIReforgePopup GUIReforgePopup;

	// Token: 0x04000584 RID: 1412
	[global::Cpp2ILInjected.Token(Token = "0x40007DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public GUIAmmo GUIAmmo;

	// Token: 0x04000585 RID: 1413
	[global::Cpp2ILInjected.Token(Token = "0x40007E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public GUIBossBar GUIBossBar;

	// Token: 0x04000586 RID: 1414
	[global::Cpp2ILInjected.Token(Token = "0x40007E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public GUIBuffs GUIBuffs;

	// Token: 0x04000587 RID: 1415
	[global::Cpp2ILInjected.Token(Token = "0x40007E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public GUIButtonBar GUIButtonBar;

	// Token: 0x04000588 RID: 1416
	[global::Cpp2ILInjected.Token(Token = "0x40007E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public GUIChest GUIChest;

	// Token: 0x04000589 RID: 1417
	[global::Cpp2ILInjected.Token(Token = "0x40007E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public GUIChestQuickStack GUIChestQuickStack;

	// Token: 0x0400058A RID: 1418
	[global::Cpp2ILInjected.Token(Token = "0x40007E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public GUIChestSplitStack GUIChestSplitStack;

	// Token: 0x0400058B RID: 1419
	[global::Cpp2ILInjected.Token(Token = "0x40007E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public GUIClothesWindow GUIClothesWindow;

	// Token: 0x0400058C RID: 1420
	[global::Cpp2ILInjected.Token(Token = "0x40007E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public GUICoins GUICoins;

	// Token: 0x0400058D RID: 1421
	[global::Cpp2ILInjected.Token(Token = "0x40007E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public GUIControlsBanner GUIControlsBanner;

	// Token: 0x0400058E RID: 1422
	[global::Cpp2ILInjected.Token(Token = "0x40007E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public GUIControlsStatusIndicators GUIControlsStatusIndicators;

	// Token: 0x0400058F RID: 1423
	[global::Cpp2ILInjected.Token(Token = "0x40007EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public GUICraftGuide GUICraftGuide;

	// Token: 0x04000590 RID: 1424
	[global::Cpp2ILInjected.Token(Token = "0x40007EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public GUICraftGuidePopup GUICraftGuidePopup;

	// Token: 0x04000591 RID: 1425
	[global::Cpp2ILInjected.Token(Token = "0x40007EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public GUICrafting GUICrafting;

	// Token: 0x04000592 RID: 1426
	[global::Cpp2ILInjected.Token(Token = "0x40007ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public GUIDisplayDoll GUIDisplayDoll;

	// Token: 0x04000593 RID: 1427
	[global::Cpp2ILInjected.Token(Token = "0x40007EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public GUIEmotesWindow GUIEmotesWindow;

	// Token: 0x04000594 RID: 1428
	[global::Cpp2ILInjected.Token(Token = "0x40007EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public GUIEquipment GUIEquipment;

	// Token: 0x04000595 RID: 1429
	[global::Cpp2ILInjected.Token(Token = "0x40007F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public GUIEquipmentUtility GUIEquipmentUtility;

	// Token: 0x04000596 RID: 1430
	[global::Cpp2ILInjected.Token(Token = "0x40007F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public GUIEvents GUIEvents;

	// Token: 0x04000597 RID: 1431
	[global::Cpp2ILInjected.Token(Token = "0x40007F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public GUIHairWindow GUIHairWindow;

	// Token: 0x04000598 RID: 1432
	[global::Cpp2ILInjected.Token(Token = "0x40007F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public GUIHatRack GUIHatRack;

	// Token: 0x04000599 RID: 1433
	[global::Cpp2ILInjected.Token(Token = "0x40007F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public GUIResearchPage GUIResearchPage;

	// Token: 0x0400059A RID: 1434
	[global::Cpp2ILInjected.Token(Token = "0x40007F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public GUIHearts GUIHearts;

	// Token: 0x0400059B RID: 1435
	[global::Cpp2ILInjected.Token(Token = "0x40007F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public GUIHotbar GUIHotbar;

	// Token: 0x0400059C RID: 1436
	[global::Cpp2ILInjected.Token(Token = "0x40007F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public GUIHousingMenu GUIHousingMenu;

	// Token: 0x0400059D RID: 1437
	[global::Cpp2ILInjected.Token(Token = "0x40007F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public GUIInventory GUIInventory;

	// Token: 0x0400059E RID: 1438
	[global::Cpp2ILInjected.Token(Token = "0x40007F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public GUIWiresUI GUIWiresUI;

	// Token: 0x0400059F RID: 1439
	[global::Cpp2ILInjected.Token(Token = "0x40007FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public GUIRubbleMaker GUIRubbleMaker;

	// Token: 0x040005A0 RID: 1440
	[global::Cpp2ILInjected.Token(Token = "0x40007FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public GUIInventorySplitStack GUIInventorySplitStack;

	// Token: 0x040005A1 RID: 1441
	[global::Cpp2ILInjected.Token(Token = "0x40007FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public GUIInventoryTransactions GUIInventoryTransactions;

	// Token: 0x040005A2 RID: 1442
	[global::Cpp2ILInjected.Token(Token = "0x40007FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public GUIItemDuplication GUIItemDuplication;

	// Token: 0x040005A3 RID: 1443
	[global::Cpp2ILInjected.Token(Token = "0x40007FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public GUIMagnify GUIMagnify;

	// Token: 0x040005A4 RID: 1444
	[global::Cpp2ILInjected.Token(Token = "0x40007FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public GUIMana GUIMana;

	// Token: 0x040005A5 RID: 1445
	[global::Cpp2ILInjected.Token(Token = "0x4000800")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public GUIMap GUIMap;

	// Token: 0x040005A6 RID: 1446
	[global::Cpp2ILInjected.Token(Token = "0x4000801")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public GUIMouseItem GUIMouseItem;

	// Token: 0x040005A7 RID: 1447
	[global::Cpp2ILInjected.Token(Token = "0x4000802")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public GUIMultiplayerChat GUIMultiplayerChat;

	// Token: 0x040005A8 RID: 1448
	[global::Cpp2ILInjected.Token(Token = "0x4000803")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public GUIMultiplayerChat GUIMultiplayerChatPage;

	// Token: 0x040005A9 RID: 1449
	[global::Cpp2ILInjected.Token(Token = "0x4000804")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public GUINetplayStatusText GUINetplayStatusText;

	// Token: 0x040005AA RID: 1450
	[global::Cpp2ILInjected.Token(Token = "0x4000805")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public GUINPCDialogue GUINPCDialogue;

	// Token: 0x040005AB RID: 1451
	[global::Cpp2ILInjected.Token(Token = "0x4000806")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public GUIPageIcons GUIPageIcons;

	// Token: 0x040005AC RID: 1452
	[global::Cpp2ILInjected.Token(Token = "0x4000807")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public GUIProfileSwitch GUIProfileSwitch;

	// Token: 0x040005AD RID: 1453
	[global::Cpp2ILInjected.Token(Token = "0x4000808")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public GUIPVPIcons GUIPVPIcons;

	// Token: 0x040005AE RID: 1454
	[global::Cpp2ILInjected.Token(Token = "0x4000809")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public GUIReforge GUIReforge;

	// Token: 0x040005AF RID: 1455
	[global::Cpp2ILInjected.Token(Token = "0x400080A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public GUIScrollControl GUIScrollControl;

	// Token: 0x040005B0 RID: 1456
	[global::Cpp2ILInjected.Token(Token = "0x400080B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public GUIJourneyModeSettings GUIJourneyModeSettings;

	// Token: 0x040005B1 RID: 1457
	[global::Cpp2ILInjected.Token(Token = "0x400080C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public GUISettings GUISettings;

	// Token: 0x040005B2 RID: 1458
	[global::Cpp2ILInjected.Token(Token = "0x400080D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public GUISettingsPauseMenu GUISettingsPauseMenu;

	// Token: 0x040005B3 RID: 1459
	[global::Cpp2ILInjected.Token(Token = "0x400080E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public GUIShop GUIShop;

	// Token: 0x040005B4 RID: 1460
	[global::Cpp2ILInjected.Token(Token = "0x400080F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public GUITrashCan GUITrashCan;

	// Token: 0x040005B5 RID: 1461
	[global::Cpp2ILInjected.Token(Token = "0x4000810")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public GUIWorldOperationProgress GUIWorldOperationProgress;

	// Token: 0x040005B6 RID: 1462
	[global::Cpp2ILInjected.Token(Token = "0x4000811")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public GUIZoom GUIZoom;

	// Token: 0x040005B7 RID: 1463
	[global::Cpp2ILInjected.Token(Token = "0x4000812")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public GUIAchievementsMenu GUIAchievementsMenu;

	// Token: 0x040005B8 RID: 1464
	[global::Cpp2ILInjected.Token(Token = "0x4000813")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public GUICredits GUICredits;

	// Token: 0x040005B9 RID: 1465
	[global::Cpp2ILInjected.Token(Token = "0x4000814")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public GUIDeleteDedicatedServer GUIDeleteDedicatedServer;

	// Token: 0x040005BA RID: 1466
	[global::Cpp2ILInjected.Token(Token = "0x4000815")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	public GUIDeletePlayer GUIDeletePlayer;

	// Token: 0x040005BB RID: 1467
	[global::Cpp2ILInjected.Token(Token = "0x4000816")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
	public GUIDeleteWorld GUIDeleteWorld;

	// Token: 0x040005BC RID: 1468
	[global::Cpp2ILInjected.Token(Token = "0x4000817")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
	public GUIErrorScreen GUIErrorScreen;

	// Token: 0x040005BD RID: 1469
	[global::Cpp2ILInjected.Token(Token = "0x4000818")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
	public GUIFileSyncInProgress GUIFileSyncInProgress;

	// Token: 0x040005BE RID: 1470
	[global::Cpp2ILInjected.Token(Token = "0x4000819")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
	public GUIInterfaceEdit GUIInterfaceEdit;

	// Token: 0x040005BF RID: 1471
	[global::Cpp2ILInjected.Token(Token = "0x400081A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
	public GUILogo GUILogo;

	// Token: 0x040005C0 RID: 1472
	[global::Cpp2ILInjected.Token(Token = "0x400081B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
	public GUILowDiskSpacePopup GUILowDiskSpacePopup;

	// Token: 0x040005C1 RID: 1473
	[global::Cpp2ILInjected.Token(Token = "0x400081C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
	public GUILowMemoryPopup GUILowMemoryPopup;

	// Token: 0x040005C2 RID: 1474
	[global::Cpp2ILInjected.Token(Token = "0x400081D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
	public GUILowMemorySetttings GUILowMemorySetttings;

	// Token: 0x040005C3 RID: 1475
	[global::Cpp2ILInjected.Token(Token = "0x400081E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
	public GUIMainMenu GUIMainMenu;

	// Token: 0x040005C4 RID: 1476
	[global::Cpp2ILInjected.Token(Token = "0x400081F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
	public GUIMultiplayerHost GUIMultiplayerHost;

	// Token: 0x040005C5 RID: 1477
	[global::Cpp2ILInjected.Token(Token = "0x4000820")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
	public GUIMultiplayerJoin GUIMultiplayerJoin;

	// Token: 0x040005C6 RID: 1478
	[global::Cpp2ILInjected.Token(Token = "0x4000821")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x268")]
	public GUIMultiplayerLobby GUIMultiplayerLobby;

	// Token: 0x040005C7 RID: 1479
	[global::Cpp2ILInjected.Token(Token = "0x4000822")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x270")]
	public GUIMultiplayerMenu GUIMultiplayerMenu;

	// Token: 0x040005C8 RID: 1480
	[global::Cpp2ILInjected.Token(Token = "0x4000823")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x278")]
	public GUIMultiplayerServerIP GUIMultiplayerServerIP;

	// Token: 0x040005C9 RID: 1481
	[global::Cpp2ILInjected.Token(Token = "0x4000824")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x280")]
	public GUIMultiplayerServerPassword GUIMultiplayerServerPassword;

	// Token: 0x040005CA RID: 1482
	[global::Cpp2ILInjected.Token(Token = "0x4000825")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x288")]
	public GUIMultiplayerServerPort GUIMultiplayerServerPort;

	// Token: 0x040005CB RID: 1483
	[global::Cpp2ILInjected.Token(Token = "0x4000826")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x290")]
	public GUIMultiplayerServerRequestedPassword GUIMultiplayerServerRequestedPassword;

	// Token: 0x040005CC RID: 1484
	[global::Cpp2ILInjected.Token(Token = "0x4000827")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x298")]
	public GUIMultiplayerWaitingHost GUIMultiplayerWaitingHost;

	// Token: 0x040005CD RID: 1485
	[global::Cpp2ILInjected.Token(Token = "0x4000828")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A0")]
	public GUINetPlayStatusMenu GUINetPlayStatusMenu;

	// Token: 0x040005CE RID: 1486
	[global::Cpp2ILInjected.Token(Token = "0x4000829")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A8")]
	public GUIPlayerAndGameModeMismatch GUIPlayerAndGameModeMismatch;

	// Token: 0x040005CF RID: 1487
	[global::Cpp2ILInjected.Token(Token = "0x400082A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B0")]
	public GUIPlayerCreateMenu GUIPlayerCreateMenu;

	// Token: 0x040005D0 RID: 1488
	[global::Cpp2ILInjected.Token(Token = "0x400082B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
	public GUIPlayerNameMenu GUIPlayerNameMenu;

	// Token: 0x040005D1 RID: 1489
	[global::Cpp2ILInjected.Token(Token = "0x400082C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
	public GUIPlayerSelectMenu GUIPlayerSelectMenu;

	// Token: 0x040005D2 RID: 1490
	[global::Cpp2ILInjected.Token(Token = "0x400082D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C8")]
	public GUIQuitConfirm GUIQuitConfirm;

	// Token: 0x040005D3 RID: 1491
	[global::Cpp2ILInjected.Token(Token = "0x400082E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
	public GUIResetSettings GUIResetSettings;

	// Token: 0x040005D4 RID: 1492
	[global::Cpp2ILInjected.Token(Token = "0x400082F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D8")]
	public GUISafeRegionEdit GUISafeRegionEdit;

	// Token: 0x040005D5 RID: 1493
	[global::Cpp2ILInjected.Token(Token = "0x4000830")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
	public GUISettingsOverlay GUISettingsOverlay;

	// Token: 0x040005D6 RID: 1494
	[global::Cpp2ILInjected.Token(Token = "0x4000831")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E8")]
	public GUIStatusMenu GUIStatusMenu;

	// Token: 0x040005D7 RID: 1495
	[global::Cpp2ILInjected.Token(Token = "0x4000832")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F0")]
	public GUIVirtualInputControllerEdit GUIVirtualInputControllerEdit;

	// Token: 0x040005D8 RID: 1496
	[global::Cpp2ILInjected.Token(Token = "0x4000833")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F8")]
	public GUIPageGroupEdit GUIPageGroupEdit;

	// Token: 0x040005D9 RID: 1497
	[global::Cpp2ILInjected.Token(Token = "0x4000834")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x300")]
	public GUIWorldCreateMenu GUIWorldCreateMenu;

	// Token: 0x040005DA RID: 1498
	[global::Cpp2ILInjected.Token(Token = "0x4000835")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x308")]
	public GUIWorldGenerateMenu GUIWorldGenerateMenu;

	// Token: 0x040005DB RID: 1499
	[global::Cpp2ILInjected.Token(Token = "0x4000836")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x310")]
	public GUIWorldLoadBackup GUIWorldLoadBackup;

	// Token: 0x040005DC RID: 1500
	[global::Cpp2ILInjected.Token(Token = "0x4000837")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x318")]
	public GUIWorldNameMenu GUIWorldNameMenu;

	// Token: 0x040005DD RID: 1501
	[global::Cpp2ILInjected.Token(Token = "0x4000838")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x320")]
	public GUIWorldNoBackup GUIWorldNoBackup;

	// Token: 0x040005DE RID: 1502
	[global::Cpp2ILInjected.Token(Token = "0x4000839")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x328")]
	public GUIWorldSelectMenu GUIWorldSelectMenu;

	// Token: 0x040005DF RID: 1503
	[global::Cpp2ILInjected.Token(Token = "0x400083A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x330")]
	public GUIPageOptions GUIPageOptions;

	// Token: 0x040005E0 RID: 1504
	[global::Cpp2ILInjected.Token(Token = "0x400083B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x338")]
	public GUITalkerList GUITalkerList;

	// Token: 0x040005E1 RID: 1505
	[global::Cpp2ILInjected.Token(Token = "0x400083C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x340")]
	public GUIControllerDisconnected GUIControllerDisconnected;

	// Token: 0x040005E2 RID: 1506
	[global::Cpp2ILInjected.Token(Token = "0x400083D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x348")]
	public GUIAccessoryInfoToggles GUIAccessoryInfoToggles;

	// Token: 0x040005E3 RID: 1507
	[global::Cpp2ILInjected.Token(Token = "0x400083E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x350")]
	public GUIEquipmentLoadout GUIEquipmentLoadout;

	// Token: 0x040005E4 RID: 1508
	[global::Cpp2ILInjected.Token(Token = "0x400083F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x358")]
	public GUIControllerMappings GUIControllerMappings;

	// Token: 0x040005E5 RID: 1509
	[global::Cpp2ILInjected.Token(Token = "0x4000840")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x360")]
	public VirtualControllerInputState VirtualControllerInputState;

	// Token: 0x040005E6 RID: 1510
	[global::Cpp2ILInjected.Token(Token = "0x4000841")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x368")]
	public GUIResearch GUIResearch;

	// Token: 0x040005E7 RID: 1511
	[global::Cpp2ILInjected.Token(Token = "0x4000842")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x370")]
	public GUIKeyboardMappings GUIKeyboardMappings;

	// Token: 0x040005E8 RID: 1512
	[global::Cpp2ILInjected.Token(Token = "0x4000843")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x378")]
	public GUIBestiary GUIBestiary;

	// Token: 0x040005E9 RID: 1513
	[global::Cpp2ILInjected.Token(Token = "0x4000844")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x380")]
	public GUIBuilderAccToggles GUIBuilderAccToggles;

	// Token: 0x040005EA RID: 1514
	[global::Cpp2ILInjected.Token(Token = "0x4000845")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x388")]
	public GUIPS4MultiplayerChecks GUIPS4MultiplayerChecks;

	// Token: 0x040005EB RID: 1515
	[global::Cpp2ILInjected.Token(Token = "0x4000846")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x390")]
	public GUIReturnToTouch GUIReturnToTouch;

	// Token: 0x040005EC RID: 1516
	[global::Cpp2ILInjected.Token(Token = "0x4000847")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x398")]
	public Rectangle BottomCentre_Root;

	// Token: 0x040005ED RID: 1517
	[global::Cpp2ILInjected.Token(Token = "0x4000848")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A8")]
	public Rectangle BottomCentre_ChatUI;

	// Token: 0x040005EE RID: 1518
	[global::Cpp2ILInjected.Token(Token = "0x4000849")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B8")]
	public Rectangle BottomCentre_BossBar;

	// Token: 0x040005EF RID: 1519
	[global::Cpp2ILInjected.Token(Token = "0x400084A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C8")]
	public Rectangle BottomCentre_EventBar;

	// Token: 0x040005F0 RID: 1520
	[global::Cpp2ILInjected.Token(Token = "0x400084B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D8")]
	public Rectangle BottomCentre_ProgressIndicator;

	// Token: 0x040005F1 RID: 1521
	[global::Cpp2ILInjected.Token(Token = "0x400084C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E8")]
	public Rectangle BottomCentre_Notification;

	// Token: 0x040005F2 RID: 1522
	[global::Cpp2ILInjected.Token(Token = "0x400084D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F8")]
	public Rectangle Right_Root;

	// Token: 0x040005F3 RID: 1523
	[global::Cpp2ILInjected.Token(Token = "0x400084E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x408")]
	public Rectangle Right_MainUI;

	// Token: 0x040005F4 RID: 1524
	[global::Cpp2ILInjected.Token(Token = "0x400084F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x418")]
	public Rectangle Right_TextNotifications;

	// Token: 0x040005F5 RID: 1525
	[global::Cpp2ILInjected.Token(Token = "0x4000850")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x428")]
	public Rectangle Right_Event;

	// Token: 0x040005F6 RID: 1526
	[global::Cpp2ILInjected.Token(Token = "0x4000851")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x438")]
	public Rectangle Right_BossBar;

	// Token: 0x040005F7 RID: 1527
	[global::Cpp2ILInjected.Token(Token = "0x4000852")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x448")]
	public Rectangle Right_StatusIndicator;

	// Token: 0x040005F8 RID: 1528
	[global::Cpp2ILInjected.Token(Token = "0x4000853")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x458")]
	public Rectangle Right_InfoAccessories;

	// Token: 0x040005F9 RID: 1529
	[global::Cpp2ILInjected.Token(Token = "0x4000854")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x468")]
	public Rectangle Right_InfoAccessories2;

	// Token: 0x040005FA RID: 1530
	[global::Cpp2ILInjected.Token(Token = "0x4000855")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x478")]
	public Rectangle Right_AchievementNotifiations;

	// Token: 0x040005FB RID: 1531
	[global::Cpp2ILInjected.Token(Token = "0x4000856")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x488")]
	public Rectangle _gridItemRegion;

	// Token: 0x040005FC RID: 1532
	[global::Cpp2ILInjected.Token(Token = "0x4000857")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x498")]
	public Rectangle PageGroupRegion;

	// Token: 0x040005FD RID: 1533
	[global::Cpp2ILInjected.Token(Token = "0x4000858")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A8")]
	public Rectangle PageContentRegion;

	// Token: 0x040005FE RID: 1534
	[global::Cpp2ILInjected.Token(Token = "0x4000859")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B8")]
	public Rectangle _leftPageRegion;

	// Token: 0x040005FF RID: 1535
	[global::Cpp2ILInjected.Token(Token = "0x400085A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C8")]
	public Rectangle _rightPageRegion;

	// Token: 0x04000600 RID: 1536
	[global::Cpp2ILInjected.Token(Token = "0x400085B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D8")]
	public Rectangle _selectedItemRegion;

	// Token: 0x04000601 RID: 1537
	[global::Cpp2ILInjected.Token(Token = "0x400085C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E8")]
	public Rectangle _buttonRegion;

	// Token: 0x04000602 RID: 1538
	[global::Cpp2ILInjected.Token(Token = "0x400085D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F8")]
	public Rectangle _mainMenuPageRegion;

	// Token: 0x04000603 RID: 1539
	[global::Cpp2ILInjected.Token(Token = "0x400085E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x508")]
	public Vector2 LeftInterface;

	// Token: 0x04000604 RID: 1540
	[global::Cpp2ILInjected.Token(Token = "0x400085F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x510")]
	public Vector2 RightInterface;

	// Token: 0x04000605 RID: 1541
	[global::Cpp2ILInjected.Token(Token = "0x4000860")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x518")]
	public bool AllowSecondRow;

	// Token: 0x04000606 RID: 1542
	[global::Cpp2ILInjected.Token(Token = "0x4000861")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x519")]
	public bool UseCollpasedCoinsAmmo;

	// Token: 0x04000607 RID: 1543
	[global::Cpp2ILInjected.Token(Token = "0x4000862")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x51C")]
	public int AllowRowHeight;

	// Token: 0x04000608 RID: 1544
	[global::Cpp2ILInjected.Token(Token = "0x4000863")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x520")]
	public bool AllowDraw;

	// Token: 0x04000609 RID: 1545
	[global::Cpp2ILInjected.Token(Token = "0x4000864")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x524")]
	public int currentFrame;

	// Token: 0x0400060A RID: 1546
	[global::Cpp2ILInjected.Token(Token = "0x4000865")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x528")]
	public int BottomCentreHUDUpdateFrame;

	// Token: 0x0400060B RID: 1547
	[global::Cpp2ILInjected.Token(Token = "0x4000866")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x52C")]
	public WiresUI.Settings.MultiToolMode ToolMode;

	// Token: 0x0400060C RID: 1548
	[global::Cpp2ILInjected.Token(Token = "0x4000867")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x530")]
	public int _lastActuatorEnabled;

	// Token: 0x0400060D RID: 1549
	[global::Cpp2ILInjected.Token(Token = "0x4000868")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x538")]
	public List<int> optionRedirection;

	// Token: 0x0400060E RID: 1550
	[global::Cpp2ILInjected.Token(Token = "0x4000869")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x540")]
	public Vector3 mouseHSL;

	// Token: 0x0400060F RID: 1551
	[global::Cpp2ILInjected.Token(Token = "0x400086A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54C")]
	public Vector3 mouseBorderHSL;

	// Token: 0x04000610 RID: 1552
	[global::Cpp2ILInjected.Token(Token = "0x400086B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x558")]
	public Vector3 controllerHSL;

	// Token: 0x04000611 RID: 1553
	[global::Cpp2ILInjected.Token(Token = "0x400086C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x564")]
	public Vector3 controllerBorderHSL;
}
