using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000435")]
public interface IProvideReports
{
	[Cpp2IlInjected.Token(Token = "0x6003140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	List<IssueReport> GetReports();
}
