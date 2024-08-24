using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.NetModules;
using Terraria.Net;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200061A RID: 1562
	[global::Cpp2ILInjected.Token(Token = "0x200093D")]
	public class NPCKillsTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x06003E5A RID: 15962 RVA: 0x0002D23C File Offset: 0x0002B43C
		[global::Cpp2ILInjected.Token(Token = "0x600476E")]
		[global::Cpp2ILInjected.Address(RVA = "0x818244", Offset = "0x818244", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public NPCKillsTracker()
		{
			throw null;
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x0002D23F File Offset: 0x0002B43F
		[global::Cpp2ILInjected.Token(Token = "0x600476F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8184D8", Offset = "0x8184D8", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "CheckLavaDeath", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_003_Fighters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "NPCLoot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Spawn", MemberParameters = new object[] { typeof(PlayerSpawnContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseTorchGodsFavor", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBestiaryCreditId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetBestiaryModule), Member = "SerializeKillCount", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void RegisterKill(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x0002D242 File Offset: 0x0002B442
		[global::Cpp2ILInjected.Token(Token = "0x6004770")]
		[global::Cpp2ILInjected.Address(RVA = "0x818710", Offset = "0x818710", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBestiaryCreditId", ReturnType = typeof(string))]
		public int GetKillCount(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x0002D245 File Offset: 0x0002B445
		[global::Cpp2ILInjected.Token(Token = "0x6004771")]
		[global::Cpp2ILInjected.Address(RVA = "0x81879C", Offset = "0x81879C", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetBestiaryModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void SetKillCountDirectly(string persistentId, int killCount)
		{
			throw null;
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x0002D248 File Offset: 0x0002B448
		[global::Cpp2ILInjected.Token(Token = "0x6004772")]
		[global::Cpp2ILInjected.Address(RVA = "0x818734", Offset = "0x818734", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonEnemyUICollectionInfoProvider), Member = "GetEntryUICollectionInfo", ReturnType = typeof(BestiaryUICollectionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SalamanderShellyDadUICollectionInfoProvider), Member = "GetEntryUICollectionInfo", ReturnType = typeof(BestiaryUICollectionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SalamanderShellyDadUICollectionInfoProvider), Member = "GetLowestAvailableUnlockStateFromEntriesThatAreInWorld", MemberParameters = new object[] { typeof(BestiaryEntryUnlockState) }, ReturnType = typeof(BestiaryEntryUnlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKillCounterInfoElement), Member = "GetKillCount", ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int GetKillCount(string persistentId)
		{
			throw null;
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x0002D24B File Offset: 0x0002B44B
		[global::Cpp2ILInjected.Token(Token = "0x6004773")]
		[global::Cpp2ILInjected.Address(RVA = "0x816F6C", Offset = "0x816F6C", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x0002D24E File Offset: 0x0002B44E
		[global::Cpp2ILInjected.Token(Token = "0x6004774")]
		[global::Cpp2ILInjected.Address(RVA = "0x817638", Offset = "0x817638", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x0002D251 File Offset: 0x0002B451
		[global::Cpp2ILInjected.Token(Token = "0x6004775")]
		[global::Cpp2ILInjected.Address(RVA = "0x8178BC", Offset = "0x8178BC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = "ValidateWorld", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x0002D254 File Offset: 0x0002B454
		[global::Cpp2ILInjected.Token(Token = "0x6004776")]
		[global::Cpp2ILInjected.Address(RVA = "0x8179F0", Offset = "0x8179F0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x0002D257 File Offset: 0x0002B457
		[global::Cpp2ILInjected.Token(Token = "0x6004777")]
		[global::Cpp2ILInjected.Address(RVA = "0x817B3C", Offset = "0x817B3C", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetBestiaryModule), Member = "SerializeKillCount", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void OnPlayerJoining(int playerIndex)
		{
			throw null;
		}

		// Token: 0x04006C40 RID: 27712
		[global::Cpp2ILInjected.Token(Token = "0x400835F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object _entryCreationLock;

		// Token: 0x04006C41 RID: 27713
		[global::Cpp2ILInjected.Token(Token = "0x4008360")]
		public const int POSITIVE_KILL_COUNT_CAP = 999999999;

		// Token: 0x04006C42 RID: 27714
		[global::Cpp2ILInjected.Token(Token = "0x4008361")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<string, int> _killCountsByNpcId;
	}
}
