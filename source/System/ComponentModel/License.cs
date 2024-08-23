using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200029B RID: 667
	[global::Cpp2ILInjected.Token(Token = "0x2000393")]
	public abstract class License : IDisposable
	{
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600157D RID: 5501
		[global::Cpp2ILInjected.Token(Token = "0x1700056D")]
		public abstract string LicenseKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017CB")]
			get;
		}

		// Token: 0x0600157E RID: 5502
		[global::Cpp2ILInjected.Token(Token = "0x60017CC")]
		public abstract void Dispose();

		// Token: 0x0600157F RID: 5503 RVA: 0x00006AB8 File Offset: 0x00004CB8
		[global::Cpp2ILInjected.Token(Token = "0x60017CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DC94", Offset = "0x1E4DC94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected License()
		{
			throw null;
		}
	}
}
