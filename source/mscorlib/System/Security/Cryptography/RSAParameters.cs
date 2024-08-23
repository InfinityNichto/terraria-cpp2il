using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	// Token: 0x02000255 RID: 597
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F2")]
	[global::System.Serializable]
	public struct RSAParameters
	{
		// Token: 0x04000A1B RID: 2587
		[global::Cpp2ILInjected.Token(Token = "0x4000CF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte[] Exponent;

		// Token: 0x04000A1C RID: 2588
		[global::Cpp2ILInjected.Token(Token = "0x4000CF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public byte[] Modulus;

		// Token: 0x04000A1D RID: 2589
		[global::Cpp2ILInjected.Token(Token = "0x4000CF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.NonSerialized]
		public byte[] P;

		// Token: 0x04000A1E RID: 2590
		[global::Cpp2ILInjected.Token(Token = "0x4000CF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[global::System.NonSerialized]
		public byte[] Q;

		// Token: 0x04000A1F RID: 2591
		[global::Cpp2ILInjected.Token(Token = "0x4000CF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		public byte[] DP;

		// Token: 0x04000A20 RID: 2592
		[global::Cpp2ILInjected.Token(Token = "0x4000CFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[global::System.NonSerialized]
		public byte[] DQ;

		// Token: 0x04000A21 RID: 2593
		[global::Cpp2ILInjected.Token(Token = "0x4000CFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[global::System.NonSerialized]
		public byte[] InverseQ;

		// Token: 0x04000A22 RID: 2594
		[global::Cpp2ILInjected.Token(Token = "0x4000CFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		[global::System.NonSerialized]
		public byte[] D;
	}
}
