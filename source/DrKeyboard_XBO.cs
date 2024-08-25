using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000021")]
public class DrKeyboard_XBO : DrKeyboard_Touch
{
	[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE470", Offset = "0x6FE470", Length = "0x8C")]
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
	public DrKeyboard_XBO(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400006A")]
	public static DrKeyboard_XBO LastKeyboard;
}
