using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000D3")]
public class GUICoins
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private int itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private int itemDragStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private int lastItemClicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private float doubleClickTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private bool rightClickHeld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public GUIItemGrid.GetItemScaleHandler ItemScaleDelegate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private GUIItemGrid.CursorOver ItemOverDelegate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private GUIItemGrid.DrawItemHandler itemDrawDelegate;

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0xF8A794", Offset = "0xF8A794", VA = "0xF8A794")]
	public GUICoins()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0xF8A8AC", Offset = "0xF8A8AC", VA = "0xF8A8AC")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0xF8A980", Offset = "0xF8A980", VA = "0xF8A980")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0xF8A9F0", Offset = "0xF8A9F0", VA = "0xF8A9F0")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0xF8BC50", Offset = "0xF8BC50", VA = "0xF8BC50")]
	private bool CanBeStored(Item checkItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0xF8BC78", Offset = "0xF8BC78", VA = "0xF8BC78")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0xF8C448", Offset = "0xF8C448", VA = "0xF8C448")]
	public void Draw()
	{
	}
}
