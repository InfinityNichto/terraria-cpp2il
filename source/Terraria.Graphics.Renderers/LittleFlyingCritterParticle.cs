using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20004FA")]
public class LittleFlyingCritterParticle : IPooledParticle, IParticle
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006788")]
	private int _lifeTimeCounted;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006789")]
	private int _lifeTimeTotal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400678C")]
	private Vector2 _spawnPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400678D")]
	private Vector2 _localPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400678E")]
	private Vector2 _velocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400678F")]
	private float _neverGoBelowThis;

	[Cpp2IlInjected.Token(Token = "0x170006EC")]
	public bool IsRestingInPool
	{
		[Cpp2IlInjected.Token(Token = "0x600377F")]
		[Cpp2IlInjected.Address(RVA = "0x1242814", Offset = "0x1242814", VA = "0x1242814", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003780")]
		[Cpp2IlInjected.Address(RVA = "0x124281C", Offset = "0x124281C", VA = "0x124281C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006ED")]
	public bool ShouldBeRemovedFromRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x6003781")]
		[Cpp2IlInjected.Address(RVA = "0x1242824", Offset = "0x1242824", VA = "0x1242824", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003782")]
		[Cpp2IlInjected.Address(RVA = "0x124282C", Offset = "0x124282C", VA = "0x124282C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003783")]
	[Cpp2IlInjected.Address(RVA = "0x1242834", Offset = "0x1242834", VA = "0x1242834")]
	public LittleFlyingCritterParticle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003784")]
	[Cpp2IlInjected.Address(RVA = "0x124283C", Offset = "0x124283C", VA = "0x124283C")]
	public void Prepare(Vector2 position, int duration)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003785")]
	[Cpp2IlInjected.Address(RVA = "0x12429BC", Offset = "0x12429BC", VA = "0x12429BC")]
	private void RandomizeVelocity()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003786")]
	[Cpp2IlInjected.Address(RVA = "0x1242A9C", Offset = "0x1242A9C", VA = "0x1242A9C", Slot = "5")]
	public void RestInPool()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003787")]
	[Cpp2IlInjected.Address(RVA = "0x1242AA8", Offset = "0x1242AA8", VA = "0x1242AA8", Slot = "10")]
	public virtual void FetchFromPool()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003788")]
	[Cpp2IlInjected.Address(RVA = "0x1242AB4", Offset = "0x1242AB4", VA = "0x1242AB4", Slot = "8")]
	public void Update(ref ParticleRendererSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003789")]
	[Cpp2IlInjected.Address(RVA = "0x1242DC8", Offset = "0x1242DC8", VA = "0x1242DC8", Slot = "9")]
	public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
	{
	}
}
