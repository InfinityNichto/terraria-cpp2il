using System;
using System.Security;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000460")]
	[Serializable]
	public sealed class DnsPermissionAttribute : CodeAccessSecurityAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97DE4", Offset = "0x1E97DE4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public DnsPermissionAttribute(SecurityAction action)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97DE8", Offset = "0x1E97DE8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IPermission CreatePermission()
		{
			throw null;
		}
	}
}
