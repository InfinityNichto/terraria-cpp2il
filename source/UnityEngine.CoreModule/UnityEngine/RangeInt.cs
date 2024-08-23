using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000093 RID: 147
	[global::Cpp2ILInjected.Token(Token = "0x20000A1")]
	public struct RangeInt
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000025D8 File Offset: 0x000007D8
		[global::Cpp2ILInjected.Token(Token = "0x170000AA")]
		public int end
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7A794", Offset = "0x1F7A794", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000025DB File Offset: 0x000007DB
		[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A7A0", Offset = "0x1F7A7A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public RangeInt(int start, int length)
		{
			throw null;
		}

		// Token: 0x04000321 RID: 801
		[global::Cpp2ILInjected.Token(Token = "0x4000351")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int start;

		// Token: 0x04000322 RID: 802
		[global::Cpp2ILInjected.Token(Token = "0x4000352")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int length;
	}
}
