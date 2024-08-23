using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;
using Terraria.Localization;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000676 RID: 1654
	[global::Cpp2ILInjected.Token(Token = "0x20009FE")]
	public class NetTextModule : NetModule
	{
		// Token: 0x06004105 RID: 16645 RVA: 0x0002D9EC File Offset: 0x0002BBEC
		[global::Cpp2ILInjected.Token(Token = "0x6004B8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A9968", Offset = "0x8A9968", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "SendChatMessageFromClient", MemberParameters = new object[] { typeof(ChatMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessage), Member = "GetMaxSerializedSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessage), Member = "Serialize", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static NetPacket SerializeClientMessage(ChatMessage message)
		{
			throw null;
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x0002D9EF File Offset: 0x0002BBEF
		[global::Cpp2ILInjected.Token(Token = "0x6004B8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A99E8", Offset = "0x8A99E8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static NetPacket SerializeServerMessage(NetworkText text, Color color)
		{
			throw null;
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x0002D9F2 File Offset: 0x0002BBF2
		[global::Cpp2ILInjected.Token(Token = "0x6004B8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A99F4", Offset = "0x8A99F4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "DisplayMessageOnClient", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "SendChatMessageToClientAs", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "BroadcastChatMessageAs", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "GetMaxSerializedSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "Serialize", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "WriteRGB", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static NetPacket SerializeServerMessage(NetworkText text, Color color, byte authorId)
		{
			throw null;
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x0002D9F5 File Offset: 0x0002BBF5
		[global::Cpp2ILInjected.Token(Token = "0x6004B8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A9AF4", Offset = "0x8A9AF4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "Deserialize", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ReadRGB", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "DisplayMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool DeserializeAsClient(BinaryReader reader, int senderPlayerId)
		{
			throw null;
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x0002D9F8 File Offset: 0x0002BBF8
		[global::Cpp2ILInjected.Token(Token = "0x6004B8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A9BEC", Offset = "0x8A9BEC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatMessage), Member = "Deserialize", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(ChatMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatCommandProcessor), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(ChatMessage),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool DeserializeAsServer(BinaryReader reader, int senderPlayerId)
		{
			throw null;
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x0002D9FB File Offset: 0x0002BBFB
		[global::Cpp2ILInjected.Token(Token = "0x6004B8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A9C7C", Offset = "0x8A9C7C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetTextModule), Member = "DeserializeAsServer", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetTextModule), Member = "DeserializeAsClient", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Deserialize(BinaryReader reader, int senderPlayerId)
		{
			throw null;
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x0002D9FE File Offset: 0x0002BBFE
		[global::Cpp2ILInjected.Token(Token = "0x6004B90")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A9CFC", Offset = "0x8A9CFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = ".ctor", ReturnType = typeof(void))]
		public NetTextModule()
		{
			throw null;
		}
	}
}
