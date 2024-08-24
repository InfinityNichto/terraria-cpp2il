using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200053A RID: 1338
	[ChatCommand("Party")]
	[global::Cpp2ILInjected.Token(Token = "0x20007A8")]
	public class PartyChatCommand : IChatCommand
	{
		// Token: 0x06003930 RID: 14640 RVA: 0x0002C360 File Offset: 0x0002A560
		[global::Cpp2ILInjected.Token(Token = "0x6003FE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x74B7A8", Offset = "0x74B7A8", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromLiteral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "SendChatMessageToClientAs", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			throw null;
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x0002C363 File Offset: 0x0002A563
		[global::Cpp2ILInjected.Token(Token = "0x6003FE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BA38", Offset = "0x74BA38", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x0002C366 File Offset: 0x0002A566
		[global::Cpp2ILInjected.Token(Token = "0x6003FE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x74B960", Offset = "0x74B960", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "ToNetworkText", ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "SendChatMessageToClient", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void SendNoTeamError(byte clientId)
		{
			throw null;
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x0002C369 File Offset: 0x0002A569
		[global::Cpp2ILInjected.Token(Token = "0x6003FE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BA3C", Offset = "0x74BA3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PartyChatCommand()
		{
			throw null;
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x0002C36C File Offset: 0x0002A56C
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003FE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BA44", Offset = "0x74BA44", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PartyChatCommand()
		{
			throw null;
		}

		// Token: 0x040068A3 RID: 26787
		[global::Cpp2ILInjected.Token(Token = "0x4007DD8")]
		private static readonly Color ERROR_COLOR;
	}
}
