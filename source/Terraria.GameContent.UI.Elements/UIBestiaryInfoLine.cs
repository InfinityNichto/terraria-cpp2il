using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006C7")]
public class UIBestiaryInfoLine<T> : UIElement, IManuallyOrderedUIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006FDD")]
	private T _text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006FDE")]
	private float _textScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006FDF")]
	private Vector2 _textSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006FE0")]
	private Color _color;

	[Cpp2IlInjected.Token(Token = "0x170007BF")]
	public int OrderInUIList
	{
		[Cpp2IlInjected.Token(Token = "0x6004444")]
		[Cpp2IlInjected.Address(RVA = "0x1641C14", Offset = "0x1641C14", VA = "0x1641C14", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6004445")]
		[Cpp2IlInjected.Address(RVA = "0x1641C1C", Offset = "0x1641C1C", VA = "0x1641C1C", Slot = "31")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007C0")]
	public float TextScale
	{
		[Cpp2IlInjected.Token(Token = "0x6004446")]
		[Cpp2IlInjected.Address(RVA = "0x1641C24", Offset = "0x1641C24", VA = "0x1641C24")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6004447")]
		[Cpp2IlInjected.Address(RVA = "0x1641C2C", Offset = "0x1641C2C", VA = "0x1641C2C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007C1")]
	public Vector2 TextSize
	{
		[Cpp2IlInjected.Token(Token = "0x6004448")]
		[Cpp2IlInjected.Address(RVA = "0x1641C34", Offset = "0x1641C34", VA = "0x1641C34")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007C2")]
	public string Text
	{
		[Cpp2IlInjected.Token(Token = "0x6004449")]
		[Cpp2IlInjected.Address(RVA = "0x1641C48", Offset = "0x1641C48", VA = "0x1641C48")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007C3")]
	public Color TextColor
	{
		[Cpp2IlInjected.Token(Token = "0x600444A")]
		[Cpp2IlInjected.Address(RVA = "0x1641CBC", Offset = "0x1641CBC", VA = "0x1641CBC")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600444B")]
		[Cpp2IlInjected.Address(RVA = "0x1641CC4", Offset = "0x1641CC4", VA = "0x1641CC4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600444C")]
	[Cpp2IlInjected.Address(RVA = "0x1641CCC", Offset = "0x1641CCC", VA = "0x1641CCC")]
	public UIBestiaryInfoLine(T text, float textScale = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600444D")]
	[Cpp2IlInjected.Address(RVA = "0x1641E48", Offset = "0x1641E48", VA = "0x1641E48", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600444E")]
	[Cpp2IlInjected.Address(RVA = "0x1641E80", Offset = "0x1641E80", VA = "0x1641E80")]
	public void SetText(T text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600444F")]
	[Cpp2IlInjected.Address(RVA = "0x1641E94", Offset = "0x1641E94", VA = "0x1641E94", Slot = "32")]
	public virtual void SetText(T text, float textScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004450")]
	[Cpp2IlInjected.Address(RVA = "0x1642028", Offset = "0x1642028", VA = "0x1642028", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004451")]
	[Cpp2IlInjected.Address(RVA = "0x164215C", Offset = "0x164215C", VA = "0x164215C", Slot = "29")]
	public override int CompareTo(object obj)
	{
		return default(int);
	}
}
