using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class GUIAxis
{
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static float GlobalScale;

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x1350DBC", Offset = "0x1350DBC", VA = "0x1350DBC")]
	public static void Draw(Axis_Layout layout, Texture2D icon, ref Vector2 innerScreenOffset, ref Vector2 centre, bool active, bool useAlternativeInner = false, bool disabled = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x13519A0", Offset = "0x13519A0", VA = "0x13519A0")]
	public static void Draw(Axis_Layout layout, Texture2D icon, Rectangle srcRect, ref Vector2 innerScreenOffset, ref Vector2 centre, bool active, bool useAlternativeInner = false, bool disabled = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x13525D4", Offset = "0x13525D4", VA = "0x13525D4")]
	public static bool RegisterPickingRegion(Axis_Layout layout)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x1352904", Offset = "0x1352904", VA = "0x1352904")]
	public static bool IsCursorOverExpanded(Vector2 position, Axis_Layout layout, out Vector2 screenOffset, out Vector2 axis, ref Vector2 centre, bool wasActive, ref float expandedSize, bool forceCursorInside = false, bool disableAxisRebalance = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x13534B8", Offset = "0x13534B8", VA = "0x13534B8")]
	public static bool IsCursorOver(Vector2 position, Axis_Layout layout, out Vector2 screenOffset, out Vector2 axis, ref Vector2 centre, bool wasActive, bool forceCursorInside = false, bool disableAxisRebalance = false)
	{
		return default(bool);
	}
}
