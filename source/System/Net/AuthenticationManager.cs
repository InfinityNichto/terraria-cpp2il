using System;
using System.Collections;
using System.Collections.Specialized;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000184 RID: 388
	[global::Cpp2ILInjected.Token(Token = "0x200022D")]
	public class AuthenticationManager
	{
		// Token: 0x06000C92 RID: 3218 RVA: 0x0000520A File Offset: 0x0000340A
		[global::Cpp2ILInjected.Token(Token = "0x6000DF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CEE0", Offset = "0x1F3CEE0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private AuthenticationManager()
		{
			throw null;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0000520D File Offset: 0x0000340D
		[global::Cpp2ILInjected.Token(Token = "0x6000DFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CEE8", Offset = "0x1F3CEE8", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticationManager), Member = "get_RegisteredModules", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticationManager), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticationManager), Member = "DoAuthenticate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticationManager), Member = "PreAuthenticate", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticationManager), Member = "DoUnregister", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NtlmClient), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void EnsureModules()
		{
			throw null;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00005210 File Offset: 0x00003410
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00005213 File Offset: 0x00003413
		[global::Cpp2ILInjected.Token(Token = "0x170002EB")]
		public static ICredentialPolicy CredentialPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3D150", Offset = "0x1F3D150", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000DFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3D1A8", Offset = "0x1F3D1A8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00005216 File Offset: 0x00003416
		[global::Cpp2ILInjected.Token(Token = "0x6000DFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3D204", Offset = "0x1F3D204", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticationManager), Member = "get_CustomTargetNameDictionary", ReturnType = typeof(StringDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static Exception GetMustImplement()
		{
			throw null;
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00005219 File Offset: 0x00003419
		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x170002EC")]
		public static StringDictionary CustomTargetNameDictionary
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3D258", Offset = "0x1F3D258", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "GetMustImplement", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0000521C File Offset: 0x0000341C
		[global::Cpp2ILInjected.Token(Token = "0x170002ED")]
		public static IEnumerator RegisteredModules
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3D28C", Offset = "0x1F3D28C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "EnsureModules", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0000521F File Offset: 0x0000341F
		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x170002EE")]
		internal static bool OSSupportsExtendedProtection
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E00")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3D2F4", Offset = "0x1F3D2F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00005222 File Offset: 0x00003422
		[global::Cpp2ILInjected.Token(Token = "0x6000E01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3D2FC", Offset = "0x1F3D2FC", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "EnsureModules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static void Clear()
		{
			throw null;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00005225 File Offset: 0x00003425
		[global::Cpp2ILInjected.Token(Token = "0x6000E02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3D424", Offset = "0x1F3D424", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.AuthorizationState", Member = "CheckAuthorization", MemberParameters = new object[]
		{
			typeof(WebResponse),
			typeof(HttpStatusCode)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00005228 File Offset: 0x00003428
		[global::Cpp2ILInjected.Token(Token = "0x6000E03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3D524", Offset = "0x1F3D524", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "EnsureModules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0000522B File Offset: 0x0000342B
		[global::Cpp2ILInjected.Token(Token = "0x6000E04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3D9F4", Offset = "0x1F3D9F4", Length = "0x51C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "DoPreAuthenticate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "EnsureModules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0000522E File Offset: 0x0000342E
		[global::Cpp2ILInjected.Token(Token = "0x6000E05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3DF10", Offset = "0x1F3DF10", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "DoUnregister", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void Register(IAuthenticationModule authenticationModule)
		{
			throw null;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00005231 File Offset: 0x00003431
		[global::Cpp2ILInjected.Token(Token = "0x6000E06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3E5DC", Offset = "0x1F3E5DC", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "DoUnregister", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void Unregister(IAuthenticationModule authenticationModule)
		{
			throw null;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00005234 File Offset: 0x00003434
		[global::Cpp2ILInjected.Token(Token = "0x6000E07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3E6F8", Offset = "0x1F3E6F8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "DoUnregister", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void Unregister(string authenticationScheme)
		{
			throw null;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00005237 File Offset: 0x00003437
		[global::Cpp2ILInjected.Token(Token = "0x6000E08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3E10C", Offset = "0x1F3E10C", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticationManager), Member = "Register", MemberParameters = new object[] { typeof(IAuthenticationModule) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticationManager), Member = "Unregister", MemberParameters = new object[] { typeof(IAuthenticationModule) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticationManager), Member = "Unregister", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "EnsureModules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private static void DoUnregister(string authenticationScheme, bool throwEx)
		{
			throw null;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0000523A File Offset: 0x0000343A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000E09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3E79C", Offset = "0x1F3E79C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static AuthenticationManager()
		{
			throw null;
		}

		// Token: 0x04000917 RID: 2327
		[global::Cpp2ILInjected.Token(Token = "0x4000BAF")]
		private static ArrayList modules;

		// Token: 0x04000918 RID: 2328
		[global::Cpp2ILInjected.Token(Token = "0x4000BB0")]
		private static object locker;

		// Token: 0x04000919 RID: 2329
		[global::Cpp2ILInjected.Token(Token = "0x4000BB1")]
		private static ICredentialPolicy credential_policy;
	}
}
