using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Configuration
{
	// Token: 0x02000361 RID: 865
	[ComVisible(false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000498")]
	public interface IConfigurationSystem
	{
		// Token: 0x06001C87 RID: 7303
		[global::Cpp2ILInjected.Token(Token = "0x6001FE0")]
		object GetConfig(string configKey);

		// Token: 0x06001C88 RID: 7304
		[global::Cpp2ILInjected.Token(Token = "0x6001FE1")]
		void Init();
	}
}
