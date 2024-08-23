using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E7 RID: 231
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000F4")]
	public class PlayStation4WindowsFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000658 RID: 1624 RVA: 0x00003335 File Offset: 0x00001535
		[global::Cpp2ILInjected.Token(Token = "0x6000675")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A04630", Offset = "0x1A04630", Length = "0xD24")]
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

		// Token: 0x06000659 RID: 1625 RVA: 0x00003338 File Offset: 0x00001538
		[global::Cpp2ILInjected.Token(Token = "0x6000676")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A05354", Offset = "0x1A05354", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PlayStation4WindowsFirefoxUnityProfile()
		{
			throw null;
		}
	}
}
