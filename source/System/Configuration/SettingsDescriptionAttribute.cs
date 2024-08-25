using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[AttributeUsage(AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x20004A4")]
	public sealed class SettingsDescriptionAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600200F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9D888", Offset = "0x1E9D888", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsDescriptionAttribute(string description)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000783")]
		public string Description
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002010")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9D88C", Offset = "0x1E9D88C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
