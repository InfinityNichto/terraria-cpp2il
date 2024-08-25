using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.MacOsStructs
{
	[global::Cpp2ILInjected.Token(Token = "0x20002CB")]
	internal struct ifaddrs
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000F1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public IntPtr ifa_next;

		[global::Cpp2ILInjected.Token(Token = "0x4000F1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string ifa_name;

		[global::Cpp2ILInjected.Token(Token = "0x4000F1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint ifa_flags;

		[global::Cpp2ILInjected.Token(Token = "0x4000F1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IntPtr ifa_addr;

		[global::Cpp2ILInjected.Token(Token = "0x4000F1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public IntPtr ifa_netmask;

		[global::Cpp2ILInjected.Token(Token = "0x4000F20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public IntPtr ifa_dstaddr;

		[global::Cpp2ILInjected.Token(Token = "0x4000F21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public IntPtr ifa_data;
	}
}
