using System;
using System.Configuration.Provider;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x200045D")]
	public class SettingsProviderCollection : ProviderCollection
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97BB4", Offset = "0x1E97BB4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SettingsProviderCollection()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006DE")]
		public SettingsProvider this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E56")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E97BEC", Offset = "0x1E97BEC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E97C24", Offset = "0x1E97C24", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Add(ProviderBase provider)
		{
			throw null;
		}
	}
}
