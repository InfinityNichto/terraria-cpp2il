using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics;

[StructLayout(0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20004E8")]
public struct LightDiscDrawer
{
	[Cpp2IlInjected.Token(Token = "0x4006737")]
	private static VertexStrip _vertexStrip;

	[Cpp2IlInjected.Token(Token = "0x60036FC")]
	[Cpp2IlInjected.Address(RVA = "0x39DEEC", Offset = "0x39DEEC", VA = "0x39DEEC")]
	public void Draw(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036FD")]
	[Cpp2IlInjected.Address(RVA = "0x39DEF4", Offset = "0x39DEF4", VA = "0x39DEF4")]
	private void StripColors(float progressOnStrip, out Color col)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036FE")]
	[Cpp2IlInjected.Address(RVA = "0x39DEF8", Offset = "0x39DEF8", VA = "0x39DEF8")]
	private float StripWidth(float progressOnStrip)
	{
		return default(float);
	}
}
