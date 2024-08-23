using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014B RID: 331
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000158")]
	public class LogitechF710ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000720 RID: 1824 RVA: 0x0000358D File Offset: 0x0000178D
		[global::Cpp2ILInjected.Token(Token = "0x600073D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23E2C", Offset = "0x1A23E2C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00003590 File Offset: 0x00001790
		[global::Cpp2ILInjected.Token(Token = "0x600073E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23EF8", Offset = "0x1A23EF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public LogitechF710ControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
