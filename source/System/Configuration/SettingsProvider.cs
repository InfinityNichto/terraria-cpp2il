using System;
using System.Configuration.Provider;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x2000458")]
	public abstract class SettingsProvider : ProviderBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E975CC", Offset = "0x1E975CC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SettingsProvider()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006D2")]
		public abstract string ApplicationName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E37")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001E38")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E39")]
		public abstract SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection);

		[global::Cpp2ILInjected.Token(Token = "0x6001E3A")]
		public abstract void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection);
	}
}
