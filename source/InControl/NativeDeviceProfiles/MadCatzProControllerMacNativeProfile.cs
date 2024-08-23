using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000161 RID: 353
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200016E")]
	public class MadCatzProControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x00003611 File Offset: 0x00001811
		[global::Cpp2ILInjected.Token(Token = "0x6000769")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26998", Offset = "0x1A26998", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00003614 File Offset: 0x00001814
		[global::Cpp2ILInjected.Token(Token = "0x600076A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26A60", Offset = "0x1A26A60", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MadCatzProControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
