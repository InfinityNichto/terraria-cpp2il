using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	[global::Cpp2ILInjected.Token(Token = "0x2000173")]
	public struct PlayerLoopSystem
	{
		[global::Cpp2ILInjected.Token(Token = "0x60006E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9275C", Offset = "0x1F9275C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000670")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Type type;

		[global::Cpp2ILInjected.Token(Token = "0x4000671")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public PlayerLoopSystem[] subSystemList;

		[global::Cpp2ILInjected.Token(Token = "0x4000672")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public PlayerLoopSystem.UpdateFunction updateDelegate;

		[global::Cpp2ILInjected.Token(Token = "0x4000673")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IntPtr updateFunction;

		[global::Cpp2ILInjected.Token(Token = "0x4000674")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public IntPtr loopConditionFunction;

		[global::Cpp2ILInjected.Token(Token = "0x2000174")]
		public delegate void UpdateFunction();
	}
}
