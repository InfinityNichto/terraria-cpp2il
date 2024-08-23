using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	// Token: 0x02000239 RID: 569
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D6")]
	[global::System.Serializable]
	public struct DSAParameters
	{
		// Token: 0x040009CB RID: 2507
		[global::Cpp2ILInjected.Token(Token = "0x4000CA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte[] P;

		// Token: 0x040009CC RID: 2508
		[global::Cpp2ILInjected.Token(Token = "0x4000CA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public byte[] Q;

		// Token: 0x040009CD RID: 2509
		[global::Cpp2ILInjected.Token(Token = "0x4000CA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public byte[] G;

		// Token: 0x040009CE RID: 2510
		[global::Cpp2ILInjected.Token(Token = "0x4000CA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public byte[] Y;

		// Token: 0x040009CF RID: 2511
		[global::Cpp2ILInjected.Token(Token = "0x4000CA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public byte[] J;

		// Token: 0x040009D0 RID: 2512
		[global::Cpp2ILInjected.Token(Token = "0x4000CAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[global::System.NonSerialized]
		public byte[] X;

		// Token: 0x040009D1 RID: 2513
		[global::Cpp2ILInjected.Token(Token = "0x4000CAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public byte[] Seed;

		// Token: 0x040009D2 RID: 2514
		[global::Cpp2ILInjected.Token(Token = "0x4000CAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int Counter;
	}
}
