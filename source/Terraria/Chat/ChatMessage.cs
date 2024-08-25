using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Chat.Commands;
using Terraria.GameContent.NetModules;
using Terraria.Net;

namespace Terraria.Chat
{
	[global::Cpp2ILInjected.Token(Token = "0x200079A")]
	public sealed class ChatMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007B6")]
		public ChatCommandId CommandId
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003FA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x74952C", Offset = "0x74952C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003FA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x749534", Offset = "0x749534", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B7")]
		public string Text
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003FA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x74953C", Offset = "0x74953C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003FA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x749544", Offset = "0x749544", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170007B8")]
		public bool IsConsumed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003FA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x74954C", Offset = "0x74954C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003FA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x749554", Offset = "0x749554", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x749148", Offset = "0x749148", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatCommandProcessor), Member = "CreateOutgoingMessage", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ChatMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandId), Member = "FromType", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(ChatCommandId))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ChatMessage(string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x749560", Offset = "0x749560", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private ChatMessage(string message, ChatCommandId commandId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x74958C", Offset = "0x74958C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "SerializeClientMessage", MemberParameters = new object[] { typeof(ChatMessage) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandId), Member = "Serialize", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Serialize(BinaryWriter writer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x749620", Offset = "0x749620", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "SerializeClientMessage", MemberParameters = new object[] { typeof(ChatMessage) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandId), Member = "GetMaxSerializedSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int GetMaxSerializedSize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7496C0", Offset = "0x7496C0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "DeserializeAsServer", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ChatMessage Deserialize(BinaryReader reader)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7491B0", Offset = "0x7491B0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatCommandProcessor), Member = "CreateOutgoingMessage", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ChatMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetCommand(ChatCommandId commandId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1576BCC", Offset = "0x1576BCC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetCommand<T>() where T : IChatCommand
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003FB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x749348", Offset = "0x749348", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Consume()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007DC8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ChatCommandId <CommandId>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007DC9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <Text>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007DCA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool <IsConsumed>k__BackingField;
	}
}
