using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat
{
	[global::Cpp2ILInjected.Token(Token = "0x200072F")]
	public interface ITagHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003CDF")]
		TextSnippet Parse(string text, Color baseColor = default(Color), string options = null);
	}
}
