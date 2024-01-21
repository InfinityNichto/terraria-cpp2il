using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects;

[Cpp2IlInjected.Token(Token = "0x2000523")]
public class OverlayManager : EffectManager<Overlay>
{
	[Cpp2IlInjected.Token(Token = "0x4006869")]
	private const float OPACITY_RATE = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400686A")]
	private LinkedList<Overlay>[] _activeOverlays;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400686B")]
	private int _overlayCount;

	[Cpp2IlInjected.Token(Token = "0x60038AE")]
	[Cpp2IlInjected.Address(RVA = "0x1509180", Offset = "0x1509180", VA = "0x1509180")]
	public OverlayManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038AF")]
	[Cpp2IlInjected.Address(RVA = "0x1509304", Offset = "0x1509304", VA = "0x1509304", Slot = "4")]
	public override void OnActivate(Overlay overlay, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038B0")]
	[Cpp2IlInjected.Address(RVA = "0x15094A0", Offset = "0x15094A0", VA = "0x15094A0")]
	public void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038B1")]
	[Cpp2IlInjected.Address(RVA = "0x15096EC", Offset = "0x15096EC", VA = "0x15096EC")]
	public void Draw(SpriteBatch spriteBatch, RenderLayers layer)
	{
	}
}
