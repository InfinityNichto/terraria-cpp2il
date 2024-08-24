using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Bestiary;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x0200066E RID: 1646
	[global::Cpp2ILInjected.Token(Token = "0x20009F4")]
	public class NetBestiaryModule : NetModule
	{
		// Token: 0x060040E8 RID: 16616 RVA: 0x0002D995 File Offset: 0x0002BB95
		[global::Cpp2ILInjected.Token(Token = "0x6004B6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A8120", Offset = "0x8A8120", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKillsTracker), Member = "RegisterKill", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKillsTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static NetPacket SerializeKillCount(int npcNetId, int killcount)
		{
			throw null;
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x0002D998 File Offset: 0x0002BB98
		[global::Cpp2ILInjected.Token(Token = "0x6004B6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A81E4", Offset = "0x8A81E4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCWasNearPlayerTracker), Member = "RegisterWasNearby", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCWasNearPlayerTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static NetPacket SerializeSight(int npcNetId)
		{
			throw null;
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x0002D99B File Offset: 0x0002BB9B
		[global::Cpp2ILInjected.Token(Token = "0x6004B6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A827C", Offset = "0x8A827C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCWasChatWithTracker), Member = "RegisterChatStartWith", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCWasChatWithTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static NetPacket SerializeChat(int npcNetId)
		{
			throw null;
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x0002D99E File Offset: 0x0002BB9E
		[global::Cpp2ILInjected.Token(Token = "0x6004B70")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A8314", Offset = "0x8A8314", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBestiaryCreditId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "SetKillCountDirectly", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasChatWithTracker), Member = "SetWasChatWithDirectly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasNearPlayerTracker), Member = "SetWasSeenDirectly", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			throw null;
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x0002D9A1 File Offset: 0x0002BBA1
		[global::Cpp2ILInjected.Token(Token = "0x6004B71")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A857C", Offset = "0x8A857C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = ".ctor", ReturnType = typeof(void))]
		public NetBestiaryModule()
		{
			throw null;
		}

		// Token: 0x02000A65 RID: 2661
		[global::Cpp2ILInjected.Token(Token = "0x20009F5")]
		private enum BestiaryUnlockType : byte
		{
			// Token: 0x04008E4A RID: 36426
			[global::Cpp2ILInjected.Token(Token = "0x40085B4")]
			Kill,
			// Token: 0x04008E4B RID: 36427
			[global::Cpp2ILInjected.Token(Token = "0x40085B5")]
			Sight,
			// Token: 0x04008E4C RID: 36428
			[global::Cpp2ILInjected.Token(Token = "0x40085B6")]
			Chat
		}
	}
}
