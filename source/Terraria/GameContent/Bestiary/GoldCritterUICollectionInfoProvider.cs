﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000952")]
	public class GoldCritterUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x60047C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C260", Offset = "0x81C260", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public GoldCritterUICollectionInfoProvider(int[] normalCritterPersistentId, string goldCritterPersistentId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C390", Offset = "0x81C390", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GoldCritterUICollectionInfoProvider), Member = "GetUnlockStateForCritter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(BestiaryEntryUnlockState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GoldCritterUICollectionInfoProvider), Member = "TryFindingOneGoldCritterThatIsAlreadyUnlocked", ReturnType = typeof(bool))]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C488", Offset = "0x81C488", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GoldCritterUICollectionInfoProvider), Member = "GetEntryUICollectionInfo", ReturnType = typeof(BestiaryUICollectionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GoldCritterUICollectionInfoProvider), Member = "GetUnlockStateForCritter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(BestiaryEntryUnlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool TryFindingOneGoldCritterThatIsAlreadyUnlocked()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C414", Offset = "0x81C414", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GoldCritterUICollectionInfoProvider), Member = "GetEntryUICollectionInfo", ReturnType = typeof(BestiaryUICollectionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GoldCritterUICollectionInfoProvider), Member = "TryFindingOneGoldCritterThatIsAlreadyUnlocked", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasNearPlayerTracker), Member = "GetWasNearbyBefore", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private BestiaryEntryUnlockState GetUnlockStateForCritter(string persistentId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008388")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string[] _normalCritterPersistentId;

		[global::Cpp2ILInjected.Token(Token = "0x4008389")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _goldCritterPersistentId;
	}
}
