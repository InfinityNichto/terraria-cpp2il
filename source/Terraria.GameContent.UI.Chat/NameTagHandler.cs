using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20006F7")]
public class NameTagHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x60045B4")]
	[Cpp2IlInjected.Address(RVA = "0x1187134", Offset = "0x1187134", VA = "0x1187134", Slot = "4")]
	TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60045B5")]
	[Cpp2IlInjected.Address(RVA = "0x118723C", Offset = "0x118723C", VA = "0x118723C")]
	public static string GenerateTag(string name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60045B6")]
	[Cpp2IlInjected.Address(RVA = "0x11872F4", Offset = "0x11872F4", VA = "0x11872F4")]
	public NameTagHandler()
	{
	}
}
