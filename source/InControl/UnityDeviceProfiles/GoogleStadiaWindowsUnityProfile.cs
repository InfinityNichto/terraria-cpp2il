using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000F3 RID: 243
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000100")]
	public class GoogleStadiaWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000670 RID: 1648 RVA: 0x0000337D File Offset: 0x0000157D
		[global::Cpp2ILInjected.Token(Token = "0x600068D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A0BE14", Offset = "0x1A0BE14", Length = "0xC9C")]
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

		// Token: 0x06000671 RID: 1649 RVA: 0x00003380 File Offset: 0x00001580
		[global::Cpp2ILInjected.Token(Token = "0x600068E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A0CAB0", Offset = "0x1A0CAB0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public GoogleStadiaWindowsUnityProfile()
		{
			throw null;
		}
	}
}
