using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005D3 RID: 1491
	[global::Cpp2ILInjected.Token(Token = "0x200087F")]
	public class DropBasedOnMasterMode : IItemDropRule, INestedItemDropRule
	{
		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x0002CD17 File Offset: 0x0002AF17
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x0002CD1A File Offset: 0x0002AF1A
		[global::Cpp2ILInjected.Token(Token = "0x170007D7")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004407")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A89F4", Offset = "0x7A89F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004408")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A89FC", Offset = "0x7A89FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x0002CD1D File Offset: 0x0002AF1D
		[global::Cpp2ILInjected.Token(Token = "0x6004409")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A69CC", Offset = "0x7A69CC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DropBasedOnMasterMode(IItemDropRule ruleForDefault, IItemDropRule ruleForMasterMode)
		{
			throw null;
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x0002CD20 File Offset: 0x0002AF20
		[global::Cpp2ILInjected.Token(Token = "0x600440A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8A04", Offset = "0x7A8A04", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x0002CD23 File Offset: 0x0002AF23
		[global::Cpp2ILInjected.Token(Token = "0x600440B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8B38", Offset = "0x7A8B38", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x0002CD26 File Offset: 0x0002AF26
		[global::Cpp2ILInjected.Token(Token = "0x600440C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8B40", Offset = "0x7A8B40", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			throw null;
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x0002CD29 File Offset: 0x0002AF29
		[global::Cpp2ILInjected.Token(Token = "0x600440D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8B94", Offset = "0x7A8B94", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "With", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(DropRateInfoChainFeed))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsMasterMode), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "AddCondition", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.NotMasterMode), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<IItemDropRuleChainAttempt>),
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x04006BA7 RID: 27559
		[global::Cpp2ILInjected.Token(Token = "0x40081C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public IItemDropRule ruleForDefault;

		// Token: 0x04006BA8 RID: 27560
		[global::Cpp2ILInjected.Token(Token = "0x40081CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IItemDropRule ruleForMasterMode;

		// Token: 0x04006BA9 RID: 27561
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
