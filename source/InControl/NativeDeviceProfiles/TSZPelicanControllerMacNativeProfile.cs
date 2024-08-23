using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A0 RID: 416
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001AD")]
	public class TSZPelicanControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007CA RID: 1994 RVA: 0x0000378B File Offset: 0x0000198B
		[global::Cpp2ILInjected.Token(Token = "0x60007E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A634", Offset = "0x1A2A634", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0000378E File Offset: 0x0000198E
		[global::Cpp2ILInjected.Token(Token = "0x60007E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A6FC", Offset = "0x1A2A6FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public TSZPelicanControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
