using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005C9")]
public enum ItemDropAttemptResultState
{
	[Cpp2IlInjected.Token(Token = "0x4006B96")]
	DoesntFillConditions,
	[Cpp2IlInjected.Token(Token = "0x4006B97")]
	FailedRandomRoll,
	[Cpp2IlInjected.Token(Token = "0x4006B98")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4006B99")]
	DidNotRunCode
}
