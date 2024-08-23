using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x0200000C RID: 12
	[global::Cpp2ILInjected.Token(Token = "0x200000C")]
	public class SaveProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00004F1B File Offset: 0x0000311B
		[global::Cpp2ILInjected.Token(Token = "0x6000031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45364", Offset = "0x1A45364", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		internal SaveProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesSaved, ZipEntry entry)
		{
			throw null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004F1E File Offset: 0x0000311E
		[global::Cpp2ILInjected.Token(Token = "0x6000032")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A453AC", Offset = "0x1A453AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		internal SaveProgressEventArgs()
		{
			throw null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004F21 File Offset: 0x00003121
		[global::Cpp2ILInjected.Token(Token = "0x6000033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A453B0", Offset = "0x1A453B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		internal SaveProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
			throw null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004F24 File Offset: 0x00003124
		[global::Cpp2ILInjected.Token(Token = "0x6000034")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A453B4", Offset = "0x1A453B4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnSaveBlock", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static SaveProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
		{
			throw null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004F27 File Offset: 0x00003127
		[global::Cpp2ILInjected.Token(Token = "0x6000035")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45438", Offset = "0x1A45438", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnSaveStarted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static SaveProgressEventArgs Started(string archiveName)
		{
			throw null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004F2A File Offset: 0x0000312A
		[global::Cpp2ILInjected.Token(Token = "0x6000036")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45494", Offset = "0x1A45494", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnSaveCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static SaveProgressEventArgs Completed(string archiveName)
		{
			throw null;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00004F2D File Offset: 0x0000312D
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public int EntriesSaved
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000037")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A454F0", Offset = "0x1A454F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000025 RID: 37
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _entriesSaved;
	}
}
