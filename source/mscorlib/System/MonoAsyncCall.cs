using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200013A RID: 314
	[global::Cpp2ILInjected.Token(Token = "0x2000180")]
	[StructLayout(0)]
	internal class MonoAsyncCall
	{
		// Token: 0x06000E24 RID: 3620 RVA: 0x00016D54 File Offset: 0x00014F54
		[global::Cpp2ILInjected.Token(Token = "0x6000F0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DED4", Offset = "0x1C7DED4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MonoAsyncCall()
		{
			throw null;
		}

		// Token: 0x040004AE RID: 1198
		[global::Cpp2ILInjected.Token(Token = "0x400067D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object msg;

		// Token: 0x040004AF RID: 1199
		[global::Cpp2ILInjected.Token(Token = "0x400067E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IntPtr cb_method;

		// Token: 0x040004B0 RID: 1200
		[global::Cpp2ILInjected.Token(Token = "0x400067F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object cb_target;

		// Token: 0x040004B1 RID: 1201
		[global::Cpp2ILInjected.Token(Token = "0x4000680")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object state;

		// Token: 0x040004B2 RID: 1202
		[global::Cpp2ILInjected.Token(Token = "0x4000681")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private object res;

		// Token: 0x040004B3 RID: 1203
		[global::Cpp2ILInjected.Token(Token = "0x4000682")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object out_args;
	}
}
