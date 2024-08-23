using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005CC RID: 1484
	[global::Cpp2ILInjected.Token(Token = "0x2000878")]
	public class CommonDrop : IItemDropRule
	{
		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x0002CCBD File Offset: 0x0002AEBD
		// (set) Token: 0x06003C7C RID: 15484 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
		[global::Cpp2ILInjected.Token(Token = "0x170007D4")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60043E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A7F24", Offset = "0x7A7F24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60043EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A7F2C", Offset = "0x7A7F2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x0002CCC3 File Offset: 0x0002AEC3
		[global::Cpp2ILInjected.Token(Token = "0x60043EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A636C", Offset = "0x7A636C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "BossBagByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "WithRerolls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "NotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonDropNotScalingWithLuck), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropLocalPerClientAndResetsNPCMoneyTo0), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(IItemDropRuleCondition)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropPerPlayerOnThePlayer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(IItemDropRuleCondition)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonDropWithRerolls), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropWithConditionRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(IItemDropRuleCondition),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_BOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterGlobalRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterTownNPCDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterHardmodeFeathers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterYoyos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 68)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public CommonDrop(int itemId, int chanceDenominator, int amountDroppedMinimum = 1, int amountDroppedMaximum = 1, int chanceNumerator = 1)
		{
			throw null;
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x0002CCC6 File Offset: 0x0002AEC6
		[global::Cpp2ILInjected.Token(Token = "0x60043EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A7F34", Offset = "0x7A7F34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x0002CCC9 File Offset: 0x0002AEC9
		[global::Cpp2ILInjected.Token(Token = "0x60043ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A7F3C", Offset = "0x7A7F3C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RollLuck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "DropItemFromNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public virtual ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x0002CCCC File Offset: 0x0002AECC
		[global::Cpp2ILInjected.Token(Token = "0x60043EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A7FB8", Offset = "0x7A7FB8", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(List<IItemDropRuleCondition>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<IItemDropRuleChainAttempt>),
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x04006B9A RID: 27546
		[global::Cpp2ILInjected.Token(Token = "0x40081BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int itemId;

		// Token: 0x04006B9B RID: 27547
		[global::Cpp2ILInjected.Token(Token = "0x40081BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int chanceDenominator;

		// Token: 0x04006B9C RID: 27548
		[global::Cpp2ILInjected.Token(Token = "0x40081BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int amountDroppedMinimum;

		// Token: 0x04006B9D RID: 27549
		[global::Cpp2ILInjected.Token(Token = "0x40081BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int amountDroppedMaximum;

		// Token: 0x04006B9E RID: 27550
		[global::Cpp2ILInjected.Token(Token = "0x40081C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int chanceNumerator;

		// Token: 0x04006B9F RID: 27551
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
