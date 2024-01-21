using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics;

[StructLayout(0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20004E7")]
public struct MagicMissileDrawer
{
	[Cpp2IlInjected.Token(Token = "0x4006736")]
	private static VertexStrip _vertexStrip;

	[Cpp2IlInjected.Token(Token = "0x60036F8")]
	[Cpp2IlInjected.Address(RVA = "0x39DF04", Offset = "0x39DF04", VA = "0x39DF04")]
	public void Draw(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036F9")]
	[Cpp2IlInjected.Address(RVA = "0x39DF0C", Offset = "0x39DF0C", VA = "0x39DF0C")]
	private void StripColors(float progressOnStrip, out Color col)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036FA")]
	[Cpp2IlInjected.Address(RVA = "0x39DF10", Offset = "0x39DF10", VA = "0x39DF10")]
	private float StripWidth(float progressOnStrip)
	{
		return default(float);
	}
}
