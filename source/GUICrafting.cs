using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class GUICrafting
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private float CraftButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private int Offset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private int LastId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private GUIItemFilter.CategoryFilter LastCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private string LastSearch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public GUIItemFilter Filter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public List<int> FilteredItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public float craftScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private float craftScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private int craftScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private Vector2 craftDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private bool pendingCraft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public float hoverCraftDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public GUITransactionButton.InputState lastState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private float ExpandButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public bool menuTogglePressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public bool materialsGridActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private DateTime NavigationTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private GUIControllerCraftingMaterials materialController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private int multiCraftDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private int multiCraftRecipe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private bool wasOverItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private int HoverRecipe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public Recipe CraftHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private Item blankItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private string materialHoverItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private Item materialToolTip;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x12C0B24", Offset = "0x12C0B24", VA = "0x12C0B24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int SelectedNumMaterials
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x12C1F34", Offset = "0x12C1F34", VA = "0x12C1F34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int CraftHoverNumMaterials
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x12C2080", Offset = "0x12C2080", VA = "0x12C2080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool Collapsed
	{
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x12C20C8", Offset = "0x12C20C8", VA = "0x12C20C8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x12C0A38", Offset = "0x12C0A38", VA = "0x12C0A38")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x12C0C28", Offset = "0x12C0C28", VA = "0x12C0C28")]
	public void DrawCraftButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x12C2148", Offset = "0x12C2148", VA = "0x12C2148")]
	public void DrawExpandButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x12C214C", Offset = "0x12C214C", VA = "0x12C214C")]
	public void DrawMaterialsGridTooltip(Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x12C2334", Offset = "0x12C2334", VA = "0x12C2334")]
	public void DrawMaterialsGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x12C298C", Offset = "0x12C298C", VA = "0x12C298C")]
	public void UpdateMaterialNavigation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x12C2BB4", Offset = "0x12C2BB4", VA = "0x12C2BB4")]
	public void ResetFilters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x12C2BD8", Offset = "0x12C2BD8", VA = "0x12C2BD8")]
	private void UpdateFilter(bool force = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x12C2DB8", Offset = "0x12C2DB8", VA = "0x12C2DB8")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x12C2ED0", Offset = "0x12C2ED0", VA = "0x12C2ED0")]
	public void RefreshGridNav()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x12C3060", Offset = "0x12C3060", VA = "0x12C3060")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x12C3788", Offset = "0x12C3788", VA = "0x12C3788")]
	public float CraftItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x12C37E0", Offset = "0x12C37E0", VA = "0x12C37E0")]
	private void RefocusExistingRecipeIfStillAvailable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x12C1360", Offset = "0x12C1360", VA = "0x12C1360")]
	public void CraftButtonOver(GUITransactionButton.InputState state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x12C38E4", Offset = "0x12C38E4", VA = "0x12C38E4")]
	public void CraftItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x12C4094", Offset = "0x12C4094", VA = "0x12C4094")]
	public void CraftItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x12C47D4", Offset = "0x12C47D4", VA = "0x12C47D4")]
	public float MaterialItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x12C482C", Offset = "0x12C482C", VA = "0x12C482C")]
	public void MaterialItemTooltipOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x12C4830", Offset = "0x12C4830", VA = "0x12C4830")]
	public void MaterialItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(RVA = "0x12C5AE8", Offset = "0x12C5AE8", VA = "0x12C5AE8")]
	public void MaterialItemTooltipDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075A")]
	[Cpp2IlInjected.Address(RVA = "0x12C669C", Offset = "0x12C669C", VA = "0x12C669C")]
	public void MaterialItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x12C72A4", Offset = "0x12C72A4", VA = "0x12C72A4")]
	public GUICrafting()
	{
	}
}
