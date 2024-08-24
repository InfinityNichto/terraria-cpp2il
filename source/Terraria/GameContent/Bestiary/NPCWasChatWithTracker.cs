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
	// Token: 0x0200061C RID: 1564
	[global::Cpp2ILInjected.Token(Token = "0x200093F")]
	public class NPCWasChatWithTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x06003E70 RID: 15984 RVA: 0x0002D27E File Offset: 0x0002B47E
		[global::Cpp2ILInjected.Token(Token = "0x6004784")]
		[global::Cpp2ILInjected.Address(RVA = "0x81842C", Offset = "0x81842C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public NPCWasChatWithTracker()
		{
			throw null;
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x0002D281 File Offset: 0x0002B481
		[global::Cpp2ILInjected.Token(Token = "0x6004785")]
		[global::Cpp2ILInjected.Address(RVA = "0x818ED4", Offset = "0x818ED4", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_000_TransformBoundNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SetTalkNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBestiaryCreditId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetBestiaryModule), Member = "SerializeChat", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void RegisterChatStartWith(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x0002D284 File Offset: 0x0002B484
		[global::Cpp2ILInjected.Token(Token = "0x6004786")]
		[global::Cpp2ILInjected.Address(RVA = "0x8190A0", Offset = "0x8190A0", Length = "0xF4")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void SetWasChatWithDirectly(string persistentId)
		{
			throw null;
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x0002D287 File Offset: 0x0002B487
		[global::Cpp2ILInjected.Token(Token = "0x6004787")]
		[global::Cpp2ILInjected.Address(RVA = "0x819194", Offset = "0x819194", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBestiaryCreditId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetWasChatWith(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x0002D28A File Offset: 0x0002B48A
		[global::Cpp2ILInjected.Token(Token = "0x6004788")]
		[global::Cpp2ILInjected.Address(RVA = "0x8191FC", Offset = "0x8191FC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownNPCUICollectionInfoProvider), Member = "GetEntryUICollectionInfo", ReturnType = typeof(BestiaryUICollectionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetWasChatWith(string persistentId)
		{
			throw null;
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x0002D28D File Offset: 0x0002B48D
		[global::Cpp2ILInjected.Token(Token = "0x6004789")]
		[global::Cpp2ILInjected.Address(RVA = "0x8173E8", Offset = "0x8173E8", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x0002D290 File Offset: 0x0002B490
		[global::Cpp2ILInjected.Token(Token = "0x600478A")]
		[global::Cpp2ILInjected.Address(RVA = "0x81778C", Offset = "0x81778C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x0002D293 File Offset: 0x0002B493
		[global::Cpp2ILInjected.Token(Token = "0x600478B")]
		[global::Cpp2ILInjected.Address(RVA = "0x817978", Offset = "0x817978", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x0002D296 File Offset: 0x0002B496
		[global::Cpp2ILInjected.Token(Token = "0x600478C")]
		[global::Cpp2ILInjected.Address(RVA = "0x817ABC", Offset = "0x817ABC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x0002D299 File Offset: 0x0002B499
		[global::Cpp2ILInjected.Token(Token = "0x600478D")]
		[global::Cpp2ILInjected.Address(RVA = "0x817F80", Offset = "0x817F80", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetBestiaryModule), Member = "SerializeChat", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void OnPlayerJoining(int playerIndex)
		{
			throw null;
		}

		// Token: 0x04006C47 RID: 27719
		[global::Cpp2ILInjected.Token(Token = "0x4008366")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object _entryCreationLock;

		// Token: 0x04006C48 RID: 27720
		[global::Cpp2ILInjected.Token(Token = "0x4008367")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private HashSet<string> _chattedWithPlayer;
	}
}
