using System;
using Cpp2ILInjected;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x200049B")]
	public interface IPersistComponentSettings
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000777")]
		bool SaveSettings
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FE8")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001FE9")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000778")]
		string SettingsKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FEA")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001FEB")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FEC")]
		void LoadComponentSettings();

		[global::Cpp2ILInjected.Token(Token = "0x6001FED")]
		void ResetComponentSettings();

		[global::Cpp2ILInjected.Token(Token = "0x6001FEE")]
		void SaveComponentSettings();
	}
}
