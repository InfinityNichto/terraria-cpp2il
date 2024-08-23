using System;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001D3 RID: 467
	[global::Cpp2ILInjected.Token(Token = "0x20002B5")]
	internal struct sockaddr_in
	{
		// Token: 0x04000B0C RID: 2828
		[global::Cpp2ILInjected.Token(Token = "0x4000EDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public ushort sin_family;

		// Token: 0x04000B0D RID: 2829
		[global::Cpp2ILInjected.Token(Token = "0x4000EDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public ushort sin_port;

		// Token: 0x04000B0E RID: 2830
		[global::Cpp2ILInjected.Token(Token = "0x4000EDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public uint sin_addr;
	}
}
