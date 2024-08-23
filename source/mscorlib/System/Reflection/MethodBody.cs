using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000445 RID: 1093
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000506")]
	public class MethodBody
	{
		// Token: 0x060022C8 RID: 8904 RVA: 0x0001A5E8 File Offset: 0x000187E8
		[global::Cpp2ILInjected.Token(Token = "0x6002564")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BB90", Offset = "0x1B8BB90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected MethodBody()
		{
			throw null;
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x0001A5EB File Offset: 0x000187EB
		[global::Cpp2ILInjected.Token(Token = "0x6002565")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BB98", Offset = "0x1B8BB98", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MethodBody(ExceptionHandlingClause[] clauses, LocalVariableInfo[] locals, byte[] il, bool init_locals, int sig_token, int max_stack)
		{
			throw null;
		}

		// Token: 0x040011B0 RID: 4528
		[global::Cpp2ILInjected.Token(Token = "0x40014CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ExceptionHandlingClause[] clauses;

		// Token: 0x040011B1 RID: 4529
		[global::Cpp2ILInjected.Token(Token = "0x40014CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private LocalVariableInfo[] locals;

		// Token: 0x040011B2 RID: 4530
		[global::Cpp2ILInjected.Token(Token = "0x40014CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] il;

		// Token: 0x040011B3 RID: 4531
		[global::Cpp2ILInjected.Token(Token = "0x40014D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool init_locals;

		// Token: 0x040011B4 RID: 4532
		[global::Cpp2ILInjected.Token(Token = "0x40014D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int sig_token;

		// Token: 0x040011B5 RID: 4533
		[global::Cpp2ILInjected.Token(Token = "0x40014D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int max_stack;
	}
}
