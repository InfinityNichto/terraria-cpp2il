using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x0200011E RID: 286
	[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000143")]
	public struct MaterialEffectPlayable : IEquatable<MaterialEffectPlayable>
	{
		// Token: 0x060005F4 RID: 1524 RVA: 0x00002D8E File Offset: 0x00000F8E
		[global::Cpp2ILInjected.Token(Token = "0x600062A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F810", Offset = "0x1F8F810", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002D91 File Offset: 0x00000F91
		[global::Cpp2ILInjected.Token(Token = "0x600062B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F81C", Offset = "0x1F8F81C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(MaterialEffectPlayable other)
		{
			throw null;
		}

		// Token: 0x040005C0 RID: 1472
		[global::Cpp2ILInjected.Token(Token = "0x400060F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
