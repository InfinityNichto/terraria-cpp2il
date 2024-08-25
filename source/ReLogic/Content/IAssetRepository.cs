using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B4A")]
	public interface IAssetRepository : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000920")]
		int PendingAssets
		{
			[global::Cpp2ILInjected.Token(Token = "0x600540E")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000921")]
		int TotalAssets
		{
			[global::Cpp2ILInjected.Token(Token = "0x600540F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000922")]
		int LoadedAssets
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005410")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005411")]
		void SetSources(IEnumerable<IContentSource> sources, AssetRequestMode mode = AssetRequestMode.ImmediateLoad);

		[global::Cpp2ILInjected.Token(Token = "0x6005412")]
		Asset<T> Request<T>(string assetName, AssetRequestMode mode = AssetRequestMode.ImmediateLoad) where T : class;

		[global::Cpp2ILInjected.Token(Token = "0x6005413")]
		void TransferCompletedAssets();

		[global::Cpp2ILInjected.Token(Token = "0x6005414")]
		void ProcessAsyncLoad();
	}
}
