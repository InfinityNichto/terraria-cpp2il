using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000074 RID: 116
	[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200007B")]
	public sealed class ReflectionProbe : Behaviour
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x00002413 File Offset: 0x00000613
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75FB4", Offset = "0x1F75FB4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent)
		{
			throw null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002416 File Offset: 0x00000616
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60001F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76034", Offset = "0x1F76034", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void CallSetDefaultReflection(Texture defaultReflectionCubemap)
		{
			throw null;
		}

		// Token: 0x040002E5 RID: 741
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40002EC")]
		private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged;

		// Token: 0x040002E6 RID: 742
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40002ED")]
		private static Action<Texture> defaultReflectionTexture;

		// Token: 0x02000167 RID: 359
		[global::Cpp2ILInjected.Token(Token = "0x200007C")]
		public enum ReflectionProbeEvent
		{
			// Token: 0x04000638 RID: 1592
			[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
			ReflectionProbeAdded,
			// Token: 0x04000639 RID: 1593
			[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
			ReflectionProbeRemoved
		}
	}
}
