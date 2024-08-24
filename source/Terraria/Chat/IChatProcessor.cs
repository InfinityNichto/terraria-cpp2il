using System;
using Cpp2ILInjected;

namespace Terraria.Chat
{
	// Token: 0x0200052E RID: 1326
	[global::Cpp2ILInjected.Token(Token = "0x200079B")]
	public interface IChatProcessor
	{
		// Token: 0x06003905 RID: 14597
		[global::Cpp2ILInjected.Token(Token = "0x6003FB1")]
		void ProcessIncomingMessage(ChatMessage message, int clientId);

		// Token: 0x06003906 RID: 14598
		[global::Cpp2ILInjected.Token(Token = "0x6003FB2")]
		ChatMessage CreateOutgoingMessage(string text);
	}
}
