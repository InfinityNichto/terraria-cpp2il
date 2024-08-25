using System;
using Cpp2ILInjected;

namespace ReLogic.OS
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B20")]
	public interface IPathService
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005346")]
		string GetStoragePath();

		[global::Cpp2ILInjected.Token(Token = "0x6005347")]
		string GetStoragePath(string subfolder);

		[global::Cpp2ILInjected.Token(Token = "0x6005348")]
		string ExpandPathVariables(string path);
	}
}
