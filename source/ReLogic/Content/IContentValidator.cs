using System;
using Cpp2ILInjected;

namespace ReLogic.Content
{
	// Token: 0x0200073B RID: 1851
	[global::Cpp2ILInjected.Token(Token = "0x2000B3B")]
	public interface IContentValidator
	{
		// Token: 0x0600471A RID: 18202
		[global::Cpp2ILInjected.Token(Token = "0x60053D3")]
		bool AssetIsValid<T>(T content, string contentPath, out IRejectionReason rejectionReason) where T : class;
	}
}
