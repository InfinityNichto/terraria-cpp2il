using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000E6 RID: 230
	[global::Cpp2ILInjected.Token(Token = "0x2000118")]
	[global::System.Serializable]
	public class UnhandledExceptionEventArgs : global::System.EventArgs
	{
		// Token: 0x06000A5D RID: 2653 RVA: 0x0001631F File Offset: 0x0001451F
		[global::Cpp2ILInjected.Token(Token = "0x6000B05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53040", Offset = "0x1C53040", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UnhandledExceptionEventArgs(object exception, bool isTerminating)
		{
			throw null;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00016322 File Offset: 0x00014522
		[global::Cpp2ILInjected.Token(Token = "0x170000F2")]
		public object ExceptionObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C530B4", Offset = "0x1C530B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00016325 File Offset: 0x00014525
		[global::Cpp2ILInjected.Token(Token = "0x170000F3")]
		public bool IsTerminating
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B07")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C530BC", Offset = "0x1C530BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002AD RID: 685
		[global::Cpp2ILInjected.Token(Token = "0x40003FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object _exception;

		// Token: 0x040002AE RID: 686
		[global::Cpp2ILInjected.Token(Token = "0x4000400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _isTerminating;
	}
}
