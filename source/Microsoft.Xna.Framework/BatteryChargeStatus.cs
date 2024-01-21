using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000262")]
[Flags]
public enum BatteryChargeStatus
{
	[Cpp2IlInjected.Token(Token = "0x4001C4F")]
	Charging = 8,
	[Cpp2IlInjected.Token(Token = "0x4001C50")]
	Critical = 4,
	[Cpp2IlInjected.Token(Token = "0x4001C51")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x4001C52")]
	Low = 2,
	[Cpp2IlInjected.Token(Token = "0x4001C53")]
	NoSystemBattery = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4001C54")]
	Unknown = 0xFF
}
