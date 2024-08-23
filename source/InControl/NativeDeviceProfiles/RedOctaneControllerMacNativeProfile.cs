using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000190 RID: 400
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200019D")]
	public class RedOctaneControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x0000372B File Offset: 0x0000192B
		[global::Cpp2ILInjected.Token(Token = "0x60007C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A29824", Offset = "0x1A29824", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0000372E File Offset: 0x0000192E
		[global::Cpp2ILInjected.Token(Token = "0x60007C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A29914", Offset = "0x1A29914", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public RedOctaneControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
