using System;
using System.Diagnostics;
using System.IO;
using System.Net.Cache;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000E5 RID: 229
	[global::Cpp2ILInjected.Token(Token = "0x2000151")]
	public sealed class FtpWebRequest : WebRequest
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x000043CA File Offset: 0x000025CA
		[global::Cpp2ILInjected.Token(Token = "0x170001BB")]
		internal FtpMethodInfo MethodInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000848")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2910", Offset = "0x1EF2910", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x000043CD File Offset: 0x000025CD
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x000043D0 File Offset: 0x000025D0
		[global::Cpp2ILInjected.Token(Token = "0x170001BC")]
		public new static RequestCachePolicy DefaultCachePolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000849")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2918", Offset = "0x1EF2918", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "get_CachePolicy", ReturnType = typeof(RequestCachePolicy))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_DefaultCachePolicy", ReturnType = typeof(RequestCachePolicy))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600084A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2968", Offset = "0x1EF2968", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x000043D3 File Offset: 0x000025D3
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x000043D6 File Offset: 0x000025D6
		[global::Cpp2ILInjected.Token(Token = "0x170001BD")]
		public override string Method
		{
			[global::Cpp2ILInjected.Token(Token = "0x600084B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF296C", Offset = "0x1EF296C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600084C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2978", Offset = "0x1EF2978", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpMethodInfo), Member = "GetMethodInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FtpMethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x000043D9 File Offset: 0x000025D9
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x000043DC File Offset: 0x000025DC
		[global::Cpp2ILInjected.Token(Token = "0x170001BE")]
		public string RenameTo
		{
			[global::Cpp2ILInjected.Token(Token = "0x600084D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2B30", Offset = "0x1EF2B30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600084E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2B38", Offset = "0x1EF2B38", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x000043DF File Offset: 0x000025DF
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x000043E2 File Offset: 0x000025E2
		[global::Cpp2ILInjected.Token(Token = "0x170001BF")]
		public override ICredentials Credentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x600084F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2C08", Offset = "0x1EF2C08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000850")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2C10", Offset = "0x1EF2C10", Length = "0x144")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000043E5 File Offset: 0x000025E5
		[global::Cpp2ILInjected.Token(Token = "0x170001C0")]
		public override Uri RequestUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000851")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2D54", Offset = "0x1EF2D54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x000043E8 File Offset: 0x000025E8
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x000043EB File Offset: 0x000025EB
		[global::Cpp2ILInjected.Token(Token = "0x170001C1")]
		public override int Timeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000852")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2D5C", Offset = "0x1EF2D5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000853")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2D64", Offset = "0x1EF2D64", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x000043EE File Offset: 0x000025EE
		[global::Cpp2ILInjected.Token(Token = "0x170001C2")]
		internal int RemainingTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000854")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2E34", Offset = "0x1EF2E34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x000043F1 File Offset: 0x000025F1
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x000043F4 File Offset: 0x000025F4
		[global::Cpp2ILInjected.Token(Token = "0x170001C3")]
		public int ReadWriteTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000855")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2E3C", Offset = "0x1EF2E3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000856")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2E44", Offset = "0x1EF2E44", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x000043F7 File Offset: 0x000025F7
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x000043FA File Offset: 0x000025FA
		[global::Cpp2ILInjected.Token(Token = "0x170001C4")]
		public long ContentOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000857")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2F04", Offset = "0x1EF2F04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000858")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2F0C", Offset = "0x1EF2F0C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x000043FD File Offset: 0x000025FD
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00004400 File Offset: 0x00002600
		[global::Cpp2ILInjected.Token(Token = "0x170001C5")]
		public override long ContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000859")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2FAC", Offset = "0x1EF2FAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600085A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2FB4", Offset = "0x1EF2FB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00004403 File Offset: 0x00002603
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00004406 File Offset: 0x00002606
		[global::Cpp2ILInjected.Token(Token = "0x170001C6")]
		public override IWebProxy Proxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600085B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2FBC", Offset = "0x1EF2FBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600085C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2FC4", Offset = "0x1EF2FC4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00004409 File Offset: 0x00002609
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0000440C File Offset: 0x0000260C
		[global::Cpp2ILInjected.Token(Token = "0x170001C7")]
		public override string ConnectionGroupName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600085D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF3028", Offset = "0x1EF3028", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600085E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF3030", Offset = "0x1EF3030", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0000440F File Offset: 0x0000260F
		[global::Cpp2ILInjected.Token(Token = "0x170001C8")]
		public ServicePoint ServicePoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x600085F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF3098", Offset = "0x1EF3098", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(ServicePoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00004412 File Offset: 0x00002612
		[global::Cpp2ILInjected.Token(Token = "0x170001C9")]
		internal bool Aborted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000860")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF3104", Offset = "0x1EF3104", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00004415 File Offset: 0x00002615
		[global::Cpp2ILInjected.Token(Token = "0x6000861")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF310C", Offset = "0x1EF310C", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequestCreator), Member = "Create", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerThread.Callback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpMethodInfo), Member = "GetMethodInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FtpMethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_UserInfo", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "UnescapeDataString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		internal FtpWebRequest(Uri uri)
		{
			throw null;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00004418 File Offset: 0x00002618
		[global::Cpp2ILInjected.Token(Token = "0x6000862")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF34B0", Offset = "0x1EF34B0", Length = "0x7A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_TimeoutException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "FinishRequestStage", MemberParameters = new object[] { typeof(FtpWebRequest.RequestStage) }, ReturnType = typeof(FtpWebRequest.RequestStage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InternalWaitForCompletion", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 57)]
		public override WebResponse GetResponse()
		{
			throw null;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0000441B File Offset: 0x0000261B
		[global::Cpp2ILInjected.Token(Token = "0x6000863")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF4D88", Offset = "0x1EF4D88", Length = "0x6AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextAwareResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "FinishRequestStage", MemberParameters = new object[] { typeof(FtpWebRequest.RequestStage) }, ReturnType = typeof(FtpWebRequest.RequestStage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextAwareResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextAwareResult), Member = "StartPostingAsyncOp", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextAwareResult), Member = "FinishPostingAsyncOp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "get_InternalPeekCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0000441E File Offset: 0x0000261E
		[global::Cpp2ILInjected.Token(Token = "0x6000864")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF5434", Offset = "0x1EF5434", Length = "0x410")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InternalWaitForCompletion", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00004421 File Offset: 0x00002621
		[global::Cpp2ILInjected.Token(Token = "0x6000865")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF5844", Offset = "0x1EF5844", Length = "0x57C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "FinishRequestStage", MemberParameters = new object[] { typeof(FtpWebRequest.RequestStage) }, ReturnType = typeof(FtpWebRequest.RequestStage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProtocolViolationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_TimeoutException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
		public override Stream GetRequestStream()
		{
			throw null;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00004424 File Offset: 0x00002624
		[global::Cpp2ILInjected.Token(Token = "0x6000866")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF5DC0", Offset = "0x1EF5DC0", Length = "0x524")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "FinishRequestStage", MemberParameters = new object[] { typeof(FtpWebRequest.RequestStage) }, ReturnType = typeof(FtpWebRequest.RequestStage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextAwareResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextAwareResult), Member = "StartPostingAsyncOp", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextAwareResult), Member = "FinishPostingAsyncOp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProtocolViolationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00004427 File Offset: 0x00002627
		[global::Cpp2ILInjected.Token(Token = "0x6000867")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF62E4", Offset = "0x1EF62E4", Length = "0x468")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InternalWaitForCompletion", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0000442A File Offset: 0x0000262A
		[global::Cpp2ILInjected.Token(Token = "0x6000868")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF4074", Offset = "0x1EF4074", Length = "0x57C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "AttemptedRecovery", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "CreateConnectionAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_TimeoutException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = "get_SocketErrorCode", ReturnType = typeof(SocketError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private void SubmitRequest(bool isAsync)
		{
			throw null;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0000442D File Offset: 0x0000262D
		[global::Cpp2ILInjected.Token(Token = "0x6000869")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF6FFC", Offset = "0x1EF6FFC", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest.<CreateConnectionAsync>d__86), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = "get_SocketErrorCode", ReturnType = typeof(SocketError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Exception TranslateConnectException(Exception e)
		{
			throw null;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00004430 File Offset: 0x00002630
		[global::Cpp2ILInjected.Token(Token = "0x600086A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF674C", Offset = "0x1EF674C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(FtpWebRequest.<CreateConnectionAsync>d__86) }, MemberParameters = new object[] { typeof(ref FtpWebRequest.<CreateConnectionAsync>d__86) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void CreateConnectionAsync()
		{
			throw null;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00004433 File Offset: 0x00002633
		[global::Cpp2ILInjected.Token(Token = "0x600086B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF67E0", Offset = "0x1EF67E0", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "TranslateConnectException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private FtpControlStream CreateConnection()
		{
			throw null;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00004436 File Offset: 0x00002636
		[global::Cpp2ILInjected.Token(Token = "0x600086C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF6978", Offset = "0x1EF6978", Length = "0x3F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "SubmitRequest", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "get_TimerQueue", ReturnType = typeof(TimerThread.Queue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_TimeoutException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private Stream TimedSubmitRequestHelper(bool isAsync)
		{
			throw null;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00004439 File Offset: 0x00002639
		[global::Cpp2ILInjected.Token(Token = "0x600086D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF7160", Offset = "0x1EF7160", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "AbortConnect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context)
		{
			throw null;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0000443C File Offset: 0x0000263C
		[global::Cpp2ILInjected.Token(Token = "0x170001CA")]
		private TimerThread.Queue TimerQueue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600086E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF70F4", Offset = "0x1EF70F4", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerThread), Member = "GetOrCreateQueue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TimerThread.Queue))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0000443F File Offset: 0x0000263F
		[global::Cpp2ILInjected.Token(Token = "0x600086F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF6D70", Offset = "0x1EF6D70", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private bool AttemptedRecovery(Exception e)
		{
			throw null;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00004442 File Offset: 0x00002642
		[global::Cpp2ILInjected.Token(Token = "0x6000870")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF4A58", Offset = "0x1EF4A58", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "get_ExitMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void SetException(Exception exception)
		{
			throw null;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00004445 File Offset: 0x00002645
		[global::Cpp2ILInjected.Token(Token = "0x6000871")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF3C50", Offset = "0x1EF3C50", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		private void CheckError()
		{
			throw null;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00004448 File Offset: 0x00002648
		[global::Cpp2ILInjected.Token(Token = "0x6000872")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF7280", Offset = "0x1EF7280", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "InvokeRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "SyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		internal void RequestCallback(object obj)
		{
			throw null;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0000444B File Offset: 0x0000264B
		[global::Cpp2ILInjected.Token(Token = "0x6000873")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF7CEC", Offset = "0x1EF7CEC", Length = "0x3A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "RequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "get_ExitMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private void SyncRequestCallback(object obj)
		{
			throw null;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0000444E File Offset: 0x0000264E
		[global::Cpp2ILInjected.Token(Token = "0x6000874")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF7290", Offset = "0x1EF7290", Length = "0xA5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest.<CreateConnectionAsync>d__86), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "AttemptedRecovery", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Associate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "FinishRequestStage", MemberParameters = new object[] { typeof(FtpWebRequest.RequestStage) }, ReturnType = typeof(FtpWebRequest.RequestStage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "get_ExitMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 74)]
		private void AsyncRequestCallback(object obj)
		{
			throw null;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00004451 File Offset: 0x00002651
		[global::Cpp2ILInjected.Token(Token = "0x6000875")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF3C64", Offset = "0x1EF3C64", Length = "0x410")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private FtpWebRequest.RequestStage FinishRequestStage(FtpWebRequest.RequestStage stage)
		{
			throw null;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00004454 File Offset: 0x00002654
		[global::Cpp2ILInjected.Token(Token = "0x6000876")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF808C", Offset = "0x1EF808C", Length = "0x4B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		public override void Abort()
		{
			throw null;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00004457 File Offset: 0x00002657
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x0000445A File Offset: 0x0000265A
		[global::Cpp2ILInjected.Token(Token = "0x170001CB")]
		public bool KeepAlive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000877")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF853C", Offset = "0x1EF853C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000878")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8544", Offset = "0x1EF8544", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x0000445D File Offset: 0x0000265D
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00004460 File Offset: 0x00002660
		[global::Cpp2ILInjected.Token(Token = "0x170001CC")]
		public override RequestCachePolicy CachePolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000879")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF85A8", Offset = "0x1EF85A8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "get_DefaultCachePolicy", ReturnType = typeof(RequestCachePolicy))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600087A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF85F4", Offset = "0x1EF85F4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00004463 File Offset: 0x00002663
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00004466 File Offset: 0x00002666
		[global::Cpp2ILInjected.Token(Token = "0x170001CD")]
		public bool UseBinary
		{
			[global::Cpp2ILInjected.Token(Token = "0x600087B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8658", Offset = "0x1EF8658", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600087C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8660", Offset = "0x1EF8660", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00004469 File Offset: 0x00002669
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x0000446C File Offset: 0x0000266C
		[global::Cpp2ILInjected.Token(Token = "0x170001CE")]
		public bool UsePassive
		{
			[global::Cpp2ILInjected.Token(Token = "0x600087D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF86CC", Offset = "0x1EF86CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600087E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF86D4", Offset = "0x1EF86D4", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0000446F File Offset: 0x0000266F
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00004472 File Offset: 0x00002672
		[global::Cpp2ILInjected.Token(Token = "0x170001CF")]
		public X509CertificateCollection ClientCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x600087F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8740", Offset = "0x1EF8740", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
			{
				typeof(CommandStream.PipelineEntry),
				typeof(ResponseDescription),
				typeof(bool),
				typeof(ref Stream)
			}, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"T&",
				typeof(ref object),
				"System.Func`1<T>"
			}, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000880")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8844", Offset = "0x1EF8844", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00004475 File Offset: 0x00002675
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00004478 File Offset: 0x00002678
		[global::Cpp2ILInjected.Token(Token = "0x170001D0")]
		public bool EnableSsl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000881")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF88A0", Offset = "0x1EF88A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000882")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF88A8", Offset = "0x1EF88A8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0000447B File Offset: 0x0000267B
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x0000447E File Offset: 0x0000267E
		[global::Cpp2ILInjected.Token(Token = "0x170001D1")]
		public override WebHeaderCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000883")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8914", Offset = "0x1EF8914", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000884")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8978", Offset = "0x1EF8978", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00004481 File Offset: 0x00002681
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x00004484 File Offset: 0x00002684
		[global::Cpp2ILInjected.Token(Token = "0x170001D2")]
		public override string ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000885")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8980", Offset = "0x1EF8980", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotSupportedException", ReturnType = typeof(NotSupportedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000886")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF89A8", Offset = "0x1EF89A8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotSupportedException", ReturnType = typeof(NotSupportedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00004487 File Offset: 0x00002687
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x0000448A File Offset: 0x0000268A
		[global::Cpp2ILInjected.Token(Token = "0x170001D3")]
		public override bool UseDefaultCredentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000887")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF89D0", Offset = "0x1EF89D0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotSupportedException", ReturnType = typeof(NotSupportedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000888")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF89F8", Offset = "0x1EF89F8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotSupportedException", ReturnType = typeof(NotSupportedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0000448D File Offset: 0x0000268D
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00004490 File Offset: 0x00002690
		[global::Cpp2ILInjected.Token(Token = "0x170001D4")]
		public override bool PreAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000889")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8A20", Offset = "0x1EF8A20", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotSupportedException", ReturnType = typeof(NotSupportedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600088A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8A48", Offset = "0x1EF8A48", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotSupportedException", ReturnType = typeof(NotSupportedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00004493 File Offset: 0x00002693
		[global::Cpp2ILInjected.Token(Token = "0x170001D5")]
		private bool InUse
		{
			[global::Cpp2ILInjected.Token(Token = "0x600088B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2B18", Offset = "0x1EF2B18", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00004496 File Offset: 0x00002696
		[global::Cpp2ILInjected.Token(Token = "0x600088C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF45F0", Offset = "0x1EF45F0", Length = "0x468")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebResponse), Member = "SetResponseStream", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "get_BannerMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "get_WelcomeMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "get_ExitMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long),
			typeof(Uri),
			typeof(FtpStatusCode),
			typeof(string),
			typeof(DateTime),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void EnsureFtpWebResponse(Exception exception)
		{
			throw null;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00004499 File Offset: 0x00002699
		[global::Cpp2ILInjected.Token(Token = "0x600088D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF8C28", Offset = "0x1EF8C28", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "System.Net.ICloseEx.CloseEx", MemberParameters = new object[] { typeof(CloseExState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InternalWaitForCompletion", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "CheckContinuePipeline", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void DataStreamClosed(CloseExState closeState)
		{
			throw null;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0000449C File Offset: 0x0000269C
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600088E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF8CA4", Offset = "0x1EF8CA4", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerThread), Member = "GetOrCreateQueue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TimerThread.Queue))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static FtpWebRequest()
		{
			throw null;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0000449F File Offset: 0x0000269F
		[global::Cpp2ILInjected.Token(Token = "0x600088F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF8DB8", Offset = "0x1EF8DB8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal FtpWebRequest()
		{
			throw null;
		}

		// Token: 0x04000524 RID: 1316
		[global::Cpp2ILInjected.Token(Token = "0x40006BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object _syncObject;

		// Token: 0x04000525 RID: 1317
		[global::Cpp2ILInjected.Token(Token = "0x40006BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ICredentials _authInfo;

		// Token: 0x04000526 RID: 1318
		[global::Cpp2ILInjected.Token(Token = "0x40006BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly Uri _uri;

		// Token: 0x04000527 RID: 1319
		[global::Cpp2ILInjected.Token(Token = "0x40006C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private FtpMethodInfo _methodInfo;

		// Token: 0x04000528 RID: 1320
		[global::Cpp2ILInjected.Token(Token = "0x40006C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string _renameTo;

		// Token: 0x04000529 RID: 1321
		[global::Cpp2ILInjected.Token(Token = "0x40006C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool _getRequestStreamStarted;

		// Token: 0x0400052A RID: 1322
		[global::Cpp2ILInjected.Token(Token = "0x40006C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		private bool _getResponseStarted;

		// Token: 0x0400052B RID: 1323
		[global::Cpp2ILInjected.Token(Token = "0x40006C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private DateTime _startTime;

		// Token: 0x0400052C RID: 1324
		[global::Cpp2ILInjected.Token(Token = "0x40006C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int _timeout;

		// Token: 0x0400052D RID: 1325
		[global::Cpp2ILInjected.Token(Token = "0x40006C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private int _remainingTimeout;

		// Token: 0x0400052E RID: 1326
		[global::Cpp2ILInjected.Token(Token = "0x40006C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private long _contentLength;

		// Token: 0x0400052F RID: 1327
		[global::Cpp2ILInjected.Token(Token = "0x40006C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private long _contentOffset;

		// Token: 0x04000530 RID: 1328
		[global::Cpp2ILInjected.Token(Token = "0x40006C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private X509CertificateCollection _clientCertificates;

		// Token: 0x04000531 RID: 1329
		[global::Cpp2ILInjected.Token(Token = "0x40006CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private bool _passive;

		// Token: 0x04000532 RID: 1330
		[global::Cpp2ILInjected.Token(Token = "0x40006CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x91")]
		private bool _binary;

		// Token: 0x04000533 RID: 1331
		[global::Cpp2ILInjected.Token(Token = "0x40006CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string _connectionGroupName;

		// Token: 0x04000534 RID: 1332
		[global::Cpp2ILInjected.Token(Token = "0x40006CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private ServicePoint _servicePoint;

		// Token: 0x04000535 RID: 1333
		[global::Cpp2ILInjected.Token(Token = "0x40006CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private bool _async;

		// Token: 0x04000536 RID: 1334
		[global::Cpp2ILInjected.Token(Token = "0x40006CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA9")]
		private bool _aborted;

		// Token: 0x04000537 RID: 1335
		[global::Cpp2ILInjected.Token(Token = "0x40006D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAA")]
		private bool _timedOut;

		// Token: 0x04000538 RID: 1336
		[global::Cpp2ILInjected.Token(Token = "0x40006D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private Exception _exception;

		// Token: 0x04000539 RID: 1337
		[global::Cpp2ILInjected.Token(Token = "0x40006D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private TimerThread.Queue _timerQueue;

		// Token: 0x0400053A RID: 1338
		[global::Cpp2ILInjected.Token(Token = "0x40006D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private TimerThread.Callback _timerCallback;

		// Token: 0x0400053B RID: 1339
		[global::Cpp2ILInjected.Token(Token = "0x40006D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private bool _enableSsl;

		// Token: 0x0400053C RID: 1340
		[global::Cpp2ILInjected.Token(Token = "0x40006D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private FtpControlStream _connection;

		// Token: 0x0400053D RID: 1341
		[global::Cpp2ILInjected.Token(Token = "0x40006D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private Stream _stream;

		// Token: 0x0400053E RID: 1342
		[global::Cpp2ILInjected.Token(Token = "0x40006D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private FtpWebRequest.RequestStage _requestStage;

		// Token: 0x0400053F RID: 1343
		[global::Cpp2ILInjected.Token(Token = "0x40006D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		private bool _onceFailed;

		// Token: 0x04000540 RID: 1344
		[global::Cpp2ILInjected.Token(Token = "0x40006D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private WebHeaderCollection _ftpRequestHeaders;

		// Token: 0x04000541 RID: 1345
		[global::Cpp2ILInjected.Token(Token = "0x40006DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private FtpWebResponse _ftpWebResponse;

		// Token: 0x04000542 RID: 1346
		[global::Cpp2ILInjected.Token(Token = "0x40006DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private int _readWriteTimeout;

		// Token: 0x04000543 RID: 1347
		[global::Cpp2ILInjected.Token(Token = "0x40006DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private ContextAwareResult _writeAsyncResult;

		// Token: 0x04000544 RID: 1348
		[global::Cpp2ILInjected.Token(Token = "0x40006DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private LazyAsyncResult _readAsyncResult;

		// Token: 0x04000545 RID: 1349
		[global::Cpp2ILInjected.Token(Token = "0x40006DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private LazyAsyncResult _requestCompleteAsyncResult;

		// Token: 0x04000546 RID: 1350
		[global::Cpp2ILInjected.Token(Token = "0x40006DF")]
		private static readonly NetworkCredential s_defaultFtpNetworkCredential;

		// Token: 0x04000547 RID: 1351
		[global::Cpp2ILInjected.Token(Token = "0x40006E0")]
		private const int s_DefaultTimeout = 100000;

		// Token: 0x04000548 RID: 1352
		[global::Cpp2ILInjected.Token(Token = "0x40006E1")]
		private static readonly TimerThread.Queue s_DefaultTimerQueue;

		// Token: 0x020003D4 RID: 980
		[global::Cpp2ILInjected.Token(Token = "0x2000152")]
		private enum RequestStage
		{
			// Token: 0x0400114B RID: 4427
			[global::Cpp2ILInjected.Token(Token = "0x40006E3")]
			CheckForError,
			// Token: 0x0400114C RID: 4428
			[global::Cpp2ILInjected.Token(Token = "0x40006E4")]
			RequestStarted,
			// Token: 0x0400114D RID: 4429
			[global::Cpp2ILInjected.Token(Token = "0x40006E5")]
			WriteReady,
			// Token: 0x0400114E RID: 4430
			[global::Cpp2ILInjected.Token(Token = "0x40006E6")]
			ReadReady,
			// Token: 0x0400114F RID: 4431
			[global::Cpp2ILInjected.Token(Token = "0x40006E7")]
			ReleaseConnection
		}

		// Token: 0x020003D5 RID: 981
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000153")]
		[StructLayout(3)]
		private struct <CreateConnectionAsync>d__86 : IAsyncStateMachine
		{
			// Token: 0x06001D6F RID: 7535 RVA: 0x00008135 File Offset: 0x00006335
			[global::Cpp2ILInjected.Token(Token = "0x6000890")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF8DF0", Offset = "0x1EF8DF0", Length = "0x2B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "ConnectAsync", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(FtpWebRequest.<CreateConnectionAsync>d__86)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref FtpWebRequest.<CreateConnectionAsync>d__86)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "TranslateConnectException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D70 RID: 7536 RVA: 0x00008138 File Offset: 0x00006338
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000891")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF90A8", Offset = "0x1EF90A8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001150 RID: 4432
			[global::Cpp2ILInjected.Token(Token = "0x40006E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001151 RID: 4433
			[global::Cpp2ILInjected.Token(Token = "0x40006E9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001152 RID: 4434
			[global::Cpp2ILInjected.Token(Token = "0x40006EA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public FtpWebRequest <>4__this;

			// Token: 0x04001153 RID: 4435
			[global::Cpp2ILInjected.Token(Token = "0x40006EB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private TcpClient <client>5__2;

			// Token: 0x04001154 RID: 4436
			[global::Cpp2ILInjected.Token(Token = "0x40006EC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020003D6 RID: 982
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000154")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001D71 RID: 7537 RVA: 0x0000813B File Offset: 0x0000633B
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000892")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF90B4", Offset = "0x1EF90B4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06001D72 RID: 7538 RVA: 0x0000813E File Offset: 0x0000633E
			[global::Cpp2ILInjected.Token(Token = "0x6000893")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9110", Offset = "0x1EF9110", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06001D73 RID: 7539 RVA: 0x00008141 File Offset: 0x00006341
			[global::Cpp2ILInjected.Token(Token = "0x6000894")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9118", Offset = "0x1EF9118", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal X509CertificateCollection <get_ClientCertificates>b__114_0()
			{
				throw null;
			}

			// Token: 0x04001155 RID: 4437
			[global::Cpp2ILInjected.Token(Token = "0x40006ED")]
			public static readonly FtpWebRequest.<>c <>9;

			// Token: 0x04001156 RID: 4438
			[global::Cpp2ILInjected.Token(Token = "0x40006EE")]
			public static Func<X509CertificateCollection> <>9__114_0;
		}
	}
}
