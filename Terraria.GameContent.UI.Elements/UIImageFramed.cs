using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006DA")]
public class UIImageFramed : UIElement, IColorable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4007067")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007068")]
	private Rectangle _frame;

	[Cpp2IlInjected.Token(Token = "0x170007C6")]
	public Color Color
	{
		[Cpp2IlInjected.Token(Token = "0x60044DA")]
		[Cpp2IlInjected.Address(RVA = "0x1492030", Offset = "0x1492030", VA = "0x1492030", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x60044DB")]
		[Cpp2IlInjected.Address(RVA = "0x1492038", Offset = "0x1492038", VA = "0x1492038", Slot = "31")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60044DC")]
	[Cpp2IlInjected.Address(RVA = "0x1481404", Offset = "0x1481404", VA = "0x1481404")]
	public UIImageFramed(Asset<Texture2D> texture, Rectangle frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044DD")]
	[Cpp2IlInjected.Address(RVA = "0x1492040", Offset = "0x1492040", VA = "0x1492040")]
	public void SetImage(Asset<Texture2D> texture, Rectangle frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044DE")]
	[Cpp2IlInjected.Address(RVA = "0x14920A4", Offset = "0x14920A4", VA = "0x14920A4")]
	public void SetFrame(Rectangle frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044DF")]
	[Cpp2IlInjected.Address(RVA = "0x148B3C0", Offset = "0x148B3C0", VA = "0x148B3C0")]
	public void SetFrame(int frameCountHorizontal, int frameCountVertical, int frameX, int frameY, int sizeOffsetX, int sizeOffsetY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044E0")]
	[Cpp2IlInjected.Address(RVA = "0x1492100", Offset = "0x1492100", VA = "0x1492100", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
