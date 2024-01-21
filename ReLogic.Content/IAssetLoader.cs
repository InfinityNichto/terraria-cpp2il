using Cpp2IlInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x200074A")]
public interface IAssetLoader
{
	[Cpp2IlInjected.Token(Token = "0x600478E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryLoad<T>(string assetName, IContentSource source, out T resultAsset) where T : class;
}
