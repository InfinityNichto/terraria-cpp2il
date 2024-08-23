using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000009 RID: 9
	[NativeHeader("Runtime/Jobs/JobSystem.h")]
	[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public static class JobsUtility
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002065 File Offset: 0x00000265
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69ECC", Offset = "0x1F69ECC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void InvokePanicFunction()
		{
			throw null;
		}

		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		internal static JobsUtility.PanicFunction_ PanicFunction;

		// Token: 0x02000160 RID: 352
		// (Invoke) Token: 0x060006B5 RID: 1717
		[global::Cpp2ILInjected.Token(Token = "0x200000A")]
		internal delegate void PanicFunction_();
	}
}
