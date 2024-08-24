using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x020001EB RID: 491
[global::Cpp2ILInjected.Token(Token = "0x200028C")]
public class GUIPageOptions
{
	// Token: 0x06000DF1 RID: 3569 RVA: 0x00024518 File Offset: 0x00022718
	[global::Cpp2ILInjected.Token(Token = "0x6000F15")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2100C", Offset = "0xA2100C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void PushLeft()
	{
		throw null;
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x0002451B File Offset: 0x0002271B
	[global::Cpp2ILInjected.Token(Token = "0x6000F16")]
	[global::Cpp2ILInjected.Address(RVA = "0xA21010", Offset = "0xA21010", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventorySplitStack), Member = "DrawOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void PopLeft()
	{
		throw null;
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x0002451E File Offset: 0x0002271E
	[global::Cpp2ILInjected.Token(Token = "0x6000F17")]
	[global::Cpp2ILInjected.Address(RVA = "0xA21014", Offset = "0xA21014", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void PushRight()
	{
		throw null;
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00024521 File Offset: 0x00022721
	[global::Cpp2ILInjected.Token(Token = "0x6000F18")]
	[global::Cpp2ILInjected.Address(RVA = "0xA21018", Offset = "0xA21018", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChestSplitStack), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "DrawCraftButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "DrawUnequipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawUnequipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawHideShowButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "DrawUnequipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "DrawCraftButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	public void PopRight()
	{
		throw null;
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00024524 File Offset: 0x00022724
	[global::Cpp2ILInjected.Token(Token = "0x17000186")]
	private bool canDepositAllValue
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000F19")]
		[global::Cpp2ILInjected.Address(RVA = "0xA2101C", Offset = "0xA2101C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawDepositAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "CanBeDepositied", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00024527 File Offset: 0x00022727
	[global::Cpp2ILInjected.Token(Token = "0x6000F1A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA21148", Offset = "0xA21148", Length = "0x398")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "DrawEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "get_ActiveCulture", ReturnType = typeof(GameCulture))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTooltip), Member = "InvalidateTooltips", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(char),
		typeof(char)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
	public void RefreshLangStrings()
	{
		throw null;
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x0002452A File Offset: 0x0002272A
	[global::Cpp2ILInjected.Token(Token = "0x6000F1B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA214E0", Offset = "0xA214E0", Length = "0x51C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadLeftItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public void DrawFavouriteOption()
	{
		throw null;
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x0002452D File Offset: 0x0002272D
	[global::Cpp2ILInjected.Token(Token = "0x6000F1C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA21AF4", Offset = "0xA21AF4", Length = "0x328")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadLeftItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "get_UseCollpasedCoinsAmmo", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContainerTransferContext), Member = "FromUnknown", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(ContainerTransferContext))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "QuickStack", MemberParameters = new object[]
	{
		typeof(ContainerTransferContext),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickStackAllChests", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void DrawQuickStack()
	{
		throw null;
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00024530 File Offset: 0x00022730
	[global::Cpp2ILInjected.Token(Token = "0x6000F1D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA21E1C", Offset = "0xA21E1C", Length = "0x288")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadLeftItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "get_UseCollpasedCoinsAmmo", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "SortInventory", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void DrawSort()
	{
		throw null;
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00024533 File Offset: 0x00022733
	[global::Cpp2ILInjected.Token(Token = "0x6000F1E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA220A4", Offset = "0xA220A4", Length = "0x2F8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadLeftItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "get_canDepositAllValue", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "get_UseCollpasedCoinsAmmo", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_Instance", ReturnType = typeof(BuilderAccToggles_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContainerTransferContext), Member = "FromUnknown", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(ContainerTransferContext))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "DepositAll", MemberParameters = new object[] { typeof(ContainerTransferContext) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void DrawDepositAll()
	{
		throw null;
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00024536 File Offset: 0x00022736
	[global::Cpp2ILInjected.Token(Token = "0x6000F1F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2239C", Offset = "0xA2239C", Length = "0x114")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadLeftItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventorySplitStack), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventorySplitStack), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void DrawSplitStack()
	{
		throw null;
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00024539 File Offset: 0x00022739
	[global::Cpp2ILInjected.Token(Token = "0x6000F20")]
	[global::Cpp2ILInjected.Address(RVA = "0xA224B0", Offset = "0xA224B0", Length = "0x174")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void LeftItemRegionInitialise()
	{
		throw null;
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x0002453C File Offset: 0x0002273C
	[global::Cpp2ILInjected.Token(Token = "0x6000F21")]
	[global::Cpp2ILInjected.Address(RVA = "0xA219FC", Offset = "0xA219FC", Length = "0xF8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawFavouriteOption", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawQuickStack", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawSort", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawDepositAll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawSplitStack", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawDepositButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void LoadLeftItemRegion()
	{
		throw null;
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x0002453F File Offset: 0x0002273F
	[global::Cpp2ILInjected.Token(Token = "0x6000F22")]
	[global::Cpp2ILInjected.Address(RVA = "0xA22624", Offset = "0xA22624", Length = "0x174")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void RightItemRegionInitialise()
	{
		throw null;
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00024542 File Offset: 0x00022742
	[global::Cpp2ILInjected.Token(Token = "0x6000F23")]
	[global::Cpp2ILInjected.Address(RVA = "0xA22798", Offset = "0xA22798", Length = "0xF8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestSort", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestSplitStack", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestRestock", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestLootAll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestRename", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestLoot", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestFavourite", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void LoadRightItemRegion()
	{
		throw null;
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000E00 RID: 3584 RVA: 0x00024545 File Offset: 0x00022745
	[global::Cpp2ILInjected.Token(Token = "0x17000187")]
	public int NumLeftOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000F24")]
		[global::Cpp2ILInjected.Address(RVA = "0xA22890", Offset = "0xA22890", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00024548 File Offset: 0x00022748
	[global::Cpp2ILInjected.Token(Token = "0x6000F25")]
	[global::Cpp2ILInjected.Address(RVA = "0xA228EC", Offset = "0xA228EC", Length = "0x1DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	private bool CanBeOpened(Item SelectedItem)
	{
		throw null;
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x0002454B File Offset: 0x0002274B
	[global::Cpp2ILInjected.Token(Token = "0x6000F26")]
	[global::Cpp2ILInjected.Address(RVA = "0xA22AC8", Offset = "0xA22AC8", Length = "0xB70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "GetSelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "CanBeEquipedAccessory", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "CanBeEquiped", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadLeftItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WiresUI.Settings), Member = "get_DrawToolModeUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_PagePopupDisplayed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "DrawDepositButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "Conflicts", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "DrawSellButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "CanBeOpened", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDisplayDoll), Member = "CanBeEquiped", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDisplayDoll), Member = "CanBeEquipedAccessory", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHatRack), Member = "CanBeEquiped", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventoryTransactions), Member = "PlaceItemDoll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventoryTransactions), Member = "PlaceItemHat", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventoryTransactions), Member = "EquipItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	public void DrawEquipButton()
	{
		throw null;
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x0002454E File Offset: 0x0002274E
	[global::Cpp2ILInjected.Token(Token = "0x6000F27")]
	[global::Cpp2ILInjected.Address(RVA = "0xA23638", Offset = "0xA23638", Length = "0x2DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadLeftItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "GetSelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "CanBeDepositied", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventoryTransactions), Member = "DepositItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void DrawDepositButton()
	{
		throw null;
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x00024551 File Offset: 0x00022751
	[global::Cpp2ILInjected.Token(Token = "0x6000F28")]
	[global::Cpp2ILInjected.Address(RVA = "0xA23E3C", Offset = "0xA23E3C", Length = "0x460")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawLeftThrow", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawRightThrow", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PlaceItem", MemberParameters = new object[]
	{
		typeof(ref Item[]),
		typeof(ref Item),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(bool),
		typeof(int),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "SetItemAnimation", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "DropSelectedItem_InterruptActionsThatUseAnimations", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(NetworkText),
		typeof(int),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItemSource", MemberParameters = new object[] { typeof(Item[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItemSourceIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
	public void ThrowItem(int additionalVelocity = 0)
	{
		throw null;
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00024554 File Offset: 0x00022754
	[global::Cpp2ILInjected.Token(Token = "0x6000F29")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2429C", Offset = "0xA2429C", Length = "0x1A0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "ThrowItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void DrawLeftThrow()
	{
		throw null;
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00024557 File Offset: 0x00022757
	[global::Cpp2ILInjected.Token(Token = "0x6000F2A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2443C", Offset = "0xA2443C", Length = "0x25C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSource", ReturnType = typeof(Item[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(ref Item),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public void DrawLeftTrash()
	{
		throw null;
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x0002455A File Offset: 0x0002275A
	[global::Cpp2ILInjected.Token(Token = "0x6000F2B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA24698", Offset = "0xA24698", Length = "0x184")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "DepositHeldItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void DrawLeftDeposit()
	{
		throw null;
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x0002455D File Offset: 0x0002275D
	[global::Cpp2ILInjected.Token(Token = "0x6000F2C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA23914", Offset = "0xA23914", Length = "0x528")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawEquipButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventoryTransactions), Member = "get_SelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "SellItemAmount", MemberParameters = new object[]
	{
		typeof(Item),
		typeof(int)
	}, ReturnType = typeof(long))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DrawCost", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(float),
		typeof(float),
		typeof(long),
		typeof(SpriteBatch)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventoryTransactions), Member = "SellItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void DrawSellButton()
	{
		throw null;
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x00024560 File Offset: 0x00022760
	[global::Cpp2ILInjected.Token(Token = "0x6000F2D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA24B60", Offset = "0xA24B60", Length = "0x294")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcShop", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadRightItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSorting), Member = "SortChest", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void DrawChestSort()
	{
		throw null;
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x00024563 File Offset: 0x00022763
	[global::Cpp2ILInjected.Token(Token = "0x6000F2E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA24DF4", Offset = "0xA24DF4", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadRightItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChestSplitStack), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChestSplitStack), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void DrawChestSplitStack()
	{
		throw null;
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00024566 File Offset: 0x00022766
	[global::Cpp2ILInjected.Token(Token = "0x6000F2F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA24F0C", Offset = "0xA24F0C", Length = "0x228")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadRightItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "Restock", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void DrawChestRestock()
	{
		throw null;
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000E0C RID: 3596 RVA: 0x00024569 File Offset: 0x00022769
	[global::Cpp2ILInjected.Token(Token = "0x17000188")]
	private bool CanLootAll
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000F30")]
		[global::Cpp2ILInjected.Address(RVA = "0xA25134", Offset = "0xA25134", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawChestLootAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "GetSelectedItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanStoreItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x0002456C File Offset: 0x0002276C
	[global::Cpp2ILInjected.Token(Token = "0x6000F31")]
	[global::Cpp2ILInjected.Address(RVA = "0xA25318", Offset = "0xA25318", Length = "0x270")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadRightItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "get_CanLootAll", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "LootAll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void DrawChestLootAll()
	{
		throw null;
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x0002456F File Offset: 0x0002276F
	[global::Cpp2ILInjected.Token(Token = "0x6000F32")]
	[global::Cpp2ILInjected.Address(RVA = "0xA25588", Offset = "0xA25588", Length = "0x23C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadRightItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "RenameChest", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void DrawChestRename()
	{
		throw null;
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x00024572 File Offset: 0x00022772
	[global::Cpp2ILInjected.Token(Token = "0x6000F33")]
	[global::Cpp2ILInjected.Address(RVA = "0xA257C4", Offset = "0xA257C4", Length = "0x278")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadRightItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "GetSelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanStoreItem", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "LootItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void DrawChestLoot()
	{
		throw null;
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x00024575 File Offset: 0x00022775
	[global::Cpp2ILInjected.Token(Token = "0x6000F34")]
	[global::Cpp2ILInjected.Address(RVA = "0xA25A3C", Offset = "0xA25A3C", Length = "0x448")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "LoadRightItemRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChest), Member = "GetSelectedItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public void DrawChestFavourite()
	{
		throw null;
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00024578 File Offset: 0x00022778
	[global::Cpp2ILInjected.Token(Token = "0x17000189")]
	public int NumRightOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000F35")]
		[global::Cpp2ILInjected.Address(RVA = "0xA25E84", Offset = "0xA25E84", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x0002457B File Offset: 0x0002277B
	[global::Cpp2ILInjected.Token(Token = "0x6000F36")]
	[global::Cpp2ILInjected.Address(RVA = "0xA25EF0", Offset = "0xA25EF0", Length = "0x180")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "ThrowItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void DrawRightThrow()
	{
		throw null;
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x0002457E File Offset: 0x0002277E
	[global::Cpp2ILInjected.Token(Token = "0x6000F37")]
	[global::Cpp2ILInjected.Address(RVA = "0xA26070", Offset = "0xA26070", Length = "0x240")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItemSource", ReturnType = typeof(Item[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(ref Item),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void DrawRightTrash()
	{
		throw null;
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00024581 File Offset: 0x00022781
	[global::Cpp2ILInjected.Token(Token = "0x6000F38")]
	[global::Cpp2ILInjected.Address(RVA = "0xA262B0", Offset = "0xA262B0", Length = "0x184")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageOptions), Member = "DepositHeldItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void DrawRightDeposit()
	{
		throw null;
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x00024584 File Offset: 0x00022784
	[global::Cpp2ILInjected.Token(Token = "0x6000F39")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2481C", Offset = "0xA2481C", Length = "0x344")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "DrawCraftButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftButtonOver", MemberParameters = new object[] { typeof(GUITransactionButton.InputState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "DrawCraftButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "DrawPurchaseButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawLeftDeposit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawRightDeposit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep), Member = "GiveItem", MemberParameters = new object[]
	{
		typeof(short),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventorySplitStack), Member = "WasSplit", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChestSplitStack), Member = "WasSplit", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsACoin", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Item),
		typeof(GetItemSettings),
		typeof(bool)
	}, ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(bool),
		typeof(int),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(NetworkText),
		typeof(int),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public void DepositHeldItem()
	{
		throw null;
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00024587 File Offset: 0x00022787
	[global::Cpp2ILInjected.Token(Token = "0x6000F3A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA26434", Offset = "0xA26434", Length = "0x1030")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIPageOptions()
	{
		throw null;
	}

	// Token: 0x04001627 RID: 5671
	[global::Cpp2ILInjected.Token(Token = "0x4001B49")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool _timerBegan;

	// Token: 0x04001628 RID: 5672
	[global::Cpp2ILInjected.Token(Token = "0x4001B4A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private DateTime _timeStart;

	// Token: 0x04001629 RID: 5673
	[global::Cpp2ILInjected.Token(Token = "0x4001B4B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private bool _leftPendingPush;

	// Token: 0x0400162A RID: 5674
	[global::Cpp2ILInjected.Token(Token = "0x4001B4C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
	private bool _displayLeftOptions;

	// Token: 0x0400162B RID: 5675
	[global::Cpp2ILInjected.Token(Token = "0x4001B4D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
	private bool _displayLeftOptionsGlobal;

	// Token: 0x0400162C RID: 5676
	[global::Cpp2ILInjected.Token(Token = "0x4001B4E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x23")]
	private bool _displayRightOptions;

	// Token: 0x0400162D RID: 5677
	[global::Cpp2ILInjected.Token(Token = "0x4001B4F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private bool _displayRightOptionsGlobal;

	// Token: 0x0400162E RID: 5678
	[global::Cpp2ILInjected.Token(Token = "0x4001B50")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private int _displayItem;

	// Token: 0x0400162F RID: 5679
	[global::Cpp2ILInjected.Token(Token = "0x4001B51")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04001630 RID: 5680
	[global::Cpp2ILInjected.Token(Token = "0x4001B52")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private float leftOptionsScale;

	// Token: 0x04001631 RID: 5681
	[global::Cpp2ILInjected.Token(Token = "0x4001B53")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private float rightOptionsScale;

	// Token: 0x04001632 RID: 5682
	[global::Cpp2ILInjected.Token(Token = "0x4001B54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private float leftFavoriteScale;

	// Token: 0x04001633 RID: 5683
	[global::Cpp2ILInjected.Token(Token = "0x4001B55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float leftChestQuickStackScale;

	// Token: 0x04001634 RID: 5684
	[global::Cpp2ILInjected.Token(Token = "0x4001B56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private float leftChestDepositAllScale;

	// Token: 0x04001635 RID: 5685
	[global::Cpp2ILInjected.Token(Token = "0x4001B57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private float leftChestSortScale;

	// Token: 0x04001636 RID: 5686
	[global::Cpp2ILInjected.Token(Token = "0x4001B58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private bool usingController;

	// Token: 0x04001637 RID: 5687
	[global::Cpp2ILInjected.Token(Token = "0x4001B59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private int lastLang;

	// Token: 0x04001638 RID: 5688
	[global::Cpp2ILInjected.Token(Token = "0x4001B5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public string[] options;

	// Token: 0x04001639 RID: 5689
	[global::Cpp2ILInjected.Token(Token = "0x4001B5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private Vector2 leftItemSize;

	// Token: 0x0400163A RID: 5690
	[global::Cpp2ILInjected.Token(Token = "0x4001B5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private Vector2 leftItemPosition;

	// Token: 0x0400163B RID: 5691
	[global::Cpp2ILInjected.Token(Token = "0x4001B5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private Vector2 leftItemSpacing;

	// Token: 0x0400163C RID: 5692
	[global::Cpp2ILInjected.Token(Token = "0x4001B5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private int leftItemIndex;

	// Token: 0x0400163D RID: 5693
	[global::Cpp2ILInjected.Token(Token = "0x4001B5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	private Vector2 rightItemSize;

	// Token: 0x0400163E RID: 5694
	[global::Cpp2ILInjected.Token(Token = "0x4001B60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	private Vector2 rightItemPosition;

	// Token: 0x0400163F RID: 5695
	[global::Cpp2ILInjected.Token(Token = "0x4001B61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	private Vector2 rightItemSpacing;

	// Token: 0x04001640 RID: 5696
	[global::Cpp2ILInjected.Token(Token = "0x4001B62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	private int rightItemIndex;

	// Token: 0x04001641 RID: 5697
	[global::Cpp2ILInjected.Token(Token = "0x4001B63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private float equipButtonScale;

	// Token: 0x04001642 RID: 5698
	[global::Cpp2ILInjected.Token(Token = "0x4001B64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	private float depositButtonScale;

	// Token: 0x04001643 RID: 5699
	[global::Cpp2ILInjected.Token(Token = "0x4001B65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private float leftThrowScale;

	// Token: 0x04001644 RID: 5700
	[global::Cpp2ILInjected.Token(Token = "0x4001B66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	private float leftTrashScale;

	// Token: 0x04001645 RID: 5701
	[global::Cpp2ILInjected.Token(Token = "0x4001B67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private float sellButtonScale;

	// Token: 0x04001646 RID: 5702
	[global::Cpp2ILInjected.Token(Token = "0x4001B68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	private float rightChestSortScale;

	// Token: 0x04001647 RID: 5703
	[global::Cpp2ILInjected.Token(Token = "0x4001B69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private float chestRestockScale;

	// Token: 0x04001648 RID: 5704
	[global::Cpp2ILInjected.Token(Token = "0x4001B6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	private float chestLootAllScale;

	// Token: 0x04001649 RID: 5705
	[global::Cpp2ILInjected.Token(Token = "0x4001B6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private float chestRenameScale;

	// Token: 0x0400164A RID: 5706
	[global::Cpp2ILInjected.Token(Token = "0x4001B6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public bool SplitKeyPressed;

	// Token: 0x0400164B RID: 5707
	[global::Cpp2ILInjected.Token(Token = "0x4001B6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBD")]
	public bool SplitInvKeyPressed;

	// Token: 0x0400164C RID: 5708
	[global::Cpp2ILInjected.Token(Token = "0x4001B6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBE")]
	public bool SplitChestKeyPressed;

	// Token: 0x0400164D RID: 5709
	[global::Cpp2ILInjected.Token(Token = "0x4001B6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private float LootButtonScale;
}
