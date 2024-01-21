using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class GUIDraggableItemGrid
{
	[Cpp2IlInjected.Token(Token = "0x20007A8")]
	public delegate void DrawItemClippedHandler(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale, Rectangle inner, Rectangle outer);

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static Rectangle dragRegion;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static Rectangle fullRegion;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private static Vector2 drawOffset;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private static float itemWidth;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private static float itemHeight;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private static float orgScrollOffset;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private static GUIItemGrid.CursorOver _overHandler;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private static GUIItemGrid.DrawItemHandler _drawhandler;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private static GUIItemGrid.GetItemSizeHandler _sizehandler;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private static GUIItemGrid.DrawItemHandler SetSizeClippedDrawItem;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private static GUIItemGrid.DrawItemHandler ClippedDrawItem;

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x12CD098", Offset = "0x12CD098", VA = "0x12CD098")]
	private static void SetSizeClippedDrawItemHandler(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x12CD1D0", Offset = "0x12CD1D0", VA = "0x12CD1D0")]
	private static void ClippedDrawItemHandler(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x12BC8A4", Offset = "0x12BC8A4", VA = "0x12BC8A4")]
	public static void Draw(DraggableItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int itemCount, ref float scrollOffset, ref float momentum, ref int draggingState, ref Vector2 dragPosition, [Optional] Texture2D overloadBackingTexture, bool drawMissingItems = false, bool allowMouseScroll = false, bool disableDragScroll = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x12CD8B0", Offset = "0x12CD8B0", VA = "0x12CD8B0")]
	public static void Draw(DraggableItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int itemCount, ref float scrollOffset, ref float momentum, ref int draggingState, ref Vector2 dragPosition, Vector2 itemSize, bool drawMissingItems = false, bool allowMouseScroll = false, bool disableDragScroll = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x12CED6C", Offset = "0x12CED6C", VA = "0x12CED6C")]
	public static void Draw(DraggableItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int itemCount, ref float scrollOffset, ref float momentum, ref int draggingState, ref Vector2 dragPosition, GUIItemGrid.GetItemSizeHandler itemSizeHandler, bool drawMissingItems = false, bool allowMouseScroll = false, bool disableDragScroll = false)
	{
	}
}
