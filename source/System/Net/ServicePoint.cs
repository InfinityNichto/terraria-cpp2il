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
	// Token: 0x020001AC RID: 428
	[global::Cpp2ILInjected.Token(Token = "0x200026E")]
	public class ServicePoint
	{
		// Token: 0x06000F26 RID: 3878 RVA: 0x000059A5 File Offset: 0x00003BA5
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

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x000059A8 File Offset: 0x00003BA8
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

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x000059AB File Offset: 0x00003BAB
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x000059AE File Offset: 0x00003BAE
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

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x000059B1 File Offset: 0x00003BB1
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x000059B4 File Offset: 0x00003BB4
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x000059B7 File Offset: 0x00003BB7
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

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000059BA File Offset: 0x00003BBA
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x000059BD File Offset: 0x00003BBD
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

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000059C0 File Offset: 0x00003BC0
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x000059C3 File Offset: 0x00003BC3
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

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x000059C6 File Offset: 0x00003BC6
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

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x000059C9 File Offset: 0x00003BC9
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

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x000059CC File Offset: 0x00003BCC
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

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x000059CF File Offset: 0x00003BCF
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x000059D2 File Offset: 0x00003BD2
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

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x000059D5 File Offset: 0x00003BD5
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

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x000059D8 File Offset: 0x00003BD8
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x000059DB File Offset: 0x00003BDB
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

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x000059DE File Offset: 0x00003BDE
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

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x000059E1 File Offset: 0x00003BE1
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x000059E4 File Offset: 0x00003BE4
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

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x000059E7 File Offset: 0x00003BE7
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x000059EA File Offset: 0x00003BEA
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

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x000059ED File Offset: 0x00003BED
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x000059F0 File Offset: 0x00003BF0
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

		// Token: 0x06000F40 RID: 3904 RVA: 0x000059F3 File Offset: 0x00003BF3
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

		// Token: 0x06000F41 RID: 3905 RVA: 0x000059F6 File Offset: 0x00003BF6
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

		// Token: 0x06000F42 RID: 3906 RVA: 0x000059F9 File Offset: 0x00003BF9
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

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000059FC File Offset: 0x00003BFC
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x000059FF File Offset: 0x00003BFF
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

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00005A02 File Offset: 0x00003C02
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00005A05 File Offset: 0x00003C05
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

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00005A08 File Offset: 0x00003C08
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

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00005A0B File Offset: 0x00003C0B
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

		// Token: 0x06000F49 RID: 3913 RVA: 0x00005A0E File Offset: 0x00003C0E
		[global::Cpp2ILInjected.Token(Token = "0x60010EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E060E8", Offset = "0x1E060E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetVersion(Version version)
		{
			throw null;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00005A11 File Offset: 0x00003C11
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

		// Token: 0x06000F4B RID: 3915 RVA: 0x00005A14 File Offset: 0x00003C14
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

		// Token: 0x06000F4C RID: 3916 RVA: 0x00005A17 File Offset: 0x00003C17
		[global::Cpp2ILInjected.Token(Token = "0x60010EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06510", Offset = "0x1E06510", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void FreeServicePoint()
		{
			throw null;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00005A1A File Offset: 0x00003C1A
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

		// Token: 0x06000F4E RID: 3918 RVA: 0x00005A1D File Offset: 0x00003C1D
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00005A20 File Offset: 0x00003C20
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

		// Token: 0x06000F50 RID: 3920 RVA: 0x00005A23 File Offset: 0x00003C23
		[global::Cpp2ILInjected.Token(Token = "0x60010F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0685C", Offset = "0x1E0685C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsStream.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void UpdateClientCertificate(X509Certificate certificate)
		{
			throw null;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00005A26 File Offset: 0x00003C26
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

		// Token: 0x06000F52 RID: 3922 RVA: 0x00005A29 File Offset: 0x00003C29
		[global::Cpp2ILInjected.Token(Token = "0x60010F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06A20", Offset = "0x1E06A20", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ServicePoint()
		{
			throw null;
		}

		// Token: 0x04000A2A RID: 2602
		[global::Cpp2ILInjected.Token(Token = "0x4000D2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Uri uri;

		// Token: 0x04000A2B RID: 2603
		[global::Cpp2ILInjected.Token(Token = "0x4000D2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private DateTime lastDnsResolve;

		// Token: 0x04000A2C RID: 2604
		[global::Cpp2ILInjected.Token(Token = "0x4000D2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Version protocolVersion;

		// Token: 0x04000A2D RID: 2605
		[global::Cpp2ILInjected.Token(Token = "0x4000D2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IPHostEntry host;

		// Token: 0x04000A2E RID: 2606
		[global::Cpp2ILInjected.Token(Token = "0x4000D30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool usesProxy;

		// Token: 0x04000A2F RID: 2607
		[global::Cpp2ILInjected.Token(Token = "0x4000D31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		private bool sendContinue;

		// Token: 0x04000A30 RID: 2608
		[global::Cpp2ILInjected.Token(Token = "0x4000D32")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		private bool useConnect;

		// Token: 0x04000A31 RID: 2609
		[global::Cpp2ILInjected.Token(Token = "0x4000D33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object hostE;

		// Token: 0x04000A32 RID: 2610
		[global::Cpp2ILInjected.Token(Token = "0x4000D34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool useNagle;

		// Token: 0x04000A33 RID: 2611
		[global::Cpp2ILInjected.Token(Token = "0x4000D35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private BindIPEndPoint endPointCallback;

		// Token: 0x04000A34 RID: 2612
		[global::Cpp2ILInjected.Token(Token = "0x4000D36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool tcp_keepalive;

		// Token: 0x04000A35 RID: 2613
		[global::Cpp2ILInjected.Token(Token = "0x4000D37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int tcp_keepalive_time;

		// Token: 0x04000A36 RID: 2614
		[global::Cpp2ILInjected.Token(Token = "0x4000D38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int tcp_keepalive_interval;

		// Token: 0x04000A37 RID: 2615
		[global::Cpp2ILInjected.Token(Token = "0x4000D39")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private bool disposed;

		// Token: 0x04000A38 RID: 2616
		[global::Cpp2ILInjected.Token(Token = "0x4000D3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int connectionLeaseTimeout;

		// Token: 0x04000A39 RID: 2617
		[global::Cpp2ILInjected.Token(Token = "0x4000D3B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int receiveBufferSize;

		// Token: 0x04000A3A RID: 2618
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000D3C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private readonly ServicePointManager.SPKey <Key>k__BackingField;

		// Token: 0x04000A3B RID: 2619
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000D3D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private ServicePointScheduler <Scheduler>k__BackingField;

		// Token: 0x04000A3C RID: 2620
		[global::Cpp2ILInjected.Token(Token = "0x4000D3E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int connectionLimit;

		// Token: 0x04000A3D RID: 2621
		[global::Cpp2ILInjected.Token(Token = "0x4000D3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private int maxIdleTime;

		// Token: 0x04000A3E RID: 2622
		[global::Cpp2ILInjected.Token(Token = "0x4000D40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private object m_ServerCertificateOrBytes;

		// Token: 0x04000A3F RID: 2623
		[global::Cpp2ILInjected.Token(Token = "0x4000D41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private object m_ClientCertificateOrBytes;
	}
}
