using System;
using System.IO;
using Cpp2ILInjected;

namespace ReLogic.Content.Readers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B52")]
	public interface IAssetReader
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005458")]
		T FromStream<T>(Stream stream) where T : class;
	}
}
