using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.NetModules;
using Terraria.Localization;

namespace Terraria.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20006A7")]
	public struct NetPacket
	{
		[global::Cpp2ILInjected.Token(Token = "0x170006D5")]
		public int Length
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60038A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x143D448", Offset = "0x143D448", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60038A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x143D450", Offset = "0x143D450", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006D6")]
		public BinaryWriter Writer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60038A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x143D458", Offset = "0x143D458", Length = "0xC")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "SetEnabledState", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "RequestUse", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "DebugCall", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "PushChange", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "DeserializeNetMessage", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "RequestUse", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "DeserializeNetMessage", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "DebugCall", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "AttemptPushingChange", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 61)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006D7")]
		public BinaryReader Reader
		{
			[global::Cpp2ILInjected.Token(Token = "0x60038A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x143B914", Offset = "0x143B914", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60038A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D464", Offset = "0x143D464", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferPool), Member = "Request", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CachedBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public NetPacket(ushort id, int size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60038A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x143BCA8", Offset = "0x143BCA8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedBuffer), Member = "Recycle", ReturnType = typeof(void))]
		public void Recycle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60038A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x143BBE4", Offset = "0x143BBE4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ShrinkToFit()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400794E")]
		private const int HEADER_SIZE = 5;

		[global::Cpp2ILInjected.Token(Token = "0x400794F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly ushort Id;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007950")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int <Length>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4007951")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly CachedBuffer Buffer;
	}
}
