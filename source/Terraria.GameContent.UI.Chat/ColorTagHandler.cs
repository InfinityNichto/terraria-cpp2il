using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20006F0")]
public class ColorTagHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x600457A")]
	[Cpp2IlInjected.Address(RVA = "0x118293C", Offset = "0x118293C", VA = "0x118293C", Slot = "4")]
	TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600457B")]
	[Cpp2IlInjected.Address(RVA = "0x1182A3C", Offset = "0x1182A3C", VA = "0x1182A3C")]
	public ColorTagHandler()
	{
	}
}
