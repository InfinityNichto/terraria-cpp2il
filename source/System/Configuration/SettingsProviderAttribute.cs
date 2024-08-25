using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x20004AC")]
	public sealed class SettingsProviderAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9DC18", Offset = "0x1E9DC18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsProviderAttribute(string providerTypeName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9DC1C", Offset = "0x1E9DC1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsProviderAttribute(Type providerType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000787")]
		public string ProviderTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002025")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9DC20", Offset = "0x1E9DC20", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
