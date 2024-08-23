using System;
using Cpp2ILInjected;

namespace System.Configuration
{
	// Token: 0x0200032A RID: 810
	[global::Cpp2ILInjected.Token(Token = "0x200045E")]
	public interface IApplicationSettingsProvider
	{
		// Token: 0x06001AFF RID: 6911
		[global::Cpp2ILInjected.Token(Token = "0x6001E58")]
		SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property);

		// Token: 0x06001B00 RID: 6912
		[global::Cpp2ILInjected.Token(Token = "0x6001E59")]
		void Reset(SettingsContext context);

		// Token: 0x06001B01 RID: 6913
		[global::Cpp2ILInjected.Token(Token = "0x6001E5A")]
		void Upgrade(SettingsContext context, SettingsPropertyCollection properties);
	}
}
