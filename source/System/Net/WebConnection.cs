using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000280")]
	internal class WebConnection : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000404")]
		public ServicePoint ServicePoint
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600118E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0E280", Offset = "0x1E0E280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600118F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0AA74", Offset = "0x1E0AA74", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WebConnection(ServicePoint sPoint)
		{
			throw null;
		}

		[Conditional("MONO_WEB_DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001190")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0E288", Offset = "0x1E0E288", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Debug(string message, params object[] args)
		{
			throw null;
		}

		[Conditional("MONO_WEB_DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001191")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0E28C", Offset = "0x1E0E28C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Debug(string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001192")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0E290", Offset = "0x1E0E290", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Poll", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SelectMode)
		}, ReturnType = typeof(bool))]
		private bool CanReuse()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001193")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0E2B8", Offset = "0x1E0E2B8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection.<InitConnection>d__19), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Poll", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SelectMode)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private bool CheckReusable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001194")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0E364", Offset = "0x1E0E364", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection.<InitConnection>d__19), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebConnection.<Connect>d__16) }, MemberParameters = new object[] { typeof(ref WebConnection.<Connect>d__16) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Task Connect(WebOperation operation, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001195")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0E448", Offset = "0x1E0E448", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection.<InitConnection>d__19), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "Start", MemberTypeParameters = new object[] { typeof(WebConnection.<CreateStream>d__18) }, MemberParameters = new object[] { typeof(ref WebConnection.<CreateStream>d__18) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001196")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0E568", Offset = "0x1E0E568", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation.<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Start", MemberTypeParameters = new object[] { typeof(WebConnection.<InitConnection>d__19) }, MemberParameters = new object[] { typeof(ref WebConnection.<InitConnection>d__19) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001197")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0E66C", Offset = "0x1E0E66C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection.<Connect>d__16), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection.<CreateStream>d__18), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection.<InitConnection>d__19), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus),
			typeof(WebExceptionInternalStatus),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static WebException GetException(WebExceptionStatus status, Exception error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001198")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0E7EC", Offset = "0x1E0E7EC", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new object[]
		{
			typeof(BufferOffsetSize),
			typeof(ref int),
			typeof(ref ReadState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001199")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0A47C", Offset = "0x1E0A47C", Length = "0x40C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.ConnectionGroup", Member = "FindIdleConnection", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(WebConnection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Domain", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_UserName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Password", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal bool CanReuseConnection(WebOperation operation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600119A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0E9B8", Offset = "0x1E0E9B8", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "Continue", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Domain", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_UserName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Password", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool PrepareSharingNtlm(WebOperation operation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600119B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0ECCC", Offset = "0x1E0ECCC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection.<InitConnection>d__19), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600119C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0ED90", Offset = "0x1E0ED90", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "StartOperation", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "Continue", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void Close(bool reset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600119D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0EE58", Offset = "0x1E0EE58", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection.<InitConnection>d__19), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsStream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private void CloseSocket()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000405")]
		public bool Closed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600119E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0A18C", Offset = "0x1E0A18C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000406")]
		public bool Busy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600119F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F0C4", Offset = "0x1E0F0C4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000407")]
		public DateTime IdleSince
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F0D4", Offset = "0x1E0F0D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0A888", Offset = "0x1E0A888", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.ConnectionGroup", Member = "FindIdleConnection", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(WebConnection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.ConnectionGroup", Member = "CreateOrReuseConnection", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(bool)
		}, ReturnType = typeof(ValueTuple<WebConnection, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromDays", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "PrepareSharingNtlm", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "RegisterRequest", MemberParameters = new object[]
		{
			typeof(ServicePoint),
			typeof(WebConnection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public bool StartOperation(WebOperation operation, bool reused)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0940C", Offset = "0x1E0940C", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "OperationCompleted", MemberParameters = new object[]
		{
			"System.Net.ServicePointScheduler.ConnectionGroup",
			typeof(WebOperation)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "PrepareSharingNtlm", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "RegisterRequest", MemberParameters = new object[]
		{
			typeof(ServicePoint),
			typeof(WebConnection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool Continue(WebOperation next)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0F0DC", Offset = "0x1E0F0DC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.ConnectionGroup", Member = "RemoveConnection", MemberParameters = new object[] { typeof(WebConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.ConnectionGroup", Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0A184", Offset = "0x1E0A184", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0ED84", Offset = "0x1E0ED84", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ResetNtlm()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000408")]
		internal bool NtlmAuthenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F114", Offset = "0x1E0F114", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60011A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F11C", Offset = "0x1E0F11C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000409")]
		internal NetworkCredential NtlmCredential
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F128", Offset = "0x1E0F128", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60011A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F130", Offset = "0x1E0F130", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700040A")]
		internal bool UnsafeAuthenticatedConnectionSharing
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F138", Offset = "0x1E0F138", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60011AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F140", Offset = "0x1E0F140", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NetworkCredential ntlm_credentials;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool ntlm_authenticated;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool unsafe_sharing;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Stream networkStream;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Socket socket;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private MonoTlsStream monoTlsStream;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private WebConnectionTunnel tunnel;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int disposed;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly ServicePoint <ServicePoint>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal readonly int ID;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private DateTime idleSince;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private WebOperation currentOperation;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000281")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60011AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F14C", Offset = "0x1E0F14C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60011AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F1A8", Offset = "0x1E0F1A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60011AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F1B0", Offset = "0x1E0F1B0", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new object[]
			{
				typeof(EndPoint),
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60011AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F24C", Offset = "0x1E0F24C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void <Connect>b__16_1(IAsyncResult asyncResult)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000DA6")]
			public static readonly WebConnection.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4000DA7")]
			public static Func<IPEndPoint, AsyncCallback, object, IAsyncResult> <>9__16_0;

			[global::Cpp2ILInjected.Token(Token = "0x4000DA8")]
			public static Action<IAsyncResult> <>9__16_1;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000282")]
		[StructLayout(3)]
		private struct <Connect>d__16 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0F338", Offset = "0x1E0F338", Length = "0x788")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new object[]
			{
				typeof(WebExceptionStatus),
				typeof(Exception)
			}, ReturnType = typeof(WebException))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object, object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "FromAsync", MemberTypeParameters = new object[] { "TArg1" }, MemberParameters = new object[]
			{
				"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>",
				typeof(Action<IAsyncResult>),
				"TArg1",
				typeof(object)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebConnection.<Connect>d__16)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebConnection.<Connect>d__16)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(AddressFamily),
				typeof(SocketType),
				typeof(ProtocolType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(IPAddress),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_NoDelay", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "KeepAliveSetup", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "CallEndPointDelegate", MemberParameters = new object[]
			{
				typeof(Socket),
				typeof(IPEndPoint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 62)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60011B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0FAC0", Offset = "0x1E0FAC0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000DA9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000DAA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000DAB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebConnection <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000DAC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebOperation operation;

			[global::Cpp2ILInjected.Token(Token = "0x4000DAD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public CancellationToken cancellationToken;

			[global::Cpp2ILInjected.Token(Token = "0x4000DAE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private Exception <connectException>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000DAF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private IPAddress[] <>7__wrap2;

			[global::Cpp2ILInjected.Token(Token = "0x4000DB0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private int <>7__wrap3;

			[global::Cpp2ILInjected.Token(Token = "0x4000DB1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000283")]
		[StructLayout(3)]
		private struct <CreateStream>d__18 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0FACC", Offset = "0x1E0FACC", Length = "0x5AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(HttpWebRequest),
				typeof(NetworkStream)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsStream), Member = "CreateStream", MemberParameters = new object[]
			{
				typeof(WebConnectionTunnel),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task<Stream>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Socket),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionTunnel), Member = "Initialize", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebConnection.<CreateStream>d__18)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebConnection.<CreateStream>d__18)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "SetResult", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(WebConnection.<CreateStream>d__18)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref WebConnection.<CreateStream>d__18)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "FlattenException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new object[]
			{
				typeof(WebExceptionStatus),
				typeof(Exception)
			}, ReturnType = typeof(WebException))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60011B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E10188", Offset = "0x1E10188", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<bool>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000DB2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000DB3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000DB4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebConnection <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000DB5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebOperation operation;

			[global::Cpp2ILInjected.Token(Token = "0x4000DB6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public bool reused;

			[global::Cpp2ILInjected.Token(Token = "0x4000DB7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public CancellationToken cancellationToken;

			[global::Cpp2ILInjected.Token(Token = "0x4000DB8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private NetworkStream <stream>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000DB9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			[global::Cpp2ILInjected.Token(Token = "0x4000DBA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter <>u__2;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000284")]
		[StructLayout(3)]
		private struct <InitConnection>d__19 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E101E0", Offset = "0x1E101E0", Length = "0x450")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "CheckReusable", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "CloseSocket", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "Reset", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "Connect", MemberParameters = new object[]
			{
				typeof(WebOperation),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "CreateStream", MemberParameters = new object[]
			{
				typeof(WebOperation),
				typeof(bool),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task<bool>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<bool>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(WebConnection),
				typeof(WebOperation),
				typeof(Stream),
				typeof(WebConnectionTunnel)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter),
				typeof(WebConnection.<InitConnection>d__19)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter),
				typeof(ref WebConnection.<InitConnection>d__19)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebConnection.<InitConnection>d__19)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebConnection.<InitConnection>d__19)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new object[]
			{
				typeof(WebExceptionStatus),
				typeof(Exception)
			}, ReturnType = typeof(WebException))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60011B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E10630", Offset = "0x1E10630", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000DBB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000DBC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<WebRequestStream> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000DBD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebOperation operation;

			[global::Cpp2ILInjected.Token(Token = "0x4000DBE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			[global::Cpp2ILInjected.Token(Token = "0x4000DBF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public WebConnection <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000DC0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private bool <reused>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000DC1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			[global::Cpp2ILInjected.Token(Token = "0x4000DC2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
