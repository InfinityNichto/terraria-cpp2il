using System;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000436")]
public class IssueReport
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062FD")]
	public DateTime timeReported;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40062FE")]
	public string reportText;

	[Cpp2IlInjected.Token(Token = "0x6003141")]
	[Cpp2IlInjected.Address(RVA = "0x1013ECC", Offset = "0x1013ECC", VA = "0x1013ECC")]
	public IssueReport(string reportText)
	{
	}
}
