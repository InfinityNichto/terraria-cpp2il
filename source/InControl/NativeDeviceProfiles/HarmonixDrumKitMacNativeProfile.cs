using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000124 RID: 292
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000131")]
	public class HarmonixDrumKitMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x000034A3 File Offset: 0x000016A3
		[global::Cpp2ILInjected.Token(Token = "0x60006EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21BC8", Offset = "0x1A21BC8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000034A6 File Offset: 0x000016A6
		[global::Cpp2ILInjected.Token(Token = "0x60006F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21C94", Offset = "0x1A21C94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HarmonixDrumKitMacNativeProfile()
		{
			throw null;
		}
	}
}
