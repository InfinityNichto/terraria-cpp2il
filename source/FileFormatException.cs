using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;
using Terraria.Localization;

[global::Cpp2ILInjected.Token(Token = "0x2000068")]
public class FileFormatException : Exception
{
	[global::Cpp2ILInjected.Token(Token = "0x6000232")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D320", Offset = "0x70D320", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "LoadFilesForCulture", MemberParameters = new object[] { typeof(GameCulture) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(FileType)
	}, ReturnType = typeof(FileMetadata))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public FileFormatException(string exceptionReason)
	{
		throw null;
	}
}
