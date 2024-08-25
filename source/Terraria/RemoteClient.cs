using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.Net;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x2000420")]
	public class RemoteClient
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000559")]
		public bool HasAnySection
		{
			[global::Cpp2ILInjected.Token(Token = "0x600273C")]
			[global::Cpp2ILInjected.Address(RVA = "0x10C403C", Offset = "0x10C403C", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
			{
				typeof(NetPacket),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
			{
				typeof(NetPacket),
				typeof(NetManager.BroadcastCondition),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600273D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C410C", Offset = "0x10C410C", Length = "0x3D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateServer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "BootPlayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NetworkText)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public void SpamUpdate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600273E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C44E0", Offset = "0x10C44E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SpamClear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600273F")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C44E8", Offset = "0x10C44E8", Length = "0x3AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateServer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "MagicConch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Shellphone_Spawn", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DemonConch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TeleportationPotion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_149_GolfBall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "Teleport", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "SyncPortalSections", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "HandleTeleportRequest", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "ToNetworkText", ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendSection", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void CheckSection(int playerIndex, Vector2 position, int fluff = 1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002740")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C4894", Offset = "0x10C4894", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool SectionRange(int size, int firstX, int firstY)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002741")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C49C0", Offset = "0x10C49C0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemoteClient), Member = "Reset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void ResetSections()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002742")]
		[global::Cpp2ILInjected.Address(RVA = "0x10BD2D4", Offset = "0x10BD2D4", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "OnConnectionAccepted", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ServerLoopUpdateFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ServerLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemoteClient), Member = "ResetSections", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageBuffer), Member = "Reset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Reset(bool setupActive = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002743")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C4A80", Offset = "0x10C4A80", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ServerWriteCallBack(object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002744")]
		[global::Cpp2ILInjected.Address(RVA = "0x10BFA40", Offset = "0x10BFA40", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ServerLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public RemoteClient()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002745")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C4B0C", Offset = "0x10C4B0C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static RemoteClient()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003374")]
		private static List<Point> _pendingSectionFraming;

		[global::Cpp2ILInjected.Token(Token = "0x4003375")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int Id;

		[global::Cpp2ILInjected.Token(Token = "0x4003376")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string Name;

		[global::Cpp2ILInjected.Token(Token = "0x4003377")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool LocalHost;

		[global::Cpp2ILInjected.Token(Token = "0x4003378")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		public bool Connected;

		[global::Cpp2ILInjected.Token(Token = "0x4003379")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		public bool IsActive;

		[global::Cpp2ILInjected.Token(Token = "0x400337A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x23")]
		public bool PendingTermination;

		[global::Cpp2ILInjected.Token(Token = "0x400337B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public bool IsAnnouncementCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x400337C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int State;

		[global::Cpp2ILInjected.Token(Token = "0x400337D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int TimeOutTimer;

		[global::Cpp2ILInjected.Token(Token = "0x400337E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public string StatusText;

		[global::Cpp2ILInjected.Token(Token = "0x400337F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public string StatusText2;

		[global::Cpp2ILInjected.Token(Token = "0x4003380")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int StatusCount;

		[global::Cpp2ILInjected.Token(Token = "0x4003381")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int StatusMax;

		[global::Cpp2ILInjected.Token(Token = "0x4003382")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public bool[,] TileSections;

		[global::Cpp2ILInjected.Token(Token = "0x4003383")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float SpamProjectile;

		[global::Cpp2ILInjected.Token(Token = "0x4003384")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public float SpamAddBlock;

		[global::Cpp2ILInjected.Token(Token = "0x4003385")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float SpamDeleteBlock;

		[global::Cpp2ILInjected.Token(Token = "0x4003386")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public float SpamWater;

		[global::Cpp2ILInjected.Token(Token = "0x4003387")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public float SpamProjectileMax;

		[global::Cpp2ILInjected.Token(Token = "0x4003388")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public float SpamAddBlockMax;

		[global::Cpp2ILInjected.Token(Token = "0x4003389")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public float SpamDeleteBlockMax;

		[global::Cpp2ILInjected.Token(Token = "0x400338A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public float SpamWaterMax;
	}
}
