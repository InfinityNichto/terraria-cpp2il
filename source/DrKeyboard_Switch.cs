using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200001F")]
public class DrKeyboard_Switch : DrKeyboard_Touch
{
	[global::Cpp2ILInjected.Token(Token = "0x6000098")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE4FC", Offset = "0x6FE4FC", Length = "0x90")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public DrKeyboard_Switch(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool multiline, bool filterText)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000067")]
	public static DrKeyboard_Switch LastKeyboard;
}
