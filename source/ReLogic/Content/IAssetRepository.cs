using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000748 RID: 1864
	[global::Cpp2ILInjected.Token(Token = "0x2000B4A")]
	public interface IAssetRepository : IDisposable
	{
		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06004750 RID: 18256
		[global::Cpp2ILInjected.Token(Token = "0x17000920")]
		int PendingAssets
		{
			[global::Cpp2ILInjected.Token(Token = "0x600540E")]
			get;
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06004751 RID: 18257
		[global::Cpp2ILInjected.Token(Token = "0x17000921")]
		int TotalAssets
		{
			[global::Cpp2ILInjected.Token(Token = "0x600540F")]
			get;
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06004752 RID: 18258
		[global::Cpp2ILInjected.Token(Token = "0x17000922")]
		int LoadedAssets
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005410")]
			get;
		}

		// Token: 0x06004753 RID: 18259
		[global::Cpp2ILInjected.Token(Token = "0x6005411")]
		void SetSources(IEnumerable<IContentSource> sources, AssetRequestMode mode = AssetRequestMode.ImmediateLoad);

		// Token: 0x06004754 RID: 18260
		[global::Cpp2ILInjected.Token(Token = "0x6005412")]
		Asset<T> Request<T>(string assetName, AssetRequestMode mode = AssetRequestMode.ImmediateLoad) where T : class;

		// Token: 0x06004755 RID: 18261
		[global::Cpp2ILInjected.Token(Token = "0x6005413")]
		void TransferCompletedAssets();

		// Token: 0x06004756 RID: 18262
		[global::Cpp2ILInjected.Token(Token = "0x6005414")]
		void ProcessAsyncLoad();
	}
}
