using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005D7")]
public class DropBasedOnMasterAndExpertMode : IItemDropRule, INestedItemDropRule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BAB")]
	public IItemDropRule ruleForDefault;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BAC")]
	public IItemDropRule ruleForExpertmode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BAD")]
	public IItemDropRule ruleForMasterMode;

	[Cpp2IlInjected.Token(Token = "0x17000734")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CDC")]
		[Cpp2IlInjected.Address(RVA = "0xE77C58", Offset = "0xE77C58", VA = "0xE77C58", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003CDD")]
		[Cpp2IlInjected.Address(RVA = "0xE77C60", Offset = "0xE77C60", VA = "0xE77C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003CDE")]
	[Cpp2IlInjected.Address(RVA = "0xE77C68", Offset = "0xE77C68", VA = "0xE77C68")]
	public DropBasedOnMasterAndExpertMode(IItemDropRule ruleForDefault, IItemDropRule ruleForExpertMode, IItemDropRule ruleForMasterMode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CDF")]
	[Cpp2IlInjected.Address(RVA = "0xE77D04", Offset = "0xE77D04", VA = "0xE77D04", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CE0")]
	[Cpp2IlInjected.Address(RVA = "0xE77EE4", Offset = "0xE77EE4", VA = "0xE77EE4", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CE1")]
	[Cpp2IlInjected.Address(RVA = "0xE77EEC", Offset = "0xE77EEC", VA = "0xE77EEC", Slot = "8")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CE2")]
	[Cpp2IlInjected.Address(RVA = "0xE77F48", Offset = "0xE77F48", VA = "0xE77F48", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}
}
