using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;

namespace ReLogic.Content.Sources;

[Cpp2IlInjected.Token(Token = "0x200074F")]
public interface IContentSource
{
	[Cpp2IlInjected.Token(Token = "0x17000824")]
	IContentValidator ContentValidator
	{
		[Cpp2IlInjected.Token(Token = "0x60047AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60047AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60047AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HasAsset(string assetName);

	[Cpp2IlInjected.Token(Token = "0x60047AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string GetExtension(string assetName);

	[Cpp2IlInjected.Token(Token = "0x60047AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Stream OpenStream(string assetName);

	[Cpp2IlInjected.Token(Token = "0x60047B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void RejectAsset(string assetName, IRejectionReason reason);

	[Cpp2IlInjected.Token(Token = "0x60047B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ClearRejections();

	[Cpp2IlInjected.Token(Token = "0x60047B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool TryGetRejections(List<string> rejectionReasons);
}
