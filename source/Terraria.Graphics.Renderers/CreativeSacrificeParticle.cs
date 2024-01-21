using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20004FC")]
public class CreativeSacrificeParticle : IParticle
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400679A")]
	public Vector2 AccelerationPerFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400679B")]
	public Vector2 Velocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400679C")]
	public Vector2 LocalPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400679D")]
	public float ScaleOffsetPerFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400679E")]
	public float StopWhenBelowXScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400679F")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40067A0")]
	private Rectangle _frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40067A1")]
	private Vector2 _origin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40067A2")]
	private float _scale;

	[Cpp2IlInjected.Token(Token = "0x170006F0")]
	public bool ShouldBeRemovedFromRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x6003794")]
		[Cpp2IlInjected.Address(RVA = "0x123CD00", Offset = "0x123CD00", VA = "0x123CD00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003795")]
		[Cpp2IlInjected.Address(RVA = "0x123CD08", Offset = "0x123CD08", VA = "0x123CD08")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003796")]
	[Cpp2IlInjected.Address(RVA = "0x123CD10", Offset = "0x123CD10", VA = "0x123CD10")]
	public CreativeSacrificeParticle(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003797")]
	[Cpp2IlInjected.Address(RVA = "0x123CEF4", Offset = "0x123CEF4", VA = "0x123CEF4", Slot = "5")]
	public void Update(ref ParticleRendererSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003798")]
	[Cpp2IlInjected.Address(RVA = "0x123CFFC", Offset = "0x123CFFC", VA = "0x123CFFC", Slot = "6")]
	public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
	{
	}
}
