﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020001F1 RID: 497
	[global::Cpp2ILInjected.Token(Token = "0x20002D4")]
	[StructLayout(2, Pack = 1, Size = 20)]
	internal struct ifreq_flags
	{
		// Token: 0x04000B6A RID: 2922
		[FixedBuffer(typeof(byte), 16)]
		[global::Cpp2ILInjected.Token(Token = "0x4000F3C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public ifreq_flags.<ifr_name>e__FixedBuffer ifr_name;

		// Token: 0x04000B6B RID: 2923
		[global::Cpp2ILInjected.Token(Token = "0x4000F3D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.Runtime.InteropServices.FieldOffset(16)]
		public uint ifru_flags;

		// Token: 0x02000446 RID: 1094
		[UnsafeValueType]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002D5")]
		[StructLayout(0, Size = 16)]
		public struct <ifr_name>e__FixedBuffer
		{
			// Token: 0x04001359 RID: 4953
			[global::Cpp2ILInjected.Token(Token = "0x4000F3E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}