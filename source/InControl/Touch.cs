using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x200004C")]
	public class Touch
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0CB0", Offset = "0x19A0CB0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal Touch()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0CD8", Offset = "0x19A0CD8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchPool), Member = "FreeTouch", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void Reset()
		{
			throw null;
		}

		[Obsolete("normalizedPressure is deprecated, please use NormalizedPressure instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000124")]
		public float normalizedPressure
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A0D70", Offset = "0x19A0D70", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000125")]
		public float NormalizedPressure
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E410", Offset = "0x199E410", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000126")]
		public bool IsMouse
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A0D94", Offset = "0x19A0D94", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0DA4", Offset = "0x19A0DA4", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "UpdateTouches", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_tapCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_altitudeAngle", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_azimuthAngle", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_maximumPossiblePressure", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_pressure", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_radius", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_radiusVariance", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void SetWithTouchData(Touch touch, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0F2C", Offset = "0x19A0F2C", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal bool SetWithMouseData(int button, ulong updateTick, float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000343")]
		public const int FingerID_None = -1;

		[global::Cpp2ILInjected.Token(Token = "0x4000344")]
		public const int FingerID_Mouse = -2;

		[global::Cpp2ILInjected.Token(Token = "0x4000345")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int fingerId;

		[global::Cpp2ILInjected.Token(Token = "0x4000346")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int mouseButton;

		[global::Cpp2ILInjected.Token(Token = "0x4000347")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public TouchPhase phase;

		[global::Cpp2ILInjected.Token(Token = "0x4000348")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int tapCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000349")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Vector2 position;

		[global::Cpp2ILInjected.Token(Token = "0x400034A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Vector2 startPosition;

		[global::Cpp2ILInjected.Token(Token = "0x400034B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Vector2 deltaPosition;

		[global::Cpp2ILInjected.Token(Token = "0x400034C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Vector2 lastPosition;

		[global::Cpp2ILInjected.Token(Token = "0x400034D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public float deltaTime;

		[global::Cpp2ILInjected.Token(Token = "0x400034E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public ulong updateTick;

		[global::Cpp2ILInjected.Token(Token = "0x400034F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public TouchType type;

		[global::Cpp2ILInjected.Token(Token = "0x4000350")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public float altitudeAngle;

		[global::Cpp2ILInjected.Token(Token = "0x4000351")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float azimuthAngle;

		[global::Cpp2ILInjected.Token(Token = "0x4000352")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public float maximumPossiblePressure;

		[global::Cpp2ILInjected.Token(Token = "0x4000353")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public float pressure;

		[global::Cpp2ILInjected.Token(Token = "0x4000354")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public float radius;

		[global::Cpp2ILInjected.Token(Token = "0x4000355")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public float radiusVariance;
	}
}
