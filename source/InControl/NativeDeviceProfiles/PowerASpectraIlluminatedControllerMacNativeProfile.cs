using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000185 RID: 389
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000192")]
	public class PowerASpectraIlluminatedControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000794 RID: 1940 RVA: 0x000036E9 File Offset: 0x000018E9
		[global::Cpp2ILInjected.Token(Token = "0x60007B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28EB8", Offset = "0x1A28EB8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000036EC File Offset: 0x000018EC
		[global::Cpp2ILInjected.Token(Token = "0x60007B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28F80", Offset = "0x1A28F80", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public PowerASpectraIlluminatedControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
