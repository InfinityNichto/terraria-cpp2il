using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005D9 RID: 1497
	[global::Cpp2ILInjected.Token(Token = "0x2000885")]
	public class DropOneByOne : IItemDropRule
	{
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x0002CD83 File Offset: 0x0002AF83
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x0002CD86 File Offset: 0x0002AF86
		[global::Cpp2ILInjected.Token(Token = "0x170007DC")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600442B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA0E4", Offset = "0x7AA0E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600442C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA0EC", Offset = "0x7AA0EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x0002CD89 File Offset: 0x0002AF89
		[global::Cpp2ILInjected.Token(Token = "0x600442D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA0F4", Offset = "0x7AA0F4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_LunarTowers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DropOneByOne(int itemId, DropOneByOne.Parameters parameters)
		{
			throw null;
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x0002CD8C File Offset: 0x0002AF8C
		[global::Cpp2ILInjected.Token(Token = "0x600442E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA194", Offset = "0x7AA194", Length = "0x10C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x0002CD8F File Offset: 0x0002AF8F
		[global::Cpp2ILInjected.Token(Token = "0x600442F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA2A0", Offset = "0x7AA2A0", Length = "0x15C")]
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
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x0002CD92 File Offset: 0x0002AF92
		[global::Cpp2ILInjected.Token(Token = "0x6004430")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA410", Offset = "0x7AA410", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x04006BB4 RID: 27572
		[global::Cpp2ILInjected.Token(Token = "0x40081D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int itemId;

		// Token: 0x04006BB5 RID: 27573
		[global::Cpp2ILInjected.Token(Token = "0x40081D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public DropOneByOne.Parameters parameters;

		// Token: 0x04006BB6 RID: 27574
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;

		// Token: 0x020009B6 RID: 2486
		[global::Cpp2ILInjected.Token(Token = "0x2000886")]
		public struct Parameters
		{
			// Token: 0x06004E40 RID: 20032 RVA: 0x0002FCF0 File Offset: 0x0002DEF0
			[global::Cpp2ILInjected.Token(Token = "0x6004431")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA3FC", Offset = "0x7AA3FC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public float GetPersonalDropRate()
			{
				throw null;
			}

			// Token: 0x04008CD5 RID: 36053
			[global::Cpp2ILInjected.Token(Token = "0x40081D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int ChanceNumerator;

			// Token: 0x04008CD6 RID: 36054
			[global::Cpp2ILInjected.Token(Token = "0x40081DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int ChanceDenominator;

			// Token: 0x04008CD7 RID: 36055
			[global::Cpp2ILInjected.Token(Token = "0x40081DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int MinimumItemDropsCount;

			// Token: 0x04008CD8 RID: 36056
			[global::Cpp2ILInjected.Token(Token = "0x40081DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int MaximumItemDropsCount;

			// Token: 0x04008CD9 RID: 36057
			[global::Cpp2ILInjected.Token(Token = "0x40081DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int MinimumStackPerChunkBase;

			// Token: 0x04008CDA RID: 36058
			[global::Cpp2ILInjected.Token(Token = "0x40081DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int MaximumStackPerChunkBase;

			// Token: 0x04008CDB RID: 36059
			[global::Cpp2ILInjected.Token(Token = "0x40081DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int BonusMinDropsPerChunkPerPlayer;

			// Token: 0x04008CDC RID: 36060
			[global::Cpp2ILInjected.Token(Token = "0x40081E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int BonusMaxDropsPerChunkPerPlayer;
		}
	}
}
