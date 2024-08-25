using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x2000557")]
	[global::System.Serializable]
	public abstract class Stream : global::System.MarshalByRefObject, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60028A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA52A4", Offset = "0x1BA52A4", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "System.Func`1<T>" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal global::System.Threading.SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005E0")]
		public abstract bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A4")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005E1")]
		public abstract bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A5")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005E2")]
		public virtual bool CanTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA53A0", Offset = "0x1BA53A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005E3")]
		public abstract bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A7")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005E4")]
		public abstract long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A8")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005E5")]
		public abstract long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A9")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60028AA")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005E6")]
		public virtual int ReadTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA53A8", Offset = "0x1BA53A8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60028AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA53F4", Offset = "0x1BA53F4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005E7")]
		public virtual int WriteTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA5440", Offset = "0x1BA5440", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60028AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA548C", Offset = "0x1BA548C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA54D8", Offset = "0x1BA54D8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "DecompressData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "DecompressData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile_OldMobile", Member = "ReadAllBytes", MemberParameters = new object[] { typeof(Stream) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "GetCopyBufferSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(Stream destination)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9823C", Offset = "0x1B9823C", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public virtual void CopyTo(Stream destination, int bufferSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5510", Offset = "0x1BA5510", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int GetCopyBufferSize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA55D4", Offset = "0x1BA55D4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TlsStream", Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.OffsetStream", Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Crc.CrcCalculatorStream", Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5644", Offset = "0x1BA5644", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "InternalSaveMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "ProcessHandshake", MemberParameters = new object[]
		{
			"Mono.Net.Security.AsyncOperationStatus",
			typeof(bool)
		}, ReturnType = "Mono.Net.Security.AsyncOperationStatus")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsStream", Member = "CloseSslStream", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection", Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebReadStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<>c__DisplayClass41_0", Member = "<ProcessRead>b__1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream", Member = "Close_internal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Close", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Http.DelegatingStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9EEE0", Offset = "0x1B9EEE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.TailStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpDataStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkStreamWrapper", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebReadStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.AuthenticatedStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Http.DelegatingStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlRegisteredNonCachedStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipSegmentedStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.BZip2.BZip2InputStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.DeflateStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.GZipStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028B5")]
		public abstract void Flush();

		[global::Cpp2ILInjected.Token(Token = "0x60028B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5654", Offset = "0x1BA5654", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskFactory), Member = "StartNew", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(global::System.Threading.CancellationToken),
			typeof(global::System.Threading.Tasks.TaskCreationOptions),
			typeof(global::System.Threading.Tasks.TaskScheduler)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public virtual global::System.Threading.Tasks.Task FlushAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5814", Offset = "0x1BA5814", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		public virtual global::System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5834", Offset = "0x1BA5834", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "EnsureAsyncActiveSemaphoreInitialized", ReturnType = typeof(global::System.Threading.SemaphoreSlim))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "Wait", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.ReadWriteTask), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(global::System.Func<object, int>),
			typeof(object),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "RunReadWriteTaskWhenReady", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(Stream.ReadWriteTask)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "RunReadWriteTask", MemberParameters = new object[] { typeof(Stream.ReadWriteTask) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetReadNotSupported", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal global::System.IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5C50", Offset = "0x1BA5C50", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<int>), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter<int>), Member = "GetResult", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual int EndRead(global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5E1C", Offset = "0x1BA5E1C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginRead", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_None", ReturnType = typeof(global::System.Threading.CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public global::System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5EB0", Offset = "0x1BA5EB0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "BeginEndReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual global::System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA611C", Offset = "0x1BA611C", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "ReadAsync", MemberParameters = new object[]
		{
			"System.Memory`1<Byte>",
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "ReadAsyncMemory", MemberParameters = new object[]
		{
			"System.Memory`1<Byte>",
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Memory<>), Member = "op_Implicit", MemberParameters = new object[] { "System.Memory`1<T>" }, ReturnType = "System.ReadOnlyMemory`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Memory<>), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "<ReadAsync>g__FinishReadAsync|44_0", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task<int>),
			typeof(byte[]),
			typeof(global::System.Memory<byte>)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual global::System.Threading.Tasks.ValueTask<int> ReadAsync(global::System.Memory<byte> buffer, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5F6C", Offset = "0x1BA5F6C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object, Stream.ReadWriteParameters, object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object, object, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskFactory<>), Member = "FromAsyncTrim", MemberTypeParameters = new object[] { "TInstance", "TArgs" }, MemberParameters = new object[] { "TInstance", "TArgs", "System.Func`5<TInstance, TArgs, AsyncCallback, Object, IAsyncResult>", "System.Func`3<TInstance, IAsyncResult, TResult>" }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private global::System.Threading.Tasks.Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA647C", Offset = "0x1BA647C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		public virtual global::System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA649C", Offset = "0x1BA649C", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "EnsureAsyncActiveSemaphoreInitialized", ReturnType = typeof(global::System.Threading.SemaphoreSlim))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "Wait", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.ReadWriteTask), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(global::System.Func<object, int>),
			typeof(object),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "RunReadWriteTaskWhenReady", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(Stream.ReadWriteTask)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "RunReadWriteTask", MemberParameters = new object[] { typeof(Stream.ReadWriteTask) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal global::System.IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5A20", Offset = "0x1BA5A20", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "ContinueWith", MemberParameters = new object[]
		{
			typeof(global::System.Action<global::System.Threading.Tasks.Task, object>),
			typeof(object),
			typeof(global::System.Threading.CancellationToken),
			typeof(global::System.Threading.Tasks.TaskContinuationOptions),
			typeof(global::System.Threading.Tasks.TaskScheduler)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void RunReadWriteTaskWhenReady(global::System.Threading.Tasks.Task asyncWaiter, Stream.ReadWriteTask readWriteTask)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5BA4", Offset = "0x1BA5BA4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream.<>c), Member = "<RunReadWriteTaskWhenReady>b__49_0", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "ScheduleAndStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6688", Offset = "0x1BA6688", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream.<>c), Member = "<BeginReadInternal>b__40_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream.<>c), Member = "<BeginWriteInternal>b__48_0", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		private void FinishTrackingAsyncOperation()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA669C", Offset = "0x1BA669C", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<int>), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter<int>), Member = "GetResult", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual void EndWrite(global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA685C", Offset = "0x1BA685C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<InnerWrite>d__67", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = "Write", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginWrite", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_None", ReturnType = typeof(global::System.Threading.CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public global::System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA68F0", Offset = "0x1BA68F0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "BeginEndWriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual global::System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6B48", Offset = "0x1BA6B48", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "WriteAsync", MemberParameters = new object[]
		{
			"System.ReadOnlyMemory`1<Byte>",
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "WriteAsyncMemory", MemberParameters = new object[]
		{
			"System.ReadOnlyMemory`1<Byte>",
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlyMemory<>), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "FinishWriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(byte[])
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual global::System.Threading.Tasks.ValueTask WriteAsync(global::System.ReadOnlyMemory<byte> buffer, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6DB8", Offset = "0x1BA6DB8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlyMemory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(Stream.<FinishWriteAsync>d__57) }, MemberParameters = new object[] { typeof(ref Stream.<FinishWriteAsync>d__57) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private global::System.Threading.Tasks.Task FinishWriteAsync(global::System.Threading.Tasks.Task writeTask, byte[] localBuffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6998", Offset = "0x1BA6998", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object, Stream.ReadWriteParameters, object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object, object, global::System.Threading.Tasks.VoidTaskResult>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.TaskFactory<global::System.Threading.Tasks.VoidTaskResult>), Member = "FromAsyncTrim", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(Stream.ReadWriteParameters)
		}, MemberParameters = new object[]
		{
			typeof(object),
			typeof(Stream.ReadWriteParameters),
			typeof(global::System.Func<object, Stream.ReadWriteParameters, global::System.AsyncCallback, object, global::System.IAsyncResult>),
			typeof(global::System.Func<object, global::System.IAsyncResult, global::System.Threading.Tasks.VoidTaskResult>)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private global::System.Threading.Tasks.Task BeginEndWriteAsync(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028C9")]
		public abstract long Seek(long offset, SeekOrigin origin);

		[global::Cpp2ILInjected.Token(Token = "0x60028CA")]
		public abstract void SetLength(long value);

		[global::Cpp2ILInjected.Token(Token = "0x60028CB")]
		public abstract int Read(byte[] buffer, int offset, int count);

		[global::Cpp2ILInjected.Token(Token = "0x60028CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B975E4", Offset = "0x1B975E4", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "Read", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Read", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Read", MemberParameters = new object[] { "System.Span`1<Byte>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Read", MemberParameters = new object[] { "System.Span`1<Byte>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public virtual int Read(global::System.Span<byte> buffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6E98", Offset = "0x1BA6E98", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual int ReadByte()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028CE")]
		public abstract void Write(byte[] buffer, int offset, int count);

		[global::Cpp2ILInjected.Token(Token = "0x60028CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B98BA0", Offset = "0x1B98BA0", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Write", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Write", MemberParameters = new object[] { "System.ReadOnlySpan`1<Byte>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Write", MemberParameters = new object[] { "System.ReadOnlySpan`1<Byte>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual void Write(global::System.ReadOnlySpan<byte> buffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6F18", Offset = "0x1BA6F18", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void WriteByte(byte value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6F90", Offset = "0x1BA6F90", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream.NullStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.SynchronousAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.SynchronousAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal global::System.IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA70F4", Offset = "0x1BA70F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream.NullStream), Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.SynchronousAsyncResult), Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		internal static int BlockingEndRead(global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA70FC", Offset = "0x1BA70FC", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream.NullStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.SynchronousAsyncResult), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.SynchronousAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal global::System.IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA7258", Offset = "0x1BA7258", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream.NullStream), Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.SynchronousAsyncResult), Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		internal static void BlockingEndWrite(global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6474", Offset = "0x1BA6474", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool HasOverriddenBeginEndRead()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6E90", Offset = "0x1BA6E90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool HasOverriddenBeginEndWrite()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60028D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B968A0", Offset = "0x1B968A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Security.Cryptography.ICryptoTransform),
			typeof(global::System.Security.Cryptography.CryptoStreamMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.TailStream), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream.NullStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(FileAccess),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(bool),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DelegatedStream", Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpDataStream", Member = ".ctor", MemberParameters = new object[] { "System.Net.Sockets.NetworkStream", "System.Net.FtpWebRequest", "System.Net.TriState" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkStreamWrapper", Member = ".ctor", MemberParameters = new object[] { "System.Net.Sockets.TcpClient" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.RequestStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ResponseStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			"System.Net.HttpListenerResponse",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionStream", Member = ".ctor", MemberParameters = new object[] { "System.Net.WebConnection", "System.Net.WebOperation" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebReadStream", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.WebOperation",
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.Sockets.Socket",
			typeof(FileAccess),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.AuthenticatedStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Http.DelegatingStream", Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.ChunkedMemoryStream", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.GZipStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			"System.IO.Compression.CompressionMode",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			"System.IO.Compression.CompressionMode",
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlRegisteredNonCachedStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			"System.Xml.XmlDownloadManager",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.OffsetStream", Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.CountingStream", Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipCipherStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			"Ionic.Zip.ZipCrypto",
			"Ionic.Zip.CryptoMode"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipInputStream", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipInputStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutputStream", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutputStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipSegmentedStream", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.BZip2.BZip2InputStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.BZip2.BZip2OutputStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.DeflateStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			"Ionic.Zlib.CompressionMode",
			"Ionic.Zlib.CompressionLevel",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.GZipStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			"Ionic.Zlib.CompressionMode",
			"Ionic.Zlib.CompressionLevel",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibBaseStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			"Ionic.Zlib.CompressionMode",
			"Ionic.Zlib.CompressionLevel",
			"Ionic.Zlib.ZlibStreamFlavor",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			"Ionic.Zlib.CompressionMode",
			"Ionic.Zlib.CompressionLevel",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Crc.CrcCalculatorStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(long),
			typeof(Stream),
			"Ionic.Crc.CRC32"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		protected Stream()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60028D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA7260", Offset = "0x1BA7260", Length = "0x1070")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.NullStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static Stream()
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60028D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6374", Offset = "0x1BA6374", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique) }, MemberParameters = new object[] { typeof(ref Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<>), Member = "get_Task", ReturnType = "System.Threading.Tasks.ValueTask`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static global::System.Threading.Tasks.ValueTask<int> Method_Internal_Static_ValueTask_1_Int32_Task_1_Int32_Byte_Memory_1_Byte_0(global::System.Threading.Tasks.Task<int> readTask, byte[] localBuffer, global::System.Memory<byte> localDestination)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40015F2")]
		public static readonly Stream Null;

		[global::Cpp2ILInjected.Token(Token = "0x40015F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[global::System.NonSerialized]
		private Stream.ReadWriteTask _activeReadWriteTask;

		[global::Cpp2ILInjected.Token(Token = "0x40015F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private global::System.Threading.SemaphoreSlim _asyncActiveSemaphore;

		[global::Cpp2ILInjected.Token(Token = "0x2000558")]
		private struct ReadWriteParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x40015F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal byte[] Buffer;

			[global::Cpp2ILInjected.Token(Token = "0x40015F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int Offset;

			[global::Cpp2ILInjected.Token(Token = "0x40015F7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal int Count;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000559")]
		private sealed class ReadWriteTask : global::System.Threading.Tasks.Task<int>, global::System.Threading.Tasks.ITaskCompletionAction
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC478C", Offset = "0x1BC478C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void ClearBeginState()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4794", Offset = "0x1BC4794", Length = "0x144")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_None", ReturnType = typeof(global::System.Threading.CancellationToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<int>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Func<object, int>),
				typeof(object),
				typeof(global::System.Threading.CancellationToken),
				typeof(global::System.Threading.Tasks.TaskCreationOptions)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "Capture", ReturnType = typeof(global::System.Threading.ExecutionContext))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "AddCompletionAction", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.ITaskCompletionAction) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public ReadWriteTask(bool isRead, bool apm, global::System.Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, global::System.AsyncCallback callback)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC48D8", Offset = "0x1BC48D8", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private static void InvokeAsyncCallback(object completedTask)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC494C", Offset = "0x1BC494C", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ContextCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "RunInternal", MemberParameters = new object[]
			{
				typeof(global::System.Threading.ExecutionContext),
				typeof(global::System.Threading.ContextCallback),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private void System.Threading.Tasks.ITaskCompletionAction.Invoke(global::System.Threading.Tasks.Task completingTask)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005E8")]
			private bool System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode
			{
				[global::Cpp2ILInjected.Token(Token = "0x60028DE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC4A60", Offset = "0x1BC4A60", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x40015F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
			internal readonly bool _isRead;

			[global::Cpp2ILInjected.Token(Token = "0x40015F9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x55")]
			internal readonly bool _apm;

			[global::Cpp2ILInjected.Token(Token = "0x40015FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal Stream _stream;

			[global::Cpp2ILInjected.Token(Token = "0x40015FB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			internal byte[] _buffer;

			[global::Cpp2ILInjected.Token(Token = "0x40015FC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			internal readonly int _offset;

			[global::Cpp2ILInjected.Token(Token = "0x40015FD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
			internal readonly int _count;

			[global::Cpp2ILInjected.Token(Token = "0x40015FE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private global::System.AsyncCallback _callback;

			[global::Cpp2ILInjected.Token(Token = "0x40015FF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private global::System.Threading.ExecutionContext _context;

			[global::Cpp2ILInjected.Token(Token = "0x4001600")]
			private static global::System.Threading.ContextCallback s_invokeAsyncCallback;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200055A")]
		private sealed class NullStream : Stream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4A68", Offset = "0x1BC4A68", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal NullStream()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005E9")]
			public override bool CanRead
			{
				[global::Cpp2ILInjected.Token(Token = "0x60028E0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC4AC0", Offset = "0x1BC4AC0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005EA")]
			public override bool CanWrite
			{
				[global::Cpp2ILInjected.Token(Token = "0x60028E1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC4AC8", Offset = "0x1BC4AC8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005EB")]
			public override bool CanSeek
			{
				[global::Cpp2ILInjected.Token(Token = "0x60028E2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC4AD0", Offset = "0x1BC4AD0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005EC")]
			public override long Length
			{
				[global::Cpp2ILInjected.Token(Token = "0x60028E3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC4AD8", Offset = "0x1BC4AD8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005ED")]
			public override long Position
			{
				[global::Cpp2ILInjected.Token(Token = "0x60028E4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC4AE0", Offset = "0x1BC4AE0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x60028E5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC4AE8", Offset = "0x1BC4AE8", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4AEC", Offset = "0x1BC4AEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(Stream),
				typeof(int)
			}, ReturnType = typeof(void))]
			public override void CopyTo(Stream destination, int bufferSize)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4AF4", Offset = "0x1BC4AF4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected override void Dispose(bool disposing)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4AF8", Offset = "0x1BC4AF8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Flush()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4AFC", Offset = "0x1BC4AFC", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override global::System.Threading.Tasks.Task FlushAsync(global::System.Threading.CancellationToken cancellationToken)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4BBC", Offset = "0x1BC4BBC", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "BlockingBeginRead", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetReadNotSupported", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override global::System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4C4C", Offset = "0x1BC4C4C", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "BlockingEndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public override int EndRead(global::System.IAsyncResult asyncResult)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4CF0", Offset = "0x1BC4CF0", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "BlockingBeginWrite", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override global::System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4D80", Offset = "0x1BC4D80", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "BlockingEndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public override void EndWrite(global::System.IAsyncResult asyncResult)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4E24", Offset = "0x1BC4E24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int Read(byte[] buffer, int offset, int count)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4E2C", Offset = "0x1BC4E2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int Read(global::System.Span<byte> buffer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4E34", Offset = "0x1BC4E34", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override global::System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4E8C", Offset = "0x1BC4E8C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override global::System.Threading.Tasks.ValueTask<int> ReadAsync(global::System.Memory<byte> buffer, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4EC0", Offset = "0x1BC4EC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int ReadByte()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4EC8", Offset = "0x1BC4EC8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Write(byte[] buffer, int offset, int count)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4ECC", Offset = "0x1BC4ECC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Write(global::System.ReadOnlySpan<byte> buffer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4ED0", Offset = "0x1BC4ED0", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override global::System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4F90", Offset = "0x1BC4F90", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override global::System.Threading.Tasks.ValueTask WriteAsync(global::System.ReadOnlyMemory<byte> buffer, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5024", Offset = "0x1BC5024", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void WriteByte(byte value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5028", Offset = "0x1BC5028", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override long Seek(long offset, SeekOrigin origin)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5030", Offset = "0x1BC5030", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void SetLength(long length)
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60028FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5034", Offset = "0x1BC5034", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task[]), Member = "FromResult", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(int) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static NullStream()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001601")]
			private static readonly global::System.Threading.Tasks.Task<int> s_zeroTask;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200055B")]
		private sealed class SynchronousAsyncResult : global::System.IAsyncResult
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC50C0", Offset = "0x1BC50C0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BlockingBeginRead", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal SynchronousAsyncResult(int bytesRead, object asyncStateObject)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC50F0", Offset = "0x1BC50F0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BlockingBeginWrite", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal SynchronousAsyncResult(object asyncStateObject)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60028FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5120", Offset = "0x1BC5120", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BlockingBeginRead", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BlockingBeginWrite", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo))]
			internal SynchronousAsyncResult(global::System.Exception ex, object asyncStateObject, bool isWrite)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005EE")]
			public bool IsCompleted
			{
				[global::Cpp2ILInjected.Token(Token = "0x60028FE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC516C", Offset = "0x1BC516C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005EF")]
			public global::System.Threading.WaitHandle AsyncWaitHandle
			{
				[global::Cpp2ILInjected.Token(Token = "0x60028FF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC5174", Offset = "0x1BC5174", Length = "0xFC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(global::System.IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "System.Func`1<T>" }, ReturnType = "T")]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005F0")]
			public object AsyncState
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002900")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC5270", Offset = "0x1BC5270", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005F1")]
			public bool CompletedSynchronously
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002901")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC5278", Offset = "0x1BC5278", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002902")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5280", Offset = "0x1BC5280", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			internal void ThrowIfError()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002903")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5294", Offset = "0x1BC5294", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BlockingEndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal static int EndRead(global::System.IAsyncResult asyncResult)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002904")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC537C", Offset = "0x1BC537C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream), Member = "BlockingEndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal static void EndWrite(global::System.IAsyncResult asyncResult)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001602")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly object _stateObject;

			[global::Cpp2ILInjected.Token(Token = "0x4001603")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly bool _isWrite;

			[global::Cpp2ILInjected.Token(Token = "0x4001604")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private global::System.Threading.ManualResetEvent _waitHandle;

			[global::Cpp2ILInjected.Token(Token = "0x4001605")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private global::System.Runtime.ExceptionServices.ExceptionDispatchInfo _exceptionInfo;

			[global::Cpp2ILInjected.Token(Token = "0x4001606")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private bool _endXxxCalled;

			[global::Cpp2ILInjected.Token(Token = "0x4001607")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			private int _bytesRead;

			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200055C")]
			[global::System.Serializable]
			private sealed class <>c
			{
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x6002905")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC5468", Offset = "0x1BC5468", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6002906")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC54C4", Offset = "0x1BC54C4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6002907")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC54CC", Offset = "0x1BC54CC", Length = "0x58")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal global::System.Threading.ManualResetEvent <get_AsyncWaitHandle>b__12_0()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4001608")]
				public static readonly Stream.SynchronousAsyncResult.<>c <>9;

				[global::Cpp2ILInjected.Token(Token = "0x4001609")]
				public static global::System.Func<global::System.Threading.ManualResetEvent> <>9__12_0;
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200055D")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6002908")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5524", Offset = "0x1BC5524", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002909")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5580", Offset = "0x1BC5580", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600290A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5588", Offset = "0x1BC5588", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SemaphoreSlim), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal global::System.Threading.SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600290B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC55E4", Offset = "0x1BC55E4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <FlushAsync>b__37_0(object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600290C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5664", Offset = "0x1BC5664", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "FinishTrackingAsyncOperation", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal int <BeginReadInternal>b__40_0(object <p0>)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600290D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC57C4", Offset = "0x1BC57C4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal global::System.IAsyncResult <BeginEndReadAsync>b__45_0(Stream stream, Stream.ReadWriteParameters args, global::System.AsyncCallback callback, object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600290E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC57E8", Offset = "0x1BC57E8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal int <BeginEndReadAsync>b__45_1(Stream stream, global::System.IAsyncResult asyncResult)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600290F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5804", Offset = "0x1BC5804", Length = "0x158")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "FinishTrackingAsyncOperation", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal int <BeginWriteInternal>b__48_0(object <p0>)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002910")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC595C", Offset = "0x1BC595C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "RunReadWriteTask", MemberParameters = new object[] { "System.IO.Stream.ReadWriteTask" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <RunReadWriteTaskWhenReady>b__49_0(global::System.Threading.Tasks.Task t, object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002911")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC59C4", Offset = "0x1BC59C4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal global::System.IAsyncResult <BeginEndWriteAsync>b__58_0(Stream stream, Stream.ReadWriteParameters args, global::System.AsyncCallback callback, object state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002912")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC59E8", Offset = "0x1BC59E8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal global::System.Threading.Tasks.VoidTaskResult <BeginEndWriteAsync>b__58_1(Stream stream, global::System.IAsyncResult asyncResult)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400160A")]
			public static readonly Stream.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x400160B")]
			public static global::System.Func<global::System.Threading.SemaphoreSlim> <>9__4_0;

			[global::Cpp2ILInjected.Token(Token = "0x400160C")]
			public static global::System.Action<object> <>9__37_0;

			[global::Cpp2ILInjected.Token(Token = "0x400160D")]
			public static global::System.Func<object, int> <>9__40_0;

			[global::Cpp2ILInjected.Token(Token = "0x400160E")]
			public static global::System.Func<Stream, Stream.ReadWriteParameters, global::System.AsyncCallback, object, global::System.IAsyncResult> <>9__45_0;

			[global::Cpp2ILInjected.Token(Token = "0x400160F")]
			public static global::System.Func<Stream, global::System.IAsyncResult, int> <>9__45_1;

			[global::Cpp2ILInjected.Token(Token = "0x4001610")]
			public static global::System.Func<object, int> <>9__48_0;

			[global::Cpp2ILInjected.Token(Token = "0x4001611")]
			public static global::System.Action<global::System.Threading.Tasks.Task, object> <>9__49_0;

			[global::Cpp2ILInjected.Token(Token = "0x4001612")]
			public static global::System.Func<Stream, Stream.ReadWriteParameters, global::System.AsyncCallback, object, global::System.IAsyncResult> <>9__58_0;

			[global::Cpp2ILInjected.Token(Token = "0x4001613")]
			public static global::System.Func<Stream, global::System.IAsyncResult, global::System.Threading.Tasks.VoidTaskResult> <>9__58_1;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200055E")]
		[StructLayout(3)]
		private struct <FinishWriteAsync>d__57 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002913")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5A14", Offset = "0x1BC5A14", Length = "0x200")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(Stream.<FinishWriteAsync>d__57)
			}, MemberParameters = new object[]
			{
				typeof(ref global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref Stream.<FinishWriteAsync>d__57)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			private void MoveNext()
			{
				throw null;
			}

			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002914")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5C14", Offset = "0x1BC5C14", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001614")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4001615")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4001616")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public global::System.Threading.Tasks.Task writeTask;

			[global::Cpp2ILInjected.Token(Token = "0x4001617")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public byte[] localBuffer;

			[global::Cpp2ILInjected.Token(Token = "0x4001618")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200055F")]
		[StructLayout(3)]
		private struct ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002915")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5C20", Offset = "0x1BC5C20", Length = "0x388")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[] { "TAwaiter", "TStateMachine" }, MemberParameters = new object[] { "TAwaiter&", "TStateMachine&" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<>), Member = "SetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<>), Member = "SetException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
			private void MoveNext()
			{
				throw null;
			}

			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002916")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5FA8", Offset = "0x1BC5FA8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001619")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x400161A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<int> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x400161B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public global::System.Threading.Tasks.Task<int> readTask;

			[global::Cpp2ILInjected.Token(Token = "0x400161C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public byte[] localBuffer;

			[global::Cpp2ILInjected.Token(Token = "0x400161D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public global::System.Memory<byte> localDestination;

			[global::Cpp2ILInjected.Token(Token = "0x400161E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
