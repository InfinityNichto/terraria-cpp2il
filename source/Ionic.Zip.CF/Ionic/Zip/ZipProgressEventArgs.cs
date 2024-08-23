using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x02000009 RID: 9
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public class ZipProgressEventArgs : EventArgs
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00004EC7 File Offset: 0x000030C7
		[global::Cpp2ILInjected.Token(Token = "0x6000015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A44EC0", Offset = "0x1A44EC0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AddProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtractProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtractProgressEventArgs), Member = "BeforeExtractEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtractProgressEventArgs), Member = "ExtractExisting", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtractProgressEventArgs), Member = "AfterExtractEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipErrorEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipErrorEventArgs), Member = "Saving", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(Exception)
		}, ReturnType = typeof(ZipErrorEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ZipProgressEventArgs()
		{
			throw null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00004ECA File Offset: 0x000030CA
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A44F18", Offset = "0x1A44F18", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ZipProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
			throw null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00004ECD File Offset: 0x000030CD
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00004ED0 File Offset: 0x000030D0
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public int EntriesTotal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000017")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44F8C", Offset = "0x1A44F8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000018")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44F94", Offset = "0x1A44F94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00004ED3 File Offset: 0x000030D3
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00004ED6 File Offset: 0x000030D6
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public ZipEntry CurrentEntry
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000019")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44F9C", Offset = "0x1A44F9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600001A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44FA4", Offset = "0x1A44FA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00004ED9 File Offset: 0x000030D9
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00004EDC File Offset: 0x000030DC
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public bool Cancel
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44FAC", Offset = "0x1A44FAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600001C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44FB4", Offset = "0x1A44FB4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00004EDF File Offset: 0x000030DF
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00004EE2 File Offset: 0x000030E2
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public ZipProgressEventType EventType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44FD0", Offset = "0x1A44FD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600001E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44FD8", Offset = "0x1A44FD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00004EE5 File Offset: 0x000030E5
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00004EE8 File Offset: 0x000030E8
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public string ArchiveName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44FE0", Offset = "0x1A44FE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000020")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44FE8", Offset = "0x1A44FE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00004EEB File Offset: 0x000030EB
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00004EEE File Offset: 0x000030EE
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public long BytesTransferred
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000021")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44FF0", Offset = "0x1A44FF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000022")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A44FF8", Offset = "0x1A44FF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00004EF1 File Offset: 0x000030F1
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00004EF4 File Offset: 0x000030F4
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		public long TotalBytesToTransfer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000023")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A45000", Offset = "0x1A45000", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000024")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A45008", Offset = "0x1A45008", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _entriesTotal;

		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool _cancel;

		// Token: 0x04000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ZipEntry _latestEntry;

		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ZipProgressEventType _flavor;

		// Token: 0x04000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _archiveName;

		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long _bytesTransferred;

		// Token: 0x04000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private long _totalBytesToTransfer;
	}
}
