using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000950")]
	public class CommonEnemyUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x60047BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x819BE8", Offset = "0x819BE8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonEnemyUICollectionInfoProvider), Member = "GetKillCountNeeded", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		public CommonEnemyUICollectionInfoProvider(string persistentId, bool quickUnlock)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x81BD6C", Offset = "0x81BD6C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "Enemy", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonEnemyUICollectionInfoProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SalamanderShellyDadUICollectionInfoProvider), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "BannerID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NPCtoBanner", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "BannerToItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static int GetKillCountNeeded(string persistentId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x81BEFC", Offset = "0x81BEFC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "GetKillCount", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x81BFDC", Offset = "0x81BFDC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public BestiaryEntryUnlockState GetUnlockStateByKillCount(int killCount, bool quickUnlock)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C04C", Offset = "0x81C04C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BestiaryEntryUnlockState GetUnlockStateByKillCount(int killCount, bool quickUnlock, int fullKillCountNeeded)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C0B8", Offset = "0x81C0B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008383")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _persistentIdentifierToCheck;

		[global::Cpp2ILInjected.Token(Token = "0x4008384")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _quickUnlock;

		[global::Cpp2ILInjected.Token(Token = "0x4008385")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _killCountNeededToFullyUnlock;
	}
}
