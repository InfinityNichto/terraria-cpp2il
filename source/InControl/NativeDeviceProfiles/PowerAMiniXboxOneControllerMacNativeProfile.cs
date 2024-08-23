using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000184 RID: 388
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000191")]
	public class PowerAMiniXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x000036E3 File Offset: 0x000018E3
		[global::Cpp2ILInjected.Token(Token = "0x60007AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28DE4", Offset = "0x1A28DE4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000036E6 File Offset: 0x000018E6
		[global::Cpp2ILInjected.Token(Token = "0x60007B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28EB0", Offset = "0x1A28EB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public PowerAMiniXboxOneControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
