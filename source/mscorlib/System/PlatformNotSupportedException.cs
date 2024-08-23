using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;

namespace System
{
	// Token: 0x020000BD RID: 189
	[global::Cpp2ILInjected.Token(Token = "0x20000EF")]
	[global::System.Serializable]
	public class PlatformNotSupportedException : global::System.NotSupportedException
	{
		// Token: 0x0600083A RID: 2106 RVA: 0x00015D25 File Offset: 0x00013F25
		[global::Cpp2ILInjected.Token(Token = "0x60008E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45290", Offset = "0x1C45290", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 226)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PlatformNotSupportedException()
		{
			throw null;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00015D28 File Offset: 0x00013F28
		[global::Cpp2ILInjected.Token(Token = "0x60008E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C452EC", Offset = "0x1C452EC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(global::Mono.ISystemDependencyProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = "set_ExtendedProtectionSelectorDelegate", MemberParameters = new object[] { "System.Net.HttpListener.ExtendedProtectionSelector" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = "set_ExtendedProtectionPolicy", MemberParameters = new object[] { "System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.NegotiateStreamPal", Member = "QueryContextClientSpecifiedSpn", MemberParameters = new object[] { "System.Net.Security.SafeDeleteContext" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.NegotiateStreamPal", Member = "InitializeSecurityContext", MemberParameters = new object[]
		{
			"System.Net.Security.SafeFreeCredentials",
			"System.Net.Security.SafeDeleteContext&",
			typeof(string),
			"System.Net.ContextFlagsPal",
			"System.Net.Security.SecurityBuffer[]",
			"System.Net.Security.SecurityBuffer",
			"System.Net.ContextFlagsPal&"
		}, ReturnType = "System.Net.SecurityStatusPal")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.NegotiateStreamPal", Member = "AcceptSecurityContext", MemberParameters = new object[] { "System.Net.Security.SafeFreeCredentials", "System.Net.Security.SafeDeleteContext&", "System.Net.ContextFlagsPal", "System.Net.Security.SecurityBuffer[]", "System.Net.Security.SecurityBuffer", "System.Net.ContextFlagsPal&" }, ReturnType = "System.Net.SecurityStatusPal")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.NegotiateStreamPal", Member = "AcquireCredentialsHandle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			"System.Net.NetworkCredential"
		}, ReturnType = "System.Net.Security.SafeFreeCredentials")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public PlatformNotSupportedException(string message)
		{
			throw null;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00015D2B File Offset: 0x00013F2B
		[global::Cpp2ILInjected.Token(Token = "0x60008E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45310", Offset = "0x1C45310", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected PlatformNotSupportedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
