using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
	// Token: 0x0200014B RID: 331
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	[global::Cpp2ILInjected.Token(Token = "0x2000173")]
	public struct PlayerLoopSystem
	{
		// Token: 0x060006A7 RID: 1703 RVA: 0x00002F59 File Offset: 0x00001159
		[global::Cpp2ILInjected.Token(Token = "0x60006E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9275C", Offset = "0x1F9275C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000619 RID: 1561
		[global::Cpp2ILInjected.Token(Token = "0x4000670")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Type type;

		// Token: 0x0400061A RID: 1562
		[global::Cpp2ILInjected.Token(Token = "0x4000671")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public PlayerLoopSystem[] subSystemList;

		// Token: 0x0400061B RID: 1563
		[global::Cpp2ILInjected.Token(Token = "0x4000672")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public PlayerLoopSystem.UpdateFunction updateDelegate;

		// Token: 0x0400061C RID: 1564
		[global::Cpp2ILInjected.Token(Token = "0x4000673")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IntPtr updateFunction;

		// Token: 0x0400061D RID: 1565
		[global::Cpp2ILInjected.Token(Token = "0x4000674")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public IntPtr loopConditionFunction;

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x060006F1 RID: 1777
		[global::Cpp2ILInjected.Token(Token = "0x2000174")]
		public delegate void UpdateFunction();
	}
}
