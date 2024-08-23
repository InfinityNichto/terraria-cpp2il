using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000111 RID: 273
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200011E")]
	public class XboxOneWindows10UnityProfile : InputDeviceProfile
	{
		// Token: 0x060006AC RID: 1708 RVA: 0x00003431 File Offset: 0x00001631
		[global::Cpp2ILInjected.Token(Token = "0x60006C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A1ED54", Offset = "0x1A1ED54", Length = "0xC90")]
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

		// Token: 0x060006AD RID: 1709 RVA: 0x00003434 File Offset: 0x00001634
		[global::Cpp2ILInjected.Token(Token = "0x60006CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A1F9E4", Offset = "0x1A1F9E4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XboxOneWindows10UnityProfile()
		{
			throw null;
		}
	}
}
