using System;
using Cpp2ILInjected;

namespace System.Security.Permissions
{
	// Token: 0x02000213 RID: 531
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20002AB")]
	public enum ReflectionPermissionFlag
	{
		// Token: 0x04000942 RID: 2370
		[global::System.Obsolete("This permission has been deprecated. Use PermissionState.Unrestricted to get full access.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BEA")]
		AllFlags = 7,
		// Token: 0x04000943 RID: 2371
		[global::Cpp2ILInjected.Token(Token = "0x4000BEB")]
		MemberAccess = 2,
		// Token: 0x04000944 RID: 2372
		[global::Cpp2ILInjected.Token(Token = "0x4000BEC")]
		NoFlags = 0,
		// Token: 0x04000945 RID: 2373
		[global::System.Obsolete("This permission is no longer used by the CLR.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BED")]
		ReflectionEmit = 4,
		// Token: 0x04000946 RID: 2374
		[global::Cpp2ILInjected.Token(Token = "0x4000BEE")]
		RestrictedMemberAccess = 8,
		// Token: 0x04000947 RID: 2375
		[global::System.Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BEF")]
		TypeInformation = 1
	}
}
