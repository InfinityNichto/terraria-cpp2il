using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class GUICraftGuide
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public float craftScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private float craftScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private int craftScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private Vector2 craftDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public bool menuTogglePressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public bool materialsGridActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private DateTime NavigationTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private GUIControllerCraftingMaterials materialController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private List<string> _requiredObjecsForCraftingText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public List<int> _materialItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private Item _defaultItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private int _selectedItem;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool Collapsed
	{
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x12BABFC", Offset = "0x12BABFC", VA = "0x12BABFC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x12BAD68", Offset = "0x12BAD68", VA = "0x12BAD68")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public Item guideItem
	{
		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x12BAE40", Offset = "0x12BAE40", VA = "0x12BAE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x12BAAFC", Offset = "0x12BAAFC", VA = "0x12BAAFC")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x12BAC7C", Offset = "0x12BAC7C", VA = "0x12BAC7C")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x12BAF14", Offset = "0x12BAF14", VA = "0x12BAF14")]
	private void RefreshItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x12BB030", Offset = "0x12BB030", VA = "0x12BB030")]
	public void DrawGuideList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x12BB634", Offset = "0x12BB634", VA = "0x12BB634")]
	public float GuideItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x12BB68C", Offset = "0x12BB68C", VA = "0x12BB68C")]
	public void GuideItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x12BBC28", Offset = "0x12BBC28", VA = "0x12BBC28")]
	public void GuideItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x12BC258", Offset = "0x12BC258", VA = "0x12BC258")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x12BCA0C", Offset = "0x12BCA0C", VA = "0x12BCA0C")]
	public GUICraftGuide()
	{
	}
}
