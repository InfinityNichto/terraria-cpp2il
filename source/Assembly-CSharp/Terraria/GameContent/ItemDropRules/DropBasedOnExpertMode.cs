using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005D2 RID: 1490
	[global::Cpp2ILInjected.Token(Token = "0x200087E")]
	public class DropBasedOnExpertMode : IItemDropRule, INestedItemDropRule
	{
		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06003C92 RID: 15506 RVA: 0x0002CD02 File Offset: 0x0002AF02
		// (set) Token: 0x06003C93 RID: 15507 RVA: 0x0002CD05 File Offset: 0x0002AF05
		[global::Cpp2ILInjected.Token(Token = "0x170007D6")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004400")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A8658", Offset = "0x7A8658", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004401")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A8660", Offset = "0x7A8660", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x0002CD08 File Offset: 0x0002AF08
		[global::Cpp2ILInjected.Token(Token = "0x6004402")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6540", Offset = "0x7A6540", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "BossBagByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "ExpertGetsRerolls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "NormalvsExpert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "NormalvsExpertNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "NormalvsExpertOneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "NormalvsExpertOneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterEclipse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenBee", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_LunarTowers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterDD2EventDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DropBasedOnExpertMode(IItemDropRule ruleForNormalMode, IItemDropRule ruleForExpertMode)
		{
			throw null;
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x0002CD0B File Offset: 0x0002AF0B
		[global::Cpp2ILInjected.Token(Token = "0x6004403")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8668", Offset = "0x7A8668", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x0002CD0E File Offset: 0x0002AF0E
		[global::Cpp2ILInjected.Token(Token = "0x6004404")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A879C", Offset = "0x7A879C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x0002CD11 File Offset: 0x0002AF11
		[global::Cpp2ILInjected.Token(Token = "0x6004405")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A87A4", Offset = "0x7A87A4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			throw null;
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x0002CD14 File Offset: 0x0002AF14
		[global::Cpp2ILInjected.Token(Token = "0x6004406")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A87F8", Offset = "0x7A87F8", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "With", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(DropRateInfoChainFeed))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsExpert), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "AddCondition", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.NotExpert), Member = ".ctor", ReturnType = typeof(void))]
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

		// Token: 0x04006BA4 RID: 27556
		[global::Cpp2ILInjected.Token(Token = "0x40081C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public IItemDropRule ruleForNormalMode;

		// Token: 0x04006BA5 RID: 27557
		[global::Cpp2ILInjected.Token(Token = "0x40081C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IItemDropRule ruleForExpertMode;

		// Token: 0x04006BA6 RID: 27558
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
