using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using UnityEngine;

// Token: 0x020000A6 RID: 166
[global::Cpp2ILInjected.Token(Token = "0x20000E1")]
public class GUIControllerDynamicGridNavigator
{
	// Token: 0x0600053C RID: 1340 RVA: 0x00022AF9 File Offset: 0x00020CF9
	[global::Cpp2ILInjected.Token(Token = "0x60005D6")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1B42C", Offset = "0xB1B42C", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "get_GridNav", ReturnType = typeof(GUIControllerDynamicGridNavigator))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerDynamicGridNavigator(GUIPageContentController controller, GUIControllerDynamicGridNavigator.GetGrid grid, GUIControllerDynamicGridNavigator.GetCollectionCount collectionCount, GUIControllerDynamicGridNavigator.GetItemScale itemScale, GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset, GUIControllerDynamicGridNavigator.SetScrollOffset setScrollOffset, GUIControllerDynamicGridNavigator.GetCollectionCount menuItemCount, GUIControllerDynamicGridNavigator.GetCollectionCount displayItemCount)
	{
		throw null;
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x0600053D RID: 1341 RVA: 0x00022AFC File Offset: 0x00020CFC
	[global::Cpp2ILInjected.Token(Token = "0x170000AC")]
	private DraggableItemGrid_Layout GridLayout
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005D7")]
		[global::Cpp2ILInjected.Address(RVA = "0xB23910", Offset = "0xB23910", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x0600053E RID: 1342 RVA: 0x00022AFF File Offset: 0x00020CFF
	[global::Cpp2ILInjected.Token(Token = "0x170000AD")]
	private int itemCount
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005D8")]
		[global::Cpp2ILInjected.Address(RVA = "0xB23924", Offset = "0xB23924", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x0600053F RID: 1343 RVA: 0x00022B02 File Offset: 0x00020D02
	[global::Cpp2ILInjected.Token(Token = "0x170000AE")]
	private float itemScale
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005D9")]
		[global::Cpp2ILInjected.Address(RVA = "0xB23938", Offset = "0xB23938", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x06000540 RID: 1344 RVA: 0x00022B05 File Offset: 0x00020D05
	// (set) Token: 0x06000541 RID: 1345 RVA: 0x00022B08 File Offset: 0x00020D08
	[global::Cpp2ILInjected.Token(Token = "0x170000AF")]
	private float GridScrollOffset
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005DA")]
		[global::Cpp2ILInjected.Address(RVA = "0xB2394C", Offset = "0xB2394C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60005DB")]
		[global::Cpp2ILInjected.Address(RVA = "0xB23960", Offset = "0xB23960", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00022B0B File Offset: 0x00020D0B
	[global::Cpp2ILInjected.Token(Token = "0x60005DC")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23974", Offset = "0xB23974", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearchPage), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	public void DisableScrollUntilChange()
	{
		throw null;
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00022B0E File Offset: 0x00020D0E
	[global::Cpp2ILInjected.Token(Token = "0x60005DD")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1AF64", Offset = "0xB1AF64", Length = "0x120")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "NextItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_LeftSideController", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRow_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRowColumn_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public void NextItem()
	{
		throw null;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00022B11 File Offset: 0x00020D11
	[global::Cpp2ILInjected.Token(Token = "0x60005DE")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1B0A0", Offset = "0xB1B0A0", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_LeftSideController", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRow_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRowColumn_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public void PreviousItem()
	{
		throw null;
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000545 RID: 1349 RVA: 0x00022B14 File Offset: 0x00020D14
	[global::Cpp2ILInjected.Token(Token = "0x170000B0")]
	private int MenuItemCount
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005DF")]
		[global::Cpp2ILInjected.Address(RVA = "0xB23AE0", Offset = "0xB23AE0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000546 RID: 1350 RVA: 0x00022B17 File Offset: 0x00020D17
	[global::Cpp2ILInjected.Token(Token = "0x170000B1")]
	private int DisplayItemCount
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005E0")]
		[global::Cpp2ILInjected.Address(RVA = "0xB23AF4", Offset = "0xB23AF4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00022B1A File Offset: 0x00020D1A
	[global::Cpp2ILInjected.Token(Token = "0x60005E1")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23B08", Offset = "0xB23B08", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool isSelectedItem(int itemIndex)
	{
		throw null;
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00022B1D File Offset: 0x00020D1D
	[global::Cpp2ILInjected.Token(Token = "0x60005E2")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1B858", Offset = "0xB1B858", Length = "0x1B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerResearchPage4Page), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NextItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "PreviousItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuide), Member = "GuideItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "MaterialItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "RefreshGridNav", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "NPCOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "Open", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearchPage), Member = "ResearchItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_MenuController", ReturnType = typeof(GUIControllerPageGroup))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_SelectedCategory", ReturnType = typeof(GUIPageIcons.Category))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "IndexOf", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Activate(int itemIndex = -1)
	{
		throw null;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00022B20 File Offset: 0x00020D20
	[global::Cpp2ILInjected.Token(Token = "0x60005E3")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1BA3C", Offset = "0xB1BA3C", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerResearchPage4Page), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_LeftSideController", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateVertical", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerItem Navigate(Microsoft.Xna.Framework.Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x0600054A RID: 1354 RVA: 0x00022B23 File Offset: 0x00020D23
	[global::Cpp2ILInjected.Token(Token = "0x170000B2")]
	private int MaxRow_Horizontal
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005E4")]
		[global::Cpp2ILInjected.Address(RVA = "0xB239DC", Offset = "0xB239DC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NextItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "PreviousItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x0600054B RID: 1355 RVA: 0x00022B26 File Offset: 0x00020D26
	[global::Cpp2ILInjected.Token(Token = "0x170000B3")]
	private int MaxRowColumn_Horizontal
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005E5")]
		[global::Cpp2ILInjected.Address(RVA = "0xB23A54", Offset = "0xB23A54", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NextItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "PreviousItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x0600054C RID: 1356 RVA: 0x00022B29 File Offset: 0x00020D29
	[global::Cpp2ILInjected.Token(Token = "0x170000B4")]
	private int MaxRow_Vertical
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005E6")]
		[global::Cpp2ILInjected.Address(RVA = "0xB24840", Offset = "0xB24840", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateVertical", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x0600054D RID: 1357 RVA: 0x00022B2C File Offset: 0x00020D2C
	[global::Cpp2ILInjected.Token(Token = "0x170000B5")]
	private int MaxRowColumn_Vertical
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005E7")]
		[global::Cpp2ILInjected.Address(RVA = "0xB248C8", Offset = "0xB248C8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateVertical", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x0600054E RID: 1358 RVA: 0x00022B2F File Offset: 0x00020D2F
	[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
	private int MenuColumn
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005E8")]
		[global::Cpp2ILInjected.Address(RVA = "0xB24964", Offset = "0xB24964", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerResearchPage4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_InMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInnerOutOfGrid", ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateVertical", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x0600054F RID: 1359 RVA: 0x00022B32 File Offset: 0x00020D32
	[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
	private bool LeftSideController
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005E9")]
		[global::Cpp2ILInjected.Address(RVA = "0xB239A4", Offset = "0xB239A4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NextItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "PreviousItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInnerOutOfGrid", ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000550 RID: 1360 RVA: 0x00022B35 File Offset: 0x00020D35
	[global::Cpp2ILInjected.Token(Token = "0x170000B8")]
	private int MaxScrollOffset_Horizontal
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005EA")]
		[global::Cpp2ILInjected.Address(RVA = "0xB24A04", Offset = "0xB24A04", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "UpdateScroll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000551 RID: 1361 RVA: 0x00022B38 File Offset: 0x00020D38
	[global::Cpp2ILInjected.Token(Token = "0x170000B9")]
	private int MaxDisplayRow_Horizontal
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005EB")]
		[global::Cpp2ILInjected.Address(RVA = "0xB24AB8", Offset = "0xB24AB8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x00022B3B File Offset: 0x00020D3B
	[global::Cpp2ILInjected.Token(Token = "0x60005EC")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1E484", Offset = "0xB1E484", Length = "0x26C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "RefreshScrollOffset", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxScrollOffset_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void RefreshScrollOffset()
	{
		throw null;
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x00022B3E File Offset: 0x00020D3E
	[global::Cpp2ILInjected.Token(Token = "0x60005ED")]
	[global::Cpp2ILInjected.Address(RVA = "0xB23B84", Offset = "0xB23B84", Length = "0x4A8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Activate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxScrollOffset_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	protected void UpdateScroll()
	{
		throw null;
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000554 RID: 1364 RVA: 0x00022B41 File Offset: 0x00020D41
	[global::Cpp2ILInjected.Token(Token = "0x170000BA")]
	private bool HasMenu
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005EE")]
		[global::Cpp2ILInjected.Address(RVA = "0xB24AFC", Offset = "0xB24AFC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000555 RID: 1365 RVA: 0x00022B44 File Offset: 0x00020D44
	[global::Cpp2ILInjected.Token(Token = "0x170000BB")]
	public bool InMenu
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005EF")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1B1CC", Offset = "0xB1B1CC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "IsInMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00022B47 File Offset: 0x00020D47
	[global::Cpp2ILInjected.Token(Token = "0x60005F0")]
	[global::Cpp2ILInjected.Address(RVA = "0xB24B4C", Offset = "0xB24B4C", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInnerOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateVertical", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	private void ClampMenu(bool preferUp = true)
	{
		throw null;
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00022B4A File Offset: 0x00020D4A
	[global::Cpp2ILInjected.Token(Token = "0x60005F1")]
	[global::Cpp2ILInjected.Address(RVA = "0xB24C0C", Offset = "0xB24C0C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateVertical", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_MenuController", ReturnType = typeof(GUIControllerPageGroup))]
	private GUIControllerItem NavigateMenuOutOfGrid()
	{
		throw null;
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00022B4D File Offset: 0x00020D4D
	[global::Cpp2ILInjected.Token(Token = "0x60005F2")]
	[global::Cpp2ILInjected.Address(RVA = "0xB24C54", Offset = "0xB24C54", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateVertical", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateUp", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	private GUIControllerItem NavigateUpOutOfGrid()
	{
		throw null;
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00022B50 File Offset: 0x00020D50
	[global::Cpp2ILInjected.Token(Token = "0x60005F3")]
	[global::Cpp2ILInjected.Address(RVA = "0xB24C84", Offset = "0xB24C84", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateVertical", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	private GUIControllerItem NavigateDownOutOfGrid()
	{
		throw null;
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00022B53 File Offset: 0x00020D53
	[global::Cpp2ILInjected.Token(Token = "0x60005F4")]
	[global::Cpp2ILInjected.Address(RVA = "0xB24CB4", Offset = "0xB24CB4", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateVertical", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_LeftSideController", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = "get_ParentGrouping", ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "NavigateLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	private GUIControllerItem NavigateInnerOutOfGrid()
	{
		throw null;
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00022B56 File Offset: 0x00020D56
	[global::Cpp2ILInjected.Token(Token = "0x60005F5")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1B4A4", Offset = "0xB1B4A4", Length = "0x3A0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerResearchPage4Page), Member = "GetNavigationOutDirs", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_LeftSideController", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRowColumn_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRow_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRowColumn_Vertical", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRow_Vertical", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00022B59 File Offset: 0x00020D59
	[global::Cpp2ILInjected.Token(Token = "0x60005F6")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2402C", Offset = "0xB2402C", Length = "0x360")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRow_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRowColumn_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateMenuOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInnerOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateUpOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "UpdateUICursorPoint", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateDownOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private GUIControllerItem NavigateHorizontal(Microsoft.Xna.Framework.Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x00022B5C File Offset: 0x00020D5C
	[global::Cpp2ILInjected.Token(Token = "0x60005F7")]
	[global::Cpp2ILInjected.Address(RVA = "0xB2438C", Offset = "0xB2438C", Length = "0x4B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "Navigate", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRowColumn_Vertical", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInnerOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateMenuOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateUpOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRow_Vertical", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateDownOutOfGrid", ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "UpdateUICursorPoint", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private GUIControllerItem NavigateVertical(Microsoft.Xna.Framework.Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00022B5F File Offset: 0x00020D5F
	[global::Cpp2ILInjected.Token(Token = "0x60005F8")]
	[global::Cpp2ILInjected.Address(RVA = "0xB24DB4", Offset = "0xB24DB4", Length = "0x1EC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampMenu", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UseHorizontalPages", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRow_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MaxRowColumn_Horizontal", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	protected void ClampPosition()
	{
		throw null;
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x00022B62 File Offset: 0x00020D62
	[global::Cpp2ILInjected.Token(Token = "0x60005F9")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1BB20", Offset = "0xB1BB20", Length = "0x358")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerResearchPage4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_LeftSideController", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x00022B65 File Offset: 0x00020D65
	[global::Cpp2ILInjected.Token(Token = "0x60005FA")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1BEAC", Offset = "0xB1BEAC", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCrafting4Page), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuide), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerCraftingGuidePopup), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerItemDuplication4Page), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPVP4Page), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerResearchPage4Page), Member = "NavigateInto", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "get_MenuColumn", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerDynamicGridNavigator), Member = "ClampPosition", ReturnType = typeof(void))]
	public void NavigateInto(int column, int row)
	{
		throw null;
	}

	// Token: 0x0400032D RID: 813
	[global::Cpp2ILInjected.Token(Token = "0x40004BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private readonly GUIControllerDynamicGridNavigator.GetGrid _grid;

	// Token: 0x0400032E RID: 814
	[global::Cpp2ILInjected.Token(Token = "0x40004BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private readonly GUIControllerDynamicGridNavigator.GetCollectionCount _collectionCount;

	// Token: 0x0400032F RID: 815
	[global::Cpp2ILInjected.Token(Token = "0x40004BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private readonly GUIControllerDynamicGridNavigator.GetItemScale _itemScale;

	// Token: 0x04000330 RID: 816
	[global::Cpp2ILInjected.Token(Token = "0x40004BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private readonly GUIControllerDynamicGridNavigator.GetScrollOffset _getScrollOffset;

	// Token: 0x04000331 RID: 817
	[global::Cpp2ILInjected.Token(Token = "0x40004BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private readonly GUIControllerDynamicGridNavigator.SetScrollOffset _setScrollOffset;

	// Token: 0x04000332 RID: 818
	[global::Cpp2ILInjected.Token(Token = "0x40004BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private readonly GUIPageContentController _controller;

	// Token: 0x04000333 RID: 819
	[global::Cpp2ILInjected.Token(Token = "0x40004C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private readonly GUIControllerDynamicGridNavigator.GetCollectionCount _displayItemCount;

	// Token: 0x04000334 RID: 820
	[global::Cpp2ILInjected.Token(Token = "0x40004C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private readonly GUIControllerDynamicGridNavigator.GetCollectionCount _menuItemCount;

	// Token: 0x04000335 RID: 821
	[global::Cpp2ILInjected.Token(Token = "0x40004C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private bool scrollDisabledUntilChange;

	// Token: 0x04000336 RID: 822
	[global::Cpp2ILInjected.Token(Token = "0x40004C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private int itemCountAtDisableScroll;

	// Token: 0x04000337 RID: 823
	[global::Cpp2ILInjected.Token(Token = "0x40004C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public int itemRow;

	// Token: 0x04000338 RID: 824
	[global::Cpp2ILInjected.Token(Token = "0x40004C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public int itemColumn;

	// Token: 0x04000339 RID: 825
	[global::Cpp2ILInjected.Token(Token = "0x40004C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public bool inMenu;

	// Token: 0x0400033A RID: 826
	[global::Cpp2ILInjected.Token(Token = "0x40004C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public int menuRow;

	// Token: 0x0400033B RID: 827
	[global::Cpp2ILInjected.Token(Token = "0x40004C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private int scrollOffset;

	// Token: 0x0200079D RID: 1949
	// (Invoke) Token: 0x0600486E RID: 18542
	[global::Cpp2ILInjected.Token(Token = "0x20000E2")]
	public delegate DraggableItemGrid_Layout GetGrid();

	// Token: 0x0200079E RID: 1950
	// (Invoke) Token: 0x06004872 RID: 18546
	[global::Cpp2ILInjected.Token(Token = "0x20000E3")]
	public delegate int GetCollectionCount();

	// Token: 0x0200079F RID: 1951
	// (Invoke) Token: 0x06004876 RID: 18550
	[global::Cpp2ILInjected.Token(Token = "0x20000E4")]
	public delegate float GetItemScale();

	// Token: 0x020007A0 RID: 1952
	// (Invoke) Token: 0x0600487A RID: 18554
	[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
	public delegate float GetScrollOffset();

	// Token: 0x020007A1 RID: 1953
	// (Invoke) Token: 0x0600487E RID: 18558
	[global::Cpp2ILInjected.Token(Token = "0x20000E6")]
	public delegate void SetScrollOffset(float scrollOffset);
}
