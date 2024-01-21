using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006CC")]
public class UIColoredSlider : UISliderBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x4006FFD")]
	private Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006FFE")]
	private LocalizedText _textKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006FFF")]
	private Func<float> _getStatusTextAct;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4007000")]
	private Action<float> _slideKeyboardAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4007001")]
	private Func<float, Color> _blipFunc;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4007002")]
	private Action _slideGamepadAction;

	[Cpp2IlInjected.Token(Token = "0x4007003")]
	private const bool BOTHER_WITH_TEXT = false;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4007004")]
	private bool _isReallyMouseOvered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x109")]
	[Cpp2IlInjected.Token(Token = "0x4007005")]
	private bool _alreadyHovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10A")]
	[Cpp2IlInjected.Token(Token = "0x4007006")]
	private bool _soundedUsage;

	[Cpp2IlInjected.Token(Token = "0x600446A")]
	[Cpp2IlInjected.Address(RVA = "0x14859A4", Offset = "0x14859A4", VA = "0x14859A4")]
	public UIColoredSlider(LocalizedText textKey, Func<float> getStatus, Action<float> setStatusKeyboard, Action setStatusGamepad, Func<float, Color> blipColorFunction, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600446B")]
	[Cpp2IlInjected.Address(RVA = "0x1485D10", Offset = "0x1485D10", VA = "0x1485D10", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600446C")]
	[Cpp2IlInjected.Address(RVA = "0x1486460", Offset = "0x1486460", VA = "0x1486460")]
	private float DrawValueBar(SpriteBatch sb, Vector2 drawPosition, float drawScale, float sliderPosition, int lockMode, out bool wasInBar, Func<float, Color> blipColorFunc)
	{
		return default(float);
	}
}
