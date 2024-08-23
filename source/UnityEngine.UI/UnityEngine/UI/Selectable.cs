using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000034 RID: 52
	[ExecuteAlways]
	[AddComponentMenu("UI/Selectable", 35)]
	[SelectionBase]
	[DisallowMultipleComponent]
	[global::Cpp2ILInjected.Token(Token = "0x2000067")]
	public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00002B1E File Offset: 0x00000D1E
		[global::Cpp2ILInjected.Token(Token = "0x17000116")]
		public static Selectable[] allSelectablesArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000419")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD84C8", Offset = "0x1FD84C8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "get_allSelectables", ReturnType = typeof(List<Selectable>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00002B21 File Offset: 0x00000D21
		[global::Cpp2ILInjected.Token(Token = "0x17000117")]
		public static int allSelectableCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600041A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8564", Offset = "0x1FD8564", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00002B24 File Offset: 0x00000D24
		[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000118")]
		public static List<Selectable> allSelectables
		{
			[global::Cpp2ILInjected.Token(Token = "0x600041B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD85BC", Offset = "0x1FD85BC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "get_allSelectablesArray", ReturnType = typeof(Selectable[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002B27 File Offset: 0x00000D27
		[global::Cpp2ILInjected.Token(Token = "0x600041C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD8658", Offset = "0x1FD8658", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static int AllSelectablesNoAlloc(Selectable[] selectables)
		{
			throw null;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00002B2A File Offset: 0x00000D2A
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00002B2D File Offset: 0x00000D2D
		[global::Cpp2ILInjected.Token(Token = "0x17000119")]
		public Navigation navigation
		{
			[global::Cpp2ILInjected.Token(Token = "0x600041D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD870C", Offset = "0x1FD870C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600041E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8720", Offset = "0x1FD8720", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(Navigation) }, MemberParameters = new object[]
			{
				typeof(ref Navigation),
				typeof(Navigation)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00002B30 File Offset: 0x00000D30
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00002B33 File Offset: 0x00000D33
		[global::Cpp2ILInjected.Token(Token = "0x1700011A")]
		public Selectable.Transition transition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600041F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD880C", Offset = "0x1FD880C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000420")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8814", Offset = "0x1FD8814", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00002B36 File Offset: 0x00000D36
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00002B39 File Offset: 0x00000D39
		[global::Cpp2ILInjected.Token(Token = "0x1700011B")]
		public ColorBlock colors
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000421")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8888", Offset = "0x1FD8888", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000422")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8898", Offset = "0x1FD8898", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(ColorBlock) }, MemberParameters = new object[]
			{
				typeof(ref ColorBlock),
				typeof(ColorBlock)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00002B3C File Offset: 0x00000D3C
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00002B3F File Offset: 0x00000D3F
		[global::Cpp2ILInjected.Token(Token = "0x1700011C")]
		public SpriteState spriteState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000423")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8930", Offset = "0x1FD8930", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000424")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8940", Offset = "0x1FD8940", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(SpriteState) }, MemberParameters = new object[]
			{
				typeof(ref SpriteState),
				typeof(SpriteState)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00002B42 File Offset: 0x00000D42
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00002B45 File Offset: 0x00000D45
		[global::Cpp2ILInjected.Token(Token = "0x1700011D")]
		public AnimationTriggers animationTriggers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000425")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD89BC", Offset = "0x1FD89BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000426")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD89C4", Offset = "0x1FD89C4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00002B48 File Offset: 0x00000D48
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00002B4B File Offset: 0x00000D4B
		[global::Cpp2ILInjected.Token(Token = "0x1700011E")]
		public Graphic targetGraphic
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000427")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8A38", Offset = "0x1FD8A38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000428")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8A40", Offset = "0x1FD8A40", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateToggle", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00002B4E File Offset: 0x00000D4E
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00002B51 File Offset: 0x00000D51
		[global::Cpp2ILInjected.Token(Token = "0x1700011F")]
		public bool interactable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000429")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8AB4", Offset = "0x1FD8AB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600042A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8ABC", Offset = "0x1FD8ABC", Length = "0x164")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00002B54 File Offset: 0x00000D54
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00002B57 File Offset: 0x00000D57
		[global::Cpp2ILInjected.Token(Token = "0x17000120")]
		private bool isPointerInside
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600042B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8C20", Offset = "0x1FD8C20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600042C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8C28", Offset = "0x1FD8C28", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00002B5A File Offset: 0x00000D5A
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00002B5D File Offset: 0x00000D5D
		[global::Cpp2ILInjected.Token(Token = "0x17000121")]
		private bool isPointerDown
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600042D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8C34", Offset = "0x1FD8C34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600042E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8C3C", Offset = "0x1FD8C3C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00002B60 File Offset: 0x00000D60
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00002B63 File Offset: 0x00000D63
		[global::Cpp2ILInjected.Token(Token = "0x17000122")]
		private bool hasSelection
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600042F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8C48", Offset = "0x1FD8C48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000430")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8C50", Offset = "0x1FD8C50", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002B66 File Offset: 0x00000D66
		[global::Cpp2ILInjected.Token(Token = "0x6000431")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD30D8", Offset = "0x1FD30D8", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Button), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationTriggers), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected Selectable()
		{
			throw null;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00002B69 File Offset: 0x00000D69
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00002B6C File Offset: 0x00000D6C
		[global::Cpp2ILInjected.Token(Token = "0x17000123")]
		public Image image
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000432")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8C5C", Offset = "0x1FD8C5C", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000433")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8CD8", Offset = "0x1FD8CD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00002B6F File Offset: 0x00000D6F
		[global::Cpp2ILInjected.Token(Token = "0x17000124")]
		public Animator animator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000434")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8CE0", Offset = "0x1FD8CE0", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002B72 File Offset: 0x00000D72
		[global::Cpp2ILInjected.Token(Token = "0x6000435")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD8D28", Offset = "0x1FD8D28", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Awake", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002B75 File Offset: 0x00000D75
		[global::Cpp2ILInjected.Token(Token = "0x6000436")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD8DB4", Offset = "0x1FD8DB4", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasGroup), Member = "get_interactable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasGroup), Member = "get_ignoreParentGroups", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void OnCanvasGroupChanged()
		{
			throw null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002B78 File Offset: 0x00000D78
		[global::Cpp2ILInjected.Token(Token = "0x6000437")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD8F58", Offset = "0x1FD8F58", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool IsInteractable()
		{
			throw null;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002B7B File Offset: 0x00000D7B
		[global::Cpp2ILInjected.Token(Token = "0x6000438")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD8F78", Offset = "0x1FD8F78", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
		protected override void OnDidApplyAnimationProperties()
		{
			throw null;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002B7E File Offset: 0x00000D7E
		[global::Cpp2ILInjected.Token(Token = "0x6000439")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3500", Offset = "0x1FD3500", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002B81 File Offset: 0x00000D81
		[global::Cpp2ILInjected.Token(Token = "0x600043A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD8FCC", Offset = "0x1FD8FCC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void OnTransformParentChanged()
		{
			throw null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002B84 File Offset: 0x00000D84
		[global::Cpp2ILInjected.Token(Token = "0x600043B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD87A8", Offset = "0x1FD87A8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_navigation", MemberParameters = new object[] { typeof(Navigation) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_transition", MemberParameters = new object[] { typeof(Selectable.Transition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_colors", MemberParameters = new object[] { typeof(ColorBlock) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_spriteState", MemberParameters = new object[] { typeof(SpriteState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_animationTriggers", MemberParameters = new object[] { typeof(AnimationTriggers) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_targetGraphic", MemberParameters = new object[] { typeof(Graphic) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnCanvasGroupChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnSetProperty()
		{
			throw null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002B87 File Offset: 0x00000D87
		[global::Cpp2ILInjected.Token(Token = "0x600043C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD37A0", Offset = "0x1FD37A0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002B8A File Offset: 0x00000D8A
		[global::Cpp2ILInjected.Token(Token = "0x600043D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD8FF4", Offset = "0x1FD8FF4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnApplicationFocus(bool hasFocus)
		{
			throw null;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00002B8D File Offset: 0x00000D8D
		[global::Cpp2ILInjected.Token(Token = "0x17000125")]
		protected Selectable.SelectionState currentSelectionState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600043E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD8F7C", Offset = "0x1FD8F7C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Button.<OnFinishSubmit>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002B90 File Offset: 0x00000D90
		[global::Cpp2ILInjected.Token(Token = "0x600043F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD909C", Offset = "0x1FD909C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
		protected virtual void InstantClearState()
		{
			throw null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002B93 File Offset: 0x00000D93
		[global::Cpp2ILInjected.Token(Token = "0x6000440")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD93C0", Offset = "0x1FD93C0", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "DoStateTransition", MemberParameters = new object[]
		{
			typeof(Selectable.SelectionState),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "StartColorTween", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "TriggerAnimation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			throw null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002B96 File Offset: 0x00000D96
		[global::Cpp2ILInjected.Token(Token = "0x6000441")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9534", Offset = "0x1FD9534", Length = "0x48C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new object[] { typeof(Quaternion) }, ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Quaternion),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "GetPointOnRectEdge", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public Selectable FindSelectable(Vector3 dir)
		{
			throw null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002B99 File Offset: 0x00000D99
		[global::Cpp2ILInjected.Token(Token = "0x6000442")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD99C0", Offset = "0x1FD99C0", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			throw null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002B9C File Offset: 0x00000D9C
		[global::Cpp2ILInjected.Token(Token = "0x6000443")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9B5C", Offset = "0x1FD9B5C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnMove", MemberParameters = new object[] { typeof(AxisEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseEventData), Member = "set_selectedObject", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Navigate(AxisEventData eventData, Selectable sel)
		{
			throw null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002B9F File Offset: 0x00000D9F
		[global::Cpp2ILInjected.Token(Token = "0x6000444")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD44F0", Offset = "0x1FD44F0", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "FindSelectableOnLeft", ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Quaternion),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual Selectable FindSelectableOnLeft()
		{
			throw null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002BA2 File Offset: 0x00000DA2
		[global::Cpp2ILInjected.Token(Token = "0x6000445")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD45E4", Offset = "0x1FD45E4", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "FindSelectableOnRight", ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Quaternion),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual Selectable FindSelectableOnRight()
		{
			throw null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002BA5 File Offset: 0x00000DA5
		[global::Cpp2ILInjected.Token(Token = "0x6000446")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD46D8", Offset = "0x1FD46D8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "FindSelectableOnUp", ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Quaternion),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual Selectable FindSelectableOnUp()
		{
			throw null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002BA8 File Offset: 0x00000DA8
		[global::Cpp2ILInjected.Token(Token = "0x6000447")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD47CC", Offset = "0x1FD47CC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "FindSelectableOnDown", ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Quaternion),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "FindSelectable", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Selectable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual Selectable FindSelectableOnDown()
		{
			throw null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002BAB File Offset: 0x00000DAB
		[global::Cpp2ILInjected.Token(Token = "0x6000448")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD4448", Offset = "0x1FD4448", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnMove", MemberParameters = new object[] { typeof(AxisEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "Navigate", MemberParameters = new object[]
		{
			typeof(AxisEventData),
			typeof(Selectable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void OnMove(AxisEventData eventData)
		{
			throw null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002BAE File Offset: 0x00000DAE
		[global::Cpp2ILInjected.Token(Token = "0x6000449")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD90F0", Offset = "0x1FD90F0", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new object[]
		{
			typeof(Selectable.SelectionState),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void StartColorTween(Color targetColor, bool instant)
		{
			throw null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002BB1 File Offset: 0x00000DB1
		[global::Cpp2ILInjected.Token(Token = "0x600044A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD91D0", Offset = "0x1FD91D0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "InstantClearState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new object[]
		{
			typeof(Selectable.SelectionState),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "set_overrideSprite", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void DoSpriteSwap(Sprite newSprite)
		{
			throw null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002BB4 File Offset: 0x00000DB4
		[global::Cpp2ILInjected.Token(Token = "0x600044B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9270", Offset = "0x1FD9270", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "InstantClearState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new object[]
		{
			typeof(Selectable.SelectionState),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "get_animator", ReturnType = typeof(Animator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animator), Member = "get_hasBoundPlayables", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animator), Member = "ResetTrigger", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animator), Member = "SetTrigger", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void TriggerAnimation(string triggername)
		{
			throw null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002BB7 File Offset: 0x00000DB7
		[global::Cpp2ILInjected.Token(Token = "0x600044C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9C08", Offset = "0x1FD9C08", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected bool IsHighlighted()
		{
			throw null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002BBA File Offset: 0x00000DBA
		[global::Cpp2ILInjected.Token(Token = "0x600044D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9050", Offset = "0x1FD9050", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected bool IsPressed()
		{
			throw null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002BBD File Offset: 0x00000DBD
		[global::Cpp2ILInjected.Token(Token = "0x600044E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9C64", Offset = "0x1FD9C64", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnPointerUp", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnPointerUp", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnPointerEnter", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnPointerExit", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void EvaluateAndTransitionToSelectionState()
		{
			throw null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002BC0 File Offset: 0x00000DC0
		[global::Cpp2ILInjected.Token(Token = "0x600044F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD3F48", Offset = "0x1FD3F48", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002BC3 File Offset: 0x00000DC3
		[global::Cpp2ILInjected.Token(Token = "0x6000450")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD4178", Offset = "0x1FD4178", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002BC6 File Offset: 0x00000DC6
		[global::Cpp2ILInjected.Token(Token = "0x6000451")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9CFC", Offset = "0x1FD9CFC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002BC9 File Offset: 0x00000DC9
		[global::Cpp2ILInjected.Token(Token = "0x6000452")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9D08", Offset = "0x1FD9D08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002BCC File Offset: 0x00000DCC
		[global::Cpp2ILInjected.Token(Token = "0x6000453")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9D10", Offset = "0x1FD9D10", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnSelect", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
		public virtual void OnSelect(BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002BCF File Offset: 0x00000DCF
		[global::Cpp2ILInjected.Token(Token = "0x6000454")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9D1C", Offset = "0x1FD9D1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnDeselect", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "EvaluateAndTransitionToSelectionState", ReturnType = typeof(void))]
		public virtual void OnDeselect(BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002BD2 File Offset: 0x00000DD2
		[global::Cpp2ILInjected.Token(Token = "0x6000455")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9D24", Offset = "0x1FD9D24", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void Select()
		{
			throw null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002BD5 File Offset: 0x00000DD5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000456")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9E1C", Offset = "0x1FD9E1C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Selectable()
		{
			throw null;
		}

		// Token: 0x0400014B RID: 331
		[global::Cpp2ILInjected.Token(Token = "0x4000201")]
		protected static Selectable[] s_Selectables;

		// Token: 0x0400014C RID: 332
		[global::Cpp2ILInjected.Token(Token = "0x4000202")]
		protected static int s_SelectableCount;

		// Token: 0x0400014D RID: 333
		[global::Cpp2ILInjected.Token(Token = "0x4000203")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_EnableCalled;

		// Token: 0x0400014E RID: 334
		[SerializeField]
		[FormerlySerializedAs("navigation")]
		[global::Cpp2ILInjected.Token(Token = "0x4000204")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Navigation m_Navigation;

		// Token: 0x0400014F RID: 335
		[SerializeField]
		[FormerlySerializedAs("transition")]
		[global::Cpp2ILInjected.Token(Token = "0x4000205")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Selectable.Transition m_Transition;

		// Token: 0x04000150 RID: 336
		[SerializeField]
		[FormerlySerializedAs("colors")]
		[global::Cpp2ILInjected.Token(Token = "0x4000206")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private ColorBlock m_Colors;

		// Token: 0x04000151 RID: 337
		[SerializeField]
		[FormerlySerializedAs("spriteState")]
		[global::Cpp2ILInjected.Token(Token = "0x4000207")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private SpriteState m_SpriteState;

		// Token: 0x04000152 RID: 338
		[SerializeField]
		[FormerlySerializedAs("animationTriggers")]
		[global::Cpp2ILInjected.Token(Token = "0x4000208")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private AnimationTriggers m_AnimationTriggers;

		// Token: 0x04000153 RID: 339
		[SerializeField]
		[Tooltip("Can the Selectable be interacted with?")]
		[global::Cpp2ILInjected.Token(Token = "0x4000209")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private bool m_Interactable;

		// Token: 0x04000154 RID: 340
		[FormerlySerializedAs("m_HighlightGraphic")]
		[SerializeField]
		[FormerlySerializedAs("highlightGraphic")]
		[global::Cpp2ILInjected.Token(Token = "0x400020A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private Graphic m_TargetGraphic;

		// Token: 0x04000155 RID: 341
		[global::Cpp2ILInjected.Token(Token = "0x400020B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private bool m_GroupsAllowInteraction;

		// Token: 0x04000156 RID: 342
		[global::Cpp2ILInjected.Token(Token = "0x400020C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		protected int m_CurrentIndex;

		// Token: 0x04000157 RID: 343
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400020D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private bool <isPointerInside>k__BackingField;

		// Token: 0x04000158 RID: 344
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400020E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE9")]
		private bool <isPointerDown>k__BackingField;

		// Token: 0x04000159 RID: 345
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400020F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEA")]
		private bool <hasSelection>k__BackingField;

		// Token: 0x0400015A RID: 346
		[global::Cpp2ILInjected.Token(Token = "0x4000210")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private readonly List<CanvasGroup> m_CanvasGroupCache;

		// Token: 0x020000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x2000068")]
		public enum Transition
		{
			// Token: 0x04000300 RID: 768
			[global::Cpp2ILInjected.Token(Token = "0x4000212")]
			None,
			// Token: 0x04000301 RID: 769
			[global::Cpp2ILInjected.Token(Token = "0x4000213")]
			ColorTint,
			// Token: 0x04000302 RID: 770
			[global::Cpp2ILInjected.Token(Token = "0x4000214")]
			SpriteSwap,
			// Token: 0x04000303 RID: 771
			[global::Cpp2ILInjected.Token(Token = "0x4000215")]
			Animation
		}

		// Token: 0x020000B3 RID: 179
		[global::Cpp2ILInjected.Token(Token = "0x2000069")]
		protected enum SelectionState
		{
			// Token: 0x04000305 RID: 773
			[global::Cpp2ILInjected.Token(Token = "0x4000217")]
			Normal,
			// Token: 0x04000306 RID: 774
			[global::Cpp2ILInjected.Token(Token = "0x4000218")]
			Highlighted,
			// Token: 0x04000307 RID: 775
			[global::Cpp2ILInjected.Token(Token = "0x4000219")]
			Pressed,
			// Token: 0x04000308 RID: 776
			[global::Cpp2ILInjected.Token(Token = "0x400021A")]
			Selected,
			// Token: 0x04000309 RID: 777
			[global::Cpp2ILInjected.Token(Token = "0x400021B")]
			Disabled
		}
	}
}
