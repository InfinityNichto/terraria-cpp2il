using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200011A RID: 282
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000127")]
	public class BETAOPControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006BE RID: 1726 RVA: 0x00003467 File Offset: 0x00001667
		[global::Cpp2ILInjected.Token(Token = "0x60006DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A212DC", Offset = "0x1A212DC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0000346A File Offset: 0x0000166A
		[global::Cpp2ILInjected.Token(Token = "0x60006DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A213A8", Offset = "0x1A213A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public BETAOPControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
