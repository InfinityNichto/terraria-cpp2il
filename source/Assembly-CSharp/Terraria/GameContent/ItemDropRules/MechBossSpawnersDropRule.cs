using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005D5 RID: 1493
	[global::Cpp2ILInjected.Token(Token = "0x2000881")]
	public class MechBossSpawnersDropRule : IItemDropRule
	{
		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x0002CD41 File Offset: 0x0002AF41
		// (set) Token: 0x06003CA8 RID: 15528 RVA: 0x0002CD44 File Offset: 0x0002AF44
		[global::Cpp2ILInjected.Token(Token = "0x170007D9")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004415")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A9364", Offset = "0x7A9364", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004416")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A936C", Offset = "0x7A936C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x0002CD47 File Offset: 0x0002AF47
		[global::Cpp2ILInjected.Token(Token = "0x6004417")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9374", Offset = "0x7A9374", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterGlobalRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.MechanicalBossesDummyCondition), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public MechBossSpawnersDropRule()
		{
			throw null;
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x0002CD4A File Offset: 0x0002AF4A
		[global::Cpp2ILInjected.Token(Token = "0x6004418")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9420", Offset = "0x7A9420", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x0002CD4D File Offset: 0x0002AF4D
		[global::Cpp2ILInjected.Token(Token = "0x6004419")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9510", Offset = "0x7A9510", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RollLuck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "DropItemFromNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x0002CD50 File Offset: 0x0002AF50
		[global::Cpp2ILInjected.Token(Token = "0x600441A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9624", Offset = "0x7A9624", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfoChainFeed), Member = "AddCondition", MemberParameters = new object[] { typeof(IItemDropRuleCondition) }, ReturnType = typeof(void))]
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
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x04006BAE RID: 27566
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;

		// Token: 0x04006BAF RID: 27567
		[global::Cpp2ILInjected.Token(Token = "0x40081D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Conditions.MechanicalBossesDummyCondition dummyCondition;
	}
}
