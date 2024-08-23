using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000484 RID: 1156
	[global::Cpp2ILInjected.Token(Token = "0x200054F")]
	internal struct FileStatus
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x0001ADE6 File Offset: 0x00018FE6
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x0001ADE9 File Offset: 0x00018FE9
		[global::Cpp2ILInjected.Token(Token = "0x170005D0")]
		internal bool InitiallyDirectory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002873")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA4044", Offset = "0x1BA4044", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002874")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA404C", Offset = "0x1BA404C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x0001ADEC File Offset: 0x00018FEC
		[global::Cpp2ILInjected.Token(Token = "0x6002875")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA4058", Offset = "0x1BA4058", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEntry), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ref global::System.IO.Enumeration.FileSystemEntry),
			typeof(global::Interop.Sys.DirectoryEntry),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>)
		}, ReturnType = typeof(FileAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static void Initialize(ref FileStatus status, bool isDirectory)
		{
			throw null;
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x0001ADEF File Offset: 0x00018FEF
		[global::Cpp2ILInjected.Token(Token = "0x6002876")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA406C", Offset = "0x1BA406C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Invalidate()
		{
			throw null;
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x0001ADF2 File Offset: 0x00018FF2
		[global::Cpp2ILInjected.Token(Token = "0x6002877")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA4078", Offset = "0x1BA4078", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEntry), Member = "get_Attributes", ReturnType = typeof(FileAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "EnsureStatInitialized", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "GetEUid", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "GetEGid", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal bool IsReadOnly(global::System.ReadOnlySpan<char> path, bool continueOnError = false)
		{
			throw null;
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x0001ADF5 File Offset: 0x00018FF5
		[global::Cpp2ILInjected.Token(Token = "0x6002878")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA4224", Offset = "0x1BA4224", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "set_Attributes", MemberParameters = new object[] { typeof(FileAttributes) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "EnsureStatInitialized", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "LChflags", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "CheckIo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(bool),
			typeof(global::System.Func<global::Interop.ErrorInfo, global::Interop.ErrorInfo>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "ChMod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = "ThrowNotFound", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void SetAttributes(string path, FileAttributes attributes)
		{
			throw null;
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x0001ADF8 File Offset: 0x00018FF8
		[global::Cpp2ILInjected.Token(Token = "0x6002879")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA44B0", Offset = "0x1BA44B0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "Refresh", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		internal bool GetExists(global::System.ReadOnlySpan<char> path)
		{
			throw null;
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x0001ADFB File Offset: 0x00018FFB
		[global::Cpp2ILInjected.Token(Token = "0x600287A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA4688", Offset = "0x1BA4688", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_CreationTimeCore", ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "EnsureStatInitialized", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "FromFileTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.DateTimeOffset GetCreationTime(global::System.ReadOnlySpan<char> path, bool continueOnError = false)
		{
			throw null;
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x0001ADFE File Offset: 0x00018FFE
		[global::Cpp2ILInjected.Token(Token = "0x600287B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA4820", Offset = "0x1BA4820", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastAccessTimeCore", ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "EnsureStatInitialized", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "UnixTimeToDateTimeOffset", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "FromFileTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.DateTimeOffset GetLastAccessTime(global::System.ReadOnlySpan<char> path, bool continueOnError = false)
		{
			throw null;
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0001AE01 File Offset: 0x00019001
		[global::Cpp2ILInjected.Token(Token = "0x600287C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA48BC", Offset = "0x1BA48BC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTimeCore", ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "EnsureStatInitialized", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "UnixTimeToDateTimeOffset", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "FromFileTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.DateTimeOffset GetLastWriteTime(global::System.ReadOnlySpan<char> path, bool continueOnError = false)
		{
			throw null;
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0001AE04 File Offset: 0x00019004
		[global::Cpp2ILInjected.Token(Token = "0x600287D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA476C", Offset = "0x1BA476C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "GetLastAccessTime", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "GetLastWriteTime", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "FromUnixTimeSeconds", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "ToLocalTime", ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.DateTimeOffset UnixTimeToDateTimeOffset(long seconds, long nanoseconds)
		{
			throw null;
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x0001AE07 File Offset: 0x00019007
		[global::Cpp2ILInjected.Token(Token = "0x600287E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA44F4", Offset = "0x1BA44F4", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "GetExists", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "EnsureStatInitialized", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_ExistsCore", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "LStat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "Stat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "GetLastErrorInfo", ReturnType = typeof(global::Interop.ErrorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = "get_RawErrno", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Refresh(global::System.ReadOnlySpan<char> path)
		{
			throw null;
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x0001AE0A File Offset: 0x0001900A
		[global::Cpp2ILInjected.Token(Token = "0x600287F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA4168", Offset = "0x1BA4168", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "IsReadOnly", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "GetCreationTime", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "GetLastAccessTime", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "GetLastWriteTime", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
		{
			typeof(global::Interop.ErrorInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "Refresh", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void EnsureStatInitialized(global::System.ReadOnlySpan<char> path, bool continueOnError = false)
		{
			throw null;
		}

		// Token: 0x040012A8 RID: 4776
		[global::Cpp2ILInjected.Token(Token = "0x40015CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::Interop.Sys.FileStatus _fileStatus;

		// Token: 0x040012A9 RID: 4777
		[global::Cpp2ILInjected.Token(Token = "0x40015CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int _fileStatusInitialized;

		// Token: 0x040012AA RID: 4778
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40015CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private bool <InitiallyDirectory>k__BackingField;

		// Token: 0x040012AB RID: 4779
		[global::Cpp2ILInjected.Token(Token = "0x40015CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x75")]
		internal bool _isDirectory;

		// Token: 0x040012AC RID: 4780
		[global::Cpp2ILInjected.Token(Token = "0x40015CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x76")]
		private bool _exists;
	}
}
