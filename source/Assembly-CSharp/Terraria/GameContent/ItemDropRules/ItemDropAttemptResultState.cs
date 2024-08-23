using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005C6 RID: 1478
	[global::Cpp2ILInjected.Token(Token = "0x2000872")]
	public enum ItemDropAttemptResultState
	{
		// Token: 0x04006B95 RID: 27541
		[global::Cpp2ILInjected.Token(Token = "0x40081B7")]
		DoesntFillConditions,
		// Token: 0x04006B96 RID: 27542
		[global::Cpp2ILInjected.Token(Token = "0x40081B8")]
		FailedRandomRoll,
		// Token: 0x04006B97 RID: 27543
		[global::Cpp2ILInjected.Token(Token = "0x40081B9")]
		Success,
		// Token: 0x04006B98 RID: 27544
		[global::Cpp2ILInjected.Token(Token = "0x40081BA")]
		DidNotRunCode
	}
}
