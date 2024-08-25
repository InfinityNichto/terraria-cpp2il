using System;
using Cpp2ILInjected;
using Ionic.Zlib;

namespace Ionic.Zip
{
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	public delegate CompressionLevel SetCompressionCallback(string localFileName, string fileNameInArchive);
}
