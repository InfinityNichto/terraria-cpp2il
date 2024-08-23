using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020001E9 RID: 489
	[global::Cpp2ILInjected.Token(Token = "0x20002CB")]
	internal struct ifaddrs
	{
		// Token: 0x04000B4A RID: 2890
		[global::Cpp2ILInjected.Token(Token = "0x4000F1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public IntPtr ifa_next;

		// Token: 0x04000B4B RID: 2891
		[global::Cpp2ILInjected.Token(Token = "0x4000F1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string ifa_name;

		// Token: 0x04000B4C RID: 2892
		[global::Cpp2ILInjected.Token(Token = "0x4000F1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint ifa_flags;

		// Token: 0x04000B4D RID: 2893
		[global::Cpp2ILInjected.Token(Token = "0x4000F1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IntPtr ifa_addr;

		// Token: 0x04000B4E RID: 2894
		[global::Cpp2ILInjected.Token(Token = "0x4000F1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public IntPtr ifa_netmask;

		// Token: 0x04000B4F RID: 2895
		[global::Cpp2ILInjected.Token(Token = "0x4000F20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public IntPtr ifa_dstaddr;

		// Token: 0x04000B50 RID: 2896
		[global::Cpp2ILInjected.Token(Token = "0x4000F21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public IntPtr ifa_data;
	}
}
