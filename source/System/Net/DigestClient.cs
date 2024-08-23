using System;
using System.Collections;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200018E RID: 398
	[global::Cpp2ILInjected.Token(Token = "0x200023A")]
	internal class DigestClient : IAuthenticationModule
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x000052D6 File Offset: 0x000034D6
		[global::Cpp2ILInjected.Token(Token = "0x170002FF")]
		private static Hashtable Cache
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F41650", Offset = "0x1F41650", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestClient), Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestClient), Member = "PreAuthenticate", MemberParameters = new object[]
			{
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestClient), Member = "CheckExpired", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x000052D9 File Offset: 0x000034D9
		[global::Cpp2ILInjected.Token(Token = "0x6000E45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F417A4", Offset = "0x1F417A4", Length = "0x7D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestClient), Member = "get_Cache", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		private static void CheckExpired(int count)
		{
			throw null;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x000052DC File Offset: 0x000034DC
		[global::Cpp2ILInjected.Token(Token = "0x6000E46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F41F7C", Offset = "0x1F41F7C", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestClient), Member = "get_Cache", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000052DF File Offset: 0x000034DF
		[global::Cpp2ILInjected.Token(Token = "0x6000E47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F42200", Offset = "0x1F42200", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestClient), Member = "get_Cache", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x000052E2 File Offset: 0x000034E2
		[global::Cpp2ILInjected.Token(Token = "0x17000300")]
		public string AuthenticationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F42380", Offset = "0x1F42380", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x000052E5 File Offset: 0x000034E5
		[global::Cpp2ILInjected.Token(Token = "0x17000301")]
		public bool CanPreAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F423C0", Offset = "0x1F423C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000052E8 File Offset: 0x000034E8
		[global::Cpp2ILInjected.Token(Token = "0x6000E4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3D140", Offset = "0x1F3D140", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DigestClient()
		{
			throw null;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000052EB File Offset: 0x000034EB
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000E4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F423C8", Offset = "0x1F423C8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "Synchronized", MemberParameters = new object[] { typeof(Hashtable) }, ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static DigestClient()
		{
			throw null;
		}

		// Token: 0x0400092F RID: 2351
		[global::Cpp2ILInjected.Token(Token = "0x4000BD7")]
		private static readonly Hashtable cache;
	}
}
