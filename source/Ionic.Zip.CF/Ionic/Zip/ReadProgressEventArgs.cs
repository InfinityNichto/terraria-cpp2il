using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x0200000A RID: 10
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public class ReadProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00004EF7 File Offset: 0x000030F7
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45010", Offset = "0x1A45010", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		internal ReadProgressEventArgs()
		{
			throw null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004EFA File Offset: 0x000030FA
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45014", Offset = "0x1A45014", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		private ReadProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
			throw null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004EFD File Offset: 0x000030FD
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45018", Offset = "0x1A45018", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnReadEntry", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ZipEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ReadProgressEventArgs Before(string archiveName, int entriesTotal)
		{
			throw null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004F00 File Offset: 0x00003100
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45084", Offset = "0x1A45084", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnReadEntry", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ZipEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ReadProgressEventArgs After(string archiveName, ZipEntry entry, int entriesTotal)
		{
			throw null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004F03 File Offset: 0x00003103
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A450F8", Offset = "0x1A450F8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnReadStarted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ReadProgressEventArgs Started(string archiveName)
		{
			throw null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004F06 File Offset: 0x00003106
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45154", Offset = "0x1A45154", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnReadBytes", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ReadProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
		{
			throw null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004F09 File Offset: 0x00003109
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A451D4", Offset = "0x1A451D4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnReadCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ReadProgressEventArgs Completed(string archiveName)
		{
			throw null;
		}
	}
}
