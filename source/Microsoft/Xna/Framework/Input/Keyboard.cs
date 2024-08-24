using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.GameInput;
using UnityEngine;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x0200028F RID: 655
	[global::Cpp2ILInjected.Token(Token = "0x2000350")]
	public static class Keyboard
	{
		// Token: 0x0600146B RID: 5227 RVA: 0x000257C9 File Offset: 0x000239C9
		[global::Cpp2ILInjected.Token(Token = "0x60015C8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9B86C", Offset = "0xA9B86C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate_HandleInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "ResetInputsOnActiveStateChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyboard), Member = "PlatformGetState", ReturnType = typeof(KeyboardState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static KeyboardState GetState()
		{
			throw null;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000257CC File Offset: 0x000239CC
		[Obsolete("Use GetState() instead. In future versions this method can be removed.")]
		[global::Cpp2ILInjected.Token(Token = "0x60015C9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9BCD4", Offset = "0xA9BCD4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyboard), Member = "PlatformGetState", ReturnType = typeof(KeyboardState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static KeyboardState GetState(PlayerIndex playerIndex)
		{
			throw null;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000257CF File Offset: 0x000239CF
		[global::Cpp2ILInjected.Token(Token = "0x60015CA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9B8E0", Offset = "0xA9B8E0", Length = "0x3F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Keyboard), Member = "GetState", ReturnType = typeof(KeyboardState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Keyboard), Member = "GetState", MemberParameters = new object[] { typeof(PlayerIndex) }, ReturnType = typeof(KeyboardState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_HasKeyboard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(List<Keys>),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<Int32Enum>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private static KeyboardState PlatformGetState()
		{
			throw null;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x000257D2 File Offset: 0x000239D2
		[global::Cpp2ILInjected.Token(Token = "0x60015CB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9BEA0", Offset = "0xA9BEA0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void SetKeys(List<Keys> keys)
		{
			throw null;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x000257D5 File Offset: 0x000239D5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015CC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9BEFC", Offset = "0xA9BEFC", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		static Keyboard()
		{
			throw null;
		}

		// Token: 0x04001D58 RID: 7512
		[global::Cpp2ILInjected.Token(Token = "0x4002332")]
		public static KeyCode[] keyCodes;

		// Token: 0x04001D59 RID: 7513
		[global::Cpp2ILInjected.Token(Token = "0x4002333")]
		public static Keys[] keys;

		// Token: 0x04001D5A RID: 7514
		[global::Cpp2ILInjected.Token(Token = "0x4002334")]
		public static bool keyboardActive;

		// Token: 0x04001D5B RID: 7515
		[global::Cpp2ILInjected.Token(Token = "0x4002335")]
		private static List<Keys> _keys;

		// Token: 0x04001D5C RID: 7516
		[global::Cpp2ILInjected.Token(Token = "0x4002336")]
		public static List<KeyCode> UnityKeys;

		// Token: 0x04001D5D RID: 7517
		[global::Cpp2ILInjected.Token(Token = "0x4002337")]
		public static List<KeyCode> LastUnityKeys;

		// Token: 0x04001D5E RID: 7518
		[global::Cpp2ILInjected.Token(Token = "0x4002338")]
		public static bool IgnoreEnterUntilClear;
	}
}
