using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000BD RID: 189
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000CA")]
	public class EightBitdoSFC30MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000604 RID: 1540 RVA: 0x00003239 File Offset: 0x00001439
		[global::Cpp2ILInjected.Token(Token = "0x6000621")]
		[global::Cpp2ILInjected.Address(RVA = "0x19EA684", Offset = "0x19EA684", Length = "0x6C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0000323C File Offset: 0x0000143C
		[global::Cpp2ILInjected.Token(Token = "0x6000622")]
		[global::Cpp2ILInjected.Address(RVA = "0x19EAD44", Offset = "0x19EAD44", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EightBitdoSFC30MacUnityProfile()
		{
			throw null;
		}
	}
}
