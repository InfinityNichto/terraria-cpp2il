using System;
using Cpp2ILInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B49")]
	public interface IAssetLoader
	{
		[global::Cpp2ILInjected.Token(Token = "0x600540D")]
		bool TryLoad<T>(string assetName, IContentSource source, out T resultAsset) where T : class;
	}
}
