using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001B6 RID: 438
	[global::Cpp2ILInjected.Token(Token = "0x2000285")]
	internal abstract class WebConnectionStream : Stream
	{
		// Token: 0x06000FE3 RID: 4067 RVA: 0x00005BD0 File Offset: 0x00003DD0
		[global::Cpp2ILInjected.Token(Token = "0x60011B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E10688", Offset = "0x1E10688", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebConnection),
			typeof(WebOperation),
			typeof(Stream),
			typeof(WebConnectionTunnel)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = ".ctor", MemberParameters = new object[] { typeof(WebRequestStream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected WebConnectionStream(WebConnection cnc, WebOperation operation)
		{
			throw null;
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00005BD3 File Offset: 0x00003DD3
		[global::Cpp2ILInjected.Token(Token = "0x1700040B")]
		internal HttpWebRequest Request
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1073C", Offset = "0x1E1073C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00005BD6 File Offset: 0x00003DD6
		[global::Cpp2ILInjected.Token(Token = "0x1700040C")]
		internal WebConnection Connection
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E10744", Offset = "0x1E10744", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00005BD9 File Offset: 0x00003DD9
		[global::Cpp2ILInjected.Token(Token = "0x1700040D")]
		internal WebOperation Operation
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1074C", Offset = "0x1E1074C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00005BDC File Offset: 0x00003DDC
		[global::Cpp2ILInjected.Token(Token = "0x1700040E")]
		internal ServicePoint ServicePoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E10754", Offset = "0x1E10754", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new object[]
			{
				typeof(BufferOffsetSize),
				typeof(ref int),
				typeof(ref ReadState)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00005BDF File Offset: 0x00003DDF
		[global::Cpp2ILInjected.Token(Token = "0x1700040F")]
		public override bool CanTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E10760", Offset = "0x1E10760", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00005BE2 File Offset: 0x00003DE2
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x00005BE5 File Offset: 0x00003DE5
		[global::Cpp2ILInjected.Token(Token = "0x17000410")]
		public override int ReadTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E10768", Offset = "0x1E10768", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60011BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E10770", Offset = "0x1E10770", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00005BE8 File Offset: 0x00003DE8
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x00005BEB File Offset: 0x00003DEB
		[global::Cpp2ILInjected.Token(Token = "0x17000411")]
		public override int WriteTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E107D0", Offset = "0x1E107D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60011BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E107D8", Offset = "0x1E107D8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00005BEE File Offset: 0x00003DEE
		[global::Cpp2ILInjected.Token(Token = "0x60011C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E10838", Offset = "0x1E10838", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "EndRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "EndWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new object[]
		{
			typeof(WebExceptionStatus),
			typeof(Exception),
			typeof(string)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "FlattenException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected Exception GetException(Exception e)
		{
			throw null;
		}

		// Token: 0x06000FEE RID: 4078
		[global::Cpp2ILInjected.Token(Token = "0x60011C1")]
		protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);

		// Token: 0x06000FEF RID: 4079 RVA: 0x00005BF1 File Offset: 0x00003DF1
		[global::Cpp2ILInjected.Token(Token = "0x60011C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1099C", Offset = "0x1E1099C", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "get_Result", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00005BF4 File Offset: 0x00003DF4
		[global::Cpp2ILInjected.Token(Token = "0x60011C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E10C24", Offset = "0x1E10C24", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state)
		{
			throw null;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00005BF7 File Offset: 0x00003DF7
		[global::Cpp2ILInjected.Token(Token = "0x60011C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E10DE0", Offset = "0x1E10DE0", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override int EndRead(IAsyncResult r)
		{
			throw null;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00005BFA File Offset: 0x00003DFA
		[global::Cpp2ILInjected.Token(Token = "0x60011C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E10F00", Offset = "0x1E10F00", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state)
		{
			throw null;
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00005BFD File Offset: 0x00003DFD
		[global::Cpp2ILInjected.Token(Token = "0x60011C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E110BC", Offset = "0x1E110BC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override void EndWrite(IAsyncResult r)
		{
			throw null;
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00005C00 File Offset: 0x00003E00
		[global::Cpp2ILInjected.Token(Token = "0x60011C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E111B0", Offset = "0x1E111B0", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00005C03 File Offset: 0x00003E03
		[global::Cpp2ILInjected.Token(Token = "0x60011C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1138C", Offset = "0x1E1138C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00005C06 File Offset: 0x00003E06
		[global::Cpp2ILInjected.Token(Token = "0x60011C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E11390", Offset = "0x1E11390", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromCancellation", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00005C09 File Offset: 0x00003E09
		[global::Cpp2ILInjected.Token(Token = "0x60011CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E11450", Offset = "0x1E11450", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new object[] { typeof(HttpWebResponse) }, ReturnType = typeof(ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void InternalClose()
		{
			throw null;
		}

		// Token: 0x06000FF8 RID: 4088
		[global::Cpp2ILInjected.Token(Token = "0x60011CB")]
		protected abstract void Close_internal(ref bool disposed);

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00005C0C File Offset: 0x00003E0C
		[global::Cpp2ILInjected.Token(Token = "0x60011CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1145C", Offset = "0x1E1145C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00005C0F File Offset: 0x00003E0F
		[global::Cpp2ILInjected.Token(Token = "0x60011CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E11470", Offset = "0x1E11470", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override long Seek(long a, SeekOrigin b)
		{
			throw null;
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00005C12 File Offset: 0x00003E12
		[global::Cpp2ILInjected.Token(Token = "0x60011CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E114BC", Offset = "0x1E114BC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetLength(long a)
		{
			throw null;
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00005C15 File Offset: 0x00003E15
		[global::Cpp2ILInjected.Token(Token = "0x17000412")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11508", Offset = "0x1E11508", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00005C18 File Offset: 0x00003E18
		[global::Cpp2ILInjected.Token(Token = "0x17000413")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11510", Offset = "0x1E11510", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00005C1B File Offset: 0x00003E1B
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00005C1E File Offset: 0x00003E1E
		[global::Cpp2ILInjected.Token(Token = "0x17000414")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1155C", Offset = "0x1E1155C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60011D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E115A8", Offset = "0x1E115A8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000A7C RID: 2684
		[global::Cpp2ILInjected.Token(Token = "0x4000DC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected bool closed;

		// Token: 0x04000A7D RID: 2685
		[global::Cpp2ILInjected.Token(Token = "0x4000DC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool disposed;

		// Token: 0x04000A7E RID: 2686
		[global::Cpp2ILInjected.Token(Token = "0x4000DC5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private object locker;

		// Token: 0x04000A7F RID: 2687
		[global::Cpp2ILInjected.Token(Token = "0x4000DC6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int read_timeout;

		// Token: 0x04000A80 RID: 2688
		[global::Cpp2ILInjected.Token(Token = "0x4000DC7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int write_timeout;

		// Token: 0x04000A81 RID: 2689
		[global::Cpp2ILInjected.Token(Token = "0x4000DC8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal bool IgnoreIOErrors;

		// Token: 0x04000A82 RID: 2690
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DC9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly HttpWebRequest <Request>k__BackingField;

		// Token: 0x04000A83 RID: 2691
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DCA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly WebConnection <Connection>k__BackingField;

		// Token: 0x04000A84 RID: 2692
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DCB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly WebOperation <Operation>k__BackingField;
	}
}
