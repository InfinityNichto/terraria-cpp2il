using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000486 RID: 1158
	[global::Cpp2ILInjected.Token(Token = "0x2000551")]
	[global::System.Serializable]
	public abstract class FileSystemInfo : global::System.MarshalByRefObject, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060025BA RID: 9658 RVA: 0x0001AE37 File Offset: 0x00019037
		[global::Cpp2ILInjected.Token(Token = "0x600288E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA1B00", Offset = "0x1BA1B00", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected FileSystemInfo()
		{
			throw null;
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x0001AE3A File Offset: 0x0001903A
		[global::Cpp2ILInjected.Token(Token = "0x600288F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA1E04", Offset = "0x1BA1E04", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Invalidate()
		{
			throw null;
		}

		// Token: 0x17000553 RID: 1363
		// (set) Token: 0x060025BC RID: 9660 RVA: 0x0001AE3D File Offset: 0x0001903D
		[global::Cpp2ILInjected.Token(Token = "0x170005D1")]
		public FileAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002890")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA4D58", Offset = "0x1BA4D58", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "SetAttributes", MemberParameters = new object[]
			{
				typeof(string),
				typeof(FileAttributes)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x0001AE40 File Offset: 0x00019040
		[global::Cpp2ILInjected.Token(Token = "0x170005D2")]
		internal bool ExistsCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002891")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA4E14", Offset = "0x1BA4E14", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_Exists", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "Refresh", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x0001AE43 File Offset: 0x00019043
		[global::Cpp2ILInjected.Token(Token = "0x170005D3")]
		internal global::System.DateTimeOffset CreationTimeCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002892")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA4EAC", Offset = "0x1BA4EAC", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_CreationTime", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_CreationTimeUtc", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "GetCreationTime", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(bool)
			}, ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x0001AE46 File Offset: 0x00019046
		[global::Cpp2ILInjected.Token(Token = "0x170005D4")]
		internal global::System.DateTimeOffset LastAccessTimeCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002893")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA4F18", Offset = "0x1BA4F18", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastAccessTime", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastAccessTimeUtc", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "GetLastAccessTime", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(bool)
			}, ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x0001AE49 File Offset: 0x00019049
		[global::Cpp2ILInjected.Token(Token = "0x170005D5")]
		internal global::System.DateTimeOffset LastWriteTimeCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002894")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA4F84", Offset = "0x1BA4F84", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTime", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTimeUtc", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStatus), Member = "GetLastWriteTime", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(bool)
			}, ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0001AE4C File Offset: 0x0001904C
		[global::Cpp2ILInjected.Token(Token = "0x6002895")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA441C", Offset = "0x1BA441C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileStatus), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = ".ctor", MemberParameters = new object[] { typeof(global::Interop.Error) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
		{
			typeof(global::Interop.ErrorInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void ThrowNotFound(string path)
		{
			throw null;
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060025C2 RID: 9666 RVA: 0x0001AE4F File Offset: 0x0001904F
		[global::Cpp2ILInjected.Token(Token = "0x170005D6")]
		internal string NormalizedPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002896")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA4FF0", Offset = "0x1BA4FF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x0001AE52 File Offset: 0x00019052
		[global::Cpp2ILInjected.Token(Token = "0x6002897")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA1E14", Offset = "0x1BA1E14", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPathInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected FileSystemInfo(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0001AE55 File Offset: 0x00019055
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002898")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA4FF8", Offset = "0x1BA4FF8", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x0001AE58 File Offset: 0x00019058
		[global::Cpp2ILInjected.Token(Token = "0x170005D7")]
		public virtual string FullName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002899")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA5140", Offset = "0x1BA5140", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x0001AE5B File Offset: 0x0001905B
		[global::Cpp2ILInjected.Token(Token = "0x170005D8")]
		public virtual string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600289A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA5148", Offset = "0x1BA5148", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x0001AE5E File Offset: 0x0001905E
		[global::Cpp2ILInjected.Token(Token = "0x170005D9")]
		public virtual bool Exists
		{
			[global::Cpp2ILInjected.Token(Token = "0x600289B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA5150", Offset = "0x1BA5150", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = "get_ExistsCore", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x0001AE61 File Offset: 0x00019061
		[global::Cpp2ILInjected.Token(Token = "0x170005DA")]
		public global::System.DateTime CreationTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600289C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA4D6C", Offset = "0x1BA4D6C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "GetCreationTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = "get_CreationTimeCore", ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToLocalTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x0001AE64 File Offset: 0x00019064
		[global::Cpp2ILInjected.Token(Token = "0x170005DB")]
		public global::System.DateTime CreationTimeUtc
		{
			[global::Cpp2ILInjected.Token(Token = "0x600289D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA51D8", Offset = "0x1BA51D8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = "get_CreationTimeCore", ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x0001AE67 File Offset: 0x00019067
		[global::Cpp2ILInjected.Token(Token = "0x170005DC")]
		public global::System.DateTime LastAccessTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600289E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA4DA4", Offset = "0x1BA4DA4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "GetLastAccessTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = "get_LastAccessTimeCore", ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToLocalTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060025CB RID: 9675 RVA: 0x0001AE6A File Offset: 0x0001906A
		[global::Cpp2ILInjected.Token(Token = "0x170005DD")]
		public global::System.DateTime LastAccessTimeUtc
		{
			[global::Cpp2ILInjected.Token(Token = "0x600289F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA5200", Offset = "0x1BA5200", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = "get_LastAccessTimeCore", ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x0001AE6D File Offset: 0x0001906D
		[global::Cpp2ILInjected.Token(Token = "0x170005DE")]
		public global::System.DateTime LastWriteTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA4DDC", Offset = "0x1BA4DDC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "GetLastWriteTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = "get_LastWriteTimeCore", ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToLocalTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x0001AE70 File Offset: 0x00019070
		[global::Cpp2ILInjected.Token(Token = "0x170005DF")]
		public global::System.DateTime LastWriteTimeUtc
		{
			[global::Cpp2ILInjected.Token(Token = "0x60028A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA5228", Offset = "0x1BA5228", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = "get_LastWriteTimeCore", ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x0001AE73 File Offset: 0x00019073
		[global::Cpp2ILInjected.Token(Token = "0x60028A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA5250", Offset = "0x1BA5250", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040012AD RID: 4781
		[global::Cpp2ILInjected.Token(Token = "0x40015CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private FileStatus _fileStatus;

		// Token: 0x040012AE RID: 4782
		[global::Cpp2ILInjected.Token(Token = "0x40015D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		protected string FullPath;

		// Token: 0x040012AF RID: 4783
		[global::Cpp2ILInjected.Token(Token = "0x40015D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		protected string OriginalPath;

		// Token: 0x040012B0 RID: 4784
		[global::Cpp2ILInjected.Token(Token = "0x40015D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		internal string _name;
	}
}
