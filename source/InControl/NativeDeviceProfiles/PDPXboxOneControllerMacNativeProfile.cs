using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200017F RID: 383
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200018C")]
	public class PDPXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x000036C5 File Offset: 0x000018C5
		[global::Cpp2ILInjected.Token(Token = "0x60007A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28690", Offset = "0x1A28690", Length = "0x3C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000036C8 File Offset: 0x000018C8
		[global::Cpp2ILInjected.Token(Token = "0x60007A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28A58", Offset = "0x1A28A58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XboxOneDriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public PDPXboxOneControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
