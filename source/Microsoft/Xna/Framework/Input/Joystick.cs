using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	[global::Cpp2ILInjected.Token(Token = "0x200034C")]
	public static class Joystick
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000256")]
		public static bool IsSupported
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001598")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9AA0C", Offset = "0xA9AA0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001599")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9AA14", Offset = "0xA9AA14", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static JoystickCapabilities GetCapabilities(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600159A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9AA2C", Offset = "0xA9AA2C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Joystick), Member = "PlatformGetState", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(JoystickState))]
		public static JoystickState GetState(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600159B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9AA20", Offset = "0xA9AA20", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static JoystickCapabilities PlatformGetCapabilities(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600159C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9AA54", Offset = "0xA9AA54", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Joystick), Member = "GetState", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(JoystickState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static JoystickState PlatformGetState(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002323")]
		private const bool PlatformIsSupported = false;
	}
}
