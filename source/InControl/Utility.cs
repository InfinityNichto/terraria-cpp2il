﻿using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl.UnityDeviceProfiles;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000070")]
	public static class Utility
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000517")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7568", Offset = "0x19B7568", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utility), Member = "DrawCircleGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void DrawCircleGizmo(Vector2 center, float radius)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000518")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7684", Offset = "0x19B7684", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "DrawGizmos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "DrawCircleGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawCircleGizmo(Vector2 center, float radius, Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000519")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7730", Offset = "0x19B7730", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utility), Member = "DrawOvalGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void DrawOvalGizmo(Vector2 center, Vector2 size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B785C", Offset = "0x19B785C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "DrawGizmos", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "DrawOvalGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawOvalGizmo(Vector2 center, Vector2 size, Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7910", Offset = "0x19B7910", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utility), Member = "DrawRectGizmo", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		public static void DrawRectGizmo(Rect rect)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7A4C", Offset = "0x19B7A4C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "DrawGizmos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "DrawGizmos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchTrackControl), Member = "DrawGizmos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "DrawRectGizmo", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawRectGizmo(Rect rect, Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7B00", Offset = "0x19B7B00", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utility), Member = "DrawRectGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		public static void DrawRectGizmo(Vector2 center, Vector2 size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7BB4", Offset = "0x19B7BB4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "DrawGizmos", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "DrawRectGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawRectGizmo(Vector2 center, Vector2 size, Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7C68", Offset = "0x19B7C68", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_current", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
		public static bool GameObjectIsCulledOnCurrentCamera(GameObject gameObject)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000520")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7CB0", Offset = "0x19B7CB0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static Color MoveColorTowards(Color color0, Color color1, float maxDelta)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000521")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7D50", Offset = "0x19B7D50", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static float ApplyDeadZone(float value, float lowerDeadZone, float upperDeadZone)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000522")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7DB4", Offset = "0x19B7DB4", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static float ApplySmoothing(float thisValue, float lastValue, float deltaTime, float sensitivity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000523")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7F40", Offset = "0x19B7F40", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "TakeSnapshot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "GetFirstPressedAnalog", ReturnType = typeof(UnknownDeviceControl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static float ApplySnapping(float value, float threshold)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000524")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7F68", Offset = "0x19B7F68", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceControl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(InputRangeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceControl), Member = "Load", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(InputControlType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal static bool TargetIsButton(InputControlType target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000525")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7F8C", Offset = "0x19B7F8C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSource), Member = "get_IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControl), Member = "get_IsStandard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static bool TargetIsStandard(InputControlType target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000526")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7FB0", Offset = "0x19B7FB0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "RefreshProfile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputDeviceProfile),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		internal static bool TargetIsAlias(InputControlType target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000527")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7FC0", Offset = "0x19B7FC0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomInputDeviceProfile), Member = "LoadFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CustomInputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ReadFromFile(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000528")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8040", Offset = "0x19B8040", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomInputDeviceProfile), Member = "SaveToFile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void WriteToFile(string path, string data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000529")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B80D8", Offset = "0x19B80D8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "UpdateBindings", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "UpdateWithRawValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchMoved", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Contains", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		public static float Abs(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600052A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7EDC", Offset = "0x19B7EDC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControlState), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(InputControlState),
			typeof(InputControlState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControlState), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(InputControlState),
			typeof(InputControlState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static bool Approximately(float v1, float v2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600052B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B80E8", Offset = "0x19B80E8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool Approximately(Vector2 v1, Vector2 v2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600052C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7F08", Offset = "0x19B7F08", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSource), Member = "GetState", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSource), Member = "GetState", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControlSource), Member = "GetState", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControlState), Member = "Set", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "get_HasInput", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static bool IsNotZero(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600052D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B81AC", Offset = "0x19B81AC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchEnded", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "TouchCameraIsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public static bool IsZero(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600052E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B7F30", Offset = "0x19B7F30", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int Sign(float f)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600052F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B81D4", Offset = "0x19B81D4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSourceListener), Member = "IsPressed", MemberParameters = new object[] { typeof(InputControl) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSourceListener), Member = "IsPressed", MemberParameters = new object[]
		{
			typeof(UnknownDeviceControl),
			typeof(InputDevice)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControlState), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "UpdateInputState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static bool AbsoluteIsOverThreshold(float value, float threshold)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000530")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B81F0", Offset = "0x19B81F0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float NormalizeAngle(float angle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000531")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B823C", Offset = "0x19B823C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TwoAxisInputControl), Member = "get_Angle", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static float VectorToAngle(Vector2 vector)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000532")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8358", Offset = "0x19B8358", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float Min(float v0, float v1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000533")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8364", Offset = "0x19B8364", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "SubmitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static float Max(float v0, float v1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000534")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8370", Offset = "0x19B8370", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessLeftStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessRightStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessDPad", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static float Min(float v0, float v1, float v2, float v3)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000535")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B838C", Offset = "0x19B838C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessLeftStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessRightStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessDPad", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static float Max(float v0, float v1, float v2, float v3)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000536")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B83A8", Offset = "0x19B83A8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerOneAxisAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "CommitWithSides", MemberParameters = new object[]
		{
			typeof(InputControl),
			typeof(InputControl),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessLeftStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessRightStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessDPad", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utility), Member = "ValueFromSides", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static float ValueFromSides(float negativeSide, float positiveSide)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000537")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8454", Offset = "0x19B8454", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTwoAxisAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessLeftStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessRightStick", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "ProcessDPad", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "ValueFromSides", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static float ValueFromSides(float negativeSide, float positiveSide, bool invertSides)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000538")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A386C", Offset = "0x15A386C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "NextPowerOfTwo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void ArrayResize<T>(ref T[] array, int capacity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000539")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A365C", Offset = "0x15A365C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarshalUtility), Member = "Copy", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "NextPowerOfTwo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void ArrayExpand<T>(ref T[] array, int capacity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600053A")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3544", Offset = "0x15A3544", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ArrayAppend<T>(ref T[] array, T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600053B")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A35C4", Offset = "0x15A35C4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "ConstrainedCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ArrayAppend<T>(ref T[] array, T[] items)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600053C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B84D0", Offset = "0x19B84D0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utility), Member = "ArrayResize", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]&",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utility), Member = "ArrayExpand", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]&",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static int NextPowerOfTwo(int value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000167")]
		internal static bool Is32Bit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600053D")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B84FC", Offset = "0x19B84FC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "get_Size", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000168")]
		internal static bool Is64Bit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600053E")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B8518", Offset = "0x19B8518", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "get_Size", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600053F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8534", Offset = "0x19B8534", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "SetupInternal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "get_operatingSystem", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "get_deviceModel", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string GetPlatformName(bool uppercase = true)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000540")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B85B0", Offset = "0x19B85B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int GetSystemBuildNumber()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000541")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B85B8", Offset = "0x19B85B8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneManager), Member = "LoadScene", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void LoadScene(string sceneName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000542")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8610", Offset = "0x19B8610", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "CheckPlatformSupport", MemberParameters = new object[] { typeof(ICollection<string>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static string PluginFileExtension()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000543")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8650", Offset = "0x19B8650", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Utility()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003FB")]
		public const float Epsilon = 1E-07f;

		[global::Cpp2ILInjected.Token(Token = "0x40003FC")]
		private static readonly Vector2[] circleVertexList;
	}
}
