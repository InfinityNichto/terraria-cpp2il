using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000531 RID: 1329
	[ChatCommand("Death")]
	[global::Cpp2ILInjected.Token(Token = "0x200079E")]
	public class DeathCommand : IChatCommand
	{
		// Token: 0x0600390A RID: 14602 RVA: 0x0002C2EE File Offset: 0x0002A4EE
		[global::Cpp2ILInjected.Token(Token = "0x6003FB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x749778", Offset = "0x749778", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "BroadcastChatMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			throw null;
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x0002C2F1 File Offset: 0x0002A4F1
		[global::Cpp2ILInjected.Token(Token = "0x6003FB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x749A50", Offset = "0x749A50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x0002C2F4 File Offset: 0x0002A4F4
		[global::Cpp2ILInjected.Token(Token = "0x6003FB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x749A54", Offset = "0x749A54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DeathCommand()
		{
			throw null;
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x0002C2F7 File Offset: 0x0002A4F7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003FB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x749A5C", Offset = "0x749A5C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static DeathCommand()
		{
			throw null;
		}

		// Token: 0x0400689A RID: 26778
		[global::Cpp2ILInjected.Token(Token = "0x4007DCC")]
		private static readonly Color RESPONSE_COLOR;
	}
}
