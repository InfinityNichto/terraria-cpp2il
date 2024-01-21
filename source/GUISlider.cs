using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class GUISlider
{
	[Cpp2IlInjected.Token(Token = "0x20007AE")]
	public delegate void DrawBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver);

	[Cpp2IlInjected.Token(Token = "0x20007AF")]
	public class DragState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40079BC")]
		public bool wasDragging;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40079BD")]
		public float dragDir;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40079BE")]
		public float dragStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40079BF")]
		public float dragTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40079C0")]
		public Vector2 dragStartPoint;

		[Cpp2IlInjected.Token(Token = "0x60048F7")]
		[Cpp2IlInjected.Address(RVA = "0xEF43D0", Offset = "0xEF43D0", VA = "0xEF43D0")]
		public DragState()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0xEF0D18", Offset = "0xEF0D18", VA = "0xEF0D18")]
	public static Rectangle GetRegion(Slider_Layout layout)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0xEF0ED8", Offset = "0xEF0ED8", VA = "0xEF0ED8")]
	public static void DrawSaturationSlider(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0xEF1338", Offset = "0xEF1338", VA = "0xEF1338")]
	public static void DrawLightnessSlider(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0xEF1798", Offset = "0xEF1798", VA = "0xEF1798")]
	public static bool DrawSaturation(Slider_Layout layout, bool disablePick, ref float value, DragState dragState, bool forceOver = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0xEF3BA8", Offset = "0xEF3BA8", VA = "0xEF3BA8")]
	public static bool DrawLightness(Slider_Layout layout, bool disablePick, ref float value, DragState dragState, bool forceOver = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0xEF3C64", Offset = "0xEF3C64", VA = "0xEF3C64")]
	public static bool IsCursorOver(Vector2 cursorPosition, Slider_Layout layout)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0xEF3E9C", Offset = "0xEF3E9C", VA = "0xEF3E9C")]
	public static float QuantiseValue(float input, int stepCount)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0xEF3ECC", Offset = "0xEF3ECC", VA = "0xEF3ECC")]
	public static float CalculateValue(int input, int minValue, int maxValue)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xEF3F6C", Offset = "0xEF3F6C", VA = "0xEF3F6C")]
	public static int ScaleValue(float input, int minValue, int maxValue)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0xEF1868", Offset = "0xEF1868", VA = "0xEF1868")]
	public static bool Draw(Slider_Layout layout, bool disablePick, ref float value, DragState dragState, [Optional] DrawBackingHandler backingHandler, bool forceOver = false, int minValue = -1, int maxValue = -1, bool ignoreStartPoint = false)
	{
		return default(bool);
	}
}
