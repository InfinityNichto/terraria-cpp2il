using Cpp2IlInjected;
using ReLogic.OS.Base;

namespace ReLogic.OS.Linux;

[Cpp2IlInjected.Token(Token = "0x200072E")]
internal class Clipboard : ReLogic.OS.Base.Clipboard
{
	[Cpp2IlInjected.Token(Token = "0x60046F0")]
	[Cpp2IlInjected.Address(RVA = "0xF9186C", Offset = "0xF9186C", VA = "0xF9186C", Slot = "7")]
	protected override string GetClipboard()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60046F1")]
	[Cpp2IlInjected.Address(RVA = "0xF91AEC", Offset = "0xF91AEC", VA = "0xF91AEC")]
	private void ClearClipboard()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046F2")]
	[Cpp2IlInjected.Address(RVA = "0xF91D14", Offset = "0xF91D14", VA = "0xF91D14", Slot = "8")]
	protected override void SetClipboard(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046F3")]
	[Cpp2IlInjected.Address(RVA = "0xF91FB4", Offset = "0xF91FB4", VA = "0xF91FB4")]
	public Clipboard()
	{
	}
}
