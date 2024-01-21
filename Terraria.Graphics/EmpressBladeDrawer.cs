using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics;

[Cpp2IlInjected.Token(Token = "0x20004E6")]
public struct EmpressBladeDrawer
{
	[Cpp2IlInjected.Token(Token = "0x4006731")]
	public const int TotalIllusions = 1;

	[Cpp2IlInjected.Token(Token = "0x4006732")]
	public const int FramesPerImportantTrail = 60;

	[Cpp2IlInjected.Token(Token = "0x4006733")]
	private static VertexStrip _vertexStrip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006734")]
	public Color ColorStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006735")]
	public Color ColorEnd;

	[Cpp2IlInjected.Token(Token = "0x60036F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A0600", Offset = "0x3A0600", VA = "0x3A0600")]
	public void Draw(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A0608", Offset = "0x3A0608", VA = "0x3A0608")]
	private void StripColors(float progressOnStrip, out Color col)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A0610", Offset = "0x3A0610", VA = "0x3A0610")]
	private float StripWidth(float progressOnStrip)
	{
		return default(float);
	}
}
