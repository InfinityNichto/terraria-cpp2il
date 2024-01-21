using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x2000500")]
public class RandomizedFrameParticle : ABasicParticle
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40067BB")]
	public float FadeInNormalizedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40067BC")]
	public float FadeOutNormalizedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40067BD")]
	public Color ColorTint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40067BE")]
	public int AnimationFramesAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40067BF")]
	public int GameFramesPerAnimationFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40067C0")]
	private float _timeTolive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40067C1")]
	private float _timeSinceSpawn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40067C2")]
	private int _gameFramesCounted;

	[Cpp2IlInjected.Token(Token = "0x60037AE")]
	[Cpp2IlInjected.Address(RVA = "0x12453F8", Offset = "0x12453F8", VA = "0x12453F8", Slot = "13")]
	public override void FetchFromPool()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037AF")]
	[Cpp2IlInjected.Address(RVA = "0x12454A0", Offset = "0x12454A0", VA = "0x12454A0")]
	public void SetTypeInfo(int animationFramesAmount, int gameFramesPerAnimationFrame, float timeToLive)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037B0")]
	[Cpp2IlInjected.Address(RVA = "0x12454AC", Offset = "0x12454AC", VA = "0x12454AC")]
	private void RandomizeFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037B1")]
	[Cpp2IlInjected.Address(RVA = "0x1245618", Offset = "0x1245618", VA = "0x1245618", Slot = "11")]
	public override void Update(ref ParticleRendererSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037B2")]
	[Cpp2IlInjected.Address(RVA = "0x1245678", Offset = "0x1245678", VA = "0x1245678", Slot = "12")]
	public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037B3")]
	[Cpp2IlInjected.Address(RVA = "0x12458C8", Offset = "0x12458C8", VA = "0x12458C8")]
	public RandomizedFrameParticle()
	{
	}
}
