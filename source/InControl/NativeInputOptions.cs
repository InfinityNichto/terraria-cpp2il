using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000042")]
	public struct NativeInputOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public ushort updateRate;

		[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int enableXInput;

		[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int enableMFi;

		[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int preventSleep;
	}
}
