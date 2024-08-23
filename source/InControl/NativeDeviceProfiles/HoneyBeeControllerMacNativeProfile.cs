using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000127 RID: 295
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000134")]
	public class HoneyBeeControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006D8 RID: 1752 RVA: 0x000034B5 File Offset: 0x000016B5
		[global::Cpp2ILInjected.Token(Token = "0x60006F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21E44", Offset = "0x1A21E44", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000034B8 File Offset: 0x000016B8
		[global::Cpp2ILInjected.Token(Token = "0x60006F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21F10", Offset = "0x1A21F10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoneyBeeControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
