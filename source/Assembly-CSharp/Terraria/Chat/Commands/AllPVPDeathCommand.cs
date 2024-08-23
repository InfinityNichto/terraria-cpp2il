using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000534 RID: 1332
	[ChatCommand("AllPVPDeath")]
	[global::Cpp2ILInjected.Token(Token = "0x20007A1")]
	public class AllPVPDeathCommand : IChatCommand
	{
		// Token: 0x06003916 RID: 14614 RVA: 0x0002C312 File Offset: 0x0002A512
		[global::Cpp2ILInjected.Token(Token = "0x6003FC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x74A11C", Offset = "0x74A11C", Length = "0x298")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			throw null;
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x0002C315 File Offset: 0x0002A515
		[global::Cpp2ILInjected.Token(Token = "0x6003FC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x74A3B4", Offset = "0x74A3B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x0002C318 File Offset: 0x0002A518
		[global::Cpp2ILInjected.Token(Token = "0x6003FC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x74A3B8", Offset = "0x74A3B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AllPVPDeathCommand()
		{
			throw null;
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x0002C31B File Offset: 0x0002A51B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003FC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x74A3C0", Offset = "0x74A3C0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static AllPVPDeathCommand()
		{
			throw null;
		}

		// Token: 0x0400689D RID: 26781
		[global::Cpp2ILInjected.Token(Token = "0x4007DCF")]
		private static readonly Color RESPONSE_COLOR;
	}
}
