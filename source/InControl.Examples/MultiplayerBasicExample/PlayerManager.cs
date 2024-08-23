using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;
using UnityEngine;

namespace MultiplayerBasicExample
{
	// Token: 0x02000009 RID: 9
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public class PlayerManager : MonoBehaviour
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000020DA File Offset: 0x000002DA
		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x198E874", Offset = "0x198E874", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "add_OnDeviceDetached", MemberParameters = new object[] { typeof(Action<InputDevice>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020DD File Offset: 0x000002DD
		[global::Cpp2ILInjected.Token(Token = "0x6000030")]
		[global::Cpp2ILInjected.Address(RVA = "0x198E918", Offset = "0x198E918", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "JoinButtonWasPressedOnDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "ThereIsNoPlayerUsingDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "CreatePlayer", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020E0 File Offset: 0x000002E0
		[global::Cpp2ILInjected.Token(Token = "0x6000031")]
		[global::Cpp2ILInjected.Address(RVA = "0x198E9A4", Offset = "0x198E9A4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action1", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_WasPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action2", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action3", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action4", ReturnType = typeof(InputControl))]
		private bool JoinButtonWasPressedOnDevice(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020E3 File Offset: 0x000002E3
		[global::Cpp2ILInjected.Token(Token = "0x6000032")]
		[global::Cpp2ILInjected.Address(RVA = "0x198EC98", Offset = "0x198EC98", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "ThereIsNoPlayerUsingDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "OnDeviceDetached", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Player FindPlayerUsingDevice(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020E6 File Offset: 0x000002E6
		[global::Cpp2ILInjected.Token(Token = "0x6000033")]
		[global::Cpp2ILInjected.Address(RVA = "0x198EA18", Offset = "0x198EA18", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "FindPlayerUsingDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ThereIsNoPlayerUsingDevice(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020E9 File Offset: 0x000002E9
		[global::Cpp2ILInjected.Token(Token = "0x6000034")]
		[global::Cpp2ILInjected.Address(RVA = "0x198ED4C", Offset = "0x198ED4C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerManager), Member = "FindPlayerUsingDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(Player))]
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

		// Token: 0x06000035 RID: 53 RVA: 0x000020EC File Offset: 0x000002EC
		[global::Cpp2ILInjected.Token(Token = "0x6000035")]
		[global::Cpp2ILInjected.Address(RVA = "0x198EA94", Offset = "0x198EA94", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector3>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector3>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "Instantiate", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T",
			typeof(Vector3),
			typeof(Quaternion)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private Player CreatePlayer(InputDevice inputDevice)
		{
			throw null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020EF File Offset: 0x000002EF
		[global::Cpp2ILInjected.Token(Token = "0x6000036")]
		[global::Cpp2ILInjected.Address(RVA = "0x198EDE8", Offset = "0x198EDE8", Length = "0xE4")]
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

		// Token: 0x06000037 RID: 55 RVA: 0x000020F2 File Offset: 0x000002F2
		[global::Cpp2ILInjected.Token(Token = "0x6000037")]
		[global::Cpp2ILInjected.Address(RVA = "0x198EECC", Offset = "0x198EECC", Length = "0x198")]
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

		// Token: 0x06000038 RID: 56 RVA: 0x000020F5 File Offset: 0x000002F5
		[global::Cpp2ILInjected.Token(Token = "0x6000038")]
		[global::Cpp2ILInjected.Address(RVA = "0x198F064", Offset = "0x198F064", Length = "0x28C")]
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

		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public GameObject playerPrefab;

		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		private const int maxPlayers = 4;

		// Token: 0x04000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<Vector3> playerPositions;

		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<Player> players;
	}
}
