using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001D1 RID: 465
	[global::Cpp2ILInjected.Token(Token = "0x20002B3")]
	[StructLayout(2)]
	internal struct ifa_ifu
	{
		// Token: 0x04000B03 RID: 2819
		[global::Cpp2ILInjected.Token(Token = "0x4000ED4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public IntPtr ifu_broadaddr;

		// Token: 0x04000B04 RID: 2820
		[global::Cpp2ILInjected.Token(Token = "0x4000ED5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public IntPtr ifu_dstaddr;
	}
}
