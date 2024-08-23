using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E4 RID: 228
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000F1")]
	public class XboxOneMacSafariUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000652 RID: 1618 RVA: 0x00003323 File Offset: 0x00001523
		[global::Cpp2ILInjected.Token(Token = "0x600066F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A01F38", Offset = "0x1A01F38", Length = "0xBA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 91)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00003326 File Offset: 0x00001526
		[global::Cpp2ILInjected.Token(Token = "0x6000670")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A02AE0", Offset = "0x1A02AE0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XboxOneMacSafariUnityProfile()
		{
			throw null;
		}
	}
}
