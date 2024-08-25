using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Permissions
{
	[global::System.Obsolete("CAS support is not available with Silverlight applications.")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002AE")]
	[global::System.Serializable]
	public enum SecurityAction
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000BF2")]
		Demand = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000BF3")]
		Assert,
		[global::System.Obsolete("This requests should not be used")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BF4")]
		Deny,
		[global::Cpp2ILInjected.Token(Token = "0x4000BF5")]
		PermitOnly,
		[global::Cpp2ILInjected.Token(Token = "0x4000BF6")]
		LinkDemand,
		[global::Cpp2ILInjected.Token(Token = "0x4000BF7")]
		InheritanceDemand,
		[global::System.Obsolete("This requests should not be used")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BF8")]
		RequestMinimum,
		[global::System.Obsolete("This requests should not be used")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BF9")]
		RequestOptional,
		[global::System.Obsolete("This requests should not be used")]
		[global::Cpp2ILInjected.Token(Token = "0x4000BFA")]
		RequestRefuse
	}
}
