using System;
using System.Collections.Specialized;
using System.Net.WebSockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200024C")]
	public sealed class HttpListenerContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000EF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49870", Offset = "0x1F49870", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = ".ctor", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = ".ctor", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal HttpListenerContext(HttpConnection cnc)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700031D")]
		internal int ErrorStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4E078", Offset = "0x1F4E078", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000EF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4E080", Offset = "0x1F4E080", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700031E")]
		internal string ErrorMessage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4E088", Offset = "0x1F4E088", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000EFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4E090", Offset = "0x1F4E090", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700031F")]
		internal bool HaveError
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4A4D0", Offset = "0x1F4A4D0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000320")]
		internal HttpConnection Connection
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4E098", Offset = "0x1F4E098", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000321")]
		public HttpListenerRequest Request
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4E0A0", Offset = "0x1F4E0A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000322")]
		public HttpListenerResponse Response
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4E0A8", Offset = "0x1F4E0A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000323")]
		public IPrincipal User
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F00")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4E0B0", Offset = "0x1F4E0B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4D92C", Offset = "0x1F4D92C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(HttpListenerContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerContext), Member = "ParseBasicAuthentication", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPrincipal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void ParseAuthentication(AuthenticationSchemes expectedSchemes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E0B8", Offset = "0x1F4E0B8", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerContext), Member = "ParseAuthentication", MemberParameters = new object[] { typeof(AuthenticationSchemes) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerBasicIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenericPrincipal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IIdentity),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal IPrincipal ParseBasicAuthentication(string authData)
		{
			throw null;
		}

		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x6000F03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E2C4", Offset = "0x1F4E2C4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol)
		{
			throw null;
		}

		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x6000F04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E2FC", Offset = "0x1F4E2FC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, TimeSpan keepAliveInterval)
		{
			throw null;
		}

		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x6000F05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E334", Offset = "0x1F4E334", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval)
		{
			throw null;
		}

		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x6000F06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E36C", Offset = "0x1F4E36C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval, ArraySegment<byte> internalBuffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E3A4", Offset = "0x1F4E3A4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal HttpListenerContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000C29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private HttpListenerRequest request;

		[global::Cpp2ILInjected.Token(Token = "0x4000C2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private HttpListenerResponse response;

		[global::Cpp2ILInjected.Token(Token = "0x4000C2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IPrincipal user;

		[global::Cpp2ILInjected.Token(Token = "0x4000C2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private HttpConnection cnc;

		[global::Cpp2ILInjected.Token(Token = "0x4000C2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string error;

		[global::Cpp2ILInjected.Token(Token = "0x4000C2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int err_status;

		[global::Cpp2ILInjected.Token(Token = "0x4000C2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal HttpListener Listener;
	}
}
