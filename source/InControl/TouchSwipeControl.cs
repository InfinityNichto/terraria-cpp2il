using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000045 RID: 69
	[global::Cpp2ILInjected.Token(Token = "0x200004A")]
	public class TouchSwipeControl : TouchControl
	{
		// Token: 0x06000389 RID: 905 RVA: 0x00002AE6 File Offset: 0x00000CE6
		[global::Cpp2ILInjected.Token(Token = "0x6000392")]
		[global::Cpp2ILInjected.Address(RVA = "0x199FE40", Offset = "0x199FE40", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void CreateControl()
		{
			throw null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002AE9 File Offset: 0x00000CE9
		[global::Cpp2ILInjected.Token(Token = "0x6000393")]
		[global::Cpp2ILInjected.Address(RVA = "0x199FE44", Offset = "0x199FE44", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void DestroyControl()
		{
			throw null;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002AEC File Offset: 0x00000CEC
		[global::Cpp2ILInjected.Token(Token = "0x6000394")]
		[global::Cpp2ILInjected.Address(RVA = "0x199FE6C", Offset = "0x199FE6C", Length = "0x28")]
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

		// Token: 0x0600038C RID: 908 RVA: 0x00002AEF File Offset: 0x00000CEF
		[global::Cpp2ILInjected.Token(Token = "0x6000395")]
		[global::Cpp2ILInjected.Address(RVA = "0x199FE94", Offset = "0x199FE94", Length = "0x94")]
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

		// Token: 0x0600038D RID: 909 RVA: 0x00002AF2 File Offset: 0x00000CF2
		[global::Cpp2ILInjected.Token(Token = "0x6000396")]
		[global::Cpp2ILInjected.Address(RVA = "0x199FF28", Offset = "0x199FF28", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002AF5 File Offset: 0x00000CF5
		[global::Cpp2ILInjected.Token(Token = "0x6000397")]
		[global::Cpp2ILInjected.Address(RVA = "0x199FF50", Offset = "0x199FF50", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "SnapTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(TouchControl.SnapAngles)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "SubmitAnalogValue", MemberParameters = new object[]
		{
			typeof(TouchControl.AnalogTarget),
			typeof(Vector2),
			typeof(float),
			typeof(float),
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

		// Token: 0x0600038F RID: 911 RVA: 0x00002AF8 File Offset: 0x00000CF8
		[global::Cpp2ILInjected.Token(Token = "0x6000398")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0098", Offset = "0x19A0098", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "CommitAnalog", MemberParameters = new object[] { typeof(TouchControl.AnalogTarget) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "CommitButton", MemberParameters = new object[] { typeof(TouchControl.ButtonTarget) }, ReturnType = typeof(void))]
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002AFB File Offset: 0x00000CFB
		[global::Cpp2ILInjected.Token(Token = "0x6000399")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A00D4", Offset = "0x19A00D4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "Contains", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void TouchBegan(Touch touch)
		{
			throw null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002AFE File Offset: 0x00000CFE
		[global::Cpp2ILInjected.Token(Token = "0x600039A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0178", Offset = "0x19A0178", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSwipeControl), Member = "GetButtonTargetForVector", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(TouchControl.ButtonTarget))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void TouchMoved(Touch touch)
		{
			throw null;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002B01 File Offset: 0x00000D01
		[global::Cpp2ILInjected.Token(Token = "0x600039B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0498", Offset = "0x19A0498", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void TouchEnded(Touch touch)
		{
			throw null;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002B04 File Offset: 0x00000D04
		[global::Cpp2ILInjected.Token(Token = "0x600039C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0314", Offset = "0x19A0314", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSwipeControl), Member = "TouchMoved", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "SnapTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private TouchControl.ButtonTarget GetButtonTargetForVector(Vector2 vector)
		{
			throw null;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00002B07 File Offset: 0x00000D07
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00002B0A File Offset: 0x00000D0A
		[global::Cpp2ILInjected.Token(Token = "0x17000120")]
		public Rect ActiveArea
		{
			[global::Cpp2ILInjected.Token(Token = "0x600039D")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A05BC", Offset = "0x19A05BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600039E")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A05C8", Offset = "0x19A05C8", Length = "0x68")]
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00002B0D File Offset: 0x00000D0D
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00002B10 File Offset: 0x00000D10
		[global::Cpp2ILInjected.Token(Token = "0x17000121")]
		public TouchUnitType AreaUnitType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600039F")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A0630", Offset = "0x19A0630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A0638", Offset = "0x19A0638", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002B13 File Offset: 0x00000D13
		[global::Cpp2ILInjected.Token(Token = "0x60003A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A0654", Offset = "0x19A0654", Length = "0x5C")]
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
		public TouchSwipeControl()
		{
			throw null;
		}

		// Token: 0x04000310 RID: 784
		[Header("Position")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400031F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TouchUnitType areaUnitType;

		// Token: 0x04000311 RID: 785
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000320")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Rect activeArea;

		// Token: 0x04000312 RID: 786
		[Header("Options")]
		[Range(0f, 1f)]
		[global::Cpp2ILInjected.Token(Token = "0x4000321")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float sensitivity;

		// Token: 0x04000313 RID: 787
		[global::Cpp2ILInjected.Token(Token = "0x4000322")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public bool oneSwipePerTouch;

		// Token: 0x04000314 RID: 788
		[Header("Analog Target")]
		[global::Cpp2ILInjected.Token(Token = "0x4000323")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public TouchControl.AnalogTarget target;

		// Token: 0x04000315 RID: 789
		[global::Cpp2ILInjected.Token(Token = "0x4000324")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public TouchControl.SnapAngles snapAngles;

		// Token: 0x04000316 RID: 790
		[Header("Button Targets")]
		[global::Cpp2ILInjected.Token(Token = "0x4000325")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public TouchControl.ButtonTarget upTarget;

		// Token: 0x04000317 RID: 791
		[global::Cpp2ILInjected.Token(Token = "0x4000326")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public TouchControl.ButtonTarget downTarget;

		// Token: 0x04000318 RID: 792
		[global::Cpp2ILInjected.Token(Token = "0x4000327")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public TouchControl.ButtonTarget leftTarget;

		// Token: 0x04000319 RID: 793
		[global::Cpp2ILInjected.Token(Token = "0x4000328")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public TouchControl.ButtonTarget rightTarget;

		// Token: 0x0400031A RID: 794
		[global::Cpp2ILInjected.Token(Token = "0x4000329")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public TouchControl.ButtonTarget tapTarget;

		// Token: 0x0400031B RID: 795
		[global::Cpp2ILInjected.Token(Token = "0x400032A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Rect worldActiveArea;

		// Token: 0x0400031C RID: 796
		[global::Cpp2ILInjected.Token(Token = "0x400032B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Vector3 currentVector;

		// Token: 0x0400031D RID: 797
		[global::Cpp2ILInjected.Token(Token = "0x400032C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private bool currentVectorIsSet;

		// Token: 0x0400031E RID: 798
		[global::Cpp2ILInjected.Token(Token = "0x400032D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Vector3 beganPosition;

		// Token: 0x0400031F RID: 799
		[global::Cpp2ILInjected.Token(Token = "0x400032E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		// Token: 0x04000320 RID: 800
		[global::Cpp2ILInjected.Token(Token = "0x400032F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Touch currentTouch;

		// Token: 0x04000321 RID: 801
		[global::Cpp2ILInjected.Token(Token = "0x4000330")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private bool fireButtonTarget;

		// Token: 0x04000322 RID: 802
		[global::Cpp2ILInjected.Token(Token = "0x4000331")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private TouchControl.ButtonTarget nextButtonTarget;

		// Token: 0x04000323 RID: 803
		[global::Cpp2ILInjected.Token(Token = "0x4000332")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private TouchControl.ButtonTarget lastButtonTarget;

		// Token: 0x04000324 RID: 804
		[global::Cpp2ILInjected.Token(Token = "0x4000333")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private bool dirty;
	}
}
