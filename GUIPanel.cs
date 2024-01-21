using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000BE")]
public static class GUIPanel
{
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static bool forceRescale;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static bool scaleEdges;

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x113DC8C", Offset = "0x113DC8C", VA = "0x113DC8C")]
	public static bool IsCursorOver(Vector2 cursorUIPosition, Panel_Layout layout)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x113DEFC", Offset = "0x113DEFC", VA = "0x113DEFC")]
	public static bool RegisterPickingRegion(Panel_Layout layout)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x113E108", Offset = "0x113E108", VA = "0x113E108")]
	public static Rectangle Region(Panel_Layout layout)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x113E324", Offset = "0x113E324", VA = "0x113E324")]
	public static void Draw(Panel_Layout layout, bool cursorOver = false, [Optional] Color? overloadBacking, [Optional] Color? overloadBorder, [Optional] Color? overloadHighlight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x11407C4", Offset = "0x11407C4", VA = "0x11407C4")]
	public static void DrawAtPosition(Panel_Layout layout, Vector2 position, Vector2 size, bool cursorOver = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x1140998", Offset = "0x1140998", VA = "0x1140998")]
	public static void DrawHorizontalFill(Panel_Layout layout, Rectangle backgroundFillRegion, float fillScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x113E73C", Offset = "0x113E73C", VA = "0x113E73C")]
	public static void DrawBacking(Vector2 position, Vector2 size, Texture2D texture, Color color, [Optional] Rectangle? sourceFrame)
	{
	}
}
