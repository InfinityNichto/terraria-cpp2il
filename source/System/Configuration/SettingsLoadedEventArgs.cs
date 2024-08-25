using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x200048C")]
	public class SettingsLoadedEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9C4D0", Offset = "0x1E9C4D0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SettingsLoadedEventArgs(SettingsProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000764")]
		public SettingsProvider Provider
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9C508", Offset = "0x1E9C508", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
