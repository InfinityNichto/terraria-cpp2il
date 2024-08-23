using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000D0 RID: 208
	[global::Cpp2ILInjected.Token(Token = "0x2000132")]
	internal class TlsStream : NetworkStream
	{
		// Token: 0x06000680 RID: 1664 RVA: 0x000040D3 File Offset: 0x000022D3
		[global::Cpp2ILInjected.Token(Token = "0x6000730")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5414", Offset = "0x1EE5414", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointManager), Member = "get_ServerCertificateValidationCallback", ReturnType = typeof(RemoteCertificateValidationCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public TlsStream(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates)
		{
			throw null;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000040D6 File Offset: 0x000022D6
		[global::Cpp2ILInjected.Token(Token = "0x6000731")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE54E0", Offset = "0x1EE54E0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void AuthenticateAsClient()
		{
			throw null;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000040D9 File Offset: 0x000022D9
		[global::Cpp2ILInjected.Token(Token = "0x6000732")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE55D8", Offset = "0x1EE55D8", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state)
		{
			throw null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000040DC File Offset: 0x000022DC
		[global::Cpp2ILInjected.Token(Token = "0x6000733")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE56E8", Offset = "0x1EE56E8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream.<>c__DisplayClass31_0", Member = "<PipelineCallback>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void EndAuthenticateAsClient(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000040DF File Offset: 0x000022DF
		[global::Cpp2ILInjected.Token(Token = "0x6000734")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE56FC", Offset = "0x1EE56FC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000040E2 File Offset: 0x000022E2
		[global::Cpp2ILInjected.Token(Token = "0x6000735")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5710", Offset = "0x1EE5710", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void EndWrite(IAsyncResult result)
		{
			throw null;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000040E5 File Offset: 0x000022E5
		[global::Cpp2ILInjected.Token(Token = "0x6000736")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5724", Offset = "0x1EE5724", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Write(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000040E8 File Offset: 0x000022E8
		[global::Cpp2ILInjected.Token(Token = "0x6000737")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5738", Offset = "0x1EE5738", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int Read(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000040EB File Offset: 0x000022EB
		[global::Cpp2ILInjected.Token(Token = "0x6000738")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE574C", Offset = "0x1EE574C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000040EE File Offset: 0x000022EE
		[global::Cpp2ILInjected.Token(Token = "0x6000739")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5760", Offset = "0x1EE5760", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x000040F1 File Offset: 0x000022F1
		[global::Cpp2ILInjected.Token(Token = "0x600073A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5774", Offset = "0x1EE5774", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400044C RID: 1100
		[global::Cpp2ILInjected.Token(Token = "0x40005C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private SslStream _sslStream;

		// Token: 0x0400044D RID: 1101
		[global::Cpp2ILInjected.Token(Token = "0x40005C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string _host;

		// Token: 0x0400044E RID: 1102
		[global::Cpp2ILInjected.Token(Token = "0x40005C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private X509CertificateCollection _clientCertificates;
	}
}
