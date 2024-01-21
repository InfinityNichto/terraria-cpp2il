using Cpp2IlInjected;
using ReLogic.OS.Base;

namespace ReLogic.OS.OSX;

[Cpp2IlInjected.Token(Token = "0x200072B")]
internal class Clipboard : ReLogic.OS.Base.Clipboard
{
	[Cpp2IlInjected.Token(Token = "0x60046E5")]
	[Cpp2IlInjected.Address(RVA = "0xF920BC", Offset = "0xF920BC", VA = "0xF920BC", Slot = "7")]
	protected override string GetClipboard()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60046E6")]
	[Cpp2IlInjected.Address(RVA = "0xF9233C", Offset = "0xF9233C", VA = "0xF9233C", Slot = "8")]
	protected override void SetClipboard(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046E7")]
	[Cpp2IlInjected.Address(RVA = "0xF925B0", Offset = "0xF925B0", VA = "0xF925B0")]
	public Clipboard()
	{
	}
}
