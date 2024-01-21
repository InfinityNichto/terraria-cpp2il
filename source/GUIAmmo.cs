using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class GUIAmmo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private int itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private int itemDragStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private int lastItemClicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private float doubleClickTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private bool rightClickHeld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public GUIItemGrid.GetItemScaleHandler ItemScaleDelegate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private GUIItemGrid.CursorOver ItemOverDelegate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private GUIItemGrid.DrawItemHandler itemDrawDelegate;

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x134E8A8", Offset = "0x134E8A8", VA = "0x134E8A8")]
	public GUIAmmo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x134E9C0", Offset = "0x134E9C0", VA = "0x134E9C0")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x134EA94", Offset = "0x134EA94", VA = "0x134EA94")]
	private bool CanBeStored(Item checkItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x134EAD0", Offset = "0x134EAD0", VA = "0x134EAD0")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x134EB40", Offset = "0x134EB40", VA = "0x134EB40")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x134FE04", Offset = "0x134FE04", VA = "0x134FE04")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x13505F4", Offset = "0x13505F4", VA = "0x13505F4")]
	public void Draw()
	{
	}
}
