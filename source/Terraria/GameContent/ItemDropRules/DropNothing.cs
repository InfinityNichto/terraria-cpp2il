using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005D1 RID: 1489
	[global::Cpp2ILInjected.Token(Token = "0x200087D")]
	public class DropNothing : IItemDropRule
	{
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06003C8C RID: 15500 RVA: 0x0002CCF0 File Offset: 0x0002AEF0
		// (set) Token: 0x06003C8D RID: 15501 RVA: 0x0002CCF3 File Offset: 0x0002AEF3
		[global::Cpp2ILInjected.Token(Token = "0x170007D5")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60043FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A8628", Offset = "0x7A8628", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60043FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A8630", Offset = "0x7A8630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x0002CCF6 File Offset: 0x0002AEF6
		[global::Cpp2ILInjected.Token(Token = "0x60043FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6CE0", Offset = "0x7A6CE0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "DropNothing", ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DropNothing()
		{
			throw null;
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x0002CCF9 File Offset: 0x0002AEF9
		[global::Cpp2ILInjected.Token(Token = "0x60043FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8638", Offset = "0x7A8638", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x0002CCFC File Offset: 0x0002AEFC
		[global::Cpp2ILInjected.Token(Token = "0x60043FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8640", Offset = "0x7A8640", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x0002CCFF File Offset: 0x0002AEFF
		[global::Cpp2ILInjected.Token(Token = "0x60043FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8648", Offset = "0x7A8648", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<IItemDropRuleChainAttempt>),
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		// Token: 0x04006BA3 RID: 27555
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
