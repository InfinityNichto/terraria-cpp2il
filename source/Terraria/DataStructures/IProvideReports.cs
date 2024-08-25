using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200062D")]
	public interface IProvideReports
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003621")]
		List<IssueReport> GetReports();
	}
}
