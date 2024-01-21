using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006D2")]
public class UIDifficultyButton : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4007035")]
	private readonly Player _player;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007036")]
	private readonly Asset<Texture2D> _BasePanelTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007037")]
	private readonly Asset<Texture2D> _selectedBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4007038")]
	private readonly Asset<Texture2D> _hoveredBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4007039")]
	private readonly byte _difficulty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x101")]
	[Cpp2IlInjected.Token(Token = "0x400703A")]
	private readonly Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x105")]
	[Cpp2IlInjected.Token(Token = "0x400703B")]
	private bool _hovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x106")]
	[Cpp2IlInjected.Token(Token = "0x400703C")]
	private bool _soundedHover;

	[Cpp2IlInjected.Token(Token = "0x60044AF")]
	[Cpp2IlInjected.Address(RVA = "0x148D1C8", Offset = "0x148D1C8", VA = "0x148D1C8")]
	public UIDifficultyButton(Player player, LocalizedText title, LocalizedText description, byte difficulty, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044B0")]
	[Cpp2IlInjected.Address(RVA = "0x148D5E0", Offset = "0x148D5E0", VA = "0x148D5E0", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044B1")]
	[Cpp2IlInjected.Address(RVA = "0x148D968", Offset = "0x148D968", VA = "0x148D968", Slot = "15")]
	public override void LeftMouseDown(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044B2")]
	[Cpp2IlInjected.Address(RVA = "0x148D9C8", Offset = "0x148D9C8", VA = "0x148D9C8", Slot = "23")]
	public override void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044B3")]
	[Cpp2IlInjected.Address(RVA = "0x148D9E8", Offset = "0x148D9E8", VA = "0x148D9E8", Slot = "24")]
	public override void MouseOut(UIMouseEvent evt)
	{
	}
}
