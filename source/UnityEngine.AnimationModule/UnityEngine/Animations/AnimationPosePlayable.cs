using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000019 RID: 25
	[RequiredByNativeCode]
	[StaticAccessor("AnimationPosePlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable>
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000020DD File Offset: 0x000002DD
		[global::Cpp2ILInjected.Token(Token = "0x6000039")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F678B0", Offset = "0x1F678B0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnimationPosePlayable), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle[]), Member = "IsPlayableOfType", MemberTypeParameters = new object[] { typeof(AnimationPosePlayable) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal AnimationPosePlayable(PlayableHandle handle)
		{
			throw null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000020E0 File Offset: 0x000002E0
		[global::Cpp2ILInjected.Token(Token = "0x600003A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6796C", Offset = "0x1F6796C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000020E3 File Offset: 0x000002E3
		[global::Cpp2ILInjected.Token(Token = "0x600003B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67978", Offset = "0x1F67978", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueType), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(AnimationPosePlayable other)
		{
			throw null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000020E6 File Offset: 0x000002E6
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600003C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F67A24", Offset = "0x1F67A24", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationPosePlayable), Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static AnimationPosePlayable()
		{
			throw null;
		}

		// Token: 0x04000047 RID: 71
		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x04000048 RID: 72
		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		private static readonly AnimationPosePlayable m_NullPlayable;
	}
}
