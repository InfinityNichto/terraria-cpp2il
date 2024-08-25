using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x20004B0")]
	public sealed class SpecialSettingAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600202A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9DD04", Offset = "0x1E9DD04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SpecialSettingAttribute(SpecialSetting specialSetting)
		{
			throw null;
		}

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
