using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;

namespace MultiplayerWithBindingsExample
{
	// Token: 0x02000006 RID: 6
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public class PlayerActions : PlayerActionSet
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002098 File Offset: 0x00000298
		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		[global::Cpp2ILInjected.Address(RVA = "0x198D4BC", Offset = "0x198D4BC", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActions), Member = "CreateWithKeyboardBindings", ReturnType = typeof(PlayerActions))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActions), Member = "CreateWithJoystickBindings", ReturnType = typeof(PlayerActions))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "CreatePlayerAction", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(PlayerAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "CreateTwoAxisPlayerAction", MemberParameters = new object[]
		{
			typeof(PlayerAction),
			typeof(PlayerAction),
			typeof(PlayerAction),
			typeof(PlayerAction)
		}, ReturnType = typeof(PlayerTwoAxisAction))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public PlayerActions()
		{
			throw null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000209B File Offset: 0x0000029B
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		[global::Cpp2ILInjected.Address(RVA = "0x198D670", Offset = "0x198D670", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(Key[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static PlayerActions CreateWithKeyboardBindings()
		{
			throw null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000209E File Offset: 0x0000029E
		[global::Cpp2ILInjected.Token(Token = "0x600001B")]
		[global::Cpp2ILInjected.Address(RVA = "0x198D814", Offset = "0x198D814", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "CreatePlayer", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PlayerActions CreateWithJoystickBindings()
		{
			throw null;
		}

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public PlayerAction Green;

		// Token: 0x0400000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public PlayerAction Red;

		// Token: 0x0400000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public PlayerAction Blue;

		// Token: 0x04000010 RID: 16
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public PlayerAction Yellow;

		// Token: 0x04000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public PlayerAction Left;

		// Token: 0x04000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public PlayerAction Right;

		// Token: 0x04000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public PlayerAction Up;

		// Token: 0x04000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public PlayerAction Down;

		// Token: 0x04000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public PlayerTwoAxisAction Rotate;
	}
}
