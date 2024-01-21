using Cpp2IlInjected;

namespace ReLogic.OS;

[Cpp2IlInjected.Token(Token = "0x2000724")]
public interface IClipboard
{
	[Cpp2IlInjected.Token(Token = "0x170007F6")]
	string Value
	{
		[Cpp2IlInjected.Token(Token = "0x60046CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60046D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170007F7")]
	string MultiLineValue
	{
		[Cpp2IlInjected.Token(Token = "0x60046D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
