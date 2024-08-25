using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	[UnityInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000E0")]
	public class XTR_G2_MacUnityProfile : InputDeviceProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x600064D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19F6B0C", Offset = "0x19F6B0C", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Define()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600064E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19F6C48", Offset = "0x19F6C48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XTR_G2_MacUnityProfile()
		{
			throw null;
		}
	}
}
