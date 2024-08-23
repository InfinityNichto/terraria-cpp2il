using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001D6 RID: 470
	[global::Cpp2ILInjected.Token(Token = "0x20002B8")]
	internal struct sockaddr_ll
	{
		// Token: 0x04000B15 RID: 2837
		[global::Cpp2ILInjected.Token(Token = "0x4000EE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public ushort sll_family;

		// Token: 0x04000B16 RID: 2838
		[global::Cpp2ILInjected.Token(Token = "0x4000EE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sll_protocol;

		// Token: 0x04000B17 RID: 2839
		[global::Cpp2ILInjected.Token(Token = "0x4000EE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int sll_ifindex;

		// Token: 0x04000B18 RID: 2840
		[global::Cpp2ILInjected.Token(Token = "0x4000EE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public ushort sll_hatype;

		// Token: 0x04000B19 RID: 2841
		[global::Cpp2ILInjected.Token(Token = "0x4000EEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		public byte sll_pkttype;

		// Token: 0x04000B1A RID: 2842
		[global::Cpp2ILInjected.Token(Token = "0x4000EEB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB")]
		public byte sll_halen;

		// Token: 0x04000B1B RID: 2843
		[global::Cpp2ILInjected.Token(Token = "0x4000EEC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public byte[] sll_addr;
	}
}
