using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000D4 RID: 212
	[UnityInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000E1")]
	public class AppleMFiUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x000032C3 File Offset: 0x000014C3
		[global::Cpp2ILInjected.Token(Token = "0x600064F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19F6CA0", Offset = "0x19F6CA0", Length = "0x888")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "set_LowerDeadZone", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "set_UpperDeadZone", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 66)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000032C6 File Offset: 0x000014C6
		[global::Cpp2ILInjected.Token(Token = "0x6000650")]
		[global::Cpp2ILInjected.Address(RVA = "0x19F7528", Offset = "0x19F7528", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AppleMFiUnityProfile()
		{
			throw null;
		}
	}
}
