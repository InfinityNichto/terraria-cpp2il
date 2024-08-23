using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E0 RID: 224
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000ED")]
	public class Xbox360MacFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600064A RID: 1610 RVA: 0x0000330B File Offset: 0x0000150B
		[global::Cpp2ILInjected.Token(Token = "0x6000667")]
		[global::Cpp2ILInjected.Address(RVA = "0x19FEBB8", Offset = "0x19FEBB8", Length = "0xC1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 94)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000330E File Offset: 0x0000150E
		[global::Cpp2ILInjected.Token(Token = "0x6000668")]
		[global::Cpp2ILInjected.Address(RVA = "0x19FF7D4", Offset = "0x19FF7D4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Xbox360MacFirefoxUnityProfile()
		{
			throw null;
		}
	}
}
