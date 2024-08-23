using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200019A RID: 410
	[global::Cpp2ILInjected.Token(Token = "0x2000251")]
	public sealed class HttpListenerResponse : IDisposable
	{
		// Token: 0x06000DBD RID: 3517 RVA: 0x00005576 File Offset: 0x00003776
		[global::Cpp2ILInjected.Token(Token = "0x6000F47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4DF70", Offset = "0x1F4DF70", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerContext), Member = ".ctor", MemberParameters = new object[] { typeof(HttpConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal HttpListenerResponse(HttpListenerContext context)
		{
			throw null;
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x00005579 File Offset: 0x00003779
		[global::Cpp2ILInjected.Token(Token = "0x17000344")]
		internal bool ForceCloseChunked
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F688", Offset = "0x1F4F688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x0000557C File Offset: 0x0000377C
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x0000557F File Offset: 0x0000377F
		[global::Cpp2ILInjected.Token(Token = "0x17000345")]
		public Encoding ContentEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4BC28", Offset = "0x1F4BC28", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F690", Offset = "0x1F4F690", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00005582 File Offset: 0x00003782
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00005585 File Offset: 0x00003785
		[global::Cpp2ILInjected.Token(Token = "0x17000346")]
		public long ContentLength64
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F750", Offset = "0x1F4F750", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F758", Offset = "0x1F4F758", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "Close", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00005588 File Offset: 0x00003788
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x0000558B File Offset: 0x0000378B
		[global::Cpp2ILInjected.Token(Token = "0x17000347")]
		public string ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F86C", Offset = "0x1F4F86C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4BB68", Offset = "0x1F4BB68", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x0000558E File Offset: 0x0000378E
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00005591 File Offset: 0x00003791
		[global::Cpp2ILInjected.Token(Token = "0x17000348")]
		public CookieCollection Cookies
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F874", Offset = "0x1F4F874", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "AppendCookie", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F50")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F8D8", Offset = "0x1F4F8D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00005594 File Offset: 0x00003794
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00005597 File Offset: 0x00003797
		[global::Cpp2ILInjected.Token(Token = "0x17000349")]
		public WebHeaderCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F51")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F8E0", Offset = "0x1F4F8E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F52")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F8E8", Offset = "0x1F4F8E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x0000559A File Offset: 0x0000379A
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x0000559D File Offset: 0x0000379D
		[global::Cpp2ILInjected.Token(Token = "0x1700034A")]
		public bool KeepAlive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F53")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F8F0", Offset = "0x1F4F8F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F54")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F8F8", Offset = "0x1F4F8F8", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x000055A0 File Offset: 0x000037A0
		[global::Cpp2ILInjected.Token(Token = "0x1700034B")]
		public Stream OutputStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F55")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F9BC", Offset = "0x1F4F9BC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[]
			{
				typeof(HttpListenerContext),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "GetResponseStream", ReturnType = typeof(ResponseStream))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x000055A3 File Offset: 0x000037A3
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x000055A6 File Offset: 0x000037A6
		[global::Cpp2ILInjected.Token(Token = "0x1700034C")]
		public Version ProtocolVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F56")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F9E4", Offset = "0x1F4F9E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F57")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F9EC", Offset = "0x1F4F9EC", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Version),
				typeof(Version)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x000055A9 File Offset: 0x000037A9
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x000055AC File Offset: 0x000037AC
		[global::Cpp2ILInjected.Token(Token = "0x1700034D")]
		public string RedirectLocation
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F58")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4FB68", Offset = "0x1F4FB68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F59")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4FB70", Offset = "0x1F4FB70", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x000055AF File Offset: 0x000037AF
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x000055B2 File Offset: 0x000037B2
		[global::Cpp2ILInjected.Token(Token = "0x1700034E")]
		public bool SendChunked
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4FC30", Offset = "0x1F4FC30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49CFC", Offset = "0x1F49CFC", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "GetRequestStream", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(long)
			}, ReturnType = typeof(RequestStream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x000055B5 File Offset: 0x000037B5
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x000055B8 File Offset: 0x000037B8
		[global::Cpp2ILInjected.Token(Token = "0x1700034F")]
		public int StatusCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4FC38", Offset = "0x1F4FC38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4BA50", Offset = "0x1F4BA50", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "Redirect", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[]
			{
				typeof(HttpListenerContext),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProtocolViolationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x000055BB File Offset: 0x000037BB
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x000055BE File Offset: 0x000037BE
		[global::Cpp2ILInjected.Token(Token = "0x17000350")]
		public string StatusDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4FC40", Offset = "0x1F4FC40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4FC48", Offset = "0x1F4FC48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000055C1 File Offset: 0x000037C1
		[global::Cpp2ILInjected.Token(Token = "0x6000F60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4FC50", Offset = "0x1F4FC50", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000055C4 File Offset: 0x000037C4
		[global::Cpp2ILInjected.Token(Token = "0x6000F61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4FC80", Offset = "0x1F4FC80", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Abort()
		{
			throw null;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000055C7 File Offset: 0x000037C7
		[global::Cpp2ILInjected.Token(Token = "0x6000F62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4FCA4", Offset = "0x1F4FCA4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void AddHeader(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000055CA File Offset: 0x000037CA
		[global::Cpp2ILInjected.Token(Token = "0x6000F63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4FDF4", Offset = "0x1F4FDF4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "get_Cookies", ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AppendCookie(Cookie cookie)
		{
			throw null;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000055CD File Offset: 0x000037CD
		[global::Cpp2ILInjected.Token(Token = "0x6000F64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4FE5C", Offset = "0x1F4FE5C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void AppendHeader(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000055D0 File Offset: 0x000037D0
		[global::Cpp2ILInjected.Token(Token = "0x6000F65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4FC68", Offset = "0x1F4FC68", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private void Close(bool force)
		{
			throw null;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000055D3 File Offset: 0x000037D3
		[global::Cpp2ILInjected.Token(Token = "0x6000F66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4FFAC", Offset = "0x1F4FFAC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Close()
		{
			throw null;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x000055D6 File Offset: 0x000037D6
		[global::Cpp2ILInjected.Token(Token = "0x6000F67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4BC48", Offset = "0x1F4BC48", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "set_ContentLength64", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "GetResponseStream", ReturnType = typeof(ResponseStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Close(byte[] responseEntity, bool willBlock)
		{
			throw null;
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x000055D9 File Offset: 0x000037D9
		[global::Cpp2ILInjected.Token(Token = "0x6000F68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4FFD0", Offset = "0x1F4FFD0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "Add", MemberParameters = new object[] { typeof(NameValueCollection) }, ReturnType = typeof(void))]
		public void CopyFrom(HttpListenerResponse templateResponse)
		{
			throw null;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x000055DC File Offset: 0x000037DC
		[global::Cpp2ILInjected.Token(Token = "0x6000F69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5003C", Offset = "0x1F5003C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public void Redirect(string url)
		{
			throw null;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000055DF File Offset: 0x000037DF
		[global::Cpp2ILInjected.Token(Token = "0x6000F6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F50064", Offset = "0x1F50064", Length = "0x31C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "SetCookie", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private bool FindCookie(Cookie cookie)
		{
			throw null;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000055E2 File Offset: 0x000037E2
		[global::Cpp2ILInjected.Token(Token = "0x6000F6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F50380", Offset = "0x1F50380", Length = "0x924")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "GetHeaders", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(Version),
			typeof(Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(Version),
			typeof(Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "CookieToClientString", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "get_KeepAlive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Encoding),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "FormatHeaders", MemberParameters = new object[] { typeof(WebHeaderCollection) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "GetResponseStream", ReturnType = typeof(ResponseStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		internal void SendHeaders(bool closing, MemoryStream ms)
		{
			throw null;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000055E5 File Offset: 0x000037E5
		[global::Cpp2ILInjected.Token(Token = "0x6000F6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F50F10", Offset = "0x1F50F10", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "AllowMultiValues", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static string FormatHeaders(WebHeaderCollection headers)
		{
			throw null;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000055E8 File Offset: 0x000037E8
		[global::Cpp2ILInjected.Token(Token = "0x6000F6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F50CA4", Offset = "0x1F50CA4", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "QuotedString", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static string CookieToClientString(Cookie cookie)
		{
			throw null;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x000055EB File Offset: 0x000037EB
		[global::Cpp2ILInjected.Token(Token = "0x6000F6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51128", Offset = "0x1F51128", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "CookieToClientString", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "IsToken", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string QuotedString(Cookie cookie, string value)
		{
			throw null;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000055EE File Offset: 0x000037EE
		[global::Cpp2ILInjected.Token(Token = "0x6000F6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F511EC", Offset = "0x1F511EC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "QuotedString", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsToken(string value)
		{
			throw null;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000055F1 File Offset: 0x000037F1
		[global::Cpp2ILInjected.Token(Token = "0x6000F70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F512B0", Offset = "0x1F512B0", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "FindCookie", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void SetCookie(Cookie cookie)
		{
			throw null;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000055F4 File Offset: 0x000037F4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000F71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F513B8", Offset = "0x1F513B8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static HttpListenerResponse()
		{
			throw null;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000055F7 File Offset: 0x000037F7
		[global::Cpp2ILInjected.Token(Token = "0x6000F72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51418", Offset = "0x1F51418", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal HttpListenerResponse()
		{
			throw null;
		}

		// Token: 0x04000990 RID: 2448
		[global::Cpp2ILInjected.Token(Token = "0x4000C47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool disposed;

		// Token: 0x04000991 RID: 2449
		[global::Cpp2ILInjected.Token(Token = "0x4000C48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Encoding content_encoding;

		// Token: 0x04000992 RID: 2450
		[global::Cpp2ILInjected.Token(Token = "0x4000C49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private long content_length;

		// Token: 0x04000993 RID: 2451
		[global::Cpp2ILInjected.Token(Token = "0x4000C4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool cl_set;

		// Token: 0x04000994 RID: 2452
		[global::Cpp2ILInjected.Token(Token = "0x4000C4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string content_type;

		// Token: 0x04000995 RID: 2453
		[global::Cpp2ILInjected.Token(Token = "0x4000C4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private CookieCollection cookies;

		// Token: 0x04000996 RID: 2454
		[global::Cpp2ILInjected.Token(Token = "0x4000C4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private WebHeaderCollection headers;

		// Token: 0x04000997 RID: 2455
		[global::Cpp2ILInjected.Token(Token = "0x4000C4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool keep_alive;

		// Token: 0x04000998 RID: 2456
		[global::Cpp2ILInjected.Token(Token = "0x4000C4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private ResponseStream output_stream;

		// Token: 0x04000999 RID: 2457
		[global::Cpp2ILInjected.Token(Token = "0x4000C50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Version version;

		// Token: 0x0400099A RID: 2458
		[global::Cpp2ILInjected.Token(Token = "0x4000C51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string location;

		// Token: 0x0400099B RID: 2459
		[global::Cpp2ILInjected.Token(Token = "0x4000C52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int status_code;

		// Token: 0x0400099C RID: 2460
		[global::Cpp2ILInjected.Token(Token = "0x4000C53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string status_description;

		// Token: 0x0400099D RID: 2461
		[global::Cpp2ILInjected.Token(Token = "0x4000C54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool chunked;

		// Token: 0x0400099E RID: 2462
		[global::Cpp2ILInjected.Token(Token = "0x4000C55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private HttpListenerContext context;

		// Token: 0x0400099F RID: 2463
		[global::Cpp2ILInjected.Token(Token = "0x4000C56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal bool HeadersSent;

		// Token: 0x040009A0 RID: 2464
		[global::Cpp2ILInjected.Token(Token = "0x4000C57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal object headers_lock;

		// Token: 0x040009A1 RID: 2465
		[global::Cpp2ILInjected.Token(Token = "0x4000C58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private bool force_close_chunked;

		// Token: 0x040009A2 RID: 2466
		[global::Cpp2ILInjected.Token(Token = "0x4000C59")]
		private static string tspecials;
	}
}
