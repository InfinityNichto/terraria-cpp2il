using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	// Token: 0x02000097 RID: 151
	[global::Cpp2ILInjected.Token(Token = "0x20000F4")]
	internal enum AsnDecodeStatus
	{
		// Token: 0x04000303 RID: 771
		[global::Cpp2ILInjected.Token(Token = "0x400046C")]
		NotDecoded = -1,
		// Token: 0x04000304 RID: 772
		[global::Cpp2ILInjected.Token(Token = "0x400046D")]
		Ok,
		// Token: 0x04000305 RID: 773
		[global::Cpp2ILInjected.Token(Token = "0x400046E")]
		BadAsn,
		// Token: 0x04000306 RID: 774
		[global::Cpp2ILInjected.Token(Token = "0x400046F")]
		BadTag,
		// Token: 0x04000307 RID: 775
		[global::Cpp2ILInjected.Token(Token = "0x4000470")]
		BadLength,
		// Token: 0x04000308 RID: 776
		[global::Cpp2ILInjected.Token(Token = "0x4000471")]
		InformationNotAvailable
	}
}
