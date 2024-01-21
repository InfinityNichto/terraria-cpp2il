using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Cpp2IlInjected;

namespace ReLogic.Text;

[Cpp2IlInjected.Token(Token = "0x2000722")]
internal static class StringReaderWrapExtension
{
	[Cpp2IlInjected.Token(Token = "0x2000ACE")]
	internal enum WrapScanMode
	{
		[Cpp2IlInjected.Token(Token = "0x4008F8A")]
		Space,
		[Cpp2IlInjected.Token(Token = "0x4008F8B")]
		NewLine,
		[Cpp2IlInjected.Token(Token = "0x4008F8C")]
		Word,
		[Cpp2IlInjected.Token(Token = "0x4008F8D")]
		None
	}

	[Cpp2IlInjected.Token(Token = "0x4007171")]
	private static readonly HashSet<char> InvalidCharactersForLineStart;

	[Cpp2IlInjected.Token(Token = "0x4007172")]
	private static readonly HashSet<char> InvalidCharactersForLineEnd;

	[Cpp2IlInjected.Token(Token = "0x4007173")]
	private static readonly CultureInfo[] SupportedCultures;

	[Cpp2IlInjected.Token(Token = "0x4007174")]
	private static readonly CultureInfo SimplifiedChinese;

	[Cpp2IlInjected.Token(Token = "0x60046BC")]
	[Cpp2IlInjected.Address(RVA = "0xF93A88", Offset = "0xF93A88", VA = "0xF93A88")]
	internal static bool IsCultureSupported(CultureInfo culture)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60046BD")]
	[Cpp2IlInjected.Address(RVA = "0xF93B1C", Offset = "0xF93B1C", VA = "0xF93B1C")]
	internal static bool IsIgnoredCharacter(char character)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60046BE")]
	[Cpp2IlInjected.Address(RVA = "0xF93B38", Offset = "0xF93B38", VA = "0xF93B38")]
	internal static bool CanBreakBetween(char previousChar, char nextChar, CultureInfo culture)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60046BF")]
	[Cpp2IlInjected.Address(RVA = "0xF93C7C", Offset = "0xF93C7C", VA = "0xF93C7C")]
	internal static WrapScanMode GetModeForCharacter(char character)
	{
		return default(WrapScanMode);
	}

	[Cpp2IlInjected.Token(Token = "0x60046C0")]
	[Cpp2IlInjected.Address(RVA = "0xF93D14", Offset = "0xF93D14", VA = "0xF93D14")]
	internal static string ReadUntilBreakable(this StringReader reader, CultureInfo culture)
	{
		return null;
	}
}
