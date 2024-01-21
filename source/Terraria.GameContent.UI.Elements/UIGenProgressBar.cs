using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006D3")]
public class UIGenProgressBar : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400703D")]
	private Asset<Texture2D> _texOuterCrimson;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400703E")]
	private Asset<Texture2D> _texOuterCorrupt;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400703F")]
	private Asset<Texture2D> _texOuterLower;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4007040")]
	private float _visualOverallProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4007041")]
	private float _targetOverallProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4007042")]
	private float _visualCurrentProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4007043")]
	private float _targetCurrentProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4007044")]
	private int _smallBarWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4007045")]
	private int _longBarWidth;

	[Cpp2IlInjected.Token(Token = "0x60044B4")]
	[Cpp2IlInjected.Address(RVA = "0x148E9B8", Offset = "0x148E9B8", VA = "0x148E9B8")]
	public UIGenProgressBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044B5")]
	[Cpp2IlInjected.Address(RVA = "0x148ED20", Offset = "0x148ED20", VA = "0x148ED20", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044B6")]
	[Cpp2IlInjected.Address(RVA = "0x148ED48", Offset = "0x148ED48", VA = "0x148ED48")]
	public void SetProgress(float overallProgress, float currentProgress)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044B7")]
	[Cpp2IlInjected.Address(RVA = "0x148ED54", Offset = "0x148ED54", VA = "0x148ED54", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044B8")]
	[Cpp2IlInjected.Address(RVA = "0x148F6D0", Offset = "0x148F6D0", VA = "0x148F6D0")]
	private void DrawFilling(SpriteBatch spritebatch, Texture2D tex, Texture2D texShadow, Vector2 topLeft, int completedWidth, int totalWidth, Color separator, Color empty)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044B9")]
	[Cpp2IlInjected.Address(RVA = "0x148F2FC", Offset = "0x148F2FC", VA = "0x148F2FC")]
	private void DrawFilling2(SpriteBatch spritebatch, Vector2 topLeft, int height, int completedWidth, int totalWidth, Color filled, Color separator, Color empty)
	{
	}
}
