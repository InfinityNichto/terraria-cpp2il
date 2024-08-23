using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200053C RID: 1340
	[ChatCommand("Say")]
	[global::Cpp2ILInjected.Token(Token = "0x20007AA")]
	public class SayChatCommand : IChatCommand
	{
		// Token: 0x06003939 RID: 14649 RVA: 0x0002C37B File Offset: 0x0002A57B
		[global::Cpp2ILInjected.Token(Token = "0x6003FE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BD54", Offset = "0x74BD54", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromLiteral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ChatColor", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "BroadcastChatMessageAs", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			throw null;
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x0002C37E File Offset: 0x0002A57E
		[global::Cpp2ILInjected.Token(Token = "0x6003FEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BED4", Offset = "0x74BED4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x0002C381 File Offset: 0x0002A581
		[global::Cpp2ILInjected.Token(Token = "0x6003FEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BED8", Offset = "0x74BED8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SayChatCommand()
		{
			throw null;
		}
	}
}
