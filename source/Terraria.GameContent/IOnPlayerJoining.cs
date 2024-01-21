using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200055C")]
public interface IOnPlayerJoining
{
	[Cpp2IlInjected.Token(Token = "0x6003A33")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPlayerJoining(int playerIndex);
}
