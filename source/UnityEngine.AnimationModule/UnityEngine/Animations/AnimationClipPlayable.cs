using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000017 RID: 23
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
	[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType.DoubleColon)]
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable>
	{
		// Token: 0x06000035 RID: 53 RVA: 0x000020D7 File Offset: 0x000002D7
		[global::Cpp2ILInjected.Token(Token = "0x6000037")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6782C", Offset = "0x1F6782C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020DA File Offset: 0x000002DA
		[global::Cpp2ILInjected.Token(Token = "0x6000038")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67838", Offset = "0x1F67838", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(PlayableHandle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(AnimationClipPlayable other)
		{
			throw null;
		}

		// Token: 0x04000045 RID: 69
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
