using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000E1 RID: 225
	[global::Cpp2ILInjected.Token(Token = "0x200014D")]
	internal class FtpDataStream : Stream, ICloseEx
	{
		// Token: 0x0600075B RID: 1883 RVA: 0x00004364 File Offset: 0x00002564
		[global::Cpp2ILInjected.Token(Token = "0x6000826")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF1098", Offset = "0x1EF1098", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal FtpDataStream(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly)
		{
			throw null;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00004367 File Offset: 0x00002567
		[global::Cpp2ILInjected.Token(Token = "0x6000827")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF119C", Offset = "0x1EF119C", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0000436A File Offset: 0x0000256A
		[global::Cpp2ILInjected.Token(Token = "0x6000828")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF1324", Offset = "0x1EF1324", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStream), Member = "Close", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "DataStreamClosed", MemberParameters = new object[] { typeof(CloseExState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private void System.Net.ICloseEx.CloseEx(CloseExState closeState)
		{
			throw null;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0000436D File Offset: 0x0000256D
		[global::Cpp2ILInjected.Token(Token = "0x6000829")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF16DC", Offset = "0x1EF16DC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "Seek", MemberParameters = new object[]
		{
			typeof(long),
			typeof(SeekOrigin)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "EndRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "EndWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CheckError()
		{
			throw null;
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00004370 File Offset: 0x00002570
		[global::Cpp2ILInjected.Token(Token = "0x170001AF")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600082A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF1718", Offset = "0x1EF1718", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00004373 File Offset: 0x00002573
		[global::Cpp2ILInjected.Token(Token = "0x170001B0")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x600082B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF1720", Offset = "0x1EF1720", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00004376 File Offset: 0x00002576
		[global::Cpp2ILInjected.Token(Token = "0x170001B1")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600082C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF1730", Offset = "0x1EF1730", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00004379 File Offset: 0x00002579
		[global::Cpp2ILInjected.Token(Token = "0x170001B2")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600082D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF1738", Offset = "0x1EF1738", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0000437C File Offset: 0x0000257C
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x0000437F File Offset: 0x0000257F
		[global::Cpp2ILInjected.Token(Token = "0x170001B3")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600082E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF1748", Offset = "0x1EF1748", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600082F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF1758", Offset = "0x1EF1758", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00004382 File Offset: 0x00002582
		[global::Cpp2ILInjected.Token(Token = "0x6000830")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF176C", Offset = "0x1EF176C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00004385 File Offset: 0x00002585
		[global::Cpp2ILInjected.Token(Token = "0x6000831")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF182C", Offset = "0x1EF182C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override int Read(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00004388 File Offset: 0x00002588
		[global::Cpp2ILInjected.Token(Token = "0x6000832")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF1924", Offset = "0x1EF1924", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Write(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0000438B File Offset: 0x0000258B
		[global::Cpp2ILInjected.Token(Token = "0x6000833")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF19F4", Offset = "0x1EF19F4", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void AsyncReadCallback(IAsyncResult ar)
		{
			throw null;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0000438E File Offset: 0x0000258E
		[global::Cpp2ILInjected.Token(Token = "0x6000834")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF1C7C", Offset = "0x1EF1C7C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00004391 File Offset: 0x00002591
		[global::Cpp2ILInjected.Token(Token = "0x6000835")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF1E08", Offset = "0x1EF1E08", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InternalWaitForCompletion", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override int EndRead(IAsyncResult ar)
		{
			throw null;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00004394 File Offset: 0x00002594
		[global::Cpp2ILInjected.Token(Token = "0x6000836")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF1FA0", Offset = "0x1EF1FA0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00004397 File Offset: 0x00002597
		[global::Cpp2ILInjected.Token(Token = "0x6000837")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF2088", Offset = "0x1EF2088", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0000439A File Offset: 0x0000259A
		[global::Cpp2ILInjected.Token(Token = "0x6000838")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF2120", Offset = "0x1EF2120", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0000439D File Offset: 0x0000259D
		[global::Cpp2ILInjected.Token(Token = "0x6000839")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF2134", Offset = "0x1EF2134", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x000043A0 File Offset: 0x000025A0
		[global::Cpp2ILInjected.Token(Token = "0x170001B4")]
		public override bool CanTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x600083A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2148", Offset = "0x1EF2148", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x000043A3 File Offset: 0x000025A3
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x000043A6 File Offset: 0x000025A6
		[global::Cpp2ILInjected.Token(Token = "0x170001B5")]
		public override int ReadTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x600083B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2158", Offset = "0x1EF2158", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600083C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF216C", Offset = "0x1EF216C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x000043A9 File Offset: 0x000025A9
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x000043AC File Offset: 0x000025AC
		[global::Cpp2ILInjected.Token(Token = "0x170001B6")]
		public override int WriteTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x600083D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2180", Offset = "0x1EF2180", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600083E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2194", Offset = "0x1EF2194", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000043AF File Offset: 0x000025AF
		[global::Cpp2ILInjected.Token(Token = "0x600083F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF21A8", Offset = "0x1EF21A8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void SetSocketTimeoutOption(int timeout)
		{
			throw null;
		}

		// Token: 0x040004FE RID: 1278
		[global::Cpp2ILInjected.Token(Token = "0x4000697")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private FtpWebRequest _request;

		// Token: 0x040004FF RID: 1279
		[global::Cpp2ILInjected.Token(Token = "0x4000698")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private NetworkStream _networkStream;

		// Token: 0x04000500 RID: 1280
		[global::Cpp2ILInjected.Token(Token = "0x4000699")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool _writeable;

		// Token: 0x04000501 RID: 1281
		[global::Cpp2ILInjected.Token(Token = "0x400069A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		private bool _readable;

		// Token: 0x04000502 RID: 1282
		[global::Cpp2ILInjected.Token(Token = "0x400069B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A")]
		private bool _isFullyRead;

		// Token: 0x04000503 RID: 1283
		[global::Cpp2ILInjected.Token(Token = "0x400069C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B")]
		private bool _closing;

		// Token: 0x04000504 RID: 1284
		[global::Cpp2ILInjected.Token(Token = "0x400069D")]
		private const int DefaultCloseTimeout = -1;
	}
}
