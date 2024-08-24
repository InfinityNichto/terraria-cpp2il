using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005DB RID: 1499
	[global::Cpp2ILInjected.Token(Token = "0x2000888")]
	public class OneFromOptionsDropRule : IItemDropRule
	{
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x0002CDA7 File Offset: 0x0002AFA7
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x0002CDAA File Offset: 0x0002AFAA
		[global::Cpp2ILInjected.Token(Token = "0x170007DE")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004438")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA6D0", Offset = "0x7AA6D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004439")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA6D8", Offset = "0x7AA6D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x0002CDAD File Offset: 0x0002AFAD
		[global::Cpp2ILInjected.Token(Token = "0x600443A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA6E0", Offset = "0x7AA6E0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "OneFromOptionsWithNumerator", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public OneFromOptionsDropRule(int chanceDenominator, int chanceNumerator, params int[] options)
		{
			throw null;
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x0002CDB0 File Offset: 0x0002AFB0
		[global::Cpp2ILInjected.Token(Token = "0x600443B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA77C", Offset = "0x7AA77C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x0002CDB3 File Offset: 0x0002AFB3
		[global::Cpp2ILInjected.Token(Token = "0x600443C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA784", Offset = "0x7AA784", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RollLuck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "DropItemFromNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x0002CDB6 File Offset: 0x0002AFB6
		[global::Cpp2ILInjected.Token(Token = "0x600443D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA7FC", Offset = "0x7AA7FC", Length = "0x18C")]
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

		// Token: 0x04006BBB RID: 27579
		[global::Cpp2ILInjected.Token(Token = "0x40081E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int[] dropIds;

		// Token: 0x04006BBC RID: 27580
		[global::Cpp2ILInjected.Token(Token = "0x40081E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int chanceDenominator;

		// Token: 0x04006BBD RID: 27581
		[global::Cpp2ILInjected.Token(Token = "0x40081E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int chanceNumerator;

		// Token: 0x04006BBE RID: 27582
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
