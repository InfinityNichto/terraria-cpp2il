using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001D4 RID: 468
	[global::Cpp2ILInjected.Token(Token = "0x20002B6")]
	internal struct sockaddr_in6
	{
		// Token: 0x04000B0F RID: 2831
		[global::Cpp2ILInjected.Token(Token = "0x4000EE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public ushort sin6_family;

		// Token: 0x04000B10 RID: 2832
		[global::Cpp2ILInjected.Token(Token = "0x4000EE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin6_port;

		// Token: 0x04000B11 RID: 2833
		[global::Cpp2ILInjected.Token(Token = "0x4000EE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin6_flowinfo;

		// Token: 0x04000B12 RID: 2834
		[global::Cpp2ILInjected.Token(Token = "0x4000EE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public in6_addr sin6_addr;

		// Token: 0x04000B13 RID: 2835
		[global::Cpp2ILInjected.Token(Token = "0x4000EE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint sin6_scope_id;
	}
}
