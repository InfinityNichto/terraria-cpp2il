using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000285")]
	internal abstract class WebConnectionStream : Stream
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60011C1")]
		protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);

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

		[global::Cpp2ILInjected.Token(Token = "0x60011C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1138C", Offset = "0x1E1138C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60011CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E11450", Offset = "0x1E11450", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new object[] { typeof(HttpWebResponse) }, ReturnType = typeof(ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void InternalClose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011CB")]
		protected abstract void Close_internal(ref bool disposed);

		[global::Cpp2ILInjected.Token(Token = "0x60011CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1145C", Offset = "0x1E1145C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E11470", Offset = "0x1E11470", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override long Seek(long a, SeekOrigin b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E114BC", Offset = "0x1E114BC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetLength(long a)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000DC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected bool closed;

		[global::Cpp2ILInjected.Token(Token = "0x4000DC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool disposed;

		[global::Cpp2ILInjected.Token(Token = "0x4000DC5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private object locker;

		[global::Cpp2ILInjected.Token(Token = "0x4000DC6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int read_timeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000DC7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int write_timeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000DC8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal bool IgnoreIOErrors;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DC9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly HttpWebRequest <Request>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DCA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly WebConnection <Connection>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DCB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly WebOperation <Operation>k__BackingField;
	}
}
