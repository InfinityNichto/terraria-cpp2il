using System;
using Cpp2ILInjected;

namespace ReLogic.Content
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B3B")]
	public interface IContentValidator
	{
		[global::Cpp2ILInjected.Token(Token = "0x60053D3")]
		bool AssetIsValid<T>(T content, string contentPath, out IRejectionReason rejectionReason) where T : class;
	}
}
