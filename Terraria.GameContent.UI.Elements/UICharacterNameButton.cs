using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006C9")]
public class UICharacterNameButton : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006FE3")]
	private readonly Asset<Texture2D> _BasePanelTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006FE4")]
	private readonly Asset<Texture2D> _selectedBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006FE5")]
	private readonly Asset<Texture2D> _hoveredBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006FE6")]
	private bool _hovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x4006FE7")]
	private bool _soundedHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4006FE8")]
	private readonly LocalizedText _textToShowWhenEmpty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4006FE9")]
	private string actualContents;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4006FEA")]
	private UIText _text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006FEB")]
	private UIText _title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006FEC")]
	public readonly LocalizedText Description;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4006FED")]
	public float DistanceFromTitleToOption;

	[Cpp2IlInjected.Token(Token = "0x6004455")]
	[Cpp2IlInjected.Address(RVA = "0x1483D94", Offset = "0x1483D94", VA = "0x1483D94")]
	public UICharacterNameButton(LocalizedText titleText, LocalizedText emptyContentText, [Optional] LocalizedText description)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004456")]
	[Cpp2IlInjected.Address(RVA = "0x1484540", Offset = "0x1484540", VA = "0x1484540", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004457")]
	[Cpp2IlInjected.Address(RVA = "0x14843E4", Offset = "0x14843E4", VA = "0x14843E4")]
	public void SetContents(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004458")]
	[Cpp2IlInjected.Address(RVA = "0x14847EC", Offset = "0x14847EC", VA = "0x14847EC")]
	public void TrimDisplayIfOverElementDimensions(int padding)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004459")]
	[Cpp2IlInjected.Address(RVA = "0x1484B68", Offset = "0x1484B68", VA = "0x1484B68", Slot = "15")]
	public override void LeftMouseDown(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600445A")]
	[Cpp2IlInjected.Address(RVA = "0x1484B70", Offset = "0x1484B70", VA = "0x1484B70", Slot = "23")]
	public override void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600445B")]
	[Cpp2IlInjected.Address(RVA = "0x1484B90", Offset = "0x1484B90", VA = "0x1484B90", Slot = "24")]
	public override void MouseOut(UIMouseEvent evt)
	{
	}
}
