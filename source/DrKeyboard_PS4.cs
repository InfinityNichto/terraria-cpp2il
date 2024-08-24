using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000018 RID: 24
[global::Cpp2ILInjected.Token(Token = "0x200001D")]
public class DrKeyboard_PS4 : DrKeyboard_Touch
{
	// Token: 0x0600008A RID: 138 RVA: 0x00021D16 File Offset: 0x0001FF16
	[global::Cpp2ILInjected.Token(Token = "0x6000096")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE450", Offset = "0x6FE450", Length = "0x20")]
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
	public DrKeyboard_PS4(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool multiline)
	{
		throw null;
	}
}
