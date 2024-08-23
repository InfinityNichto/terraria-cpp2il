using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000185 RID: 389
	[global::Cpp2ILInjected.Token(Token = "0x200022E")]
	internal class BasicClient : IAuthenticationModule
	{
		// Token: 0x06000CA3 RID: 3235 RVA: 0x0000523D File Offset: 0x0000343D
		[global::Cpp2ILInjected.Token(Token = "0x6000E0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3E80C", Offset = "0x1F3E80C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00005240 File Offset: 0x00003440
		[global::Cpp2ILInjected.Token(Token = "0x6000E0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3EC00", Offset = "0x1F3EC00", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static byte[] GetBytes(string str)
		{
			throw null;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00005243 File Offset: 0x00003443
		[global::Cpp2ILInjected.Token(Token = "0x6000E0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3E8AC", Offset = "0x1F3E8AC", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicClient), Member = "PreAuthenticate", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_UserName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Password", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Domain", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BasicClient), Member = "GetBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Authorization), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00005246 File Offset: 0x00003446
		[global::Cpp2ILInjected.Token(Token = "0x6000E0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3EC90", Offset = "0x1F3EC90", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00005249 File Offset: 0x00003449
		[global::Cpp2ILInjected.Token(Token = "0x170002EF")]
		public string AuthenticationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E0E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3EC9C", Offset = "0x1F3EC9C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0000524C File Offset: 0x0000344C
		[global::Cpp2ILInjected.Token(Token = "0x170002F0")]
		public bool CanPreAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3ECDC", Offset = "0x1F3ECDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0000524F File Offset: 0x0000344F
		[global::Cpp2ILInjected.Token(Token = "0x6000E10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3D148", Offset = "0x1F3D148", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BasicClient()
		{
			throw null;
		}
	}
}
