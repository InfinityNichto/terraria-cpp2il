using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000DE RID: 222
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000EB")]
	public class PlayStation4MacFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x000032FF File Offset: 0x000014FF
		[global::Cpp2ILInjected.Token(Token = "0x6000663")]
		[global::Cpp2ILInjected.Address(RVA = "0x19FD160", Offset = "0x19FD160", Length = "0xCA8")]
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

		// Token: 0x06000647 RID: 1607 RVA: 0x00003302 File Offset: 0x00001502
		[global::Cpp2ILInjected.Token(Token = "0x6000664")]
		[global::Cpp2ILInjected.Address(RVA = "0x19FDE08", Offset = "0x19FDE08", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PlayStation4MacFirefoxUnityProfile()
		{
			throw null;
		}
	}
}
