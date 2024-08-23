using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000034 RID: 52
	[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000037")]
	internal sealed class DebugLogHandler : ILogHandler
	{
		// Token: 0x06000055 RID: 85
		[ThreadAndSerializationSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B040", Offset = "0x1F6B040", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern void Internal_Log(LogType level, LogOption options, string msg, Object obj);

		// Token: 0x06000056 RID: 86
		[ThreadAndSerializationSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600005E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B09C", Offset = "0x1F6B09C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern void Internal_LogException(Exception ex, Object obj);

		// Token: 0x06000057 RID: 87 RVA: 0x0000210A File Offset: 0x0000030A
		[global::Cpp2ILInjected.Token(Token = "0x600005F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B0E0", Offset = "0x1F6B0E0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000210D File Offset: 0x0000030D
		[global::Cpp2ILInjected.Token(Token = "0x6000060")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B148", Offset = "0x1F6B148", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void LogException(Exception exception, Object context)
		{
			throw null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002110 File Offset: 0x00000310
		[global::Cpp2ILInjected.Token(Token = "0x6000061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B1D8", Offset = "0x1F6B1D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DebugLogHandler()
		{
			throw null;
		}
	}
}
