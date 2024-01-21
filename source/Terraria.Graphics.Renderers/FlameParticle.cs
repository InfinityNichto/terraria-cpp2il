using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20004FF")]
public class FlameParticle : ABasicParticle
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40067B6")]
	public float FadeOutNormalizedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40067B7")]
	private float _timeTolive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40067B8")]
	private float _timeSinceSpawn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40067B9")]
	private int _indexOfPlayerWhoSpawnedThis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40067BA")]
	private int _packedShaderIndex;

	[Cpp2IlInjected.Token(Token = "0x60037A8")]
	[Cpp2IlInjected.Address(RVA = "0x123D5DC", Offset = "0x123D5DC", VA = "0x123D5DC", Slot = "13")]
	public override void FetchFromPool()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037A9")]
	[Cpp2IlInjected.Address(RVA = "0x123D604", Offset = "0x123D604", VA = "0x123D604", Slot = "10")]
	public override void SetBasicInfo(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037AA")]
	[Cpp2IlInjected.Address(RVA = "0x123D6B0", Offset = "0x123D6B0", VA = "0x123D6B0")]
	public void SetTypeInfo(float timeToLive, int indexOfPlayerWhoSpawnedIt, int packedShaderIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037AB")]
	[Cpp2IlInjected.Address(RVA = "0x123D6C0", Offset = "0x123D6C0", VA = "0x123D6C0", Slot = "11")]
	public override void Update(ref ParticleRendererSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037AC")]
	[Cpp2IlInjected.Address(RVA = "0x123D6F8", Offset = "0x123D6F8", VA = "0x123D6F8", Slot = "12")]
	public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037AD")]
	[Cpp2IlInjected.Address(RVA = "0x123DEC4", Offset = "0x123DEC4", VA = "0x123DEC4")]
	public FlameParticle()
	{
	}
}
