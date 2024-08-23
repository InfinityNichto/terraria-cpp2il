using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000195 RID: 405
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001A2")]
	public class RockCandyPS3ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007B4 RID: 1972 RVA: 0x00003749 File Offset: 0x00001949
		[global::Cpp2ILInjected.Token(Token = "0x60007D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A29C48", Offset = "0x1A29C48", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0000374C File Offset: 0x0000194C
		[global::Cpp2ILInjected.Token(Token = "0x60007D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A29D10", Offset = "0x1A29D10", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public RockCandyPS3ControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
