using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200017A RID: 378
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000187")]
	public class PDPTitanfall2XboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x000036A7 File Offset: 0x000018A7
		[global::Cpp2ILInjected.Token(Token = "0x600079B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28284", Offset = "0x1A28284", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000036AA File Offset: 0x000018AA
		[global::Cpp2ILInjected.Token(Token = "0x600079C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28350", Offset = "0x1A28350", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public PDPTitanfall2XboxOneControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
