using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x20004AD")]
	public sealed class SettingsSerializeAsAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9DC58", Offset = "0x1E9DC58", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsSerializeAsAttribute(SettingsSerializeAs serializeAs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000788")]
		public SettingsSerializeAs SerializeAs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002027")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9DC5C", Offset = "0x1E9DC5C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
