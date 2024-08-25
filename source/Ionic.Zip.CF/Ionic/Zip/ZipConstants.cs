using System;
using Cpp2ILInjected;

namespace Ionic.Zip
{
	[global::Cpp2ILInjected.Token(Token = "0x2000019")]
	internal static class ZipConstants
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		public const uint PackedToRemovableMedia = 808471376U;

		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		public const uint Zip64EndOfCentralDirectoryRecordSignature = 101075792U;

		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		public const uint Zip64EndOfCentralDirectoryLocatorSignature = 117853008U;

		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		public const uint EndOfCentralDirectorySignature = 101010256U;

		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		public const int ZipEntrySignature = 67324752;

		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		public const int ZipEntryDataDescriptorSignature = 134695760;

		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		public const int SplitArchiveSignature = 134695760;

		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		public const int ZipDirEntrySignature = 33639248;

		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		public const int AesKeySize = 192;

		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		public const int AesBlockSize = 128;

		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		public const ushort AesAlgId128 = 26126;

		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		public const ushort AesAlgId192 = 26127;

		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		public const ushort AesAlgId256 = 26128;
	}
}
