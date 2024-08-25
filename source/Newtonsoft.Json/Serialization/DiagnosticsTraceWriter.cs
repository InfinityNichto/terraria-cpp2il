using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000079")]
	public class DiagnosticsTraceWriter : ITraceWriter
	{
		[global::Cpp2ILInjected.Token(Token = "0x170000B9")]
		public TraceLevel LevelFilter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600044B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDF70C", Offset = "0x1CDF70C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600044C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDF714", Offset = "0x1CDF714", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600044D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF71C", Offset = "0x1CDF71C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DiagnosticsTraceWriter), Member = "Trace", MemberParameters = new object[]
		{
			typeof(TraceLevel),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private TraceEventType GetTraceEventType(TraceLevel level)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600044E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDF788", Offset = "0x1CDF788", Length = "0x448")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceEventCache), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiagnosticsTraceWriter), Member = "GetTraceEventType", MemberParameters = new object[] { typeof(TraceLevel) }, ReturnType = typeof(TraceEventType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Trace), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListenerCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Trace), Member = "get_AutoFlush", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public void Trace(TraceLevel level, string message, Exception ex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600044F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDFBD0", Offset = "0x1CDFBD0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DiagnosticsTraceWriter()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400020A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private TraceLevel <LevelFilter>k__BackingField;
	}
}
