using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000048 RID: 72
	[global::Cpp2ILInjected.Token(Token = "0x200004D")]
	public abstract class TouchControl : MonoBehaviour
	{
		// Token: 0x060003B0 RID: 944
		[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
		public abstract void CreateControl();

		// Token: 0x060003B1 RID: 945
		[global::Cpp2ILInjected.Token(Token = "0x60003BA")]
		public abstract void DestroyControl();

		// Token: 0x060003B2 RID: 946
		[global::Cpp2ILInjected.Token(Token = "0x60003BB")]
		public abstract void ConfigureControl();

		// Token: 0x060003B3 RID: 947
		[global::Cpp2ILInjected.Token(Token = "0x60003BC")]
		public abstract void SubmitControlState(ulong updateTick, float deltaTime);

		// Token: 0x060003B4 RID: 948
		[global::Cpp2ILInjected.Token(Token = "0x60003BD")]
		public abstract void CommitControlState(ulong updateTick, float deltaTime);

		// Token: 0x060003B5 RID: 949
		[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
		public abstract void TouchBegan(Touch touch);

		// Token: 0x060003B6 RID: 950
		[global::Cpp2ILInjected.Token(Token = "0x60003BF")]
		public abstract void TouchMoved(Touch touch);

		// Token: 0x060003B7 RID: 951
		[global::Cpp2ILInjected.Token(Token = "0x60003C0")]
		public abstract void TouchEnded(Touch touch);

		// Token: 0x060003B8 RID: 952
		[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
		public abstract void DrawGizmos();

		// Token: 0x060003B9 RID: 953 RVA: 0x00002B5B File Offset: 0x00000D5B
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

		// Token: 0x060003BA RID: 954 RVA: 0x00002B5E File Offset: 0x00000D5E
		[global::Cpp2ILInjected.Token(Token = "0x60003C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1318", Offset = "0x19A1318", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "UnloadUnusedAssets", ReturnType = typeof(AsyncOperation))]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002B61 File Offset: 0x00000D61
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

		// Token: 0x060003BC RID: 956 RVA: 0x00002B64 File Offset: 0x00000D64
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

		// Token: 0x060003BD RID: 957 RVA: 0x00002B67 File Offset: 0x00000D67
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

		// Token: 0x060003BE RID: 958 RVA: 0x00002B6A File Offset: 0x00000D6A
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

		// Token: 0x060003BF RID: 959 RVA: 0x00002B6D File Offset: 0x00000D6D
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

		// Token: 0x060003C0 RID: 960 RVA: 0x00002B70 File Offset: 0x00000D70
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

		// Token: 0x060003C1 RID: 961 RVA: 0x00002B73 File Offset: 0x00000D73
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

		// Token: 0x060003C2 RID: 962 RVA: 0x00002B76 File Offset: 0x00000D76
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

		// Token: 0x060003C3 RID: 963 RVA: 0x00002B79 File Offset: 0x00000D79
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

		// Token: 0x060003C4 RID: 964 RVA: 0x00002B7C File Offset: 0x00000D7C
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

		// Token: 0x060003C5 RID: 965 RVA: 0x00002B7F File Offset: 0x00000D7F
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

		// Token: 0x060003C6 RID: 966 RVA: 0x00002B82 File Offset: 0x00000D82
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

		// Token: 0x060003C7 RID: 967 RVA: 0x00002B85 File Offset: 0x00000D85
		[global::Cpp2ILInjected.Token(Token = "0x60003D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x199EAC0", Offset = "0x199EAC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected TouchControl()
		{
			throw null;
		}

		// Token: 0x020001EF RID: 495
		[global::Cpp2ILInjected.Token(Token = "0x200004E")]
		public enum ButtonTarget
		{
			// Token: 0x040003E2 RID: 994
			[global::Cpp2ILInjected.Token(Token = "0x4000357")]
			None,
			// Token: 0x040003E3 RID: 995
			[global::Cpp2ILInjected.Token(Token = "0x4000358")]
			DPadDown = 12,
			// Token: 0x040003E4 RID: 996
			[global::Cpp2ILInjected.Token(Token = "0x4000359")]
			DPadLeft,
			// Token: 0x040003E5 RID: 997
			[global::Cpp2ILInjected.Token(Token = "0x400035A")]
			DPadRight,
			// Token: 0x040003E6 RID: 998
			[global::Cpp2ILInjected.Token(Token = "0x400035B")]
			DPadUp = 11,
			// Token: 0x040003E7 RID: 999
			[global::Cpp2ILInjected.Token(Token = "0x400035C")]
			LeftTrigger = 15,
			// Token: 0x040003E8 RID: 1000
			[global::Cpp2ILInjected.Token(Token = "0x400035D")]
			RightTrigger,
			// Token: 0x040003E9 RID: 1001
			[global::Cpp2ILInjected.Token(Token = "0x400035E")]
			LeftBumper,
			// Token: 0x040003EA RID: 1002
			[global::Cpp2ILInjected.Token(Token = "0x400035F")]
			RightBumper,
			// Token: 0x040003EB RID: 1003
			[global::Cpp2ILInjected.Token(Token = "0x4000360")]
			Action1,
			// Token: 0x040003EC RID: 1004
			[global::Cpp2ILInjected.Token(Token = "0x4000361")]
			Action2,
			// Token: 0x040003ED RID: 1005
			[global::Cpp2ILInjected.Token(Token = "0x4000362")]
			Action3,
			// Token: 0x040003EE RID: 1006
			[global::Cpp2ILInjected.Token(Token = "0x4000363")]
			Action4,
			// Token: 0x040003EF RID: 1007
			[global::Cpp2ILInjected.Token(Token = "0x4000364")]
			Action5,
			// Token: 0x040003F0 RID: 1008
			[global::Cpp2ILInjected.Token(Token = "0x4000365")]
			Action6,
			// Token: 0x040003F1 RID: 1009
			[global::Cpp2ILInjected.Token(Token = "0x4000366")]
			Action7,
			// Token: 0x040003F2 RID: 1010
			[global::Cpp2ILInjected.Token(Token = "0x4000367")]
			Action8,
			// Token: 0x040003F3 RID: 1011
			[global::Cpp2ILInjected.Token(Token = "0x4000368")]
			Action9,
			// Token: 0x040003F4 RID: 1012
			[global::Cpp2ILInjected.Token(Token = "0x4000369")]
			Action10,
			// Token: 0x040003F5 RID: 1013
			[global::Cpp2ILInjected.Token(Token = "0x400036A")]
			Action11,
			// Token: 0x040003F6 RID: 1014
			[global::Cpp2ILInjected.Token(Token = "0x400036B")]
			Action12,
			// Token: 0x040003F7 RID: 1015
			[global::Cpp2ILInjected.Token(Token = "0x400036C")]
			Menu = 106,
			// Token: 0x040003F8 RID: 1016
			[global::Cpp2ILInjected.Token(Token = "0x400036D")]
			Button0 = 500,
			// Token: 0x040003F9 RID: 1017
			[global::Cpp2ILInjected.Token(Token = "0x400036E")]
			Button1,
			// Token: 0x040003FA RID: 1018
			[global::Cpp2ILInjected.Token(Token = "0x400036F")]
			Button2,
			// Token: 0x040003FB RID: 1019
			[global::Cpp2ILInjected.Token(Token = "0x4000370")]
			Button3,
			// Token: 0x040003FC RID: 1020
			[global::Cpp2ILInjected.Token(Token = "0x4000371")]
			Button4,
			// Token: 0x040003FD RID: 1021
			[global::Cpp2ILInjected.Token(Token = "0x4000372")]
			Button5,
			// Token: 0x040003FE RID: 1022
			[global::Cpp2ILInjected.Token(Token = "0x4000373")]
			Button6,
			// Token: 0x040003FF RID: 1023
			[global::Cpp2ILInjected.Token(Token = "0x4000374")]
			Button7,
			// Token: 0x04000400 RID: 1024
			[global::Cpp2ILInjected.Token(Token = "0x4000375")]
			Button8,
			// Token: 0x04000401 RID: 1025
			[global::Cpp2ILInjected.Token(Token = "0x4000376")]
			Button9,
			// Token: 0x04000402 RID: 1026
			[global::Cpp2ILInjected.Token(Token = "0x4000377")]
			Button10,
			// Token: 0x04000403 RID: 1027
			[global::Cpp2ILInjected.Token(Token = "0x4000378")]
			Button11,
			// Token: 0x04000404 RID: 1028
			[global::Cpp2ILInjected.Token(Token = "0x4000379")]
			Button12,
			// Token: 0x04000405 RID: 1029
			[global::Cpp2ILInjected.Token(Token = "0x400037A")]
			Button13,
			// Token: 0x04000406 RID: 1030
			[global::Cpp2ILInjected.Token(Token = "0x400037B")]
			Button14,
			// Token: 0x04000407 RID: 1031
			[global::Cpp2ILInjected.Token(Token = "0x400037C")]
			Button15,
			// Token: 0x04000408 RID: 1032
			[global::Cpp2ILInjected.Token(Token = "0x400037D")]
			Button16,
			// Token: 0x04000409 RID: 1033
			[global::Cpp2ILInjected.Token(Token = "0x400037E")]
			Button17,
			// Token: 0x0400040A RID: 1034
			[global::Cpp2ILInjected.Token(Token = "0x400037F")]
			Button18,
			// Token: 0x0400040B RID: 1035
			[global::Cpp2ILInjected.Token(Token = "0x4000380")]
			Button19
		}

		// Token: 0x020001F0 RID: 496
		[global::Cpp2ILInjected.Token(Token = "0x200004F")]
		public enum AnalogTarget
		{
			// Token: 0x0400040D RID: 1037
			[global::Cpp2ILInjected.Token(Token = "0x4000382")]
			None,
			// Token: 0x0400040E RID: 1038
			[global::Cpp2ILInjected.Token(Token = "0x4000383")]
			LeftStick,
			// Token: 0x0400040F RID: 1039
			[global::Cpp2ILInjected.Token(Token = "0x4000384")]
			RightStick,
			// Token: 0x04000410 RID: 1040
			[global::Cpp2ILInjected.Token(Token = "0x4000385")]
			Both
		}

		// Token: 0x020001F1 RID: 497
		[global::Cpp2ILInjected.Token(Token = "0x2000050")]
		public enum SnapAngles
		{
			// Token: 0x04000412 RID: 1042
			[global::Cpp2ILInjected.Token(Token = "0x4000387")]
			None,
			// Token: 0x04000413 RID: 1043
			[global::Cpp2ILInjected.Token(Token = "0x4000388")]
			Four = 4,
			// Token: 0x04000414 RID: 1044
			[global::Cpp2ILInjected.Token(Token = "0x4000389")]
			Eight = 8,
			// Token: 0x04000415 RID: 1045
			[global::Cpp2ILInjected.Token(Token = "0x400038A")]
			Sixteen = 16
		}
	}
}
