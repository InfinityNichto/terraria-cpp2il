using System.Collections.Generic;
using Cpp2IlInjected;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x2000741")]
public class RejectedAssetCollection
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007359")]
	private Dictionary<string, IRejectionReason> _rejectedAssetsAndReasons;

	[Cpp2IlInjected.Token(Token = "0x600475F")]
	[Cpp2IlInjected.Address(RVA = "0x10BEC84", Offset = "0x10BEC84", VA = "0x10BEC84")]
	public void Reject(string assetPath, IRejectionReason reason)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004760")]
	[Cpp2IlInjected.Address(RVA = "0x10BECF0", Offset = "0x10BECF0", VA = "0x10BECF0")]
	public bool IsRejected(string assetPath)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004761")]
	[Cpp2IlInjected.Address(RVA = "0x10BED54", Offset = "0x10BED54", VA = "0x10BED54")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004762")]
	[Cpp2IlInjected.Address(RVA = "0x10BEDB0", Offset = "0x10BEDB0", VA = "0x10BEDB0")]
	public bool TryGetRejections(List<string> rejectionReasons)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004763")]
	[Cpp2IlInjected.Address(RVA = "0x10BEF90", Offset = "0x10BEF90", VA = "0x10BEF90")]
	public RejectedAssetCollection()
	{
	}
}
