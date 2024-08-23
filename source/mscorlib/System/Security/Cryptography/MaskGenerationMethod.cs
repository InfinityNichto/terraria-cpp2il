using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000248 RID: 584
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002E5")]
	public abstract class MaskGenerationMethod
	{
		// Token: 0x060016C6 RID: 5830
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x60018E0")]
		public abstract byte[] GenerateMask(byte[] rgbSeed, int cbReturn);

		// Token: 0x060016C7 RID: 5831 RVA: 0x000184EE File Offset: 0x000166EE
		[global::Cpp2ILInjected.Token(Token = "0x60018E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFFDC0", Offset = "0x1AFFDC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected MaskGenerationMethod()
		{
			throw null;
		}
	}
}
