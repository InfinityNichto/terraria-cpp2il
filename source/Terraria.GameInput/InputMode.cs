using Cpp2IlInjected;

namespace Terraria.GameInput;

[Cpp2IlInjected.Token(Token = "0x20004B5")]
public enum InputMode
{
	[Cpp2IlInjected.Token(Token = "0x40065F6")]
	Keyboard,
	[Cpp2IlInjected.Token(Token = "0x40065F7")]
	KeyboardUI,
	[Cpp2IlInjected.Token(Token = "0x40065F8")]
	Mouse,
	[Cpp2IlInjected.Token(Token = "0x40065F9")]
	XBoxGamepad,
	[Cpp2IlInjected.Token(Token = "0x40065FA")]
	XBoxGamepadUI
}
