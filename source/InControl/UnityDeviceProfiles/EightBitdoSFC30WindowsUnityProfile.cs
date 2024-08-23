using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000EE RID: 238
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000FB")]
	public class EightBitdoSFC30WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000666 RID: 1638 RVA: 0x0000335F File Offset: 0x0000155F
		[global::Cpp2ILInjected.Token(Token = "0x6000683")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A092D8", Offset = "0x1A092D8", Length = "0x694")]
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

		// Token: 0x06000667 RID: 1639 RVA: 0x00003362 File Offset: 0x00001562
		[global::Cpp2ILInjected.Token(Token = "0x6000684")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A0996C", Offset = "0x1A0996C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EightBitdoSFC30WindowsUnityProfile()
		{
			throw null;
		}
	}
}
