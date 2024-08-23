using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x0200007C RID: 124
	[SwitchLevel(typeof(TraceLevel))]
	[global::Cpp2ILInjected.Token(Token = "0x20000D4")]
	public class TraceSwitch : Switch
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x00003A40 File Offset: 0x00001C40
		[global::Cpp2ILInjected.Token(Token = "0x60004D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC7394", Offset = "0x1EC7394", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompModSwitches), Member = "get_EventLog", ReturnType = typeof(TraceSwitch))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeLicenseContext), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Switch), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TraceSwitch(string displayName, string description)
		{
			throw null;
		}
	}
}
