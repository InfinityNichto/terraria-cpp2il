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
using Terraria.GameContent.Creative;
using Terraria.Localization;

// Token: 0x020000EA RID: 234
[global::Cpp2ILInjected.Token(Token = "0x200014F")]
public class GUIItemFilter
{
	// Token: 0x0600082F RID: 2095 RVA: 0x000233D2 File Offset: 0x000215D2
	[global::Cpp2ILInjected.Token(Token = "0x6000929")]
	[global::Cpp2ILInjected.Address(RVA = "0x91E1E4", Offset = "0x91E1E4", Length = "0xD8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.BySearch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerItemFilter), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public GUIItemFilter(GUIPageIcons.Category cat)
	{
		throw null;
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x000233D5 File Offset: 0x000215D5
	[global::Cpp2ILInjected.Token(Token = "0x600092A")]
	[global::Cpp2ILInjected.Address(RVA = "0x91E2BC", Offset = "0x91E2BC", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "set_SelectedCategory", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(GUIPageIcons.Category)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemFilter), Member = "SetSearchTerm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Reset(bool expandedOnTouch = false)
	{
		throw null;
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x000233D8 File Offset: 0x000215D8
	[global::Cpp2ILInjected.Token(Token = "0x600092B")]
	[global::Cpp2ILInjected.Address(RVA = "0x91E400", Offset = "0x91E400", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SetFilterCategory(GUIItemFilter.CategoryFilter category)
	{
		throw null;
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x000233DB File Offset: 0x000215DB
	[global::Cpp2ILInjected.Token(Token = "0x600092C")]
	[global::Cpp2ILInjected.Address(RVA = "0x91E33C", Offset = "0x91E33C", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "Reset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "DrawFilter", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "DrawSearch", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "set_SelectedCategory", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "SetActiveLayout", MemberParameters = new object[] { typeof(InterfaceProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void SetSearchTerm(string term)
	{
		throw null;
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x000233DE File Offset: 0x000215DE
	[global::Cpp2ILInjected.Token(Token = "0x600092D")]
	[global::Cpp2ILInjected.Address(RVA = "0x91CC24", Offset = "0x91CC24", Length = "0x280")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "UpdateFilter", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "UpdateFilter", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.MiscFallback), Member = ".ctor", MemberParameters = new object[] { typeof(List<IItemEntryFilter>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public bool Matches(int itemId)
	{
		throw null;
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x000233E1 File Offset: 0x000215E1
	[global::Cpp2ILInjected.Token(Token = "0x600092E")]
	[global::Cpp2ILInjected.Address(RVA = "0x914688", Offset = "0x914688", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "DrawFilter", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OnCategoryClosed", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CloseKeyboard", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void CloseExpandedFilter()
	{
		throw null;
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x000233E4 File Offset: 0x000215E4
	[global::Cpp2ILInjected.Token(Token = "0x600092F")]
	[global::Cpp2ILInjected.Address(RVA = "0x91E408", Offset = "0x91E408", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "DrawFilter", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void LoadCategoryButtonIcon(TransactionButton_Layout button)
	{
		throw null;
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x000233E7 File Offset: 0x000215E7
	[global::Cpp2ILInjected.Token(Token = "0x6000930")]
	[global::Cpp2ILInjected.Address(RVA = "0x91E520", Offset = "0x91E520", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "DrawFilter", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CloseKeyboard", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void Close()
	{
		throw null;
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x000233EA File Offset: 0x000215EA
	[global::Cpp2ILInjected.Token(Token = "0x6000931")]
	[global::Cpp2ILInjected.Address(RVA = "0x91E5AC", Offset = "0x91E5AC", Length = "0x141C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "DrawEditOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "ClickedOutOfRegion", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemFilter), Member = "CloseExpandedFilter", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemFilter), Member = "DrawSearch", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Color?),
		typeof(Color?),
		typeof(Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICrafting), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemFilter), Member = "LoadCategoryButtonIcon", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemFilter), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemDuplication), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "ClosePopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_GameMode", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "GetCategoryGrouping", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICrafting), Member = "get_Collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemDuplication), Member = "get_Collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_HoldingItem", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "Conflicts", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "GetCategoryTexture", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "IndexOf", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(int),
		"System.Int32Enum"
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "IsCollapsed", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "SetCollapsed", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "set_SelectedCategory", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemFilter), Member = "SetSearchTerm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Crafting", ReturnType = typeof(GUIControllerCrafting))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Duplicate", ReturnType = typeof(GUIControllerItemDuplication))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
	public void DrawFilter()
	{
		throw null;
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x000233ED File Offset: 0x000215ED
	[global::Cpp2ILInjected.Token(Token = "0x6000932")]
	[global::Cpp2ILInjected.Address(RVA = "0x91F9C8", Offset = "0x91F9C8", Length = "0x5A0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "DrawFilter", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Color?),
		typeof(Color?),
		typeof(Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "clrInput", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Rectangle),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CloseKeyboard", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemFilter), Member = "SetSearchTerm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private void DrawSearch()
	{
		throw null;
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x000233F0 File Offset: 0x000215F0
	[global::Cpp2ILInjected.Token(Token = "0x6000933")]
	[global::Cpp2ILInjected.Address(RVA = "0x91FF68", Offset = "0x91FF68", Length = "0x1E0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "GetCategoryGrouping", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get_PageGroupRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get_PageContentRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Panel_Layout)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "set_PageGroupRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "set_PageContentRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public bool IsOver(Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x000233F3 File Offset: 0x000215F3
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000934")]
	[global::Cpp2ILInjected.Address(RVA = "0x920148", Offset = "0x920148", Length = "0xABC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Weapon), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Armor), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Vanity), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.BuildingBlock), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Furniture), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Accessories), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.MiscAccessories), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Consumables), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Tools), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.Materials), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.BySearch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 78)]
	static GUIItemFilter()
	{
		throw null;
	}

	// Token: 0x0400064B RID: 1611
	[global::Cpp2ILInjected.Token(Token = "0x40008A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private GUIPageIcons.Category _cat;

	// Token: 0x0400064C RID: 1612
	[global::Cpp2ILInjected.Token(Token = "0x40008A7")]
	private static string[] categoryName;

	// Token: 0x0400064D RID: 1613
	[global::Cpp2ILInjected.Token(Token = "0x40008A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public GUIItemFilter.CategoryFilter ActiveCategory;

	// Token: 0x0400064E RID: 1614
	[global::Cpp2ILInjected.Token(Token = "0x40008A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string SearchTerm;

	// Token: 0x0400064F RID: 1615
	[global::Cpp2ILInjected.Token(Token = "0x40008AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool Expanded;

	// Token: 0x04000650 RID: 1616
	[global::Cpp2ILInjected.Token(Token = "0x40008AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
	public bool editingSearch;

	// Token: 0x04000651 RID: 1617
	[global::Cpp2ILInjected.Token(Token = "0x40008AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public string editSearch;

	// Token: 0x04000652 RID: 1618
	[global::Cpp2ILInjected.Token(Token = "0x40008AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public string editSearchStart;

	// Token: 0x04000653 RID: 1619
	[global::Cpp2ILInjected.Token(Token = "0x40008AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public string editDisplaySearch;

	// Token: 0x04000654 RID: 1620
	[global::Cpp2ILInjected.Token(Token = "0x40008AF")]
	private static List<IItemEntryFilter> everythingButMisc;

	// Token: 0x04000655 RID: 1621
	[global::Cpp2ILInjected.Token(Token = "0x40008B0")]
	private static IItemEntryFilter[] CategoryFilters;

	// Token: 0x04000656 RID: 1622
	[global::Cpp2ILInjected.Token(Token = "0x40008B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private ISearchFilter<Item> searchFilter;

	// Token: 0x04000657 RID: 1623
	[global::Cpp2ILInjected.Token(Token = "0x40008B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private bool disableReset;

	// Token: 0x04000658 RID: 1624
	[global::Cpp2ILInjected.Token(Token = "0x40008B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
	private bool miscFilterInitialised;

	// Token: 0x04000659 RID: 1625
	[global::Cpp2ILInjected.Token(Token = "0x40008B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private float collapseScale;

	// Token: 0x0400065A RID: 1626
	[global::Cpp2ILInjected.Token(Token = "0x40008B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private float allScale;

	// Token: 0x0400065B RID: 1627
	[global::Cpp2ILInjected.Token(Token = "0x40008B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private float weaponScale;

	// Token: 0x0400065C RID: 1628
	[global::Cpp2ILInjected.Token(Token = "0x40008B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private float armorScale;

	// Token: 0x0400065D RID: 1629
	[global::Cpp2ILInjected.Token(Token = "0x40008B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private float vanityScale;

	// Token: 0x0400065E RID: 1630
	[global::Cpp2ILInjected.Token(Token = "0x40008B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private float buildingBlockScale;

	// Token: 0x0400065F RID: 1631
	[global::Cpp2ILInjected.Token(Token = "0x40008BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private float furnitureScale;

	// Token: 0x04000660 RID: 1632
	[global::Cpp2ILInjected.Token(Token = "0x40008BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private float gameplayItemsScale;

	// Token: 0x04000661 RID: 1633
	[global::Cpp2ILInjected.Token(Token = "0x40008BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private float accessoriesScale;

	// Token: 0x04000662 RID: 1634
	[global::Cpp2ILInjected.Token(Token = "0x40008BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private float equipmentScale;

	// Token: 0x04000663 RID: 1635
	[global::Cpp2ILInjected.Token(Token = "0x40008BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	private float consumablesScale;

	// Token: 0x04000664 RID: 1636
	[global::Cpp2ILInjected.Token(Token = "0x40008BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private float toolsScale;

	// Token: 0x04000665 RID: 1637
	[global::Cpp2ILInjected.Token(Token = "0x40008C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	private float materialsScale;

	// Token: 0x04000666 RID: 1638
	[global::Cpp2ILInjected.Token(Token = "0x40008C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public GUIControllerItemFilter _controller;

	// Token: 0x04000667 RID: 1639
	[global::Cpp2ILInjected.Token(Token = "0x40008C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private GUIControllerItem previousNavigationItem;

	// Token: 0x04000668 RID: 1640
	[global::Cpp2ILInjected.Token(Token = "0x40008C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x04000669 RID: 1641
	[global::Cpp2ILInjected.Token(Token = "0x40008C4")]
	private static float BeginSearchScale;

	// Token: 0x020007C6 RID: 1990
	[global::Cpp2ILInjected.Token(Token = "0x2000150")]
	public enum CategoryFilter
	{
		// Token: 0x04007A26 RID: 31270
		[global::Cpp2ILInjected.Token(Token = "0x40008C6")]
		All,
		// Token: 0x04007A27 RID: 31271
		[global::Cpp2ILInjected.Token(Token = "0x40008C7")]
		Weapon,
		// Token: 0x04007A28 RID: 31272
		[global::Cpp2ILInjected.Token(Token = "0x40008C8")]
		Armor,
		// Token: 0x04007A29 RID: 31273
		[global::Cpp2ILInjected.Token(Token = "0x40008C9")]
		Vanity,
		// Token: 0x04007A2A RID: 31274
		[global::Cpp2ILInjected.Token(Token = "0x40008CA")]
		BuildingBlock,
		// Token: 0x04007A2B RID: 31275
		[global::Cpp2ILInjected.Token(Token = "0x40008CB")]
		Furniture,
		// Token: 0x04007A2C RID: 31276
		[global::Cpp2ILInjected.Token(Token = "0x40008CC")]
		Accessories,
		// Token: 0x04007A2D RID: 31277
		[global::Cpp2ILInjected.Token(Token = "0x40008CD")]
		Equipment,
		// Token: 0x04007A2E RID: 31278
		[global::Cpp2ILInjected.Token(Token = "0x40008CE")]
		Consumables,
		// Token: 0x04007A2F RID: 31279
		[global::Cpp2ILInjected.Token(Token = "0x40008CF")]
		Tools,
		// Token: 0x04007A30 RID: 31280
		[global::Cpp2ILInjected.Token(Token = "0x40008D0")]
		Materials,
		// Token: 0x04007A31 RID: 31281
		[global::Cpp2ILInjected.Token(Token = "0x40008D1")]
		GameplayItems,
		// Token: 0x04007A32 RID: 31282
		[global::Cpp2ILInjected.Token(Token = "0x40008D2")]
		Count
	}
}
