using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000374")]
public static class CrashDump
{
	[Cpp2IlInjected.Token(Token = "0x20008CA")]
	[Flags]
	public enum Options : uint
	{
		[Cpp2IlInjected.Token(Token = "0x40080B7")]
		Normal = 0u,
		[Cpp2IlInjected.Token(Token = "0x40080B8")]
		WithDataSegs = 1u,
		[Cpp2IlInjected.Token(Token = "0x40080B9")]
		WithFullMemory = 2u,
		[Cpp2IlInjected.Token(Token = "0x40080BA")]
		WithHandleData = 4u,
		[Cpp2IlInjected.Token(Token = "0x40080BB")]
		FilterMemory = 8u,
		[Cpp2IlInjected.Token(Token = "0x40080BC")]
		ScanMemory = 0x10u,
		[Cpp2IlInjected.Token(Token = "0x40080BD")]
		WithUnloadedModules = 0x20u,
		[Cpp2IlInjected.Token(Token = "0x40080BE")]
		WithIndirectlyReferencedMemory = 0x40u,
		[Cpp2IlInjected.Token(Token = "0x40080BF")]
		FilterModulePaths = 0x80u,
		[Cpp2IlInjected.Token(Token = "0x40080C0")]
		WithProcessThreadData = 0x100u,
		[Cpp2IlInjected.Token(Token = "0x40080C1")]
		WithPrivateReadWriteMemory = 0x200u,
		[Cpp2IlInjected.Token(Token = "0x40080C2")]
		WithoutOptionalData = 0x400u,
		[Cpp2IlInjected.Token(Token = "0x40080C3")]
		WithFullMemoryInfo = 0x800u,
		[Cpp2IlInjected.Token(Token = "0x40080C4")]
		WithThreadInfo = 0x1000u,
		[Cpp2IlInjected.Token(Token = "0x40080C5")]
		WithCodeSegs = 0x2000u,
		[Cpp2IlInjected.Token(Token = "0x40080C6")]
		WithoutAuxiliaryState = 0x4000u,
		[Cpp2IlInjected.Token(Token = "0x40080C7")]
		WithFullAuxiliaryState = 0x8000u,
		[Cpp2IlInjected.Token(Token = "0x40080C8")]
		WithPrivateWriteCopyMemory = 0x10000u,
		[Cpp2IlInjected.Token(Token = "0x40080C9")]
		IgnoreInaccessibleMemory = 0x20000u,
		[Cpp2IlInjected.Token(Token = "0x40080CA")]
		ValidTypeFlags = 0x3FFFFu
	}

	[Cpp2IlInjected.Token(Token = "0x20008CB")]
	private enum ExceptionInfo
	{
		[Cpp2IlInjected.Token(Token = "0x40080CC")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40080CD")]
		Present
	}

	[Cpp2IlInjected.Token(Token = "0x20008CC")]
	private struct MiniDumpExceptionInformation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40080CE")]
		public uint ThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40080CF")]
		public IntPtr ExceptionPointers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40080D0")]
		public bool ClientPointers;
	}

	[Cpp2IlInjected.Token(Token = "0x6002CD3")]
	[Cpp2IlInjected.Address(RVA = "0x10D9408", Offset = "0x10D9408", VA = "0x10D9408")]
	public static bool WriteException(Options options, string outputDirectory = ".")
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CD4")]
	[Cpp2IlInjected.Address(RVA = "0x10D9418", Offset = "0x10D9418", VA = "0x10D9418")]
	public static bool Write(Options options, string outputDirectory = ".")
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CD5")]
	[Cpp2IlInjected.Address(RVA = "0x10D9420", Offset = "0x10D9420", VA = "0x10D9420")]
	private static string CreateDumpName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002CD6")]
	[Cpp2IlInjected.Address(RVA = "0x10D9410", Offset = "0x10D9410", VA = "0x10D9410")]
	private static bool Write(Options options, ExceptionInfo exceptionInfo, string outputDirectory)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CD7")]
	[Cpp2IlInjected.Address(RVA = "0x10D96F0", Offset = "0x10D96F0", VA = "0x10D96F0")]
	private static bool Write(SafeHandle fileHandle, Options options, ExceptionInfo exceptionInfo)
	{
		return default(bool);
	}
}
