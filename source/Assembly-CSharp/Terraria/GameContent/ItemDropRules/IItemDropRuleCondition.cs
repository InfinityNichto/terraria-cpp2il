using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005C9 RID: 1481
	[global::Cpp2ILInjected.Token(Token = "0x2000875")]
	public interface IItemDropRuleCondition : IProvideItemConditionDescription
	{
		// Token: 0x06003C74 RID: 15476
		[global::Cpp2ILInjected.Token(Token = "0x60043E2")]
		bool CanDrop(DropAttemptInfo info);

		// Token: 0x06003C75 RID: 15477
		[global::Cpp2ILInjected.Token(Token = "0x60043E3")]
		bool CanShowItemDropInUI();
	}
}
