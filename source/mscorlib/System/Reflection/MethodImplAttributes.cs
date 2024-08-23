using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	// Token: 0x0200041F RID: 1055
	[global::Cpp2ILInjected.Token(Token = "0x20004DE")]
	public enum MethodImplAttributes
	{
		// Token: 0x040010BD RID: 4285
		[global::Cpp2ILInjected.Token(Token = "0x40013D7")]
		CodeTypeMask = 3,
		// Token: 0x040010BE RID: 4286
		[global::Cpp2ILInjected.Token(Token = "0x40013D8")]
		IL = 0,
		// Token: 0x040010BF RID: 4287
		[global::Cpp2ILInjected.Token(Token = "0x40013D9")]
		Native,
		// Token: 0x040010C0 RID: 4288
		[global::Cpp2ILInjected.Token(Token = "0x40013DA")]
		OPTIL,
		// Token: 0x040010C1 RID: 4289
		[global::Cpp2ILInjected.Token(Token = "0x40013DB")]
		Runtime,
		// Token: 0x040010C2 RID: 4290
		[global::Cpp2ILInjected.Token(Token = "0x40013DC")]
		ManagedMask,
		// Token: 0x040010C3 RID: 4291
		[global::Cpp2ILInjected.Token(Token = "0x40013DD")]
		Unmanaged = 4,
		// Token: 0x040010C4 RID: 4292
		[global::Cpp2ILInjected.Token(Token = "0x40013DE")]
		Managed = 0,
		// Token: 0x040010C5 RID: 4293
		[global::Cpp2ILInjected.Token(Token = "0x40013DF")]
		ForwardRef = 16,
		// Token: 0x040010C6 RID: 4294
		[global::Cpp2ILInjected.Token(Token = "0x40013E0")]
		PreserveSig = 128,
		// Token: 0x040010C7 RID: 4295
		[global::Cpp2ILInjected.Token(Token = "0x40013E1")]
		InternalCall = 4096,
		// Token: 0x040010C8 RID: 4296
		[global::Cpp2ILInjected.Token(Token = "0x40013E2")]
		Synchronized = 32,
		// Token: 0x040010C9 RID: 4297
		[global::Cpp2ILInjected.Token(Token = "0x40013E3")]
		NoInlining = 8,
		// Token: 0x040010CA RID: 4298
		[global::Cpp2ILInjected.Token(Token = "0x40013E4")]
		AggressiveInlining = 256,
		// Token: 0x040010CB RID: 4299
		[global::Cpp2ILInjected.Token(Token = "0x40013E5")]
		NoOptimization = 64,
		// Token: 0x040010CC RID: 4300
		[global::Cpp2ILInjected.Token(Token = "0x40013E6")]
		MaxMethodImplVal = 65535,
		// Token: 0x040010CD RID: 4301
		[global::Cpp2ILInjected.Token(Token = "0x40013E7")]
		SecurityMitigations = 1024
	}
}
