using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000187 RID: 391
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000194")]
	public class ProEXXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x000036F5 File Offset: 0x000018F5
		[global::Cpp2ILInjected.Token(Token = "0x60007B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A29050", Offset = "0x1A29050", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000036F8 File Offset: 0x000018F8
		[global::Cpp2ILInjected.Token(Token = "0x60007B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2911C", Offset = "0x1A2911C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public ProEXXboxOneControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
