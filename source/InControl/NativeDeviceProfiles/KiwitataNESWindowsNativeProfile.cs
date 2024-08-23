using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C4 RID: 452
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001D1")]
	public class KiwitataNESWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x00003863 File Offset: 0x00001A63
		[global::Cpp2ILInjected.Token(Token = "0x600082F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A3EB74", Offset = "0x1A3EB74", Length = "0x65C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "DPadLeftMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "DPadRightMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "DPadUpMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "DPadDownMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00003866 File Offset: 0x00001A66
		[global::Cpp2ILInjected.Token(Token = "0x6000830")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A3F1D0", Offset = "0x1A3F1D0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public KiwitataNESWindowsNativeProfile()
		{
			throw null;
		}
	}
}
