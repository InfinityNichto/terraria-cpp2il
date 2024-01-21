using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006ED")]
public class UIVerticalSlider : UISliderBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40070C8")]
	public float FillPercent;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40070C9")]
	public Color FilledColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40070CA")]
	public Color EmptyColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40070CB")]
	private Func<float> _getSliderValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40070CC")]
	private Action<float> _slideKeyboardAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40070CD")]
	private Func<float, Color> _blipFunc;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40070CE")]
	private Action _slideGamepadAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40070CF")]
	private bool _isReallyMouseOvered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10D")]
	[Cpp2IlInjected.Token(Token = "0x40070D0")]
	private bool _soundedUsage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10E")]
	[Cpp2IlInjected.Token(Token = "0x40070D1")]
	private bool _alreadyHovered;

	[Cpp2IlInjected.Token(Token = "0x6004571")]
	[Cpp2IlInjected.Address(RVA = "0x10911E8", Offset = "0x10911E8", VA = "0x10911E8")]
	public UIVerticalSlider(Func<float> getStatus, Action<float> setStatusKeyboard, Action setStatusGamepad, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004572")]
	[Cpp2IlInjected.Address(RVA = "0x109147C", Offset = "0x109147C", VA = "0x109147C", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004573")]
	[Cpp2IlInjected.Address(RVA = "0x10917D8", Offset = "0x10917D8", VA = "0x10917D8")]
	private bool DrawValueBarDynamicWidth(SpriteBatch spriteBatch, out float sliderValueThatWasSet)
	{
		return default(bool);
	}
}
