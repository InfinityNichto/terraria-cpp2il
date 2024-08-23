using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x02000137 RID: 311
	[global::Cpp2ILInjected.Token(Token = "0x20001BE")]
	[StructLayout(0, CharSet = CharSet.Unicode)]
	internal struct hostent
	{
		// Token: 0x0400075B RID: 1883
		[global::Cpp2ILInjected.Token(Token = "0x4000974")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public IntPtr h_name;

		// Token: 0x0400075C RID: 1884
		[global::Cpp2ILInjected.Token(Token = "0x4000975")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public IntPtr h_aliases;

		// Token: 0x0400075D RID: 1885
		[global::Cpp2ILInjected.Token(Token = "0x4000976")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public short h_addrtype;

		// Token: 0x0400075E RID: 1886
		[global::Cpp2ILInjected.Token(Token = "0x4000977")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		public short h_length;

		// Token: 0x0400075F RID: 1887
		[global::Cpp2ILInjected.Token(Token = "0x4000978")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IntPtr h_addr_list;
	}
}
