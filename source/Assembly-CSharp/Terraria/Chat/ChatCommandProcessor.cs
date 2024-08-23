using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Chat.Commands;
using Terraria.GameContent.NetModules;
using Terraria.Initializers;
using Terraria.Localization;
using Terraria.UI.Chat;
using UnityEngine;

namespace Terraria.Chat
{
	// Token: 0x0200052C RID: 1324
	[global::Cpp2ILInjected.Token(Token = "0x2000798")]
	public class ChatCommandProcessor : IChatProcessor
	{
		// Token: 0x060038EE RID: 14574 RVA: 0x0002C2A6 File Offset: 0x0002A4A6
		[global::Cpp2ILInjected.Token(Token = "0x6003F96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1576780", Offset = "0x1576780", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ChatCommandId, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(ChatCommandId),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, ChatCommandId>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ChatCommandId)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public ChatCommandProcessor AddCommand<T>() where T : IChatCommand, new()
		{
			throw null;
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x0002C2A9 File Offset: 0x0002A4A9
		[global::Cpp2ILInjected.Token(Token = "0x6003F97")]
		[global::Cpp2ILInjected.Address(RVA = "0x748C88", Offset = "0x748C88", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatInitializer), Member = "PrepareAliases", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddAlias(LocalizedText text, NetworkText result)
		{
			throw null;
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x0002C2AC File Offset: 0x0002A4AC
		[global::Cpp2ILInjected.Token(Token = "0x6003F98")]
		[global::Cpp2ILInjected.Address(RVA = "0x748CE8", Offset = "0x748CE8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatInitializer), Member = "PrepareAliases", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ClearAliases()
		{
			throw null;
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x0002C2AF File Offset: 0x0002A4AF
		[global::Cpp2ILInjected.Token(Token = "0x6003F99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1576A64", Offset = "0x1576A64", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ChatCommandId, object>), Member = "get_Item", MemberParameters = new object[] { typeof(ChatCommandId) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ChatCommandProcessor AddDefaultCommand<T>() where T : IChatCommand, new()
		{
			throw null;
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x0002C2B2 File Offset: 0x0002A4B2
		[global::Cpp2ILInjected.Token(Token = "0x6003F9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x748D30", Offset = "0x748D30", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatCommandProcessor.<>c__DisplayClass10_0), Member = "<CreateOutgoingMessage>b__0", MemberParameters = new object[] { typeof(KeyValuePair<LocalizedText, ChatCommandId>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatCommandProcessor.<>c__DisplayClass10_0), Member = "<CreateOutgoingMessage>b__1", MemberParameters = new object[] { typeof(KeyValuePair<LocalizedText, NetworkText>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatCommandProcessor.<>c__DisplayClass10_0), Member = "<CreateOutgoingMessage>b__2", MemberParameters = new object[] { typeof(KeyValuePair<LocalizedText, NetworkText>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool HasLocalizedCommand(ChatMessage message, LocalizedText command)
		{
			throw null;
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x0002C2B5 File Offset: 0x0002A4B5
		[global::Cpp2ILInjected.Token(Token = "0x6003F9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x748DA4", Offset = "0x748DA4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatCommandProcessor), Member = "CreateOutgoingMessage", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ChatMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string RemoveCommandPrefix(string messageText, LocalizedText command)
		{
			throw null;
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x0002C2B8 File Offset: 0x0002A4B8
		[global::Cpp2ILInjected.Token(Token = "0x6003F9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x748E48", Offset = "0x748E48", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessage), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, ChatCommandId>, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, object>, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(KeyValuePair<object, object>) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<KeyValuePair<object, object>>),
			typeof(Func<KeyValuePair<object, object>, bool>)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessage), Member = "SetCommand", MemberParameters = new object[] { typeof(ChatCommandId) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandProcessor), Member = "RemoveCommandPrefix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(LocalizedText)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ChatCommandId, object>), Member = "get_Item", MemberParameters = new object[] { typeof(ChatCommandId) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public ChatMessage CreateOutgoingMessage(string text)
		{
			throw null;
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x0002C2BB File Offset: 0x0002A4BB
		[global::Cpp2ILInjected.Token(Token = "0x6003F9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x749210", Offset = "0x749210", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "DeserializeAsServer", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ChatCommandId, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ChatCommandId),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void ProcessIncomingMessage(ChatMessage message, int clientId)
		{
			throw null;
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x0002C2BE File Offset: 0x0002A4BE
		[global::Cpp2ILInjected.Token(Token = "0x6003F9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x749354", Offset = "0x749354", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, ChatCommandId>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ChatCommandId, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public ChatCommandProcessor()
		{
			throw null;
		}

		// Token: 0x04006892 RID: 26770
		[global::Cpp2ILInjected.Token(Token = "0x4007DC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<LocalizedText, ChatCommandId> _localizedCommands;

		// Token: 0x04006893 RID: 26771
		[global::Cpp2ILInjected.Token(Token = "0x4007DC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<ChatCommandId, IChatCommand> _commands;

		// Token: 0x04006894 RID: 26772
		[global::Cpp2ILInjected.Token(Token = "0x4007DC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<LocalizedText, NetworkText> _aliases;

		// Token: 0x04006895 RID: 26773
		[global::Cpp2ILInjected.Token(Token = "0x4007DC5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IChatCommand _defaultCommand;

		// Token: 0x02000977 RID: 2423
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000799")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06004D7D RID: 19837 RVA: 0x0002FAC8 File Offset: 0x0002DCC8
			[global::Cpp2ILInjected.Token(Token = "0x6003F9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x749140", Offset = "0x749140", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass10_0()
			{
				throw null;
			}

			// Token: 0x06004D7E RID: 19838 RVA: 0x0002FACB File Offset: 0x0002DCCB
			[global::Cpp2ILInjected.Token(Token = "0x6003FA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x749460", Offset = "0x749460", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandProcessor), Member = "HasLocalizedCommand", MemberParameters = new object[]
			{
				typeof(ChatMessage),
				typeof(LocalizedText)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <CreateOutgoingMessage>b__0(KeyValuePair<LocalizedText, ChatCommandId> pair)
			{
				throw null;
			}

			// Token: 0x06004D7F RID: 19839 RVA: 0x0002FACE File Offset: 0x0002DCCE
			[global::Cpp2ILInjected.Token(Token = "0x6003FA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7494A4", Offset = "0x7494A4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandProcessor), Member = "HasLocalizedCommand", MemberParameters = new object[]
			{
				typeof(ChatMessage),
				typeof(LocalizedText)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <CreateOutgoingMessage>b__1(KeyValuePair<LocalizedText, NetworkText> pair)
			{
				throw null;
			}

			// Token: 0x06004D80 RID: 19840 RVA: 0x0002FAD1 File Offset: 0x0002DCD1
			[global::Cpp2ILInjected.Token(Token = "0x6003FA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7494E8", Offset = "0x7494E8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandProcessor), Member = "HasLocalizedCommand", MemberParameters = new object[]
			{
				typeof(ChatMessage),
				typeof(LocalizedText)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <CreateOutgoingMessage>b__2(KeyValuePair<LocalizedText, NetworkText> pair)
			{
				throw null;
			}

			// Token: 0x04008BE5 RID: 35813
			[global::Cpp2ILInjected.Token(Token = "0x4007DC6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ChatMessage message;

			// Token: 0x04008BE6 RID: 35814
			[global::Cpp2ILInjected.Token(Token = "0x4007DC7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<LocalizedText, NetworkText>, bool> <>9__2;
		}
	}
}
