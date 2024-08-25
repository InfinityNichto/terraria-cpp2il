using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[SwitchLevel(typeof(bool))]
	[global::Cpp2ILInjected.Token(Token = "0x20000C7")]
	public class BooleanSwitch : Switch
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000493")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC4910", Offset = "0x1EC4910", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompModSwitches), Member = "get_CommonDesignerServices", ReturnType = typeof(BooleanSwitch))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BooleanSwitch(string displayName, string description)
		{
			throw null;
		}
	}
}
