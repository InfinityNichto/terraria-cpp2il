using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E6 RID: 230
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000F3")]
	public class PlayStation4WindowsChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x0000332F File Offset: 0x0000152F
		[global::Cpp2ILInjected.Token(Token = "0x6000673")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A038B4", Offset = "0x1A038B4", Length = "0xD24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 100)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00003332 File Offset: 0x00001532
		[global::Cpp2ILInjected.Token(Token = "0x6000674")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A045D8", Offset = "0x1A045D8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PlayStation4WindowsChromeUnityProfile()
		{
			throw null;
		}
	}
}
