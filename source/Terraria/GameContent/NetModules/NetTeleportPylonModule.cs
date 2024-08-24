using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000675 RID: 1653
	[global::Cpp2ILInjected.Token(Token = "0x20009FC")]
	public class NetTeleportPylonModule : NetModule
	{
		// Token: 0x06004101 RID: 16641 RVA: 0x0002D9E0 File Offset: 0x0002BBE0
		[global::Cpp2ILInjected.Token(Token = "0x6004B86")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A9508", Offset = "0x8A9508", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "UpdatePylonsListAndBroadcastChanges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static NetPacket SerializePylonWasAddedOrRemoved(TeleportPylonInfo info, NetTeleportPylonModule.SubPacketType packetType)
		{
			throw null;
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x0002D9E3 File Offset: 0x0002BBE3
		[global::Cpp2ILInjected.Token(Token = "0x6004B87")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A95F8", Offset = "0x8A95F8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "RequestTeleportation", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static NetPacket SerializeUseRequest(TeleportPylonInfo info)
		{
			throw null;
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x0002D9E6 File Offset: 0x0002BBE6
		[global::Cpp2ILInjected.Token(Token = "0x6004B88")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A96DC", Offset = "0x8A96DC", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "AddForClient", MemberParameters = new object[] { typeof(TeleportPylonInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "HandleTeleportRequest", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "RemoveForClient", MemberParameters = new object[] { typeof(TeleportPylonInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			throw null;
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x0002D9E9 File Offset: 0x0002BBE9
		[global::Cpp2ILInjected.Token(Token = "0x6004B89")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A9960", Offset = "0x8A9960", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = ".ctor", ReturnType = typeof(void))]
		public NetTeleportPylonModule()
		{
			throw null;
		}

		// Token: 0x02000A66 RID: 2662
		[global::Cpp2ILInjected.Token(Token = "0x20009FD")]
		public enum SubPacketType : byte
		{
			// Token: 0x04008E4E RID: 36430
			[global::Cpp2ILInjected.Token(Token = "0x40085BC")]
			PylonWasAdded,
			// Token: 0x04008E4F RID: 36431
			[global::Cpp2ILInjected.Token(Token = "0x40085BD")]
			PylonWasRemoved,
			// Token: 0x04008E50 RID: 36432
			[global::Cpp2ILInjected.Token(Token = "0x40085BE")]
			PlayerRequestsTeleport
		}
	}
}
