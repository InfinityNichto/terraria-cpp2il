﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType.DoubleColon)]
	[global::Cpp2ILInjected.Token(Token = "0x2000013")]
	internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66D20", Offset = "0x1F66D20", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnimationRemoveScalePlayable), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle[]), Member = "IsPlayableOfType", MemberTypeParameters = new object[] { typeof(AnimationRemoveScalePlayable) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal AnimationRemoveScalePlayable(PlayableHandle handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66DDC", Offset = "0x1F66DDC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66DE8", Offset = "0x1F66DE8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueType), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(AnimationRemoveScalePlayable other)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66E94", Offset = "0x1F66E94", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationRemoveScalePlayable), Member = ".ctor", MemberParameters = new object[] { typeof(PlayableHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static AnimationRemoveScalePlayable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		private static readonly AnimationRemoveScalePlayable m_NullPlayable;
	}
}
