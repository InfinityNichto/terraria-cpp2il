using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E1 RID: 225
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000EE")]
	public class Xbox360MacSafariUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600064C RID: 1612 RVA: 0x00003311 File Offset: 0x00001511
		[global::Cpp2ILInjected.Token(Token = "0x6000669")]
		[global::Cpp2ILInjected.Address(RVA = "0x19FF82C", Offset = "0x19FF82C", Length = "0xBF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 93)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00003314 File Offset: 0x00001514
		[global::Cpp2ILInjected.Token(Token = "0x600066A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A00424", Offset = "0x1A00424", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Xbox360MacSafariUnityProfile()
		{
			throw null;
		}
	}
}
