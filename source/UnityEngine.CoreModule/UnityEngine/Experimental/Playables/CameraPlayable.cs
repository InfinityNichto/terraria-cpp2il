using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x0200011F RID: 287
	[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("CameraPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000144")]
	public struct CameraPlayable : IEquatable<CameraPlayable>
	{
		// Token: 0x060005F6 RID: 1526 RVA: 0x00002D94 File Offset: 0x00000F94
		[global::Cpp2ILInjected.Token(Token = "0x600062C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F918", Offset = "0x1F8F918", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002D97 File Offset: 0x00000F97
		[global::Cpp2ILInjected.Token(Token = "0x600062D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F924", Offset = "0x1F8F924", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(PlayableHandle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(CameraPlayable other)
		{
			throw null;
		}

		// Token: 0x040005C1 RID: 1473
		[global::Cpp2ILInjected.Token(Token = "0x4000610")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
