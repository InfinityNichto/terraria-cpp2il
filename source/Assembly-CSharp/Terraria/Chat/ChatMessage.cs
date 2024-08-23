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
	// Token: 0x0200052D RID: 1325
	[global::Cpp2ILInjected.Token(Token = "0x200079A")]
	public sealed class ChatMessage
	{
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x0002C2C1 File Offset: 0x0002A4C1
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x0002C2C4 File Offset: 0x0002A4C4
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

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x0002C2C7 File Offset: 0x0002A4C7
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x0002C2CA File Offset: 0x0002A4CA
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

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x0002C2CD File Offset: 0x0002A4CD
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x0002C2D0 File Offset: 0x0002A4D0
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

		// Token: 0x060038FD RID: 14589 RVA: 0x0002C2D3 File Offset: 0x0002A4D3
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

		// Token: 0x060038FE RID: 14590 RVA: 0x0002C2D6 File Offset: 0x0002A4D6
		[global::Cpp2ILInjected.Token(Token = "0x6003FAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x749560", Offset = "0x749560", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private ChatMessage(string message, ChatCommandId commandId)
		{
			throw null;
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x0002C2D9 File Offset: 0x0002A4D9
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

		// Token: 0x06003900 RID: 14592 RVA: 0x0002C2DC File Offset: 0x0002A4DC
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

		// Token: 0x06003901 RID: 14593 RVA: 0x0002C2DF File Offset: 0x0002A4DF
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

		// Token: 0x06003902 RID: 14594 RVA: 0x0002C2E2 File Offset: 0x0002A4E2
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

		// Token: 0x06003903 RID: 14595 RVA: 0x0002C2E5 File Offset: 0x0002A4E5
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

		// Token: 0x06003904 RID: 14596 RVA: 0x0002C2E8 File Offset: 0x0002A4E8
		[global::Cpp2ILInjected.Token(Token = "0x6003FB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x749348", Offset = "0x749348", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Consume()
		{
			throw null;
		}

		// Token: 0x04006896 RID: 26774
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007DC8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ChatCommandId <CommandId>k__BackingField;

		// Token: 0x04006897 RID: 26775
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007DC9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <Text>k__BackingField;

		// Token: 0x04006898 RID: 26776
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007DCA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool <IsConsumed>k__BackingField;
	}
}
