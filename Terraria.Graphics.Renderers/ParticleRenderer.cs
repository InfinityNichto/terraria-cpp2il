using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20004F7")]
public class ParticleRenderer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006784")]
	public ParticleRendererSettings Settings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006785")]
	public List<IParticle> Particles;

	[Cpp2IlInjected.Token(Token = "0x6003774")]
	[Cpp2IlInjected.Address(RVA = "0x1244624", Offset = "0x1244624", VA = "0x1244624")]
	public ParticleRenderer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003775")]
	[Cpp2IlInjected.Address(RVA = "0x12446B4", Offset = "0x12446B4", VA = "0x12446B4")]
	public void Add(IParticle particle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003776")]
	[Cpp2IlInjected.Address(RVA = "0x1244718", Offset = "0x1244718", VA = "0x1244718")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003777")]
	[Cpp2IlInjected.Address(RVA = "0x1244774", Offset = "0x1244774", VA = "0x1244774")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003778")]
	[Cpp2IlInjected.Address(RVA = "0x12449E4", Offset = "0x12449E4", VA = "0x12449E4")]
	public void Draw(SpriteBatch spriteBatch)
	{
	}
}
