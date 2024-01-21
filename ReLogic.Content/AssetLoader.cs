using Cpp2IlInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x200073E")]
public class AssetLoader : IAssetLoader
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007358")]
	private readonly AssetReaderCollection _readers;

	[Cpp2IlInjected.Token(Token = "0x600475B")]
	[Cpp2IlInjected.Address(RVA = "0x10BD458", Offset = "0x10BD458", VA = "0x10BD458")]
	public AssetLoader(AssetReaderCollection readers)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600475C")]
	[Cpp2IlInjected.Address(RVA = "0x16784FC", Offset = "0x16784FC", VA = "0x16784FC", Slot = "4")]
	public bool TryLoad<T>(string assetName, IContentSource source, out T resultAsset) where T : class
	{
		return default(bool);
	}
}
