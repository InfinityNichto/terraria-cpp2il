using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002A4")]
	public enum OperationalStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000E98")]
		Up = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000E99")]
		Down,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9A")]
		Testing,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9B")]
		Unknown,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9C")]
		Dormant,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9D")]
		NotPresent,
		[global::Cpp2ILInjected.Token(Token = "0x4000E9E")]
		LowerLayerDown
	}
}
