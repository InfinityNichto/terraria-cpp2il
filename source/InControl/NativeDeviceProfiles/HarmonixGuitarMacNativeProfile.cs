using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000125 RID: 293
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000132")]
	public class HarmonixGuitarMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x000034A9 File Offset: 0x000016A9
		[global::Cpp2ILInjected.Token(Token = "0x60006F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21C9C", Offset = "0x1A21C9C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000034AC File Offset: 0x000016AC
		[global::Cpp2ILInjected.Token(Token = "0x60006F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21D68", Offset = "0x1A21D68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HarmonixGuitarMacNativeProfile()
		{
			throw null;
		}
	}
}
