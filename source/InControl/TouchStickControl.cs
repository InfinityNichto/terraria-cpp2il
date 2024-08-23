using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000044 RID: 68
	[global::Cpp2ILInjected.Token(Token = "0x2000049")]
	public class TouchStickControl : TouchControl
	{
		// Token: 0x0600036E RID: 878 RVA: 0x00002A95 File Offset: 0x00000C95
		[global::Cpp2ILInjected.Token(Token = "0x6000377")]
		[global::Cpp2ILInjected.Address(RVA = "0x199EAC8", Offset = "0x199EAC8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Transform),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void CreateControl()
		{
			throw null;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002A98 File Offset: 0x00000C98
		[global::Cpp2ILInjected.Token(Token = "0x6000378")]
		[global::Cpp2ILInjected.Address(RVA = "0x199EB68", Offset = "0x199EB68", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Delete", ReturnType = typeof(void))]
		public override void DestroyControl()
		{
			throw null;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002A9B File Offset: 0x00000C9B
		[global::Cpp2ILInjected.Token(Token = "0x6000379")]
		[global::Cpp2ILInjected.Address(RVA = "0x199EBA4", Offset = "0x199EBA4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "OffsetToWorldPosition", MemberParameters = new object[]
		{
			typeof(TouchControlAnchor),
			typeof(Vector2),
			typeof(TouchUnitType),
			typeof(bool)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ConvertToWorld", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(TouchUnitType)
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_PixelToWorld", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_PercentToWorld", ReturnType = typeof(float))]
		public override void ConfigureControl()
		{
			throw null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002A9E File Offset: 0x00000C9E
		[global::Cpp2ILInjected.Token(Token = "0x600037A")]
		[global::Cpp2ILInjected.Address(RVA = "0x199EC88", Offset = "0x199EC88", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchStickControl), Member = "get_RingPosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "DrawGizmos", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchStickControl), Member = "get_KnobPosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "DrawCircleGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
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

		// Token: 0x06000372 RID: 882 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::Cpp2ILInjected.Token(Token = "0x600037B")]
		[global::Cpp2ILInjected.Address(RVA = "0x199EDFC", Offset = "0x199EDFC", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchStickControl), Member = "get_KnobPosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchStickControl), Member = "get_RingPosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "set_Position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[global::Cpp2ILInjected.Token(Token = "0x600037C")]
		[global::Cpp2ILInjected.Address(RVA = "0x199F1F8", Offset = "0x199F1F8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002AA7 File Offset: 0x00000CA7
		[global::Cpp2ILInjected.Token(Token = "0x600037D")]
		[global::Cpp2ILInjected.Address(RVA = "0x199F2F8", Offset = "0x199F2F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002AAA File Offset: 0x00000CAA
		[global::Cpp2ILInjected.Token(Token = "0x600037E")]
		[global::Cpp2ILInjected.Address(RVA = "0x199F35C", Offset = "0x199F35C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "Contains", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Contains", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "set_Position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchStickControl), Member = "get_RingPosition", ReturnType = typeof(Vector3))]
		public override void TouchBegan(Touch touch)
		{
			throw null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002AAD File Offset: 0x00000CAD
		[global::Cpp2ILInjected.Token(Token = "0x600037F")]
		[global::Cpp2ILInjected.Address(RVA = "0x199F614", Offset = "0x199F614", Length = "0x394")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "set_Position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "SnapTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(TouchControl.SnapAngles)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "Abs", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void TouchMoved(Touch touch)
		{
			throw null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002AB0 File Offset: 0x00000CB0
		[global::Cpp2ILInjected.Token(Token = "0x6000380")]
		[global::Cpp2ILInjected.Address(RVA = "0x199F9D4", Offset = "0x199F9D4", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchStickControl), Member = "get_RingPosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "IsZero", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchStickControl), Member = "get_KnobPosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void TouchEnded(Touch touch)
		{
			throw null;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00002AB3 File Offset: 0x00000CB3
		[global::Cpp2ILInjected.Token(Token = "0x17000117")]
		public bool IsActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000381")]
			[global::Cpp2ILInjected.Address(RVA = "0x199F480", Offset = "0x199F480", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00002AB6 File Offset: 0x00000CB6
		[global::Cpp2ILInjected.Token(Token = "0x17000118")]
		public bool IsNotActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000382")]
			[global::Cpp2ILInjected.Address(RVA = "0x199F1C0", Offset = "0x199F1C0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00002AB9 File Offset: 0x00000CB9
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00002ABC File Offset: 0x00000CBC
		[global::Cpp2ILInjected.Token(Token = "0x17000119")]
		public Vector3 RingPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000383")]
			[global::Cpp2ILInjected.Address(RVA = "0x199ED9C", Offset = "0x199ED9C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "DrawGizmos", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchBegan", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchEnded", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "get_Position", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000384")]
			[global::Cpp2ILInjected.Address(RVA = "0x199F1D0", Offset = "0x199F1D0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "set_Position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00002ABF File Offset: 0x00000CBF
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00002AC2 File Offset: 0x00000CC2
		[global::Cpp2ILInjected.Token(Token = "0x1700011A")]
		public Vector3 KnobPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000385")]
			[global::Cpp2ILInjected.Address(RVA = "0x199EDCC", Offset = "0x199EDCC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "DrawGizmos", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchEnded", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "get_Position", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000386")]
			[global::Cpp2ILInjected.Address(RVA = "0x199F1E4", Offset = "0x199F1E4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "set_Position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00002AC5 File Offset: 0x00000CC5
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00002AC8 File Offset: 0x00000CC8
		[global::Cpp2ILInjected.Token(Token = "0x1700011B")]
		public TouchControlAnchor Anchor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000387")]
			[global::Cpp2ILInjected.Address(RVA = "0x199FC10", Offset = "0x199FC10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000388")]
			[global::Cpp2ILInjected.Address(RVA = "0x199FC18", Offset = "0x199FC18", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00002ACB File Offset: 0x00000CCB
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00002ACE File Offset: 0x00000CCE
		[global::Cpp2ILInjected.Token(Token = "0x1700011C")]
		public Vector2 Offset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000389")]
			[global::Cpp2ILInjected.Address(RVA = "0x199FC34", Offset = "0x199FC34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600038A")]
			[global::Cpp2ILInjected.Address(RVA = "0x199FC3C", Offset = "0x199FC3C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00002AD1 File Offset: 0x00000CD1
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[global::Cpp2ILInjected.Token(Token = "0x1700011D")]
		public TouchUnitType OffsetUnitType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038B")]
			[global::Cpp2ILInjected.Address(RVA = "0x199FC74", Offset = "0x199FC74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600038C")]
			[global::Cpp2ILInjected.Address(RVA = "0x199FC7C", Offset = "0x199FC7C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00002AD7 File Offset: 0x00000CD7
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00002ADA File Offset: 0x00000CDA
		[global::Cpp2ILInjected.Token(Token = "0x1700011E")]
		public Rect ActiveArea
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038D")]
			[global::Cpp2ILInjected.Address(RVA = "0x199FC98", Offset = "0x199FC98", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600038E")]
			[global::Cpp2ILInjected.Address(RVA = "0x199FCA4", Offset = "0x199FCA4", Length = "0x68")]
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

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00002ADD File Offset: 0x00000CDD
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00002AE0 File Offset: 0x00000CE0
		[global::Cpp2ILInjected.Token(Token = "0x1700011F")]
		public TouchUnitType AreaUnitType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038F")]
			[global::Cpp2ILInjected.Address(RVA = "0x199FD0C", Offset = "0x199FD0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000390")]
			[global::Cpp2ILInjected.Address(RVA = "0x199FD14", Offset = "0x199FD14", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002AE3 File Offset: 0x00000CE3
		[global::Cpp2ILInjected.Token(Token = "0x6000391")]
		[global::Cpp2ILInjected.Address(RVA = "0x199FD30", Offset = "0x199FD30", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Linear", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(AnimationCurve))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public TouchStickControl()
		{
			throw null;
		}

		// Token: 0x040002F3 RID: 755
		[Header("Position")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000302")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TouchControlAnchor anchor;

		// Token: 0x040002F4 RID: 756
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000303")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private TouchUnitType offsetUnitType;

		// Token: 0x040002F5 RID: 757
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000304")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Vector2 offset;

		// Token: 0x040002F6 RID: 758
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000305")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private TouchUnitType areaUnitType;

		// Token: 0x040002F7 RID: 759
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000306")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private Rect activeArea;

		// Token: 0x040002F8 RID: 760
		[Header("Options")]
		[global::Cpp2ILInjected.Token(Token = "0x4000307")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public TouchControl.AnalogTarget target;

		// Token: 0x040002F9 RID: 761
		[global::Cpp2ILInjected.Token(Token = "0x4000308")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public TouchControl.SnapAngles snapAngles;

		// Token: 0x040002FA RID: 762
		[global::Cpp2ILInjected.Token(Token = "0x4000309")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public LockAxis lockToAxis;

		// Token: 0x040002FB RID: 763
		[Range(0f, 1f)]
		[global::Cpp2ILInjected.Token(Token = "0x400030A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public float lowerDeadZone;

		// Token: 0x040002FC RID: 764
		[Range(0f, 1f)]
		[global::Cpp2ILInjected.Token(Token = "0x400030B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public float upperDeadZone;

		// Token: 0x040002FD RID: 765
		[global::Cpp2ILInjected.Token(Token = "0x400030C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public AnimationCurve inputCurve;

		// Token: 0x040002FE RID: 766
		[global::Cpp2ILInjected.Token(Token = "0x400030D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public bool allowDragging;

		// Token: 0x040002FF RID: 767
		[global::Cpp2ILInjected.Token(Token = "0x400030E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public DragAxis allowDraggingAxis;

		// Token: 0x04000300 RID: 768
		[global::Cpp2ILInjected.Token(Token = "0x400030F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public bool snapToInitialTouch;

		// Token: 0x04000301 RID: 769
		[global::Cpp2ILInjected.Token(Token = "0x4000310")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		public bool resetWhenDone;

		// Token: 0x04000302 RID: 770
		[global::Cpp2ILInjected.Token(Token = "0x4000311")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public float resetDuration;

		// Token: 0x04000303 RID: 771
		[Header("Sprites")]
		[global::Cpp2ILInjected.Token(Token = "0x4000312")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public TouchSprite ring;

		// Token: 0x04000304 RID: 772
		[global::Cpp2ILInjected.Token(Token = "0x4000313")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public TouchSprite knob;

		// Token: 0x04000305 RID: 773
		[global::Cpp2ILInjected.Token(Token = "0x4000314")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public float knobRange;

		// Token: 0x04000306 RID: 774
		[global::Cpp2ILInjected.Token(Token = "0x4000315")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private Vector3 resetPosition;

		// Token: 0x04000307 RID: 775
		[global::Cpp2ILInjected.Token(Token = "0x4000316")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Vector3 beganPosition;

		// Token: 0x04000308 RID: 776
		[global::Cpp2ILInjected.Token(Token = "0x4000317")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private Vector3 movedPosition;

		// Token: 0x04000309 RID: 777
		[global::Cpp2ILInjected.Token(Token = "0x4000318")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private float ringResetSpeed;

		// Token: 0x0400030A RID: 778
		[global::Cpp2ILInjected.Token(Token = "0x4000319")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		private float knobResetSpeed;

		// Token: 0x0400030B RID: 779
		[global::Cpp2ILInjected.Token(Token = "0x400031A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private Rect worldActiveArea;

		// Token: 0x0400030C RID: 780
		[global::Cpp2ILInjected.Token(Token = "0x400031B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private float worldKnobRange;

		// Token: 0x0400030D RID: 781
		[global::Cpp2ILInjected.Token(Token = "0x400031C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		private Vector3 value;

		// Token: 0x0400030E RID: 782
		[global::Cpp2ILInjected.Token(Token = "0x400031D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private Touch currentTouch;

		// Token: 0x0400030F RID: 783
		[global::Cpp2ILInjected.Token(Token = "0x400031E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private bool dirty;
	}
}
