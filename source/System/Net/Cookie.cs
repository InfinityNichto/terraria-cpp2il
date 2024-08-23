using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200016D RID: 365
	[global::Cpp2ILInjected.Token(Token = "0x200020C")]
	[Serializable]
	public sealed class Cookie
	{
		// Token: 0x06000B6F RID: 2927 RVA: 0x00004EAD File Offset: 0x000030AD
		[global::Cpp2ILInjected.Token(Token = "0x6000CC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BEF4", Offset = "0x1F2BEF4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "GetServer", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Cookie()
		{
			throw null;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00004EB0 File Offset: 0x000030B0
		[global::Cpp2ILInjected.Token(Token = "0x6000CC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BFD4", Offset = "0x1F2BFD4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "Clone", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Cookie(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00004EB3 File Offset: 0x000030B3
		[global::Cpp2ILInjected.Token(Token = "0x6000CC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2C238", Offset = "0x1F2C238", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Cookie(string name, string value, string path)
		{
			throw null;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00004EB6 File Offset: 0x000030B6
		[global::Cpp2ILInjected.Token(Token = "0x6000CC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2C2F4", Offset = "0x1F2C2F4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		public Cookie(string name, string value, string path, string domain)
		{
			throw null;
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00004EB9 File Offset: 0x000030B9
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x00004EBC File Offset: 0x000030BC
		[global::Cpp2ILInjected.Token(Token = "0x17000299")]
		public string Comment
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C38C", Offset = "0x1F2C38C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C394", Offset = "0x1F2C394", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00004EBF File Offset: 0x000030BF
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x00004EC2 File Offset: 0x000030C2
		[global::Cpp2ILInjected.Token(Token = "0x1700029A")]
		public Uri CommentUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CC9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C3EC", Offset = "0x1F2C3EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CCA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C3F4", Offset = "0x1F2C3F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00004EC5 File Offset: 0x000030C5
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x00004EC8 File Offset: 0x000030C8
		[global::Cpp2ILInjected.Token(Token = "0x1700029B")]
		public bool HttpOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CCB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C3FC", Offset = "0x1F2C3FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CCC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C404", Offset = "0x1F2C404", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00004ECB File Offset: 0x000030CB
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00004ECE File Offset: 0x000030CE
		[global::Cpp2ILInjected.Token(Token = "0x1700029C")]
		public bool Discard
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CCD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C410", Offset = "0x1F2C410", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C418", Offset = "0x1F2C418", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00004ED1 File Offset: 0x000030D1
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00004ED4 File Offset: 0x000030D4
		[global::Cpp2ILInjected.Token(Token = "0x1700029D")]
		public string Domain
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C424", Offset = "0x1F2C424", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C31C", Offset = "0x1F2C31C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "Clone", ReturnType = typeof(Cookie))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "GetServer", ReturnType = typeof(Cookie))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00004ED7 File Offset: 0x000030D7
		[global::Cpp2ILInjected.Token(Token = "0x1700029E")]
		private string _Domain
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C42C", Offset = "0x1F2C42C", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00004EDA File Offset: 0x000030DA
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00004EDD File Offset: 0x000030DD
		[global::Cpp2ILInjected.Token(Token = "0x1700029F")]
		internal bool DomainImplicit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C500", Offset = "0x1F2C500", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C508", Offset = "0x1F2C508", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00004EE0 File Offset: 0x000030E0
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00004EE3 File Offset: 0x000030E3
		[global::Cpp2ILInjected.Token(Token = "0x170002A0")]
		public bool Expired
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C514", Offset = "0x1F2C514", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
			{
				typeof(Cookie),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "ExpireCollection", MemberParameters = new object[] { typeof(CookieCollection) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "MergeUpdateCollections", MemberParameters = new object[]
			{
				typeof(CookieCollection),
				typeof(CookieCollection),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C5CC", Offset = "0x1F2C5CC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00004EE6 File Offset: 0x000030E6
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00004EE9 File Offset: 0x000030E9
		[global::Cpp2ILInjected.Token(Token = "0x170002A1")]
		public DateTime Expires
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C630", Offset = "0x1F2C630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C638", Offset = "0x1F2C638", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x00004EEC File Offset: 0x000030EC
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x00004EEF File Offset: 0x000030EF
		[global::Cpp2ILInjected.Token(Token = "0x170002A2")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C640", Offset = "0x1F2C640", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CD9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C0D8", Offset = "0x1F2C0D8", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "IsBlankString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "InternalSetName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00004EF2 File Offset: 0x000030F2
		[global::Cpp2ILInjected.Token(Token = "0x6000CDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2C648", Offset = "0x1F2C648", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "GetServer", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "IsBlankString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal bool InternalSetName(string value)
		{
			throw null;
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00004EF5 File Offset: 0x000030F5
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00004EF8 File Offset: 0x000030F8
		[global::Cpp2ILInjected.Token(Token = "0x170002A3")]
		public string Path
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C750", Offset = "0x1F2C750", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C298", Offset = "0x1F2C298", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00004EFB File Offset: 0x000030FB
		[global::Cpp2ILInjected.Token(Token = "0x170002A4")]
		private string _Path
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C758", Offset = "0x1F2C758", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x00004EFE File Offset: 0x000030FE
		[global::Cpp2ILInjected.Token(Token = "0x170002A5")]
		internal bool Plain
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C4F0", Offset = "0x1F2C4F0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00004F01 File Offset: 0x00003101
		[global::Cpp2ILInjected.Token(Token = "0x6000CDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2C7EC", Offset = "0x1F2C7EC", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Cookie)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(CookieCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "set_Port", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "set_Domain", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "set_Version", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal Cookie Clone()
		{
			throw null;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00004F04 File Offset: 0x00003104
		[global::Cpp2ILInjected.Token(Token = "0x6000CE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2CC98", Offset = "0x1F2CC98", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			typeof(CookieVariant),
			typeof(Uri),
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		private static bool IsDomainEqualToHost(string domain, string host)
		{
			throw null;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00004F07 File Offset: 0x00003107
		[global::Cpp2ILInjected.Token(Token = "0x6000CE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2CCE4", Offset = "0x1F2CCE4", Length = "0x8E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Cookie)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(CookieCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "DomainCharsTest", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "IsDomainEqualToHost", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieParser), Member = "CheckQuoted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
		internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow)
		{
			throw null;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00004F0A File Offset: 0x0000310A
		[global::Cpp2ILInjected.Token(Token = "0x6000CE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2D5CC", Offset = "0x1F2D5CC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			typeof(CookieVariant),
			typeof(Uri),
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool DomainCharsTest(string name)
		{
			throw null;
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x00004F0D File Offset: 0x0000310D
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x00004F10 File Offset: 0x00003110
		[global::Cpp2ILInjected.Token(Token = "0x170002A6")]
		public string Port
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D724", Offset = "0x1F2D724", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2C948", Offset = "0x1F2C948", Length = "0x2DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "Clone", ReturnType = typeof(Cookie))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "GetServer", ReturnType = typeof(Cookie))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "ToArray", ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00004F13 File Offset: 0x00003113
		[global::Cpp2ILInjected.Token(Token = "0x170002A7")]
		internal int[] PortList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D72C", Offset = "0x1F2D72C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00004F16 File Offset: 0x00003116
		[global::Cpp2ILInjected.Token(Token = "0x170002A8")]
		private string _Port
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CE6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D734", Offset = "0x1F2D734", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00004F19 File Offset: 0x00003119
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00004F1C File Offset: 0x0000311C
		[global::Cpp2ILInjected.Token(Token = "0x170002A9")]
		public bool Secure
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D7F4", Offset = "0x1F2D7F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D7FC", Offset = "0x1F2D7FC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00004F1F File Offset: 0x0000311F
		[global::Cpp2ILInjected.Token(Token = "0x170002AA")]
		public DateTime TimeStamp
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D808", Offset = "0x1F2D808", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x00004F22 File Offset: 0x00003122
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x00004F25 File Offset: 0x00003125
		[global::Cpp2ILInjected.Token(Token = "0x170002AB")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D810", Offset = "0x1F2D810", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D818", Offset = "0x1F2D818", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x00004F28 File Offset: 0x00003128
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x00004F2B File Offset: 0x0000312B
		[global::Cpp2ILInjected.Token(Token = "0x170002AC")]
		internal CookieVariant Variant
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D870", Offset = "0x1F2D870", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D878", Offset = "0x1F2D878", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00004F2E File Offset: 0x0000312E
		[global::Cpp2ILInjected.Token(Token = "0x170002AD")]
		internal string DomainKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D880", Offset = "0x1F2D880", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00004F31 File Offset: 0x00003131
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x00004F34 File Offset: 0x00003134
		[global::Cpp2ILInjected.Token(Token = "0x170002AE")]
		public int Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D89C", Offset = "0x1F2D89C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2CC24", Offset = "0x1F2CC24", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "Clone", ReturnType = typeof(Cookie))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "GetServer", ReturnType = typeof(Cookie))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00004F37 File Offset: 0x00003137
		[global::Cpp2ILInjected.Token(Token = "0x170002AF")]
		private string _Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2D8A4", Offset = "0x1F2D8A4", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00004F3A File Offset: 0x0000313A
		[global::Cpp2ILInjected.Token(Token = "0x6000CF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2D9A0", Offset = "0x1F2D9A0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static IComparer GetComparer()
		{
			throw null;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00004F3D File Offset: 0x0000313D
		[global::Cpp2ILInjected.Token(Token = "0x6000CF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2D9F8", Offset = "0x1F2D9F8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object comparand)
		{
			throw null;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00004F40 File Offset: 0x00003140
		[global::Cpp2ILInjected.Token(Token = "0x6000CF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2DAC8", Offset = "0x1F2DAC8", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00004F43 File Offset: 0x00003143
		[global::Cpp2ILInjected.Token(Token = "0x6000CF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2DCB8", Offset = "0x1F2DCB8", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "get__Domain", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "get__Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "get__Port", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "get__Version", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00004F46 File Offset: 0x00003146
		[global::Cpp2ILInjected.Token(Token = "0x6000CF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2DF5C", Offset = "0x1F2DF5C", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal string ToServerString()
		{
			throw null;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00004F49 File Offset: 0x00003149
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000CF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2E314", Offset = "0x1F2E314", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		static Cookie()
		{
			throw null;
		}

		// Token: 0x04000885 RID: 2181
		[global::Cpp2ILInjected.Token(Token = "0x4000AE6")]
		internal const int MaxSupportedVersion = 1;

		// Token: 0x04000886 RID: 2182
		[global::Cpp2ILInjected.Token(Token = "0x4000AE7")]
		internal const string CommentAttributeName = "Comment";

		// Token: 0x04000887 RID: 2183
		[global::Cpp2ILInjected.Token(Token = "0x4000AE8")]
		internal const string CommentUrlAttributeName = "CommentURL";

		// Token: 0x04000888 RID: 2184
		[global::Cpp2ILInjected.Token(Token = "0x4000AE9")]
		internal const string DiscardAttributeName = "Discard";

		// Token: 0x04000889 RID: 2185
		[global::Cpp2ILInjected.Token(Token = "0x4000AEA")]
		internal const string DomainAttributeName = "Domain";

		// Token: 0x0400088A RID: 2186
		[global::Cpp2ILInjected.Token(Token = "0x4000AEB")]
		internal const string ExpiresAttributeName = "Expires";

		// Token: 0x0400088B RID: 2187
		[global::Cpp2ILInjected.Token(Token = "0x4000AEC")]
		internal const string MaxAgeAttributeName = "Max-Age";

		// Token: 0x0400088C RID: 2188
		[global::Cpp2ILInjected.Token(Token = "0x4000AED")]
		internal const string PathAttributeName = "Path";

		// Token: 0x0400088D RID: 2189
		[global::Cpp2ILInjected.Token(Token = "0x4000AEE")]
		internal const string PortAttributeName = "Port";

		// Token: 0x0400088E RID: 2190
		[global::Cpp2ILInjected.Token(Token = "0x4000AEF")]
		internal const string SecureAttributeName = "Secure";

		// Token: 0x0400088F RID: 2191
		[global::Cpp2ILInjected.Token(Token = "0x4000AF0")]
		internal const string VersionAttributeName = "Version";

		// Token: 0x04000890 RID: 2192
		[global::Cpp2ILInjected.Token(Token = "0x4000AF1")]
		internal const string HttpOnlyAttributeName = "HttpOnly";

		// Token: 0x04000891 RID: 2193
		[global::Cpp2ILInjected.Token(Token = "0x4000AF2")]
		internal const string SeparatorLiteral = "; ";

		// Token: 0x04000892 RID: 2194
		[global::Cpp2ILInjected.Token(Token = "0x4000AF3")]
		internal const string EqualsLiteral = "=";

		// Token: 0x04000893 RID: 2195
		[global::Cpp2ILInjected.Token(Token = "0x4000AF4")]
		internal const string QuotesLiteral = "\"";

		// Token: 0x04000894 RID: 2196
		[global::Cpp2ILInjected.Token(Token = "0x4000AF5")]
		internal const string SpecialAttributeLiteral = "$";

		// Token: 0x04000895 RID: 2197
		[global::Cpp2ILInjected.Token(Token = "0x4000AF6")]
		internal static readonly char[] PortSplitDelimiters;

		// Token: 0x04000896 RID: 2198
		[global::Cpp2ILInjected.Token(Token = "0x4000AF7")]
		internal static readonly char[] Reserved2Name;

		// Token: 0x04000897 RID: 2199
		[global::Cpp2ILInjected.Token(Token = "0x4000AF8")]
		internal static readonly char[] Reserved2Value;

		// Token: 0x04000898 RID: 2200
		[global::Cpp2ILInjected.Token(Token = "0x4000AF9")]
		private static Comparer staticComparer;

		// Token: 0x04000899 RID: 2201
		[global::Cpp2ILInjected.Token(Token = "0x4000AFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_comment;

		// Token: 0x0400089A RID: 2202
		[global::Cpp2ILInjected.Token(Token = "0x4000AFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Uri m_commentUri;

		// Token: 0x0400089B RID: 2203
		[global::Cpp2ILInjected.Token(Token = "0x4000AFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private CookieVariant m_cookieVariant;

		// Token: 0x0400089C RID: 2204
		[global::Cpp2ILInjected.Token(Token = "0x4000AFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private bool m_discard;

		// Token: 0x0400089D RID: 2205
		[global::Cpp2ILInjected.Token(Token = "0x4000AFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string m_domain;

		// Token: 0x0400089E RID: 2206
		[global::Cpp2ILInjected.Token(Token = "0x4000AFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool m_domain_implicit;

		// Token: 0x0400089F RID: 2207
		[global::Cpp2ILInjected.Token(Token = "0x4000B00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private DateTime m_expires;

		// Token: 0x040008A0 RID: 2208
		[global::Cpp2ILInjected.Token(Token = "0x4000B01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string m_name;

		// Token: 0x040008A1 RID: 2209
		[global::Cpp2ILInjected.Token(Token = "0x4000B02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string m_path;

		// Token: 0x040008A2 RID: 2210
		[global::Cpp2ILInjected.Token(Token = "0x4000B03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool m_path_implicit;

		// Token: 0x040008A3 RID: 2211
		[global::Cpp2ILInjected.Token(Token = "0x4000B04")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string m_port;

		// Token: 0x040008A4 RID: 2212
		[global::Cpp2ILInjected.Token(Token = "0x4000B05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool m_port_implicit;

		// Token: 0x040008A5 RID: 2213
		[global::Cpp2ILInjected.Token(Token = "0x4000B06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int[] m_port_list;

		// Token: 0x040008A6 RID: 2214
		[global::Cpp2ILInjected.Token(Token = "0x4000B07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool m_secure;

		// Token: 0x040008A7 RID: 2215
		[OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x4000B08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool m_httpOnly;

		// Token: 0x040008A8 RID: 2216
		[global::Cpp2ILInjected.Token(Token = "0x4000B09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private DateTime m_timeStamp;

		// Token: 0x040008A9 RID: 2217
		[global::Cpp2ILInjected.Token(Token = "0x4000B0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private string m_value;

		// Token: 0x040008AA RID: 2218
		[global::Cpp2ILInjected.Token(Token = "0x4000B0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private int m_version;

		// Token: 0x040008AB RID: 2219
		[global::Cpp2ILInjected.Token(Token = "0x4000B0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string m_domainKey;

		// Token: 0x040008AC RID: 2220
		[global::Cpp2ILInjected.Token(Token = "0x4000B0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal bool IsQuotedVersion;

		// Token: 0x040008AD RID: 2221
		[global::Cpp2ILInjected.Token(Token = "0x4000B0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x99")]
		internal bool IsQuotedDomain;
	}
}
