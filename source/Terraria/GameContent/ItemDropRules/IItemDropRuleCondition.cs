using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000875")]
	public interface IItemDropRuleCondition : IProvideItemConditionDescription
	{
		[global::Cpp2ILInjected.Token(Token = "0x60043E2")]
		bool CanDrop(DropAttemptInfo info);

		[global::Cpp2ILInjected.Token(Token = "0x60043E3")]
		bool CanShowItemDropInUI();
	}
}
