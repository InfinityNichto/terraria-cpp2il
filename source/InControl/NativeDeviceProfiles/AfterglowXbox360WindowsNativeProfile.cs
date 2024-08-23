using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001BA RID: 442
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001C7")]
	public class AfterglowXbox360WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x00003827 File Offset: 0x00001A27
		[global::Cpp2ILInjected.Token(Token = "0x600081B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A382B0", Offset = "0x1A382B0", Length = "0xB1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 85)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0000382A File Offset: 0x00001A2A
		[global::Cpp2ILInjected.Token(Token = "0x600081C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A38DCC", Offset = "0x1A38DCC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AfterglowXbox360WindowsNativeProfile()
		{
			throw null;
		}
	}
}
