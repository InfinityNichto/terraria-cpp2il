using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200019D RID: 413
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001AA")]
	public class ThrustmasterTMXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x00003779 File Offset: 0x00001979
		[global::Cpp2ILInjected.Token(Token = "0x60007E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A3D0", Offset = "0x1A2A3D0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0000377C File Offset: 0x0000197C
		[global::Cpp2ILInjected.Token(Token = "0x60007E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A498", Offset = "0x1A2A498", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public ThrustmasterTMXMacNativeProfile()
		{
			throw null;
		}
	}
}
