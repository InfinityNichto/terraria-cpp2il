using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020001EF RID: 495
	[global::Cpp2ILInjected.Token(Token = "0x20002D1")]
	[StructLayout(2, Pack = 1, Size = 16)]
	internal struct ifconf
	{
		// Token: 0x04000B66 RID: 2918
		[global::Cpp2ILInjected.Token(Token = "0x4000F37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public int ifc_len;

		// Token: 0x04000B67 RID: 2919
		[global::Cpp2ILInjected.Token(Token = "0x4000F38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		public IntPtr ifc_buf;
	}
}
