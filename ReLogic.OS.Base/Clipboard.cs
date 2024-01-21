using Cpp2IlInjected;

namespace ReLogic.OS.Base;

[Cpp2IlInjected.Token(Token = "0x2000731")]
internal abstract class Clipboard : IClipboard
{
	[Cpp2IlInjected.Token(Token = "0x170007F8")]
	public string Value
	{
		[Cpp2IlInjected.Token(Token = "0x60046FC")]
		[Cpp2IlInjected.Address(RVA = "0xF91648", Offset = "0xF91648", VA = "0xF91648", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60046FD")]
		[Cpp2IlInjected.Address(RVA = "0xF91780", Offset = "0xF91780", VA = "0xF91780", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007F9")]
	public string MultiLineValue
	{
		[Cpp2IlInjected.Token(Token = "0x60046FE")]
		[Cpp2IlInjected.Address(RVA = "0xF91790", Offset = "0xF91790", VA = "0xF91790", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60046FF")]
	[Cpp2IlInjected.Address(RVA = "0xF9166C", Offset = "0xF9166C", VA = "0xF9166C")]
	private static string SanitizeClipboardText(string clipboardText, bool allowNewLine)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004700")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract string GetClipboard();

	[Cpp2IlInjected.Token(Token = "0x6004701")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void SetClipboard(string text);

	[Cpp2IlInjected.Token(Token = "0x6004702")]
	[Cpp2IlInjected.Address(RVA = "0xF917B4", Offset = "0xF917B4", VA = "0xF917B4")]
	protected Clipboard()
	{
	}
}
