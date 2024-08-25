using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x200004B")]
	public class TouchTrackControl : TouchControl
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A06B0", Offset = "0x19A06B0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void CreateControl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A06BC", Offset = "0x19A06BC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void DestroyControl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A06E4", Offset = "0x19A06E4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ConvertToWorld", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(TouchUnitType)
		}, ReturnType = typeof(Rect))]
		public override void ConfigureControl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A070C", Offset = "0x19A070C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "DrawRectGizmo", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void DrawGizmos()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A07A0", Offset = "0x19A07A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnValidate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A07B4", Offset = "0x19A07B4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A07DC", Offset = "0x19A07DC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "SubmitRawAnalogValue", MemberParameters = new object[]
		{
			typeof(TouchControl.AnalogTarget),
			typeof(Vector2),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "SubmitButtonState", MemberParameters = new object[]
		{
			typeof(TouchControl.ButtonTarget),
			typeof(bool),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0904", Offset = "0x19A0904", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "CommitAnalog", MemberParameters = new object[] { typeof(TouchControl.AnalogTarget) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "CommitButton", MemberParameters = new object[] { typeof(TouchControl.ButtonTarget) }, ReturnType = typeof(void))]
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0920", Offset = "0x19A0920", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "Contains", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ScreenToViewPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
		public override void TouchBegan(Touch touch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0A24", Offset = "0x19A0A24", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ScreenToViewPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		public override void TouchMoved(Touch touch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0A60", Offset = "0x19A0A60", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void TouchEnded(Touch touch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000122")]
		public Rect ActiveArea
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A0BB0", Offset = "0x19A0BB0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A0BBC", Offset = "0x19A0BBC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Rect)
			}, ReturnType = typeof(bool))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000123")]
		public TouchUnitType AreaUnitType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A0C24", Offset = "0x19A0C24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A0C2C", Offset = "0x19A0C2C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0C48", Offset = "0x19A0C48", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		public TouchTrackControl()
		{
			throw null;
		}

		[Header("Dimensions")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000334")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TouchUnitType areaUnitType;

		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000335")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Rect activeArea;

		[Header("Analog Target")]
		[global::Cpp2ILInjected.Token(Token = "0x4000336")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public TouchControl.AnalogTarget target;

		[global::Cpp2ILInjected.Token(Token = "0x4000337")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float scale;

		[Header("Button Target")]
		[global::Cpp2ILInjected.Token(Token = "0x4000338")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public TouchControl.ButtonTarget tapTarget;

		[global::Cpp2ILInjected.Token(Token = "0x4000339")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public float maxTapDuration;

		[global::Cpp2ILInjected.Token(Token = "0x400033A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float maxTapMovement;

		[global::Cpp2ILInjected.Token(Token = "0x400033B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Rect worldActiveArea;

		[global::Cpp2ILInjected.Token(Token = "0x400033C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Vector3 lastPosition;

		[global::Cpp2ILInjected.Token(Token = "0x400033D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private Vector3 thisPosition;

		[global::Cpp2ILInjected.Token(Token = "0x400033E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Touch currentTouch;

		[global::Cpp2ILInjected.Token(Token = "0x400033F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool dirty;

		[global::Cpp2ILInjected.Token(Token = "0x4000340")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool fireButtonTarget;

		[global::Cpp2ILInjected.Token(Token = "0x4000341")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private float beganTime;

		[global::Cpp2ILInjected.Token(Token = "0x4000342")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Vector3 beganPosition;
	}
}
