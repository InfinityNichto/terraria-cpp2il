using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x02000074 RID: 116
	[global::Cpp2ILInjected.Token(Token = "0x20000CC")]
	public class TraceEventCache
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x000039A4 File Offset: 0x00001BA4
		[global::Cpp2ILInjected.Token(Token = "0x170000CB")]
		public string Callstack
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5670", Offset = "0x1EC5670", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_StackTrace", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x000039A7 File Offset: 0x00001BA7
		[global::Cpp2ILInjected.Token(Token = "0x170000CC")]
		public Stack LogicalOperationStack
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5690", Offset = "0x1EC5690", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Trace), Member = "get_CorrelationManager", ReturnType = typeof(CorrelationManager))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CorrelationManager), Member = "GetLogicalOperationStack", ReturnType = typeof(Stack))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x000039AA File Offset: 0x00001BAA
		[global::Cpp2ILInjected.Token(Token = "0x170000CD")]
		public DateTime DateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC56A0", Offset = "0x1EC56A0", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListener), Member = "WriteFooter", MemberParameters = new object[] { typeof(TraceEventCache) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000039AD File Offset: 0x00001BAD
		[global::Cpp2ILInjected.Token(Token = "0x170000CE")]
		public int ProcessId
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5734", Offset = "0x1EC5734", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000039B0 File Offset: 0x00001BB0
		[global::Cpp2ILInjected.Token(Token = "0x170000CF")]
		public string ThreadId
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC578C", Offset = "0x1EC578C", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListener), Member = "WriteFooter", MemberParameters = new object[] { typeof(TraceEventCache) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x000039B3 File Offset: 0x00001BB3
		[global::Cpp2ILInjected.Token(Token = "0x170000D0")]
		public long Timestamp
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5820", Offset = "0x1EC5820", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListener), Member = "WriteFooter", MemberParameters = new object[] { typeof(TraceEventCache) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000039B6 File Offset: 0x00001BB6
		[global::Cpp2ILInjected.Token(Token = "0x60004A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5888", Offset = "0x1EC5888", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceEventCache), Member = "GetProcessId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new object[] { "System.Diagnostics.Process.State" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void InitProcessInfo()
		{
			throw null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000039B9 File Offset: 0x00001BB9
		[global::Cpp2ILInjected.Token(Token = "0x60004A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5738", Offset = "0x1EC5738", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListener), Member = "WriteFooter", MemberParameters = new object[] { typeof(TraceEventCache) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int GetProcessId()
		{
			throw null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000039BC File Offset: 0x00001BBC
		[global::Cpp2ILInjected.Token(Token = "0x60004A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5808", Offset = "0x1EC5808", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
		internal static int GetThreadId()
		{
			throw null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000039BF File Offset: 0x00001BBF
		[global::Cpp2ILInjected.Token(Token = "0x60004A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5C34", Offset = "0x1EC5C34", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DiagnosticsTraceWriter", Member = "Trace", MemberParameters = new object[]
		{
			typeof(TraceLevel),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TraceEventCache()
		{
			throw null;
		}

		// Token: 0x04000254 RID: 596
		[global::Cpp2ILInjected.Token(Token = "0x4000395")]
		private static int processId;

		// Token: 0x04000255 RID: 597
		[global::Cpp2ILInjected.Token(Token = "0x4000396")]
		private static string processName;

		// Token: 0x04000256 RID: 598
		[global::Cpp2ILInjected.Token(Token = "0x4000397")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private long timeStamp;

		// Token: 0x04000257 RID: 599
		[global::Cpp2ILInjected.Token(Token = "0x4000398")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private DateTime dateTime;

		// Token: 0x04000258 RID: 600
		[global::Cpp2ILInjected.Token(Token = "0x4000399")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string stackTrace;
	}
}
