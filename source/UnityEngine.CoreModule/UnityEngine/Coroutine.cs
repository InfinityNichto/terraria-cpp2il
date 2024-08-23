using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000AE RID: 174
	[NativeHeader("Runtime/Mono/Coroutine.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000BF")]
	[StructLayout(0)]
	public sealed class Coroutine : YieldInstruction
	{
		// Token: 0x06000337 RID: 823 RVA: 0x000026B0 File Offset: 0x000008B0
		[global::Cpp2ILInjected.Token(Token = "0x6000349")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D934", Offset = "0x1F7D934", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private Coroutine()
		{
			throw null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000026B3 File Offset: 0x000008B3
		[global::Cpp2ILInjected.Token(Token = "0x600034A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D93C", Offset = "0x1F7D93C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06000339 RID: 825
		[FreeFunction("Coroutine::CleanupCoroutineGC", true)]
		[global::Cpp2ILInjected.Token(Token = "0x600034B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D9F8", Offset = "0x1F7D9F8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void ReleaseCoroutine(IntPtr ptr);

		// Token: 0x0400033E RID: 830
		[global::Cpp2ILInjected.Token(Token = "0x4000373")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
