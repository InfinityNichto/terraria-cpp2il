using Cpp2IlInjected;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004D1")]
public struct StyleDimension
{
	[Cpp2IlInjected.Token(Token = "0x40066B1")]
	public static StyleDimension Fill;

	[Cpp2IlInjected.Token(Token = "0x40066B2")]
	public static StyleDimension Empty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40066B3")]
	public float Pixels;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40066B4")]
	public float Precent;

	[Cpp2IlInjected.Token(Token = "0x6003629")]
	[Cpp2IlInjected.Address(RVA = "0x39E668", Offset = "0x39E668", VA = "0x39E668")]
	public StyleDimension(float pixels, float precent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600362A")]
	[Cpp2IlInjected.Address(RVA = "0x39E674", Offset = "0x39E674", VA = "0x39E674")]
	public void Set(float pixels, float precent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600362B")]
	[Cpp2IlInjected.Address(RVA = "0x39E680", Offset = "0x39E680", VA = "0x39E680")]
	public float GetValue(float containerSize)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600362C")]
	[Cpp2IlInjected.Address(RVA = "0x1344DB8", Offset = "0x1344DB8", VA = "0x1344DB8")]
	public static StyleDimension FromPixels(float pixels)
	{
		return default(StyleDimension);
	}

	[Cpp2IlInjected.Token(Token = "0x600362D")]
	[Cpp2IlInjected.Address(RVA = "0x1344DC4", Offset = "0x1344DC4", VA = "0x1344DC4")]
	public static StyleDimension FromPercent(float percent)
	{
		return default(StyleDimension);
	}

	[Cpp2IlInjected.Token(Token = "0x600362E")]
	[Cpp2IlInjected.Address(RVA = "0x1344DD4", Offset = "0x1344DD4", VA = "0x1344DD4")]
	public static StyleDimension FromPixelsAndPercent(float pixels, float percent)
	{
		return default(StyleDimension);
	}
}
