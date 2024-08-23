using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000073 RID: 115
	[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000079")]
	[StructLayout(0)]
	public class CullingGroup
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00002410 File Offset: 0x00000610
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75E64", Offset = "0x1F75E64", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
			throw null;
		}

		// Token: 0x040002E3 RID: 739
		[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		// Token: 0x040002E4 RID: 740
		[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private CullingGroup.StateChanged m_OnStateChanged;

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x060006BF RID: 1727
		[global::Cpp2ILInjected.Token(Token = "0x200007A")]
		public delegate void StateChanged(CullingGroupEvent sphere);
	}
}
