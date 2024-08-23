using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200018D RID: 397
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200019A")]
	public class RazerStrikeControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007A4 RID: 1956 RVA: 0x00003719 File Offset: 0x00001919
		[global::Cpp2ILInjected.Token(Token = "0x60007C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A295C0", Offset = "0x1A295C0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000371C File Offset: 0x0000191C
		[global::Cpp2ILInjected.Token(Token = "0x60007C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A29688", Offset = "0x1A29688", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public RazerStrikeControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
