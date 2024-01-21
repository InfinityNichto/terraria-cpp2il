using Cpp2IlInjected;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004D4")]
public interface IHaveBackButtonCommand
{
	[Cpp2IlInjected.Token(Token = "0x600367C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HandleBackButtonUsage();
}
