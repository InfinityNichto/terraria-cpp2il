using System;
using System.Runtime.InteropServices;
using System.Security.Claims;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Principal
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000329")]
	[global::System.Serializable]
	public class GenericPrincipal : global::System.Security.Claims.ClaimsPrincipal
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000DE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IIdentity m_identity;

		[global::Cpp2ILInjected.Token(Token = "0x4000DE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string[] m_roles;
	}
}
