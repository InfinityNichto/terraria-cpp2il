using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics;

[Cpp2IlInjected.Token(Token = "0x20004E1")]
public class SpriteViewMatrix
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006716")]
	private Vector2 _zoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006717")]
	private Vector2 _translation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006718")]
	private Matrix _zoomMatrix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4006719")]
	private Matrix _transformationMatrix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400671A")]
	private Matrix _normalizedTransformationMatrix;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400671B")]
	private SpriteEffects _effects;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x400671C")]
	private Matrix _effectMatrix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400671D")]
	private GraphicsDevice _graphicsDevice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400671E")]
	private Viewport _viewport;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400671F")]
	private bool _overrideSystemViewport;

	[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
	[Cpp2IlInjected.Token(Token = "0x4006720")]
	private bool _needsRebuild;

	[Cpp2IlInjected.Token(Token = "0x170006DC")]
	public Vector2 Zoom
	{
		[Cpp2IlInjected.Token(Token = "0x60036D3")]
		[Cpp2IlInjected.Address(RVA = "0x124BA3C", Offset = "0x124BA3C", VA = "0x124BA3C")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60036D4")]
		[Cpp2IlInjected.Address(RVA = "0x124BA50", Offset = "0x124BA50", VA = "0x124BA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006DD")]
	public Vector2 Translation
	{
		[Cpp2IlInjected.Token(Token = "0x60036D5")]
		[Cpp2IlInjected.Address(RVA = "0x124BB08", Offset = "0x124BB08", VA = "0x124BB08")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006DE")]
	public Matrix ZoomMatrix
	{
		[Cpp2IlInjected.Token(Token = "0x60036D6")]
		[Cpp2IlInjected.Address(RVA = "0x12469A8", Offset = "0x12469A8", VA = "0x12469A8")]
		get
		{
			return default(Matrix);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006DF")]
	public Matrix TransformationMatrix
	{
		[Cpp2IlInjected.Token(Token = "0x60036D7")]
		[Cpp2IlInjected.Address(RVA = "0x1241D38", Offset = "0x1241D38", VA = "0x1241D38")]
		get
		{
			return default(Matrix);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006E0")]
	public Matrix NormalizedTransformationmatrix
	{
		[Cpp2IlInjected.Token(Token = "0x60036D8")]
		[Cpp2IlInjected.Address(RVA = "0x124CE88", Offset = "0x124CE88", VA = "0x124CE88")]
		get
		{
			return default(Matrix);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006E1")]
	public SpriteEffects Effects
	{
		[Cpp2IlInjected.Token(Token = "0x60036D9")]
		[Cpp2IlInjected.Address(RVA = "0x124CECC", Offset = "0x124CECC", VA = "0x124CECC")]
		get
		{
			return default(SpriteEffects);
		}
		[Cpp2IlInjected.Token(Token = "0x60036DA")]
		[Cpp2IlInjected.Address(RVA = "0x124CED4", Offset = "0x124CED4", VA = "0x124CED4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006E2")]
	public Matrix EffectMatrix
	{
		[Cpp2IlInjected.Token(Token = "0x60036DB")]
		[Cpp2IlInjected.Address(RVA = "0x124CEEC", Offset = "0x124CEEC", VA = "0x124CEEC")]
		get
		{
			return default(Matrix);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60036DC")]
	[Cpp2IlInjected.Address(RVA = "0x124CF30", Offset = "0x124CF30", VA = "0x124CF30")]
	public SpriteViewMatrix(GraphicsDevice graphicsDevice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036DD")]
	[Cpp2IlInjected.Address(RVA = "0x124BBB8", Offset = "0x124BBB8", VA = "0x124BBB8")]
	private void Rebuild()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036DE")]
	[Cpp2IlInjected.Address(RVA = "0x124D288", Offset = "0x124D288", VA = "0x124D288")]
	public void SetViewportOverride(Viewport viewport)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036DF")]
	[Cpp2IlInjected.Address(RVA = "0x124D2AC", Offset = "0x124D2AC", VA = "0x124D2AC")]
	public void ClearViewportOverride()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036E0")]
	[Cpp2IlInjected.Address(RVA = "0x124BB3C", Offset = "0x124BB3C", VA = "0x124BB3C")]
	private bool ShouldRebuild()
	{
		return default(bool);
	}
}
