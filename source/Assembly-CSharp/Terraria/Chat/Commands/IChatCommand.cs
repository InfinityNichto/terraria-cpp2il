using System;
using Cpp2ILInjected;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000530 RID: 1328
	[global::Cpp2ILInjected.Token(Token = "0x200079D")]
	public interface IChatCommand
	{
		// Token: 0x06003908 RID: 14600
		[global::Cpp2ILInjected.Token(Token = "0x6003FB4")]
		void ProcessIncomingMessage(string text, byte clientId);

		// Token: 0x06003909 RID: 14601
		[global::Cpp2ILInjected.Token(Token = "0x6003FB5")]
		void ProcessOutgoingMessage(ChatMessage message);
	}
}
