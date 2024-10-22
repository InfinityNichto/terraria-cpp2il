﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000143")]
	public struct MaterialEffectPlayable : IEquatable<MaterialEffectPlayable>
	{
		[global::Cpp2ILInjected.Token(Token = "0x600062A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F810", Offset = "0x1F8F810", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600062B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8F81C", Offset = "0x1F8F81C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(MaterialEffectPlayable other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400060F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
