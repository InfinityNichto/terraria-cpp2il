using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020001F6 RID: 502
	[global::Cpp2ILInjected.Token(Token = "0x20002DB")]
	internal struct sockaddr_in6
	{
		// Token: 0x04000B75 RID: 2933
		[global::Cpp2ILInjected.Token(Token = "0x4000F49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sin6_len;

		// Token: 0x04000B76 RID: 2934
		[global::Cpp2ILInjected.Token(Token = "0x4000F4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sin6_family;

		// Token: 0x04000B77 RID: 2935
		[global::Cpp2ILInjected.Token(Token = "0x4000F4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin6_port;

		// Token: 0x04000B78 RID: 2936
		[global::Cpp2ILInjected.Token(Token = "0x4000F4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin6_flowinfo;

		// Token: 0x04000B79 RID: 2937
		[global::Cpp2ILInjected.Token(Token = "0x4000F4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public in6_addr sin6_addr;

		// Token: 0x04000B7A RID: 2938
		[global::Cpp2ILInjected.Token(Token = "0x4000F4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint sin6_scope_id;
	}
}
