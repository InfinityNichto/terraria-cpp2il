using System;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000034 RID: 52
	[global::Cpp2ILInjected.Token(Token = "0x200007E")]
	public class UriBuilder
	{
		// Token: 0x0600015B RID: 347 RVA: 0x000031DC File Offset: 0x000013DC
		[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1380", Offset = "0x1EA1380", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FtpWebRequest)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public UriBuilder(Uri uri)
		{
			throw null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000031DF File Offset: 0x000013DF
		[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA14F0", Offset = "0x1EA14F0", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Fragment", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Query", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_HasAuthority", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_UserInfo", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Init(Uri uri)
		{
			throw null;
		}

		// Token: 0x17000060 RID: 96
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000031E2 File Offset: 0x000013E2
		[global::Cpp2ILInjected.Token(Token = "0x17000062")]
		public string Path
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA17AC", Offset = "0x1EA17AC", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new object[]
			{
				typeof(string),
				typeof(FtpWebRequest)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
			{
				typeof(char),
				typeof(char)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "InternalEscapeString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (set) Token: 0x0600015E RID: 350 RVA: 0x000031E5 File Offset: 0x000013E5
		[global::Cpp2ILInjected.Token(Token = "0x17000063")]
		public string Query
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA1858", Offset = "0x1EA1858", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000031E8 File Offset: 0x000013E8
		[global::Cpp2ILInjected.Token(Token = "0x17000064")]
		public Uri Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA1908", Offset = "0x1EA1908", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "GetHashCode", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new object[]
			{
				typeof(string),
				typeof(FtpWebRequest)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000031EB File Offset: 0x000013EB
		[global::Cpp2ILInjected.Token(Token = "0x60001E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1998", Offset = "0x1EA1998", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriBuilder), Member = "get_Uri", ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object rparam)
		{
			throw null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000031EE File Offset: 0x000013EE
		[global::Cpp2ILInjected.Token(Token = "0x60001E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA19E4", Offset = "0x1EA19E4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriBuilder), Member = "get_Uri", ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000031F1 File Offset: 0x000013F1
		[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1658", Offset = "0x1EA1658", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "get_Uri", ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Fragment", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Query", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_HasAuthority", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_UserInfo", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void SetFieldsFromUri(Uri uri)
		{
			throw null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000031F4 File Offset: 0x000013F4
		[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA19FC", Offset = "0x1EA19FC", Length = "0x41C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "GetSyntax", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(UriParser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000090 RID: 144
		[global::Cpp2ILInjected.Token(Token = "0x4000160")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _changed;

		// Token: 0x04000091 RID: 145
		[global::Cpp2ILInjected.Token(Token = "0x4000161")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _fragment;

		// Token: 0x04000092 RID: 146
		[global::Cpp2ILInjected.Token(Token = "0x4000162")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _host;

		// Token: 0x04000093 RID: 147
		[global::Cpp2ILInjected.Token(Token = "0x4000163")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _password;

		// Token: 0x04000094 RID: 148
		[global::Cpp2ILInjected.Token(Token = "0x4000164")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _path;

		// Token: 0x04000095 RID: 149
		[global::Cpp2ILInjected.Token(Token = "0x4000165")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _port;

		// Token: 0x04000096 RID: 150
		[global::Cpp2ILInjected.Token(Token = "0x4000166")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _query;

		// Token: 0x04000097 RID: 151
		[global::Cpp2ILInjected.Token(Token = "0x4000167")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string _scheme;

		// Token: 0x04000098 RID: 152
		[global::Cpp2ILInjected.Token(Token = "0x4000168")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string _schemeDelimiter;

		// Token: 0x04000099 RID: 153
		[global::Cpp2ILInjected.Token(Token = "0x4000169")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Uri _uri;

		// Token: 0x0400009A RID: 154
		[global::Cpp2ILInjected.Token(Token = "0x400016A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string _username;
	}
}
