using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005E1 RID: 1505
	[global::Cpp2ILInjected.Token(Token = "0x20008CE")]
	public class ItemDropResolver
	{
		// Token: 0x06003D18 RID: 15640 RVA: 0x0002CE94 File Offset: 0x0002B094
		[global::Cpp2ILInjected.Token(Token = "0x600458A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BBBA4", Offset = "0x7BBBA4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemDropResolver(ItemDropDatabase database)
		{
			throw null;
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x0002CE97 File Offset: 0x0002B097
		[global::Cpp2ILInjected.Token(Token = "0x600458B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BBBCC", Offset = "0x7BBBCC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "NPCLoot_DropItems", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropDatabase), Member = "GetRulesForNPCID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(List<IItemDropRule>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropResolver), Member = "ResolveRule", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(DropAttemptInfo)
		}, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void TryDropping(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x0002CE9A File Offset: 0x0002B09A
		[global::Cpp2ILInjected.Token(Token = "0x600458C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BBC90", Offset = "0x7BBC90", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropResolver), Member = "TryDropping", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropResolver), Member = "ResolveRuleChains", MemberParameters = new object[]
		{
			typeof(ref DropAttemptInfo),
			typeof(ref ItemDropAttemptResult),
			typeof(List<IItemDropRuleChainAttempt>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRuleResolveAction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropResolver), Member = "ResolveRuleChains", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(DropAttemptInfo),
			typeof(ItemDropAttemptResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private ItemDropAttemptResult ResolveRule(IItemDropRule rule, DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x0002CE9D File Offset: 0x0002B09D
		[global::Cpp2ILInjected.Token(Token = "0x600458D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BBF04", Offset = "0x7BBF04", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropResolver), Member = "ResolveRule", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(DropAttemptInfo)
		}, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropResolver), Member = "ResolveRuleChains", MemberParameters = new object[]
		{
			typeof(ref DropAttemptInfo),
			typeof(ref ItemDropAttemptResult),
			typeof(List<IItemDropRuleChainAttempt>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ResolveRuleChains(IItemDropRule rule, DropAttemptInfo info, ItemDropAttemptResult parentResult)
		{
			throw null;
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x0002CEA0 File Offset: 0x0002B0A0
		[global::Cpp2ILInjected.Token(Token = "0x600458E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7BC0FC", Offset = "0x7BC0FC", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropResolver), Member = "ResolveRuleChains", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(DropAttemptInfo),
			typeof(ItemDropAttemptResult)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropResolver), Member = "ResolveRule", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(DropAttemptInfo)
		}, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ResolveRuleChains(ref DropAttemptInfo info, ref ItemDropAttemptResult parentResult, List<IItemDropRuleChainAttempt> ruleChains)
		{
			throw null;
		}

		// Token: 0x04006BCA RID: 27594
		[global::Cpp2ILInjected.Token(Token = "0x4008201")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ItemDropDatabase _database;
	}
}
