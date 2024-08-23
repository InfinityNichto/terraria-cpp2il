using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020001F2 RID: 498
	[global::Cpp2ILInjected.Token(Token = "0x20002D6")]
	[StructLayout(2, Pack = 1, Size = 20)]
	internal struct ifreq_mtu
	{
		// Token: 0x04000B6C RID: 2924
		[FixedBuffer(typeof(byte), 16)]
		[global::Cpp2ILInjected.Token(Token = "0x4000F3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public ifreq_mtu.<ifr_name>e__FixedBuffer ifr_name;

		// Token: 0x04000B6D RID: 2925
		[global::Cpp2ILInjected.Token(Token = "0x4000F40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.Runtime.InteropServices.FieldOffset(16)]
		public int ifru_mtu;

		// Token: 0x02000447 RID: 1095
		[UnsafeValueType]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002D7")]
		[StructLayout(0, Size = 16)]
		public struct <ifr_name>e__FixedBuffer
		{
			// Token: 0x0400135A RID: 4954
			[global::Cpp2ILInjected.Token(Token = "0x4000F41")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
