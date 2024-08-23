using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000013 RID: 19
	[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
	[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000014")]
	public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable>
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000020A4 File Offset: 0x000002A4
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66F30", Offset = "0x1F66F30", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnimatorControllerPlayable), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal AnimatorControllerPlayable(PlayableHandle handle)
		{
			throw null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020A7 File Offset: 0x000002A7
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F670A8", Offset = "0x1F670A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020AA File Offset: 0x000002AA
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66FA8", Offset = "0x1F66FA8", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle[]), Member = "IsPlayableOfType", MemberTypeParameters = new object[] { typeof(AnimatorControllerPlayable) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void SetHandle(PlayableHandle handle)
		{
			throw null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020AD File Offset: 0x000002AD
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F670B4", Offset = "0x1F670B4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(PlayableHandle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(AnimatorControllerPlayable other)
		{
			throw null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020B0 File Offset: 0x000002B0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6712C", Offset = "0x1F6712C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimatorControllerPlayable), Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static AnimatorControllerPlayable()
		{
			throw null;
		}

		// Token: 0x0400003D RID: 61
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x0400003E RID: 62
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		private static readonly AnimatorControllerPlayable m_NullPlayable;
	}
}
