using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000FE")]
public class GUIResearchPage
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private float researchScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400077E")]
	private int refCost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400077F")]
	public List<int> _researchItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000780")]
	private Item _defaultItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000781")]
	public int _selectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000782")]
	public float scrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000783")]
	private float scrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000784")]
	private int scrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000785")]
	private Vector2 dragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000786")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000787")]
	private float reforgeActionScale;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool Collapsed
	{
		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x1156710", Offset = "0x1156710", VA = "0x1156710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x11569A4", Offset = "0x11569A4", VA = "0x11569A4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Item ResearchItem
	{
		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x1156F8C", Offset = "0x1156F8C", VA = "0x1156F8C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x1156610", Offset = "0x1156610", VA = "0x1156610")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x1156790", Offset = "0x1156790", VA = "0x1156790")]
	public int ReforgeCost()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x1156798", Offset = "0x1156798", VA = "0x1156798")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x1156880", Offset = "0x1156880", VA = "0x1156880")]
	private void RefreshItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x1156A9C", Offset = "0x1156A9C", VA = "0x1156A9C")]
	public void DrawResearch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x1157060", Offset = "0x1157060", VA = "0x1157060")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x115753C", Offset = "0x115753C", VA = "0x115753C")]
	public float ResearchItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x1157594", Offset = "0x1157594", VA = "0x1157594")]
	public void ResearchItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x1157804", Offset = "0x1157804", VA = "0x1157804")]
	public void ResearchItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x1157DD4", Offset = "0x1157DD4", VA = "0x1157DD4")]
	public GUIResearchPage()
	{
	}
}
