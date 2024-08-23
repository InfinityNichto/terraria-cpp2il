using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000283 RID: 643
	[global::Cpp2ILInjected.Token(Token = "0x200037A")]
	public class HandledEventArgs : EventArgs
	{
		// Token: 0x06001510 RID: 5392 RVA: 0x00006A52 File Offset: 0x00004C52
		[global::Cpp2ILInjected.Token(Token = "0x600175B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4CD44", Offset = "0x1E4CD44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HandledEventArgs()
		{
			throw null;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00006A55 File Offset: 0x00004C55
		[global::Cpp2ILInjected.Token(Token = "0x600175C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4CD4C", Offset = "0x1E4CD4C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HandledEventArgs(bool defaultHandledValue)
		{
			throw null;
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x00006A58 File Offset: 0x00004C58
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x00006A5B File Offset: 0x00004C5B
		[global::Cpp2ILInjected.Token(Token = "0x1700054E")]
		public bool Handled
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600175D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4CDBC", Offset = "0x1E4CDBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600175E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4CDC4", Offset = "0x1E4CDC4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000E23 RID: 3619
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400122B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <Handled>k__BackingField;
	}
}
