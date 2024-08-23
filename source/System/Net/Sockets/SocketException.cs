using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	// Token: 0x02000207 RID: 519
	[global::Cpp2ILInjected.Token(Token = "0x20002F6")]
	[Serializable]
	public class SocketException : Win32Exception
	{
		// Token: 0x060011C7 RID: 4551
		[global::Cpp2ILInjected.Token(Token = "0x6001400")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3297C", Offset = "0x1E3297C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int WSAGetLastError_icall();

		// Token: 0x060011C8 RID: 4552 RVA: 0x00006104 File Offset: 0x00004304
		[global::Cpp2ILInjected.Token(Token = "0x6001401")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E32980", Offset = "0x1E32980", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public SocketException()
		{
			throw null;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00006107 File Offset: 0x00004307
		[global::Cpp2ILInjected.Token(Token = "0x6001402")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E329A0", Offset = "0x1E329A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		internal SocketException(int error, string message)
		{
			throw null;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0000610A File Offset: 0x0000430A
		[global::Cpp2ILInjected.Token(Token = "0x6001403")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2F3DC", Offset = "0x1E2F3DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public SocketException(int errorCode)
		{
			throw null;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0000610D File Offset: 0x0000430D
		[global::Cpp2ILInjected.Token(Token = "0x6001404")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E32190", Offset = "0x1E32190", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "get_ScopeId", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "set_ScopeId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "get_Address", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "set_Address", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(IList<ArraySegment<byte>>),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(IList<ArraySegment<byte>>),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		internal SocketException(SocketError socketError)
		{
			throw null;
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00006110 File Offset: 0x00004310
		[global::Cpp2ILInjected.Token(Token = "0x6001405")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E329A8", Offset = "0x1E329A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00006113 File Offset: 0x00004313
		[global::Cpp2ILInjected.Token(Token = "0x17000486")]
		public override int ErrorCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001406")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E329B0", Offset = "0x1E329B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00006116 File Offset: 0x00004316
		[global::Cpp2ILInjected.Token(Token = "0x17000487")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001407")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E329B8", Offset = "0x1E329B8", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x00006119 File Offset: 0x00004319
		[global::Cpp2ILInjected.Token(Token = "0x17000488")]
		public SocketError SocketErrorCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001408")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E30A9C", Offset = "0x1E30A9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "TranslateConnectException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000BE8 RID: 3048
		[global::Cpp2ILInjected.Token(Token = "0x4000FE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private EndPoint m_EndPoint;
	}
}
