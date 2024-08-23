using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E3 RID: 227
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000F0")]
	public class XboxOneMacFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000650 RID: 1616 RVA: 0x0000331D File Offset: 0x0000151D
		[global::Cpp2ILInjected.Token(Token = "0x600066D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A011D4", Offset = "0x1A011D4", Length = "0xD0C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 99)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00003320 File Offset: 0x00001520
		[global::Cpp2ILInjected.Token(Token = "0x600066E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A01EE0", Offset = "0x1A01EE0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XboxOneMacFirefoxUnityProfile()
		{
			throw null;
		}
	}
}
