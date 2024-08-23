using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x02000539 RID: 1337
	[ChatCommand("Playing")]
	[global::Cpp2ILInjected.Token(Token = "0x20007A6")]
	public class ListPlayersCommand : IChatCommand
	{
		// Token: 0x0600392C RID: 14636 RVA: 0x0002C354 File Offset: 0x0002A554
		[global::Cpp2ILInjected.Token(Token = "0x6003FD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x74B408", Offset = "0x74B408", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IEnumerable<string>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromLiteral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "SendChatMessageToClient", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			throw null;
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x0002C357 File Offset: 0x0002A557
		[global::Cpp2ILInjected.Token(Token = "0x6003FD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x74B6C0", Offset = "0x74B6C0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x0002C35A File Offset: 0x0002A55A
		[global::Cpp2ILInjected.Token(Token = "0x6003FDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x74B6C4", Offset = "0x74B6C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ListPlayersCommand()
		{
			throw null;
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x0002C35D File Offset: 0x0002A55D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003FDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x74B6CC", Offset = "0x74B6CC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static ListPlayersCommand()
		{
			throw null;
		}

		// Token: 0x040068A2 RID: 26786
		[global::Cpp2ILInjected.Token(Token = "0x4007DD4")]
		private static readonly Color RESPONSE_COLOR;

		// Token: 0x02000978 RID: 2424
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007A7")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004D81 RID: 19841 RVA: 0x0002FAD4 File Offset: 0x0002DCD4
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003FDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x74B734", Offset = "0x74B734", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004D82 RID: 19842 RVA: 0x0002FAD7 File Offset: 0x0002DCD7
			[global::Cpp2ILInjected.Token(Token = "0x6003FDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x74B790", Offset = "0x74B790", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004D83 RID: 19843 RVA: 0x0002FADA File Offset: 0x0002DCDA
			[global::Cpp2ILInjected.Token(Token = "0x6003FDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x74B798", Offset = "0x74B798", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <ProcessIncomingMessage>b__1_0(Player player)
			{
				throw null;
			}

			// Token: 0x06004D84 RID: 19844 RVA: 0x0002FADD File Offset: 0x0002DCDD
			[global::Cpp2ILInjected.Token(Token = "0x6003FDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x74B7A0", Offset = "0x74B7A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal string <ProcessIncomingMessage>b__1_1(Player player)
			{
				throw null;
			}

			// Token: 0x04008BE7 RID: 35815
			[global::Cpp2ILInjected.Token(Token = "0x4007DD5")]
			public static readonly ListPlayersCommand.<>c <>9;

			// Token: 0x04008BE8 RID: 35816
			[global::Cpp2ILInjected.Token(Token = "0x4007DD6")]
			public static Func<Player, bool> <>9__1_0;

			// Token: 0x04008BE9 RID: 35817
			[global::Cpp2ILInjected.Token(Token = "0x4007DD7")]
			public static Func<Player, string> <>9__1_1;
		}
	}
}
