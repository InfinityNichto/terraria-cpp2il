using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x02000073 RID: 115
	[global::Cpp2ILInjected.Token(Token = "0x20000CB")]
	public sealed class Trace
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000399B File Offset: 0x00001B9B
		[global::Cpp2ILInjected.Token(Token = "0x170000C8")]
		public static TraceListenerCollection Listeners
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC52AC", Offset = "0x1EC52AC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DiagnosticsTraceWriter", Member = "Trace", MemberParameters = new object[]
			{
				typeof(TraceLevel),
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000399E File Offset: 0x00001B9E
		[global::Cpp2ILInjected.Token(Token = "0x170000C9")]
		public static bool AutoFlush
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5528", Offset = "0x1EC5528", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DiagnosticsTraceWriter", Member = "Trace", MemberParameters = new object[]
			{
				typeof(TraceLevel),
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x000039A1 File Offset: 0x00001BA1
		[global::Cpp2ILInjected.Token(Token = "0x170000CA")]
		public static CorrelationManager CorrelationManager
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC55D4", Offset = "0x1EC55D4", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceEventCache), Member = "get_LogicalOperationStack", ReturnType = typeof(Stack))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListener), Member = "WriteFooter", MemberParameters = new object[] { typeof(TraceEventCache) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000253 RID: 595
		[global::Cpp2ILInjected.Token(Token = "0x4000394")]
		private static CorrelationManager correlationManager;
	}
}
