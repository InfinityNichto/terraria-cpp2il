using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000147 RID: 327
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000154")]
	public class LogitechControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000718 RID: 1816 RVA: 0x00003575 File Offset: 0x00001775
		[global::Cpp2ILInjected.Token(Token = "0x6000735")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23AB4", Offset = "0x1A23AB4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00003578 File Offset: 0x00001778
		[global::Cpp2ILInjected.Token(Token = "0x6000736")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23B80", Offset = "0x1A23B80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public LogitechControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
