using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006D4")]
public class UIHairStyleButton : UIImageButton
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4007046")]
	private readonly Player _player;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4007047")]
	public readonly int HairStyleId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4007048")]
	private readonly Asset<Texture2D> _selectedBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4007049")]
	private readonly Asset<Texture2D> _hoveredBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400704A")]
	private bool _hovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
	[Cpp2IlInjected.Token(Token = "0x400704B")]
	private bool _soundedHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x400704C")]
	private int _framesToSkip;

	[Cpp2IlInjected.Token(Token = "0x60044BA")]
	[Cpp2IlInjected.Address(RVA = "0x148FD00", Offset = "0x148FD00", VA = "0x148FD00")]
	public UIHairStyleButton(Player player, int hairStyleId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044BB")]
	[Cpp2IlInjected.Address(RVA = "0x1490048", Offset = "0x1490048", VA = "0x1490048")]
	public void SkipRenderingContent(int timeInFrames)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044BC")]
	[Cpp2IlInjected.Address(RVA = "0x1490050", Offset = "0x1490050", VA = "0x1490050", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044BD")]
	[Cpp2IlInjected.Address(RVA = "0x14906D0", Offset = "0x14906D0", VA = "0x14906D0", Slot = "15")]
	public override void LeftMouseDown(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044BE")]
	[Cpp2IlInjected.Address(RVA = "0x1490730", Offset = "0x1490730", VA = "0x1490730", Slot = "23")]
	public override void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044BF")]
	[Cpp2IlInjected.Address(RVA = "0x14907BC", Offset = "0x14907BC", VA = "0x14907BC", Slot = "24")]
	public override void MouseOut(UIMouseEvent evt)
	{
	}
}
