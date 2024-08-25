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

[global::Cpp2ILInjected.Token(Token = "0x2000002")]
internal static class Interop
{
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

	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	internal enum Error
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		SUCCESS,
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		E2BIG = 65537,
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		EACCES,
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		EADDRINUSE,
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		EADDRNOTAVAIL,
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		EAFNOSUPPORT,
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		EAGAIN,
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		EALREADY,
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		EBADF,
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		EBADMSG,
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		EBUSY,
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		ECANCELED,
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		ECHILD,
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		ECONNABORTED,
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		ECONNREFUSED,
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		ECONNRESET,
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		EDEADLK,
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		EDESTADDRREQ,
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		EDOM,
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		EDQUOT,
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		EEXIST,
		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		EFAULT,
		[global::Cpp2ILInjected.Token(Token = "0x4000018")]
		EFBIG,
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		EHOSTUNREACH,
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		EIDRM,
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		EILSEQ,
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		EINPROGRESS,
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		EINTR,
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		EINVAL,
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		EIO,
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		EISCONN,
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		EISDIR,
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		ELOOP,
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		EMFILE,
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		EMLINK,
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		EMSGSIZE,
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		EMULTIHOP,
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		ENAMETOOLONG,
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		ENETDOWN,
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		ENETRESET,
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		ENETUNREACH,
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		ENFILE,
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		ENOBUFS,
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		ENODEV = 65580,
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		ENOENT,
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		ENOEXEC,
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		ENOLCK,
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		ENOLINK,
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		ENOMEM,
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		ENOMSG,
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		ENOPROTOOPT,
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		ENOSPC,
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		ENOSYS = 65591,
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		ENOTCONN,
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		ENOTDIR,
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		ENOTEMPTY,
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		ENOTSOCK = 65596,
		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		ENOTSUP,
		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		ENOTTY,
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		ENXIO,
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		EOVERFLOW,
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		EPERM = 65602,
		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		EPIPE,
		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		EPROTO,
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		EPROTONOSUPPORT,
		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		EPROTOTYPE,
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		ERANGE,
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		EROFS,
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		ESPIPE,
		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		ESRCH,
		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		ESTALE,
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		ETIMEDOUT = 65613,
		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		ETXTBSY,
		[global::Cpp2ILInjected.Token(Token = "0x400004B")]
		EXDEV,
		[global::Cpp2ILInjected.Token(Token = "0x400004C")]
		ESOCKTNOSUPPORT = 65630,
		[global::Cpp2ILInjected.Token(Token = "0x400004D")]
		EPFNOSUPPORT = 65632,
		[global::Cpp2ILInjected.Token(Token = "0x400004E")]
		ESHUTDOWN = 65644,
		[global::Cpp2ILInjected.Token(Token = "0x400004F")]
		EHOSTDOWN = 65648,
		[global::Cpp2ILInjected.Token(Token = "0x4000050")]
		ENODATA,
		[global::Cpp2ILInjected.Token(Token = "0x4000051")]
		EOPNOTSUPP = 65597,
		[global::Cpp2ILInjected.Token(Token = "0x4000052")]
		EWOULDBLOCK = 65542
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	internal struct ErrorInfo
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA98CC", Offset = "0x1AA98CC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystemInfo), Member = "ThrowNotFound", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal ErrorInfo(global::Interop.Error error)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000053")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::Interop.Error _error;

		[global::Cpp2ILInjected.Token(Token = "0x4000054")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int _rawErrno;
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	internal static class Sys
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA98C8", Offset = "0x1AA98C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern global::Interop.Error ConvertErrorPlatformToPal(int platformErrno);

		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA98E0", Offset = "0x1AA98E0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.ErrorInfo), Member = "get_RawErrno", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int ConvertErrorPalToPlatform(global::Interop.Error error);

		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9B2C", Offset = "0x1AA9B2C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private unsafe static extern byte* StrErrorR(int platformErrno, byte* buffer, int bufferSize);

		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA985C", Offset = "0x1AA985C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal unsafe static extern void GetNonCryptographicallySecureRandomBytes(byte* buffer, int length);

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

		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA9B88", Offset = "0x1AA9B88", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "ReadLink", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern int ReadLink(string path, byte[] buffer, int bufferSize);

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

		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA080", Offset = "0x1AAA080", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern int LChflagsCanSetHiddenFlag();

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

		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA0D8", Offset = "0x1AAA0D8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int MkDir(string path, int mode);

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

		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA168", Offset = "0x1AAA168", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int Stat(ref byte path, out global::Interop.Sys.FileStatus output);

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

		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA2DC", Offset = "0x1AAA2DC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int LStat(ref byte path, out global::Interop.Sys.FileStatus output);

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

		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAA450", Offset = "0x1AAA450", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileSystem), Member = "DeleteFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[global::System.Runtime.InteropServices.PreserveSig]
		internal static extern int Unlink(string pathname);

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

		[global::Cpp2ILInjected.Token(Token = "0x4000055")]
		internal static readonly bool CanSetHiddenFlag;

		[global::Cpp2ILInjected.Token(Token = "0x2000006")]
		internal enum NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000057")]
			DT_UNKNOWN,
			[global::Cpp2ILInjected.Token(Token = "0x4000058")]
			DT_FIFO,
			[global::Cpp2ILInjected.Token(Token = "0x4000059")]
			DT_CHR,
			[global::Cpp2ILInjected.Token(Token = "0x400005A")]
			DT_DIR = 4,
			[global::Cpp2ILInjected.Token(Token = "0x400005B")]
			DT_BLK = 6,
			[global::Cpp2ILInjected.Token(Token = "0x400005C")]
			DT_REG = 8,
			[global::Cpp2ILInjected.Token(Token = "0x400005D")]
			DT_LNK = 10,
			[global::Cpp2ILInjected.Token(Token = "0x400005E")]
			DT_SOCK = 12,
			[global::Cpp2ILInjected.Token(Token = "0x400005F")]
			DT_WHT = 14
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000007")]
		internal struct DirectoryEntry
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x4000060")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal unsafe byte* Name;

			[global::Cpp2ILInjected.Token(Token = "0x4000061")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int NameLength;

			[global::Cpp2ILInjected.Token(Token = "0x4000062")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal global::Interop.Sys.NodeType InodeType;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000008")]
		internal struct FileStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000063")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal global::Interop.Sys.FileStatusFlags Flags;

			[global::Cpp2ILInjected.Token(Token = "0x4000064")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			internal int Mode;

			[global::Cpp2ILInjected.Token(Token = "0x4000065")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal uint Uid;

			[global::Cpp2ILInjected.Token(Token = "0x4000066")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal uint Gid;

			[global::Cpp2ILInjected.Token(Token = "0x4000067")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal long Size;

			[global::Cpp2ILInjected.Token(Token = "0x4000068")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal long ATime;

			[global::Cpp2ILInjected.Token(Token = "0x4000069")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal long ATimeNsec;

			[global::Cpp2ILInjected.Token(Token = "0x400006A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal long MTime;

			[global::Cpp2ILInjected.Token(Token = "0x400006B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal long MTimeNsec;

			[global::Cpp2ILInjected.Token(Token = "0x400006C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal long CTime;

			[global::Cpp2ILInjected.Token(Token = "0x400006D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			internal long CTimeNsec;

			[global::Cpp2ILInjected.Token(Token = "0x400006E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			internal long BirthTime;

			[global::Cpp2ILInjected.Token(Token = "0x400006F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			internal long BirthTimeNsec;

			[global::Cpp2ILInjected.Token(Token = "0x4000070")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal long Dev;

			[global::Cpp2ILInjected.Token(Token = "0x4000071")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			internal long Ino;

			[global::Cpp2ILInjected.Token(Token = "0x4000072")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			internal uint UserFlags;
		}

		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000009")]
		internal enum FileStatusFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000074")]
			None = 0,
			[global::Cpp2ILInjected.Token(Token = "0x4000075")]
			HasBirthTime = 1
		}

		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x200000A")]
		internal enum Permissions
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000077")]
			Mask = 511,
			[global::Cpp2ILInjected.Token(Token = "0x4000078")]
			S_IRWXU = 448,
			[global::Cpp2ILInjected.Token(Token = "0x4000079")]
			S_IRUSR = 256,
			[global::Cpp2ILInjected.Token(Token = "0x400007A")]
			S_IWUSR = 128,
			[global::Cpp2ILInjected.Token(Token = "0x400007B")]
			S_IXUSR = 64,
			[global::Cpp2ILInjected.Token(Token = "0x400007C")]
			S_IRWXG = 56,
			[global::Cpp2ILInjected.Token(Token = "0x400007D")]
			S_IRGRP = 32,
			[global::Cpp2ILInjected.Token(Token = "0x400007E")]
			S_IWGRP = 16,
			[global::Cpp2ILInjected.Token(Token = "0x400007F")]
			S_IXGRP = 8,
			[global::Cpp2ILInjected.Token(Token = "0x4000080")]
			S_IRWXO = 7,
			[global::Cpp2ILInjected.Token(Token = "0x4000081")]
			S_IROTH = 4,
			[global::Cpp2ILInjected.Token(Token = "0x4000082")]
			S_IWOTH = 2,
			[global::Cpp2ILInjected.Token(Token = "0x4000083")]
			S_IXOTH = 1
		}
	}
}
