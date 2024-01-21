using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics;

[StructLayout(0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20004EA")]
public struct RainbowRodDrawer
{
	[Cpp2IlInjected.Token(Token = "0x400673A")]
	private static VertexStrip _vertexStrip;

	[Cpp2IlInjected.Token(Token = "0x6003704")]
	[Cpp2IlInjected.Address(RVA = "0x39DF14", Offset = "0x39DF14", VA = "0x39DF14")]
	public void Draw(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003705")]
	[Cpp2IlInjected.Address(RVA = "0x39DF1C", Offset = "0x39DF1C", VA = "0x39DF1C")]
	private void StripColors(float progressOnStrip, out Color col)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003706")]
	[Cpp2IlInjected.Address(RVA = "0x39DF20", Offset = "0x39DF20", VA = "0x39DF20")]
	private float StripWidth(float progressOnStrip)
	{
		return default(float);
	}
}
