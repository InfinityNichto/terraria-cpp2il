using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006EA")]
public class UITextPanel<T> : UIPanel
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40070B5")]
	protected T _text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40070B6")]
	protected float _textScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40070B7")]
	protected Vector2 _textSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40070B8")]
	protected bool _isLarge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40070B9")]
	protected Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40070BA")]
	protected bool _drawPanel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40070BB")]
	public float TextHAlign;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40070BC")]
	public bool HideContents;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40070BD")]
	private string _asterisks;

	[Cpp2IlInjected.Token(Token = "0x170007D7")]
	public bool IsLarge
	{
		[Cpp2IlInjected.Token(Token = "0x6004559")]
		[Cpp2IlInjected.Address(RVA = "0x1642CF8", Offset = "0x1642CF8", VA = "0x1642CF8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007D8")]
	public bool DrawPanel
	{
		[Cpp2IlInjected.Token(Token = "0x600455A")]
		[Cpp2IlInjected.Address(RVA = "0x1642D00", Offset = "0x1642D00", VA = "0x1642D00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600455B")]
		[Cpp2IlInjected.Address(RVA = "0x1642D08", Offset = "0x1642D08", VA = "0x1642D08")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007D9")]
	public float TextScale
	{
		[Cpp2IlInjected.Token(Token = "0x600455C")]
		[Cpp2IlInjected.Address(RVA = "0x1642D10", Offset = "0x1642D10", VA = "0x1642D10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600455D")]
		[Cpp2IlInjected.Address(RVA = "0x1642D18", Offset = "0x1642D18", VA = "0x1642D18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007DA")]
	public Vector2 TextSize
	{
		[Cpp2IlInjected.Token(Token = "0x600455E")]
		[Cpp2IlInjected.Address(RVA = "0x1642D20", Offset = "0x1642D20", VA = "0x1642D20")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007DB")]
	public string Text
	{
		[Cpp2IlInjected.Token(Token = "0x600455F")]
		[Cpp2IlInjected.Address(RVA = "0x1642D34", Offset = "0x1642D34", VA = "0x1642D34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007DC")]
	public Color TextColor
	{
		[Cpp2IlInjected.Token(Token = "0x6004560")]
		[Cpp2IlInjected.Address(RVA = "0x1642DA8", Offset = "0x1642DA8", VA = "0x1642DA8")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6004561")]
		[Cpp2IlInjected.Address(RVA = "0x1642DB0", Offset = "0x1642DB0", VA = "0x1642DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004562")]
	[Cpp2IlInjected.Address(RVA = "0x1642DB8", Offset = "0x1642DB8", VA = "0x1642DB8")]
	public UITextPanel(T text, float textScale = 1f, bool large = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004563")]
	[Cpp2IlInjected.Address(RVA = "0x1642F2C", Offset = "0x1642F2C", VA = "0x1642F2C", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004564")]
	[Cpp2IlInjected.Address(RVA = "0x1642F74", Offset = "0x1642F74", VA = "0x1642F74")]
	public void SetText(T text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004565")]
	[Cpp2IlInjected.Address(RVA = "0x1642FA4", Offset = "0x1642FA4", VA = "0x1642FA4", Slot = "30")]
	public virtual void SetText(T text, float textScale, bool large)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004566")]
	[Cpp2IlInjected.Address(RVA = "0x1643188", Offset = "0x1643188", VA = "0x1643188", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004567")]
	[Cpp2IlInjected.Address(RVA = "0x16431D8", Offset = "0x16431D8", VA = "0x16431D8")]
	protected void DrawText(SpriteBatch spriteBatch)
	{
	}
}
