using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000047 RID: 71
	[global::Cpp2ILInjected.Token(Token = "0x200004C")]
	public class Touch
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x00002B46 File Offset: 0x00000D46
		[global::Cpp2ILInjected.Token(Token = "0x60003B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0CB0", Offset = "0x19A0CB0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal Touch()
		{
			throw null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002B49 File Offset: 0x00000D49
		[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0CD8", Offset = "0x19A0CD8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchPool), Member = "FreeTouch", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void Reset()
		{
			throw null;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00002B4C File Offset: 0x00000D4C
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00002B4F File Offset: 0x00000D4F
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00002B52 File Offset: 0x00000D52
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

		// Token: 0x060003AE RID: 942 RVA: 0x00002B55 File Offset: 0x00000D55
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

		// Token: 0x060003AF RID: 943 RVA: 0x00002B58 File Offset: 0x00000D58
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

		// Token: 0x04000334 RID: 820
		[global::Cpp2ILInjected.Token(Token = "0x4000343")]
		public const int FingerID_None = -1;

		// Token: 0x04000335 RID: 821
		[global::Cpp2ILInjected.Token(Token = "0x4000344")]
		public const int FingerID_Mouse = -2;

		// Token: 0x04000336 RID: 822
		[global::Cpp2ILInjected.Token(Token = "0x4000345")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int fingerId;

		// Token: 0x04000337 RID: 823
		[global::Cpp2ILInjected.Token(Token = "0x4000346")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int mouseButton;

		// Token: 0x04000338 RID: 824
		[global::Cpp2ILInjected.Token(Token = "0x4000347")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public TouchPhase phase;

		// Token: 0x04000339 RID: 825
		[global::Cpp2ILInjected.Token(Token = "0x4000348")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int tapCount;

		// Token: 0x0400033A RID: 826
		[global::Cpp2ILInjected.Token(Token = "0x4000349")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Vector2 position;

		// Token: 0x0400033B RID: 827
		[global::Cpp2ILInjected.Token(Token = "0x400034A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Vector2 startPosition;

		// Token: 0x0400033C RID: 828
		[global::Cpp2ILInjected.Token(Token = "0x400034B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Vector2 deltaPosition;

		// Token: 0x0400033D RID: 829
		[global::Cpp2ILInjected.Token(Token = "0x400034C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Vector2 lastPosition;

		// Token: 0x0400033E RID: 830
		[global::Cpp2ILInjected.Token(Token = "0x400034D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public float deltaTime;

		// Token: 0x0400033F RID: 831
		[global::Cpp2ILInjected.Token(Token = "0x400034E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public ulong updateTick;

		// Token: 0x04000340 RID: 832
		[global::Cpp2ILInjected.Token(Token = "0x400034F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public TouchType type;

		// Token: 0x04000341 RID: 833
		[global::Cpp2ILInjected.Token(Token = "0x4000350")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public float altitudeAngle;

		// Token: 0x04000342 RID: 834
		[global::Cpp2ILInjected.Token(Token = "0x4000351")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float azimuthAngle;

		// Token: 0x04000343 RID: 835
		[global::Cpp2ILInjected.Token(Token = "0x4000352")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public float maximumPossiblePressure;

		// Token: 0x04000344 RID: 836
		[global::Cpp2ILInjected.Token(Token = "0x4000353")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public float pressure;

		// Token: 0x04000345 RID: 837
		[global::Cpp2ILInjected.Token(Token = "0x4000354")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public float radius;

		// Token: 0x04000346 RID: 838
		[global::Cpp2ILInjected.Token(Token = "0x4000355")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public float radiusVariance;
	}
}
