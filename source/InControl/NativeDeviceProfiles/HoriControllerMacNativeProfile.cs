using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000129 RID: 297
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000136")]
	public class HoriControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006DC RID: 1756 RVA: 0x000034C1 File Offset: 0x000016C1
		[global::Cpp2ILInjected.Token(Token = "0x60006F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21FEC", Offset = "0x1A21FEC", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000034C4 File Offset: 0x000016C4
		[global::Cpp2ILInjected.Token(Token = "0x60006FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22160", Offset = "0x1A22160", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
