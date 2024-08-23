using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x02000085 RID: 133
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x20000E0")]
	public class MonitoringDescriptionAttribute : DescriptionAttribute
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x00003B39 File Offset: 0x00001D39
		[global::Cpp2ILInjected.Token(Token = "0x600052E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC2D0", Offset = "0x1ECC2D0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DescriptionAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MonitoringDescriptionAttribute(string description)
		{
			throw null;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00003B3C File Offset: 0x00001D3C
		[global::Cpp2ILInjected.Token(Token = "0x170000FE")]
		public override string Description
		{
			[global::Cpp2ILInjected.Token(Token = "0x600052F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECC338", Offset = "0x1ECC338", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DescriptionAttribute), Member = "get_Description", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}
	}
}
