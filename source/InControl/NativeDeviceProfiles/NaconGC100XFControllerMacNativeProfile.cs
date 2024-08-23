using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000174 RID: 372
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000181")]
	public class NaconGC100XFControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x00003683 File Offset: 0x00001883
		[global::Cpp2ILInjected.Token(Token = "0x600078F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A27B2C", Offset = "0x1A27B2C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00003686 File Offset: 0x00001886
		[global::Cpp2ILInjected.Token(Token = "0x6000790")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A27BF4", Offset = "0x1A27BF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public NaconGC100XFControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
