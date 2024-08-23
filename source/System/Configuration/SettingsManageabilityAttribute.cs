using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	// Token: 0x02000371 RID: 881
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x20004A8")]
	public sealed class SettingsManageabilityAttribute : Attribute
	{
		// Token: 0x06001CBC RID: 7356 RVA: 0x00007F4C File Offset: 0x0000614C
		[global::Cpp2ILInjected.Token(Token = "0x6002015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9D93C", Offset = "0x1E9D93C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsManageabilityAttribute(SettingsManageability manageability)
		{
			throw null;
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x00007F4F File Offset: 0x0000614F
		[global::Cpp2ILInjected.Token(Token = "0x17000786")]
		public SettingsManageability Manageability
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002016")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9D940", Offset = "0x1E9D940", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
