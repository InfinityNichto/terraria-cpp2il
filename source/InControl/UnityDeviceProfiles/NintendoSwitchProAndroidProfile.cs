using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200009B RID: 155
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000A8")]
	public class NintendoSwitchProAndroidProfile : InputDeviceProfile
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x0000315B File Offset: 0x0000135B
		[global::Cpp2ILInjected.Token(Token = "0x60005D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19D5660", Offset = "0x19D5660", Length = "0xBBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 92)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000315E File Offset: 0x0000135E
		[global::Cpp2ILInjected.Token(Token = "0x60005D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19D621C", Offset = "0x19D621C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NintendoSwitchProAndroidProfile()
		{
			throw null;
		}
	}
}
