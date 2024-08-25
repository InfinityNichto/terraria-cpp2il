using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200062F")]
	public class GeneralIssueReporter : IProvideReports
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003623")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCA14", Offset = "0x13DCA14", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IssueReport), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void AddReport(string textToShow)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003624")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCAE8", Offset = "0x13DCAE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public List<IssueReport> GetReports()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003625")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCAF0", Offset = "0x13DCAF0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public GeneralIssueReporter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<IssueReport> _reports;
	}
}
