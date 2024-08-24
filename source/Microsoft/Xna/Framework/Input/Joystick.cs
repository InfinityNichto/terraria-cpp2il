using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x0200028B RID: 651
	[global::Cpp2ILInjected.Token(Token = "0x200034C")]
	public static class Joystick
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00025739 File Offset: 0x00023939
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

		// Token: 0x0600143C RID: 5180 RVA: 0x0002573C File Offset: 0x0002393C
		[global::Cpp2ILInjected.Token(Token = "0x6001599")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9AA14", Offset = "0xA9AA14", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static JoystickCapabilities GetCapabilities(int index)
		{
			throw null;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0002573F File Offset: 0x0002393F
		[global::Cpp2ILInjected.Token(Token = "0x600159A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9AA2C", Offset = "0xA9AA2C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Joystick), Member = "PlatformGetState", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(JoystickState))]
		public static JoystickState GetState(int index)
		{
			throw null;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00025742 File Offset: 0x00023942
		[global::Cpp2ILInjected.Token(Token = "0x600159B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9AA20", Offset = "0xA9AA20", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static JoystickCapabilities PlatformGetCapabilities(int index)
		{
			throw null;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00025745 File Offset: 0x00023945
		[global::Cpp2ILInjected.Token(Token = "0x600159C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9AA54", Offset = "0xA9AA54", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Joystick), Member = "GetState", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(JoystickState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static JoystickState PlatformGetState(int index)
		{
			throw null;
		}

		// Token: 0x04001D49 RID: 7497
		[global::Cpp2ILInjected.Token(Token = "0x4002323")]
		private const bool PlatformIsSupported = false;
	}
}
