using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public enum BindingSourceType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000018")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		DeviceBindingSource,
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		KeyBindingSource,
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		MouseBindingSource,
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		UnknownDeviceBindingSource
	}
}
