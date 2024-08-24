using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.NetModules;
using Terraria.Net;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200061B RID: 1563
	[global::Cpp2ILInjected.Token(Token = "0x200093E")]
	public class NPCWasNearPlayerTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x06003E64 RID: 15972 RVA: 0x0002D25A File Offset: 0x0002B45A
		[global::Cpp2ILInjected.Token(Token = "0x6004778")]
		[global::Cpp2ILInjected.Address(RVA = "0x8188F0", Offset = "0x8188F0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void PrepareSamplesBasedOptimizations()
		{
			throw null;
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x0002D25D File Offset: 0x0002B45D
		[global::Cpp2ILInjected.Token(Token = "0x6004779")]
		[global::Cpp2ILInjected.Address(RVA = "0x8182F0", Offset = "0x8182F0", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public NPCWasNearPlayerTracker()
		{
			throw null;
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x0002D260 File Offset: 0x0002B460
		[global::Cpp2ILInjected.Token(Token = "0x600477A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8188F4", Offset = "0x8188F4", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCWasNearPlayerTracker), Member = "ScanWorldForFinds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetBestiaryModule), Member = "SerializeSight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void RegisterWasNearby(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x0002D263 File Offset: 0x0002B463
		[global::Cpp2ILInjected.Token(Token = "0x600477B")]
		[global::Cpp2ILInjected.Address(RVA = "0x818AC0", Offset = "0x818AC0", Length = "0xF4")]
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
		public void SetWasSeenDirectly(string persistentId)
		{
			throw null;
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x0002D266 File Offset: 0x0002B466
		[global::Cpp2ILInjected.Token(Token = "0x600477C")]
		[global::Cpp2ILInjected.Address(RVA = "0x818BB4", Offset = "0x818BB4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBestiaryCreditId", ReturnType = typeof(string))]
		public bool GetWasNearbyBefore(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x0002D269 File Offset: 0x0002B469
		[global::Cpp2ILInjected.Token(Token = "0x600477D")]
		[global::Cpp2ILInjected.Address(RVA = "0x818BD8", Offset = "0x818BD8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CritterUICollectionInfoProvider), Member = "GetEntryUICollectionInfo", ReturnType = typeof(BestiaryUICollectionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GoldCritterUICollectionInfoProvider), Member = "GetUnlockStateForCritter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(BestiaryEntryUnlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetWasNearbyBefore(string persistentIdentifier)
		{
			throw null;
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x0002D26C File Offset: 0x0002B46C
		[global::Cpp2ILInjected.Token(Token = "0x600477E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8171D0", Offset = "0x8171D0", Length = "0x218")]
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

		// Token: 0x06003E6B RID: 15979 RVA: 0x0002D26F File Offset: 0x0002B46F
		[global::Cpp2ILInjected.Token(Token = "0x600477F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8176F0", Offset = "0x8176F0", Length = "0x9C")]
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

		// Token: 0x06003E6C RID: 15980 RVA: 0x0002D272 File Offset: 0x0002B472
		[global::Cpp2ILInjected.Token(Token = "0x6004780")]
		[global::Cpp2ILInjected.Address(RVA = "0x817924", Offset = "0x817924", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x0002D275 File Offset: 0x0002B475
		[global::Cpp2ILInjected.Token(Token = "0x6004781")]
		[global::Cpp2ILInjected.Address(RVA = "0x817A38", Offset = "0x817A38", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryUnlocksTracker), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x0002D278 File Offset: 0x0002B478
		[global::Cpp2ILInjected.Token(Token = "0x6004782")]
		[global::Cpp2ILInjected.Address(RVA = "0x818C30", Offset = "0x818C30", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_HitboxForBestiaryNearbyCheck", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_CountsAsACritter", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasNearPlayerTracker), Member = "RegisterWasNearby", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void ScanWorldForFinds()
		{
			throw null;
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x0002D27B File Offset: 0x0002B47B
		[global::Cpp2ILInjected.Token(Token = "0x6004783")]
		[global::Cpp2ILInjected.Address(RVA = "0x817D74", Offset = "0x817D74", Length = "0x20C")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetBestiaryModule), Member = "SerializeSight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
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

		// Token: 0x04006C43 RID: 27715
		[global::Cpp2ILInjected.Token(Token = "0x4008362")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object _entryCreationLock;

		// Token: 0x04006C44 RID: 27716
		[global::Cpp2ILInjected.Token(Token = "0x4008363")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private HashSet<string> _wasNearPlayer;

		// Token: 0x04006C45 RID: 27717
		[global::Cpp2ILInjected.Token(Token = "0x4008364")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<Rectangle> _playerHitboxesForBestiary;

		// Token: 0x04006C46 RID: 27718
		[global::Cpp2ILInjected.Token(Token = "0x4008365")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<int> _wasSeenNearPlayerByNetId;
	}
}
