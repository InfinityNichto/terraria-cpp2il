using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001D2 RID: 466
	[global::Cpp2ILInjected.Token(Token = "0x20002B4")]
	internal struct ifaddrs
	{
		// Token: 0x04000B05 RID: 2821
		[global::Cpp2ILInjected.Token(Token = "0x4000ED6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public IntPtr ifa_next;

		// Token: 0x04000B06 RID: 2822
		[global::Cpp2ILInjected.Token(Token = "0x4000ED7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string ifa_name;

		// Token: 0x04000B07 RID: 2823
		[global::Cpp2ILInjected.Token(Token = "0x4000ED8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint ifa_flags;

		// Token: 0x04000B08 RID: 2824
		[global::Cpp2ILInjected.Token(Token = "0x4000ED9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IntPtr ifa_addr;

		// Token: 0x04000B09 RID: 2825
		[global::Cpp2ILInjected.Token(Token = "0x4000EDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public IntPtr ifa_netmask;

		// Token: 0x04000B0A RID: 2826
		[global::Cpp2ILInjected.Token(Token = "0x4000EDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public ifa_ifu ifa_ifu;

		// Token: 0x04000B0B RID: 2827
		[global::Cpp2ILInjected.Token(Token = "0x4000EDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public IntPtr ifa_data;
	}
}
