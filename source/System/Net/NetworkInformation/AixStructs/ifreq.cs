using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020001F0 RID: 496
	[global::Cpp2ILInjected.Token(Token = "0x20002D2")]
	[StructLayout(2, Pack = 1, Size = 18)]
	internal struct ifreq
	{
		// Token: 0x04000B68 RID: 2920
		[FixedBuffer(typeof(byte), 16)]
		[global::Cpp2ILInjected.Token(Token = "0x4000F39")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public ifreq.<ifr_name>e__FixedBuffer ifr_name;

		// Token: 0x04000B69 RID: 2921
		[global::Cpp2ILInjected.Token(Token = "0x4000F3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.Runtime.InteropServices.FieldOffset(16)]
		public sockaddr ifru_addr;

		// Token: 0x02000445 RID: 1093
		[CompilerGenerated]
		[UnsafeValueType]
		[global::Cpp2ILInjected.Token(Token = "0x20002D3")]
		[StructLayout(0, Size = 16)]
		public struct <ifr_name>e__FixedBuffer
		{
			// Token: 0x04001358 RID: 4952
			[global::Cpp2ILInjected.Token(Token = "0x4000F3B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
