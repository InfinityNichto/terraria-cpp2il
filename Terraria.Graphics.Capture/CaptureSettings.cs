using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Capture;

[Cpp2IlInjected.Token(Token = "0x200050B")]
public class CaptureSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40067FF")]
	public Rectangle Area;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006800")]
	public bool UseScaling;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006801")]
	public string OutputName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006802")]
	public bool CaptureEntities;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006803")]
	public CaptureBiome Biome;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006804")]
	public bool CaptureMech;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4006805")]
	public bool CaptureBackground;

	[Cpp2IlInjected.Token(Token = "0x6003806")]
	[Cpp2IlInjected.Address(RVA = "0x150730C", Offset = "0x150730C", VA = "0x150730C")]
	public CaptureSettings()
	{
	}
}
