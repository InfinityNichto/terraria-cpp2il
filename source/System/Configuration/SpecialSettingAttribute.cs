using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	// Token: 0x02000379 RID: 889
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x20004B0")]
	public sealed class SpecialSettingAttribute : Attribute
	{
		// Token: 0x06001CD1 RID: 7377 RVA: 0x00007F8B File Offset: 0x0000618B
		[global::Cpp2ILInjected.Token(Token = "0x600202A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9DD04", Offset = "0x1E9DD04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SpecialSettingAttribute(SpecialSetting specialSetting)
		{
			throw null;
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x00007F8E File Offset: 0x0000618E
		[global::Cpp2ILInjected.Token(Token = "0x17000789")]
		public SpecialSetting SpecialSetting
		{
			[global::Cpp2ILInjected.Token(Token = "0x600202B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9DD08", Offset = "0x1E9DD08", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
