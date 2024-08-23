using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000284 RID: 644
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000321")]
	public enum X509KeyStorageFlags
	{
		// Token: 0x04000AF4 RID: 2804
		[global::Cpp2ILInjected.Token(Token = "0x4000DCE")]
		DefaultKeySet = 0,
		// Token: 0x04000AF5 RID: 2805
		[global::Cpp2ILInjected.Token(Token = "0x4000DCF")]
		UserKeySet = 1,
		// Token: 0x04000AF6 RID: 2806
		[global::Cpp2ILInjected.Token(Token = "0x4000DD0")]
		MachineKeySet = 2,
		// Token: 0x04000AF7 RID: 2807
		[global::Cpp2ILInjected.Token(Token = "0x4000DD1")]
		Exportable = 4,
		// Token: 0x04000AF8 RID: 2808
		[global::Cpp2ILInjected.Token(Token = "0x4000DD2")]
		UserProtected = 8,
		// Token: 0x04000AF9 RID: 2809
		[global::Cpp2ILInjected.Token(Token = "0x4000DD3")]
		PersistKeySet = 16,
		// Token: 0x04000AFA RID: 2810
		[global::Cpp2ILInjected.Token(Token = "0x4000DD4")]
		EphemeralKeySet = 32
	}
}
