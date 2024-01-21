using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006D5")]
public class UIHeader : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400704D")]
	private string _text;

	[Cpp2IlInjected.Token(Token = "0x170007C5")]
	public string Text
	{
		[Cpp2IlInjected.Token(Token = "0x60044C0")]
		[Cpp2IlInjected.Address(RVA = "0x14907E4", Offset = "0x14907E4", VA = "0x14907E4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60044C1")]
		[Cpp2IlInjected.Address(RVA = "0x14907EC", Offset = "0x14907EC", VA = "0x14907EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60044C2")]
	[Cpp2IlInjected.Address(RVA = "0x1490910", Offset = "0x1490910", VA = "0x1490910")]
	public UIHeader()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044C3")]
	[Cpp2IlInjected.Address(RVA = "0x14909A4", Offset = "0x14909A4", VA = "0x14909A4")]
	public UIHeader(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044C4")]
	[Cpp2IlInjected.Address(RVA = "0x1490A30", Offset = "0x1490A30", VA = "0x1490A30", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
