using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020001EB RID: 491
	[global::Cpp2ILInjected.Token(Token = "0x20002CD")]
	internal struct sockaddr_in
	{
		// Token: 0x04000B53 RID: 2899
		[global::Cpp2ILInjected.Token(Token = "0x4000F24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte sin_len;

		// Token: 0x04000B54 RID: 2900
		[global::Cpp2ILInjected.Token(Token = "0x4000F25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte sin_family;

		// Token: 0x04000B55 RID: 2901
		[global::Cpp2ILInjected.Token(Token = "0x4000F26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin_port;

		// Token: 0x04000B56 RID: 2902
		[global::Cpp2ILInjected.Token(Token = "0x4000F27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin_addr;
	}
}
