using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x020000B0 RID: 176
	[global::Cpp2ILInjected.Token(Token = "0x20000C1")]
	public class WaitForSecondsRealtime : CustomYieldInstruction
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600033B RID: 827 RVA: 0x000026B9 File Offset: 0x000008B9
		// (set) Token: 0x0600033C RID: 828 RVA: 0x000026BC File Offset: 0x000008BC
		[global::Cpp2ILInjected.Token(Token = "0x170000B2")]
		public float waitTime
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600034D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7DA3C", Offset = "0x1F7DA3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600034E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7DA44", Offset = "0x1F7DA44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600033D RID: 829 RVA: 0x000026BF File Offset: 0x000008BF
		[global::Cpp2ILInjected.Token(Token = "0x170000B3")]
		public override bool keepWaiting
		{
			[global::Cpp2ILInjected.Token(Token = "0x600034F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7DA4C", Offset = "0x1F7DA4C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000026C2 File Offset: 0x000008C2
		[global::Cpp2ILInjected.Token(Token = "0x6000350")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7DAE8", Offset = "0x1F7DAE8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown.<DelayedDestroyDropdownList>d__75", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField.<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WaitForSecondsRealtime(float time)
		{
			throw null;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000026C5 File Offset: 0x000008C5
		[global::Cpp2ILInjected.Token(Token = "0x6000351")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7DB20", Offset = "0x1F7DB20", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x0400033F RID: 831
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000374")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float <waitTime>k__BackingField;

		// Token: 0x04000340 RID: 832
		[global::Cpp2ILInjected.Token(Token = "0x4000375")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float m_WaitUntilTime;
	}
}
