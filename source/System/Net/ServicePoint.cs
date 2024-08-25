using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200026E")]
	public class ServicePoint
	{
		[global::Cpp2ILInjected.Token(Token = "0x60010C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0538C", Offset = "0x1E0538C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(IWebProxy)
		}, ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ServicePoint),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal ServicePoint(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003C3")]
		internal ServicePointManager.SPKey Key
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60010C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0563C", Offset = "0x1E0563C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003C4")]
		private ServicePointScheduler Scheduler
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60010CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05644", Offset = "0x1E05644", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60010CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0564C", Offset = "0x1E0564C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003C5")]
		public Uri Address
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05654", Offset = "0x1E05654", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003C6")]
		public BindIPEndPoint BindIPEndPointDelegate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0565C", Offset = "0x1E0565C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05664", Offset = "0x1E05664", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003C7")]
		public int ConnectionLeaseTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0566C", Offset = "0x1E0566C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05674", Offset = "0x1E05674", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003C8")]
		public int ConnectionLimit
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E056D4", Offset = "0x1E056D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E056DC", Offset = "0x1E056DC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003C9")]
		public string ConnectionName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05754", Offset = "0x1E05754", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003CA")]
		public int CurrentConnections
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05760", Offset = "0x1E05760", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003CB")]
		public DateTime IdleSince
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0577C", Offset = "0x1E0577C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003CC")]
		public int MaxIdleTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05800", Offset = "0x1E05800", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05808", Offset = "0x1E05808", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003CD")]
		public virtual Version ProtocolVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05880", Offset = "0x1E05880", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003CE")]
		public int ReceiveBufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05888", Offset = "0x1E05888", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05890", Offset = "0x1E05890", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003CF")]
		public bool SupportsPipelining
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E058F0", Offset = "0x1E058F0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "Equals", MemberParameters = new object[] { typeof(Version) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003D0")]
		public bool Expect100Continue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05954", Offset = "0x1E05954", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E059F4", Offset = "0x1E059F4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003D1")]
		public bool UseNagleAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05A00", Offset = "0x1E05A00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05A08", Offset = "0x1E05A08", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003D2")]
		internal bool SendContinue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05958", Offset = "0x1E05958", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Version),
				typeof(Version)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05A14", Offset = "0x1E05A14", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E05A20", Offset = "0x1E05A20", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(IWebProxy)
		}, ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E05AD0", Offset = "0x1E05AD0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "PutBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(uint),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "IOControl", MemberParameters = new object[]
		{
			typeof(IOControlCode),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void KeepAliveSetup(Socket socket)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E05B7C", Offset = "0x1E05B7C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "KeepAliveSetup", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void PutBytes(byte[] bytes, uint v, int offset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003D3")]
		internal bool UsesProxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05C40", Offset = "0x1E05C40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05C48", Offset = "0x1E05C48", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003D4")]
		internal bool UseConnect
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05C54", Offset = "0x1E05C54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05C5C", Offset = "0x1E05C5C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003D5")]
		private bool HasTimedOut
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05C68", Offset = "0x1E05C68", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(TimeSpan)
			}, ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003D6")]
		internal IPHostEntry HostEntry
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E05D94", Offset = "0x1E05D94", Length = "0x354")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPHostEntry), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPAddress))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "get_HasTimedOut", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E060E8", Offset = "0x1E060E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetVersion(Version version)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E060F0", Offset = "0x1E060F0", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "SendRequest", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BufferOffsetSize),
			typeof(CancellationToken)
		}, ReturnType = typeof(WebOperation))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "SendRequest", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal void SendRequest(WebOperation operation, string groupName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06330", Offset = "0x1E06330", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "CloseConnectionGroup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "CloseConnectionGroup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool CloseConnectionGroup(string connectionGroupName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06510", Offset = "0x1E06510", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void FreeServicePoint()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003D7")]
		public X509Certificate Certificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06520", Offset = "0x1E06520", Length = "0x184")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E066A4", Offset = "0x1E066A4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(X509Certificate),
			typeof(ref X509Chain),
			typeof(X509CertificateCollection),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(ValidationResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void UpdateServerCertificate(X509Certificate certificate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003D8")]
		public X509Certificate ClientCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E066D8", Offset = "0x1E066D8", Length = "0x184")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0685C", Offset = "0x1E0685C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsStream.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void UpdateClientCertificate(X509Certificate certificate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06890", Offset = "0x1E06890", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06A20", Offset = "0x1E06A20", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ServicePoint()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Uri uri;

		[global::Cpp2ILInjected.Token(Token = "0x4000D2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private DateTime lastDnsResolve;

		[global::Cpp2ILInjected.Token(Token = "0x4000D2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Version protocolVersion;

		[global::Cpp2ILInjected.Token(Token = "0x4000D2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IPHostEntry host;

		[global::Cpp2ILInjected.Token(Token = "0x4000D30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool usesProxy;

		[global::Cpp2ILInjected.Token(Token = "0x4000D31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		private bool sendContinue;

		[global::Cpp2ILInjected.Token(Token = "0x4000D32")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		private bool useConnect;

		[global::Cpp2ILInjected.Token(Token = "0x4000D33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object hostE;

		[global::Cpp2ILInjected.Token(Token = "0x4000D34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool useNagle;

		[global::Cpp2ILInjected.Token(Token = "0x4000D35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private BindIPEndPoint endPointCallback;

		[global::Cpp2ILInjected.Token(Token = "0x4000D36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool tcp_keepalive;

		[global::Cpp2ILInjected.Token(Token = "0x4000D37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int tcp_keepalive_time;

		[global::Cpp2ILInjected.Token(Token = "0x4000D38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int tcp_keepalive_interval;

		[global::Cpp2ILInjected.Token(Token = "0x4000D39")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private bool disposed;

		[global::Cpp2ILInjected.Token(Token = "0x4000D3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int connectionLeaseTimeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000D3B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int receiveBufferSize;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000D3C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private readonly ServicePointManager.SPKey <Key>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000D3D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private ServicePointScheduler <Scheduler>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000D3E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int connectionLimit;

		[global::Cpp2ILInjected.Token(Token = "0x4000D3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private int maxIdleTime;

		[global::Cpp2ILInjected.Token(Token = "0x4000D40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private object m_ServerCertificateOrBytes;

		[global::Cpp2ILInjected.Token(Token = "0x4000D41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private object m_ClientCertificateOrBytes;
	}
}
