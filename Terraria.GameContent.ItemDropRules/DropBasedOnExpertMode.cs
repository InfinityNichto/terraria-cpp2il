using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005D5")]
public class DropBasedOnExpertMode : IItemDropRule, INestedItemDropRule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BA5")]
	public IItemDropRule ruleForNormalMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BA6")]
	public IItemDropRule ruleForExpertMode;

	[Cpp2IlInjected.Token(Token = "0x17000732")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CCE")]
		[Cpp2IlInjected.Address(RVA = "0xE77738", Offset = "0xE77738", VA = "0xE77738", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003CCF")]
		[Cpp2IlInjected.Address(RVA = "0xE77740", Offset = "0xE77740", VA = "0xE77740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003CD0")]
	[Cpp2IlInjected.Address(RVA = "0xE77748", Offset = "0xE77748", VA = "0xE77748")]
	public DropBasedOnExpertMode(IItemDropRule ruleForNormalMode, IItemDropRule ruleForExpertMode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CD1")]
	[Cpp2IlInjected.Address(RVA = "0xE777DC", Offset = "0xE777DC", VA = "0xE777DC", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CD2")]
	[Cpp2IlInjected.Address(RVA = "0xE77928", Offset = "0xE77928", VA = "0xE77928", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CD3")]
	[Cpp2IlInjected.Address(RVA = "0xE77930", Offset = "0xE77930", VA = "0xE77930", Slot = "8")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CD4")]
	[Cpp2IlInjected.Address(RVA = "0xE7797C", Offset = "0xE7797C", VA = "0xE7797C", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
