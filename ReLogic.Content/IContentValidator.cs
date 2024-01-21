using Cpp2IlInjected;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x200073F")]
public interface IContentValidator
{
	[Cpp2IlInjected.Token(Token = "0x600475D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AssetIsValid<T>(T content, string contentPath, out IRejectionReason rejectionReason) where T : class;
}
