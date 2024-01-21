using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006BA")]
public class GroupOptionButton<T> : UIElement, IGroupOptionButton
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F90")]
	private T _currentOption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F91")]
	private readonly Asset<Texture2D> _BasePanelTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F92")]
	private readonly Asset<Texture2D> _selectedBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F93")]
	private readonly Asset<Texture2D> _hoveredBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F94")]
	private readonly Asset<Texture2D> _iconTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F95")]
	private readonly T _myOption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F96")]
	private Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F97")]
	private Color _borderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F98")]
	public float FadeFromBlack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F99")]
	private float _whiteLerp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F9A")]
	private float _opacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F9B")]
	private bool _hovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F9C")]
	private bool _soundedHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F9D")]
	public bool ShowHighlightWhenSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F9E")]
	private bool _UseOverrideColors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006F9F")]
	private Color _overrideUnpickedColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006FA0")]
	private Color _overridePickedColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006FA1")]
	private float _overrideOpacityPicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006FA2")]
	private float _overrideOpacityUnpicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006FA3")]
	public readonly LocalizedText Description;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006FA4")]
	private UIText _title;

	[Cpp2IlInjected.Token(Token = "0x170007BA")]
	public T OptionValue
	{
		[Cpp2IlInjected.Token(Token = "0x60043E2")]
		[Cpp2IlInjected.Address(RVA = "0x163F404", Offset = "0x163F404", VA = "0x163F404")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007BB")]
	public bool IsSelected
	{
		[Cpp2IlInjected.Token(Token = "0x60043E3")]
		[Cpp2IlInjected.Address(RVA = "0x163F40C", Offset = "0x163F40C", VA = "0x163F40C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60043E4")]
	[Cpp2IlInjected.Address(RVA = "0x163F468", Offset = "0x163F468", VA = "0x163F468")]
	public GroupOptionButton(T option, LocalizedText title, LocalizedText description, Color textColor, string iconTexturePath, float textSize = 1f, float titleAlignmentX = 0.5f, float titleWidthReduction = 10f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043E5")]
	[Cpp2IlInjected.Address(RVA = "0x163FAA4", Offset = "0x163FAA4", VA = "0x163FAA4")]
	public void SetText(LocalizedText text, float textSize, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043E6")]
	[Cpp2IlInjected.Address(RVA = "0x163FBDC", Offset = "0x163FBDC", VA = "0x163FBDC")]
	public void SetCurrentOption(T option)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043E7")]
	[Cpp2IlInjected.Address(RVA = "0x163FBE4", Offset = "0x163FBE4", VA = "0x163FBE4", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043E8")]
	[Cpp2IlInjected.Address(RVA = "0x16400A8", Offset = "0x16400A8", VA = "0x16400A8", Slot = "15")]
	public override void LeftMouseDown(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043E9")]
	[Cpp2IlInjected.Address(RVA = "0x16400FC", Offset = "0x16400FC", VA = "0x16400FC", Slot = "23")]
	public override void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043EA")]
	[Cpp2IlInjected.Address(RVA = "0x164011C", Offset = "0x164011C", VA = "0x164011C", Slot = "24")]
	public override void MouseOut(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043EB")]
	[Cpp2IlInjected.Address(RVA = "0x164013C", Offset = "0x164013C", VA = "0x164013C")]
	public void SetColor(Color color, float opacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043EC")]
	[Cpp2IlInjected.Address(RVA = "0x1640148", Offset = "0x1640148", VA = "0x1640148", Slot = "30")]
	public void SetColorsBasedOnSelectionState(Color pickedColor, Color unpickedColor, float opacityPicked, float opacityNotPicked)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043ED")]
	[Cpp2IlInjected.Address(RVA = "0x1640168", Offset = "0x1640168", VA = "0x1640168", Slot = "31")]
	public void SetBorderColor(Color color)
	{
	}
}
