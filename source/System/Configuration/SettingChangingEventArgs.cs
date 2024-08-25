using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x200048A")]
	public class SettingChangingEventArgs : CancelEventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9C2D8", Offset = "0x1E9C2D8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SettingChangingEventArgs(string settingName, string settingClass, string settingKey, object newValue, bool cancel)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000760")]
		public object NewValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9C310", Offset = "0x1E9C310", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000761")]
		public string SettingClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9C348", Offset = "0x1E9C348", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000762")]
		public string SettingKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9C380", Offset = "0x1E9C380", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000763")]
		public string SettingName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9C3B8", Offset = "0x1E9C3B8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
