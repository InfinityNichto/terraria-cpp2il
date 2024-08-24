using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000537 RID: 1335
	[ChatCommand("Emote")]
	[global::Cpp2ILInjected.Token(Token = "0x20007A4")]
	public class EmoteCommand : IChatCommand
	{
		// Token: 0x06003922 RID: 14626 RVA: 0x0002C336 File Offset: 0x0002A536
		[global::Cpp2ILInjected.Token(Token = "0x6003FCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x74AB64", Offset = "0x74AB64", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromLiteral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "BroadcastChatMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			throw null;
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x0002C339 File Offset: 0x0002A539
		[global::Cpp2ILInjected.Token(Token = "0x6003FCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x74ACD4", Offset = "0x74ACD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x0002C33C File Offset: 0x0002A53C
		[global::Cpp2ILInjected.Token(Token = "0x6003FD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x74ACD8", Offset = "0x74ACD8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EmoteCommand()
		{
			throw null;
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x0002C33F File Offset: 0x0002A53F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003FD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x74ACE0", Offset = "0x74ACE0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static EmoteCommand()
		{
			throw null;
		}

		// Token: 0x040068A0 RID: 26784
		[global::Cpp2ILInjected.Token(Token = "0x4007DD2")]
		private static readonly Color RESPONSE_COLOR;
	}
}
