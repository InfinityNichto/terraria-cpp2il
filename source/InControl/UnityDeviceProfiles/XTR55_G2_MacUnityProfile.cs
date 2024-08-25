using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	[UnityInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000DF")]
	public class XTR55_G2_MacUnityProfile : InputDeviceProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x600064B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19F6978", Offset = "0x19F6978", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Define()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600064C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19F6AB4", Offset = "0x19F6AB4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XTR55_G2_MacUnityProfile()
		{
			throw null;
		}
	}
}
