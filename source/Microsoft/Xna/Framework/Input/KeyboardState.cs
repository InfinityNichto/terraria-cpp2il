using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.GameInput;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000290 RID: 656
	[global::Cpp2ILInjected.Token(Token = "0x2000351")]
	public struct KeyboardState
	{
		// Token: 0x06001470 RID: 5232 RVA: 0x000257D8 File Offset: 0x000239D8
		[global::Cpp2ILInjected.Token(Token = "0x60015CD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C0B0", Offset = "0xA9C0B0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyboardState), Member = "get_Item", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(KeyState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyboardState), Member = "IsKeyDown", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyboardState), Member = "IsKeyUp", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool InternalGetKey(Keys key)
		{
			throw null;
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x000257DB File Offset: 0x000239DB
		[global::Cpp2ILInjected.Token(Token = "0x60015CE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C154", Offset = "0xA9C154", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyboardState), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(List<Keys>),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyboardState), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Keys[]),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyboardState), Member = ".ctor", MemberParameters = new object[] { typeof(Keys[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InternalSetKey(Keys key)
		{
			throw null;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000257DE File Offset: 0x000239DE
		[global::Cpp2ILInjected.Token(Token = "0x60015CF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C1C4", Offset = "0xA9C1C4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InternalClearKey(Keys key)
		{
			throw null;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000257E1 File Offset: 0x000239E1
		[global::Cpp2ILInjected.Token(Token = "0x60015D0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C234", Offset = "0xA9C234", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void InternalClearAllKeys()
		{
			throw null;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x000257E4 File Offset: 0x000239E4
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x000257E7 File Offset: 0x000239E7
		[global::Cpp2ILInjected.Token(Token = "0x17000265")]
		public bool CapsLock
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015D1")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9C240", Offset = "0xA9C240", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015D2")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9C248", Offset = "0xA9C248", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x000257EA File Offset: 0x000239EA
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x000257ED File Offset: 0x000239ED
		[global::Cpp2ILInjected.Token(Token = "0x17000266")]
		public bool NumLock
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015D3")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9C254", Offset = "0xA9C254", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015D4")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9C25C", Offset = "0xA9C25C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x000257F0 File Offset: 0x000239F0
		[global::Cpp2ILInjected.Token(Token = "0x60015D5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9BD48", Offset = "0xA9BD48", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Keyboard), Member = "PlatformGetState", ReturnType = typeof(KeyboardState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "InternalSetKey", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal KeyboardState(List<Keys> keys, bool capsLock = false, bool numLock = false)
		{
			throw null;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x000257F3 File Offset: 0x000239F3
		[global::Cpp2ILInjected.Token(Token = "0x60015D6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C268", Offset = "0xA9C268", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "InternalSetKey", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(void))]
		public KeyboardState(Keys[] keys, bool capsLock = false, bool numLock = false)
		{
			throw null;
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x000257F6 File Offset: 0x000239F6
		[global::Cpp2ILInjected.Token(Token = "0x60015D7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C2DC", Offset = "0xA9C2DC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "InternalSetKey", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(void))]
		public KeyboardState(params Keys[] keys)
		{
			throw null;
		}

		// Token: 0x1700023F RID: 575
		[global::Cpp2ILInjected.Token(Token = "0x17000267")]
		public KeyState this[Keys key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015D8")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9C340", Offset = "0xA9C340", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "InternalGetKey", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x000257FC File Offset: 0x000239FC
		[global::Cpp2ILInjected.Token(Token = "0x60015D9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C354", Offset = "0xA9C354", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate_AltEnter_ToggleFullscreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate_F10_ToggleFPS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PressingShift", MemberParameters = new object[] { typeof(KeyboardState) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PressingControl", MemberParameters = new object[] { typeof(KeyboardState) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "KeyboardInput", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "InternalGetKey", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(bool))]
		public bool IsKeyDown(Keys key)
		{
			throw null;
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x000257FF File Offset: 0x000239FF
		[global::Cpp2ILInjected.Token(Token = "0x60015DA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C358", Offset = "0xA9C358", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "InternalGetKey", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(bool))]
		public bool IsKeyUp(Keys key)
		{
			throw null;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00025802 File Offset: 0x00023A02
		[global::Cpp2ILInjected.Token(Token = "0x60015DB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C370", Offset = "0xA9C370", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint CountBits(uint v)
		{
			throw null;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00025805 File Offset: 0x00023A05
		[global::Cpp2ILInjected.Token(Token = "0x60015DC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C3A4", Offset = "0xA9C3A4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int AddKeysToArray(uint keys, int offset, Keys[] pressedKeys, int index)
		{
			throw null;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00025808 File Offset: 0x00023A08
		[global::Cpp2ILInjected.Token(Token = "0x60015DD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C3DC", Offset = "0xA9C3DC", Length = "0x490")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "InvalidateKeyboardSwap", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "ResetInputsOnActiveStateChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "KeyboardInput", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public Keys[] GetPressedKeys()
		{
			throw null;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0002580B File Offset: 0x00023A0B
		[global::Cpp2ILInjected.Token(Token = "0x60015DE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C86C", Offset = "0xA9C86C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0002580E File Offset: 0x00023A0E
		[global::Cpp2ILInjected.Token(Token = "0x60015DF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C89C", Offset = "0xA9C89C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(KeyboardState a, KeyboardState b)
		{
			throw null;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00025811 File Offset: 0x00023A11
		[global::Cpp2ILInjected.Token(Token = "0x60015E0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9C928", Offset = "0xA9C928", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(KeyboardState a, KeyboardState b)
		{
			throw null;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00025814 File Offset: 0x00023A14
		[global::Cpp2ILInjected.Token(Token = "0x60015E1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9CA3C", Offset = "0xA9CA3C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00025817 File Offset: 0x00023A17
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015E2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9CB6C", Offset = "0xA9CB6C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static KeyboardState()
		{
			throw null;
		}

		// Token: 0x04001D5F RID: 7519
		[global::Cpp2ILInjected.Token(Token = "0x4002339")]
		private static Keys[] empty;

		// Token: 0x04001D60 RID: 7520
		[global::Cpp2ILInjected.Token(Token = "0x400233A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private uint keys0;

		// Token: 0x04001D61 RID: 7521
		[global::Cpp2ILInjected.Token(Token = "0x400233B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private uint keys1;

		// Token: 0x04001D62 RID: 7522
		[global::Cpp2ILInjected.Token(Token = "0x400233C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private uint keys2;

		// Token: 0x04001D63 RID: 7523
		[global::Cpp2ILInjected.Token(Token = "0x400233D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private uint keys3;

		// Token: 0x04001D64 RID: 7524
		[global::Cpp2ILInjected.Token(Token = "0x400233E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private uint keys4;

		// Token: 0x04001D65 RID: 7525
		[global::Cpp2ILInjected.Token(Token = "0x400233F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private uint keys5;

		// Token: 0x04001D66 RID: 7526
		[global::Cpp2ILInjected.Token(Token = "0x4002340")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private uint keys6;

		// Token: 0x04001D67 RID: 7527
		[global::Cpp2ILInjected.Token(Token = "0x4002341")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private uint keys7;

		// Token: 0x04001D68 RID: 7528
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002342")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool <CapsLock>k__BackingField;

		// Token: 0x04001D69 RID: 7529
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002343")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool <NumLock>k__BackingField;

		// Token: 0x04001D6A RID: 7530
		[global::Cpp2ILInjected.Token(Token = "0x4002344")]
		private static Keys[] keysArray1;

		// Token: 0x04001D6B RID: 7531
		[global::Cpp2ILInjected.Token(Token = "0x4002345")]
		private static Keys[] keysArray2;

		// Token: 0x04001D6C RID: 7532
		[global::Cpp2ILInjected.Token(Token = "0x4002346")]
		private static Keys[] keysArray3;

		// Token: 0x04001D6D RID: 7533
		[global::Cpp2ILInjected.Token(Token = "0x4002347")]
		private static Keys[] keysArray4;

		// Token: 0x04001D6E RID: 7534
		[global::Cpp2ILInjected.Token(Token = "0x4002348")]
		private static Keys[] keysArray5;

		// Token: 0x04001D6F RID: 7535
		[global::Cpp2ILInjected.Token(Token = "0x4002349")]
		private static Keys[] keysArray6;

		// Token: 0x04001D70 RID: 7536
		[global::Cpp2ILInjected.Token(Token = "0x400234A")]
		private static Keys[] keysArray7;

		// Token: 0x04001D71 RID: 7537
		[global::Cpp2ILInjected.Token(Token = "0x400234B")]
		private static Keys[] keysArray8;
	}
}
