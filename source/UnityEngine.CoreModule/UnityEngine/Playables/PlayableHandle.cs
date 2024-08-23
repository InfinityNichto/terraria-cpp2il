using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x0200012D RID: 301
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000154")]
	public struct PlayableHandle : IEquatable<PlayableHandle>
	{
		// Token: 0x0600061C RID: 1564 RVA: 0x00002E00 File Offset: 0x00001000
		[VisibleToOtherModules]
		[global::Cpp2ILInjected.Token(Token = "0x6000654")]
		[global::Cpp2ILInjected.Address(RVA = "0x15942C4", Offset = "0x15942C4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "GetPlayableType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool IsPlayableOfType<T>()
		{
			throw null;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00002E03 File Offset: 0x00001003
		[global::Cpp2ILInjected.Token(Token = "0x17000152")]
		public static PlayableHandle Null
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000655")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8FFCC", Offset = "0x1F8FFCC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Playable), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002E06 File Offset: 0x00001006
		[global::Cpp2ILInjected.Token(Token = "0x6000656")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F890", Offset = "0x1F8F890", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CameraPlayable), Member = "Equals", MemberParameters = new object[] { typeof(CameraPlayable) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureMixerPlayable), Member = "Equals", MemberParameters = new object[] { typeof(TextureMixerPlayable) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Playable), Member = "Equals", MemberParameters = new object[] { typeof(Playable) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Animations.AnimatorControllerPlayable" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Animations.AnimationScriptPlayable" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Animations.AnimationLayerMixerPlayable" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationClipPlayable", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Animations.AnimationClipPlayable" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Animations.AnimationMotionXToDeltaPlayable" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Animations.AnimationMixerPlayable" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Audio.AudioClipPlayable", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Audio.AudioClipPlayable" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Audio.AudioMixerPlayable", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Audio.AudioMixerPlayable" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator ==(PlayableHandle x, PlayableHandle y)
		{
			throw null;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002E09 File Offset: 0x00001009
		[global::Cpp2ILInjected.Token(Token = "0x6000657")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F902A0", Offset = "0x1F902A0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object p)
		{
			throw null;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002E0C File Offset: 0x0000100C
		[global::Cpp2ILInjected.Token(Token = "0x6000658")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90318", Offset = "0x1F90318", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(PlayableHandle other)
		{
			throw null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002E0F File Offset: 0x0000100F
		[global::Cpp2ILInjected.Token(Token = "0x6000659")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90398", Offset = "0x1F90398", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00002E12 File Offset: 0x00001012
		[global::Cpp2ILInjected.Token(Token = "0x600065A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9026C", Offset = "0x1F9026C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
		{
			throw null;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002E15 File Offset: 0x00001015
		[VisibleToOtherModules]
		[global::Cpp2ILInjected.Token(Token = "0x600065B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F903CC", Offset = "0x1F903CC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = "SetHandle", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal bool IsValid()
		{
			throw null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00002E18 File Offset: 0x00001018
		[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		[global::Cpp2ILInjected.Token(Token = "0x600065C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9047C", Offset = "0x1F9047C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayableHandle), Member = "IsPlayableOfType", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal Type GetPlayableType()
		{
			throw null;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002E1B File Offset: 0x0000101B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600065D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9052C", Offset = "0x1F9052C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PlayableHandle()
		{
			throw null;
		}

		// Token: 0x06000626 RID: 1574
		[global::Cpp2ILInjected.Token(Token = "0x600065E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90440", Offset = "0x1F90440", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool IsValid_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000627 RID: 1575
		[global::Cpp2ILInjected.Token(Token = "0x600065F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F904F0", Offset = "0x1F904F0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern Type GetPlayableType_Injected(ref PlayableHandle _unity_self);

		// Token: 0x040005DD RID: 1501
		[global::Cpp2ILInjected.Token(Token = "0x4000633")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal IntPtr m_Handle;

		// Token: 0x040005DE RID: 1502
		[global::Cpp2ILInjected.Token(Token = "0x4000634")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal uint m_Version;

		// Token: 0x040005DF RID: 1503
		[global::Cpp2ILInjected.Token(Token = "0x4000635")]
		private static readonly PlayableHandle m_Null;
	}
}
