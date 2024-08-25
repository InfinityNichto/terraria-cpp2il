using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200001E")]
public class DrKeyboard_Stadia : DrKeyboard_Touch
{
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
