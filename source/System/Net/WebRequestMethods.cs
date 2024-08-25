using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001DB")]
	public static class WebRequestMethods
	{
		[global::Cpp2ILInjected.Token(Token = "0x20001DC")]
		public static class Ftp
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000A07")]
			public const string DownloadFile = "RETR";

			[global::Cpp2ILInjected.Token(Token = "0x4000A08")]
			public const string ListDirectory = "NLST";

			[global::Cpp2ILInjected.Token(Token = "0x4000A09")]
			public const string UploadFile = "STOR";

			[global::Cpp2ILInjected.Token(Token = "0x4000A0A")]
			public const string DeleteFile = "DELE";

			[global::Cpp2ILInjected.Token(Token = "0x4000A0B")]
			public const string AppendFile = "APPE";

			[global::Cpp2ILInjected.Token(Token = "0x4000A0C")]
			public const string GetFileSize = "SIZE";

			[global::Cpp2ILInjected.Token(Token = "0x4000A0D")]
			public const string UploadFileWithUniqueName = "STOU";

			[global::Cpp2ILInjected.Token(Token = "0x4000A0E")]
			public const string MakeDirectory = "MKD";

			[global::Cpp2ILInjected.Token(Token = "0x4000A0F")]
			public const string RemoveDirectory = "RMD";

			[global::Cpp2ILInjected.Token(Token = "0x4000A10")]
			public const string ListDirectoryDetails = "LIST";

			[global::Cpp2ILInjected.Token(Token = "0x4000A11")]
			public const string GetDateTimestamp = "MDTM";

			[global::Cpp2ILInjected.Token(Token = "0x4000A12")]
			public const string PrintWorkingDirectory = "PWD";

			[global::Cpp2ILInjected.Token(Token = "0x4000A13")]
			public const string Rename = "RENAME";
		}

		[global::Cpp2ILInjected.Token(Token = "0x20001DD")]
		public static class Http
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000A14")]
			public const string Get = "GET";

			[global::Cpp2ILInjected.Token(Token = "0x4000A15")]
			public const string Connect = "CONNECT";

			[global::Cpp2ILInjected.Token(Token = "0x4000A16")]
			public const string Head = "HEAD";

			[global::Cpp2ILInjected.Token(Token = "0x4000A17")]
			public const string Put = "PUT";

			[global::Cpp2ILInjected.Token(Token = "0x4000A18")]
			public const string Post = "POST";

			[global::Cpp2ILInjected.Token(Token = "0x4000A19")]
			public const string MkCol = "MKCOL";
		}

		[global::Cpp2ILInjected.Token(Token = "0x20001DE")]
		public static class File
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000A1A")]
			public const string DownloadFile = "GET";

			[global::Cpp2ILInjected.Token(Token = "0x4000A1B")]
			public const string UploadFile = "PUT";
		}
	}
}
