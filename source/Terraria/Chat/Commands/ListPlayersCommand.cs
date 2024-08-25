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
	[ChatCommand("Playing")]
	[global::Cpp2ILInjected.Token(Token = "0x20007A6")]
	public class ListPlayersCommand : IChatCommand
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003FD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x74B6C0", Offset = "0x74B6C0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x74B6C4", Offset = "0x74B6C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ListPlayersCommand()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007DD4")]
		private static readonly Color RESPONSE_COLOR;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007A7")]
		[Serializable]
		private sealed class <>c
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6003FDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x74B790", Offset = "0x74B790", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003FDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x74B798", Offset = "0x74B798", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <ProcessIncomingMessage>b__1_0(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003FDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x74B7A0", Offset = "0x74B7A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal string <ProcessIncomingMessage>b__1_1(Player player)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007DD5")]
			public static readonly ListPlayersCommand.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4007DD6")]
			public static Func<Player, bool> <>9__1_0;

			[global::Cpp2ILInjected.Token(Token = "0x4007DD7")]
			public static Func<Player, string> <>9__1_1;
		}
	}
}
