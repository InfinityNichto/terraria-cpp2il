using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006E7")]
public class UISlicedImage : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400709C")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400709D")]
	private Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400709E")]
	private int _leftSliceDepth;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400709F")]
	private int _rightSliceDepth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40070A0")]
	private int _topSliceDepth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40070A1")]
	private int _bottomSliceDepth;

	[Cpp2IlInjected.Token(Token = "0x170007CF")]
	public Color Color
	{
		[Cpp2IlInjected.Token(Token = "0x6004531")]
		[Cpp2IlInjected.Address(RVA = "0x1496D58", Offset = "0x1496D58", VA = "0x1496D58")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6004532")]
		[Cpp2IlInjected.Address(RVA = "0x1496D60", Offset = "0x1496D60", VA = "0x1496D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004533")]
	[Cpp2IlInjected.Address(RVA = "0x1496D68", Offset = "0x1496D68", VA = "0x1496D68")]
	public UISlicedImage(Asset<Texture2D> texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004534")]
	[Cpp2IlInjected.Address(RVA = "0x1496E6C", Offset = "0x1496E6C", VA = "0x1496E6C")]
	public void SetImage(Asset<Texture2D> texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004535")]
	[Cpp2IlInjected.Address(RVA = "0x1496E74", Offset = "0x1496E74", VA = "0x1496E74", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004536")]
	[Cpp2IlInjected.Address(RVA = "0x1496F6C", Offset = "0x1496F6C", VA = "0x1496F6C")]
	public void SetSliceDepths(int top, int bottom, int left, int right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004537")]
	[Cpp2IlInjected.Address(RVA = "0x1496F84", Offset = "0x1496F84", VA = "0x1496F84")]
	public void SetSliceDepths(int fluff)
	{
	}
}
