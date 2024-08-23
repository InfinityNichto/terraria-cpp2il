using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200001C RID: 28
[global::Cpp2ILInjected.Token(Token = "0x2000021")]
public class DrKeyboard_XBO : DrKeyboard_Touch
{
	// Token: 0x06000095 RID: 149 RVA: 0x00021D37 File Offset: 0x0001FF37
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

	// Token: 0x04000063 RID: 99
	[global::Cpp2ILInjected.Token(Token = "0x400006A")]
	public static DrKeyboard_XBO LastKeyboard;
}
