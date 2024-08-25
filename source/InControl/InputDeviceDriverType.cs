using System;
using Cpp2ILInjected;
using UnityEngine;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x200002F")]
	public enum InputDeviceDriverType : ushort
	{
		[global::Cpp2ILInjected.Token(Token = "0x400023C")]
		Unknown,
		[global::Cpp2ILInjected.Token(Token = "0x400023D")]
		HID,
		[global::Cpp2ILInjected.Token(Token = "0x400023E")]
		USB,
		[global::Cpp2ILInjected.Token(Token = "0x400023F")]
		Bluetooth,
		[InspectorName("XInput")]
		[global::Cpp2ILInjected.Token(Token = "0x4000240")]
		XInput,
		[InspectorName("DirectInput")]
		[global::Cpp2ILInjected.Token(Token = "0x4000241")]
		DirectInput,
		[InspectorName("RawInput")]
		[global::Cpp2ILInjected.Token(Token = "0x4000242")]
		RawInput
	}
}
