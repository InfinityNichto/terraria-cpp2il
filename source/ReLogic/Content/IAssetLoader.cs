using System;
using Cpp2ILInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000747 RID: 1863
	[global::Cpp2ILInjected.Token(Token = "0x2000B49")]
	public interface IAssetLoader
	{
		// Token: 0x0600474F RID: 18255
		[global::Cpp2ILInjected.Token(Token = "0x600540D")]
		bool TryLoad<T>(string assetName, IContentSource source, out T resultAsset) where T : class;
	}
}
