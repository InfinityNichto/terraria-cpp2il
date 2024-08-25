using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	[global::Cpp2ILInjected.Token(Token = "0x20002D6")]
	[StructLayout(2, Pack = 1, Size = 20)]
	internal struct ifreq_mtu
	{
		[FixedBuffer(typeof(byte), 16)]
		[global::Cpp2ILInjected.Token(Token = "0x4000F3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public ifreq_mtu.<ifr_name>e__FixedBuffer ifr_name;

		[global::Cpp2ILInjected.Token(Token = "0x4000F40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.Runtime.InteropServices.FieldOffset(16)]
		public int ifru_mtu;

		[UnsafeValueType]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002D7")]
		[StructLayout(0, Size = 16)]
		public struct <ifr_name>e__FixedBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000F41")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
