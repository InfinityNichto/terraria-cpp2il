using System;
using System.Runtime.InteropServices;
using System.Security.Claims;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Principal
{
	// Token: 0x0200028C RID: 652
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000329")]
	[global::System.Serializable]
	public class GenericPrincipal : global::System.Security.Claims.ClaimsPrincipal
	{
		// Token: 0x0600193E RID: 6462 RVA: 0x00018BFC File Offset: 0x00016DFC
		[global::Cpp2ILInjected.Token(Token = "0x6001B58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1EF6C", Offset = "0x1B1EF6C", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerContext", Member = "ParseBasicAuthentication", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPrincipal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public GenericPrincipal(IIdentity identity, string[] roles)
		{
			throw null;
		}

		// Token: 0x04000B0D RID: 2829
		[global::Cpp2ILInjected.Token(Token = "0x4000DE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IIdentity m_identity;

		// Token: 0x04000B0E RID: 2830
		[global::Cpp2ILInjected.Token(Token = "0x4000DE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string[] m_roles;
	}
}
