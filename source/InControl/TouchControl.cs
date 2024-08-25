using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x200004D")]
	public abstract class TouchControl : MonoBehaviour
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
		public abstract void CreateControl();

		[global::Cpp2ILInjected.Token(Token = "0x60003BA")]
		public abstract void DestroyControl();

		[global::Cpp2ILInjected.Token(Token = "0x60003BB")]
		public abstract void ConfigureControl();

		[global::Cpp2ILInjected.Token(Token = "0x60003BC")]
		public abstract void SubmitControlState(ulong updateTick, float deltaTime);

		[global::Cpp2ILInjected.Token(Token = "0x60003BD")]
		public abstract void CommitControlState(ulong updateTick, float deltaTime);

		[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
		public abstract void TouchBegan(Touch touch);

		[global::Cpp2ILInjected.Token(Token = "0x60003BF")]
		public abstract void TouchMoved(Touch touch);

		[global::Cpp2ILInjected.Token(Token = "0x60003C0")]
		public abstract void TouchEnded(Touch touch);

		[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
		public abstract void DrawGizmos();

		[global::Cpp2ILInjected.Token(Token = "0x60003C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A11E4", Offset = "0x19A11E4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void OnEnable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1318", Offset = "0x19A1318", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "UnloadUnusedAssets", ReturnType = typeof(AsyncOperation))]
		private void OnDisable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1334", Offset = "0x19A1334", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Setup()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x199DBE4", Offset = "0x199DBE4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "ConfigureControl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "ConfigureControl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchUtility), Member = "RoundVector", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_PixelToWorld", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_PercentToWorld", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_ViewSize", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchUtility), Member = "AnchorToViewPoint", MemberParameters = new object[] { typeof(TouchControlAnchor) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ViewToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		protected Vector3 OffsetToWorldPosition(TouchControlAnchor anchor, Vector2 offset, TouchUnitType offsetUnitType, bool lockAspectRatio)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E528", Offset = "0x199E528", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "SubmitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "SubmitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchTrackControl), Member = "SubmitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_Device", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "UpdateWithState", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void SubmitButtonState(TouchControl.ButtonTarget target, bool state, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E468", Offset = "0x199E468", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "SubmitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_Device", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void SubmitButtonValue(TouchControl.ButtonTarget target, float value, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E5FC", Offset = "0x199E5FC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "CommitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchTrackControl), Member = "CommitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_Device", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "Commit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void CommitButton(TouchControl.ButtonTarget target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x199F214", Offset = "0x199F214", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "SubmitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_Device", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeadZone), Member = "Circular", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "UpdateLeftStickWithValue", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "UpdateRightStickWithValue", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		protected void SubmitAnalogValue(TouchControl.AnalogTarget target, Vector2 value, float lowerDeadZone, float upperDeadZone, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x199F300", Offset = "0x199F300", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "CommitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchTrackControl), Member = "CommitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_Device", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "CommitLeftStick", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "CommitRightStick", ReturnType = typeof(void))]
		protected void CommitAnalog(TouchControl.AnalogTarget target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0854", Offset = "0x19A0854", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchTrackControl), Member = "SubmitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_Device", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "UpdateLeftStickWithRawValue", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "UpdateRightStickWithRawValue", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		protected void SubmitRawAnalogValue(TouchControl.AnalogTarget target, Vector2 rawValue, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x199F9A8", Offset = "0x199F9A8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchMoved", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "SubmitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "SnapTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		protected static Vector3 SnapTo(Vector2 vector, TouchControl.SnapAngles snapAngles)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1734", Offset = "0x19A1734", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "GetButtonTargetForVector", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(TouchControl.ButtonTarget))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "SnapTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(TouchControl.SnapAngles)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector3)
		}, ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Quaternion),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected static Vector3 SnapTo(Vector2 vector, float snapAngle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1A58", Offset = "0x19A1A58", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_ControlsShowGizmos", ReturnType = typeof(TouchManager.GizmoShowOption))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "GameObjectIsCulledOnCurrentCamera", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void OnDrawGizmosSelected()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1B88", Offset = "0x19A1B88", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_ControlsShowGizmos", ReturnType = typeof(TouchManager.GizmoShowOption))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "GameObjectIsCulledOnCurrentCamera", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x199EAC0", Offset = "0x199EAC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected TouchControl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200004E")]
		public enum ButtonTarget
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000357")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4000358")]
			DPadDown = 12,
			[global::Cpp2ILInjected.Token(Token = "0x4000359")]
			DPadLeft,
			[global::Cpp2ILInjected.Token(Token = "0x400035A")]
			DPadRight,
			[global::Cpp2ILInjected.Token(Token = "0x400035B")]
			DPadUp = 11,
			[global::Cpp2ILInjected.Token(Token = "0x400035C")]
			LeftTrigger = 15,
			[global::Cpp2ILInjected.Token(Token = "0x400035D")]
			RightTrigger,
			[global::Cpp2ILInjected.Token(Token = "0x400035E")]
			LeftBumper,
			[global::Cpp2ILInjected.Token(Token = "0x400035F")]
			RightBumper,
			[global::Cpp2ILInjected.Token(Token = "0x4000360")]
			Action1,
			[global::Cpp2ILInjected.Token(Token = "0x4000361")]
			Action2,
			[global::Cpp2ILInjected.Token(Token = "0x4000362")]
			Action3,
			[global::Cpp2ILInjected.Token(Token = "0x4000363")]
			Action4,
			[global::Cpp2ILInjected.Token(Token = "0x4000364")]
			Action5,
			[global::Cpp2ILInjected.Token(Token = "0x4000365")]
			Action6,
			[global::Cpp2ILInjected.Token(Token = "0x4000366")]
			Action7,
			[global::Cpp2ILInjected.Token(Token = "0x4000367")]
			Action8,
			[global::Cpp2ILInjected.Token(Token = "0x4000368")]
			Action9,
			[global::Cpp2ILInjected.Token(Token = "0x4000369")]
			Action10,
			[global::Cpp2ILInjected.Token(Token = "0x400036A")]
			Action11,
			[global::Cpp2ILInjected.Token(Token = "0x400036B")]
			Action12,
			[global::Cpp2ILInjected.Token(Token = "0x400036C")]
			Menu = 106,
			[global::Cpp2ILInjected.Token(Token = "0x400036D")]
			Button0 = 500,
			[global::Cpp2ILInjected.Token(Token = "0x400036E")]
			Button1,
			[global::Cpp2ILInjected.Token(Token = "0x400036F")]
			Button2,
			[global::Cpp2ILInjected.Token(Token = "0x4000370")]
			Button3,
			[global::Cpp2ILInjected.Token(Token = "0x4000371")]
			Button4,
			[global::Cpp2ILInjected.Token(Token = "0x4000372")]
			Button5,
			[global::Cpp2ILInjected.Token(Token = "0x4000373")]
			Button6,
			[global::Cpp2ILInjected.Token(Token = "0x4000374")]
			Button7,
			[global::Cpp2ILInjected.Token(Token = "0x4000375")]
			Button8,
			[global::Cpp2ILInjected.Token(Token = "0x4000376")]
			Button9,
			[global::Cpp2ILInjected.Token(Token = "0x4000377")]
			Button10,
			[global::Cpp2ILInjected.Token(Token = "0x4000378")]
			Button11,
			[global::Cpp2ILInjected.Token(Token = "0x4000379")]
			Button12,
			[global::Cpp2ILInjected.Token(Token = "0x400037A")]
			Button13,
			[global::Cpp2ILInjected.Token(Token = "0x400037B")]
			Button14,
			[global::Cpp2ILInjected.Token(Token = "0x400037C")]
			Button15,
			[global::Cpp2ILInjected.Token(Token = "0x400037D")]
			Button16,
			[global::Cpp2ILInjected.Token(Token = "0x400037E")]
			Button17,
			[global::Cpp2ILInjected.Token(Token = "0x400037F")]
			Button18,
			[global::Cpp2ILInjected.Token(Token = "0x4000380")]
			Button19
		}

		[global::Cpp2ILInjected.Token(Token = "0x200004F")]
		public enum AnalogTarget
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000382")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4000383")]
			LeftStick,
			[global::Cpp2ILInjected.Token(Token = "0x4000384")]
			RightStick,
			[global::Cpp2ILInjected.Token(Token = "0x4000385")]
			Both
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000050")]
		public enum SnapAngles
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000387")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4000388")]
			Four = 4,
			[global::Cpp2ILInjected.Token(Token = "0x4000389")]
			Eight = 8,
			[global::Cpp2ILInjected.Token(Token = "0x400038A")]
			Sixteen = 16
		}
	}
}
