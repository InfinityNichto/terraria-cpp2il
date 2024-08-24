using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005D6 RID: 1494
	[global::Cpp2ILInjected.Token(Token = "0x2000882")]
	public class SlimeBodyItemDropRule : IItemDropRule
	{
		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06003CAD RID: 15533 RVA: 0x0002CD53 File Offset: 0x0002AF53
		// (set) Token: 0x06003CAE RID: 15534 RVA: 0x0002CD56 File Offset: 0x0002AF56
		[global::Cpp2ILInjected.Token(Token = "0x170007DA")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600441B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A98C4", Offset = "0x7A98C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600441C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A98CC", Offset = "0x7A98CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x0002CD59 File Offset: 0x0002AF59
		[global::Cpp2ILInjected.Token(Token = "0x600441D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A98D4", Offset = "0x7A98D4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterGlobalRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SlimeBodyItemDropRule()
		{
			throw null;
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		[global::Cpp2ILInjected.Token(Token = "0x600441E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9954", Offset = "0x7A9954", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x0002CD5F File Offset: 0x0002AF5F
		[global::Cpp2ILInjected.Token(Token = "0x600441F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9994", Offset = "0x7A9994", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlimeBodyItemDropRule), Member = "GetDropInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
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
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x0002CD62 File Offset: 0x0002AF62
		[global::Cpp2ILInjected.Token(Token = "0x6004420")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9A20", Offset = "0x7A9A20", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlimeBodyItemDropRule), Member = "TryDroppingItem", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(ItemDropAttemptResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void GetDropInfo(int itemId, out int amountDroppedMinimum, out int amountDroppedMaximum)
		{
			throw null;
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x0002CD65 File Offset: 0x0002AF65
		[global::Cpp2ILInjected.Token(Token = "0x6004421")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A9AF8", Offset = "0x7A9AF8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x04006BB0 RID: 27568
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
