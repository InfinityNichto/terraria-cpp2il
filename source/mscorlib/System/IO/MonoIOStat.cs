using System;
using Cpp2ILInjected;

namespace System.IO
{
	// Token: 0x02000497 RID: 1175
	[global::Cpp2ILInjected.Token(Token = "0x200056C")]
	internal struct MonoIOStat
	{
		// Token: 0x04001329 RID: 4905
		[global::Cpp2ILInjected.Token(Token = "0x4001675")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public FileAttributes fileAttributes;

		// Token: 0x0400132A RID: 4906
		[global::Cpp2ILInjected.Token(Token = "0x4001676")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public long Length;

		// Token: 0x0400132B RID: 4907
		[global::Cpp2ILInjected.Token(Token = "0x4001677")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public long CreationTime;

		// Token: 0x0400132C RID: 4908
		[global::Cpp2ILInjected.Token(Token = "0x4001678")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public long LastAccessTime;

		// Token: 0x0400132D RID: 4909
		[global::Cpp2ILInjected.Token(Token = "0x4001679")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public long LastWriteTime;
	}
}
