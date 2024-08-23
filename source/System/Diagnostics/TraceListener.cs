using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x02000079 RID: 121
	[global::Cpp2ILInjected.Token(Token = "0x20000D1")]
	public abstract class TraceListener : MarshalByRefObject, IDisposable
	{
		// Token: 0x06000412 RID: 1042 RVA: 0x000039D7 File Offset: 0x00001BD7
		[global::Cpp2ILInjected.Token(Token = "0x60004B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC60B8", Offset = "0x1EC60B8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		protected TraceListener(string name)
		{
			throw null;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x000039DA File Offset: 0x00001BDA
		[global::Cpp2ILInjected.Token(Token = "0x170000D5")]
		public virtual bool IsThreadSafe
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC60F0", Offset = "0x1EC60F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000039DD File Offset: 0x00001BDD
		[global::Cpp2ILInjected.Token(Token = "0x60004B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC60F8", Offset = "0x1EC60F8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000039E0 File Offset: 0x00001BE0
		[global::Cpp2ILInjected.Token(Token = "0x60004B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6164", Offset = "0x1EC6164", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000039E3 File Offset: 0x00001BE3
		[global::Cpp2ILInjected.Token(Token = "0x60004B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6168", Offset = "0x1EC6168", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Flush()
		{
			throw null;
		}

		// Token: 0x170000D0 RID: 208
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x000039E6 File Offset: 0x00001BE6
		[global::Cpp2ILInjected.Token(Token = "0x170000D6")]
		public int IndentLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5DA0", Offset = "0x1EC5DA0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x000039E9 File Offset: 0x00001BE9
		[global::Cpp2ILInjected.Token(Token = "0x170000D7")]
		public int IndentSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5DAC", Offset = "0x1EC5DAC", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceInternal), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListenerCollection), Member = "InitializeListener", MemberParameters = new object[] { typeof(TraceListener) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x000039EC File Offset: 0x00001BEC
		[ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170000D8")]
		public TraceFilter Filter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC616C", Offset = "0x1EC616C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x000039EF File Offset: 0x00001BEF
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x000039F2 File Offset: 0x00001BF2
		[global::Cpp2ILInjected.Token(Token = "0x170000D9")]
		protected bool NeedIndent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC6174", Offset = "0x1EC6174", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC617C", Offset = "0x1EC617C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x000039F5 File Offset: 0x00001BF5
		[ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170000DA")]
		public TraceOptions TraceOutputOptions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC6188", Offset = "0x1EC6188", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600041D RID: 1053
		[global::Cpp2ILInjected.Token(Token = "0x60004BD")]
		public abstract void Write(string message);

		// Token: 0x0600041E RID: 1054 RVA: 0x000039F8 File Offset: 0x00001BF8
		[global::Cpp2ILInjected.Token(Token = "0x60004BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6190", Offset = "0x1EC6190", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void WriteIndent()
		{
			throw null;
		}

		// Token: 0x0600041F RID: 1055
		[global::Cpp2ILInjected.Token(Token = "0x60004BF")]
		public abstract void WriteLine(string message);

		// Token: 0x06000420 RID: 1056 RVA: 0x000039FB File Offset: 0x00001BFB
		[ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6264", Offset = "0x1EC6264", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListener), Member = "WriteHeader", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TraceEventType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListener), Member = "WriteFooter", MemberParameters = new object[] { typeof(TraceEventCache) }, ReturnType = typeof(void))]
		public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			throw null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000039FE File Offset: 0x00001BFE
		[global::Cpp2ILInjected.Token(Token = "0x60004C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6328", Offset = "0x1EC6328", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListener), Member = "TraceEvent", MemberParameters = new object[]
		{
			typeof(TraceEventCache),
			typeof(string),
			typeof(TraceEventType),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void WriteHeader(string source, TraceEventType eventType, int id)
		{
			throw null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00003A01 File Offset: 0x00001C01
		[global::Cpp2ILInjected.Token(Token = "0x60004C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6438", Offset = "0x1EC6438", Length = "0x584")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListener), Member = "TraceEvent", MemberParameters = new object[]
		{
			typeof(TraceEventCache),
			typeof(string),
			typeof(TraceEventType),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceEventCache), Member = "GetProcessId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Trace), Member = "get_CorrelationManager", ReturnType = typeof(CorrelationManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CorrelationManager), Member = "GetLogicalOperationStack", ReturnType = typeof(Stack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceEventCache), Member = "get_ThreadId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceEventCache), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceEventCache), Member = "get_Timestamp", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_StackTrace", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void WriteFooter(TraceEventCache eventCache)
		{
			throw null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00003A04 File Offset: 0x00001C04
		[global::Cpp2ILInjected.Token(Token = "0x60004C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC69BC", Offset = "0x1EC69BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool IsEnabled(TraceOptions opts)
		{
			throw null;
		}

		// Token: 0x04000270 RID: 624
		[global::Cpp2ILInjected.Token(Token = "0x40003B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int indentLevel;

		// Token: 0x04000271 RID: 625
		[global::Cpp2ILInjected.Token(Token = "0x40003B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int indentSize;

		// Token: 0x04000272 RID: 626
		[global::Cpp2ILInjected.Token(Token = "0x40003B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TraceOptions traceOptions;

		// Token: 0x04000273 RID: 627
		[global::Cpp2ILInjected.Token(Token = "0x40003B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private bool needIndent;

		// Token: 0x04000274 RID: 628
		[global::Cpp2ILInjected.Token(Token = "0x40003B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string listenerName;

		// Token: 0x04000275 RID: 629
		[global::Cpp2ILInjected.Token(Token = "0x40003B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private TraceFilter filter;
	}
}
