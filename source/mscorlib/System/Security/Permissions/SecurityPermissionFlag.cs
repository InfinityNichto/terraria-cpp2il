using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Permissions
{
	// Token: 0x02000219 RID: 537
	[global::System.Flags]
	[global::System.Obsolete("CAS support is not available with Silverlight applications.")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002B1")]
	[global::System.Serializable]
	public enum SecurityPermissionFlag
	{
		// Token: 0x04000957 RID: 2391
		[global::Cpp2ILInjected.Token(Token = "0x4000BFF")]
		NoFlags = 0,
		// Token: 0x04000958 RID: 2392
		[global::Cpp2ILInjected.Token(Token = "0x4000C00")]
		Assertion = 1,
		// Token: 0x04000959 RID: 2393
		[global::Cpp2ILInjected.Token(Token = "0x4000C01")]
		UnmanagedCode = 2,
		// Token: 0x0400095A RID: 2394
		[global::Cpp2ILInjected.Token(Token = "0x4000C02")]
		SkipVerification = 4,
		// Token: 0x0400095B RID: 2395
		[global::Cpp2ILInjected.Token(Token = "0x4000C03")]
		Execution = 8,
		// Token: 0x0400095C RID: 2396
		[global::Cpp2ILInjected.Token(Token = "0x4000C04")]
		ControlThread = 16,
		// Token: 0x0400095D RID: 2397
		[global::Cpp2ILInjected.Token(Token = "0x4000C05")]
		ControlEvidence = 32,
		// Token: 0x0400095E RID: 2398
		[global::Cpp2ILInjected.Token(Token = "0x4000C06")]
		ControlPolicy = 64,
		// Token: 0x0400095F RID: 2399
		[global::Cpp2ILInjected.Token(Token = "0x4000C07")]
		SerializationFormatter = 128,
		// Token: 0x04000960 RID: 2400
		[global::Cpp2ILInjected.Token(Token = "0x4000C08")]
		ControlDomainPolicy = 256,
		// Token: 0x04000961 RID: 2401
		[global::Cpp2ILInjected.Token(Token = "0x4000C09")]
		ControlPrincipal = 512,
		// Token: 0x04000962 RID: 2402
		[global::Cpp2ILInjected.Token(Token = "0x4000C0A")]
		ControlAppDomain = 1024,
		// Token: 0x04000963 RID: 2403
		[global::Cpp2ILInjected.Token(Token = "0x4000C0B")]
		RemotingConfiguration = 2048,
		// Token: 0x04000964 RID: 2404
		[global::Cpp2ILInjected.Token(Token = "0x4000C0C")]
		Infrastructure = 4096,
		// Token: 0x04000965 RID: 2405
		[global::Cpp2ILInjected.Token(Token = "0x4000C0D")]
		BindingRedirects = 8192,
		// Token: 0x04000966 RID: 2406
		[global::Cpp2ILInjected.Token(Token = "0x4000C0E")]
		AllFlags = 16383
	}
}
