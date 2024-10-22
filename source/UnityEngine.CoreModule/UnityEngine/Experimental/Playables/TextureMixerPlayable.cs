﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000146")]
	public struct TextureMixerPlayable : IEquatable<TextureMixerPlayable>
	{
		[global::Cpp2ILInjected.Token(Token = "0x600062E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F998", Offset = "0x1F8F998", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600062F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F9A4", Offset = "0x1F8F9A4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(PlayableHandle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(TextureMixerPlayable other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000612")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
