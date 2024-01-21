using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class GUIButton
{
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static float GlobalScale;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static SpriteBatch overloadedSpriteBatch;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private static SpriteBatch sb
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xF7E374", Offset = "0xF7E374", VA = "0xF7E374")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0xF7E460", Offset = "0xF7E460", VA = "0xF7E460")]
	public static void Draw(Button_Layout layout, Texture2D texture, [Optional] Color? overrideColor, [Optional] float? overrideScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0xF7E884", Offset = "0xF7E884", VA = "0xF7E884")]
	public static void DrawAtPosition(Button_Layout layout, Vector2 position, Texture2D texture, [Optional] Color? overrideColor, [Optional] float? overrideScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0xF7EC28", Offset = "0xF7EC28", VA = "0xF7EC28")]
	public static void Draw(Button_Layout layout, Rectangle srcRect, Texture2D texture, [Optional] Color? overrideColor, [Optional] float? overrideScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0xF7F074", Offset = "0xF7F074", VA = "0xF7F074")]
	public static Rectangle GetRegion(Button_Layout layout, Texture2D texture)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0xF7F2A0", Offset = "0xF7F2A0", VA = "0xF7F2A0")]
	public static bool RegisterPickingRegion(Button_Layout layout, Texture2D texture)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0xF7F664", Offset = "0xF7F664", VA = "0xF7F664")]
	public static bool IsCursorOverAtPosition(Vector2 position, Button_Layout layout, Vector2 controlPosition, Texture2D texture)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0xF7F98C", Offset = "0xF7F98C", VA = "0xF7F98C")]
	public static bool IsCursorOverExpanded(Vector2 position, Button_Layout layout, Texture2D texture, ref float expanded)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0xF7FDE4", Offset = "0xF7FDE4", VA = "0xF7FDE4")]
	public static bool IsCursorOver(Vector2 position, Button_Layout layout, Texture2D texture)
	{
		return default(bool);
	}
}
