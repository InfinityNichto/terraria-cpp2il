using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000532 RID: 1330
	[ChatCommand("PVPDeath")]
	[global::Cpp2ILInjected.Token(Token = "0x200079F")]
	public class PVPDeathCommand : IChatCommand
	{
		// Token: 0x0600390E RID: 14606 RVA: 0x0002C2FA File Offset: 0x0002A4FA
		[global::Cpp2ILInjected.Token(Token = "0x6003FBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x749AC4", Offset = "0x749AC4", Length = "0x2D8")]
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

		// Token: 0x0600390F RID: 14607 RVA: 0x0002C2FD File Offset: 0x0002A4FD
		[global::Cpp2ILInjected.Token(Token = "0x6003FBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x749D9C", Offset = "0x749D9C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x0002C300 File Offset: 0x0002A500
		[global::Cpp2ILInjected.Token(Token = "0x6003FBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x749DA0", Offset = "0x749DA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PVPDeathCommand()
		{
			throw null;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x0002C303 File Offset: 0x0002A503
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003FBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x749DA8", Offset = "0x749DA8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PVPDeathCommand()
		{
			throw null;
		}

		// Token: 0x0400689B RID: 26779
		[global::Cpp2ILInjected.Token(Token = "0x4007DCD")]
		private static readonly Color RESPONSE_COLOR;
	}
}
