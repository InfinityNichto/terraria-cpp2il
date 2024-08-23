using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020001F4 RID: 500
	[global::Cpp2ILInjected.Token(Token = "0x20002D9")]
	internal struct sockaddr_in
	{
		// Token: 0x04000B70 RID: 2928
		[global::Cpp2ILInjected.Token(Token = "0x4000F44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sin_len;

		// Token: 0x04000B71 RID: 2929
		[global::Cpp2ILInjected.Token(Token = "0x4000F45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sin_family;

		// Token: 0x04000B72 RID: 2930
		[global::Cpp2ILInjected.Token(Token = "0x4000F46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin_port;

		// Token: 0x04000B73 RID: 2931
		[global::Cpp2ILInjected.Token(Token = "0x4000F47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin_addr;
	}
}
