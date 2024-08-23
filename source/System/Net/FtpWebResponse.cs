using System;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000E7 RID: 231
	[global::Cpp2ILInjected.Token(Token = "0x2000156")]
	public class FtpWebResponse : WebResponse, IDisposable
	{
		// Token: 0x060007C7 RID: 1991 RVA: 0x000044A8 File Offset: 0x000026A8
		[global::Cpp2ILInjected.Token(Token = "0x6000897")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF8B04", Offset = "0x1EF8B04", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponse), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage)
		{
			throw null;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000044AB File Offset: 0x000026AB
		[global::Cpp2ILInjected.Token(Token = "0x6000898")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF7270", Offset = "0x1EF7270", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage)
		{
			throw null;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000044AE File Offset: 0x000026AE
		[global::Cpp2ILInjected.Token(Token = "0x6000899")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF91CC", Offset = "0x1EF91CC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebResponse.EmptyStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Stream GetResponseStream()
		{
			throw null;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000044B1 File Offset: 0x000026B1
		[global::Cpp2ILInjected.Token(Token = "0x600089A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF8A70", Offset = "0x1EF8A70", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void SetResponseStream(Stream stream)
		{
			throw null;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000044B4 File Offset: 0x000026B4
		[global::Cpp2ILInjected.Token(Token = "0x600089B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF92B8", Offset = "0x1EF92B8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x000044B7 File Offset: 0x000026B7
		[global::Cpp2ILInjected.Token(Token = "0x170001D6")]
		public override long ContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x600089C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF93AC", Offset = "0x1EF93AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x000044BA File Offset: 0x000026BA
		[global::Cpp2ILInjected.Token(Token = "0x170001D7")]
		public override WebHeaderCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x600089D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF93B4", Offset = "0x1EF93B4", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x000044BD File Offset: 0x000026BD
		[global::Cpp2ILInjected.Token(Token = "0x170001D8")]
		public override bool SupportsHeaders
		{
			[global::Cpp2ILInjected.Token(Token = "0x600089E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF94C8", Offset = "0x1EF94C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x000044C0 File Offset: 0x000026C0
		[global::Cpp2ILInjected.Token(Token = "0x170001D9")]
		public override Uri ResponseUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x600089F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF94D0", Offset = "0x1EF94D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x000044C3 File Offset: 0x000026C3
		[global::Cpp2ILInjected.Token(Token = "0x170001DA")]
		public FtpStatusCode StatusCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF94D8", Offset = "0x1EF94D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x000044C6 File Offset: 0x000026C6
		[global::Cpp2ILInjected.Token(Token = "0x170001DB")]
		public string StatusDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF94E0", Offset = "0x1EF94E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x000044C9 File Offset: 0x000026C9
		[global::Cpp2ILInjected.Token(Token = "0x170001DC")]
		public DateTime LastModified
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF94E8", Offset = "0x1EF94E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x000044CC File Offset: 0x000026CC
		[global::Cpp2ILInjected.Token(Token = "0x170001DD")]
		public string BannerMessage
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF94F0", Offset = "0x1EF94F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x000044CF File Offset: 0x000026CF
		[global::Cpp2ILInjected.Token(Token = "0x170001DE")]
		public string WelcomeMessage
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF94F8", Offset = "0x1EF94F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x000044D2 File Offset: 0x000026D2
		[global::Cpp2ILInjected.Token(Token = "0x170001DF")]
		public string ExitMessage
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9500", Offset = "0x1EF9500", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000044D5 File Offset: 0x000026D5
		[global::Cpp2ILInjected.Token(Token = "0x60008A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF9508", Offset = "0x1EF9508", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal FtpWebResponse()
		{
			throw null;
		}

		// Token: 0x04000549 RID: 1353
		[global::Cpp2ILInjected.Token(Token = "0x40006EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal Stream _responseStream;

		// Token: 0x0400054A RID: 1354
		[global::Cpp2ILInjected.Token(Token = "0x40006F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private long _contentLength;

		// Token: 0x0400054B RID: 1355
		[global::Cpp2ILInjected.Token(Token = "0x40006F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Uri _responseUri;

		// Token: 0x0400054C RID: 1356
		[global::Cpp2ILInjected.Token(Token = "0x40006F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private FtpStatusCode _statusCode;

		// Token: 0x0400054D RID: 1357
		[global::Cpp2ILInjected.Token(Token = "0x40006F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _statusLine;

		// Token: 0x0400054E RID: 1358
		[global::Cpp2ILInjected.Token(Token = "0x40006F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private WebHeaderCollection _ftpRequestHeaders;

		// Token: 0x0400054F RID: 1359
		[global::Cpp2ILInjected.Token(Token = "0x40006F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private DateTime _lastModified;

		// Token: 0x04000550 RID: 1360
		[global::Cpp2ILInjected.Token(Token = "0x40006F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string _bannerMessage;

		// Token: 0x04000551 RID: 1361
		[global::Cpp2ILInjected.Token(Token = "0x40006F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string _welcomeMessage;

		// Token: 0x04000552 RID: 1362
		[global::Cpp2ILInjected.Token(Token = "0x40006F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private string _exitMessage;

		// Token: 0x020003D7 RID: 983
		[global::Cpp2ILInjected.Token(Token = "0x2000157")]
		internal sealed class EmptyStream : MemoryStream
		{
			// Token: 0x06001D74 RID: 7540 RVA: 0x00008144 File Offset: 0x00006344
			[global::Cpp2ILInjected.Token(Token = "0x60008A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF922C", Offset = "0x1EF922C", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebResponse), Member = "GetResponseStream", ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal EmptyStream()
			{
				throw null;
			}
		}
	}
}
