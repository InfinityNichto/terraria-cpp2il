using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000424")]
public class ColorSlidersSet
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062B6")]
	public float Hue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40062B7")]
	public float Saturation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40062B8")]
	public float Luminance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40062B9")]
	public float Alpha;

	[Cpp2IlInjected.Token(Token = "0x60030E4")]
	[Cpp2IlInjected.Address(RVA = "0x10127C0", Offset = "0x10127C0", VA = "0x10127C0")]
	public void SetHSL(Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030E5")]
	[Cpp2IlInjected.Address(RVA = "0x1012858", Offset = "0x1012858", VA = "0x1012858")]
	public void SetHSL(Vector3 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030E6")]
	[Cpp2IlInjected.Address(RVA = "0x1012864", Offset = "0x1012864", VA = "0x1012864")]
	public Color GetColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60030E7")]
	[Cpp2IlInjected.Address(RVA = "0x101293C", Offset = "0x101293C", VA = "0x101293C")]
	public Vector3 GetHSLVector()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60030E8")]
	[Cpp2IlInjected.Address(RVA = "0x1012978", Offset = "0x1012978", VA = "0x1012978")]
	public void ApplyToMainLegacyBars()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030E9")]
	[Cpp2IlInjected.Address(RVA = "0x1012A24", Offset = "0x1012A24", VA = "0x1012A24")]
	public ColorSlidersSet()
	{
	}
}
