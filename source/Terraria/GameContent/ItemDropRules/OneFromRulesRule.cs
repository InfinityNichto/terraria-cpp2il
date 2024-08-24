using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005DD RID: 1501
	[global::Cpp2ILInjected.Token(Token = "0x200088A")]
	public class OneFromRulesRule : IItemDropRule, INestedItemDropRule
	{
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06003CD5 RID: 15573 RVA: 0x0002CDCB File Offset: 0x0002AFCB
		// (set) Token: 0x06003CD6 RID: 15574 RVA: 0x0002CDCE File Offset: 0x0002AFCE
		[global::Cpp2ILInjected.Token(Token = "0x170007E0")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004444")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AAD7C", Offset = "0x7AAD7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004445")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AAD84", Offset = "0x7AAD84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x0002CDD1 File Offset: 0x0002AFD1
		[global::Cpp2ILInjected.Token(Token = "0x6004446")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AAD8C", Offset = "0x7AAD8C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Plantera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Golem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public OneFromRulesRule(int chanceDenominator, params IItemDropRule[] options)
		{
			throw null;
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x0002CDD4 File Offset: 0x0002AFD4
		[global::Cpp2ILInjected.Token(Token = "0x6004447")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AAE24", Offset = "0x7AAE24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x0002CDD7 File Offset: 0x0002AFD7
		[global::Cpp2ILInjected.Token(Token = "0x6004448")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AAE2C", Offset = "0x7AAE2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x0002CDDA File Offset: 0x0002AFDA
		[global::Cpp2ILInjected.Token(Token = "0x6004449")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AAE34", Offset = "0x7AAE34", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			throw null;
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x0002CDDD File Offset: 0x0002AFDD
		[global::Cpp2ILInjected.Token(Token = "0x600444A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AAEC0", Offset = "0x7AAEC0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "With", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(DropRateInfoChainFeed))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<IItemDropRuleChainAttempt>),
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x04006BC3 RID: 27587
		[global::Cpp2ILInjected.Token(Token = "0x40081ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public IItemDropRule[] options;

		// Token: 0x04006BC4 RID: 27588
		[global::Cpp2ILInjected.Token(Token = "0x40081EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int chanceDenominator;

		// Token: 0x04006BC5 RID: 27589
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
