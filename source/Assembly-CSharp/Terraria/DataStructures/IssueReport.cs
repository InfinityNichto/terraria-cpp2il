using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Base;

namespace Terraria.DataStructures
{
	// Token: 0x02000433 RID: 1075
	[global::Cpp2ILInjected.Token(Token = "0x200062E")]
	public class IssueReport
	{
		// Token: 0x06003105 RID: 12549 RVA: 0x0002AC44 File Offset: 0x00028E44
		[global::Cpp2ILInjected.Token(Token = "0x6003622")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC9A0", Offset = "0x13DC9A0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorkshopIssueReporter), Member = "AddReport", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeneralIssueReporter), Member = "AddReport", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IssueReport(string reportText)
		{
			throw null;
		}

		// Token: 0x040062FC RID: 25340
		[global::Cpp2ILInjected.Token(Token = "0x40076E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public DateTime timeReported;

		// Token: 0x040062FD RID: 25341
		[global::Cpp2ILInjected.Token(Token = "0x40076E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string reportText;
	}
}
