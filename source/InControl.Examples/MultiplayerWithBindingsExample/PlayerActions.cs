using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;

namespace MultiplayerWithBindingsExample
{
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public class PlayerActions : PlayerActionSet
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public PlayerAction Green;

		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public PlayerAction Red;

		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public PlayerAction Blue;

		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public PlayerAction Yellow;

		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public PlayerAction Left;

		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public PlayerAction Right;

		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public PlayerAction Up;

		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public PlayerAction Down;

		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public PlayerTwoAxisAction Rotate;
	}
}
