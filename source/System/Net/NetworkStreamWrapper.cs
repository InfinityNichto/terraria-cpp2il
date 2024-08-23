using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000E8 RID: 232
	[global::Cpp2ILInjected.Token(Token = "0x2000158")]
	internal class NetworkStreamWrapper : Stream
	{
		// Token: 0x060007D7 RID: 2007 RVA: 0x000044D8 File Offset: 0x000026D8
		[global::Cpp2ILInjected.Token(Token = "0x60008A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF9540", Offset = "0x1EF9540", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal NetworkStreamWrapper(TcpClient client)
		{
			throw null;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x000044DB File Offset: 0x000026DB
		[global::Cpp2ILInjected.Token(Token = "0x170001E0")]
		protected bool UsingSecureStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF95BC", Offset = "0x1EF95BC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
			{
				typeof(CommandStream.PipelineEntry),
				typeof(ResponseDescription),
				typeof(bool),
				typeof(ref Stream)
			}, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000044DE File Offset: 0x000026DE
		[global::Cpp2ILInjected.Token(Token = "0x170001E1")]
		internal IPAddress ServerAddress
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9638", Offset = "0x1EF9638", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
			{
				typeof(CommandStream.PipelineEntry),
				typeof(ResponseDescription),
				typeof(bool),
				typeof(ref Stream),
				typeof(ref bool)
			}, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x000044E1 File Offset: 0x000026E1
		[global::Cpp2ILInjected.Token(Token = "0x170001E2")]
		internal Socket Socket
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF96C0", Offset = "0x1EF96C0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
			{
				typeof(CommandStream.PipelineEntry),
				typeof(ResponseDescription),
				typeof(bool),
				typeof(ref Stream)
			}, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
			{
				typeof(CommandStream.PipelineEntry),
				typeof(ResponseDescription),
				typeof(bool),
				typeof(ref Stream),
				typeof(ref bool)
			}, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x000044E4 File Offset: 0x000026E4
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x000044E7 File Offset: 0x000026E7
		[global::Cpp2ILInjected.Token(Token = "0x170001E3")]
		internal NetworkStream NetworkStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF96CC", Offset = "0x1EF96CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF96D4", Offset = "0x1EF96D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x000044EA File Offset: 0x000026EA
		[global::Cpp2ILInjected.Token(Token = "0x170001E4")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF96DC", Offset = "0x1EF96DC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x000044ED File Offset: 0x000026ED
		[global::Cpp2ILInjected.Token(Token = "0x170001E5")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF96EC", Offset = "0x1EF96EC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x000044F0 File Offset: 0x000026F0
		[global::Cpp2ILInjected.Token(Token = "0x170001E6")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF96FC", Offset = "0x1EF96FC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x000044F3 File Offset: 0x000026F3
		[global::Cpp2ILInjected.Token(Token = "0x170001E7")]
		public override bool CanTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF970C", Offset = "0x1EF970C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x000044F6 File Offset: 0x000026F6
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x000044F9 File Offset: 0x000026F9
		[global::Cpp2ILInjected.Token(Token = "0x170001E8")]
		public override int ReadTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF971C", Offset = "0x1EF971C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9730", Offset = "0x1EF9730", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x000044FC File Offset: 0x000026FC
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x000044FF File Offset: 0x000026FF
		[global::Cpp2ILInjected.Token(Token = "0x170001E9")]
		public override int WriteTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9744", Offset = "0x1EF9744", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF9758", Offset = "0x1EF9758", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00004502 File Offset: 0x00002702
		[global::Cpp2ILInjected.Token(Token = "0x170001EA")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF976C", Offset = "0x1EF976C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00004505 File Offset: 0x00002705
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00004508 File Offset: 0x00002708
		[global::Cpp2ILInjected.Token(Token = "0x170001EB")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF977C", Offset = "0x1EF977C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60008B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF978C", Offset = "0x1EF978C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0000450B File Offset: 0x0000270B
		[global::Cpp2ILInjected.Token(Token = "0x60008B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF97A0", Offset = "0x1EF97A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0000450E File Offset: 0x0000270E
		[global::Cpp2ILInjected.Token(Token = "0x60008BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF97B4", Offset = "0x1EF97B4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int Read(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00004511 File Offset: 0x00002711
		[global::Cpp2ILInjected.Token(Token = "0x60008BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF97C8", Offset = "0x1EF97C8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Write(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00004514 File Offset: 0x00002714
		[global::Cpp2ILInjected.Token(Token = "0x60008BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF97DC", Offset = "0x1EF97DC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00004517 File Offset: 0x00002717
		[global::Cpp2ILInjected.Token(Token = "0x60008BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF106C", Offset = "0x1EF106C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReadCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new object[]
		{
			typeof(ReceiveState),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "ConnectCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "SSLHandshakeCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Dispose", ReturnType = typeof(void))]
		internal void CloseSocket()
		{
			throw null;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0000451A File Offset: 0x0000271A
		[global::Cpp2ILInjected.Token(Token = "0x60008BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF98A0", Offset = "0x1EF98A0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "Abort", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStream), Member = "Close", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Dispose", ReturnType = typeof(void))]
		public void Close(int timeout)
		{
			throw null;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0000451D File Offset: 0x0000271D
		[global::Cpp2ILInjected.Token(Token = "0x60008BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF98C4", Offset = "0x1EF98C4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00004520 File Offset: 0x00002720
		[global::Cpp2ILInjected.Token(Token = "0x60008C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF98D8", Offset = "0x1EF98D8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00004523 File Offset: 0x00002723
		[global::Cpp2ILInjected.Token(Token = "0x60008C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF98EC", Offset = "0x1EF98EC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00004526 File Offset: 0x00002726
		[global::Cpp2ILInjected.Token(Token = "0x60008C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF9900", Offset = "0x1EF9900", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00004529 File Offset: 0x00002729
		[global::Cpp2ILInjected.Token(Token = "0x60008C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF9914", Offset = "0x1EF9914", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0000452C File Offset: 0x0000272C
		[global::Cpp2ILInjected.Token(Token = "0x60008C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF9928", Offset = "0x1EF9928", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0000452F File Offset: 0x0000272F
		[global::Cpp2ILInjected.Token(Token = "0x60008C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF993C", Offset = "0x1EF993C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00004532 File Offset: 0x00002732
		[global::Cpp2ILInjected.Token(Token = "0x60008C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF9950", Offset = "0x1EF9950", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00004535 File Offset: 0x00002735
		[global::Cpp2ILInjected.Token(Token = "0x60008C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF9964", Offset = "0x1EF9964", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00004538 File Offset: 0x00002738
		[global::Cpp2ILInjected.Token(Token = "0x60008C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF6934", Offset = "0x1EF6934", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void SetSocketTimeoutOption(int timeout)
		{
			throw null;
		}

		// Token: 0x04000553 RID: 1363
		[global::Cpp2ILInjected.Token(Token = "0x40006F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private TcpClient _client;

		// Token: 0x04000554 RID: 1364
		[global::Cpp2ILInjected.Token(Token = "0x40006FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private NetworkStream _networkStream;
	}
}
