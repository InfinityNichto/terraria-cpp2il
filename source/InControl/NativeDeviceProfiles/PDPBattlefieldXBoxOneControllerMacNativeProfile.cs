using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000177 RID: 375
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000184")]
	public class PDPBattlefieldXBoxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x00003695 File Offset: 0x00001895
		[global::Cpp2ILInjected.Token(Token = "0x6000795")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28018", Offset = "0x1A28018", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00003698 File Offset: 0x00001898
		[global::Cpp2ILInjected.Token(Token = "0x6000796")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A280E4", Offset = "0x1A280E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public PDPBattlefieldXBoxOneControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
