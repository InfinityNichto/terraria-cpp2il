using System;
using Cpp2ILInjected;

namespace System.Configuration
{
	// Token: 0x02000364 RID: 868
	[global::Cpp2ILInjected.Token(Token = "0x200049B")]
	public interface IPersistComponentSettings
	{
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001C8F RID: 7311
		// (set) Token: 0x06001C90 RID: 7312
		[global::Cpp2ILInjected.Token(Token = "0x17000777")]
		bool SaveSettings
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FE8")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001FE9")]
			set;
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001C91 RID: 7313
		// (set) Token: 0x06001C92 RID: 7314
		[global::Cpp2ILInjected.Token(Token = "0x17000778")]
		string SettingsKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FEA")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001FEB")]
			set;
		}

		// Token: 0x06001C93 RID: 7315
		[global::Cpp2ILInjected.Token(Token = "0x6001FEC")]
		void LoadComponentSettings();

		// Token: 0x06001C94 RID: 7316
		[global::Cpp2ILInjected.Token(Token = "0x6001FED")]
		void ResetComponentSettings();

		// Token: 0x06001C95 RID: 7317
		[global::Cpp2ILInjected.Token(Token = "0x6001FEE")]
		void SaveComponentSettings();
	}
}
