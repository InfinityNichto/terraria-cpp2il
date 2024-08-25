using System;
using Cpp2ILInjected;

namespace Ionic.Zip
{
	[global::Cpp2ILInjected.Token(Token = "0x2000025")]
	public enum ZipEntrySource
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000B1")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x40000B2")]
		FileSystem,
		[global::Cpp2ILInjected.Token(Token = "0x40000B3")]
		Stream,
		[global::Cpp2ILInjected.Token(Token = "0x40000B4")]
		ZipFile,
		[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
		WriteDelegate,
		[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
		JitStream,
		[global::Cpp2ILInjected.Token(Token = "0x40000B7")]
		ZipOutputStream
	}
}
