using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000110 RID: 272
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200011D")]
	public class XboxOneWindows10AEUnityProfile : InputDeviceProfile
	{
		// Token: 0x060006AA RID: 1706 RVA: 0x0000342B File Offset: 0x0000162B
		[global::Cpp2ILInjected.Token(Token = "0x60006C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A1E068", Offset = "0x1A1E068", Length = "0xC94")]
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

		// Token: 0x060006AB RID: 1707 RVA: 0x0000342E File Offset: 0x0000162E
		[global::Cpp2ILInjected.Token(Token = "0x60006C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A1ECFC", Offset = "0x1A1ECFC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XboxOneWindows10AEUnityProfile()
		{
			throw null;
		}
	}
}
