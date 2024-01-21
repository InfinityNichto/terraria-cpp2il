using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20006F8")]
public class PlainTagHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x2000AC0")]
	public class PlainSnippet : TextSnippet
	{
		[Cpp2IlInjected.Token(Token = "0x60052D3")]
		[Cpp2IlInjected.Address(RVA = "0x1187368", Offset = "0x1187368", VA = "0x1187368")]
		public PlainSnippet(string text = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052D4")]
		[Cpp2IlInjected.Address(RVA = "0x1187378", Offset = "0x1187378", VA = "0x1187378")]
		public PlainSnippet(string text, Color color, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052D5")]
		[Cpp2IlInjected.Address(RVA = "0x1187398", Offset = "0x1187398", VA = "0x1187398", Slot = "7")]
		public override Color GetVisibleColor()
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60045B7")]
	[Cpp2IlInjected.Address(RVA = "0x11872FC", Offset = "0x11872FC", VA = "0x11872FC", Slot = "4")]
	TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60045B8")]
	[Cpp2IlInjected.Address(RVA = "0x1187370", Offset = "0x1187370", VA = "0x1187370")]
	public PlainTagHandler()
	{
	}
}
