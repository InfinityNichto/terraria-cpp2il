using System;
using Cpp2ILInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000746 RID: 1862
	[global::Cpp2ILInjected.Token(Token = "0x2000B48")]
	public interface IAsset : IDisposable
	{
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06004749 RID: 18249
		[global::Cpp2ILInjected.Token(Token = "0x1700091B")]
		AssetState State
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005407")]
			get;
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600474A RID: 18250
		[global::Cpp2ILInjected.Token(Token = "0x1700091C")]
		IContentSource Source
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005408")]
			get;
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x0600474B RID: 18251
		[global::Cpp2ILInjected.Token(Token = "0x1700091D")]
		string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005409")]
			get;
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x0600474C RID: 18252
		[global::Cpp2ILInjected.Token(Token = "0x1700091E")]
		bool IsLoaded
		{
			[global::Cpp2ILInjected.Token(Token = "0x600540A")]
			get;
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x0600474D RID: 18253
		[global::Cpp2ILInjected.Token(Token = "0x1700091F")]
		bool IsDisposed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600540B")]
			get;
		}

		// Token: 0x0600474E RID: 18254
		[global::Cpp2ILInjected.Token(Token = "0x600540C")]
		void ActionUnityLoad();
	}
}
