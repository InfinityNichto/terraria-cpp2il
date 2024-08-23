using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000036 RID: 54
	[ExecuteAlways]
	[AddComponentMenu("UI/Slider", 34)]
	[RequireComponent(typeof(RectTransform))]
	[global::Cpp2ILInjected.Token(Token = "0x200006B")]
	public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00002BE1 File Offset: 0x00000DE1
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00002BE4 File Offset: 0x00000DE4
		[global::Cpp2ILInjected.Token(Token = "0x17000126")]
		public RectTransform fillRect
		{
			[global::Cpp2ILInjected.Token(Token = "0x600045A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD9ED8", Offset = "0x1FD9ED8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600045B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD9EE0", Offset = "0x1FD9EE0", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00002BE7 File Offset: 0x00000DE7
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00002BEA File Offset: 0x00000DEA
		[global::Cpp2ILInjected.Token(Token = "0x17000127")]
		public RectTransform handleRect
		{
			[global::Cpp2ILInjected.Token(Token = "0x600045C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA4A0", Offset = "0x1FDA4A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600045D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA4A8", Offset = "0x1FDA4A8", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00002BED File Offset: 0x00000DED
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00002BF0 File Offset: 0x00000DF0
		[global::Cpp2ILInjected.Token(Token = "0x17000128")]
		public Slider.Direction direction
		{
			[global::Cpp2ILInjected.Token(Token = "0x600045E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA524", Offset = "0x1FDA524", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600045F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA52C", Offset = "0x1FDA52C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "SetDirection", MemberParameters = new object[]
			{
				typeof(Slider.Direction),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00002BF3 File Offset: 0x00000DF3
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00002BF6 File Offset: 0x00000DF6
		[global::Cpp2ILInjected.Token(Token = "0x17000129")]
		public float minValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000460")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA5A0", Offset = "0x1FDA5A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000461")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA5A8", Offset = "0x1FDA5A8", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00002BF9 File Offset: 0x00000DF9
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00002BFC File Offset: 0x00000DFC
		[global::Cpp2ILInjected.Token(Token = "0x1700012A")]
		public float maxValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000462")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA638", Offset = "0x1FDA638", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000463")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA640", Offset = "0x1FDA640", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00002BFF File Offset: 0x00000DFF
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00002C02 File Offset: 0x00000E02
		[global::Cpp2ILInjected.Token(Token = "0x1700012B")]
		public bool wholeNumbers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000464")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA6D0", Offset = "0x1FDA6D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000465")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA6D8", Offset = "0x1FDA6D8", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00002C05 File Offset: 0x00000E05
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00002C08 File Offset: 0x00000E08
		[global::Cpp2ILInjected.Token(Token = "0x1700012C")]
		public virtual float value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000466")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA768", Offset = "0x1FDA768", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000467")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA808", Offset = "0x1FDA808", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002C0B File Offset: 0x00000E0B
		[global::Cpp2ILInjected.Token(Token = "0x6000468")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDA81C", Offset = "0x1FDA81C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void SetValueWithoutNotify(float input)
		{
			throw null;
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00002C0E File Offset: 0x00000E0E
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00002C11 File Offset: 0x00000E11
		[global::Cpp2ILInjected.Token(Token = "0x1700012D")]
		public float normalizedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000469")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA830", Offset = "0x1FDA830", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600046A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA914", Offset = "0x1FDA914", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00002C14 File Offset: 0x00000E14
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00002C17 File Offset: 0x00000E17
		[global::Cpp2ILInjected.Token(Token = "0x1700012E")]
		public Slider.SliderEvent onValueChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA94C", Offset = "0x1FDA94C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600046C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA954", Offset = "0x1FDA954", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00002C1A File Offset: 0x00000E1A
		[global::Cpp2ILInjected.Token(Token = "0x1700012F")]
		private float stepSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDA95C", Offset = "0x1FDA95C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002C1D File Offset: 0x00000E1D
		[global::Cpp2ILInjected.Token(Token = "0x600046E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDA988", Offset = "0x1FDA988", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider.SliderEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected Slider()
		{
			throw null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002C20 File Offset: 0x00000E20
		[global::Cpp2ILInjected.Token(Token = "0x600046F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDAA8C", Offset = "0x1FDAA8C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Rebuild(CanvasUpdate executing)
		{
			throw null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002C23 File Offset: 0x00000E23
		[global::Cpp2ILInjected.Token(Token = "0x6000470")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDAA90", Offset = "0x1FDAA90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void LayoutComplete()
		{
			throw null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002C26 File Offset: 0x00000E26
		[global::Cpp2ILInjected.Token(Token = "0x6000471")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDAA94", Offset = "0x1FDAA94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void GraphicUpdateComplete()
		{
			throw null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002C29 File Offset: 0x00000E29
		[global::Cpp2ILInjected.Token(Token = "0x6000472")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDAA98", Offset = "0x1FDAA98", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateCachedReferences", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002C2C File Offset: 0x00000E2C
		[global::Cpp2ILInjected.Token(Token = "0x6000473")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDAAD4", Offset = "0x1FDAAD4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002C2F File Offset: 0x00000E2F
		[global::Cpp2ILInjected.Token(Token = "0x6000474")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDAAF4", Offset = "0x1FDAAF4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002C32 File Offset: 0x00000E32
		[global::Cpp2ILInjected.Token(Token = "0x6000475")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDAB34", Offset = "0x1FDAB34", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "ClampValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "get_normalizedValue", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "Invoke", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void OnDidApplyAnimationProperties()
		{
			throw null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002C35 File Offset: 0x00000E35
		[global::Cpp2ILInjected.Token(Token = "0x6000476")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9F5C", Offset = "0x1FD9F5C", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_fillRect", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_handleRect", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void UpdateCachedReferences()
		{
			throw null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002C38 File Offset: 0x00000E38
		[global::Cpp2ILInjected.Token(Token = "0x6000477")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDAD10", Offset = "0x1FDAD10", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private float ClampValue(float input)
		{
			throw null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002C3B File Offset: 0x00000E3B
		[global::Cpp2ILInjected.Token(Token = "0x6000478")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDADE8", Offset = "0x1FDADE8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "ClampValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "Invoke", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void Set(float input, bool sendCallback = true)
		{
			throw null;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002C3E File Offset: 0x00000E3E
		[global::Cpp2ILInjected.Token(Token = "0x6000479")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDAEA4", Offset = "0x1FDAEA4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		protected override void OnRectTransformDimensionsChange()
		{
			throw null;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00002C41 File Offset: 0x00000E41
		[global::Cpp2ILInjected.Token(Token = "0x17000130")]
		private Slider.Axis axis
		{
			[global::Cpp2ILInjected.Token(Token = "0x600047A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDADD8", Offset = "0x1FDADD8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00002C44 File Offset: 0x00000E44
		[global::Cpp2ILInjected.Token(Token = "0x17000131")]
		private bool reverseValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600047B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDADC4", Offset = "0x1FDADC4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002C47 File Offset: 0x00000E47
		[global::Cpp2ILInjected.Token(Token = "0x600047C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDA1D4", Offset = "0x1FDA1D4", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_fillRect", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_handleRect", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_direction", MemberParameters = new object[] { typeof(Slider.Direction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_minValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_maxValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_wholeNumbers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Add", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(RectTransform),
			typeof(DrivenTransformProperties)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "get_normalizedValue", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void UpdateVisuals()
		{
			throw null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002C4A File Offset: 0x00000E4A
		[global::Cpp2ILInjected.Token(Token = "0x600047D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDAEDC", Offset = "0x1FDAEDC", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
			throw null;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002C4D File Offset: 0x00000E4D
		[global::Cpp2ILInjected.Token(Token = "0x600047E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB10C", Offset = "0x1FDB10C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool MayDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002C50 File Offset: 0x00000E50
		[global::Cpp2ILInjected.Token(Token = "0x600047F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB168", Offset = "0x1FDB168", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_enterEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateDrag", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(Camera)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002C53 File Offset: 0x00000E53
		[global::Cpp2ILInjected.Token(Token = "0x6000480")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB338", Offset = "0x1FDB338", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "UpdateDrag", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(Camera)
		}, ReturnType = typeof(void))]
		public virtual void OnDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002C56 File Offset: 0x00000E56
		[global::Cpp2ILInjected.Token(Token = "0x6000481")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB3AC", Offset = "0x1FDB3AC", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnMove", MemberParameters = new object[] { typeof(AxisEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void OnMove(AxisEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002C59 File Offset: 0x00000E59
		[global::Cpp2ILInjected.Token(Token = "0x6000482")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB5F0", Offset = "0x1FDB5F0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
		public override Selectable FindSelectableOnLeft()
		{
			throw null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002C5C File Offset: 0x00000E5C
		[global::Cpp2ILInjected.Token(Token = "0x6000483")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB614", Offset = "0x1FDB614", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
		public override Selectable FindSelectableOnRight()
		{
			throw null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002C5F File Offset: 0x00000E5F
		[global::Cpp2ILInjected.Token(Token = "0x6000484")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB638", Offset = "0x1FDB638", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
		public override Selectable FindSelectableOnUp()
		{
			throw null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002C62 File Offset: 0x00000E62
		[global::Cpp2ILInjected.Token(Token = "0x6000485")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB65C", Offset = "0x1FDB65C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
		public override Selectable FindSelectableOnDown()
		{
			throw null;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002C65 File Offset: 0x00000E65
		[global::Cpp2ILInjected.Token(Token = "0x6000486")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB680", Offset = "0x1FDB680", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002C68 File Offset: 0x00000E68
		[global::Cpp2ILInjected.Token(Token = "0x6000487")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB688", Offset = "0x1FDB688", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider), Member = "set_direction", MemberParameters = new object[] { typeof(Slider.Direction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutAxes", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutOnAxis", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void SetDirection(Slider.Direction direction, bool includeRectLayouts)
		{
			throw null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002C6B File Offset: 0x00000E6B
		[global::Cpp2ILInjected.Token(Token = "0x6000488")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB800", Offset = "0x1FDB800", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			throw null;
		}

		// Token: 0x0400015B RID: 347
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400021C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private RectTransform m_FillRect;

		// Token: 0x0400015C RID: 348
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400021D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private RectTransform m_HandleRect;

		// Token: 0x0400015D RID: 349
		[SerializeField]
		[Space]
		[global::Cpp2ILInjected.Token(Token = "0x400021E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private Slider.Direction m_Direction;

		// Token: 0x0400015E RID: 350
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400021F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
		private float m_MinValue;

		// Token: 0x0400015F RID: 351
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000220")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private float m_MaxValue;

		// Token: 0x04000160 RID: 352
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000221")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
		private bool m_WholeNumbers;

		// Token: 0x04000161 RID: 353
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000222")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		protected float m_Value;

		// Token: 0x04000162 RID: 354
		[SerializeField]
		[Space]
		[global::Cpp2ILInjected.Token(Token = "0x4000223")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private Slider.SliderEvent m_OnValueChanged;

		// Token: 0x04000163 RID: 355
		[global::Cpp2ILInjected.Token(Token = "0x4000224")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private Image m_FillImage;

		// Token: 0x04000164 RID: 356
		[global::Cpp2ILInjected.Token(Token = "0x4000225")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private Transform m_FillTransform;

		// Token: 0x04000165 RID: 357
		[global::Cpp2ILInjected.Token(Token = "0x4000226")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private RectTransform m_FillContainerRect;

		// Token: 0x04000166 RID: 358
		[global::Cpp2ILInjected.Token(Token = "0x4000227")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private Transform m_HandleTransform;

		// Token: 0x04000167 RID: 359
		[global::Cpp2ILInjected.Token(Token = "0x4000228")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private RectTransform m_HandleContainerRect;

		// Token: 0x04000168 RID: 360
		[global::Cpp2ILInjected.Token(Token = "0x4000229")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Vector2 m_Offset;

		// Token: 0x04000169 RID: 361
		[global::Cpp2ILInjected.Token(Token = "0x400022A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0400016A RID: 362
		[global::Cpp2ILInjected.Token(Token = "0x400022B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x159")]
		private bool m_DelayedUpdateVisuals;

		// Token: 0x020000B4 RID: 180
		[global::Cpp2ILInjected.Token(Token = "0x200006C")]
		public enum Direction
		{
			// Token: 0x0400030B RID: 779
			[global::Cpp2ILInjected.Token(Token = "0x400022D")]
			LeftToRight,
			// Token: 0x0400030C RID: 780
			[global::Cpp2ILInjected.Token(Token = "0x400022E")]
			RightToLeft,
			// Token: 0x0400030D RID: 781
			[global::Cpp2ILInjected.Token(Token = "0x400022F")]
			BottomToTop,
			// Token: 0x0400030E RID: 782
			[global::Cpp2ILInjected.Token(Token = "0x4000230")]
			TopToBottom
		}

		// Token: 0x020000B5 RID: 181
		[global::Cpp2ILInjected.Token(Token = "0x200006D")]
		[Serializable]
		public class SliderEvent : UnityEvent<float>
		{
			// Token: 0x060006C6 RID: 1734 RVA: 0x000033E2 File Offset: 0x000015E2
			[global::Cpp2ILInjected.Token(Token = "0x6000489")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDAA44", Offset = "0x1FDAA44", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public SliderEvent()
			{
				throw null;
			}
		}

		// Token: 0x020000B6 RID: 182
		[global::Cpp2ILInjected.Token(Token = "0x200006E")]
		private enum Axis
		{
			// Token: 0x04000310 RID: 784
			[global::Cpp2ILInjected.Token(Token = "0x4000232")]
			Horizontal,
			// Token: 0x04000311 RID: 785
			[global::Cpp2ILInjected.Token(Token = "0x4000233")]
			Vertical
		}
	}
}
