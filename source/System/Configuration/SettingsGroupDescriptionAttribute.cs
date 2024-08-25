using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x20004A5")]
	public sealed class SettingsGroupDescriptionAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9D8C4", Offset = "0x1E9D8C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsGroupDescriptionAttribute(string description)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000784")]
		public string Description
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002012")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9D8C8", Offset = "0x1E9D8C8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
