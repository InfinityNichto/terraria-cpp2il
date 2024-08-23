using System;
using System.Security;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200032C RID: 812
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000460")]
	[Serializable]
	public sealed class DnsPermissionAttribute : CodeAccessSecurityAttribute
	{
		// Token: 0x06001B09 RID: 6921 RVA: 0x00007A51 File Offset: 0x00005C51
		[global::Cpp2ILInjected.Token(Token = "0x6001E62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97DE4", Offset = "0x1E97DE4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public DnsPermissionAttribute(SecurityAction action)
		{
			throw null;
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x00007A54 File Offset: 0x00005C54
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
