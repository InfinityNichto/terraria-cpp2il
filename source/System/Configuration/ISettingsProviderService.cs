using System;
using Cpp2ILInjected;

namespace System.Configuration
{
	// Token: 0x02000366 RID: 870
	[global::Cpp2ILInjected.Token(Token = "0x200049D")]
	public interface ISettingsProviderService
	{
		// Token: 0x06001C9A RID: 7322
		[global::Cpp2ILInjected.Token(Token = "0x6001FF3")]
		SettingsProvider GetSettingsProvider(SettingsProperty property);
	}
}
