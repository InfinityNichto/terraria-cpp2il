using System;
using Cpp2ILInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000749 RID: 1865
	[global::Cpp2ILInjected.Token(Token = "0x2000B4B")]
	public interface IAsyncAssetLoader : IDisposable
	{
		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06004757 RID: 18263
		[global::Cpp2ILInjected.Token(Token = "0x17000923")]
		bool IsRunning
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005415")]
			get;
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06004758 RID: 18264
		[global::Cpp2ILInjected.Token(Token = "0x17000924")]
		int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005416")]
			get;
		}

		// Token: 0x06004759 RID: 18265
		[global::Cpp2ILInjected.Token(Token = "0x6005417")]
		void Start();

		// Token: 0x0600475A RID: 18266
		[global::Cpp2ILInjected.Token(Token = "0x6005418")]
		void Stop();

		// Token: 0x0600475B RID: 18267
		[global::Cpp2ILInjected.Token(Token = "0x6005419")]
		void Load<T>(string assetName, IContentSource source, LoadAssetDelegate<T> callback) where T : class;

		// Token: 0x0600475C RID: 18268
		[global::Cpp2ILInjected.Token(Token = "0x600541A")]
		void TransferCompleted();
	}
}
