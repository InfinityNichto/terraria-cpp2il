using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002B4")]
	internal struct ifaddrs
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000ED6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public IntPtr ifa_next;

		[global::Cpp2ILInjected.Token(Token = "0x4000ED7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string ifa_name;

		[global::Cpp2ILInjected.Token(Token = "0x4000ED8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint ifa_flags;

		[global::Cpp2ILInjected.Token(Token = "0x4000ED9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IntPtr ifa_addr;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public IntPtr ifa_netmask;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public ifa_ifu ifa_ifu;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public IntPtr ifa_data;
	}
}
