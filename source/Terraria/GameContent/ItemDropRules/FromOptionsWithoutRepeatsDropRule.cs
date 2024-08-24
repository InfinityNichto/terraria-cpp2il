using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005DC RID: 1500
	[global::Cpp2ILInjected.Token(Token = "0x2000889")]
	public class FromOptionsWithoutRepeatsDropRule : IItemDropRule
	{
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x0002CDB9 File Offset: 0x0002AFB9
		// (set) Token: 0x06003CD0 RID: 15568 RVA: 0x0002CDBC File Offset: 0x0002AFBC
		[global::Cpp2ILInjected.Token(Token = "0x170007DF")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600443E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA988", Offset = "0x7AA988", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600443F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA990", Offset = "0x7AA990", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x0002CDBF File Offset: 0x0002AFBF
		[global::Cpp2ILInjected.Token(Token = "0x6004440")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA998", Offset = "0x7AA998", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_MoonLord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public FromOptionsWithoutRepeatsDropRule(int dropCount, params int[] options)
		{
			throw null;
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x0002CDC2 File Offset: 0x0002AFC2
		[global::Cpp2ILInjected.Token(Token = "0x6004441")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AAA78", Offset = "0x7AAA78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x0002CDC5 File Offset: 0x0002AFC5
		[global::Cpp2ILInjected.Token(Token = "0x6004442")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AAA80", Offset = "0x7AAA80", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "DropItemFromNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x0002CDC8 File Offset: 0x0002AFC8
		[global::Cpp2ILInjected.Token(Token = "0x6004443")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AABB4", Offset = "0x7AABB4", Length = "0x1C8")]
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

		// Token: 0x04006BBF RID: 27583
		[global::Cpp2ILInjected.Token(Token = "0x40081E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int[] dropIds;

		// Token: 0x04006BC0 RID: 27584
		[global::Cpp2ILInjected.Token(Token = "0x40081EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int dropCount;

		// Token: 0x04006BC1 RID: 27585
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;

		// Token: 0x04006BC2 RID: 27586
		[global::Cpp2ILInjected.Token(Token = "0x40081EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<int> _temporaryAvailableItems;
	}
}
