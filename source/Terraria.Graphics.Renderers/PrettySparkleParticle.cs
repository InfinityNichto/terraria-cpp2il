using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x2000502")]
public class PrettySparkleParticle : ABasicParticle
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40067D1")]
	public float FadeInNormalizedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40067D2")]
	public float FadeOutNormalizedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40067D3")]
	public float TimeToLive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40067D4")]
	public Color ColorTint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40067D5")]
	public float Opacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40067D6")]
	public float AdditiveAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40067D7")]
	public float FadeInEnd;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40067D8")]
	public float FadeOutStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40067D9")]
	public float FadeOutEnd;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40067DA")]
	public bool DrawHorizontalAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8D")]
	[Cpp2IlInjected.Token(Token = "0x40067DB")]
	public bool DrawVerticalAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40067DC")]
	private float _timeSinceSpawn;

	[Cpp2IlInjected.Token(Token = "0x60037B8")]
	[Cpp2IlInjected.Address(RVA = "0x1244B98", Offset = "0x1244B98", VA = "0x1244B98", Slot = "13")]
	public override void FetchFromPool()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037B9")]
	[Cpp2IlInjected.Address(RVA = "0x1244C7C", Offset = "0x1244C7C", VA = "0x1244C7C", Slot = "11")]
	public override void Update(ref ParticleRendererSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037BA")]
	[Cpp2IlInjected.Address(RVA = "0x1244D8C", Offset = "0x1244D8C", VA = "0x1244D8C", Slot = "12")]
	public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037BB")]
	[Cpp2IlInjected.Address(RVA = "0x12453A8", Offset = "0x12453A8", VA = "0x12453A8")]
	public PrettySparkleParticle()
	{
	}
}
