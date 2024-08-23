using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x0200028A RID: 650
	[global::Cpp2ILInjected.Token(Token = "0x200034B")]
	internal class GamepadTranslator
	{
		// Token: 0x06001435 RID: 5173 RVA: 0x00025727 File Offset: 0x00023927
		[global::Cpp2ILInjected.Token(Token = "0x6001592")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A538", Offset = "0xA9A538", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public GamepadTranslator(string config)
		{
			throw null;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0002572A File Offset: 0x0002392A
		[global::Cpp2ILInjected.Token(Token = "0x6001593")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A6E0", Offset = "0xA9A6E0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamepadTranslator), Member = "ButtonPressed", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JoystickState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamepadTranslator), Member = "AxisPressed", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JoystickState)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamepadTranslator), Member = "DpadPressed", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JoystickState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamepadTranslator), Member = "TriggerPressed", MemberParameters = new object[]
		{
			typeof(string),
			typeof(JoystickState)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ButtonType Read(string button)
		{
			throw null;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0002572D File Offset: 0x0002392D
		[global::Cpp2ILInjected.Token(Token = "0x6001594")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A7A4", Offset = "0xA9A7A4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamepadTranslator), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ButtonType))]
		public bool ButtonPressed(string button, JoystickState state)
		{
			throw null;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00025730 File Offset: 0x00023930
		[global::Cpp2ILInjected.Token(Token = "0x6001595")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A80C", Offset = "0xA9A80C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamepadTranslator), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ButtonType))]
		public float AxisPressed(string axis, JoystickState state)
		{
			throw null;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00025733 File Offset: 0x00023933
		[global::Cpp2ILInjected.Token(Token = "0x6001596")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A844", Offset = "0xA9A844", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamepadTranslator), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ButtonType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool DpadPressed(string dpad, JoystickState state)
		{
			throw null;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00025736 File Offset: 0x00023936
		[global::Cpp2ILInjected.Token(Token = "0x6001597")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A940", Offset = "0xA9A940", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamepadTranslator), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ButtonType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public float TriggerPressed(string trigger, JoystickState state)
		{
			throw null;
		}

		// Token: 0x04001D48 RID: 7496
		[global::Cpp2ILInjected.Token(Token = "0x4002322")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<string, ButtonType> Data;
	}
}
