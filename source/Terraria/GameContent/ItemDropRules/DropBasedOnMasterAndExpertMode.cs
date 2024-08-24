using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005D4 RID: 1492
	[global::Cpp2ILInjected.Token(Token = "0x2000880")]
	public class DropBasedOnMasterAndExpertMode : IItemDropRule, INestedItemDropRule
	{
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06003CA0 RID: 15520 RVA: 0x0002CD2C File Offset: 0x0002AF2C
		// (set) Token: 0x06003CA1 RID: 15521 RVA: 0x0002CD2F File Offset: 0x0002AF2F
		[global::Cpp2ILInjected.Token(Token = "0x170007D8")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600440E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A8D90", Offset = "0x7A8D90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600440F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A8D98", Offset = "0x7A8D98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x0002CD32 File Offset: 0x0002AF32
		[global::Cpp2ILInjected.Token(Token = "0x6004410")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8DA0", Offset = "0x7A8DA0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_BOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOW", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DropBasedOnMasterAndExpertMode(IItemDropRule ruleForDefault, IItemDropRule ruleForExpertMode, IItemDropRule ruleForMasterMode)
		{
			throw null;
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x0002CD35 File Offset: 0x0002AF35
		[global::Cpp2ILInjected.Token(Token = "0x6004411")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8E3C", Offset = "0x7A8E3C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x0002CD38 File Offset: 0x0002AF38
		[global::Cpp2ILInjected.Token(Token = "0x6004412")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8FDC", Offset = "0x7A8FDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x0002CD3B File Offset: 0x0002AF3B
		[global::Cpp2ILInjected.Token(Token = "0x6004413")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8FE4", Offset = "0x7A8FE4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			throw null;
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x0002CD3E File Offset: 0x0002AF3E
		[global::Cpp2ILInjected.Token(Token = "0x6004414")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9050", Offset = "0x7A9050", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "With", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(DropRateInfoChainFeed))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsMasterMode), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "AddCondition", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.NotMasterMode), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsExpert), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.NotExpert), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<IItemDropRuleChainAttempt>),
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x04006BAA RID: 27562
		[global::Cpp2ILInjected.Token(Token = "0x40081CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public IItemDropRule ruleForDefault;

		// Token: 0x04006BAB RID: 27563
		[global::Cpp2ILInjected.Token(Token = "0x40081CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IItemDropRule ruleForExpertmode;

		// Token: 0x04006BAC RID: 27564
		[global::Cpp2ILInjected.Token(Token = "0x40081CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public IItemDropRule ruleForMasterMode;

		// Token: 0x04006BAD RID: 27565
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
