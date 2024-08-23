using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Utilities
{
	// Token: 0x02000371 RID: 881
	[global::Cpp2ILInjected.Token(Token = "0x20004F2")]
	public static class CrashDump
	{
		// Token: 0x06002C9C RID: 11420 RVA: 0x00029FF9 File Offset: 0x000281F9
		[global::Cpp2ILInjected.Token(Token = "0x60030AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF61C", Offset = "0x12FF61C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool WriteException(CrashDump.Options options, string outputDirectory = ".")
		{
			throw null;
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00029FFC File Offset: 0x000281FC
		[global::Cpp2ILInjected.Token(Token = "0x60030AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF62C", Offset = "0x12FF62C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool Write(CrashDump.Options options, string outputDirectory = ".")
		{
			throw null;
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x00029FFF File Offset: 0x000281FF
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

		// Token: 0x06002C9F RID: 11423 RVA: 0x0002A002 File Offset: 0x00028202
		[global::Cpp2ILInjected.Token(Token = "0x60030AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF624", Offset = "0x12FF624", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool Write(CrashDump.Options options, CrashDump.ExceptionInfo exceptionInfo, string outputDirectory)
		{
			throw null;
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x0002A005 File Offset: 0x00028205
		[global::Cpp2ILInjected.Token(Token = "0x60030AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF894", Offset = "0x12FF894", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool Write(SafeHandle fileHandle, CrashDump.Options options, CrashDump.ExceptionInfo exceptionInfo)
		{
			throw null;
		}

		// Token: 0x020008D3 RID: 2259
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x20004F3")]
		public enum Options : uint
		{
			// Token: 0x040080CA RID: 32970
			[global::Cpp2ILInjected.Token(Token = "0x4003AA7")]
			Normal = 0U,
			// Token: 0x040080CB RID: 32971
			[global::Cpp2ILInjected.Token(Token = "0x4003AA8")]
			WithDataSegs = 1U,
			// Token: 0x040080CC RID: 32972
			[global::Cpp2ILInjected.Token(Token = "0x4003AA9")]
			WithFullMemory = 2U,
			// Token: 0x040080CD RID: 32973
			[global::Cpp2ILInjected.Token(Token = "0x4003AAA")]
			WithHandleData = 4U,
			// Token: 0x040080CE RID: 32974
			[global::Cpp2ILInjected.Token(Token = "0x4003AAB")]
			FilterMemory = 8U,
			// Token: 0x040080CF RID: 32975
			[global::Cpp2ILInjected.Token(Token = "0x4003AAC")]
			ScanMemory = 16U,
			// Token: 0x040080D0 RID: 32976
			[global::Cpp2ILInjected.Token(Token = "0x4003AAD")]
			WithUnloadedModules = 32U,
			// Token: 0x040080D1 RID: 32977
			[global::Cpp2ILInjected.Token(Token = "0x4003AAE")]
			WithIndirectlyReferencedMemory = 64U,
			// Token: 0x040080D2 RID: 32978
			[global::Cpp2ILInjected.Token(Token = "0x4003AAF")]
			FilterModulePaths = 128U,
			// Token: 0x040080D3 RID: 32979
			[global::Cpp2ILInjected.Token(Token = "0x4003AB0")]
			WithProcessThreadData = 256U,
			// Token: 0x040080D4 RID: 32980
			[global::Cpp2ILInjected.Token(Token = "0x4003AB1")]
			WithPrivateReadWriteMemory = 512U,
			// Token: 0x040080D5 RID: 32981
			[global::Cpp2ILInjected.Token(Token = "0x4003AB2")]
			WithoutOptionalData = 1024U,
			// Token: 0x040080D6 RID: 32982
			[global::Cpp2ILInjected.Token(Token = "0x4003AB3")]
			WithFullMemoryInfo = 2048U,
			// Token: 0x040080D7 RID: 32983
			[global::Cpp2ILInjected.Token(Token = "0x4003AB4")]
			WithThreadInfo = 4096U,
			// Token: 0x040080D8 RID: 32984
			[global::Cpp2ILInjected.Token(Token = "0x4003AB5")]
			WithCodeSegs = 8192U,
			// Token: 0x040080D9 RID: 32985
			[global::Cpp2ILInjected.Token(Token = "0x4003AB6")]
			WithoutAuxiliaryState = 16384U,
			// Token: 0x040080DA RID: 32986
			[global::Cpp2ILInjected.Token(Token = "0x4003AB7")]
			WithFullAuxiliaryState = 32768U,
			// Token: 0x040080DB RID: 32987
			[global::Cpp2ILInjected.Token(Token = "0x4003AB8")]
			WithPrivateWriteCopyMemory = 65536U,
			// Token: 0x040080DC RID: 32988
			[global::Cpp2ILInjected.Token(Token = "0x4003AB9")]
			IgnoreInaccessibleMemory = 131072U,
			// Token: 0x040080DD RID: 32989
			[global::Cpp2ILInjected.Token(Token = "0x4003ABA")]
			ValidTypeFlags = 262143U
		}

		// Token: 0x020008D4 RID: 2260
		[global::Cpp2ILInjected.Token(Token = "0x20004F4")]
		private enum ExceptionInfo
		{
			// Token: 0x040080DF RID: 32991
			[global::Cpp2ILInjected.Token(Token = "0x4003ABC")]
			None,
			// Token: 0x040080E0 RID: 32992
			[global::Cpp2ILInjected.Token(Token = "0x4003ABD")]
			Present
		}

		// Token: 0x020008D5 RID: 2261
		[global::Cpp2ILInjected.Token(Token = "0x20004F5")]
		[StructLayout(0, Pack = 4, Size = 16)]
		private struct MiniDumpExceptionInformation
		{
			// Token: 0x040080E1 RID: 32993
			[global::Cpp2ILInjected.Token(Token = "0x4003ABE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public uint ThreadId;

			// Token: 0x040080E2 RID: 32994
			[global::Cpp2ILInjected.Token(Token = "0x4003ABF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public IntPtr ExceptionPointers;

			// Token: 0x040080E3 RID: 32995
			[global::Cpp2ILInjected.Token(Token = "0x4003AC0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public bool ClientPointers;
		}
	}
}
