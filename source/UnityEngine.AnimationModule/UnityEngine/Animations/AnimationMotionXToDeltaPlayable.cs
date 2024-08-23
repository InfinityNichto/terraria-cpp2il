using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x0200001A RID: 26
	[RequiredByNativeCode]
	[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable>
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000020E9 File Offset: 0x000002E9
		[global::Cpp2ILInjected.Token(Token = "0x600003D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67AC0", Offset = "0x1F67AC0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnimationMotionXToDeltaPlayable), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle[]), Member = "IsPlayableOfType", MemberTypeParameters = new object[] { typeof(AnimationMotionXToDeltaPlayable) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private AnimationMotionXToDeltaPlayable(PlayableHandle handle)
		{
			throw null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000020EC File Offset: 0x000002EC
		[global::Cpp2ILInjected.Token(Token = "0x600003E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67B7C", Offset = "0x1F67B7C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000020EF File Offset: 0x000002EF
		[global::Cpp2ILInjected.Token(Token = "0x600003F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67B88", Offset = "0x1F67B88", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(PlayableHandle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(AnimationMotionXToDeltaPlayable other)
		{
			throw null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000020F2 File Offset: 0x000002F2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000040")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67C00", Offset = "0x1F67C00", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationMotionXToDeltaPlayable), Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static AnimationMotionXToDeltaPlayable()
		{
			throw null;
		}

		// Token: 0x04000049 RID: 73
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x0400004A RID: 74
		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable;
	}
}
