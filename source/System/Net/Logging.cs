using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000181 RID: 385
	[global::Cpp2ILInjected.Token(Token = "0x2000229")]
	internal static class Logging
	{
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x000051C8 File Offset: 0x000033C8
		[global::Cpp2ILInjected.Token(Token = "0x170002E6")]
		internal static bool On
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CBB8", Offset = "0x1F3CBB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 58)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000051CB File Offset: 0x000033CB
		[global::Cpp2ILInjected.Token(Token = "0x170002E7")]
		internal static TraceSource Web
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CBC0", Offset = "0x1F3CBC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x000051CE File Offset: 0x000033CE
		[global::Cpp2ILInjected.Token(Token = "0x170002E8")]
		internal static TraceSource HttpListener
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CBC8", Offset = "0x1F3CBC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x000051D1 File Offset: 0x000033D1
		[global::Cpp2ILInjected.Token(Token = "0x170002E9")]
		internal static TraceSource Sockets
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CBD0", Offset = "0x1F3CBD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000051D4 File Offset: 0x000033D4
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBD8", Offset = "0x1F3CBD8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Enter(TraceSource traceSource, object obj, string method, object paramObject)
		{
			throw null;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000051D7 File Offset: 0x000033D7
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBDC", Offset = "0x1F3CBDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Enter(TraceSource traceSource, string msg)
		{
			throw null;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000051DA File Offset: 0x000033DA
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBE0", Offset = "0x1F3CBE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Enter(TraceSource traceSource, string msg, string parameters)
		{
			throw null;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x000051DD File Offset: 0x000033DD
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBE4", Offset = "0x1F3CBE4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Exception(TraceSource traceSource, object obj, string method, Exception e)
		{
			throw null;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000051E0 File Offset: 0x000033E0
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBE8", Offset = "0x1F3CBE8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Exit(TraceSource traceSource, object obj, string method, object retObject)
		{
			throw null;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000051E3 File Offset: 0x000033E3
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBEC", Offset = "0x1F3CBEC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Exit(TraceSource traceSource, string msg)
		{
			throw null;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000051E6 File Offset: 0x000033E6
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBF0", Offset = "0x1F3CBF0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Exit(TraceSource traceSource, string msg, string parameters)
		{
			throw null;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000051E9 File Offset: 0x000033E9
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBF4", Offset = "0x1F3CBF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintInfo(TraceSource traceSource, object obj, string method, string msg)
		{
			throw null;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000051EC File Offset: 0x000033EC
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBF8", Offset = "0x1F3CBF8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintInfo(TraceSource traceSource, object obj, string msg)
		{
			throw null;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000051EF File Offset: 0x000033EF
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBFC", Offset = "0x1F3CBFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintInfo(TraceSource traceSource, string msg)
		{
			throw null;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000051F2 File Offset: 0x000033F2
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CC00", Offset = "0x1F3CC00", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintWarning(TraceSource traceSource, object obj, string method, string msg)
		{
			throw null;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000051F5 File Offset: 0x000033F5
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CC04", Offset = "0x1F3CC04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintWarning(TraceSource traceSource, string msg)
		{
			throw null;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000051F8 File Offset: 0x000033F8
		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CC08", Offset = "0x1F3CC08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintError(TraceSource traceSource, string msg)
		{
			throw null;
		}
	}
}
