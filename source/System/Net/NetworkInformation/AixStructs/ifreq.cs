using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	[global::Cpp2ILInjected.Token(Token = "0x20002D2")]
	[StructLayout(2, Pack = 1, Size = 18)]
	internal struct ifreq
	{
		[FixedBuffer(typeof(byte), 16)]
		[global::Cpp2ILInjected.Token(Token = "0x4000F39")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public ifreq.<ifr_name>e__FixedBuffer ifr_name;

		[global::Cpp2ILInjected.Token(Token = "0x4000F3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.Runtime.InteropServices.FieldOffset(16)]
		public sockaddr ifru_addr;

		[CompilerGenerated]
		[UnsafeValueType]
		[global::Cpp2ILInjected.Token(Token = "0x20002D3")]
		[StructLayout(0, Size = 16)]
		public struct <ifr_name>e__FixedBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000F3B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
