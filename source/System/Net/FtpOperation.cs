using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200014E")]
	internal enum FtpOperation
	{
		[global::Cpp2ILInjected.Token(Token = "0x400069F")]
		DownloadFile,
		[global::Cpp2ILInjected.Token(Token = "0x40006A0")]
		ListDirectory,
		[global::Cpp2ILInjected.Token(Token = "0x40006A1")]
		ListDirectoryDetails,
		[global::Cpp2ILInjected.Token(Token = "0x40006A2")]
		UploadFile,
		[global::Cpp2ILInjected.Token(Token = "0x40006A3")]
		UploadFileUnique,
		[global::Cpp2ILInjected.Token(Token = "0x40006A4")]
		AppendFile,
		[global::Cpp2ILInjected.Token(Token = "0x40006A5")]
		DeleteFile,
		[global::Cpp2ILInjected.Token(Token = "0x40006A6")]
		GetDateTimestamp,
		[global::Cpp2ILInjected.Token(Token = "0x40006A7")]
		GetFileSize,
		[global::Cpp2ILInjected.Token(Token = "0x40006A8")]
		Rename,
		[global::Cpp2ILInjected.Token(Token = "0x40006A9")]
		MakeDirectory,
		[global::Cpp2ILInjected.Token(Token = "0x40006AA")]
		RemoveDirectory,
		[global::Cpp2ILInjected.Token(Token = "0x40006AB")]
		PrintWorkingDirectory,
		[global::Cpp2ILInjected.Token(Token = "0x40006AC")]
		Other
	}
}
