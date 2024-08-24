using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000630 RID: 1584
	[global::Cpp2ILInjected.Token(Token = "0x2000953")]
	public class SalamanderShellyDadUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
	{
		// Token: 0x06003EB3 RID: 16051 RVA: 0x0002D31D File Offset: 0x0002B51D
		[global::Cpp2ILInjected.Token(Token = "0x60047C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C5C0", Offset = "0x81C5C0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonEnemyUICollectionInfoProvider), Member = "GetKillCountNeeded", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		public SalamanderShellyDadUICollectionInfoProvider(string persistentId)
		{
			throw null;
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x0002D320 File Offset: 0x0002B520
		[global::Cpp2ILInjected.Token(Token = "0x60047C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C5F4", Offset = "0x81C5F4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "GetKillCount", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SalamanderShellyDadUICollectionInfoProvider), Member = "IsIncludedInCurrentWorld", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SalamanderShellyDadUICollectionInfoProvider), Member = "GetLowestAvailableUnlockStateFromEntriesThatAreInWorld", MemberParameters = new object[] { typeof(BestiaryEntryUnlockState) }, ReturnType = typeof(BestiaryEntryUnlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			throw null;
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x0002D323 File Offset: 0x0002B523
		[global::Cpp2ILInjected.Token(Token = "0x60047C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C870", Offset = "0x81C870", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SalamanderShellyDadUICollectionInfoProvider), Member = "GetEntryUICollectionInfo", ReturnType = typeof(BestiaryUICollectionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "GetKillCount", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private BestiaryEntryUnlockState GetLowestAvailableUnlockStateFromEntriesThatAreInWorld(BestiaryEntryUnlockState unlockstatus)
		{
			throw null;
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x0002D326 File Offset: 0x0002B526
		[global::Cpp2ILInjected.Token(Token = "0x60047CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x81C6D8", Offset = "0x81C6D8", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SalamanderShellyDadUICollectionInfoProvider), Member = "GetEntryUICollectionInfo", ReturnType = typeof(BestiaryUICollectionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool IsIncludedInCurrentWorld()
		{
			throw null;
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0002D329 File Offset: 0x0002B529
		[global::Cpp2ILInjected.Token(Token = "0x60047CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x81CA78", Offset = "0x81CA78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x04006C6B RID: 27755
		[global::Cpp2ILInjected.Token(Token = "0x400838A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _persistentIdentifierToCheck;

		// Token: 0x04006C6C RID: 27756
		[global::Cpp2ILInjected.Token(Token = "0x400838B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _killCountNeededToFullyUnlock;
	}
}
