using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000091 RID: 145
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200009F")]
	public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x00002596 File Offset: 0x00000796
		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A044", Offset = "0x1F7A044", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PreserveAttribute), Member = ".ctor", ReturnType = typeof(void))]
		public RuntimeInitializeOnLoadMethodAttribute()
		{
			throw null;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002599 File Offset: 0x00000799
		[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A068", Offset = "0x1F7A068", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PreserveAttribute), Member = ".ctor", ReturnType = typeof(void))]
		public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
		{
			throw null;
		}

		// Token: 0x170000A2 RID: 162
		// (set) Token: 0x060002AB RID: 683 RVA: 0x0000259C File Offset: 0x0000079C
		[global::Cpp2ILInjected.Token(Token = "0x170000A4")]
		private RuntimeInitializeLoadType loadType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7A060", Offset = "0x1F7A060", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000320 RID: 800
		[global::Cpp2ILInjected.Token(Token = "0x4000350")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RuntimeInitializeLoadType m_LoadType;
	}
}
