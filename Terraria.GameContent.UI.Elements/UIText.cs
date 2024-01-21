using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006E8")]
public class UIText : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40070A2")]
	private object _text;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40070A3")]
	private float _textScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40070A4")]
	private Vector2 _textSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40070A5")]
	private bool _isLarge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x101")]
	[Cpp2IlInjected.Token(Token = "0x40070A6")]
	private Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x105")]
	[Cpp2IlInjected.Token(Token = "0x40070A7")]
	private Color _shadowColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x109")]
	[Cpp2IlInjected.Token(Token = "0x40070A8")]
	private bool _isWrapped;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40070AC")]
	public bool DynamicallyScaleDownToWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40070AD")]
	private string _visibleText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40070AE")]
	private string _lastTextReference;

	[Cpp2IlInjected.Token(Token = "0x170007D0")]
	public string Text
	{
		[Cpp2IlInjected.Token(Token = "0x6004538")]
		[Cpp2IlInjected.Address(RVA = "0x1484B54", Offset = "0x1484B54", VA = "0x1484B54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007D1")]
	public float TextOriginX
	{
		[Cpp2IlInjected.Token(Token = "0x6004539")]
		[Cpp2IlInjected.Address(RVA = "0x1497020", Offset = "0x1497020", VA = "0x1497020")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600453A")]
		[Cpp2IlInjected.Address(RVA = "0x1497028", Offset = "0x1497028", VA = "0x1497028")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007D2")]
	public float TextOriginY
	{
		[Cpp2IlInjected.Token(Token = "0x600453B")]
		[Cpp2IlInjected.Address(RVA = "0x1497030", Offset = "0x1497030", VA = "0x1497030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600453C")]
		[Cpp2IlInjected.Address(RVA = "0x1497038", Offset = "0x1497038", VA = "0x1497038")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007D3")]
	public float WrappedTextBottomPadding
	{
		[Cpp2IlInjected.Token(Token = "0x600453D")]
		[Cpp2IlInjected.Address(RVA = "0x1497040", Offset = "0x1497040", VA = "0x1497040")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600453E")]
		[Cpp2IlInjected.Address(RVA = "0x1497048", Offset = "0x1497048", VA = "0x1497048")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007D4")]
	public bool IsWrapped
	{
		[Cpp2IlInjected.Token(Token = "0x600453F")]
		[Cpp2IlInjected.Address(RVA = "0x1497050", Offset = "0x1497050", VA = "0x1497050")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6004540")]
		[Cpp2IlInjected.Address(RVA = "0x1497058", Offset = "0x1497058", VA = "0x1497058")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007D5")]
	public Color TextColor
	{
		[Cpp2IlInjected.Token(Token = "0x6004543")]
		[Cpp2IlInjected.Address(RVA = "0x1497434", Offset = "0x1497434", VA = "0x1497434")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6004544")]
		[Cpp2IlInjected.Address(RVA = "0x149743C", Offset = "0x149743C", VA = "0x149743C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007D6")]
	public Color ShadowColor
	{
		[Cpp2IlInjected.Token(Token = "0x6004545")]
		[Cpp2IlInjected.Address(RVA = "0x1497444", Offset = "0x1497444", VA = "0x1497444")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6004546")]
		[Cpp2IlInjected.Address(RVA = "0x149744C", Offset = "0x149744C", VA = "0x149744C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400005F")]
	public event Action OnInternalTextChange
	{
		[Cpp2IlInjected.Token(Token = "0x6004541")]
		[Cpp2IlInjected.Address(RVA = "0x14972D4", Offset = "0x14972D4", VA = "0x14972D4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6004542")]
		[Cpp2IlInjected.Address(RVA = "0x1497384", Offset = "0x1497384", VA = "0x1497384")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004547")]
	[Cpp2IlInjected.Address(RVA = "0x148A378", Offset = "0x148A378", VA = "0x148A378")]
	public UIText(string text, float textScale = 1f, bool large = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004548")]
	[Cpp2IlInjected.Address(RVA = "0x1484210", Offset = "0x1484210", VA = "0x1484210")]
	public UIText(LocalizedText text, float textScale = 1f, bool large = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004549")]
	[Cpp2IlInjected.Address(RVA = "0x1497454", Offset = "0x1497454", VA = "0x1497454", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600454A")]
	[Cpp2IlInjected.Address(RVA = "0x14847CC", Offset = "0x14847CC", VA = "0x14847CC")]
	public void SetText(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600454B")]
	[Cpp2IlInjected.Address(RVA = "0x14847AC", Offset = "0x14847AC", VA = "0x14847AC")]
	public void SetText(LocalizedText text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600454C")]
	[Cpp2IlInjected.Address(RVA = "0x1497488", Offset = "0x1497488", VA = "0x1497488")]
	public void SetText(string text, float textScale, bool large)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600454D")]
	[Cpp2IlInjected.Address(RVA = "0x14974A0", Offset = "0x14974A0", VA = "0x14974A0")]
	public void SetText(LocalizedText text, float textScale, bool large)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600454E")]
	[Cpp2IlInjected.Address(RVA = "0x14974B8", Offset = "0x14974B8", VA = "0x14974B8", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600454F")]
	[Cpp2IlInjected.Address(RVA = "0x14978B4", Offset = "0x14978B4", VA = "0x14978B4")]
	private void VerifyTextState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004550")]
	[Cpp2IlInjected.Address(RVA = "0x1497084", Offset = "0x1497084", VA = "0x1497084")]
	private void InternalSetText(object text, float textScale, bool large)
	{
	}
}
