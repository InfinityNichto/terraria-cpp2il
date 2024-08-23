using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x0200001B RID: 27
	[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
	[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable>
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000020F5 File Offset: 0x000002F5
		[global::Cpp2ILInjected.Token(Token = "0x6000041")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67C9C", Offset = "0x1F67C9C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnimationMixerPlayable), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle[]), Member = "IsPlayableOfType", MemberTypeParameters = new object[] { typeof(AnimationMixerPlayable) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal AnimationMixerPlayable(PlayableHandle handle)
		{
			throw null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000020F8 File Offset: 0x000002F8
		[global::Cpp2ILInjected.Token(Token = "0x6000042")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67D58", Offset = "0x1F67D58", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000020FB File Offset: 0x000002FB
		[global::Cpp2ILInjected.Token(Token = "0x6000043")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67D64", Offset = "0x1F67D64", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(PlayableHandle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(AnimationMixerPlayable other)
		{
			throw null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000020FE File Offset: 0x000002FE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67DDC", Offset = "0x1F67DDC", Length = "0x109C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationMixerPlayable), Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static AnimationMixerPlayable()
		{
			throw null;
		}

		// Token: 0x0400004B RID: 75
		[global::Cpp2ILInjected.Token(Token = "0x400004B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x0400004C RID: 76
		[global::Cpp2ILInjected.Token(Token = "0x400004C")]
		private static readonly AnimationMixerPlayable m_NullPlayable;
	}
}
