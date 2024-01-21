using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DrKeyboard_XBO : DrKeyboard_Touch
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static DrKeyboard_XBO LastKeyboard;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x20CD338", Offset = "0x20CD338", VA = "0x20CD338")]
	public DrKeyboard_XBO(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt)
	{
	}
}
