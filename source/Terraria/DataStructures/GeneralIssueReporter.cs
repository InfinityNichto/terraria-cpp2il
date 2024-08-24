using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000434 RID: 1076
	[global::Cpp2ILInjected.Token(Token = "0x200062F")]
	public class GeneralIssueReporter : IProvideReports
	{
		// Token: 0x06003106 RID: 12550 RVA: 0x0002AC47 File Offset: 0x00028E47
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

		// Token: 0x06003107 RID: 12551 RVA: 0x0002AC4A File Offset: 0x00028E4A
		[global::Cpp2ILInjected.Token(Token = "0x6003624")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCAE8", Offset = "0x13DCAE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public List<IssueReport> GetReports()
		{
			throw null;
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x0002AC4D File Offset: 0x00028E4D
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

		// Token: 0x040062FE RID: 25342
		[global::Cpp2ILInjected.Token(Token = "0x40076E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<IssueReport> _reports;
	}
}
