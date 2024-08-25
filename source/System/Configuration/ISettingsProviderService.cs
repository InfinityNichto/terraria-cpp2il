using System;
using Cpp2ILInjected;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x200049D")]
	public interface ISettingsProviderService
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FF3")]
		SettingsProvider GetSettingsProvider(SettingsProperty property);
	}
}
