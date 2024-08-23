using System;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000002 RID: 2
[global::Cpp2ILInjected.Token(Token = "0x2000002")]
internal static class Interop
{
	// Token: 0x06000001 RID: 1 RVA: 0x000145E5 File Offset: 0x000127E5
	[global::Cpp2ILInjected.Token(Token = "0x6000001")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AA9018", Offset = "0x1AA9018", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "CheckIo", MemberParameters = new object[]
	{
		typeof(long),
		typeof(string),
		typeof(bool),
		typeof(global::System.Func<global::Interop.ErrorInfo, global::Interop.ErrorInfo>)
	}, ReturnType = typeof(long))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
	{
		typeof(global::Interop.ErrorInfo),
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private static void ThrowExceptionForIoErrno(global::Interop.ErrorInfo errorInfo, string path, bool isDirectory, global::System.Func<global::Interop.ErrorInfo, global::Interop.ErrorInfo> errorRewriter)
	{
		throw null;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000145E8 File Offset: 0x000127E8
	[global::Cpp2ILInjected.Token(Token = "0x6000002")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AA9534", Offset = "0x1AA9534", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "CheckIo", MemberParameters = new object[]
	{
		typeof(int),
		typeof(string),
		typeof(bool),
		typeof(global::System.Func<global::Interop.ErrorInfo, global::Interop.ErrorInfo>)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "GetLastErrorInfo", ReturnType = typeof(global::Interop.ErrorInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "ThrowExceptionForIoErrno", MemberParameters = new object[]
	{
		typeof(global::Interop.ErrorInfo),
		typeof(string),
		typeof(bool),
		typeof(global::System.Func<global::Interop.ErrorInfo, global::Interop.ErrorInfo>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	internal static long CheckIo(long result, string path = null, bool isDirectory = false, global::System.Func<global::Interop.ErrorInfo, global::Interop.ErrorInfo> errorRewriter = null)
	{
		throw null;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000145EB File Offset: 0x000127EB
	[global::Cpp2ILInjected.Token(Token = "0x6000003")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AA9614", Offset = "0x1AA9614", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "SetAttributes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(global::System.IO.FileAttributes)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CopyFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "CheckIo", MemberParameters = new object[]
	{
		typeof(long),
		typeof(string),
		typeof(bool),
		typeof(global::System.Func<global::Interop.ErrorInfo, global::Interop.ErrorInfo>)
	}, ReturnType = typeof(long))]
	internal static int CheckIo(int result, string path = null, bool isDirectory = false, global::System.Func<global::Interop.ErrorInfo, global::Interop.ErrorInfo> errorRewriter = null)
	{
		throw null;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000145EE File Offset: 0x000127EE
	[global::Cpp2ILInjected.Token(Token = "0x6000004")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AA9070", Offset = "0x1AA9070", Length = "0x4C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "ThrowExceptionForIoErrno", MemberParameters = new object[]
	{
		typeof(global::Interop.ErrorInfo),
		typeof(string),
		typeof(bool),
		typeof(global::System.Func<global::Interop.ErrorInfo, global::Interop.ErrorInfo>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "EnumerateFilesRecursively", MemberParameters = new object[]
	{
		typeof(string),
		typeof(global::System.Predicate<string>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "EnsureStatInitialized", MemberParameters = new object[]
	{
		typeof(global::System.ReadOnlySpan<char>),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CopyDanglingSymlink", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "LinkOrCopyFile", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "DeleteFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystemInfo), Member = "ThrowNotFound", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "CreateDirectoryHandle", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(global::System.IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "FindNextEntry", MemberParameters = new object[]
	{
		typeof(byte*),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OperationCanceledException), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = "get_RawErrno", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetIOException", MemberParameters = new object[] { typeof(global::Interop.ErrorInfo) }, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UnauthorizedAccessException), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(global::System.Exception)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.IOException), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.PathTooLongException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.DirectoryNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileNotFoundException), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
	internal unsafe static global::System.Exception GetExceptionForIoErrno(global::Interop.ErrorInfo errorInfo, string path = null, bool isDirectory = false)
	{
		throw null;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000145F1 File Offset: 0x000127F1
	[global::Cpp2ILInjected.Token(Token = "0x6000005")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AA96A4", Offset = "0x1AA96A4", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
	{
		typeof(global::Interop.ErrorInfo),
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(global::System.Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = "GetErrorMessage", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = "get_RawErrno", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.IOException), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	internal static global::System.Exception GetIOException(global::Interop.ErrorInfo errorInfo)
	{
		throw null;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000145F4 File Offset: 0x000127F4
	[global::Cpp2ILInjected.Token(Token = "0x6000006")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AA97F8", Offset = "0x1AA97F8", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "NewGuid", ReturnType = typeof(global::System.Guid))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = "GenerateGlobalSeed", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = ".cctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RandomNumberGenerator), Member = "FillSpan", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	internal unsafe static void GetRandomBytes(byte* buffer, int length)
	{
		throw null;
	}

	// Token: 0x0200055A RID: 1370
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	internal enum Error
	{
		// Token: 0x040016D6 RID: 5846
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		SUCCESS,
		// Token: 0x040016D7 RID: 5847
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		E2BIG = 65537,
		// Token: 0x040016D8 RID: 5848
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		EACCES,
		// Token: 0x040016D9 RID: 5849
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		EADDRINUSE,
		// Token: 0x040016DA RID: 5850
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		EADDRNOTAVAIL,
		// Token: 0x040016DB RID: 5851
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		EAFNOSUPPORT,
		// Token: 0x040016DC RID: 5852
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		EAGAIN,
		// Token: 0x040016DD RID: 5853
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		EALREADY,
		// Token: 0x040016DE RID: 5854
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		EBADF,
		// Token: 0x040016DF RID: 5855
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		EBADMSG,
		// Token: 0x040016E0 RID: 5856
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		EBUSY,
		// Token: 0x040016E1 RID: 5857
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		ECANCELED,
		// Token: 0x040016E2 RID: 5858
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		ECHILD,
		// Token: 0x040016E3 RID: 5859
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		ECONNABORTED,
		// Token: 0x040016E4 RID: 5860
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		ECONNREFUSED,
		// Token: 0x040016E5 RID: 5861
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		ECONNRESET,
		// Token: 0x040016E6 RID: 5862
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		EDEADLK,
		// Token: 0x040016E7 RID: 5863
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		EDESTADDRREQ,
		// Token: 0x040016E8 RID: 5864
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		EDOM,
		// Token: 0x040016E9 RID: 5865
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		EDQUOT,
		// Token: 0x040016EA RID: 5866
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		EEXIST,
		// Token: 0x040016EB RID: 5867
		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		EFAULT,
		// Token: 0x040016EC RID: 5868
		[global::Cpp2ILInjected.Token(Token = "0x4000018")]
		EFBIG,
		// Token: 0x040016ED RID: 5869
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		EHOSTUNREACH,
		// Token: 0x040016EE RID: 5870
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		EIDRM,
		// Token: 0x040016EF RID: 5871
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		EILSEQ,
		// Token: 0x040016F0 RID: 5872
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		EINPROGRESS,
		// Token: 0x040016F1 RID: 5873
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		EINTR,
		// Token: 0x040016F2 RID: 5874
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		EINVAL,
		// Token: 0x040016F3 RID: 5875
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		EIO,
		// Token: 0x040016F4 RID: 5876
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		EISCONN,
		// Token: 0x040016F5 RID: 5877
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		EISDIR,
		// Token: 0x040016F6 RID: 5878
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		ELOOP,
		// Token: 0x040016F7 RID: 5879
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		EMFILE,
		// Token: 0x040016F8 RID: 5880
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		EMLINK,
		// Token: 0x040016F9 RID: 5881
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		EMSGSIZE,
		// Token: 0x040016FA RID: 5882
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		EMULTIHOP,
		// Token: 0x040016FB RID: 5883
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		ENAMETOOLONG,
		// Token: 0x040016FC RID: 5884
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		ENETDOWN,
		// Token: 0x040016FD RID: 5885
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		ENETRESET,
		// Token: 0x040016FE RID: 5886
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		ENETUNREACH,
		// Token: 0x040016FF RID: 5887
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		ENFILE,
		// Token: 0x04001700 RID: 5888
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		ENOBUFS,
		// Token: 0x04001701 RID: 5889
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		ENODEV = 65580,
		// Token: 0x04001702 RID: 5890
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		ENOENT,
		// Token: 0x04001703 RID: 5891
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		ENOEXEC,
		// Token: 0x04001704 RID: 5892
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		ENOLCK,
		// Token: 0x04001705 RID: 5893
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		ENOLINK,
		// Token: 0x04001706 RID: 5894
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		ENOMEM,
		// Token: 0x04001707 RID: 5895
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		ENOMSG,
		// Token: 0x04001708 RID: 5896
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		ENOPROTOOPT,
		// Token: 0x04001709 RID: 5897
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		ENOSPC,
		// Token: 0x0400170A RID: 5898
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		ENOSYS = 65591,
		// Token: 0x0400170B RID: 5899
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		ENOTCONN,
		// Token: 0x0400170C RID: 5900
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		ENOTDIR,
		// Token: 0x0400170D RID: 5901
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		ENOTEMPTY,
		// Token: 0x0400170E RID: 5902
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		ENOTSOCK = 65596,
		// Token: 0x0400170F RID: 5903
		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		ENOTSUP,
		// Token: 0x04001710 RID: 5904
		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		ENOTTY,
		// Token: 0x04001711 RID: 5905
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		ENXIO,
		// Token: 0x04001712 RID: 5906
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		EOVERFLOW,
		// Token: 0x04001713 RID: 5907
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		EPERM = 65602,
		// Token: 0x04001714 RID: 5908
		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		EPIPE,
		// Token: 0x04001715 RID: 5909
		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		EPROTO,
		// Token: 0x04001716 RID: 5910
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		EPROTONOSUPPORT,
		// Token: 0x04001717 RID: 5911
		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		EPROTOTYPE,
		// Token: 0x04001718 RID: 5912
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		ERANGE,
		// Token: 0x04001719 RID: 5913
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		EROFS,
		// Token: 0x0400171A RID: 5914
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		ESPIPE,
		// Token: 0x0400171B RID: 5915
		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		ESRCH,
		// Token: 0x0400171C RID: 5916
		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		ESTALE,
		// Token: 0x0400171D RID: 5917
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		ETIMEDOUT = 65613,
		// Token: 0x0400171E RID: 5918
		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		ETXTBSY,
		// Token: 0x0400171F RID: 5919
		[global::Cpp2ILInjected.Token(Token = "0x400004B")]
		EXDEV,
		// Token: 0x04001720 RID: 5920
		[global::Cpp2ILInjected.Token(Token = "0x400004C")]
		ESOCKTNOSUPPORT = 65630,
		// Token: 0x04001721 RID: 5921
		[global::Cpp2ILInjected.Token(Token = "0x400004D")]
		EPFNOSUPPORT = 65632,
		// Token: 0x04001722 RID: 5922
		[global::Cpp2ILInjected.Token(Token = "0x400004E")]
		ESHUTDOWN = 65644,
		// Token: 0x04001723 RID: 5923
		[global::Cpp2ILInjected.Token(Token = "0x400004F")]
		EHOSTDOWN = 65648,
		// Token: 0x04001724 RID: 5924
		[global::Cpp2ILInjected.Token(Token = "0x4000050")]
		ENODATA,
		// Token: 0x04001725 RID: 5925
		[global::Cpp2ILInjected.Token(Token = "0x4000051")]
		EOPNOTSUPP = 65597,
		// Token: 0x04001726 RID: 5926
		[global::Cpp2ILInjected.Token(Token = "0x4000052")]
		EWOULDBLOCK = 65542
	}

	// Token: 0x0200055B RID: 1371
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	internal struct ErrorInfo
	{
		// Token: 0x06003EF0 RID: 16112 RVA: 0x0001F814 File Offset: 0x0001DA14
		[global::Cpp2ILInjected.Token(Token = "0x6000007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9860", Offset = "0x1AA9860", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "GetLastErrorInfo", ReturnType = typeof(global::Interop.ErrorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "EnsureStatInitialized", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "FindNextEntry", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal unsafe ErrorInfo(int errno)
		{
			throw null;
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x0001F817 File Offset: 0x0001DA17
		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA98CC", Offset = "0x1AA98CC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystemInfo), Member = "ThrowNotFound", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal ErrorInfo(global::Interop.Error error)
		{
			throw null;
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x0001F81A File Offset: 0x0001DA1A
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		internal global::Interop.Error Error
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000009")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA98D8", Offset = "0x1AA98D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06003EF3 RID: 16115 RVA: 0x0001F81D File Offset: 0x0001DA1D
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		internal int RawErrno
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA9728", Offset = "0x1AA9728", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.ErrorInfo), Member = "GetErrorMessage", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.ErrorInfo), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
			{
				typeof(global::Interop.ErrorInfo),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "GetIOException", MemberParameters = new object[] { typeof(global::Interop.ErrorInfo) }, ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "Refresh", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "InternalContinueOnError", MemberParameters = new object[]
			{
				typeof(global::Interop.ErrorInfo),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "ConvertErrorPalToPlatform", MemberParameters = new object[] { typeof(global::Interop.Error) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0001F820 File Offset: 0x0001DA20
		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9794", Offset = "0x1AA9794", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.ErrorInfo), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "GetIOException", MemberParameters = new object[] { typeof(global::Interop.ErrorInfo) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = "get_RawErrno", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "StrError", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal string GetErrorMessage()
		{
			throw null;
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0001F823 File Offset: 0x0001DA23
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9A58", Offset = "0x1AA9A58", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = "get_RawErrno", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = "GetErrorMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04001727 RID: 5927
		[global::Cpp2ILInjected.Token(Token = "0x4000053")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::Interop.Error _error;

		// Token: 0x04001728 RID: 5928
		[global::Cpp2ILInjected.Token(Token = "0x4000054")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int _rawErrno;
	}

	// Token: 0x0200055C RID: 1372
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	internal static class Sys
	{
		// Token: 0x06003EF6 RID: 16118 RVA: 0x0001F826 File Offset: 0x0001DA26
		[global::Cpp2ILInjected.Token(Token = "0x600000D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA95AC", Offset = "0x1AA95AC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop), Member = "CheckIo", MemberParameters = new object[]
		{
			typeof(long),
			typeof(string),
			typeof(bool),
			typeof(global::System.Func<global::Interop.ErrorInfo, global::Interop.ErrorInfo>)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "EnumerateFilesRecursively", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Predicate<string>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "Refresh", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CopyDanglingSymlink", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "LinkOrCopyFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "DeleteFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "FileExists", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(ref global::Interop.ErrorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "CreateDirectoryHandle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.ErrorInfo), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static global::Interop.ErrorInfo GetLastErrorInfo()
		{
			throw null;
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0001F829 File Offset: 0x0001DA29
		[global::Cpp2ILInjected.Token(Token = "0x600000E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA995C", Offset = "0x1AA995C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.ErrorInfo), Member = "GetErrorMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "PtrToStringAnsi", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal unsafe static string StrError(int platformErrno)
		{
			throw null;
		}

		// Token: 0x06003EF8 RID: 16120
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA98C8", Offset = "0x1AA98C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern global::Interop.Error ConvertErrorPlatformToPal(int platformErrno);

		// Token: 0x06003EF9 RID: 16121
		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA98E0", Offset = "0x1AA98E0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.ErrorInfo), Member = "get_RawErrno", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int ConvertErrorPalToPlatform(global::Interop.Error error);

		// Token: 0x06003EFA RID: 16122
		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9B2C", Offset = "0x1AA9B2C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private unsafe static extern byte* StrErrorR(int platformErrno, byte* buffer, int bufferSize);

		// Token: 0x06003EFB RID: 16123
		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA985C", Offset = "0x1AA985C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal unsafe static extern void GetNonCryptographicallySecureRandomBytes(byte* buffer, int length);

		// Token: 0x06003EFC RID: 16124
		[global::Cpp2ILInjected.Token(Token = "0x6000013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9B30", Offset = "0x1AA9B30", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "EnumerateFilesRecursively", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Predicate<string>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "CreateDirectoryHandle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern global::System.IntPtr OpenDir(string path);

		// Token: 0x06003EFD RID: 16125
		[global::Cpp2ILInjected.Token(Token = "0x6000014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9B64", Offset = "0x1AA9B64", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "EnumerateFilesRecursively", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Predicate<string>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.EnumerationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int GetReadDirRBufferSize();

		// Token: 0x06003EFE RID: 16126
		[global::Cpp2ILInjected.Token(Token = "0x6000015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9B68", Offset = "0x1AA9B68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "EnumerateFilesRecursively", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Predicate<string>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "FindNextEntry", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal unsafe static extern int ReadDirR(global::System.IntPtr dir, byte* buffer, int bufferSize, out global::Interop.Sys.DirectoryEntry outputEntry);

		// Token: 0x06003EFF RID: 16127
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9B6C", Offset = "0x1AA9B6C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "EnumerateFilesRecursively", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Predicate<string>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEnumerator<>), Member = "CloseDirectoryHandle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int CloseDir(global::System.IntPtr dir);

		// Token: 0x06003F00 RID: 16128
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9B88", Offset = "0x1AA9B88", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "ReadLink", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern int ReadLink(string path, byte[] buffer, int bufferSize);

		// Token: 0x06003F01 RID: 16129 RVA: 0x0001F82C File Offset: 0x0001DA2C
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9BD4", Offset = "0x1AA9BD4", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "FindTimeZoneIdUsingReadLink", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CopyDanglingSymlink", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "ReadLink", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static string ReadLink(string path)
		{
			throw null;
		}

		// Token: 0x06003F02 RID: 16130
		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9DB8", Offset = "0x1AA9DB8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "EnumerateFilesRecursively", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Predicate<string>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CopyDanglingSymlink", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int Stat(string path, out global::Interop.Sys.FileStatus output);

		// Token: 0x06003F03 RID: 16131
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9DF4", Offset = "0x1AA9DF4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CopyDanglingSymlink", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "MoveFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int LStat(string path, out global::Interop.Sys.FileStatus output);

		// Token: 0x06003F04 RID: 16132
		[global::Cpp2ILInjected.Token(Token = "0x600001B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9E30", Offset = "0x1AA9E30", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CopyDanglingSymlink", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int Symlink(string target, string linkPath);

		// Token: 0x06003F05 RID: 16133
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9EE8", Offset = "0x1AA9EE8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int ChMod(string path, int mode);

		// Token: 0x06003F06 RID: 16134
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9F24", Offset = "0x1AA9F24", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CopyFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int CopyFile(Microsoft.Win32.SafeHandles.SafeFileHandle source, Microsoft.Win32.SafeHandles.SafeFileHandle destination);

		// Token: 0x06003F07 RID: 16135
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9FD8", Offset = "0x1AA9FD8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "IsReadOnly", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern uint GetEGid();

		// Token: 0x06003F08 RID: 16136
		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9FDC", Offset = "0x1AA9FDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "IsReadOnly", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern uint GetEUid();

		// Token: 0x06003F09 RID: 16137
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9FE0", Offset = "0x1AA9FE0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int LChflags(string path, uint flags);

		// Token: 0x06003F0A RID: 16138
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA080", Offset = "0x1AAA080", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern int LChflagsCanSetHiddenFlag();

		// Token: 0x06003F0B RID: 16139
		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA084", Offset = "0x1AAA084", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "LinkOrCopyFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int Link(string source, string link);

		// Token: 0x06003F0C RID: 16140
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA0D8", Offset = "0x1AAA0D8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int MkDir(string path, int mode);

		// Token: 0x06003F0D RID: 16141
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA114", Offset = "0x1AAA114", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "MoveFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int Rename(string oldPath, string newPath);

		// Token: 0x06003F0E RID: 16142
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA168", Offset = "0x1AAA168", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int Stat(ref byte path, out global::Interop.Sys.FileStatus output);

		// Token: 0x06003F0F RID: 16143 RVA: 0x0001F82F File Offset: 0x0001DA2F
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA184", Offset = "0x1AAA184", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "Refresh", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "FileExists", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(ref global::Interop.ErrorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEntry), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ref global::System.IO.Enumeration.FileSystemEntry),
			typeof(global::Interop.Sys.DirectoryEntry),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>)
		}, ReturnType = typeof(global::System.IO.FileAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueUtf8Converter), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueUtf8Converter), Member = "ConvertAndTerminateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.Span<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueUtf8Converter), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static int Stat(global::System.ReadOnlySpan<char> path, out global::Interop.Sys.FileStatus output)
		{
			throw null;
		}

		// Token: 0x06003F10 RID: 16144
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA2DC", Offset = "0x1AAA2DC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int LStat(ref byte path, out global::Interop.Sys.FileStatus output);

		// Token: 0x06003F11 RID: 16145 RVA: 0x0001F832 File Offset: 0x0001DA32
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA2F8", Offset = "0x1AAA2F8", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "Refresh", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "FileExists", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(ref global::Interop.ErrorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEntry), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ref global::System.IO.Enumeration.FileSystemEntry),
			typeof(global::Interop.Sys.DirectoryEntry),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>)
		}, ReturnType = typeof(global::System.IO.FileAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueUtf8Converter), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueUtf8Converter), Member = "ConvertAndTerminateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.Span<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.ValueUtf8Converter), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static int LStat(global::System.ReadOnlySpan<char> path, out global::Interop.Sys.FileStatus output)
		{
			throw null;
		}

		// Token: 0x06003F12 RID: 16146
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA450", Offset = "0x1AAA450", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "DeleteFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int Unlink(string pathname);

		// Token: 0x06003F13 RID: 16147
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA484", Offset = "0x1AAA484", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "DoubleToNumber", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int),
			typeof(ref global::System.Number.NumberBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern int DoubleToString(double value, byte* format, byte* buffer, int bufferLength);

		// Token: 0x06003F14 RID: 16148 RVA: 0x0001F835 File Offset: 0x0001DA35
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA488", Offset = "0x1AAA488", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static Sys()
		{
			throw null;
		}

		// Token: 0x04001729 RID: 5929
		[global::Cpp2ILInjected.Token(Token = "0x4000055")]
		internal static readonly bool CanSetHiddenFlag;

		// Token: 0x020006A2 RID: 1698
		[global::Cpp2ILInjected.Token(Token = "0x2000006")]
		internal enum NodeType
		{
			// Token: 0x04001AF3 RID: 6899
			[global::Cpp2ILInjected.Token(Token = "0x4000057")]
			DT_UNKNOWN,
			// Token: 0x04001AF4 RID: 6900
			[global::Cpp2ILInjected.Token(Token = "0x4000058")]
			DT_FIFO,
			// Token: 0x04001AF5 RID: 6901
			[global::Cpp2ILInjected.Token(Token = "0x4000059")]
			DT_CHR,
			// Token: 0x04001AF6 RID: 6902
			[global::Cpp2ILInjected.Token(Token = "0x400005A")]
			DT_DIR = 4,
			// Token: 0x04001AF7 RID: 6903
			[global::Cpp2ILInjected.Token(Token = "0x400005B")]
			DT_BLK = 6,
			// Token: 0x04001AF8 RID: 6904
			[global::Cpp2ILInjected.Token(Token = "0x400005C")]
			DT_REG = 8,
			// Token: 0x04001AF9 RID: 6905
			[global::Cpp2ILInjected.Token(Token = "0x400005D")]
			DT_LNK = 10,
			// Token: 0x04001AFA RID: 6906
			[global::Cpp2ILInjected.Token(Token = "0x400005E")]
			DT_SOCK = 12,
			// Token: 0x04001AFB RID: 6907
			[global::Cpp2ILInjected.Token(Token = "0x400005F")]
			DT_WHT = 14
		}

		// Token: 0x020006A3 RID: 1699
		[global::Cpp2ILInjected.Token(Token = "0x2000007")]
		internal struct DirectoryEntry
		{
			// Token: 0x0600435D RID: 17245 RVA: 0x0002046B File Offset: 0x0001E66B
			[global::Cpp2ILInjected.Token(Token = "0x600002C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAA4DC", Offset = "0x1AAA4DC", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDirectoryEntryFullPath", MemberParameters = new object[]
			{
				typeof(ref global::Interop.Sys.DirectoryEntry),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemEntry), Member = "get_FileName", ReturnType = typeof(global::System.ReadOnlySpan<char>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal global::System.ReadOnlySpan<char> GetName(global::System.Span<char> buffer)
			{
				throw null;
			}

			// Token: 0x04001AFC RID: 6908
			[global::Cpp2ILInjected.Token(Token = "0x4000060")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal unsafe byte* Name;

			// Token: 0x04001AFD RID: 6909
			[global::Cpp2ILInjected.Token(Token = "0x4000061")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int NameLength;

			// Token: 0x04001AFE RID: 6910
			[global::Cpp2ILInjected.Token(Token = "0x4000062")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal global::Interop.Sys.NodeType InodeType;
		}

		// Token: 0x020006A4 RID: 1700
		[global::Cpp2ILInjected.Token(Token = "0x2000008")]
		internal struct FileStatus
		{
			// Token: 0x04001AFF RID: 6911
			[global::Cpp2ILInjected.Token(Token = "0x4000063")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal global::Interop.Sys.FileStatusFlags Flags;

			// Token: 0x04001B00 RID: 6912
			[global::Cpp2ILInjected.Token(Token = "0x4000064")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			internal int Mode;

			// Token: 0x04001B01 RID: 6913
			[global::Cpp2ILInjected.Token(Token = "0x4000065")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal uint Uid;

			// Token: 0x04001B02 RID: 6914
			[global::Cpp2ILInjected.Token(Token = "0x4000066")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal uint Gid;

			// Token: 0x04001B03 RID: 6915
			[global::Cpp2ILInjected.Token(Token = "0x4000067")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal long Size;

			// Token: 0x04001B04 RID: 6916
			[global::Cpp2ILInjected.Token(Token = "0x4000068")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal long ATime;

			// Token: 0x04001B05 RID: 6917
			[global::Cpp2ILInjected.Token(Token = "0x4000069")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal long ATimeNsec;

			// Token: 0x04001B06 RID: 6918
			[global::Cpp2ILInjected.Token(Token = "0x400006A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal long MTime;

			// Token: 0x04001B07 RID: 6919
			[global::Cpp2ILInjected.Token(Token = "0x400006B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal long MTimeNsec;

			// Token: 0x04001B08 RID: 6920
			[global::Cpp2ILInjected.Token(Token = "0x400006C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal long CTime;

			// Token: 0x04001B09 RID: 6921
			[global::Cpp2ILInjected.Token(Token = "0x400006D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			internal long CTimeNsec;

			// Token: 0x04001B0A RID: 6922
			[global::Cpp2ILInjected.Token(Token = "0x400006E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			internal long BirthTime;

			// Token: 0x04001B0B RID: 6923
			[global::Cpp2ILInjected.Token(Token = "0x400006F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			internal long BirthTimeNsec;

			// Token: 0x04001B0C RID: 6924
			[global::Cpp2ILInjected.Token(Token = "0x4000070")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal long Dev;

			// Token: 0x04001B0D RID: 6925
			[global::Cpp2ILInjected.Token(Token = "0x4000071")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			internal long Ino;

			// Token: 0x04001B0E RID: 6926
			[global::Cpp2ILInjected.Token(Token = "0x4000072")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			internal uint UserFlags;
		}

		// Token: 0x020006A5 RID: 1701
		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000009")]
		internal enum FileStatusFlags
		{
			// Token: 0x04001B10 RID: 6928
			[global::Cpp2ILInjected.Token(Token = "0x4000074")]
			None = 0,
			// Token: 0x04001B11 RID: 6929
			[global::Cpp2ILInjected.Token(Token = "0x4000075")]
			HasBirthTime = 1
		}

		// Token: 0x020006A6 RID: 1702
		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x200000A")]
		internal enum Permissions
		{
			// Token: 0x04001B13 RID: 6931
			[global::Cpp2ILInjected.Token(Token = "0x4000077")]
			Mask = 511,
			// Token: 0x04001B14 RID: 6932
			[global::Cpp2ILInjected.Token(Token = "0x4000078")]
			S_IRWXU = 448,
			// Token: 0x04001B15 RID: 6933
			[global::Cpp2ILInjected.Token(Token = "0x4000079")]
			S_IRUSR = 256,
			// Token: 0x04001B16 RID: 6934
			[global::Cpp2ILInjected.Token(Token = "0x400007A")]
			S_IWUSR = 128,
			// Token: 0x04001B17 RID: 6935
			[global::Cpp2ILInjected.Token(Token = "0x400007B")]
			S_IXUSR = 64,
			// Token: 0x04001B18 RID: 6936
			[global::Cpp2ILInjected.Token(Token = "0x400007C")]
			S_IRWXG = 56,
			// Token: 0x04001B19 RID: 6937
			[global::Cpp2ILInjected.Token(Token = "0x400007D")]
			S_IRGRP = 32,
			// Token: 0x04001B1A RID: 6938
			[global::Cpp2ILInjected.Token(Token = "0x400007E")]
			S_IWGRP = 16,
			// Token: 0x04001B1B RID: 6939
			[global::Cpp2ILInjected.Token(Token = "0x400007F")]
			S_IXGRP = 8,
			// Token: 0x04001B1C RID: 6940
			[global::Cpp2ILInjected.Token(Token = "0x4000080")]
			S_IRWXO = 7,
			// Token: 0x04001B1D RID: 6941
			[global::Cpp2ILInjected.Token(Token = "0x4000081")]
			S_IROTH = 4,
			// Token: 0x04001B1E RID: 6942
			[global::Cpp2ILInjected.Token(Token = "0x4000082")]
			S_IWOTH = 2,
			// Token: 0x04001B1F RID: 6943
			[global::Cpp2ILInjected.Token(Token = "0x4000083")]
			S_IXOTH = 1
		}
	}
}
