using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	[ChatCommand("AllPVPDeath")]
	[global::Cpp2ILInjected.Token(Token = "0x20007A1")]
	public class AllPVPDeathCommand : IChatCommand
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003FC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x74A3B4", Offset = "0x74A3B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x74A3B8", Offset = "0x74A3B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AllPVPDeathCommand()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007DCF")]
		private static readonly Color RESPONSE_COLOR;
	}
}
