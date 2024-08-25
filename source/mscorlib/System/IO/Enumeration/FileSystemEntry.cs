using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO.Enumeration
{
	[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000574")]
	public ref struct FileSystemEntry
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x400168B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal global::Interop.Sys.DirectoryEntry _directoryEntry;

		[global::Cpp2ILInjected.Token(Token = "0x400168C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private FileStatus _status;

		[global::Cpp2ILInjected.Token(Token = "0x400168D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private global::System.Span<char> _pathBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x400168E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private global::System.ReadOnlySpan<char> _fullPath;

		[global::Cpp2ILInjected.Token(Token = "0x400168F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private global::System.ReadOnlySpan<char> _fileName;

		[global::System.Runtime.CompilerServices.FixedBuffer(typeof(char), 256)]
		[global::Cpp2ILInjected.Token(Token = "0x4001690")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private FileSystemEntry.<_fileNameBuffer>e__FixedBuffer _fileNameBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x4001691")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
		private FileAttributes _initialAttributes;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001692")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
		private global::System.ReadOnlySpan<char> <Directory>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001693")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
		private global::System.ReadOnlySpan<char> <RootDirectory>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001694")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
		private global::System.ReadOnlySpan<char> <OriginalRootDirectory>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::System.Runtime.CompilerServices.UnsafeValueType]
		[global::Cpp2ILInjected.Token(Token = "0x2000575")]
		[StructLayout(0, Size = 512)]
		public struct <_fileNameBuffer>e__FixedBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x4001695")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public char FixedElementField;
		}
	}
}
