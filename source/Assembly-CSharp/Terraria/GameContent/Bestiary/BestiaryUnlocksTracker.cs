using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000619 RID: 1561
	[global::Cpp2ILInjected.Token(Token = "0x200093C")]
	public class BestiaryUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x06003E53 RID: 15955 RVA: 0x0002D227 File Offset: 0x0002B427
		[global::Cpp2ILInjected.Token(Token = "0x6004767")]
		[global::Cpp2ILInjected.Address(RVA = "0x816F34", Offset = "0x816F34", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveBestiary", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasNearPlayerTracker), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasChatWithTracker), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		public void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x0002D22A File Offset: 0x0002B42A
		[global::Cpp2ILInjected.Token(Token = "0x6004768")]
		[global::Cpp2ILInjected.Address(RVA = "0x817600", Offset = "0x817600", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadBestiary", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasNearPlayerTracker), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasChatWithTracker), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x0002D22D File Offset: 0x0002B42D
		[global::Cpp2ILInjected.Token(Token = "0x6004769")]
		[global::Cpp2ILInjected.Address(RVA = "0x817828", Offset = "0x817828", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "ValidateWorld", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "ValidateWorld", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x0002D230 File Offset: 0x0002B430
		[global::Cpp2ILInjected.Token(Token = "0x600476A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8179CC", Offset = "0x8179CC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasNearPlayerTracker), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasChatWithTracker), Member = "Reset", ReturnType = typeof(void))]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x0002D233 File Offset: 0x0002B433
		[global::Cpp2ILInjected.Token(Token = "0x600476B")]
		[global::Cpp2ILInjected.Address(RVA = "0x817B04", Offset = "0x817B04", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasNearPlayerTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasChatWithTracker), Member = "OnPlayerJoining", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public void OnPlayerJoining(int playerIndex)
		{
			throw null;
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x0002D236 File Offset: 0x0002B436
		[global::Cpp2ILInjected.Token(Token = "0x600476C")]
		[global::Cpp2ILInjected.Address(RVA = "0x81818C", Offset = "0x81818C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadBestiaryForVersionsBefore210", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public void FillBasedOnVersionBefore210()
		{
			throw null;
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x0002D239 File Offset: 0x0002B439
		[global::Cpp2ILInjected.Token(Token = "0x600476D")]
		[global::Cpp2ILInjected.Address(RVA = "0x818190", Offset = "0x818190", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasNearPlayerTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasChatWithTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public BestiaryUnlocksTracker()
		{
			throw null;
		}

		// Token: 0x04006C3D RID: 27709
		[global::Cpp2ILInjected.Token(Token = "0x400835C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public NPCKillsTracker Kills;

		// Token: 0x04006C3E RID: 27710
		[global::Cpp2ILInjected.Token(Token = "0x400835D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public NPCWasNearPlayerTracker Sights;

		// Token: 0x04006C3F RID: 27711
		[global::Cpp2ILInjected.Token(Token = "0x400835E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public NPCWasChatWithTracker Chats;
	}
}
