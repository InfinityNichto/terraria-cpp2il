using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x02000076 RID: 118
	[global::Cpp2ILInjected.Token(Token = "0x20000CE")]
	public abstract class TraceFilter
	{
		// Token: 0x0600040A RID: 1034
		[global::Cpp2ILInjected.Token(Token = "0x60004AA")]
		public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);

		// Token: 0x0600040B RID: 1035 RVA: 0x000039C2 File Offset: 0x00001BC2
		[global::Cpp2ILInjected.Token(Token = "0x60004AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5CA4", Offset = "0x1EC5CA4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage)
		{
			throw null;
		}
	}
}
