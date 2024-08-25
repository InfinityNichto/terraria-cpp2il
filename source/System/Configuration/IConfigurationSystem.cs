using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Configuration
{
	[ComVisible(false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000498")]
	public interface IConfigurationSystem
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FE0")]
		object GetConfig(string configKey);

		[global::Cpp2ILInjected.Token(Token = "0x6001FE1")]
		void Init();
	}
}
