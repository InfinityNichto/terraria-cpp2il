using System;
using Cpp2ILInjected;

namespace ReLogic.Text
{
	// Token: 0x0200071B RID: 1819
	[global::Cpp2ILInjected.Token(Token = "0x2000B15")]
	public interface IFontMetrics
	{
		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06004674 RID: 18036
		[global::Cpp2ILInjected.Token(Token = "0x170008F5")]
		int LineSpacing
		{
			[global::Cpp2ILInjected.Token(Token = "0x600531D")]
			get;
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06004675 RID: 18037
		[global::Cpp2ILInjected.Token(Token = "0x170008F6")]
		float CharacterSpacing
		{
			[global::Cpp2ILInjected.Token(Token = "0x600531E")]
			get;
		}

		// Token: 0x06004676 RID: 18038
		[global::Cpp2ILInjected.Token(Token = "0x600531F")]
		GlyphMetrics GetCharacterMetrics(char character);
	}
}
