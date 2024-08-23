using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO.Enumeration
{
	// Token: 0x0200049E RID: 1182
	[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000574")]
	public ref struct FileSystemEntry
	{
		// Token: 0x060026EC RID: 9964 RVA: 0x0001B167 File Offset: 0x00019367
		[global::Cpp2ILInjected.Token(Token = "0x6002A09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD2AA4", Offset = "0x1BD2AA4", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerator<>), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "get_Empty", ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "get_FullPath", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "Stat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "LStat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ref FileStatus),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static FileAttributes Initialize(ref FileSystemEntry entry, global::Interop.Sys.DirectoryEntry directoryEntry, global::System.ReadOnlySpan<char> directory, global::System.ReadOnlySpan<char> rootDirectory, global::System.ReadOnlySpan<char> originalRootDirectory, global::System.Span<char> pathBuffer)
		{
			throw null;
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x0001B16A File Offset: 0x0001936A
		[global::Cpp2ILInjected.Token(Token = "0x17000606")]
		private global::System.ReadOnlySpan<char> FullPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD2D24", Offset = "0x1BD2D24", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEntry), Member = "Initialize", MemberParameters = new object[]
			{
				typeof(ref FileSystemEntry),
				typeof(global::Interop.Sys.DirectoryEntry),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.Span<char>)
			}, ReturnType = typeof(FileAttributes))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEntry), Member = "get_Attributes", ReturnType = typeof(FileAttributes))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "get_FileName", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "TryJoin", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.Span<char>),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x0001B16D File Offset: 0x0001936D
		[global::Cpp2ILInjected.Token(Token = "0x17000607")]
		public global::System.ReadOnlySpan<char> FileName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD2E54", Offset = "0x1BD2E54", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEntry), Member = "get_FullPath", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory.<>c__DisplayClass3_0", Member = "<UserFiles>b__1", MemberParameters = new object[] { typeof(ref FileSystemEntry) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory.<>c__DisplayClass4_0", Member = "<UserDirectories>b__1", MemberParameters = new object[] { typeof(ref FileSystemEntry) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory.<>c__DisplayClass5_0", Member = "<UserEntries>b__1", MemberParameters = new object[] { typeof(ref FileSystemEntry) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerator<>), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys.DirectoryEntry), Member = "GetName", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x0001B170 File Offset: 0x00019370
		// (set) Token: 0x060026F0 RID: 9968 RVA: 0x0001B173 File Offset: 0x00019373
		[global::Cpp2ILInjected.Token(Token = "0x17000608")]
		public global::System.ReadOnlySpan<char> Directory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002A0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD2EE8", Offset = "0x1BD2EE8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002A0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD2EF8", Offset = "0x1BD2EF8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x0001B176 File Offset: 0x00019376
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x0001B179 File Offset: 0x00019379
		[global::Cpp2ILInjected.Token(Token = "0x17000609")]
		public global::System.ReadOnlySpan<char> RootDirectory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002A0E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD2F04", Offset = "0x1BD2F04", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002A0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD2F14", Offset = "0x1BD2F14", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x0001B17C File Offset: 0x0001937C
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x0001B17F File Offset: 0x0001937F
		[global::Cpp2ILInjected.Token(Token = "0x1700060A")]
		public global::System.ReadOnlySpan<char> OriginalRootDirectory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002A10")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD2F20", Offset = "0x1BD2F20", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002A11")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD2F30", Offset = "0x1BD2F30", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x0001B182 File Offset: 0x00019382
		[global::Cpp2ILInjected.Token(Token = "0x1700060B")]
		public FileAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A12")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD2F3C", Offset = "0x1BD2F3C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerator<>), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "get_FullPath", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "IsReadOnly", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x0001B185 File Offset: 0x00019385
		[global::Cpp2ILInjected.Token(Token = "0x1700060C")]
		public bool IsDirectory
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A13")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD2F84", Offset = "0x1BD2F84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x0001B188 File Offset: 0x00019388
		[global::Cpp2ILInjected.Token(Token = "0x6002A14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD2F8C", Offset = "0x1BD2F8C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory.<>c", Member = "<UserFiles>b__3_0", MemberParameters = new object[] { typeof(ref FileSystemEntry) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory.<>c", Member = "<UserDirectories>b__4_0", MemberParameters = new object[] { typeof(ref FileSystemEntry) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory.<>c", Member = "<UserEntries>b__5_0", MemberParameters = new object[] { typeof(ref FileSystemEntry) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "EndsInDirectorySeparator", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "StartsWithDirectorySeparator", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemEntry), Member = "get_FileName", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Join", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public string ToSpecifiedFullPath()
		{
			throw null;
		}

		// Token: 0x0400133C RID: 4924
		[global::Cpp2ILInjected.Token(Token = "0x400168B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal global::Interop.Sys.DirectoryEntry _directoryEntry;

		// Token: 0x0400133D RID: 4925
		[global::Cpp2ILInjected.Token(Token = "0x400168C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private FileStatus _status;

		// Token: 0x0400133E RID: 4926
		[global::Cpp2ILInjected.Token(Token = "0x400168D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private global::System.Span<char> _pathBuffer;

		// Token: 0x0400133F RID: 4927
		[global::Cpp2ILInjected.Token(Token = "0x400168E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private global::System.ReadOnlySpan<char> _fullPath;

		// Token: 0x04001340 RID: 4928
		[global::Cpp2ILInjected.Token(Token = "0x400168F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private global::System.ReadOnlySpan<char> _fileName;

		// Token: 0x04001341 RID: 4929
		[global::System.Runtime.CompilerServices.FixedBuffer(typeof(char), 256)]
		[global::Cpp2ILInjected.Token(Token = "0x4001690")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private FileSystemEntry.<_fileNameBuffer>e__FixedBuffer _fileNameBuffer;

		// Token: 0x04001342 RID: 4930
		[global::Cpp2ILInjected.Token(Token = "0x4001691")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
		private FileAttributes _initialAttributes;

		// Token: 0x04001343 RID: 4931
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001692")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
		private global::System.ReadOnlySpan<char> <Directory>k__BackingField;

		// Token: 0x04001344 RID: 4932
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001693")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
		private global::System.ReadOnlySpan<char> <RootDirectory>k__BackingField;

		// Token: 0x04001345 RID: 4933
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001694")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
		private global::System.ReadOnlySpan<char> <OriginalRootDirectory>k__BackingField;

		// Token: 0x02000620 RID: 1568
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::System.Runtime.CompilerServices.UnsafeValueType]
		[global::Cpp2ILInjected.Token(Token = "0x2000575")]
		[StructLayout(0, Size = 512)]
		public struct <_fileNameBuffer>e__FixedBuffer
		{
			// Token: 0x040019D5 RID: 6613
			[global::Cpp2ILInjected.Token(Token = "0x4001695")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public char FixedElementField;
		}
	}
}
