using System;
using Cpp2ILInjected;

namespace ReLogic.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B15")]
	public interface IFontMetrics
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008F5")]
		int LineSpacing
		{
			[global::Cpp2ILInjected.Token(Token = "0x600531D")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008F6")]
		float CharacterSpacing
		{
			[global::Cpp2ILInjected.Token(Token = "0x600531E")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600531F")]
		GlyphMetrics GetCharacterMetrics(char character);
	}
}
