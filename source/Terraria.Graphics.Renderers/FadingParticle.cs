using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20004FE")]
public class FadingParticle : ABasicParticle
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40067B1")]
	public float FadeInNormalizedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40067B2")]
	public float FadeOutNormalizedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40067B3")]
	public Color ColorTint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40067B4")]
	private float _timeTolive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40067B5")]
	private float _timeSinceSpawn;

	[Cpp2IlInjected.Token(Token = "0x60037A3")]
	[Cpp2IlInjected.Address(RVA = "0x123D21C", Offset = "0x123D21C", VA = "0x123D21C", Slot = "13")]
	public override void FetchFromPool()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037A4")]
	[Cpp2IlInjected.Address(RVA = "0x123D2BC", Offset = "0x123D2BC", VA = "0x123D2BC")]
	public void SetTypeInfo(float timeToLive)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037A5")]
	[Cpp2IlInjected.Address(RVA = "0x123D2C4", Offset = "0x123D2C4", VA = "0x123D2C4", Slot = "11")]
	public override void Update(ref ParticleRendererSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037A6")]
	[Cpp2IlInjected.Address(RVA = "0x123D2FC", Offset = "0x123D2FC", VA = "0x123D2FC", Slot = "12")]
	public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037A7")]
	[Cpp2IlInjected.Address(RVA = "0x123D54C", Offset = "0x123D54C", VA = "0x123D54C")]
	public FadingParticle()
	{
	}
}
