using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x20004F2")]
	public static class CrashDump
	{
		[global::Cpp2ILInjected.Token(Token = "0x60030AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF61C", Offset = "0x12FF61C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool WriteException(CrashDump.Options options, string outputDirectory = ".")
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF62C", Offset = "0x12FF62C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool Write(CrashDump.Options options, string outputDirectory = ".")
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF634", Offset = "0x12FF634", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static string CreateDumpName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF624", Offset = "0x12FF624", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool Write(CrashDump.Options options, CrashDump.ExceptionInfo exceptionInfo, string outputDirectory)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF894", Offset = "0x12FF894", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool Write(SafeHandle fileHandle, CrashDump.Options options, CrashDump.ExceptionInfo exceptionInfo)
		{
			throw null;
		}

		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x20004F3")]
		public enum Options : uint
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003AA7")]
			Normal = 0U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AA8")]
			WithDataSegs = 1U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AA9")]
			WithFullMemory = 2U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AAA")]
			WithHandleData = 4U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AAB")]
			FilterMemory = 8U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AAC")]
			ScanMemory = 16U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AAD")]
			WithUnloadedModules = 32U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AAE")]
			WithIndirectlyReferencedMemory = 64U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AAF")]
			FilterModulePaths = 128U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AB0")]
			WithProcessThreadData = 256U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AB1")]
			WithPrivateReadWriteMemory = 512U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AB2")]
			WithoutOptionalData = 1024U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AB3")]
			WithFullMemoryInfo = 2048U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AB4")]
			WithThreadInfo = 4096U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AB5")]
			WithCodeSegs = 8192U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AB6")]
			WithoutAuxiliaryState = 16384U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AB7")]
			WithFullAuxiliaryState = 32768U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AB8")]
			WithPrivateWriteCopyMemory = 65536U,
			[global::Cpp2ILInjected.Token(Token = "0x4003AB9")]
			IgnoreInaccessibleMemory = 131072U,
			[global::Cpp2ILInjected.Token(Token = "0x4003ABA")]
			ValidTypeFlags = 262143U
		}

		[global::Cpp2ILInjected.Token(Token = "0x20004F4")]
		private enum ExceptionInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003ABC")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4003ABD")]
			Present
		}

		[global::Cpp2ILInjected.Token(Token = "0x20004F5")]
		[StructLayout(0, Pack = 4, Size = 16)]
		private struct MiniDumpExceptionInformation
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003ABE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public uint ThreadId;

			[global::Cpp2ILInjected.Token(Token = "0x4003ABF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public IntPtr ExceptionPointers;

			[global::Cpp2ILInjected.Token(Token = "0x4003AC0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public bool ClientPointers;
		}
	}
}
