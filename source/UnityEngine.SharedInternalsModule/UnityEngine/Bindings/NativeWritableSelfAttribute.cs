using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000E RID: 14
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	internal sealed class NativeWritableSelfAttribute : Attribute
	{
		// Token: 0x17000009 RID: 9
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002092 File Offset: 0x00000292
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public bool WritableSelf
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000017")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3D50", Offset = "0x1FA3D50", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002095 File Offset: 0x00000295
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3D5C", Offset = "0x1FA3D5C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativeWritableSelfAttribute()
		{
			throw null;
		}

		// Token: 0x0400000B RID: 11
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <WritableSelf>k__BackingField;
	}
}
