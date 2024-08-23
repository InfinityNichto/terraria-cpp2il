using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;

namespace ReLogic.Content.Sources
{
	// Token: 0x0200074C RID: 1868
	[global::Cpp2ILInjected.Token(Token = "0x2000B4E")]
	public interface IContentSource
	{
		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600476C RID: 18284
		// (set) Token: 0x0600476D RID: 18285
		[global::Cpp2ILInjected.Token(Token = "0x17000927")]
		IContentValidator ContentValidator
		{
			[global::Cpp2ILInjected.Token(Token = "0x600542A")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600542B")]
			set;
		}

		// Token: 0x0600476E RID: 18286
		[global::Cpp2ILInjected.Token(Token = "0x600542C")]
		bool HasAsset(string assetName);

		// Token: 0x0600476F RID: 18287
		[global::Cpp2ILInjected.Token(Token = "0x600542D")]
		string GetExtension(string assetName);

		// Token: 0x06004770 RID: 18288
		[global::Cpp2ILInjected.Token(Token = "0x600542E")]
		Stream OpenStream(string assetName);

		// Token: 0x06004771 RID: 18289
		[global::Cpp2ILInjected.Token(Token = "0x600542F")]
		void RejectAsset(string assetName, IRejectionReason reason);

		// Token: 0x06004772 RID: 18290
		[global::Cpp2ILInjected.Token(Token = "0x6005430")]
		void ClearRejections();

		// Token: 0x06004773 RID: 18291
		[global::Cpp2ILInjected.Token(Token = "0x6005431")]
		bool TryGetRejections(List<string> rejectionReasons);
	}
}
