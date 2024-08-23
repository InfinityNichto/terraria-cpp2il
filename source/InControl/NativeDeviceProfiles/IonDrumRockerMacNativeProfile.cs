using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000143 RID: 323
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000150")]
	public class IonDrumRockerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000710 RID: 1808 RVA: 0x0000355D File Offset: 0x0000175D
		[global::Cpp2ILInjected.Token(Token = "0x600072D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23764", Offset = "0x1A23764", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00003560 File Offset: 0x00001760
		[global::Cpp2ILInjected.Token(Token = "0x600072E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23830", Offset = "0x1A23830", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public IonDrumRockerMacNativeProfile()
		{
			throw null;
		}
	}
}
