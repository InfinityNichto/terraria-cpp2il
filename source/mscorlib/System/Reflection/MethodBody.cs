using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000506")]
	public class MethodBody
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002564")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BB90", Offset = "0x1B8BB90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected MethodBody()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002565")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BB98", Offset = "0x1B8BB98", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MethodBody(ExceptionHandlingClause[] clauses, LocalVariableInfo[] locals, byte[] il, bool init_locals, int sig_token, int max_stack)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40014CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ExceptionHandlingClause[] clauses;

		[global::Cpp2ILInjected.Token(Token = "0x40014CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private LocalVariableInfo[] locals;

		[global::Cpp2ILInjected.Token(Token = "0x40014CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] il;

		[global::Cpp2ILInjected.Token(Token = "0x40014D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool init_locals;

		[global::Cpp2ILInjected.Token(Token = "0x40014D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int sig_token;

		[global::Cpp2ILInjected.Token(Token = "0x40014D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int max_stack;
	}
}
