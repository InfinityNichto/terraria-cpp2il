using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class GUIInventory
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private int itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private int itemOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private int lastItemClicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	private int itemDragStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	private float doubleClickTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000621")]
	private bool rightClickHeld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000622")]
	private float favoriteButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	public bool InHandItemActionHappened;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	private GUIItemGrid.GetItemScaleHandler ItemScaleDelegate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private GUIItemGrid.CursorOver ItemOverDelegate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000626")]
	private GUIItemGrid.DrawItemHandler itemDrawDelegate;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x1362A04", Offset = "0x1362A04", VA = "0x1362A04")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x1360DC0", Offset = "0x1360DC0", VA = "0x1360DC0")]
	public GUIInventory()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(RVA = "0x1360F10", Offset = "0x1360F10", VA = "0x1360F10")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(RVA = "0x13613A0", Offset = "0x13613A0", VA = "0x13613A0")]
	public Item GetSelectedItem()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x13614FC", Offset = "0x13614FC", VA = "0x13614FC")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x1361554", Offset = "0x1361554", VA = "0x1361554")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x1362B44", Offset = "0x1362B44", VA = "0x1362B44")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x1365A08", Offset = "0x1365A08", VA = "0x1365A08")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x1363070", Offset = "0x1363070", VA = "0x1363070")]
	public void DrawItem(SpriteBatch spriteBatch, ItemGrid_Layout gridLayout, Item[] inv, int slot, Vector2 position, Color lightColor, float scale)
	{
	}
}
