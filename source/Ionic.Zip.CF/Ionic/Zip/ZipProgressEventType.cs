using System;
using Cpp2ILInjected;

namespace Ionic.Zip
{
	[global::Cpp2ILInjected.Token(Token = "0x2000008")]
	public enum ZipProgressEventType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		Adding_Started,
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		Adding_AfterAddEntry,
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		Adding_Completed,
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		Reading_Started,
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		Reading_BeforeReadEntry,
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		Reading_AfterReadEntry,
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		Reading_Completed,
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		Reading_ArchiveBytesRead,
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		Saving_Started,
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		Saving_BeforeWriteEntry,
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		Saving_AfterWriteEntry,
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		Saving_Completed,
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		Saving_AfterSaveTempArchive,
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		Saving_BeforeRenameTempArchive,
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		Saving_AfterRenameTempArchive,
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		Saving_AfterCompileSelfExtractor,
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		Saving_EntryBytesRead,
		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		Extracting_BeforeExtractEntry,
		[global::Cpp2ILInjected.Token(Token = "0x4000018")]
		Extracting_AfterExtractEntry,
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		Extracting_ExtractEntryWouldOverwrite,
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		Extracting_EntryBytesWritten,
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		Extracting_BeforeExtractAll,
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		Extracting_AfterExtractAll,
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		Error_Saving
	}
}
