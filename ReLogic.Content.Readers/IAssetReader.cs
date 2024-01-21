using System.IO;
using Cpp2IlInjected;

namespace ReLogic.Content.Readers;

[Cpp2IlInjected.Token(Token = "0x2000753")]
public interface IAssetReader
{
	[Cpp2IlInjected.Token(Token = "0x60047D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T FromStream<T>(Stream stream) where T : class;
}
