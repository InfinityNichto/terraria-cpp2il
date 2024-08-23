using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000121 RID: 289
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200012E")]
	public class FusionXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060006CC RID: 1740 RVA: 0x00003491 File Offset: 0x00001691
		[global::Cpp2ILInjected.Token(Token = "0x60006E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A218A8", Offset = "0x1A218A8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00003494 File Offset: 0x00001694
		[global::Cpp2ILInjected.Token(Token = "0x60006EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2199C", Offset = "0x1A2199C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public FusionXboxOneControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
