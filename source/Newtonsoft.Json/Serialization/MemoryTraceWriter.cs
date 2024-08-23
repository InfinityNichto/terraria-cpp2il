using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000064 RID: 100
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200007D")]
	public class MemoryTraceWriter : ITraceWriter
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00002CB7 File Offset: 0x00000EB7
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00002CBA File Offset: 0x00000EBA
		[global::Cpp2ILInjected.Token(Token = "0x170000C1")]
		public TraceLevel LevelFilter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000460")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFD40", Offset = "0x1CDFD40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000461")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFD48", Offset = "0x1CDFD48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002CBD File Offset: 0x00000EBD
		[global::Cpp2ILInjected.Token(Token = "0x6000462")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDFD50", Offset = "0x1CDFD50", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public MemoryTraceWriter()
		{
			throw null;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002CC0 File Offset: 0x00000EC0
		[global::Cpp2ILInjected.Token(Token = "0x6000463")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDFDD8", Offset = "0x1CDFDD8", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Dequeue", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Enqueue", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void Trace(TraceLevel level, string message, Exception ex)
		{
			throw null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002CC3 File Offset: 0x00000EC3
		[global::Cpp2ILInjected.Token(Token = "0x6000464")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0000", Offset = "0x1CE0000", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public IEnumerable<string> GetTraceMessages()
		{
			throw null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002CC6 File Offset: 0x00000EC6
		[global::Cpp2ILInjected.Token(Token = "0x6000465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0008", Offset = "0x1CE0008", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>.Enumerator), Member = "get_Current", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040001CC RID: 460
		[global::Cpp2ILInjected.Token(Token = "0x4000211")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Queue<string> _traceMessages;

		// Token: 0x040001CD RID: 461
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000212")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TraceLevel <LevelFilter>k__BackingField;
	}
}
