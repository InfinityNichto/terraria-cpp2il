using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;

namespace ReLogic.Content.Sources
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B4E")]
	public interface IContentSource
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000927")]
		IContentValidator ContentValidator
		{
			[global::Cpp2ILInjected.Token(Token = "0x600542A")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600542B")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600542C")]
		bool HasAsset(string assetName);

		[global::Cpp2ILInjected.Token(Token = "0x600542D")]
		string GetExtension(string assetName);

		[global::Cpp2ILInjected.Token(Token = "0x600542E")]
		Stream OpenStream(string assetName);

		[global::Cpp2ILInjected.Token(Token = "0x600542F")]
		void RejectAsset(string assetName, IRejectionReason reason);

		[global::Cpp2ILInjected.Token(Token = "0x6005430")]
		void ClearRejections();

		[global::Cpp2ILInjected.Token(Token = "0x6005431")]
		bool TryGetRejections(List<string> rejectionReasons);
	}
}
