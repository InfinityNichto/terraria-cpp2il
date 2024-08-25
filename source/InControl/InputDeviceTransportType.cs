using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000037")]
	public enum InputDeviceTransportType : ushort
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000286")]
		Unknown,
		[global::Cpp2ILInjected.Token(Token = "0x4000287")]
		USB,
		[global::Cpp2ILInjected.Token(Token = "0x4000288")]
		Bluetooth
	}
}
