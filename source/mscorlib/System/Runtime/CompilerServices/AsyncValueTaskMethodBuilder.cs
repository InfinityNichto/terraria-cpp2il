using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003B7 RID: 951
	[global::Cpp2ILInjected.Token(Token = "0x2000464")]
	[StructLayout(3)]
	public struct AsyncValueTaskMethodBuilder
	{
		// Token: 0x04000FAC RID: 4012
		[global::Cpp2ILInjected.Token(Token = "0x40012A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private AsyncTaskMethodBuilder _methodBuilder;

		// Token: 0x04000FAD RID: 4013
		[global::Cpp2ILInjected.Token(Token = "0x40012A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _haveResult;

		// Token: 0x04000FAE RID: 4014
		[global::Cpp2ILInjected.Token(Token = "0x40012A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool _useBuilder;
	}
}
