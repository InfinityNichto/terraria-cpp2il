using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C1 RID: 193
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000D3")]
	public sealed class ComputeShader : Object
	{
		// Token: 0x06000441 RID: 1089
		[RequiredByNativeCode]
		[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000455")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F839FC", Offset = "0x1F839FC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern int FindKernel(string name);
	}
}
