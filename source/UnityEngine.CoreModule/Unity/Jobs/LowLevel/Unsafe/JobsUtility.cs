using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Jobs.LowLevel.Unsafe
{
	[NativeHeader("Runtime/Jobs/JobSystem.h")]
	[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public static class JobsUtility
	{
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69ECC", Offset = "0x1F69ECC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void InvokePanicFunction()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		internal static JobsUtility.PanicFunction_ PanicFunction;

		[global::Cpp2ILInjected.Token(Token = "0x200000A")]
		internal delegate void PanicFunction_();
	}
}
