using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x2000282")]
[Flags]
public enum Buttons
{
	[Cpp2IlInjected.Token(Token = "0x4001CF7")]
	DPadUp = 1,
	[Cpp2IlInjected.Token(Token = "0x4001CF8")]
	DPadDown = 2,
	[Cpp2IlInjected.Token(Token = "0x4001CF9")]
	DPadLeft = 4,
	[Cpp2IlInjected.Token(Token = "0x4001CFA")]
	DPadRight = 8,
	[Cpp2IlInjected.Token(Token = "0x4001CFB")]
	Start = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4001CFC")]
	Back = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4001CFD")]
	LeftStick = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4001CFE")]
	RightStick = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4001CFF")]
	LeftShoulder = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4001D00")]
	RightShoulder = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4001D01")]
	BigButton = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4001D02")]
	A = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4001D03")]
	B = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4001D04")]
	X = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x4001D05")]
	Y = 0x8000,
	[Cpp2IlInjected.Token(Token = "0x4001D06")]
	LeftThumbstickLeft = 0x200000,
	[Cpp2IlInjected.Token(Token = "0x4001D07")]
	RightTrigger = 0x400000,
	[Cpp2IlInjected.Token(Token = "0x4001D08")]
	LeftTrigger = 0x800000,
	[Cpp2IlInjected.Token(Token = "0x4001D09")]
	RightThumbstickUp = 0x1000000,
	[Cpp2IlInjected.Token(Token = "0x4001D0A")]
	RightThumbstickDown = 0x2000000,
	[Cpp2IlInjected.Token(Token = "0x4001D0B")]
	RightThumbstickRight = 0x4000000,
	[Cpp2IlInjected.Token(Token = "0x4001D0C")]
	RightThumbstickLeft = 0x8000000,
	[Cpp2IlInjected.Token(Token = "0x4001D0D")]
	LeftThumbstickUp = 0x10000000,
	[Cpp2IlInjected.Token(Token = "0x4001D0E")]
	LeftThumbstickDown = 0x20000000,
	[Cpp2IlInjected.Token(Token = "0x4001D0F")]
	LeftThumbstickRight = 0x40000000
}
