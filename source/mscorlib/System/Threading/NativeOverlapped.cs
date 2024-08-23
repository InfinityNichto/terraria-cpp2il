using System;
using Cpp2ILInjected;

namespace System.Threading
{
	// Token: 0x02000179 RID: 377
	[global::Cpp2ILInjected.Token(Token = "0x20001CC")]
	public struct NativeOverlapped
	{
		// Token: 0x0400071E RID: 1822
		[global::Cpp2ILInjected.Token(Token = "0x400091F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::System.IntPtr InternalLow;

		// Token: 0x0400071F RID: 1823
		[global::Cpp2ILInjected.Token(Token = "0x4000920")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public global::System.IntPtr InternalHigh;

		// Token: 0x04000720 RID: 1824
		[global::Cpp2ILInjected.Token(Token = "0x4000921")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int OffsetLow;

		// Token: 0x04000721 RID: 1825
		[global::Cpp2ILInjected.Token(Token = "0x4000922")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int OffsetHigh;

		// Token: 0x04000722 RID: 1826
		[global::Cpp2ILInjected.Token(Token = "0x4000923")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public global::System.IntPtr EventHandle;
	}
}
