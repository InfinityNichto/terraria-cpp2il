using System;
using Cpp2ILInjected;

namespace System.Net
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200014F")]
	internal enum FtpMethodFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x40006AE")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40006AF")]
		IsDownload = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40006B0")]
		IsUpload = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40006B1")]
		TakesParameter = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40006B2")]
		MayTakeParameter = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40006B3")]
		DoesNotTakeParameter = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40006B4")]
		ParameterIsDirectory = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40006B5")]
		ShouldParseForResponseUri = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40006B6")]
		HasHttpCommand = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40006B7")]
		MustChangeWorkingDirectoryToPath = 256
	}
}
