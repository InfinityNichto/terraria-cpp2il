using System;
using Cpp2ILInjected;

namespace InControl
{
	// Token: 0x0200003D RID: 61
	[global::Cpp2ILInjected.Token(Token = "0x2000042")]
	public struct NativeInputOptions
	{
		// Token: 0x040002D3 RID: 723
		[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public ushort updateRate;

		// Token: 0x040002D4 RID: 724
		[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int enableXInput;

		// Token: 0x040002D5 RID: 725
		[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int enableMFi;

		// Token: 0x040002D6 RID: 726
		[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int preventSleep;
	}
}
