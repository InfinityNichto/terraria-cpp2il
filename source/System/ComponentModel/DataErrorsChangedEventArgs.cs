using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002CD RID: 717
	[global::Cpp2ILInjected.Token(Token = "0x20003CC")]
	public class DataErrorsChangedEventArgs : EventArgs
	{
		// Token: 0x06001762 RID: 5986 RVA: 0x0000701C File Offset: 0x0000521C
		[global::Cpp2ILInjected.Token(Token = "0x60019C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6037C", Offset = "0x1E6037C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DataErrorsChangedEventArgs(string propertyName)
		{
			throw null;
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x0000701F File Offset: 0x0000521F
		[global::Cpp2ILInjected.Token(Token = "0x170005DE")]
		public virtual string PropertyName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E603E8", Offset = "0x1E603E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000EBF RID: 3775
		[global::Cpp2ILInjected.Token(Token = "0x40012DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _propertyName;
	}
}
