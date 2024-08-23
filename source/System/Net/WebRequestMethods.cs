using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x0200014D RID: 333
	[global::Cpp2ILInjected.Token(Token = "0x20001DB")]
	public static class WebRequestMethods
	{
		// Token: 0x020003F6 RID: 1014
		[global::Cpp2ILInjected.Token(Token = "0x20001DC")]
		public static class Ftp
		{
			// Token: 0x040011D8 RID: 4568
			[global::Cpp2ILInjected.Token(Token = "0x4000A07")]
			public const string DownloadFile = "RETR";

			// Token: 0x040011D9 RID: 4569
			[global::Cpp2ILInjected.Token(Token = "0x4000A08")]
			public const string ListDirectory = "NLST";

			// Token: 0x040011DA RID: 4570
			[global::Cpp2ILInjected.Token(Token = "0x4000A09")]
			public const string UploadFile = "STOR";

			// Token: 0x040011DB RID: 4571
			[global::Cpp2ILInjected.Token(Token = "0x4000A0A")]
			public const string DeleteFile = "DELE";

			// Token: 0x040011DC RID: 4572
			[global::Cpp2ILInjected.Token(Token = "0x4000A0B")]
			public const string AppendFile = "APPE";

			// Token: 0x040011DD RID: 4573
			[global::Cpp2ILInjected.Token(Token = "0x4000A0C")]
			public const string GetFileSize = "SIZE";

			// Token: 0x040011DE RID: 4574
			[global::Cpp2ILInjected.Token(Token = "0x4000A0D")]
			public const string UploadFileWithUniqueName = "STOU";

			// Token: 0x040011DF RID: 4575
			[global::Cpp2ILInjected.Token(Token = "0x4000A0E")]
			public const string MakeDirectory = "MKD";

			// Token: 0x040011E0 RID: 4576
			[global::Cpp2ILInjected.Token(Token = "0x4000A0F")]
			public const string RemoveDirectory = "RMD";

			// Token: 0x040011E1 RID: 4577
			[global::Cpp2ILInjected.Token(Token = "0x4000A10")]
			public const string ListDirectoryDetails = "LIST";

			// Token: 0x040011E2 RID: 4578
			[global::Cpp2ILInjected.Token(Token = "0x4000A11")]
			public const string GetDateTimestamp = "MDTM";

			// Token: 0x040011E3 RID: 4579
			[global::Cpp2ILInjected.Token(Token = "0x4000A12")]
			public const string PrintWorkingDirectory = "PWD";

			// Token: 0x040011E4 RID: 4580
			[global::Cpp2ILInjected.Token(Token = "0x4000A13")]
			public const string Rename = "RENAME";
		}

		// Token: 0x020003F7 RID: 1015
		[global::Cpp2ILInjected.Token(Token = "0x20001DD")]
		public static class Http
		{
			// Token: 0x040011E5 RID: 4581
			[global::Cpp2ILInjected.Token(Token = "0x4000A14")]
			public const string Get = "GET";

			// Token: 0x040011E6 RID: 4582
			[global::Cpp2ILInjected.Token(Token = "0x4000A15")]
			public const string Connect = "CONNECT";

			// Token: 0x040011E7 RID: 4583
			[global::Cpp2ILInjected.Token(Token = "0x4000A16")]
			public const string Head = "HEAD";

			// Token: 0x040011E8 RID: 4584
			[global::Cpp2ILInjected.Token(Token = "0x4000A17")]
			public const string Put = "PUT";

			// Token: 0x040011E9 RID: 4585
			[global::Cpp2ILInjected.Token(Token = "0x4000A18")]
			public const string Post = "POST";

			// Token: 0x040011EA RID: 4586
			[global::Cpp2ILInjected.Token(Token = "0x4000A19")]
			public const string MkCol = "MKCOL";
		}

		// Token: 0x020003F8 RID: 1016
		[global::Cpp2ILInjected.Token(Token = "0x20001DE")]
		public static class File
		{
			// Token: 0x040011EB RID: 4587
			[global::Cpp2ILInjected.Token(Token = "0x4000A1A")]
			public const string DownloadFile = "GET";

			// Token: 0x040011EC RID: 4588
			[global::Cpp2ILInjected.Token(Token = "0x4000A1B")]
			public const string UploadFile = "PUT";
		}
	}
}
