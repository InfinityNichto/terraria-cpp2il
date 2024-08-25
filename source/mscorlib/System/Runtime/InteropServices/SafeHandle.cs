using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices
{
	[global::Cpp2ILInjected.Token(Token = "0x200044E")]
	[StructLayout(0)]
	public abstract class SafeHandle : global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject, global::System.IDisposable
	{
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6002184")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70690", Offset = "0x1B70690", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafePasswordHandle), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeGssCredHandle", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeGssContextHandle", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeDeleteContext", Member = ".ctor", MemberParameters = new object[] { "System.Net.Security.SafeFreeCredentials" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeFreeCredentials", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeFreeNegoCredentials", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SafeHandle(global::System.IntPtr invalidHandleValue, bool ownsHandle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002185")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70728", Offset = "0x1B70728", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6002186")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B707C8", Offset = "0x1B707C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void SetHandle(global::System.IntPtr handle)
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6002187")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B707D0", Offset = "0x1B707D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.IntPtr DangerousGetHandle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700045A")]
		public bool IsClosed
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6002188")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B707D8", Offset = "0x1B707D8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "get_Length", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "get_Position", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "ReadByte", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "Read", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "BeginRead", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "Write", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "BeginWrite", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(global::System.AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(global::System.IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "Seek", MemberParameters = new object[]
			{
				typeof(long),
				typeof(global::System.IO.SeekOrigin)
			}, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "Flush", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "FlushAsync", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NTAuthentication", Member = "CloseContext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700045B")]
		public abstract bool IsInvalid
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6002189")]
			get;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600218A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B707E4", Offset = "0x1B707E4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.WaitHandle), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "get_HasExited", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "set_PriorityClass", MemberParameters = new object[] { "System.Diagnostics.ProcessPriorityClass" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "ReleaseProcessHandle", MemberParameters = new object[] { "Microsoft.Win32.SafeHandles.SafeProcessHandle" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "WaitForExit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "get_ProcessName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebStream", Member = "System.Net.ICloseEx.CloseEx", MemberParameters = new object[] { "System.Net.CloseExState" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Close()
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600218B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B707F4", Offset = "0x1B707F4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeGssNameHandle", Member = "CreateUser", MemberParameters = new object[] { typeof(string) }, ReturnType = "Microsoft.Win32.SafeHandles.SafeGssNameHandle")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeGssNameHandle", Member = "CreatePrincipal", MemberParameters = new object[] { typeof(string) }, ReturnType = "Microsoft.Win32.SafeHandles.SafeGssNameHandle")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeGssCredHandle", Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = "Microsoft.Win32.SafeHandles.SafeGssCredHandle")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NTAuthentication", Member = "CloseContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NTAuthentication", Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(bool),
			"System.Net.SecurityStatusPal&"
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginSConnect", MemberParameters = new object[] { "System.Net.Sockets.SocketAsyncResult" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeDeleteNegoContext", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.Security.SafeFreeNegoCredentials",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeDeleteNegoContext", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600218C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70804", Offset = "0x1B70804", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafePasswordHandle), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeDeleteNegoContext", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600218D")]
		protected abstract bool ReleaseHandle();

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600218E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B708D4", Offset = "0x1B708D4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.EventWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Threading.EventResetMode),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.WaitHandle), Member = "set_Handle", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetHandleAsInvalid()
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x600218F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6FC14", Offset = "0x1B6FC14", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "CopyFile", MemberParameters = new object[]
		{
			typeof(Microsoft.Win32.SafeHandles.SafeFileHandle),
			typeof(Microsoft.Win32.SafeHandles.SafeFileHandle)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.WaitHandle), Member = "WaitOneNative", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(uint),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.WaitHandle), Member = "WaitMultiple", MemberParameters = new object[]
		{
			typeof(global::System.Threading.WaitHandle[]),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.NativeEventCalls), Member = "SetEvent", MemberParameters = new object[] { typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.NativeEventCalls), Member = "ResetEvent", MemberParameters = new object[] { typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.RegisteredWaitHandle), Member = "Wait", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeBuffer), Member = "AcquirePointer", MemberParameters = new object[] { typeof(ref byte*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "GetFileType", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(global::System.IO.MonoFileType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "Cancel", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "Read", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "Write", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "Seek", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(long),
			typeof(global::System.IO.SeekOrigin),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "GetLength", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "SetLength", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(long),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(HandleRef),
			typeof(SafeHandle),
			typeof(HandleRef),
			typeof(ref Microsoft.Win32.SafeHandles.SafeWaitHandle),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "GetExitCodeProcess", MemberParameters = new object[]
		{
			"Microsoft.Win32.SafeHandles.SafeProcessHandle",
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "SetPriorityClass", MemberParameters = new object[]
		{
			"Microsoft.Win32.SafeHandles.SafeProcessHandle",
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "ProcessName_internal", MemberParameters = new object[] { "Microsoft.Win32.SafeHandles.SafeProcessHandle" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Available_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "LocalEndPoint_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(int),
			typeof(ref int)
		}, ReturnType = "System.Net.SocketAddress")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Blocking_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "RemoteEndPoint_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(int),
			typeof(ref int)
		}, ReturnType = "System.Net.SocketAddress")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Poll_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			"System.Net.Sockets.SelectMode",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Bind_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			"System.Net.SocketAddress",
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Listen_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Disconnect_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "GetSocketOption_obj_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			"System.Net.Sockets.SocketOptionLevel",
			"System.Net.Sockets.SocketOptionName",
			typeof(ref object),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SetSocketOption_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			"System.Net.Sockets.SocketOptionLevel",
			"System.Net.Sockets.SocketOptionName",
			typeof(object),
			"System.Byte[]",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "IOControl_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(int),
			"System.Byte[]",
			"System.Byte[]",
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Shutdown_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			"System.Net.Sockets.SocketShutdown",
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeDeleteContext", Member = ".ctor", MemberParameters = new object[] { "System.Net.Security.SafeFreeCredentials" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeCredentialReference", Member = ".ctor", MemberParameters = new object[] { "System.Net.Security.SafeFreeCredentials" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeFreeNegoCredentials", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "Flush", MemberParameters = new object[] { "System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "ReadZStream", MemberParameters = new object[]
		{
			"System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle",
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "WriteZStream", MemberParameters = new object[]
		{
			"System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle",
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public unsafe void DangerousAddRef(ref bool success)
		{
			throw null;
		}

		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6002190")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6FDB4", Offset = "0x1B6FDB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "CopyFile", MemberParameters = new object[]
		{
			typeof(Microsoft.Win32.SafeHandles.SafeFileHandle),
			typeof(Microsoft.Win32.SafeHandles.SafeFileHandle)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.WaitHandle), Member = "WaitOneNative", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(uint),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.WaitHandle), Member = "WaitMultiple", MemberParameters = new object[]
		{
			typeof(global::System.Threading.WaitHandle[]),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.NativeEventCalls), Member = "SetEvent", MemberParameters = new object[] { typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.NativeEventCalls), Member = "ResetEvent", MemberParameters = new object[] { typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.RegisteredWaitHandle), Member = "Wait", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "GetFileType", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(global::System.IO.MonoFileType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "Cancel", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "Read", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "Write", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "Seek", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(long),
			typeof(global::System.IO.SeekOrigin),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "GetLength", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = "SetLength", MemberParameters = new object[]
		{
			typeof(SafeHandle),
			typeof(long),
			typeof(ref global::System.IO.MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(HandleRef),
			typeof(SafeHandle),
			typeof(HandleRef),
			typeof(ref Microsoft.Win32.SafeHandles.SafeWaitHandle),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "GetExitCodeProcess", MemberParameters = new object[]
		{
			"Microsoft.Win32.SafeHandles.SafeProcessHandle",
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "SetPriorityClass", MemberParameters = new object[]
		{
			"Microsoft.Win32.SafeHandles.SafeProcessHandle",
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "ProcessName_internal", MemberParameters = new object[] { "Microsoft.Win32.SafeHandles.SafeProcessHandle" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Available_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "LocalEndPoint_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(int),
			typeof(ref int)
		}, ReturnType = "System.Net.SocketAddress")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Blocking_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "RemoteEndPoint_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(int),
			typeof(ref int)
		}, ReturnType = "System.Net.SocketAddress")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Poll_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			"System.Net.Sockets.SelectMode",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Bind_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			"System.Net.SocketAddress",
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Listen_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Disconnect_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "GetSocketOption_obj_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			"System.Net.Sockets.SocketOptionLevel",
			"System.Net.Sockets.SocketOptionName",
			typeof(ref object),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SetSocketOption_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			"System.Net.Sockets.SocketOptionLevel",
			"System.Net.Sockets.SocketOptionName",
			typeof(object),
			"System.Byte[]",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "IOControl_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			typeof(int),
			"System.Byte[]",
			"System.Byte[]",
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Shutdown_internal", MemberParameters = new object[]
		{
			"System.Net.Sockets.SafeSocketHandle",
			"System.Net.Sockets.SocketShutdown",
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeDeleteContext", Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeCredentialReference", Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeFreeNegoCredentials", Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "Flush", MemberParameters = new object[] { "System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "ReadZStream", MemberParameters = new object[]
		{
			"System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle",
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "WriteZStream", MemberParameters = new object[]
		{
			"System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle",
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 65)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void DangerousRelease()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002191")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70820", Offset = "0x1B70820", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void InternalDispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002192")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B708C0", Offset = "0x1B708C0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private void InternalFinalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002193")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70958", Offset = "0x1B70958", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeHandle), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeHandle), Member = "InternalDispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeHandle), Member = "InternalFinalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void DangerousReleaseInternal(bool dispose)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400127D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected global::System.IntPtr handle;

		[global::Cpp2ILInjected.Token(Token = "0x400127E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _state;

		[global::Cpp2ILInjected.Token(Token = "0x400127F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _ownsHandle;

		[global::Cpp2ILInjected.Token(Token = "0x4001280")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D")]
		private bool _fullyInitialized;

		[global::Cpp2ILInjected.Token(Token = "0x4001281")]
		private const int RefCount_Mask = 2147483644;

		[global::Cpp2ILInjected.Token(Token = "0x4001282")]
		private const int RefCount_One = 4;
	}
}
