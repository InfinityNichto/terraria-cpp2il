using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
	[RequiredByNativeCode]
	[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	[global::Cpp2ILInjected.Token(Token = "0x2000172")]
	internal struct PlayerLoopSystemInternal
	{
		[global::Cpp2ILInjected.Token(Token = "0x400066B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Type type;

		[global::Cpp2ILInjected.Token(Token = "0x400066C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public PlayerLoopSystem.UpdateFunction updateDelegate;

		[global::Cpp2ILInjected.Token(Token = "0x400066D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public IntPtr updateFunction;

		[global::Cpp2ILInjected.Token(Token = "0x400066E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IntPtr loopConditionFunction;

		[global::Cpp2ILInjected.Token(Token = "0x400066F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int numSubSystems;
	}
}
