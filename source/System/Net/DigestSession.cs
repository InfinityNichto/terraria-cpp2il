using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200018D RID: 397
	[global::Cpp2ILInjected.Token(Token = "0x2000239")]
	internal class DigestSession
	{
		// Token: 0x06000CCB RID: 3275 RVA: 0x000052A9 File Offset: 0x000034A9
		[global::Cpp2ILInjected.Token(Token = "0x6000E35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F409B4", Offset = "0x1F409B4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static DigestSession()
		{
			throw null;
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x000052AC File Offset: 0x000034AC
		[global::Cpp2ILInjected.Token(Token = "0x6000E36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40A04", Offset = "0x1F40A04", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestClient), Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DigestSession()
		{
			throw null;
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000052AF File Offset: 0x000034AF
		[global::Cpp2ILInjected.Token(Token = "0x170002F8")]
		public string Algorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E37")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F40A74", Offset = "0x1F40A74", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x000052B2 File Offset: 0x000034B2
		[global::Cpp2ILInjected.Token(Token = "0x170002F9")]
		public string Realm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E38")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F40A84", Offset = "0x1F40A84", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000052B5 File Offset: 0x000034B5
		[global::Cpp2ILInjected.Token(Token = "0x170002FA")]
		public string Nonce
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E39")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F40A94", Offset = "0x1F40A94", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x000052B8 File Offset: 0x000034B8
		[global::Cpp2ILInjected.Token(Token = "0x170002FB")]
		public string Opaque
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F40AA4", Offset = "0x1F40AA4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000052BB File Offset: 0x000034BB
		[global::Cpp2ILInjected.Token(Token = "0x170002FC")]
		public string QOP
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F40AB4", Offset = "0x1F40AB4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x000052BE File Offset: 0x000034BE
		[global::Cpp2ILInjected.Token(Token = "0x170002FD")]
		public string CNonce
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E3C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F40AC4", Offset = "0x1F40AC4", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "HA1", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(HttpWebRequest)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000052C1 File Offset: 0x000034C1
		[global::Cpp2ILInjected.Token(Token = "0x6000E3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40BB4", Offset = "0x1F40BB4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestClient), Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestHeaderParser), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestHeaderParser), Member = "Parse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD5), Member = "Create", ReturnType = typeof(MD5))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Parse(string challenge)
		{
			throw null;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x000052C4 File Offset: 0x000034C4
		[global::Cpp2ILInjected.Token(Token = "0x6000E3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40C78", Offset = "0x1F40C78", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "HA1", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "HA2", MemberParameters = new object[] { typeof(HttpWebRequest) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(HttpWebRequest)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string HashToHexString(string toBeHashed)
		{
			throw null;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x000052C7 File Offset: 0x000034C7
		[global::Cpp2ILInjected.Token(Token = "0x6000E3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40DA4", Offset = "0x1F40DA4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(HttpWebRequest)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "HashToHexString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "get_CNonce", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string HA1(string username, string password)
		{
			throw null;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x000052CA File Offset: 0x000034CA
		[global::Cpp2ILInjected.Token(Token = "0x6000E40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40EA4", Offset = "0x1F40EA4", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(HttpWebRequest)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "HashToHexString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string HA2(HttpWebRequest webRequest)
		{
			throw null;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000052CD File Offset: 0x000034CD
		[global::Cpp2ILInjected.Token(Token = "0x6000E41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40F74", Offset = "0x1F40F74", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "HA1", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "get_CNonce", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "HA2", MemberParameters = new object[] { typeof(HttpWebRequest) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "HashToHexString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string Response(string username, string password, HttpWebRequest webRequest)
		{
			throw null;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x000052D0 File Offset: 0x000034D0
		[global::Cpp2ILInjected.Token(Token = "0x6000E42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F410B4", Offset = "0x1F410B4", Length = "0x594")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_UserName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Password", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "Response", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(HttpWebRequest)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestSession), Member = "get_CNonce", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Authorization), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public Authorization Authenticate(WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x000052D3 File Offset: 0x000034D3
		[global::Cpp2ILInjected.Token(Token = "0x170002FE")]
		public DateTime LastUse
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F41648", Offset = "0x1F41648", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000929 RID: 2345
		[global::Cpp2ILInjected.Token(Token = "0x4000BD1")]
		private static RandomNumberGenerator rng;

		// Token: 0x0400092A RID: 2346
		[global::Cpp2ILInjected.Token(Token = "0x4000BD2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DateTime lastUse;

		// Token: 0x0400092B RID: 2347
		[global::Cpp2ILInjected.Token(Token = "0x4000BD3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _nc;

		// Token: 0x0400092C RID: 2348
		[global::Cpp2ILInjected.Token(Token = "0x4000BD4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private HashAlgorithm hash;

		// Token: 0x0400092D RID: 2349
		[global::Cpp2ILInjected.Token(Token = "0x4000BD5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private DigestHeaderParser parser;

		// Token: 0x0400092E RID: 2350
		[global::Cpp2ILInjected.Token(Token = "0x4000BD6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _cnonce;
	}
}
