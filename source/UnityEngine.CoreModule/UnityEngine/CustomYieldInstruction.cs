using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x020000B6 RID: 182
	[global::Cpp2ILInjected.Token(Token = "0x20000C8")]
	public abstract class CustomYieldInstruction : IEnumerator
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000369 RID: 873
		[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
		public abstract bool keepWaiting
		{
			[global::Cpp2ILInjected.Token(Token = "0x600037D")]
			get;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00002731 File Offset: 0x00000931
		[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
		public object Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x600037E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7ED24", Offset = "0x1F7ED24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002734 File Offset: 0x00000934
		[global::Cpp2ILInjected.Token(Token = "0x600037F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7ED2C", Offset = "0x1F7ED2C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool MoveNext()
		{
			throw null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002737 File Offset: 0x00000937
		[global::Cpp2ILInjected.Token(Token = "0x6000380")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7ED38", Offset = "0x1F7ED38", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Reset()
		{
			throw null;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000273A File Offset: 0x0000093A
		[global::Cpp2ILInjected.Token(Token = "0x6000381")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7DB18", Offset = "0x1F7DB18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CustomYieldInstruction()
		{
			throw null;
		}
	}
}
