using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;
using Terraria.GameContent;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.NetModules;
using Terraria.Localization;

namespace Terraria.Net
{
	// Token: 0x02000499 RID: 1177
	[global::Cpp2ILInjected.Token(Token = "0x20006A6")]
	public abstract class NetModule
	{
		// Token: 0x0600335A RID: 13146
		[global::Cpp2ILInjected.Token(Token = "0x60038A0")]
		public abstract bool Deserialize(BinaryReader reader, int userId);

		// Token: 0x0600335B RID: 13147 RVA: 0x0002B2E6 File Offset: 0x000294E6
		[global::Cpp2ILInjected.Token(Token = "0x60038A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593BBC", Offset = "0x1593BBC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "Serialize", MemberParameters = new object[] { typeof(HashSet<int>) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = "SerializeForPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetAmbienceModule), Member = "SerializeSkyEntitySpawn", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetBestiaryModule), Member = "SerializeKillCount", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetBestiaryModule), Member = "SerializeSight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetBestiaryModule), Member = "SerializeChat", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativeUnlocksModule), Member = "SerializeItemSacrifice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativePowersModule), Member = "PreparePacket", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativeUnlocksPlayerReportModule), Member = "SerializeSacrificeRequest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativePowerPermissionsModule), Member = "SerializeCurrentPowerPermissionLevel", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetParticlesModule), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetPingModule), Member = "Serialize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTeleportPylonModule), Member = "SerializePylonWasAddedOrRemoved", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(NetTeleportPylonModule.SubPacketType)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTeleportPylonModule), Member = "SerializeUseRequest", MemberParameters = new object[] { typeof(TeleportPylonInfo) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "SerializeClientMessage", MemberParameters = new object[] { typeof(ChatMessage) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "SerializeServerMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected static NetPacket CreatePacket<T>(int maxSize) where T : NetModule
		{
			throw null;
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x0002B2E9 File Offset: 0x000294E9
		[global::Cpp2ILInjected.Token(Token = "0x60038A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D440", Offset = "0x143D440", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetLiquidModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetAmbienceModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetBestiaryModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativeUnlocksModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativePowersModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativeUnlocksPlayerReportModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativePowerPermissionsModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetParticlesModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetPingModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTeleportPylonModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected NetModule()
		{
			throw null;
		}
	}
}
