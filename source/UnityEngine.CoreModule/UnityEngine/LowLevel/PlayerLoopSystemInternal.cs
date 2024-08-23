using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
	// Token: 0x0200014A RID: 330
	[RequiredByNativeCode]
	[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	[global::Cpp2ILInjected.Token(Token = "0x2000172")]
	internal struct PlayerLoopSystemInternal
	{
		// Token: 0x04000614 RID: 1556
		[global::Cpp2ILInjected.Token(Token = "0x400066B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Type type;

		// Token: 0x04000615 RID: 1557
		[global::Cpp2ILInjected.Token(Token = "0x400066C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public PlayerLoopSystem.UpdateFunction updateDelegate;

		// Token: 0x04000616 RID: 1558
		[global::Cpp2ILInjected.Token(Token = "0x400066D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public IntPtr updateFunction;

		// Token: 0x04000617 RID: 1559
		[global::Cpp2ILInjected.Token(Token = "0x400066E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IntPtr loopConditionFunction;

		// Token: 0x04000618 RID: 1560
		[global::Cpp2ILInjected.Token(Token = "0x400066F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int numSubSystems;
	}
}
