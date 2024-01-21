using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics;

[Cpp2IlInjected.Token(Token = "0x20004E9")]
public struct FlameLashDrawer
{
	[Cpp2IlInjected.Token(Token = "0x4006738")]
	private static VertexStrip _vertexStrip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006739")]
	private float transitToDark;

	[Cpp2IlInjected.Token(Token = "0x6003700")]
	[Cpp2IlInjected.Address(RVA = "0x3A07E8", Offset = "0x3A07E8", VA = "0x3A07E8")]
	public void Draw(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003701")]
	[Cpp2IlInjected.Address(RVA = "0x3A07F0", Offset = "0x3A07F0", VA = "0x3A07F0")]
	private void StripColors(float progressOnStrip, out Color col)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003702")]
	[Cpp2IlInjected.Address(RVA = "0x3A07F8", Offset = "0x3A07F8", VA = "0x3A07F8")]
	private float StripWidth(float progressOnStrip)
	{
		return default(float);
	}
}
