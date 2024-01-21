using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class GUIItemDuplication
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	private float CraftButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	private int Offset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	public int FocusItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private int LastId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private GUIItemFilter.CategoryFilter LastCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	private string LastSearch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private bool rightClickHeld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000640")]
	public GUIItemFilter Filter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private List<int> AvailableItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	public List<int> FilteredItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	public float craftScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private float craftScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private int craftScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private Vector2 craftDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000647")]
	private bool pendingCraft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000648")]
	public float hoverCraftDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	public GUITransactionButton.InputState lastState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private bool wasOverItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private int multiCraftDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private int slowRampUp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private int multiCraftRecipe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private int HoverDuplicateEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private bool lastRightDown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private Item blankItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private string materialHoverItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private Item materialToolTip;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x1368E30", Offset = "0x1368E30", VA = "0x1368E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool Collapsed
	{
		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x1368F38", Offset = "0x1368F38", VA = "0x1368F38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(RVA = "0x1368D44", Offset = "0x1368D44", VA = "0x1368D44")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x1368FB8", Offset = "0x1368FB8", VA = "0x1368FB8")]
	public void DrawCraftButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0x1369C24", Offset = "0x1369C24", VA = "0x1369C24")]
	public void ResetFilters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x1369C48", Offset = "0x1369C48", VA = "0x1369C48")]
	private void UpdateFilter(bool force = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000839")]
	[Cpp2IlInjected.Address(RVA = "0x136A1B0", Offset = "0x136A1B0", VA = "0x136A1B0")]
	private int CompareItemOrder(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x136A398", Offset = "0x136A398", VA = "0x136A398")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x136A4AC", Offset = "0x136A4AC", VA = "0x136A4AC")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x136AB48", Offset = "0x136AB48", VA = "0x136AB48")]
	public float CraftItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x136ABA0", Offset = "0x136ABA0", VA = "0x136ABA0")]
	public void CraftItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x136B1E0", Offset = "0x136B1E0", VA = "0x136B1E0")]
	public void CraftItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x136B8C0", Offset = "0x136B8C0", VA = "0x136B8C0")]
	public GUIItemDuplication()
	{
	}
}
