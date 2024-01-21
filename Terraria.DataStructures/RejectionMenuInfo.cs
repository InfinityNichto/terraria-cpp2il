using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000473")]
public class RejectionMenuInfo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006423")]
	public ReturnFromRejectionMenuAction ExitAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006424")]
	public string TextToShow;

	[Cpp2IlInjected.Token(Token = "0x600322C")]
	[Cpp2IlInjected.Address(RVA = "0x122E514", Offset = "0x122E514", VA = "0x122E514")]
	public void DefaultExitAction()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600322D")]
	[Cpp2IlInjected.Address(RVA = "0x122E5C4", Offset = "0x122E5C4", VA = "0x122E5C4")]
	public RejectionMenuInfo()
	{
	}
}
