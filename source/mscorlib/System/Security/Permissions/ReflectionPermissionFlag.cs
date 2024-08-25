using System;
using Cpp2ILInjected;

namespace System.Security.Permissions
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20002AB")]
	public enum ReflectionPermissionFlag
	{
		[global::System.Obsolete("This permission has been deprecated. Use PermissionState.Unrestricted to get full access.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BEA")]
		AllFlags = 7,
		[global::Cpp2ILInjected.Token(Token = "0x4000BEB")]
		MemberAccess = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000BEC")]
		NoFlags = 0,
		[global::System.Obsolete("This permission is no longer used by the CLR.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BED")]
		ReflectionEmit = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000BEE")]
		RestrictedMemberAccess = 8,
		[global::System.Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BEF")]
		TypeInformation = 1
	}
}
