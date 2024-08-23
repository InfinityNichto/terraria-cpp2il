using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E8 RID: 232
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000F5")]
	public class XInputWindowsChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600065A RID: 1626 RVA: 0x0000333B File Offset: 0x0000153B
		[global::Cpp2ILInjected.Token(Token = "0x6000677")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A053AC", Offset = "0x1A053AC", Length = "0xD00")]
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

		// Token: 0x0600065B RID: 1627 RVA: 0x0000333E File Offset: 0x0000153E
		[global::Cpp2ILInjected.Token(Token = "0x6000678")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A060AC", Offset = "0x1A060AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XInputWindowsChromeUnityProfile()
		{
			throw null;
		}
	}
}
