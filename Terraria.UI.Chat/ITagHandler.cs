using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20004DD")]
public interface ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x60036BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options);
}
