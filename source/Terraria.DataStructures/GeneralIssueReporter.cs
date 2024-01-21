using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000437")]
public class GeneralIssueReporter : IProvideReports
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062FF")]
	private List<IssueReport> _reports;

	[Cpp2IlInjected.Token(Token = "0x6003142")]
	[Cpp2IlInjected.Address(RVA = "0x1013E44", Offset = "0x1013E44", VA = "0x1013E44")]
	public void AddReport(string textToShow)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003143")]
	[Cpp2IlInjected.Address(RVA = "0x1013F6C", Offset = "0x1013F6C", VA = "0x1013F6C", Slot = "4")]
	public List<IssueReport> GetReports()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003144")]
	[Cpp2IlInjected.Address(RVA = "0x1013F74", Offset = "0x1013F74", VA = "0x1013F74")]
	public GeneralIssueReporter()
	{
	}
}
