using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Renderers;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006E1")]
public class UIParticleLayer : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400707E")]
	public ParticleRenderer ParticleSystem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400707F")]
	public Vector2 AnchorPositionOffsetByPercents;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4007080")]
	public Vector2 AnchorPositionOffsetByPixels;

	[Cpp2IlInjected.Token(Token = "0x60044FF")]
	[Cpp2IlInjected.Address(RVA = "0x148A288", Offset = "0x148A288", VA = "0x148A288")]
	public UIParticleLayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004500")]
	[Cpp2IlInjected.Address(RVA = "0x149545C", Offset = "0x149545C", VA = "0x149545C")]
	private void ParticleSystemUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004501")]
	[Cpp2IlInjected.Address(RVA = "0x1495468", Offset = "0x1495468", VA = "0x1495468", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004502")]
	[Cpp2IlInjected.Address(RVA = "0x1495604", Offset = "0x1495604", VA = "0x1495604", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004503")]
	[Cpp2IlInjected.Address(RVA = "0x148B3B4", Offset = "0x148B3B4", VA = "0x148B3B4")]
	public void AddParticle(IParticle particle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004504")]
	[Cpp2IlInjected.Address(RVA = "0x148B878", Offset = "0x148B878", VA = "0x148B878")]
	public void ClearParticles()
	{
	}
}
