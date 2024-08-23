using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat
{
	// Token: 0x020004DA RID: 1242
	[global::Cpp2ILInjected.Token(Token = "0x200072F")]
	public interface ITagHandler
	{
		// Token: 0x0600367E RID: 13950
		[global::Cpp2ILInjected.Token(Token = "0x6003CDF")]
		TextSnippet Parse(string text, Color baseColor = default(Color), string options = null);
	}
}
