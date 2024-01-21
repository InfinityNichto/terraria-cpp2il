using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x2000501")]
public class GasParticle : ABasicParticle
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40067C3")]
	public float FadeInNormalizedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40067C4")]
	public float FadeOutNormalizedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40067C5")]
	public float TimeToLive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40067C6")]
	public Color ColorTint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40067C7")]
	public float Opacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40067C8")]
	public float AdditiveAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40067C9")]
	public float FadeInEnd;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40067CA")]
	public float FadeOutStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40067CB")]
	public float FadeOutEnd;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40067CC")]
	public float SlowdownScalar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40067CD")]
	private float _timeSinceSpawn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40067CE")]
	public Color LightColorTint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40067CF")]
	private int _internalIndentifier;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40067D0")]
	public float InitialScale;

	[Cpp2IlInjected.Token(Token = "0x60037B4")]
	[Cpp2IlInjected.Address(RVA = "0x123DED0", Offset = "0x123DED0", VA = "0x123DED0", Slot = "13")]
	public override void FetchFromPool()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037B5")]
	[Cpp2IlInjected.Address(RVA = "0x123DFE8", Offset = "0x123DFE8", VA = "0x123DFE8", Slot = "11")]
	public override void Update(ref ParticleRendererSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037B6")]
	[Cpp2IlInjected.Address(RVA = "0x123E39C", Offset = "0x123E39C", VA = "0x123E39C", Slot = "12")]
	public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037B7")]
	[Cpp2IlInjected.Address(RVA = "0x123E808", Offset = "0x123E808", VA = "0x123E808")]
	public GasParticle()
	{
	}
}
