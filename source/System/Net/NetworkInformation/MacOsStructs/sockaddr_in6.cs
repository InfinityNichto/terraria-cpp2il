using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020001ED RID: 493
	[global::Cpp2ILInjected.Token(Token = "0x20002CF")]
	internal struct sockaddr_in6
	{
		// Token: 0x04000B58 RID: 2904
		[global::Cpp2ILInjected.Token(Token = "0x4000F29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sin6_len;

		// Token: 0x04000B59 RID: 2905
		[global::Cpp2ILInjected.Token(Token = "0x4000F2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sin6_family;

		// Token: 0x04000B5A RID: 2906
		[global::Cpp2ILInjected.Token(Token = "0x4000F2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin6_port;

		// Token: 0x04000B5B RID: 2907
		[global::Cpp2ILInjected.Token(Token = "0x4000F2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin6_flowinfo;

		// Token: 0x04000B5C RID: 2908
		[global::Cpp2ILInjected.Token(Token = "0x4000F2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public in6_addr sin6_addr;

		// Token: 0x04000B5D RID: 2909
		[global::Cpp2ILInjected.Token(Token = "0x4000F2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint sin6_scope_id;
	}
}
