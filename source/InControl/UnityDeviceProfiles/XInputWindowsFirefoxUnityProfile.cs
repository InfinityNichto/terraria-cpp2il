using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E9 RID: 233
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000F6")]
	public class XInputWindowsFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600065C RID: 1628 RVA: 0x00003341 File Offset: 0x00001541
		[global::Cpp2ILInjected.Token(Token = "0x6000679")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A06104", Offset = "0x1A06104", Length = "0xCEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 98)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00003344 File Offset: 0x00001544
		[global::Cpp2ILInjected.Token(Token = "0x600067A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A06DF0", Offset = "0x1A06DF0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XInputWindowsFirefoxUnityProfile()
		{
			throw null;
		}
	}
}
