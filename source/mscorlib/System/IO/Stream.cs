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
	// Token: 0x0200048C RID: 1164
	[global::Cpp2ILInjected.Token(Token = "0x2000557")]
	[global::System.Serializable]
	public abstract class Stream : global::System.MarshalByRefObject, global::System.IDisposable
	{
		// Token: 0x060025CF RID: 9679 RVA: 0x0001AE76 File Offset: 0x00019076
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

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060025D0 RID: 9680
		[global::Cpp2ILInjected.Token(Token = "0x170005E0")]
		public abstract bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A4")]
			get;
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060025D1 RID: 9681
		[global::Cpp2ILInjected.Token(Token = "0x170005E1")]
		public abstract bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A5")]
			get;
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x0001AE79 File Offset: 0x00019079
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

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060025D3 RID: 9683
		[global::Cpp2ILInjected.Token(Token = "0x170005E3")]
		public abstract bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A7")]
			get;
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060025D4 RID: 9684
		[global::Cpp2ILInjected.Token(Token = "0x170005E4")]
		public abstract long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A8")]
			get;
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060025D5 RID: 9685
		// (set) Token: 0x060025D6 RID: 9686
		[global::Cpp2ILInjected.Token(Token = "0x170005E5")]
		public abstract long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A9")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60028AA")]
			set;
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x0001AE7C File Offset: 0x0001907C
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x0001AE7F File Offset: 0x0001907F
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x0001AE82 File Offset: 0x00019082
		// (set) Token: 0x060025DA RID: 9690 RVA: 0x0001AE85 File Offset: 0x00019085
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

		// Token: 0x060025DB RID: 9691 RVA: 0x0001AE88 File Offset: 0x00019088
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

		// Token: 0x060025DC RID: 9692 RVA: 0x0001AE8B File Offset: 0x0001908B
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

		// Token: 0x060025DD RID: 9693 RVA: 0x0001AE8E File Offset: 0x0001908E
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

		// Token: 0x060025DE RID: 9694 RVA: 0x0001AE91 File Offset: 0x00019091
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

		// Token: 0x060025DF RID: 9695 RVA: 0x0001AE94 File Offset: 0x00019094
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

		// Token: 0x060025E0 RID: 9696 RVA: 0x0001AE97 File Offset: 0x00019097
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

		// Token: 0x060025E1 RID: 9697
		[global::Cpp2ILInjected.Token(Token = "0x60028B5")]
		public abstract void Flush();

		// Token: 0x060025E2 RID: 9698 RVA: 0x0001AE9A File Offset: 0x0001909A
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

		// Token: 0x060025E3 RID: 9699 RVA: 0x0001AE9D File Offset: 0x0001909D
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

		// Token: 0x060025E4 RID: 9700 RVA: 0x0001AEA0 File Offset: 0x000190A0
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

		// Token: 0x060025E5 RID: 9701 RVA: 0x0001AEA3 File Offset: 0x000190A3
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

		// Token: 0x060025E6 RID: 9702 RVA: 0x0001AEA6 File Offset: 0x000190A6
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

		// Token: 0x060025E7 RID: 9703 RVA: 0x0001AEA9 File Offset: 0x000190A9
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

		// Token: 0x060025E8 RID: 9704 RVA: 0x0001AEAC File Offset: 0x000190AC
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

		// Token: 0x060025E9 RID: 9705 RVA: 0x0001AEAF File Offset: 0x000190AF
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

		// Token: 0x060025EA RID: 9706 RVA: 0x0001AEB2 File Offset: 0x000190B2
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

		// Token: 0x060025EB RID: 9707 RVA: 0x0001AEB5 File Offset: 0x000190B5
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

		// Token: 0x060025EC RID: 9708 RVA: 0x0001AEB8 File Offset: 0x000190B8
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

		// Token: 0x060025ED RID: 9709 RVA: 0x0001AEBB File Offset: 0x000190BB
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

		// Token: 0x060025EE RID: 9710 RVA: 0x0001AEBE File Offset: 0x000190BE
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

		// Token: 0x060025EF RID: 9711 RVA: 0x0001AEC1 File Offset: 0x000190C1
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

		// Token: 0x060025F0 RID: 9712 RVA: 0x0001AEC4 File Offset: 0x000190C4
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

		// Token: 0x060025F1 RID: 9713 RVA: 0x0001AEC7 File Offset: 0x000190C7
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

		// Token: 0x060025F2 RID: 9714 RVA: 0x0001AECA File Offset: 0x000190CA
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

		// Token: 0x060025F3 RID: 9715 RVA: 0x0001AECD File Offset: 0x000190CD
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

		// Token: 0x060025F4 RID: 9716 RVA: 0x0001AED0 File Offset: 0x000190D0
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

		// Token: 0x060025F5 RID: 9717
		[global::Cpp2ILInjected.Token(Token = "0x60028C9")]
		public abstract long Seek(long offset, SeekOrigin origin);

		// Token: 0x060025F6 RID: 9718
		[global::Cpp2ILInjected.Token(Token = "0x60028CA")]
		public abstract void SetLength(long value);

		// Token: 0x060025F7 RID: 9719
		[global::Cpp2ILInjected.Token(Token = "0x60028CB")]
		public abstract int Read(byte[] buffer, int offset, int count);

		// Token: 0x060025F8 RID: 9720 RVA: 0x0001AED3 File Offset: 0x000190D3
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

		// Token: 0x060025F9 RID: 9721 RVA: 0x0001AED6 File Offset: 0x000190D6
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

		// Token: 0x060025FA RID: 9722
		[global::Cpp2ILInjected.Token(Token = "0x60028CE")]
		public abstract void Write(byte[] buffer, int offset, int count);

		// Token: 0x060025FB RID: 9723 RVA: 0x0001AED9 File Offset: 0x000190D9
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

		// Token: 0x060025FC RID: 9724 RVA: 0x0001AEDC File Offset: 0x000190DC
		[global::Cpp2ILInjected.Token(Token = "0x60028D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6F18", Offset = "0x1BA6F18", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void WriteByte(byte value)
		{
			throw null;
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x0001AEDF File Offset: 0x000190DF
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

		// Token: 0x060025FE RID: 9726 RVA: 0x0001AEE2 File Offset: 0x000190E2
		[global::Cpp2ILInjected.Token(Token = "0x60028D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA70F4", Offset = "0x1BA70F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream.NullStream), Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.SynchronousAsyncResult), Member = "EndRead", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(int))]
		internal static int BlockingEndRead(global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x0001AEE5 File Offset: 0x000190E5
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

		// Token: 0x06002600 RID: 9728 RVA: 0x0001AEE8 File Offset: 0x000190E8
		[global::Cpp2ILInjected.Token(Token = "0x60028D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA7258", Offset = "0x1BA7258", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stream.NullStream), Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream.SynchronousAsyncResult), Member = "EndWrite", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		internal static void BlockingEndWrite(global::System.IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x0001AEEB File Offset: 0x000190EB
		[global::Cpp2ILInjected.Token(Token = "0x60028D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6474", Offset = "0x1BA6474", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool HasOverriddenBeginEndRead()
		{
			throw null;
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x0001AEEE File Offset: 0x000190EE
		[global::Cpp2ILInjected.Token(Token = "0x60028D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA6E90", Offset = "0x1BA6E90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool HasOverriddenBeginEndWrite()
		{
			throw null;
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x0001AEF1 File Offset: 0x000190F1
		[global::Cpp2ILInjected.Token(Token = "0x60028D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B968A0", Offset = "0x1B968A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		protected Stream()
		{
			throw null;
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x0001AEF4 File Offset: 0x000190F4
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

		// Token: 0x06002605 RID: 9733 RVA: 0x0001AEF7 File Offset: 0x000190F7
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

		// Token: 0x040012D0 RID: 4816
		[global::Cpp2ILInjected.Token(Token = "0x40015F2")]
		public static readonly Stream Null;

		// Token: 0x040012D1 RID: 4817
		[global::Cpp2ILInjected.Token(Token = "0x40015F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[global::System.NonSerialized]
		private Stream.ReadWriteTask _activeReadWriteTask;

		// Token: 0x040012D2 RID: 4818
		[global::Cpp2ILInjected.Token(Token = "0x40015F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private global::System.Threading.SemaphoreSlim _asyncActiveSemaphore;

		// Token: 0x02000616 RID: 1558
		[global::Cpp2ILInjected.Token(Token = "0x2000558")]
		private struct ReadWriteParameters
		{
			// Token: 0x040019AA RID: 6570
			[global::Cpp2ILInjected.Token(Token = "0x40015F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal byte[] Buffer;

			// Token: 0x040019AB RID: 6571
			[global::Cpp2ILInjected.Token(Token = "0x40015F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int Offset;

			// Token: 0x040019AC RID: 6572
			[global::Cpp2ILInjected.Token(Token = "0x40015F7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal int Count;
		}

		// Token: 0x02000617 RID: 1559
		[global::Cpp2ILInjected.Token(Token = "0x2000559")]
		private sealed class ReadWriteTask : global::System.Threading.Tasks.Task<int>, global::System.Threading.Tasks.ITaskCompletionAction
		{
			// Token: 0x060041AB RID: 16811 RVA: 0x0001FF7F File Offset: 0x0001E17F
			[global::Cpp2ILInjected.Token(Token = "0x60028DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC478C", Offset = "0x1BC478C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void ClearBeginState()
			{
				throw null;
			}

			// Token: 0x060041AC RID: 16812 RVA: 0x0001FF82 File Offset: 0x0001E182
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

			// Token: 0x060041AD RID: 16813 RVA: 0x0001FF85 File Offset: 0x0001E185
			[global::Cpp2ILInjected.Token(Token = "0x60028DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC48D8", Offset = "0x1BC48D8", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private static void InvokeAsyncCallback(object completedTask)
			{
				throw null;
			}

			// Token: 0x060041AE RID: 16814 RVA: 0x0001FF88 File Offset: 0x0001E188
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

			// Token: 0x17000779 RID: 1913
			// (get) Token: 0x060041AF RID: 16815 RVA: 0x0001FF8B File Offset: 0x0001E18B
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

			// Token: 0x040019AD RID: 6573
			[global::Cpp2ILInjected.Token(Token = "0x40015F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
			internal readonly bool _isRead;

			// Token: 0x040019AE RID: 6574
			[global::Cpp2ILInjected.Token(Token = "0x40015F9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x55")]
			internal readonly bool _apm;

			// Token: 0x040019AF RID: 6575
			[global::Cpp2ILInjected.Token(Token = "0x40015FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal Stream _stream;

			// Token: 0x040019B0 RID: 6576
			[global::Cpp2ILInjected.Token(Token = "0x40015FB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			internal byte[] _buffer;

			// Token: 0x040019B1 RID: 6577
			[global::Cpp2ILInjected.Token(Token = "0x40015FC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			internal readonly int _offset;

			// Token: 0x040019B2 RID: 6578
			[global::Cpp2ILInjected.Token(Token = "0x40015FD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
			internal readonly int _count;

			// Token: 0x040019B3 RID: 6579
			[global::Cpp2ILInjected.Token(Token = "0x40015FE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private global::System.AsyncCallback _callback;

			// Token: 0x040019B4 RID: 6580
			[global::Cpp2ILInjected.Token(Token = "0x40015FF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private global::System.Threading.ExecutionContext _context;

			// Token: 0x040019B5 RID: 6581
			[global::Cpp2ILInjected.Token(Token = "0x4001600")]
			private static global::System.Threading.ContextCallback s_invokeAsyncCallback;
		}

		// Token: 0x02000618 RID: 1560
		[global::Cpp2ILInjected.Token(Token = "0x200055A")]
		private sealed class NullStream : Stream
		{
			// Token: 0x060041B0 RID: 16816 RVA: 0x0001FF8E File Offset: 0x0001E18E
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

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x060041B1 RID: 16817 RVA: 0x0001FF91 File Offset: 0x0001E191
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

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x060041B2 RID: 16818 RVA: 0x0001FF94 File Offset: 0x0001E194
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

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x060041B3 RID: 16819 RVA: 0x0001FF97 File Offset: 0x0001E197
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

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x060041B4 RID: 16820 RVA: 0x0001FF9A File Offset: 0x0001E19A
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

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x060041B5 RID: 16821 RVA: 0x0001FF9D File Offset: 0x0001E19D
			// (set) Token: 0x060041B6 RID: 16822 RVA: 0x0001FFA0 File Offset: 0x0001E1A0
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

			// Token: 0x060041B7 RID: 16823 RVA: 0x0001FFA3 File Offset: 0x0001E1A3
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

			// Token: 0x060041B8 RID: 16824 RVA: 0x0001FFA6 File Offset: 0x0001E1A6
			[global::Cpp2ILInjected.Token(Token = "0x60028E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4AF4", Offset = "0x1BC4AF4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected override void Dispose(bool disposing)
			{
				throw null;
			}

			// Token: 0x060041B9 RID: 16825 RVA: 0x0001FFA9 File Offset: 0x0001E1A9
			[global::Cpp2ILInjected.Token(Token = "0x60028E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4AF8", Offset = "0x1BC4AF8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Flush()
			{
				throw null;
			}

			// Token: 0x060041BA RID: 16826 RVA: 0x0001FFAC File Offset: 0x0001E1AC
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

			// Token: 0x060041BB RID: 16827 RVA: 0x0001FFAF File Offset: 0x0001E1AF
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

			// Token: 0x060041BC RID: 16828 RVA: 0x0001FFB2 File Offset: 0x0001E1B2
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

			// Token: 0x060041BD RID: 16829 RVA: 0x0001FFB5 File Offset: 0x0001E1B5
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

			// Token: 0x060041BE RID: 16830 RVA: 0x0001FFB8 File Offset: 0x0001E1B8
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

			// Token: 0x060041BF RID: 16831 RVA: 0x0001FFBB File Offset: 0x0001E1BB
			[global::Cpp2ILInjected.Token(Token = "0x60028EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4E24", Offset = "0x1BC4E24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int Read(byte[] buffer, int offset, int count)
			{
				throw null;
			}

			// Token: 0x060041C0 RID: 16832 RVA: 0x0001FFBE File Offset: 0x0001E1BE
			[global::Cpp2ILInjected.Token(Token = "0x60028EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4E2C", Offset = "0x1BC4E2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int Read(global::System.Span<byte> buffer)
			{
				throw null;
			}

			// Token: 0x060041C1 RID: 16833 RVA: 0x0001FFC1 File Offset: 0x0001E1C1
			[global::Cpp2ILInjected.Token(Token = "0x60028F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4E34", Offset = "0x1BC4E34", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override global::System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
			{
				throw null;
			}

			// Token: 0x060041C2 RID: 16834 RVA: 0x0001FFC4 File Offset: 0x0001E1C4
			[global::Cpp2ILInjected.Token(Token = "0x60028F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4E8C", Offset = "0x1BC4E8C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override global::System.Threading.Tasks.ValueTask<int> ReadAsync(global::System.Memory<byte> buffer, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
			{
				throw null;
			}

			// Token: 0x060041C3 RID: 16835 RVA: 0x0001FFC7 File Offset: 0x0001E1C7
			[global::Cpp2ILInjected.Token(Token = "0x60028F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4EC0", Offset = "0x1BC4EC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int ReadByte()
			{
				throw null;
			}

			// Token: 0x060041C4 RID: 16836 RVA: 0x0001FFCA File Offset: 0x0001E1CA
			[global::Cpp2ILInjected.Token(Token = "0x60028F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4EC8", Offset = "0x1BC4EC8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Write(byte[] buffer, int offset, int count)
			{
				throw null;
			}

			// Token: 0x060041C5 RID: 16837 RVA: 0x0001FFCD File Offset: 0x0001E1CD
			[global::Cpp2ILInjected.Token(Token = "0x60028F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC4ECC", Offset = "0x1BC4ECC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Write(global::System.ReadOnlySpan<byte> buffer)
			{
				throw null;
			}

			// Token: 0x060041C6 RID: 16838 RVA: 0x0001FFD0 File Offset: 0x0001E1D0
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

			// Token: 0x060041C7 RID: 16839 RVA: 0x0001FFD3 File Offset: 0x0001E1D3
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

			// Token: 0x060041C8 RID: 16840 RVA: 0x0001FFD6 File Offset: 0x0001E1D6
			[global::Cpp2ILInjected.Token(Token = "0x60028F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5024", Offset = "0x1BC5024", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void WriteByte(byte value)
			{
				throw null;
			}

			// Token: 0x060041C9 RID: 16841 RVA: 0x0001FFD9 File Offset: 0x0001E1D9
			[global::Cpp2ILInjected.Token(Token = "0x60028F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5028", Offset = "0x1BC5028", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override long Seek(long offset, SeekOrigin origin)
			{
				throw null;
			}

			// Token: 0x060041CA RID: 16842 RVA: 0x0001FFDC File Offset: 0x0001E1DC
			[global::Cpp2ILInjected.Token(Token = "0x60028F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5030", Offset = "0x1BC5030", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void SetLength(long length)
			{
				throw null;
			}

			// Token: 0x060041CB RID: 16843 RVA: 0x0001FFDF File Offset: 0x0001E1DF
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

			// Token: 0x040019B6 RID: 6582
			[global::Cpp2ILInjected.Token(Token = "0x4001601")]
			private static readonly global::System.Threading.Tasks.Task<int> s_zeroTask;
		}

		// Token: 0x02000619 RID: 1561
		[global::Cpp2ILInjected.Token(Token = "0x200055B")]
		private sealed class SynchronousAsyncResult : global::System.IAsyncResult
		{
			// Token: 0x060041CC RID: 16844 RVA: 0x0001FFE2 File Offset: 0x0001E1E2
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

			// Token: 0x060041CD RID: 16845 RVA: 0x0001FFE5 File Offset: 0x0001E1E5
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

			// Token: 0x060041CE RID: 16846 RVA: 0x0001FFE8 File Offset: 0x0001E1E8
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

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x060041CF RID: 16847 RVA: 0x0001FFEB File Offset: 0x0001E1EB
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

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x060041D0 RID: 16848 RVA: 0x0001FFEE File Offset: 0x0001E1EE
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

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x060041D1 RID: 16849 RVA: 0x0001FFF1 File Offset: 0x0001E1F1
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

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x060041D2 RID: 16850 RVA: 0x0001FFF4 File Offset: 0x0001E1F4
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

			// Token: 0x060041D3 RID: 16851 RVA: 0x0001FFF7 File Offset: 0x0001E1F7
			[global::Cpp2ILInjected.Token(Token = "0x6002902")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5280", Offset = "0x1BC5280", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			internal void ThrowIfError()
			{
				throw null;
			}

			// Token: 0x060041D4 RID: 16852 RVA: 0x0001FFFA File Offset: 0x0001E1FA
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

			// Token: 0x060041D5 RID: 16853 RVA: 0x0001FFFD File Offset: 0x0001E1FD
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

			// Token: 0x040019B7 RID: 6583
			[global::Cpp2ILInjected.Token(Token = "0x4001602")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly object _stateObject;

			// Token: 0x040019B8 RID: 6584
			[global::Cpp2ILInjected.Token(Token = "0x4001603")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly bool _isWrite;

			// Token: 0x040019B9 RID: 6585
			[global::Cpp2ILInjected.Token(Token = "0x4001604")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private global::System.Threading.ManualResetEvent _waitHandle;

			// Token: 0x040019BA RID: 6586
			[global::Cpp2ILInjected.Token(Token = "0x4001605")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private global::System.Runtime.ExceptionServices.ExceptionDispatchInfo _exceptionInfo;

			// Token: 0x040019BB RID: 6587
			[global::Cpp2ILInjected.Token(Token = "0x4001606")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private bool _endXxxCalled;

			// Token: 0x040019BC RID: 6588
			[global::Cpp2ILInjected.Token(Token = "0x4001607")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			private int _bytesRead;

			// Token: 0x020006B1 RID: 1713
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200055C")]
			[global::System.Serializable]
			private sealed class <>c
			{
				// Token: 0x06004376 RID: 17270 RVA: 0x000204B0 File Offset: 0x0001E6B0
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

				// Token: 0x06004377 RID: 17271 RVA: 0x000204B3 File Offset: 0x0001E6B3
				[global::Cpp2ILInjected.Token(Token = "0x6002906")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC54C4", Offset = "0x1BC54C4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x06004378 RID: 17272 RVA: 0x000204B6 File Offset: 0x0001E6B6
				[global::Cpp2ILInjected.Token(Token = "0x6002907")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BC54CC", Offset = "0x1BC54CC", Length = "0x58")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal global::System.Threading.ManualResetEvent <get_AsyncWaitHandle>b__12_0()
				{
					throw null;
				}

				// Token: 0x04001B3F RID: 6975
				[global::Cpp2ILInjected.Token(Token = "0x4001608")]
				public static readonly Stream.SynchronousAsyncResult.<>c <>9;

				// Token: 0x04001B40 RID: 6976
				[global::Cpp2ILInjected.Token(Token = "0x4001609")]
				public static global::System.Func<global::System.Threading.ManualResetEvent> <>9__12_0;
			}
		}

		// Token: 0x0200061A RID: 1562
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200055D")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x060041D6 RID: 16854 RVA: 0x00020000 File Offset: 0x0001E200
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

			// Token: 0x060041D7 RID: 16855 RVA: 0x00020003 File Offset: 0x0001E203
			[global::Cpp2ILInjected.Token(Token = "0x6002909")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5580", Offset = "0x1BC5580", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x060041D8 RID: 16856 RVA: 0x00020006 File Offset: 0x0001E206
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

			// Token: 0x060041D9 RID: 16857 RVA: 0x00020009 File Offset: 0x0001E209
			[global::Cpp2ILInjected.Token(Token = "0x600290B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC55E4", Offset = "0x1BC55E4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <FlushAsync>b__37_0(object state)
			{
				throw null;
			}

			// Token: 0x060041DA RID: 16858 RVA: 0x0002000C File Offset: 0x0001E20C
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

			// Token: 0x060041DB RID: 16859 RVA: 0x0002000F File Offset: 0x0001E20F
			[global::Cpp2ILInjected.Token(Token = "0x600290D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC57C4", Offset = "0x1BC57C4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal global::System.IAsyncResult <BeginEndReadAsync>b__45_0(Stream stream, Stream.ReadWriteParameters args, global::System.AsyncCallback callback, object state)
			{
				throw null;
			}

			// Token: 0x060041DC RID: 16860 RVA: 0x00020012 File Offset: 0x0001E212
			[global::Cpp2ILInjected.Token(Token = "0x600290E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC57E8", Offset = "0x1BC57E8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal int <BeginEndReadAsync>b__45_1(Stream stream, global::System.IAsyncResult asyncResult)
			{
				throw null;
			}

			// Token: 0x060041DD RID: 16861 RVA: 0x00020015 File Offset: 0x0001E215
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

			// Token: 0x060041DE RID: 16862 RVA: 0x00020018 File Offset: 0x0001E218
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

			// Token: 0x060041DF RID: 16863 RVA: 0x0002001B File Offset: 0x0001E21B
			[global::Cpp2ILInjected.Token(Token = "0x6002911")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC59C4", Offset = "0x1BC59C4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal global::System.IAsyncResult <BeginEndWriteAsync>b__58_0(Stream stream, Stream.ReadWriteParameters args, global::System.AsyncCallback callback, object state)
			{
				throw null;
			}

			// Token: 0x060041E0 RID: 16864 RVA: 0x0002001E File Offset: 0x0001E21E
			[global::Cpp2ILInjected.Token(Token = "0x6002912")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC59E8", Offset = "0x1BC59E8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal global::System.Threading.Tasks.VoidTaskResult <BeginEndWriteAsync>b__58_1(Stream stream, global::System.IAsyncResult asyncResult)
			{
				throw null;
			}

			// Token: 0x040019BD RID: 6589
			[global::Cpp2ILInjected.Token(Token = "0x400160A")]
			public static readonly Stream.<>c <>9;

			// Token: 0x040019BE RID: 6590
			[global::Cpp2ILInjected.Token(Token = "0x400160B")]
			public static global::System.Func<global::System.Threading.SemaphoreSlim> <>9__4_0;

			// Token: 0x040019BF RID: 6591
			[global::Cpp2ILInjected.Token(Token = "0x400160C")]
			public static global::System.Action<object> <>9__37_0;

			// Token: 0x040019C0 RID: 6592
			[global::Cpp2ILInjected.Token(Token = "0x400160D")]
			public static global::System.Func<object, int> <>9__40_0;

			// Token: 0x040019C1 RID: 6593
			[global::Cpp2ILInjected.Token(Token = "0x400160E")]
			public static global::System.Func<Stream, Stream.ReadWriteParameters, global::System.AsyncCallback, object, global::System.IAsyncResult> <>9__45_0;

			// Token: 0x040019C2 RID: 6594
			[global::Cpp2ILInjected.Token(Token = "0x400160F")]
			public static global::System.Func<Stream, global::System.IAsyncResult, int> <>9__45_1;

			// Token: 0x040019C3 RID: 6595
			[global::Cpp2ILInjected.Token(Token = "0x4001610")]
			public static global::System.Func<object, int> <>9__48_0;

			// Token: 0x040019C4 RID: 6596
			[global::Cpp2ILInjected.Token(Token = "0x4001611")]
			public static global::System.Action<global::System.Threading.Tasks.Task, object> <>9__49_0;

			// Token: 0x040019C5 RID: 6597
			[global::Cpp2ILInjected.Token(Token = "0x4001612")]
			public static global::System.Func<Stream, Stream.ReadWriteParameters, global::System.AsyncCallback, object, global::System.IAsyncResult> <>9__58_0;

			// Token: 0x040019C6 RID: 6598
			[global::Cpp2ILInjected.Token(Token = "0x4001613")]
			public static global::System.Func<Stream, global::System.IAsyncResult, global::System.Threading.Tasks.VoidTaskResult> <>9__58_1;
		}

		// Token: 0x0200061B RID: 1563
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200055E")]
		[StructLayout(3)]
		private struct <FinishWriteAsync>d__57 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			// Token: 0x060041E1 RID: 16865 RVA: 0x00020021 File Offset: 0x0001E221
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

			// Token: 0x060041E2 RID: 16866 RVA: 0x00020024 File Offset: 0x0001E224
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6002914")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BC5C14", Offset = "0x1BC5C14", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(global::System.Runtime.CompilerServices.IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x040019C7 RID: 6599
			[global::Cpp2ILInjected.Token(Token = "0x4001614")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040019C8 RID: 6600
			[global::Cpp2ILInjected.Token(Token = "0x4001615")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040019C9 RID: 6601
			[global::Cpp2ILInjected.Token(Token = "0x4001616")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public global::System.Threading.Tasks.Task writeTask;

			// Token: 0x040019CA RID: 6602
			[global::Cpp2ILInjected.Token(Token = "0x4001617")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public byte[] localBuffer;

			// Token: 0x040019CB RID: 6603
			[global::Cpp2ILInjected.Token(Token = "0x4001618")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200061C RID: 1564
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200055F")]
		[StructLayout(3)]
		private struct ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			// Token: 0x060041E3 RID: 16867 RVA: 0x00020027 File Offset: 0x0001E227
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

			// Token: 0x060041E4 RID: 16868 RVA: 0x0002002A File Offset: 0x0001E22A
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

			// Token: 0x040019CC RID: 6604
			[global::Cpp2ILInjected.Token(Token = "0x4001619")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040019CD RID: 6605
			[global::Cpp2ILInjected.Token(Token = "0x400161A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<int> <>t__builder;

			// Token: 0x040019CE RID: 6606
			[global::Cpp2ILInjected.Token(Token = "0x400161B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public global::System.Threading.Tasks.Task<int> readTask;

			// Token: 0x040019CF RID: 6607
			[global::Cpp2ILInjected.Token(Token = "0x400161C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public byte[] localBuffer;

			// Token: 0x040019D0 RID: 6608
			[global::Cpp2ILInjected.Token(Token = "0x400161D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public global::System.Memory<byte> localDestination;

			// Token: 0x040019D1 RID: 6609
			[global::Cpp2ILInjected.Token(Token = "0x400161E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private global::System.Runtime.CompilerServices.ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
