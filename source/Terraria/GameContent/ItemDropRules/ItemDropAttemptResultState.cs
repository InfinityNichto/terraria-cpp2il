using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000872")]
	public enum ItemDropAttemptResultState
	{
		[global::Cpp2ILInjected.Token(Token = "0x40081B7")]
		DoesntFillConditions,
		[global::Cpp2ILInjected.Token(Token = "0x40081B8")]
		FailedRandomRoll,
		[global::Cpp2ILInjected.Token(Token = "0x40081B9")]
		Success,
		[global::Cpp2ILInjected.Token(Token = "0x40081BA")]
		DidNotRunCode
	}
}
