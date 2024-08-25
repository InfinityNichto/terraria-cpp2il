using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public class ZipProgressEventArgs : EventArgs
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A44F18", Offset = "0x1A44F18", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadProgressEventArgs), Member = "Before", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(ReadProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadProgressEventArgs), Member = "After", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(int)
		}, ReturnType = typeof(ReadProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadProgressEventArgs), Member = "Started", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ReadProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadProgressEventArgs), Member = "ByteUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(ReadProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadProgressEventArgs), Member = "Completed", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ReadProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AddProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AddProgressEventArgs), Member = "AfterEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(int)
		}, ReturnType = typeof(AddProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AddProgressEventArgs), Member = "Started", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(AddProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AddProgressEventArgs), Member = "Completed", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(AddProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(ZipEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveProgressEventArgs), Member = "ByteUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(SaveProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveProgressEventArgs), Member = "Started", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SaveProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveProgressEventArgs), Member = "Completed", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SaveProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtractProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtractProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtractProgressEventArgs), Member = "ExtractAllStarted", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtractProgressEventArgs), Member = "ExtractAllCompleted", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtractProgressEventArgs), Member = "ByteUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnSaveEntry", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ZipEntry),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnSaveEvent", MemberParameters = new object[] { typeof(ZipProgressEventType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnExtractEntry", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ZipProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _entriesTotal;

		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool _cancel;

		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ZipEntry _latestEntry;

		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ZipProgressEventType _flavor;

		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _archiveName;

		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long _bytesTransferred;

		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private long _totalBytesToTransfer;
	}
}
