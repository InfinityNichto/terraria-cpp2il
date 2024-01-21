using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class GUIItemGrid
{
	[Cpp2IlInjected.Token(Token = "0x20007A9")]
	public delegate void CursorOver(int itemIndex);

	[Cpp2IlInjected.Token(Token = "0x20007AA")]
	public delegate float GetItemScaleHandler(int itemIndex);

	[Cpp2IlInjected.Token(Token = "0x20007AB")]
	public delegate void DrawItemHandler(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale);

	[Cpp2IlInjected.Token(Token = "0x20007AC")]
	public delegate Vector2 GetItemSizeHandler(int itemIndex);

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static bool disablePickingCallbacks;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static Rectangle calculatedRegion;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static int calcBackingWidth;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static int calcBackingHeight;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private static bool calcRegionInitialised;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private static DrawItemHandler dummyDraw;

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x136EDB0", Offset = "0x136EDB0", VA = "0x136EDB0")]
	private static void DummyDraw(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x136F148", Offset = "0x136F148", VA = "0x136F148")]
	public static Rectangle CalculateRegion(ItemGrid_Layout gridLayout, GetItemScaleHandler scaleHandler, Vector2 itemSize, int overloadedItemCount = -1)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x136127C", Offset = "0x136127C", VA = "0x136127C")]
	public static Rectangle CalculateRegion(ItemGrid_Layout gridLayout, GetItemScaleHandler scaleHandler, int overloadedItemCount = -1, [Optional] Texture2D overloadBackingTexture)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x13662B0", Offset = "0x13662B0", VA = "0x13662B0")]
	public static void Draw(ItemGrid_Layout gridLayout, GetItemScaleHandler scaleHandler, CursorOver cursorOverHandler, DrawItemHandler drawhandler, int overloadedItemCount = -1, [Optional] Texture2D overloadBackingTexture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x1370814", Offset = "0x1370814", VA = "0x1370814")]
	public static void Draw(ItemGrid_Layout gridLayout, GetItemScaleHandler scaleHandler, CursorOver cursorOverHandler, DrawItemHandler drawhandler, GetItemSizeHandler itemSizeHandler, int overloadedItemCount = -1, int reverseOrverOffset = 0, int maxRowSize = -1, int maxRowSizeLineCount = 1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x136F26C", Offset = "0x136F26C", VA = "0x136F26C")]
	public static void Draw(ItemGrid_Layout gridLayout, GetItemScaleHandler scaleHandler, CursorOver cursorOverHandler, DrawItemHandler drawhandler, Vector2 itemSize, int overloadedItemCount = -1)
	{
	}
}
