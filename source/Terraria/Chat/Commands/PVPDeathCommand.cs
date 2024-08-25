using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	[ChatCommand("PVPDeath")]
	[global::Cpp2ILInjected.Token(Token = "0x200079F")]
	public class PVPDeathCommand : IChatCommand
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003FBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x749D9C", Offset = "0x749D9C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x749DA0", Offset = "0x749DA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PVPDeathCommand()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007DCD")]
		private static readonly Color RESPONSE_COLOR;
	}
}
