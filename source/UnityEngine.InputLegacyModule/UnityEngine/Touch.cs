using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Input/InputBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public struct Touch
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public int fingerId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000001")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D20", Offset = "0x1FA0D20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CursorManager", Member = "GetTouchId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CursorManager", Member = "GetTouchIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "UpdateTouches", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ref bool),
				typeof(ref bool)
			}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public Vector2 position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000002")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D28", Offset = "0x1FA0D28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CursorManager", Member = "GetTouchPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Touch", Member = "SetWithTouchData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ref bool),
				typeof(ref bool)
			}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public int tapCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000003")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D30", Offset = "0x1FA0D30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Touch", Member = "SetWithTouchData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public TouchPhase phase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000004")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D38", Offset = "0x1FA0D38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CursorManager", Member = "GetTouchPhase", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TouchPhase))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Touch", Member = "SetWithTouchData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ref bool),
				typeof(ref bool)
			}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public float pressure
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000005")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D40", Offset = "0x1FA0D40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Touch", Member = "SetWithTouchData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ref bool),
				typeof(ref bool)
			}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public float maximumPossiblePressure
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000006")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D48", Offset = "0x1FA0D48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Touch", Member = "SetWithTouchData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		public TouchType type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000007")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D50", Offset = "0x1FA0D50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CursorManager", Member = "ShouldIgnoreTouch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.StandaloneInputModule", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.TouchInputModule", Member = "ProcessTouchEvents", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public float altitudeAngle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000008")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D58", Offset = "0x1FA0D58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Touch", Member = "SetWithTouchData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ref bool),
				typeof(ref bool)
			}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public float azimuthAngle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000009")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D60", Offset = "0x1FA0D60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Touch", Member = "SetWithTouchData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ref bool),
				typeof(ref bool)
			}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public float radius
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D68", Offset = "0x1FA0D68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Touch", Member = "SetWithTouchData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ref bool),
				typeof(ref bool)
			}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public float radiusVariance
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0D70", Offset = "0x1FA0D70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Touch", Member = "SetWithTouchData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new object[]
			{
				typeof(Touch),
				typeof(ref bool),
				typeof(ref bool)
			}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_FingerId;

		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private Vector2 m_Position;

		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private Vector2 m_RawPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private Vector2 m_PositionDelta;

		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private float m_TimeDelta;

		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_TapCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private TouchPhase m_Phase;

		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private TouchType m_Type;

		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float m_Pressure;

		[global::Cpp2ILInjected.Token(Token = "0x4000018")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private float m_maximumPossiblePressure;

		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private float m_Radius;

		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private float m_RadiusVariance;

		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private float m_AltitudeAngle;

		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private float m_AzimuthAngle;
	}
}
