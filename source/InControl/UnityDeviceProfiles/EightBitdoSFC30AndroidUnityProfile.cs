using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000084 RID: 132
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000091")]
	public class EightBitdoSFC30AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x000030D1 File Offset: 0x000012D1
		[global::Cpp2ILInjected.Token(Token = "0x60005A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19C98C8", Offset = "0x19C98C8", Length = "0x694")]
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

		// Token: 0x0600058D RID: 1421 RVA: 0x000030D4 File Offset: 0x000012D4
		[global::Cpp2ILInjected.Token(Token = "0x60005AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19C9F5C", Offset = "0x19C9F5C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EightBitdoSFC30AndroidUnityProfile()
		{
			throw null;
		}
	}
}
