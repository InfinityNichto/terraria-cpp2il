using System;
using Cpp2ILInjected;

namespace Microsoft.Xna.Framework
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000320")]
	public enum BatteryChargeStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x4002221")]
		Charging = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4002222")]
		Critical = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4002223")]
		High = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4002224")]
		Low = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4002225")]
		NoSystemBattery = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4002226")]
		Unknown = 255
	}
}
