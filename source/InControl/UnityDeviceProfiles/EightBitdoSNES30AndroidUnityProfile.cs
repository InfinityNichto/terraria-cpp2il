using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000086 RID: 134
	[UnityInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000093")]
	public class EightBitdoSNES30AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x000030DD File Offset: 0x000012DD
		[global::Cpp2ILInjected.Token(Token = "0x60005AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19CA7BC", Offset = "0x19CA7BC", Length = "0x694")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000030E0 File Offset: 0x000012E0
		[global::Cpp2ILInjected.Token(Token = "0x60005AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x19CAE50", Offset = "0x19CAE50", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EightBitdoSNES30AndroidUnityProfile()
		{
			throw null;
		}
	}
}
