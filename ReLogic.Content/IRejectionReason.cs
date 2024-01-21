using Cpp2IlInjected;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x2000740")]
public interface IRejectionReason
{
	[Cpp2IlInjected.Token(Token = "0x600475E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GetReason();
}
