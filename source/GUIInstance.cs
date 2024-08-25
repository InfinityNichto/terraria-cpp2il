using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.UI;

[global::Cpp2ILInjected.Token(Token = "0x200014A")]
public class GUIInstance
{
	[global::Cpp2ILInjected.Token(Token = "0x60008FC")]
	[global::Cpp2ILInjected.Address(RVA = "0x91461C", Offset = "0x91461C", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "DrawToggles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "EquipChestItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChestSplitStack), Member = "Open", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipmentLoadout), Member = "DrawToggles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = "CloseDialoguesAndPopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventorySplitStack), Member = "Open", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "SellItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "EquipItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "PlaceItemDoll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "PlaceItemHat", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventoryTransactions), Member = "DepositItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "DrawFilter", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "PlayerMenuDisplayToggle", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "PlayerMenuDisplayToggle", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawQuickStack", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawDepositAll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestRestock", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestLootAll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestRename", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestLoot", ReturnType = typeof(void))]
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

	[global::Cpp2ILInjected.Token(Token = "0x40007D5")]
	public static GUIInstance Active;

	[global::Cpp2ILInjected.Token(Token = "0x40007D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public XNAUnityRunner.ForcedInputMode LastPrimaryInputMode;

	[global::Cpp2ILInjected.Token(Token = "0x40007D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public InterfaceProfile_Layout _active;

	[global::Cpp2ILInjected.Token(Token = "0x40007D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool UseLargeMinimap;

	[global::Cpp2ILInjected.Token(Token = "0x40007D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public GUIControllerNavigationController GUIControllerNavigationController;

	[global::Cpp2ILInjected.Token(Token = "0x40007DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIControllerPageRedirect GUIControllerPageRedirect;

	[global::Cpp2ILInjected.Token(Token = "0x40007DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public GUIVirtualInputController GUIVirtualInputController;

	[global::Cpp2ILInjected.Token(Token = "0x40007DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public GUIAccessoryInfo GUIAccessoryInfo;

	[global::Cpp2ILInjected.Token(Token = "0x40007DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public GUIMenuNameEdit GUIMenuNameEdit;

	[global::Cpp2ILInjected.Token(Token = "0x40007DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public GUIReforgePopup GUIReforgePopup;

	[global::Cpp2ILInjected.Token(Token = "0x40007DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public GUIAmmo GUIAmmo;

	[global::Cpp2ILInjected.Token(Token = "0x40007E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public GUIBossBar GUIBossBar;

	[global::Cpp2ILInjected.Token(Token = "0x40007E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public GUIBuffs GUIBuffs;

	[global::Cpp2ILInjected.Token(Token = "0x40007E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public GUIButtonBar GUIButtonBar;

	[global::Cpp2ILInjected.Token(Token = "0x40007E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public GUIChest GUIChest;

	[global::Cpp2ILInjected.Token(Token = "0x40007E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public GUIChestQuickStack GUIChestQuickStack;

	[global::Cpp2ILInjected.Token(Token = "0x40007E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public GUIChestSplitStack GUIChestSplitStack;

	[global::Cpp2ILInjected.Token(Token = "0x40007E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public GUIClothesWindow GUIClothesWindow;

	[global::Cpp2ILInjected.Token(Token = "0x40007E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public GUICoins GUICoins;

	[global::Cpp2ILInjected.Token(Token = "0x40007E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public GUIControlsBanner GUIControlsBanner;

	[global::Cpp2ILInjected.Token(Token = "0x40007E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public GUIControlsStatusIndicators GUIControlsStatusIndicators;

	[global::Cpp2ILInjected.Token(Token = "0x40007EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public GUICraftGuide GUICraftGuide;

	[global::Cpp2ILInjected.Token(Token = "0x40007EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public GUICraftGuidePopup GUICraftGuidePopup;

	[global::Cpp2ILInjected.Token(Token = "0x40007EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public GUICrafting GUICrafting;

	[global::Cpp2ILInjected.Token(Token = "0x40007ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public GUIDisplayDoll GUIDisplayDoll;

	[global::Cpp2ILInjected.Token(Token = "0x40007EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public GUIEmotesWindow GUIEmotesWindow;

	[global::Cpp2ILInjected.Token(Token = "0x40007EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public GUIEquipment GUIEquipment;

	[global::Cpp2ILInjected.Token(Token = "0x40007F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public GUIEquipmentUtility GUIEquipmentUtility;

	[global::Cpp2ILInjected.Token(Token = "0x40007F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public GUIEvents GUIEvents;

	[global::Cpp2ILInjected.Token(Token = "0x40007F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public GUIHairWindow GUIHairWindow;

	[global::Cpp2ILInjected.Token(Token = "0x40007F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public GUIHatRack GUIHatRack;

	[global::Cpp2ILInjected.Token(Token = "0x40007F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public GUIResearchPage GUIResearchPage;

	[global::Cpp2ILInjected.Token(Token = "0x40007F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public GUIHearts GUIHearts;

	[global::Cpp2ILInjected.Token(Token = "0x40007F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public GUIHotbar GUIHotbar;

	[global::Cpp2ILInjected.Token(Token = "0x40007F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public GUIHousingMenu GUIHousingMenu;

	[global::Cpp2ILInjected.Token(Token = "0x40007F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public GUIInventory GUIInventory;

	[global::Cpp2ILInjected.Token(Token = "0x40007F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public GUIWiresUI GUIWiresUI;

	[global::Cpp2ILInjected.Token(Token = "0x40007FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public GUIRubbleMaker GUIRubbleMaker;

	[global::Cpp2ILInjected.Token(Token = "0x40007FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public GUIInventorySplitStack GUIInventorySplitStack;

	[global::Cpp2ILInjected.Token(Token = "0x40007FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public GUIInventoryTransactions GUIInventoryTransactions;

	[global::Cpp2ILInjected.Token(Token = "0x40007FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public GUIItemDuplication GUIItemDuplication;

	[global::Cpp2ILInjected.Token(Token = "0x40007FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public GUIMagnify GUIMagnify;

	[global::Cpp2ILInjected.Token(Token = "0x40007FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public GUIMana GUIMana;

	[global::Cpp2ILInjected.Token(Token = "0x4000800")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public GUIMap GUIMap;

	[global::Cpp2ILInjected.Token(Token = "0x4000801")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public GUIMouseItem GUIMouseItem;

	[global::Cpp2ILInjected.Token(Token = "0x4000802")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public GUIMultiplayerChat GUIMultiplayerChat;

	[global::Cpp2ILInjected.Token(Token = "0x4000803")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public GUIMultiplayerChat GUIMultiplayerChatPage;

	[global::Cpp2ILInjected.Token(Token = "0x4000804")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public GUINetplayStatusText GUINetplayStatusText;

	[global::Cpp2ILInjected.Token(Token = "0x4000805")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public GUINPCDialogue GUINPCDialogue;

	[global::Cpp2ILInjected.Token(Token = "0x4000806")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public GUIPageIcons GUIPageIcons;

	[global::Cpp2ILInjected.Token(Token = "0x4000807")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public GUIProfileSwitch GUIProfileSwitch;

	[global::Cpp2ILInjected.Token(Token = "0x4000808")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public GUIPVPIcons GUIPVPIcons;

	[global::Cpp2ILInjected.Token(Token = "0x4000809")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public GUIReforge GUIReforge;

	[global::Cpp2ILInjected.Token(Token = "0x400080A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public GUIScrollControl GUIScrollControl;

	[global::Cpp2ILInjected.Token(Token = "0x400080B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public GUIJourneyModeSettings GUIJourneyModeSettings;

	[global::Cpp2ILInjected.Token(Token = "0x400080C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public GUISettings GUISettings;

	[global::Cpp2ILInjected.Token(Token = "0x400080D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public GUISettingsPauseMenu GUISettingsPauseMenu;

	[global::Cpp2ILInjected.Token(Token = "0x400080E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public GUIShop GUIShop;

	[global::Cpp2ILInjected.Token(Token = "0x400080F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public GUITrashCan GUITrashCan;

	[global::Cpp2ILInjected.Token(Token = "0x4000810")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public GUIWorldOperationProgress GUIWorldOperationProgress;

	[global::Cpp2ILInjected.Token(Token = "0x4000811")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public GUIZoom GUIZoom;

	[global::Cpp2ILInjected.Token(Token = "0x4000812")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public GUIAchievementsMenu GUIAchievementsMenu;

	[global::Cpp2ILInjected.Token(Token = "0x4000813")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public GUICredits GUICredits;

	[global::Cpp2ILInjected.Token(Token = "0x4000814")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public GUIDeleteDedicatedServer GUIDeleteDedicatedServer;

	[global::Cpp2ILInjected.Token(Token = "0x4000815")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	public GUIDeletePlayer GUIDeletePlayer;

	[global::Cpp2ILInjected.Token(Token = "0x4000816")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
	public GUIDeleteWorld GUIDeleteWorld;

	[global::Cpp2ILInjected.Token(Token = "0x4000817")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
	public GUIErrorScreen GUIErrorScreen;

	[global::Cpp2ILInjected.Token(Token = "0x4000818")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
	public GUIFileSyncInProgress GUIFileSyncInProgress;

	[global::Cpp2ILInjected.Token(Token = "0x4000819")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
	public GUIInterfaceEdit GUIInterfaceEdit;

	[global::Cpp2ILInjected.Token(Token = "0x400081A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
	public GUILogo GUILogo;

	[global::Cpp2ILInjected.Token(Token = "0x400081B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
	public GUILowDiskSpacePopup GUILowDiskSpacePopup;

	[global::Cpp2ILInjected.Token(Token = "0x400081C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
	public GUILowMemoryPopup GUILowMemoryPopup;

	[global::Cpp2ILInjected.Token(Token = "0x400081D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
	public GUILowMemorySetttings GUILowMemorySetttings;

	[global::Cpp2ILInjected.Token(Token = "0x400081E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
	public GUIMainMenu GUIMainMenu;

	[global::Cpp2ILInjected.Token(Token = "0x400081F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
	public GUIMultiplayerHost GUIMultiplayerHost;

	[global::Cpp2ILInjected.Token(Token = "0x4000820")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
	public GUIMultiplayerJoin GUIMultiplayerJoin;

	[global::Cpp2ILInjected.Token(Token = "0x4000821")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x268")]
	public GUIMultiplayerLobby GUIMultiplayerLobby;

	[global::Cpp2ILInjected.Token(Token = "0x4000822")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x270")]
	public GUIMultiplayerMenu GUIMultiplayerMenu;

	[global::Cpp2ILInjected.Token(Token = "0x4000823")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x278")]
	public GUIMultiplayerServerIP GUIMultiplayerServerIP;

	[global::Cpp2ILInjected.Token(Token = "0x4000824")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x280")]
	public GUIMultiplayerServerPassword GUIMultiplayerServerPassword;

	[global::Cpp2ILInjected.Token(Token = "0x4000825")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x288")]
	public GUIMultiplayerServerPort GUIMultiplayerServerPort;

	[global::Cpp2ILInjected.Token(Token = "0x4000826")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x290")]
	public GUIMultiplayerServerRequestedPassword GUIMultiplayerServerRequestedPassword;

	[global::Cpp2ILInjected.Token(Token = "0x4000827")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x298")]
	public GUIMultiplayerWaitingHost GUIMultiplayerWaitingHost;

	[global::Cpp2ILInjected.Token(Token = "0x4000828")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A0")]
	public GUINetPlayStatusMenu GUINetPlayStatusMenu;

	[global::Cpp2ILInjected.Token(Token = "0x4000829")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A8")]
	public GUIPlayerAndGameModeMismatch GUIPlayerAndGameModeMismatch;

	[global::Cpp2ILInjected.Token(Token = "0x400082A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B0")]
	public GUIPlayerCreateMenu GUIPlayerCreateMenu;

	[global::Cpp2ILInjected.Token(Token = "0x400082B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
	public GUIPlayerNameMenu GUIPlayerNameMenu;

	[global::Cpp2ILInjected.Token(Token = "0x400082C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
	public GUIPlayerSelectMenu GUIPlayerSelectMenu;

	[global::Cpp2ILInjected.Token(Token = "0x400082D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C8")]
	public GUIQuitConfirm GUIQuitConfirm;

	[global::Cpp2ILInjected.Token(Token = "0x400082E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
	public GUIResetSettings GUIResetSettings;

	[global::Cpp2ILInjected.Token(Token = "0x400082F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D8")]
	public GUISafeRegionEdit GUISafeRegionEdit;

	[global::Cpp2ILInjected.Token(Token = "0x4000830")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
	public GUISettingsOverlay GUISettingsOverlay;

	[global::Cpp2ILInjected.Token(Token = "0x4000831")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E8")]
	public GUIStatusMenu GUIStatusMenu;

	[global::Cpp2ILInjected.Token(Token = "0x4000832")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F0")]
	public GUIVirtualInputControllerEdit GUIVirtualInputControllerEdit;

	[global::Cpp2ILInjected.Token(Token = "0x4000833")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F8")]
	public GUIPageGroupEdit GUIPageGroupEdit;

	[global::Cpp2ILInjected.Token(Token = "0x4000834")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x300")]
	public GUIWorldCreateMenu GUIWorldCreateMenu;

	[global::Cpp2ILInjected.Token(Token = "0x4000835")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x308")]
	public GUIWorldGenerateMenu GUIWorldGenerateMenu;

	[global::Cpp2ILInjected.Token(Token = "0x4000836")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x310")]
	public GUIWorldLoadBackup GUIWorldLoadBackup;

	[global::Cpp2ILInjected.Token(Token = "0x4000837")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x318")]
	public GUIWorldNameMenu GUIWorldNameMenu;

	[global::Cpp2ILInjected.Token(Token = "0x4000838")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x320")]
	public GUIWorldNoBackup GUIWorldNoBackup;

	[global::Cpp2ILInjected.Token(Token = "0x4000839")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x328")]
	public GUIWorldSelectMenu GUIWorldSelectMenu;

	[global::Cpp2ILInjected.Token(Token = "0x400083A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x330")]
	public GUIPageOptions GUIPageOptions;

	[global::Cpp2ILInjected.Token(Token = "0x400083B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x338")]
	public GUITalkerList GUITalkerList;

	[global::Cpp2ILInjected.Token(Token = "0x400083C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x340")]
	public GUIControllerDisconnected GUIControllerDisconnected;

	[global::Cpp2ILInjected.Token(Token = "0x400083D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x348")]
	public GUIAccessoryInfoToggles GUIAccessoryInfoToggles;

	[global::Cpp2ILInjected.Token(Token = "0x400083E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x350")]
	public GUIEquipmentLoadout GUIEquipmentLoadout;

	[global::Cpp2ILInjected.Token(Token = "0x400083F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x358")]
	public GUIControllerMappings GUIControllerMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000840")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x360")]
	public VirtualControllerInputState VirtualControllerInputState;

	[global::Cpp2ILInjected.Token(Token = "0x4000841")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x368")]
	public GUIResearch GUIResearch;

	[global::Cpp2ILInjected.Token(Token = "0x4000842")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x370")]
	public GUIKeyboardMappings GUIKeyboardMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000843")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x378")]
	public GUIBestiary GUIBestiary;

	[global::Cpp2ILInjected.Token(Token = "0x4000844")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x380")]
	public GUIBuilderAccToggles GUIBuilderAccToggles;

	[global::Cpp2ILInjected.Token(Token = "0x4000845")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x388")]
	public GUIPS4MultiplayerChecks GUIPS4MultiplayerChecks;

	[global::Cpp2ILInjected.Token(Token = "0x4000846")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x390")]
	public GUIReturnToTouch GUIReturnToTouch;

	[global::Cpp2ILInjected.Token(Token = "0x4000847")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x398")]
	public Rectangle BottomCentre_Root;

	[global::Cpp2ILInjected.Token(Token = "0x4000848")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A8")]
	public Rectangle BottomCentre_ChatUI;

	[global::Cpp2ILInjected.Token(Token = "0x4000849")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B8")]
	public Rectangle BottomCentre_BossBar;

	[global::Cpp2ILInjected.Token(Token = "0x400084A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C8")]
	public Rectangle BottomCentre_EventBar;

	[global::Cpp2ILInjected.Token(Token = "0x400084B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D8")]
	public Rectangle BottomCentre_ProgressIndicator;

	[global::Cpp2ILInjected.Token(Token = "0x400084C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E8")]
	public Rectangle BottomCentre_Notification;

	[global::Cpp2ILInjected.Token(Token = "0x400084D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F8")]
	public Rectangle Right_Root;

	[global::Cpp2ILInjected.Token(Token = "0x400084E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x408")]
	public Rectangle Right_MainUI;

	[global::Cpp2ILInjected.Token(Token = "0x400084F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x418")]
	public Rectangle Right_TextNotifications;

	[global::Cpp2ILInjected.Token(Token = "0x4000850")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x428")]
	public Rectangle Right_Event;

	[global::Cpp2ILInjected.Token(Token = "0x4000851")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x438")]
	public Rectangle Right_BossBar;

	[global::Cpp2ILInjected.Token(Token = "0x4000852")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x448")]
	public Rectangle Right_StatusIndicator;

	[global::Cpp2ILInjected.Token(Token = "0x4000853")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x458")]
	public Rectangle Right_InfoAccessories;

	[global::Cpp2ILInjected.Token(Token = "0x4000854")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x468")]
	public Rectangle Right_InfoAccessories2;

	[global::Cpp2ILInjected.Token(Token = "0x4000855")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x478")]
	public Rectangle Right_AchievementNotifiations;

	[global::Cpp2ILInjected.Token(Token = "0x4000856")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x488")]
	public Rectangle _gridItemRegion;

	[global::Cpp2ILInjected.Token(Token = "0x4000857")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x498")]
	public Rectangle PageGroupRegion;

	[global::Cpp2ILInjected.Token(Token = "0x4000858")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A8")]
	public Rectangle PageContentRegion;

	[global::Cpp2ILInjected.Token(Token = "0x4000859")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B8")]
	public Rectangle _leftPageRegion;

	[global::Cpp2ILInjected.Token(Token = "0x400085A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C8")]
	public Rectangle _rightPageRegion;

	[global::Cpp2ILInjected.Token(Token = "0x400085B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D8")]
	public Rectangle _selectedItemRegion;

	[global::Cpp2ILInjected.Token(Token = "0x400085C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E8")]
	public Rectangle _buttonRegion;

	[global::Cpp2ILInjected.Token(Token = "0x400085D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F8")]
	public Rectangle _mainMenuPageRegion;

	[global::Cpp2ILInjected.Token(Token = "0x400085E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x508")]
	public Vector2 LeftInterface;

	[global::Cpp2ILInjected.Token(Token = "0x400085F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x510")]
	public Vector2 RightInterface;

	[global::Cpp2ILInjected.Token(Token = "0x4000860")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x518")]
	public bool AllowSecondRow;

	[global::Cpp2ILInjected.Token(Token = "0x4000861")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x519")]
	public bool UseCollpasedCoinsAmmo;

	[global::Cpp2ILInjected.Token(Token = "0x4000862")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x51C")]
	public int AllowRowHeight;

	[global::Cpp2ILInjected.Token(Token = "0x4000863")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x520")]
	public bool AllowDraw;

	[global::Cpp2ILInjected.Token(Token = "0x4000864")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x524")]
	public int currentFrame;

	[global::Cpp2ILInjected.Token(Token = "0x4000865")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x528")]
	public int BottomCentreHUDUpdateFrame;

	[global::Cpp2ILInjected.Token(Token = "0x4000866")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x52C")]
	public WiresUI.Settings.MultiToolMode ToolMode;

	[global::Cpp2ILInjected.Token(Token = "0x4000867")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x530")]
	public int _lastActuatorEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4000868")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x538")]
	public List<int> optionRedirection;

	[global::Cpp2ILInjected.Token(Token = "0x4000869")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x540")]
	public Vector3 mouseHSL;

	[global::Cpp2ILInjected.Token(Token = "0x400086A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54C")]
	public Vector3 mouseBorderHSL;

	[global::Cpp2ILInjected.Token(Token = "0x400086B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x558")]
	public Vector3 controllerHSL;

	[global::Cpp2ILInjected.Token(Token = "0x400086C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x564")]
	public Vector3 controllerBorderHSL;
}
