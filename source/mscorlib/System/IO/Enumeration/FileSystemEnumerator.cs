using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO.Enumeration
{
	[global::Cpp2ILInjected.Token(Token = "0x200057F")]
	public abstract class FileSystemEnumerator<TResult> : global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject, global::System.Collections.Generic.IEnumerator<TResult>, global::System.IDisposable, global::System.Collections.IEnumerator
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002A34")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A18C4", Offset = "0x16A18C4", Length = "0x444")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "GetReadDirRBufferSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		public FileSystemEnumerator(string directory, EnumerationOptions options = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A35")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A1D08", Offset = "0x16A1D08", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = "get_RawErrno", ReturnType = typeof(int))]
		private bool InternalContinueOnError(global::Interop.ErrorInfo info, bool ignoreNotFound = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A36")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A1DAC", Offset = "0x16A1DAC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsDirectoryNotFound(global::Interop.ErrorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A37")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A1DD0", Offset = "0x16A1DD0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsAccessError(global::Interop.ErrorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A38")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A1E08", Offset = "0x16A1E08", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "OpenDir", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "GetLastErrorInfo", ReturnType = typeof(global::Interop.ErrorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
		{
			typeof(global::Interop.ErrorInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private global::System.IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A39")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A1F30", Offset = "0x16A1F30", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "CloseDir", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void CloseDirectoryHandle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A1FDC", Offset = "0x16A1FDC", Length = "0x52C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ref FileSystemEntry),
			typeof(global::Interop.Sys.DirectoryEntry),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>)
		}, ReturnType = typeof(FileAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "get_Attributes", ReturnType = typeof(FileAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Queue<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "get_FileName", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Join", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Queue<>), Member = "Enqueue", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public bool MoveNext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2508", Offset = "0x16A2508", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void FindNextEntry()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2540", Offset = "0x16A2540", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "ReadDirR", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(byte*),
			typeof(int),
			typeof(ref global::Interop.Sys.DirectoryEntry)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
		{
			typeof(global::Interop.ErrorInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe void FindNextEntry(byte* entryBufferPtr, int bufferLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2698", Offset = "0x16A2698", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Queue<>), Member = "Dequeue", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool DequeueNextDirectory()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2794", Offset = "0x16A2794", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void InternalDispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2A34", Offset = "0x16A2A34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A40")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2A3C", Offset = "0x16A2A3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A41")]
		protected abstract TResult TransformEntry(ref FileSystemEntry entry);

		[global::Cpp2ILInjected.Token(Token = "0x6002A42")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2A44", Offset = "0x16A2A44", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnDirectoryFinished(global::System.ReadOnlySpan<char> directory)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A43")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2A48", Offset = "0x16A2A48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual bool ContinueOnError(int error)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700060F")]
		public TResult Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A44")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A2A50", Offset = "0x16A2A50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000610")]
		private object System.Collections.IEnumerator.Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A45")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A2A58", Offset = "0x16A2A58", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A46")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2A6C", Offset = "0x16A2A6C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void DirectoryFinished()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A47")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2B4C", Offset = "0x16A2B4C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A48")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2B84", Offset = "0x16A2B84", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A49")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2C04", Offset = "0x16A2C04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A2C08", Offset = "0x16A2C08", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40016A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _originalRootDirectory;

		[global::Cpp2ILInjected.Token(Token = "0x40016A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _rootDirectory;

		[global::Cpp2ILInjected.Token(Token = "0x40016AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly EnumerationOptions _options;

		[global::Cpp2ILInjected.Token(Token = "0x40016AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly object _lock;

		[global::Cpp2ILInjected.Token(Token = "0x40016AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string _currentPath;

		[global::Cpp2ILInjected.Token(Token = "0x40016AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.IntPtr _directoryHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40016AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _lastEntryFound;

		[global::Cpp2ILInjected.Token(Token = "0x40016AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Collections.Generic.Queue<string> _pending;

		[global::Cpp2ILInjected.Token(Token = "0x40016B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::Interop.Sys.DirectoryEntry _entry;

		[global::Cpp2ILInjected.Token(Token = "0x40016B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TResult _current;

		[global::Cpp2ILInjected.Token(Token = "0x40016B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private char[] _pathBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x40016B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private byte[] _entryBuffer;
	}
}
