using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005AC")]
public class SmartInteractSystem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B4B")]
	private List<ISmartInteractCandidateProvider> _candidateProvidersByOrderOfPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B4C")]
	private List<ISmartInteractBlockReasonProvider> _blockProviders;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006B4D")]
	private List<ISmartInteractCandidate> _candidates;

	[Cpp2IlInjected.Token(Token = "0x6003C33")]
	[Cpp2IlInjected.Address(RVA = "0x11947B4", Offset = "0x11947B4", VA = "0x11947B4")]
	public SmartInteractSystem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C34")]
	[Cpp2IlInjected.Address(RVA = "0x1194A58", Offset = "0x1194A58", VA = "0x1194A58")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C35")]
	[Cpp2IlInjected.Address(RVA = "0x1194BE8", Offset = "0x1194BE8", VA = "0x1194BE8")]
	public void RunQuery(SmartInteractScanSettings settings)
	{
	}
}
