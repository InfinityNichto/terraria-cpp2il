using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x0200000D RID: 13
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	public class ExtractProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00004F30 File Offset: 0x00003130
		[global::Cpp2ILInjected.Token(Token = "0x6000038")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A454F8", Offset = "0x1A454F8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		internal ExtractProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesExtracted, ZipEntry entry, string extractLocation)
		{
			throw null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004F33 File Offset: 0x00003133
		[global::Cpp2ILInjected.Token(Token = "0x6000039")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45548", Offset = "0x1A45548", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		internal ExtractProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
			throw null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004F36 File Offset: 0x00003136
		[global::Cpp2ILInjected.Token(Token = "0x600003A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4554C", Offset = "0x1A4554C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		internal ExtractProgressEventArgs()
		{
			throw null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004F39 File Offset: 0x00003139
		[global::Cpp2ILInjected.Token(Token = "0x600003B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45550", Offset = "0x1A45550", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnSingleEntryExtract", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ExtractProgressEventArgs BeforeExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
		{
			throw null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004F3C File Offset: 0x0000313C
		[global::Cpp2ILInjected.Token(Token = "0x600003C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A455C8", Offset = "0x1A455C8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnExtractExisting", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ExtractProgressEventArgs ExtractExisting(string archiveName, ZipEntry entry, string extractLocation)
		{
			throw null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004F3F File Offset: 0x0000313F
		[global::Cpp2ILInjected.Token(Token = "0x600003D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45640", Offset = "0x1A45640", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnSingleEntryExtract", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ExtractProgressEventArgs AfterExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
		{
			throw null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004F42 File Offset: 0x00003142
		[global::Cpp2ILInjected.Token(Token = "0x600003E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A456B8", Offset = "0x1A456B8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnExtractAllStarted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ExtractProgressEventArgs ExtractAllStarted(string archiveName, string extractLocation)
		{
			throw null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004F45 File Offset: 0x00003145
		[global::Cpp2ILInjected.Token(Token = "0x600003F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45724", Offset = "0x1A45724", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnExtractAllCompleted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ExtractProgressEventArgs ExtractAllCompleted(string archiveName, string extractLocation)
		{
			throw null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004F48 File Offset: 0x00003148
		[global::Cpp2ILInjected.Token(Token = "0x6000040")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45790", Offset = "0x1A45790", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnExtractBlock", MemberParameters = new object[]
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
		internal static ExtractProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesWritten, long totalBytes)
		{
			throw null;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00004F4B File Offset: 0x0000314B
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public int EntriesExtracted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000041")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A45814", Offset = "0x1A45814", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00004F4E File Offset: 0x0000314E
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public string ExtractLocation
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000042")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4581C", Offset = "0x1A4581C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _entriesExtracted;

		// Token: 0x04000027 RID: 39
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string _target;
	}
}
