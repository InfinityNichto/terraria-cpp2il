using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class GUICraftGuidePopup
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public GUIControllerCraftingGuidePopup _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public float materialScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private float materialScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private int materialScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private Vector2 materialDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private int OpenedFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public bool PopupDisplayed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private GUIInputRegionExclusive PickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private List<string> _requiredObjecsForCraftingText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private string materialHoverItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private Item materialToolTip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private int yoyoLogo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private int researchLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private int setBonusLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private int materialsLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private int numLines;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private string[] toolTipLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private bool[] preFixLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private bool[] badPreFixLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private Item lastItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	private float CachedLayoutSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private float CachedLayoutWrapSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private int CachedMinTextHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private Vector2 CachedTextSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private string displayString;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public float craftScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private float craftScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private int craftScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private Vector2 craftDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private int _selectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private int multiCraftDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public int focusGuideRecipe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public int[] availableGuideRecipe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public int numAvailableGuideRecipes;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public int SelectedNumMaterials
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x12BCC50", Offset = "0x12BCC50", VA = "0x12BCC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x12BCB14", Offset = "0x12BCB14", VA = "0x12BCB14")]
	public void LoadRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x12BDA34", Offset = "0x12BDA34", VA = "0x12BDA34")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x12BB458", Offset = "0x12BB458", VA = "0x12BB458")]
	public void OpenPopup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x12BDB58", Offset = "0x12BDB58", VA = "0x12BDB58")]
	public void ClosePopup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x12BDBE0", Offset = "0x12BDBE0", VA = "0x12BDBE0")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x12BDE94", Offset = "0x12BDE94", VA = "0x12BDE94")]
	public void LoadPanelRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x12BDF70", Offset = "0x12BDF70", VA = "0x12BDF70")]
	private void DrawItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x12BE76C", Offset = "0x12BE76C", VA = "0x12BE76C")]
	private void DrawMaterials()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x12BE8DC", Offset = "0x12BE8DC", VA = "0x12BE8DC")]
	public float MaterialItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x12BE938", Offset = "0x12BE938", VA = "0x12BE938")]
	public void MaterialItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x12BEFD0", Offset = "0x12BEFD0", VA = "0x12BEFD0")]
	public void MaterialItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x12BCD1C", Offset = "0x12BCD1C", VA = "0x12BCD1C")]
	private void UpdateText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x12BF27C", Offset = "0x12BF27C", VA = "0x12BF27C")]
	private void DrawText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x12BF31C", Offset = "0x12BF31C", VA = "0x12BF31C")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x12BFACC", Offset = "0x12BFACC", VA = "0x12BFACC")]
	private void DrawGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x12BFDF8", Offset = "0x12BFDF8", VA = "0x12BFDF8")]
	public float CraftItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x12BFE54", Offset = "0x12BFE54", VA = "0x12BFE54")]
	public void CraftItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x12C032C", Offset = "0x12C032C", VA = "0x12C032C")]
	public void CraftItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x12BB978", Offset = "0x12BB978", VA = "0x12BB978")]
	public void FindRecipes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x12C0900", Offset = "0x12C0900", VA = "0x12C0900")]
	public GUICraftGuidePopup()
	{
	}
}
