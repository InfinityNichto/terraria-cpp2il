using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects;

[Cpp2IlInjected.Token(Token = "0x2000522")]
public abstract class Overlay : GameEffect
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006867")]
	public OverlayMode Mode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006868")]
	private RenderLayers _layer;

	[Cpp2IlInjected.Token(Token = "0x1700070E")]
	public RenderLayers Layer
	{
		[Cpp2IlInjected.Token(Token = "0x60038AA")]
		[Cpp2IlInjected.Address(RVA = "0x150913C", Offset = "0x150913C", VA = "0x150913C")]
		get
		{
			return default(RenderLayers);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60038AB")]
	[Cpp2IlInjected.Address(RVA = "0x1509144", Offset = "0x1509144", VA = "0x1509144")]
	public Overlay(EffectPriority priority, RenderLayers layer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void Draw(SpriteBatch spriteBatch);

	[Cpp2IlInjected.Token(Token = "0x60038AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void Update(GameTime gameTime);
}
