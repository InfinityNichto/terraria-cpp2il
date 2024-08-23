using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001B5 RID: 437
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001C2")]
	public class XTR_G2_MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007F4 RID: 2036 RVA: 0x00003809 File Offset: 0x00001A09
		[global::Cpp2ILInjected.Token(Token = "0x6000811")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A35A68", Offset = "0x1A35A68", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0000380C File Offset: 0x00001A0C
		[global::Cpp2ILInjected.Token(Token = "0x6000812")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A35BC4", Offset = "0x1A35BC4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XTR_G2_MacNativeProfile()
		{
			throw null;
		}
	}
}
