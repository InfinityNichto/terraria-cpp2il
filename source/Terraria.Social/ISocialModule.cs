using Cpp2IlInjected;

namespace Terraria.Social;

[Cpp2IlInjected.Token(Token = "0x2000382")]
public interface ISocialModule
{
	[Cpp2IlInjected.Token(Token = "0x6002D41")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6002D42")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Shutdown();
}
