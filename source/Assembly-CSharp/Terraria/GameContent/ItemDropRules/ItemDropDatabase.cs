using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Bestiary;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005E0 RID: 1504
	[global::Cpp2ILInjected.Token(Token = "0x20008CC")]
	public class ItemDropDatabase
	{
		// Token: 0x06003CE2 RID: 15586 RVA: 0x0002CDF2 File Offset: 0x0002AFF2
		[global::Cpp2ILInjected.Token(Token = "0x6004551")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AF0D4", Offset = "0x7AF0D4", Length = "0x524")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<int, object>, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(KeyValuePair<int, object>) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<KeyValuePair<int, object>>),
			typeof(Func<KeyValuePair<int, object>, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public void PrepareNPCNetIDsByTypeDictionary()
		{
			throw null;
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x0002CDF5 File Offset: 0x0002AFF5
		[global::Cpp2ILInjected.Token(Token = "0x6004552")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AF5F8", Offset = "0x7AF5F8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Distinct", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void TrimDuplicateRulesForNegativeIDs()
		{
			throw null;
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x0002CDF8 File Offset: 0x0002AFF8
		[global::Cpp2ILInjected.Token(Token = "0x6004553")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AF6E0", Offset = "0x7AF6E0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropResolver), Member = "TryDropping", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabase), Member = "ExtractDropsForNPC", MemberParameters = new object[]
		{
			typeof(ItemDropDatabase),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public List<IItemDropRule> GetRulesForNPCID(int npcNetId, bool includeGlobalDrops = true)
		{
			throw null;
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x0002CDFB File Offset: 0x0002AFFB
		[global::Cpp2ILInjected.Token(Token = "0x6004554")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AF7CC", Offset = "0x7AF7CC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterGlobalRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterYoyos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public IItemDropRule RegisterToGlobal(IItemDropRule entry)
		{
			throw null;
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x0002CDFE File Offset: 0x0002AFFE
		[global::Cpp2ILInjected.Token(Token = "0x6004555")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AF870", Offset = "0x7AF870", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 404)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPCNetId", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IItemDropRule RegisterToNPC(int type, IItemDropRule entry)
		{
			throw null;
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x0002CE01 File Offset: 0x0002B001
		[global::Cpp2ILInjected.Token(Token = "0x6004556")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AF95C", Offset = "0x7AF95C", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void RegisterToNPCNetId(int npcNetId, IItemDropRule entry)
		{
			throw null;
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x0002CE04 File Offset: 0x0002B004
		[global::Cpp2ILInjected.Token(Token = "0x6004557")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AFAD0", Offset = "0x7AFAD0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBloodMoonFishing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterEclipse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterHardmodeDungeonDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_FrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Twins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOW", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterWeirdRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterFoodDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterHardmodeFeathers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterStatusImmunityItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterPirateDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMartianDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 174)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		public IItemDropRule RegisterToMultipleNPCs(IItemDropRule entry, params int[] npcNetIds)
		{
			throw null;
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x0002CE07 File Offset: 0x0002B007
		[global::Cpp2ILInjected.Token(Token = "0x6004558")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AFB30", Offset = "0x7AFB30", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterHardmodeDungeonDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IItemDropRule RegisterToMultipleNPCsNotRemixSeed(IItemDropRule entry, params int[] npcNetIds)
		{
			throw null;
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x0002CE0A File Offset: 0x0002B00A
		[global::Cpp2ILInjected.Token(Token = "0x6004559")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AFC1C", Offset = "0x7AFC1C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterHardmodeDungeonDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IItemDropRule RegisterToMultipleNPCsRemixSeed(IItemDropRule entry, params int[] npcNetIds)
		{
			throw null;
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x0002CE0D File Offset: 0x0002B00D
		[global::Cpp2ILInjected.Token(Token = "0x600455A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AFD08", Offset = "0x7AFD08", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RemoveFromNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void RemoveFromNPCNetId(int npcNetId, IItemDropRule entry)
		{
			throw null;
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x0002CE10 File Offset: 0x0002B010
		[global::Cpp2ILInjected.Token(Token = "0x600455B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AFDBC", Offset = "0x7AFDBC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RemoveFromMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RemoveFromNPCNetId", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IItemDropRule RemoveFromNPC(int type, IItemDropRule entry)
		{
			throw null;
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x0002CE13 File Offset: 0x0002B013
		[global::Cpp2ILInjected.Token(Token = "0x600455C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AFEA8", Offset = "0x7AFEA8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RemoveFromNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		public IItemDropRule RemoveFromMultipleNPCs(IItemDropRule entry, params int[] npcNetIds)
		{
			throw null;
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x0002CE16 File Offset: 0x0002B016
		[global::Cpp2ILInjected.Token(Token = "0x600455D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AFF08", Offset = "0x7AFF08", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "PrepareNPCNetIDsByTypeDictionary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterGlobalRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterFoodDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterWeirdRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterTownNPCDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterDD2EventDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterHardmodeFeathers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterYoyos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterStatusImmunityItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterPirateDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterMartianDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBossTrophies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterHardmodeDungeonDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterMimic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterEclipse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBloodMoonFishing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "TrimDuplicateRulesForNegativeIDs", ReturnType = typeof(void))]
		public void Populate()
		{
			throw null;
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x0002CE19 File Offset: 0x0002B019
		[global::Cpp2ILInjected.Token(Token = "0x600455E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B77B8", Offset = "0x7B77B8", Length = "0x458")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NormalvsExpert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void RegisterBloodMoonFishing()
		{
			throw null;
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x0002CE1C File Offset: 0x0002B01C
		[global::Cpp2ILInjected.Token(Token = "0x600455F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B7134", Offset = "0x7B7134", Length = "0x684")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ExpertGetsRerolls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "WithRerolls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void RegisterEclipse()
		{
			throw null;
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x0002CE1F File Offset: 0x0002B01F
		[global::Cpp2ILInjected.Token(Token = "0x6004560")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B6CF8", Offset = "0x7B6CF8", Length = "0x43C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnFailedRoll", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void RegisterMimic()
		{
			throw null;
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x0002CE22 File Offset: 0x0002B022
		[global::Cpp2ILInjected.Token(Token = "0x6004561")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B6974", Offset = "0x7B6974", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ExpertGetsRerolls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCsNotRemixSeed", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCsRemixSeed", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void RegisterHardmodeDungeonDrops()
		{
			throw null;
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x0002CE25 File Offset: 0x0002B025
		[global::Cpp2ILInjected.Token(Token = "0x6004562")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B68BC", Offset = "0x7B68BC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_BOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOW", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenBee", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Skeletron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_WOF", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_AncientCultist", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_MoonLord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_LunarTowers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Golem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_DukeFishron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_SkeletronPrime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_TheDestroyer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Twins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Plantera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_KingSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_FrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Deerclops", ReturnType = typeof(void))]
		private void RegisterBosses()
		{
			throw null;
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x0002CE28 File Offset: 0x0002B028
		[global::Cpp2ILInjected.Token(Token = "0x6004563")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BB508", Offset = "0x7BB508", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void RegisterBoss_QueenSlime()
		{
			throw null;
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x0002CE2B File Offset: 0x0002B02B
		[global::Cpp2ILInjected.Token(Token = "0x6004564")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BB26C", Offset = "0x7BB26C", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void RegisterBoss_HallowBoss()
		{
			throw null;
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x0002CE2E File Offset: 0x0002B02E
		[global::Cpp2ILInjected.Token(Token = "0x6004565")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BA98C", Offset = "0x7BA98C", Length = "0x8E0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneFromRulesRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnMasterAndExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		private void RegisterBoss_PumpkinMoon()
		{
			throw null;
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x0002CE31 File Offset: 0x0002B031
		[global::Cpp2ILInjected.Token(Token = "0x6004566")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BA4A0", Offset = "0x7BA4A0", Length = "0x4EC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnFailedRoll", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void RegisterBoss_FrostMoon()
		{
			throw null;
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x0002CE34 File Offset: 0x0002B034
		[global::Cpp2ILInjected.Token(Token = "0x6004567")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BA280", Offset = "0x7BA280", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnFailedRoll", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void RegisterBoss_KingSlime()
		{
			throw null;
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x0002CE37 File Offset: 0x0002B037
		[global::Cpp2ILInjected.Token(Token = "0x6004568")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B9E28", Offset = "0x7B9E28", Length = "0x458")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneFromRulesRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnFailedConditions", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void RegisterBoss_Plantera()
		{
			throw null;
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x0002CE3A File Offset: 0x0002B03A
		[global::Cpp2ILInjected.Token(Token = "0x6004569")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B98A0", Offset = "0x7B98A0", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void RegisterBoss_SkeletronPrime()
		{
			throw null;
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x0002CE3D File Offset: 0x0002B03D
		[global::Cpp2ILInjected.Token(Token = "0x600456A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B9A38", Offset = "0x7B9A38", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void RegisterBoss_TheDestroyer()
		{
			throw null;
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x0002CE40 File Offset: 0x0002B040
		[global::Cpp2ILInjected.Token(Token = "0x600456B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B9BD0", Offset = "0x7B9BD0", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void RegisterBoss_Twins()
		{
			throw null;
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x0002CE43 File Offset: 0x0002B043
		[global::Cpp2ILInjected.Token(Token = "0x600456C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B7C10", Offset = "0x7B7C10", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void RegisterBoss_EOC()
		{
			throw null;
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x0002CE46 File Offset: 0x0002B046
		[global::Cpp2ILInjected.Token(Token = "0x600456D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B7E7C", Offset = "0x7B7E7C", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnMasterAndExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void RegisterBoss_BOC()
		{
			throw null;
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x0002CE49 File Offset: 0x0002B049
		[global::Cpp2ILInjected.Token(Token = "0x600456E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B813C", Offset = "0x7B813C", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnMasterAndExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBagByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void RegisterBoss_EOW()
		{
			throw null;
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x0002CE4C File Offset: 0x0002B04C
		[global::Cpp2ILInjected.Token(Token = "0x600456F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BB724", Offset = "0x7BB724", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneFromRulesRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void RegisterBoss_Deerclops()
		{
			throw null;
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x0002CE4F File Offset: 0x0002B04F
		[global::Cpp2ILInjected.Token(Token = "0x6004570")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B848C", Offset = "0x7B848C", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "DropNothing", ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnFailedRoll", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void RegisterBoss_QueenBee()
		{
			throw null;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x0002CE52 File Offset: 0x0002B052
		[global::Cpp2ILInjected.Token(Token = "0x6004571")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B8794", Offset = "0x7B8794", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnFailedRoll", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void RegisterBoss_Skeletron()
		{
			throw null;
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x0002CE55 File Offset: 0x0002B055
		[global::Cpp2ILInjected.Token(Token = "0x6004572")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B88EC", Offset = "0x7B88EC", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void RegisterBoss_WOF()
		{
			throw null;
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x0002CE58 File Offset: 0x0002B058
		[global::Cpp2ILInjected.Token(Token = "0x6004573")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B8B24", Offset = "0x7B8B24", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		private void RegisterBoss_AncientCultist()
		{
			throw null;
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x0002CE5B File Offset: 0x0002B05B
		[global::Cpp2ILInjected.Token(Token = "0x6004574")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B8BBC", Offset = "0x7B8BBC", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FromOptionsWithoutRepeatsDropRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void RegisterBoss_MoonLord()
		{
			throw null;
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x0002CE5E File Offset: 0x0002B05E
		[global::Cpp2ILInjected.Token(Token = "0x6004575")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B8DF4", Offset = "0x7B8DF4", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropOneByOne), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(DropOneByOne.Parameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void RegisterBoss_LunarTowers()
		{
			throw null;
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x0002CE61 File Offset: 0x0002B061
		[global::Cpp2ILInjected.Token(Token = "0x6004576")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B9060", Offset = "0x7B9060", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void RegisterBoss_Betsy()
		{
			throw null;
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x0002CE64 File Offset: 0x0002B064
		[global::Cpp2ILInjected.Token(Token = "0x6004577")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B921C", Offset = "0x7B921C", Length = "0x39C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneFromRulesRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void RegisterBoss_Golem()
		{
			throw null;
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x0002CE67 File Offset: 0x0002B067
		[global::Cpp2ILInjected.Token(Token = "0x6004578")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B95B8", Offset = "0x7B95B8", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBosses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void RegisterBoss_DukeFishron()
		{
			throw null;
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x0002CE6A File Offset: 0x0002B06A
		[global::Cpp2ILInjected.Token(Token = "0x6004579")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B0CD8", Offset = "0x7B0CD8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NormalvsExpert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void RegisterWeirdRules()
		{
			throw null;
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x0002CE6D File Offset: 0x0002B06D
		[global::Cpp2ILInjected.Token(Token = "0x600457A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AFFA8", Offset = "0x7AFFA8", Length = "0x5B4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MechBossSpawnersDropRule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToGlobal", MemberParameters = new object[] { typeof(IItemDropRule) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlimeBodyItemDropRule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnFailedRoll", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		private void RegisterGlobalRules()
		{
			throw null;
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x0002CE70 File Offset: 0x0002B070
		[global::Cpp2ILInjected.Token(Token = "0x600457B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B055C", Offset = "0x7B055C", Length = "0x77C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Food", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private void RegisterFoodDrops()
		{
			throw null;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x0002CE73 File Offset: 0x0002B073
		[global::Cpp2ILInjected.Token(Token = "0x600457C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B0D54", Offset = "0x7B0D54", Length = "0x36C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void RegisterTownNPCDrops()
		{
			throw null;
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x0002CE76 File Offset: 0x0002B076
		[global::Cpp2ILInjected.Token(Token = "0x600457D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B10C0", Offset = "0x7B10C0", Length = "0x5B0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDropNotScalingWithLuck), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NormalvsExpertOneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NormalvsExpertNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void RegisterDD2EventDrops()
		{
			throw null;
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x0002CE79 File Offset: 0x0002B079
		[global::Cpp2ILInjected.Token(Token = "0x600457E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B5028", Offset = "0x7B5028", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void RegisterHardmodeFeathers()
		{
			throw null;
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x0002CE7C File Offset: 0x0002B07C
		[global::Cpp2ILInjected.Token(Token = "0x600457F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B525C", Offset = "0x7B525C", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToGlobal", MemberParameters = new object[] { typeof(IItemDropRule) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void RegisterYoyos()
		{
			throw null;
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x0002CE7F File Offset: 0x0002B07F
		[global::Cpp2ILInjected.Token(Token = "0x6004580")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B5490", Offset = "0x7B5490", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "StatusImmunityItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void RegisterStatusImmunityItems()
		{
			throw null;
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x0002CE82 File Offset: 0x0002B082
		[global::Cpp2ILInjected.Token(Token = "0x6004581")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B57EC", Offset = "0x7B57EC", Length = "0x830")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void RegisterPirateDrops()
		{
			throw null;
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x0002CE85 File Offset: 0x0002B085
		[global::Cpp2ILInjected.Token(Token = "0x6004582")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B601C", Offset = "0x7B601C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void RegisterBloodMoonFishingEnemies()
		{
			throw null;
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x0002CE88 File Offset: 0x0002B088
		[global::Cpp2ILInjected.Token(Token = "0x6004583")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B636C", Offset = "0x7B636C", Length = "0x550")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void RegisterBossTrophies()
		{
			throw null;
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x0002CE8B File Offset: 0x0002B08B
		[global::Cpp2ILInjected.Token(Token = "0x6004584")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B6020", Offset = "0x7B6020", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void RegisterMartianDrops()
		{
			throw null;
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x0002CE8E File Offset: 0x0002B08E
		[global::Cpp2ILInjected.Token(Token = "0x6004585")]
		[global::Cpp2ILInjected.Address(RVA = "0x7B1670", Offset = "0x7B1670", Length = "0x39B8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "Populate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IItemDropRule)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RegisterToMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NormalvsExpert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NormalvsExpertOneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeadingConditionRule), Member = ".ctor", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnSuccess", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "OnFailedRoll", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule),
			typeof(bool)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "RemoveFromMultipleNPCs", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "WithRerolls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 210)]
		private void RegisterMiscDrops()
		{
			throw null;
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x0002CE91 File Offset: 0x0002B091
		[global::Cpp2ILInjected.Token(Token = "0x6004586")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BB9F0", Offset = "0x7BB9F0", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public ItemDropDatabase()
		{
			throw null;
		}

		// Token: 0x04006BC6 RID: 27590
		[global::Cpp2ILInjected.Token(Token = "0x40081FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<IItemDropRule> _globalEntries;

		// Token: 0x04006BC7 RID: 27591
		[global::Cpp2ILInjected.Token(Token = "0x40081FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<int, List<IItemDropRule>> _entriesByNpcNetId;

		// Token: 0x04006BC8 RID: 27592
		[global::Cpp2ILInjected.Token(Token = "0x40081FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Dictionary<int, List<int>> _npcNetIdsByType;

		// Token: 0x04006BC9 RID: 27593
		[global::Cpp2ILInjected.Token(Token = "0x40081FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _masterModeDropRng;

		// Token: 0x020009F6 RID: 2550
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20008CD")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004F41 RID: 20289 RVA: 0x0002FFF3 File Offset: 0x0002E1F3
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004587")]
			[global::Cpp2ILInjected.Address(RVA = "0x7BBB04", Offset = "0x7BBB04", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004F42 RID: 20290 RVA: 0x0002FFF6 File Offset: 0x0002E1F6
			[global::Cpp2ILInjected.Token(Token = "0x6004588")]
			[global::Cpp2ILInjected.Address(RVA = "0x7BBB60", Offset = "0x7BBB60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004F43 RID: 20291 RVA: 0x0002FFF9 File Offset: 0x0002E1F9
			[global::Cpp2ILInjected.Token(Token = "0x6004589")]
			[global::Cpp2ILInjected.Address(RVA = "0x7BBB68", Offset = "0x7BBB68", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <PrepareNPCNetIDsByTypeDictionary>b__3_0(KeyValuePair<int, NPC> x)
			{
				throw null;
			}

			// Token: 0x04008CE8 RID: 36072
			[global::Cpp2ILInjected.Token(Token = "0x40081FF")]
			public static readonly ItemDropDatabase.<>c <>9;

			// Token: 0x04008CE9 RID: 36073
			[global::Cpp2ILInjected.Token(Token = "0x4008200")]
			public static Func<KeyValuePair<int, NPC>, bool> <>9__3_0;
		}
	}
}
