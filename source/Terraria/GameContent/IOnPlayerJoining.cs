using System;
using Cpp2ILInjected;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007D9")]
	public interface IOnPlayerJoining
	{
		[global::Cpp2ILInjected.Token(Token = "0x60040DC")]
		void OnPlayerJoining(int playerIndex);
	}
}
