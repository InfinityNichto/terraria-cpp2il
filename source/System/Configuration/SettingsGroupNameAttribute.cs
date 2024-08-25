using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x20004A6")]
	public sealed class SettingsGroupNameAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9D900", Offset = "0x1E9D900", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsGroupNameAttribute(string groupName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000785")]
		public string GroupName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002014")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9D904", Offset = "0x1E9D904", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
