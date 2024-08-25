using System;
using Cpp2ILInjected;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x200045E")]
	public interface IApplicationSettingsProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E58")]
		SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property);

		[global::Cpp2ILInjected.Token(Token = "0x6001E59")]
		void Reset(SettingsContext context);

		[global::Cpp2ILInjected.Token(Token = "0x6001E5A")]
		void Upgrade(SettingsContext context, SettingsPropertyCollection properties);
	}
}
