using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	// Token: 0x02000205 RID: 517
	[global::Cpp2ILInjected.Token(Token = "0x20002EA")]
	public class NetworkStream : Stream
	{
		// Token: 0x06001108 RID: 4360 RVA: 0x00005F0F File Offset: 0x0000410F
		[global::Cpp2ILInjected.Token(Token = "0x6001301")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E218A0", Offset = "0x1E218A0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TlsStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(NetworkStream),
			typeof(Socket),
			typeof(string),
			typeof(X509CertificateCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public NetworkStream(Socket socket)
		{
			throw null;
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00005F12 File Offset: 0x00004112
		[global::Cpp2ILInjected.Token(Token = "0x6001302")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E21A4C", Offset = "0x1E21A4C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(EndPointListener),
			typeof(bool),
			typeof(X509Certificate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(FileAccess),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public NetworkStream(Socket socket, bool ownsSocket)
		{
			throw null;
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00005F15 File Offset: 0x00004115
		[global::Cpp2ILInjected.Token(Token = "0x6001303")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E218AC", Offset = "0x1E218AC", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public NetworkStream(Socket socket, FileAccess access, bool ownsSocket)
		{
			throw null;
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x00005F18 File Offset: 0x00004118
		[global::Cpp2ILInjected.Token(Token = "0x17000465")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001304")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E21A58", Offset = "0x1E21A58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x00005F1B File Offset: 0x0000411B
		[global::Cpp2ILInjected.Token(Token = "0x17000466")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001305")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E21A60", Offset = "0x1E21A60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x00005F1E File Offset: 0x0000411E
		[global::Cpp2ILInjected.Token(Token = "0x17000467")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001306")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E21A68", Offset = "0x1E21A68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x00005F21 File Offset: 0x00004121
		[global::Cpp2ILInjected.Token(Token = "0x17000468")]
		public override bool CanTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001307")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E21A70", Offset = "0x1E21A70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x00005F24 File Offset: 0x00004124
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x00005F27 File Offset: 0x00004127
		[global::Cpp2ILInjected.Token(Token = "0x17000469")]
		public override int ReadTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001308")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E21A78", Offset = "0x1E21A78", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001309")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E21C90", Offset = "0x1E21C90", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x00005F2A File Offset: 0x0000412A
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x00005F2D File Offset: 0x0000412D
		[global::Cpp2ILInjected.Token(Token = "0x1700046A")]
		public override int WriteTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x600130A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E21ED4", Offset = "0x1E21ED4", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600130B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E21F50", Offset = "0x1E21F50", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStream), Member = "SetSocketTimeoutOption", MemberParameters = new object[]
			{
				typeof(SocketShutdown),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x00005F30 File Offset: 0x00004130
		[global::Cpp2ILInjected.Token(Token = "0x1700046B")]
		public virtual bool DataAvailable
		{
			[global::Cpp2ILInjected.Token(Token = "0x600130C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E21FD4", Offset = "0x1E21FD4", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_Available", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x00005F33 File Offset: 0x00004133
		[global::Cpp2ILInjected.Token(Token = "0x1700046C")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600130D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E22114", Offset = "0x1E22114", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x00005F36 File Offset: 0x00004136
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x00005F39 File Offset: 0x00004139
		[global::Cpp2ILInjected.Token(Token = "0x1700046D")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600130E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E22160", Offset = "0x1E22160", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600130F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E221AC", Offset = "0x1E221AC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00005F3C File Offset: 0x0000413C
		[global::Cpp2ILInjected.Token(Token = "0x6001310")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E221F8", Offset = "0x1E221F8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00005F3F File Offset: 0x0000413F
		[global::Cpp2ILInjected.Token(Token = "0x6001311")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E22244", Offset = "0x1E22244", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public override int Read(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00005F42 File Offset: 0x00004142
		[global::Cpp2ILInjected.Token(Token = "0x6001312")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2256C", Offset = "0x1E2256C", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Read", MemberParameters = new object[] { typeof(Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new object[]
		{
			typeof(Span<byte>),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public override int Read(Span<byte> destination)
		{
			throw null;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00005F45 File Offset: 0x00004145
		[global::Cpp2ILInjected.Token(Token = "0x6001313")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E228AC", Offset = "0x1E228AC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int ReadByte()
		{
			throw null;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00005F48 File Offset: 0x00004148
		[global::Cpp2ILInjected.Token(Token = "0x6001314")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E22930", Offset = "0x1E22930", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public override void Write(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00005F4B File Offset: 0x0000414B
		[global::Cpp2ILInjected.Token(Token = "0x6001315")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E22C58", Offset = "0x1E22C58", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Write", MemberParameters = new object[] { typeof(ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<byte>),
			typeof(SocketFlags),
			typeof(ref SocketError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public override void Write(ReadOnlySpan<byte> source)
		{
			throw null;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00005F4E File Offset: 0x0000414E
		[global::Cpp2ILInjected.Token(Token = "0x6001316")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E22F18", Offset = "0x1E22F18", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteByte(byte value)
		{
			throw null;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00005F51 File Offset: 0x00004151
		[global::Cpp2ILInjected.Token(Token = "0x6001317")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E22F90", Offset = "0x1E22F90", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "System.Net.ICloseEx.CloseEx", MemberParameters = new object[] { typeof(CloseExState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStreamWrapper), Member = "Close", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Close(int timeout)
		{
			throw null;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00005F54 File Offset: 0x00004154
		[global::Cpp2ILInjected.Token(Token = "0x6001318")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E22FF4", Offset = "0x1E22FF4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "InternalShutdown", MemberParameters = new object[] { typeof(SocketShutdown) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00005F57 File Offset: 0x00004157
		[global::Cpp2ILInjected.Token(Token = "0x6001319")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E230F0", Offset = "0x1E230F0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00005F5A File Offset: 0x0000415A
		[global::Cpp2ILInjected.Token(Token = "0x600131A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E23194", Offset = "0x1E23194", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00005F5D File Offset: 0x0000415D
		[global::Cpp2ILInjected.Token(Token = "0x600131B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E234EC", Offset = "0x1E234EC", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00005F60 File Offset: 0x00004160
		[global::Cpp2ILInjected.Token(Token = "0x600131C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E23730", Offset = "0x1E23730", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00005F63 File Offset: 0x00004163
		[global::Cpp2ILInjected.Token(Token = "0x600131D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E23A88", Offset = "0x1E23A88", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndSend", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00005F66 File Offset: 0x00004166
		[global::Cpp2ILInjected.Token(Token = "0x600131E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E23CCC", Offset = "0x1E23CCC", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(SocketFlags),
			typeof(bool),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTask<>), Member = "AsTask", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00005F69 File Offset: 0x00004169
		[global::Cpp2ILInjected.Token(Token = "0x600131F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2430C", Offset = "0x1E2430C", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new object[]
		{
			typeof(Memory<byte>),
			typeof(SocketFlags),
			typeof(bool),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00005F6C File Offset: 0x0000416C
		[global::Cpp2ILInjected.Token(Token = "0x6001320")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2452C", Offset = "0x1E2452C", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new object[]
		{
			typeof(ReadOnlyMemory<byte>),
			typeof(SocketFlags),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTask), Member = "AsTask", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00005F6F File Offset: 0x0000416F
		[global::Cpp2ILInjected.Token(Token = "0x6001321")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E24B20", Offset = "0x1E24B20", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new object[]
		{
			typeof(ReadOnlyMemory<byte>),
			typeof(SocketFlags),
			typeof(CancellationToken)
		}, ReturnType = typeof(ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00005F72 File Offset: 0x00004172
		[global::Cpp2ILInjected.Token(Token = "0x6001322")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E24D3C", Offset = "0x1E24D3C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00005F75 File Offset: 0x00004175
		[global::Cpp2ILInjected.Token(Token = "0x6001323")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E24D40", Offset = "0x1E24D40", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00005F78 File Offset: 0x00004178
		[global::Cpp2ILInjected.Token(Token = "0x6001324")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E24DC8", Offset = "0x1E24DC8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00005F7B File Offset: 0x0000417B
		[global::Cpp2ILInjected.Token(Token = "0x6001325")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E21D14", Offset = "0x1E21D14", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "set_WriteTimeout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
		{
			typeof(SocketOptionLevel),
			typeof(SocketOptionName),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
		{
			throw null;
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00005F7E File Offset: 0x0000417E
		[global::Cpp2ILInjected.Token(Token = "0x1700046E")]
		internal Socket InternalSocket
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001326")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E24F48", Offset = "0x1E24F48", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsStream.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000BB5 RID: 2997
		[global::Cpp2ILInjected.Token(Token = "0x4000F89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Socket _streamSocket;

		// Token: 0x04000BB6 RID: 2998
		[global::Cpp2ILInjected.Token(Token = "0x4000F8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly bool _ownsSocket;

		// Token: 0x04000BB7 RID: 2999
		[global::Cpp2ILInjected.Token(Token = "0x4000F8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		private bool _readable;

		// Token: 0x04000BB8 RID: 3000
		[global::Cpp2ILInjected.Token(Token = "0x4000F8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		private bool _writeable;

		// Token: 0x04000BB9 RID: 3001
		[global::Cpp2ILInjected.Token(Token = "0x4000F8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int _closeTimeout;

		// Token: 0x04000BBA RID: 3002
		[global::Cpp2ILInjected.Token(Token = "0x4000F8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool _cleanedUp;

		// Token: 0x04000BBB RID: 3003
		[global::Cpp2ILInjected.Token(Token = "0x4000F8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int _currentReadTimeout;

		// Token: 0x04000BBC RID: 3004
		[global::Cpp2ILInjected.Token(Token = "0x4000F90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _currentWriteTimeout;
	}
}
