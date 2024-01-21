using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005CC")]
public interface IItemDropRuleCondition : IProvideItemConditionDescription
{
	[Cpp2IlInjected.Token(Token = "0x6003CB0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CanDrop(DropAttemptInfo info);

	[Cpp2IlInjected.Token(Token = "0x6003CB1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanShowItemDropInUI();
}
