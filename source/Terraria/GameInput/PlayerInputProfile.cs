using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameInput
{
	[global::Cpp2ILInjected.Token(Token = "0x20006CD")]
	public class PlayerInputProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000714")]
		public string ShowName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60039ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x146F1C4", Offset = "0x146F1C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000715")]
		public bool HotbarAllowsRadial
		{
			[global::Cpp2ILInjected.Token(Token = "0x60039EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x146F1CC", Offset = "0x146F1CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HandleHotbar", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "PostInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60039EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x146F1DC", Offset = "0x146F1DC", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyConfiguration), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "Add", MemberParameters = new object[]
		{
			"System.Int32Enum",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public PlayerInputProfile(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60039F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x146F368", Offset = "0x146F368", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyConfiguration), Member = "SetupKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "Reset", MemberParameters = new object[]
		{
			typeof(KeyConfiguration),
			typeof(PresetProfiles),
			typeof(InputMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void Initialize(PresetProfiles style)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60039F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x146F500", Offset = "0x146F500", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyGameplaySettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60039F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x146F70C", Offset = "0x146F70C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInputProfile), Member = "CopyKeysFrom", MemberParameters = new object[]
		{
			typeof(PlayerInputProfile),
			typeof(InputMode),
			typeof(TriggerNames[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyHotbarSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60039F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x146F7A4", Offset = "0x146F7A4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInputProfile), Member = "CopyKeysFrom", MemberParameters = new object[]
		{
			typeof(PlayerInputProfile),
			typeof(InputMode),
			typeof(TriggerNames[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyMapSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60039F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x146F83C", Offset = "0x146F83C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInputProfile), Member = "CopyKeysFrom", MemberParameters = new object[]
		{
			typeof(PlayerInputProfile),
			typeof(InputMode),
			typeof(TriggerNames[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyGamepadSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60039F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x146F8DC", Offset = "0x146F8DC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CopyGamepadAdvancedSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60039F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x146F598", Offset = "0x146F598", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInputProfile), Member = "CopyHotbarSettingsFrom", MemberParameters = new object[]
		{
			typeof(PlayerInputProfile),
			typeof(InputMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInputProfile), Member = "CopyMapSettingsFrom", MemberParameters = new object[]
		{
			typeof(PlayerInputProfile),
			typeof(InputMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInputProfile), Member = "CopyGamepadSettingsFrom", MemberParameters = new object[]
		{
			typeof(PlayerInputProfile),
			typeof(InputMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			"System.Int32Enum",
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void CopyKeysFrom(PlayerInputProfile profile, InputMode mode, TriggerNames[] keysToCopy)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60039F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x146F920", Offset = "0x146F920", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawRadialDpad", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool UsingDpadHotbar()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60039F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x146FC74", Offset = "0x146FC74", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TriggersSet), Member = "GetNavigatorDirections", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool UsingDpadMovekeys()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007A20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Dictionary<InputMode, KeyConfiguration> InputModes;

		[global::Cpp2ILInjected.Token(Token = "0x4007A21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string Name;

		[global::Cpp2ILInjected.Token(Token = "0x4007A22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool AllowEditting;

		[global::Cpp2ILInjected.Token(Token = "0x4007A23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int HotbarRadialHoldTimeRequired;

		[global::Cpp2ILInjected.Token(Token = "0x4007A24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public float TriggersDeadzone;

		[global::Cpp2ILInjected.Token(Token = "0x4007A25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float InterfaceDeadzoneX;

		[global::Cpp2ILInjected.Token(Token = "0x4007A26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float LeftThumbstickDeadzoneX;

		[global::Cpp2ILInjected.Token(Token = "0x4007A27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float LeftThumbstickDeadzoneY;

		[global::Cpp2ILInjected.Token(Token = "0x4007A28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public float RightThumbstickDeadzoneX;

		[global::Cpp2ILInjected.Token(Token = "0x4007A29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float RightThumbstickDeadzoneY;

		[global::Cpp2ILInjected.Token(Token = "0x4007A2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool LeftThumbstickInvertX;

		[global::Cpp2ILInjected.Token(Token = "0x4007A2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		public bool LeftThumbstickInvertY;

		[global::Cpp2ILInjected.Token(Token = "0x4007A2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
		public bool RightThumbstickInvertX;

		[global::Cpp2ILInjected.Token(Token = "0x4007A2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x43")]
		public bool RightThumbstickInvertY;

		[global::Cpp2ILInjected.Token(Token = "0x4007A2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int InventoryMoveCD;
	}
}
