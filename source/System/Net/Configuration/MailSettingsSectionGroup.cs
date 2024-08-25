using System;
using System.Configuration;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x2000475")]
	public sealed class MailSettingsSectionGroup : ConfigurationSectionGroup
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001EED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E99C18", Offset = "0x1E99C18", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MailSettingsSectionGroup()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000714")]
		public SmtpSection Smtp
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E99C50", Offset = "0x1E99C50", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
