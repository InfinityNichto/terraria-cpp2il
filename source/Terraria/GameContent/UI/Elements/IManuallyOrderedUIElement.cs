using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AA5")]
	public interface IManuallyOrderedUIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008BD")]
		int OrderInUIList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005051")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6005052")]
			set;
		}
	}
}
