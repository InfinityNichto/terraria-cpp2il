using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000174 RID: 372
	[global::Cpp2ILInjected.Token(Token = "0x2000216")]
	[Serializable]
	public class CookieContainer
	{
		// Token: 0x06000BD1 RID: 3025 RVA: 0x00004FD3 File Offset: 0x000031D3
		[global::Cpp2ILInjected.Token(Token = "0x6000D2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F30BD4", Offset = "0x1F30BD4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPGlobalProperties), Member = "InternalGetIPGlobalProperties", ReturnType = typeof(IPGlobalProperties))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public CookieContainer()
		{
			throw null;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00004FD6 File Offset: 0x000031D6
		[global::Cpp2ILInjected.Token(Token = "0x6000D2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F30CC4", Offset = "0x1F30CC4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public CookieContainer(int capacity)
		{
			throw null;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00004FD9 File Offset: 0x000031D9
		[global::Cpp2ILInjected.Token(Token = "0x6000D2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F30D54", Offset = "0x1F30D54", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public CookieContainer(int capacity, int perDomainCapacity, int maxCookieSize)
		{
			throw null;
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00004FDC File Offset: 0x000031DC
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x00004FDF File Offset: 0x000031DF
		[global::Cpp2ILInjected.Token(Token = "0x170002C1")]
		public int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F30F00", Offset = "0x1F30F00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D30")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F30F08", Offset = "0x1F30F08", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "AgeCookies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00004FE2 File Offset: 0x000031E2
		[global::Cpp2ILInjected.Token(Token = "0x170002C2")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D31")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F32380", Offset = "0x1F32380", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00004FE5 File Offset: 0x000031E5
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00004FE8 File Offset: 0x000031E8
		[global::Cpp2ILInjected.Token(Token = "0x170002C3")]
		public int MaxCookieSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F32388", Offset = "0x1F32388", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F32390", Offset = "0x1F32390", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00004FEB File Offset: 0x000031EB
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x00004FEE File Offset: 0x000031EE
		[global::Cpp2ILInjected.Token(Token = "0x170002C4")]
		public int PerDomainCapacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D34")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F323F0", Offset = "0x1F323F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D35")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F323F8", Offset = "0x1F323F8", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "AgeCookies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00004FF1 File Offset: 0x000031F1
		[global::Cpp2ILInjected.Token(Token = "0x6000D36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3249C", Offset = "0x1F3249C", Length = "0x378")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[] { typeof(CookieCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "Clone", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "IsLocalDomain", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			typeof(CookieVariant),
			typeof(Uri),
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public void Add(Cookie cookie)
		{
			throw null;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00004FF4 File Offset: 0x000031F4
		[global::Cpp2ILInjected.Token(Token = "0x6000D37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F331A4", Offset = "0x1F331A4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(int),
			typeof(CookieCollection),
			typeof(List<string>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void AddRemoveDomain(string key, PathList value)
		{
			throw null;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00004FF7 File Offset: 0x000031F7
		[global::Cpp2ILInjected.Token(Token = "0x6000D38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F32A3C", Offset = "0x1F32A3C", Length = "0x768")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "AddRemoveDomain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PathList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathList), Member = "GetCookiesCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathList), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "get_Expired", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "AgeCookies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "InternalAdd", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
		internal void Add(Cookie cookie, bool throwOnError)
		{
			throw null;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00004FFA File Offset: 0x000031FA
		[global::Cpp2ILInjected.Token(Token = "0x6000D39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F31070", Offset = "0x1F31070", Length = "0x1310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "set_Capacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "set_PerDomainCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "ExpireCollection", MemberParameters = new object[] { typeof(CookieCollection) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(int)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 85)]
		private bool AgeCookies(string domain)
		{
			throw null;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00004FFD File Offset: 0x000031FD
		[global::Cpp2ILInjected.Token(Token = "0x6000D3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F33888", Offset = "0x1F33888", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "AgeCookies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "get_Expired", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private int ExpireCollection(CookieCollection cc)
		{
			throw null;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00005000 File Offset: 0x00003200
		[global::Cpp2ILInjected.Token(Token = "0x6000D3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F339D4", Offset = "0x1F339D4", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void Add(CookieCollection cookies)
		{
			throw null;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00005003 File Offset: 0x00003203
		[global::Cpp2ILInjected.Token(Token = "0x6000D3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F32814", Offset = "0x1F32814", Length = "0x228")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal bool IsLocalDomain(string host)
		{
			throw null;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00005006 File Offset: 0x00003206
		[global::Cpp2ILInjected.Token(Token = "0x6000D3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F33CC4", Offset = "0x1F33CC4", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "Clone", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "IsLocalDomain", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			typeof(CookieVariant),
			typeof(Uri),
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Add(Uri uri, Cookie cookie)
		{
			throw null;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00005009 File Offset: 0x00003209
		[global::Cpp2ILInjected.Token(Token = "0x6000D3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F33DF8", Offset = "0x1F33DF8", Length = "0x3A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "IsLocalDomain", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "Clone", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			typeof(CookieVariant),
			typeof(Uri),
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public void Add(Uri uri, CookieCollection cookies)
		{
			throw null;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0000500C File Offset: 0x0000320C
		[global::Cpp2ILInjected.Token(Token = "0x6000D3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F34198", Offset = "0x1F34198", Length = "0x664")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "SetCookies", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "FillCookies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "IsLocalDomain", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieParser), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "IsBlankString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			typeof(CookieVariant),
			typeof(Uri),
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "InternalAdd", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AbsoluteUri", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow)
		{
			throw null;
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0000500F File Offset: 0x0000320F
		[global::Cpp2ILInjected.Token(Token = "0x6000D40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F347FC", Offset = "0x1F347FC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public CookieCollection GetCookies(Uri uri)
		{
			throw null;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00005012 File Offset: 0x00003212
		[global::Cpp2ILInjected.Token(Token = "0x6000D41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F348BC", Offset = "0x1F348BC", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "GetCookieHeader", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(int),
			typeof(CookieCollection),
			typeof(List<string>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal CookieCollection InternalGetCookies(Uri uri)
		{
			throw null;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00005015 File Offset: 0x00003215
		[global::Cpp2ILInjected.Token(Token = "0x6000D42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F34D34", Offset = "0x1F34D34", Length = "0x788")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "InternalGetCookies", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieParser), Member = "CheckQuoted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "TimeStamp", MemberParameters = new object[] { typeof(CookieCollection.Stamp) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "MergeUpdateCollections", MemberParameters = new object[]
		{
			typeof(CookieCollection),
			typeof(CookieCollection),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "AddRemoveDomain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PathList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie)
		{
			throw null;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00005018 File Offset: 0x00003218
		[global::Cpp2ILInjected.Token(Token = "0x6000D43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F354D0", Offset = "0x1F354D0", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(int),
			typeof(CookieCollection),
			typeof(List<string>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "get_Expired", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "InternalAdd", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly)
		{
			throw null;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0000501B File Offset: 0x0000321B
		[global::Cpp2ILInjected.Token(Token = "0x6000D44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F35688", Offset = "0x1F35688", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "GetCookieHeader", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public string GetCookieHeader(Uri uri)
		{
			throw null;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0000501E File Offset: 0x0000321E
		[global::Cpp2ILInjected.Token(Token = "0x6000D45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F35754", Offset = "0x1F35754", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "GetCookieHeader", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "InternalGetCookies", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal string GetCookieHeader(Uri uri, out string optCookie2)
		{
			throw null;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00005021 File Offset: 0x00003221
		[global::Cpp2ILInjected.Token(Token = "0x6000D46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F35AD8", Offset = "0x1F35AD8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void SetCookies(Uri uri, string cookieHeader)
		{
			throw null;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00005024 File Offset: 0x00003224
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000D47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F35BCC", Offset = "0x1F35BCC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static CookieContainer()
		{
			throw null;
		}

		// Token: 0x040008D8 RID: 2264
		[global::Cpp2ILInjected.Token(Token = "0x4000B44")]
		public const int DefaultCookieLimit = 300;

		// Token: 0x040008D9 RID: 2265
		[global::Cpp2ILInjected.Token(Token = "0x4000B45")]
		public const int DefaultPerDomainCookieLimit = 20;

		// Token: 0x040008DA RID: 2266
		[global::Cpp2ILInjected.Token(Token = "0x4000B46")]
		public const int DefaultCookieLengthLimit = 4096;

		// Token: 0x040008DB RID: 2267
		[global::Cpp2ILInjected.Token(Token = "0x4000B47")]
		private static readonly HeaderVariantInfo[] HeaderInfo;

		// Token: 0x040008DC RID: 2268
		[global::Cpp2ILInjected.Token(Token = "0x4000B48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Hashtable m_domainTable;

		// Token: 0x040008DD RID: 2269
		[global::Cpp2ILInjected.Token(Token = "0x4000B49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_maxCookieSize;

		// Token: 0x040008DE RID: 2270
		[global::Cpp2ILInjected.Token(Token = "0x4000B4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int m_maxCookies;

		// Token: 0x040008DF RID: 2271
		[global::Cpp2ILInjected.Token(Token = "0x4000B4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_maxCookiesPerDomain;

		// Token: 0x040008E0 RID: 2272
		[global::Cpp2ILInjected.Token(Token = "0x4000B4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_count;

		// Token: 0x040008E1 RID: 2273
		[global::Cpp2ILInjected.Token(Token = "0x4000B4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string m_fqdnMyDomain;
	}
}
