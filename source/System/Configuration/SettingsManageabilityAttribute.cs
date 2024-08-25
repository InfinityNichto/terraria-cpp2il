using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x20004A8")]
	public sealed class SettingsManageabilityAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9D93C", Offset = "0x1E9D93C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsManageabilityAttribute(SettingsManageability manageability)
		{
			throw null;
		}

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
