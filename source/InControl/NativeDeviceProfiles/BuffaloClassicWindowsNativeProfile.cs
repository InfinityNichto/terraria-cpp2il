using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001BC RID: 444
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001C9")]
	public class BuffaloClassicWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x00003833 File Offset: 0x00001A33
		[global::Cpp2ILInjected.Token(Token = "0x600081F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A39A5C", Offset = "0x1A39A5C", Length = "0x69C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00003836 File Offset: 0x00001A36
		[global::Cpp2ILInjected.Token(Token = "0x6000820")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A3A0F8", Offset = "0x1A3A0F8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BuffaloClassicWindowsNativeProfile()
		{
			throw null;
		}
	}
}
