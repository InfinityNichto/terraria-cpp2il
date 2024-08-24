using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200053B RID: 1339
	[ChatCommand("Roll")]
	[global::Cpp2ILInjected.Token(Token = "0x20007A9")]
	public class RollCommand : IChatCommand
	{
		// Token: 0x06003935 RID: 14645 RVA: 0x0002C36F File Offset: 0x0002A56F
		[global::Cpp2ILInjected.Token(Token = "0x6003FE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BAAC", Offset = "0x74BAAC", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "ToNetworkText", ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromFormattable", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			throw null;
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x0002C372 File Offset: 0x0002A572
		[global::Cpp2ILInjected.Token(Token = "0x6003FE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BCE0", Offset = "0x74BCE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x0002C375 File Offset: 0x0002A575
		[global::Cpp2ILInjected.Token(Token = "0x6003FE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BCE4", Offset = "0x74BCE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RollCommand()
		{
			throw null;
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x0002C378 File Offset: 0x0002A578
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003FE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x74BCEC", Offset = "0x74BCEC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static RollCommand()
		{
			throw null;
		}

		// Token: 0x040068A4 RID: 26788
		[global::Cpp2ILInjected.Token(Token = "0x4007DD9")]
		private static readonly Color RESPONSE_COLOR;
	}
}
