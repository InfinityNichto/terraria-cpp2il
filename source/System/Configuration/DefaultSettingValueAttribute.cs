using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[AttributeUsage(AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x2000496")]
	public sealed class DefaultSettingValueAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9CF88", Offset = "0x1E9CF88", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public DefaultSettingValueAttribute(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000772")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9CF8C", Offset = "0x1E9CF8C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
