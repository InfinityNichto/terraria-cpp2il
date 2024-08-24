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
	// Token: 0x02000320 RID: 800
	[global::Cpp2ILInjected.Token(Token = "0x2000420")]
	public class RemoteClient
	{
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x00028A0C File Offset: 0x00026C0C
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

		// Token: 0x06002540 RID: 9536 RVA: 0x00028A0F File Offset: 0x00026C0F
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

		// Token: 0x06002541 RID: 9537 RVA: 0x00028A12 File Offset: 0x00026C12
		[global::Cpp2ILInjected.Token(Token = "0x600273E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C44E0", Offset = "0x10C44E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SpamClear()
		{
			throw null;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00028A15 File Offset: 0x00026C15
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

		// Token: 0x06002543 RID: 9539 RVA: 0x00028A18 File Offset: 0x00026C18
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

		// Token: 0x06002544 RID: 9540 RVA: 0x00028A1B File Offset: 0x00026C1B
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

		// Token: 0x06002545 RID: 9541 RVA: 0x00028A1E File Offset: 0x00026C1E
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

		// Token: 0x06002546 RID: 9542 RVA: 0x00028A21 File Offset: 0x00026C21
		[global::Cpp2ILInjected.Token(Token = "0x6002743")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C4A80", Offset = "0x10C4A80", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ServerWriteCallBack(object state)
		{
			throw null;
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00028A24 File Offset: 0x00026C24
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

		// Token: 0x06002548 RID: 9544 RVA: 0x00028A27 File Offset: 0x00026C27
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

		// Token: 0x04002C58 RID: 11352
		[global::Cpp2ILInjected.Token(Token = "0x4003374")]
		private static List<Point> _pendingSectionFraming;

		// Token: 0x04002C59 RID: 11353
		[global::Cpp2ILInjected.Token(Token = "0x4003375")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int Id;

		// Token: 0x04002C5A RID: 11354
		[global::Cpp2ILInjected.Token(Token = "0x4003376")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x04002C5B RID: 11355
		[global::Cpp2ILInjected.Token(Token = "0x4003377")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool LocalHost;

		// Token: 0x04002C5C RID: 11356
		[global::Cpp2ILInjected.Token(Token = "0x4003378")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		public bool Connected;

		// Token: 0x04002C5D RID: 11357
		[global::Cpp2ILInjected.Token(Token = "0x4003379")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		public bool IsActive;

		// Token: 0x04002C5E RID: 11358
		[global::Cpp2ILInjected.Token(Token = "0x400337A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x23")]
		public bool PendingTermination;

		// Token: 0x04002C5F RID: 11359
		[global::Cpp2ILInjected.Token(Token = "0x400337B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public bool IsAnnouncementCompleted;

		// Token: 0x04002C60 RID: 11360
		[global::Cpp2ILInjected.Token(Token = "0x400337C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int State;

		// Token: 0x04002C61 RID: 11361
		[global::Cpp2ILInjected.Token(Token = "0x400337D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int TimeOutTimer;

		// Token: 0x04002C62 RID: 11362
		[global::Cpp2ILInjected.Token(Token = "0x400337E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public string StatusText;

		// Token: 0x04002C63 RID: 11363
		[global::Cpp2ILInjected.Token(Token = "0x400337F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public string StatusText2;

		// Token: 0x04002C64 RID: 11364
		[global::Cpp2ILInjected.Token(Token = "0x4003380")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int StatusCount;

		// Token: 0x04002C65 RID: 11365
		[global::Cpp2ILInjected.Token(Token = "0x4003381")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int StatusMax;

		// Token: 0x04002C66 RID: 11366
		[global::Cpp2ILInjected.Token(Token = "0x4003382")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public bool[,] TileSections;

		// Token: 0x04002C67 RID: 11367
		[global::Cpp2ILInjected.Token(Token = "0x4003383")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float SpamProjectile;

		// Token: 0x04002C68 RID: 11368
		[global::Cpp2ILInjected.Token(Token = "0x4003384")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public float SpamAddBlock;

		// Token: 0x04002C69 RID: 11369
		[global::Cpp2ILInjected.Token(Token = "0x4003385")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float SpamDeleteBlock;

		// Token: 0x04002C6A RID: 11370
		[global::Cpp2ILInjected.Token(Token = "0x4003386")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public float SpamWater;

		// Token: 0x04002C6B RID: 11371
		[global::Cpp2ILInjected.Token(Token = "0x4003387")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public float SpamProjectileMax;

		// Token: 0x04002C6C RID: 11372
		[global::Cpp2ILInjected.Token(Token = "0x4003388")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public float SpamAddBlockMax;

		// Token: 0x04002C6D RID: 11373
		[global::Cpp2ILInjected.Token(Token = "0x4003389")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public float SpamDeleteBlockMax;

		// Token: 0x04002C6E RID: 11374
		[global::Cpp2ILInjected.Token(Token = "0x400338A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public float SpamWaterMax;
	}
}
