using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000019 RID: 25
[global::Cpp2ILInjected.Token(Token = "0x200001E")]
public class DrKeyboard_Stadia : DrKeyboard_Touch
{
	// Token: 0x0600008B RID: 139 RVA: 0x00021D19 File Offset: 0x0001FF19
	[global::Cpp2ILInjected.Token(Token = "0x6000097")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE444", Offset = "0x6FE444", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrKeyboard_Touch), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(TouchScreenKeyboardType),
		typeof(string),
		typeof(int),
		typeof(string),
		typeof(string),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	public DrKeyboard_Stadia(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool password, bool multiline)
	{
		throw null;
	}
}
