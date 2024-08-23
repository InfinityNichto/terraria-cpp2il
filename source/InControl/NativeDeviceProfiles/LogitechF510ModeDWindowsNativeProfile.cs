using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C7 RID: 455
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001D4")]
	public class LogitechF510ModeDWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000818 RID: 2072 RVA: 0x00003875 File Offset: 0x00001A75
		[global::Cpp2ILInjected.Token(Token = "0x6000835")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A409D8", Offset = "0x1A409D8", Length = "0xB7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 88)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00003878 File Offset: 0x00001A78
		[global::Cpp2ILInjected.Token(Token = "0x6000836")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A41554", Offset = "0x1A41554", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LogitechF510ModeDWindowsNativeProfile()
		{
			throw null;
		}
	}
}
