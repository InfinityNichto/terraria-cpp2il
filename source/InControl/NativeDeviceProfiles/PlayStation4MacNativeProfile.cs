using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001AE RID: 430
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001BB")]
	public class PlayStation4MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007E6 RID: 2022 RVA: 0x000037DF File Offset: 0x000019DF
		[global::Cpp2ILInjected.Token(Token = "0x6000803")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A3163C", Offset = "0x1A3163C", Length = "0xA10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "LeftStickLeftMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "LeftStickRightMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "LeftStickUpMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "LeftStickDownMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "RightStickLeftMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "RightStickRightMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "RightStickUpMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "RightStickDownMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "LeftTriggerMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "RightTriggerMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 74)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000037E2 File Offset: 0x000019E2
		[global::Cpp2ILInjected.Token(Token = "0x6000804")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A3204C", Offset = "0x1A3204C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PlayStation4MacNativeProfile()
		{
			throw null;
		}
	}
}
