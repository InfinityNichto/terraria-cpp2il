using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DrKeyboard_Switch : DrKeyboard_Touch
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static DrKeyboard_Switch LastKeyboard;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x20CD3F4", Offset = "0x20CD3F4", VA = "0x20CD3F4")]
	public DrKeyboard_Switch(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool multiline, bool filterText)
	{
	}
}
