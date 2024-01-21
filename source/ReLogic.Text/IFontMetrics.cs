using Cpp2IlInjected;

namespace ReLogic.Text;

[Cpp2IlInjected.Token(Token = "0x200071E")]
public interface IFontMetrics
{
	[Cpp2IlInjected.Token(Token = "0x170007F3")]
	int LineSpacing
	{
		[Cpp2IlInjected.Token(Token = "0x60046B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170007F4")]
	float CharacterSpacing
	{
		[Cpp2IlInjected.Token(Token = "0x60046B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60046B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GlyphMetrics GetCharacterMetrics(char character);
}
