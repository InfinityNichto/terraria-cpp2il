using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;
using UnityEngine;

namespace MultiplayerWithBindingsExample
{
	// Token: 0x02000007 RID: 7
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	public class PlayerManager : MonoBehaviour
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000020A1 File Offset: 0x000002A1
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		[global::Cpp2ILInjected.Address(RVA = "0x198D924", Offset = "0x198D924", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "add_OnDeviceDetached", MemberParameters = new object[] { typeof(Action<InputDevice>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActions), Member = "CreateWithKeyboardBindings", ReturnType = typeof(PlayerActions))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActions), Member = "CreateWithJoystickBindings", ReturnType = typeof(PlayerActions))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020A4 File Offset: 0x000002A4
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		[global::Cpp2ILInjected.Address(RVA = "0x198D9DC", Offset = "0x198D9DC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "remove_OnDeviceDetached", MemberParameters = new object[] { typeof(Action<InputDevice>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "Destroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020A7 File Offset: 0x000002A7
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x198DA98", Offset = "0x198DA98", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "JoinButtonWasPressedOnListener", MemberParameters = new object[] { typeof(PlayerActions) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "ThereIsNoPlayerUsingJoystick", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "CreatePlayer", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "ThereIsNoPlayerUsingKeyboard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020AA File Offset: 0x000002AA
		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x198DB48", Offset = "0x198DB48", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_WasPressed", ReturnType = typeof(bool))]
		private bool JoinButtonWasPressedOnListener(PlayerActions actions)
		{
			throw null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020AD File Offset: 0x000002AD
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x198DE98", Offset = "0x198DE98", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "ThereIsNoPlayerUsingJoystick", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "OnDeviceDetached", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Player FindPlayerUsingJoystick(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020B0 File Offset: 0x000002B0
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x198DB9C", Offset = "0x198DB9C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "FindPlayerUsingJoystick", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ThereIsNoPlayerUsingJoystick(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020B3 File Offset: 0x000002B3
		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x198DF54", Offset = "0x198DF54", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "ThereIsNoPlayerUsingKeyboard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Player FindPlayerUsingKeyboard()
		{
			throw null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020B6 File Offset: 0x000002B6
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x198DE2C", Offset = "0x198DE2C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "FindPlayerUsingKeyboard", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ThereIsNoPlayerUsingKeyboard()
		{
			throw null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020B9 File Offset: 0x000002B9
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x198E00C", Offset = "0x198E00C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "FindPlayerUsingJoystick", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnDeviceDetached(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020BC File Offset: 0x000002BC
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x198DC18", Offset = "0x198DC18", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector3>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector3>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "Instantiate", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T",
			typeof(Vector3),
			typeof(Quaternion)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActions), Member = "CreateWithJoystickBindings", ReturnType = typeof(PlayerActions))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private Player CreatePlayer(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020BF File Offset: 0x000002BF
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x198E0A8", Offset = "0x198E0A8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector3>), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "Destroy", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void RemovePlayer(Player player)
		{
			throw null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020C2 File Offset: 0x000002C2
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x198E18C", Offset = "0x198E18C", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "Label", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void OnGUI()
		{
			throw null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020C5 File Offset: 0x000002C5
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x198E324", Offset = "0x198E324", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector3>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public PlayerManager()
		{
			throw null;
		}

		// Token: 0x04000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public GameObject playerPrefab;

		// Token: 0x04000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		private const int maxPlayers = 4;

		// Token: 0x04000018 RID: 24
		[global::Cpp2ILInjected.Token(Token = "0x4000018")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<Vector3> playerPositions;

		// Token: 0x04000019 RID: 25
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<Player> players;

		// Token: 0x0400001A RID: 26
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private PlayerActions keyboardListener;

		// Token: 0x0400001B RID: 27
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private PlayerActions joystickListener;
	}
}
