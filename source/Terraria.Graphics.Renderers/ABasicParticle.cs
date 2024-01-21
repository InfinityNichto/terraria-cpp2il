using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20004FD")]
public abstract class ABasicParticle : IPooledParticle, IParticle
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40067A4")]
	public Vector2 AccelerationPerFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40067A5")]
	public Vector2 Velocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40067A6")]
	public Vector2 LocalPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40067A7")]
	protected Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40067A8")]
	protected Rectangle _frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40067A9")]
	protected Vector2 _origin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40067AA")]
	public float Rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40067AB")]
	public float RotationVelocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40067AC")]
	public float RotationAcceleration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40067AD")]
	public Vector2 Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40067AE")]
	public Vector2 ScaleVelocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40067AF")]
	public Vector2 ScaleAcceleration;

	[Cpp2IlInjected.Token(Token = "0x170006F1")]
	public bool ShouldBeRemovedFromRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x6003799")]
		[Cpp2IlInjected.Address(RVA = "0x123C34C", Offset = "0x123C34C", VA = "0x123C34C", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600379A")]
		[Cpp2IlInjected.Address(RVA = "0x123C354", Offset = "0x123C354", VA = "0x123C354")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006F2")]
	public bool IsRestingInPool
	{
		[Cpp2IlInjected.Token(Token = "0x600379F")]
		[Cpp2IlInjected.Address(RVA = "0x123C8E0", Offset = "0x123C8E0", VA = "0x123C8E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60037A0")]
		[Cpp2IlInjected.Address(RVA = "0x123C8E8", Offset = "0x123C8E8", VA = "0x123C8E8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600379B")]
	[Cpp2IlInjected.Address(RVA = "0x123C35C", Offset = "0x123C35C", VA = "0x123C35C")]
	public ABasicParticle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600379C")]
	[Cpp2IlInjected.Address(RVA = "0x123C5C0", Offset = "0x123C5C0", VA = "0x123C5C0", Slot = "10")]
	public virtual void SetBasicInfo(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600379D")]
	[Cpp2IlInjected.Address(RVA = "0x123C790", Offset = "0x123C790", VA = "0x123C790", Slot = "11")]
	public virtual void Update(ref ParticleRendererSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600379E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch);

	[Cpp2IlInjected.Token(Token = "0x60037A1")]
	[Cpp2IlInjected.Address(RVA = "0x123C8F0", Offset = "0x123C8F0", VA = "0x123C8F0", Slot = "5")]
	public void RestInPool()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037A2")]
	[Cpp2IlInjected.Address(RVA = "0x123C8FC", Offset = "0x123C8FC", VA = "0x123C8FC", Slot = "13")]
	public virtual void FetchFromPool()
	{
	}
}
