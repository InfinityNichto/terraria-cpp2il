using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Pool;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x0200000E RID: 14
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Legacy/Dropdown", 102)]
	[global::Cpp2ILInjected.Token(Token = "0x2000013")]
	public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002164 File Offset: 0x00000364
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002167 File Offset: 0x00000367
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public RectTransform template
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000070")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAA0", Offset = "0x1FACAA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000071")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FABEB4", Offset = "0x1FABEB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000216A File Offset: 0x0000036A
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0000216D File Offset: 0x0000036D
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public Text captionText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000072")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAA8", Offset = "0x1FACAA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000073")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FABEBC", Offset = "0x1FABEBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002170 File Offset: 0x00000370
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002173 File Offset: 0x00000373
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public Image captionImage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000074")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAB0", Offset = "0x1FACAB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000075")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAB8", Offset = "0x1FACAB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002176 File Offset: 0x00000376
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002179 File Offset: 0x00000379
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public Text itemText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000076")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAC0", Offset = "0x1FACAC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000077")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FABEC4", Offset = "0x1FABEC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000217C File Offset: 0x0000037C
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000217F File Offset: 0x0000037F
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public Image itemImage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000078")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAC8", Offset = "0x1FACAC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000079")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAD0", Offset = "0x1FACAD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002182 File Offset: 0x00000382
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002185 File Offset: 0x00000385
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		public List<Dropdown.OptionData> options
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FABECC", Offset = "0x1FABECC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600007B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAD8", Offset = "0x1FACAD8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002188 File Offset: 0x00000388
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000218B File Offset: 0x0000038B
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public Dropdown.DropdownEvent onValueChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAE4", Offset = "0x1FACAE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600007D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAEC", Offset = "0x1FACAEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000218E File Offset: 0x0000038E
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002191 File Offset: 0x00000391
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		public float alphaFadeSpeed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAF4", Offset = "0x1FACAF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600007F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACAFC", Offset = "0x1FACAFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002194 File Offset: 0x00000394
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002197 File Offset: 0x00000397
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		public int value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000080")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACB04", Offset = "0x1FACB04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000081")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACB0C", Offset = "0x1FACB0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000219A File Offset: 0x0000039A
		[global::Cpp2ILInjected.Token(Token = "0x6000082")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FACC0C", Offset = "0x1FACC0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "Set", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void SetValueWithoutNotify(int input)
		{
			throw null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000219D File Offset: 0x0000039D
		[global::Cpp2ILInjected.Token(Token = "0x6000083")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FACB14", Offset = "0x1FACB14", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "OnSelectItem", MemberParameters = new object[] { typeof(Toggle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<int>), Member = "Invoke", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Set(int value, bool sendCallback = true)
		{
			throw null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000021A0 File Offset: 0x000003A0
		[global::Cpp2ILInjected.Token(Token = "0x6000084")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FACC14", Offset = "0x1FACC14", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown.OptionDataList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown.DropdownEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected Dropdown()
		{
			throw null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000021A3 File Offset: 0x000003A3
		[global::Cpp2ILInjected.Token(Token = "0x6000085")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FACDE0", Offset = "0x1FACDE0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000021A6 File Offset: 0x000003A6
		[global::Cpp2ILInjected.Token(Token = "0x6000086")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FACECC", Offset = "0x1FACECC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TweenRunner<FloatTween>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000021A9 File Offset: 0x000003A9
		[global::Cpp2ILInjected.Token(Token = "0x6000087")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FACF60", Offset = "0x1FACF60", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "ImmediateDestroyDropdownList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000021AC File Offset: 0x000003AC
		[global::Cpp2ILInjected.Token(Token = "0x6000088")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FABEE0", Offset = "0x1FABEE0", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "set_template", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "set_captionText", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "set_captionImage", MemberParameters = new object[] { typeof(Image) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "set_itemText", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "set_itemImage", MemberParameters = new object[] { typeof(Image) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "set_options", MemberParameters = new object[] { typeof(List<Dropdown.OptionData>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "Set", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "AddOptions", MemberParameters = new object[] { typeof(List<Dropdown.OptionData>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "AddOptions", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "AddOptions", MemberParameters = new object[] { typeof(List<Sprite>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void RefreshShownValue()
		{
			throw null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000021AF File Offset: 0x000003AF
		[global::Cpp2ILInjected.Token(Token = "0x6000089")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAD164", Offset = "0x1FAD164", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddOptions(List<Dropdown.OptionData> options)
		{
			throw null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000021B2 File Offset: 0x000003B2
		[global::Cpp2ILInjected.Token(Token = "0x600008A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAD1C8", Offset = "0x1FAD1C8", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddOptions(List<string> options)
		{
			throw null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000021B5 File Offset: 0x000003B5
		[global::Cpp2ILInjected.Token(Token = "0x600008B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAD334", Offset = "0x1FAD334", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddOptions(List<Sprite> options)
		{
			throw null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000021B8 File Offset: 0x000003B8
		[global::Cpp2ILInjected.Token(Token = "0x600008C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAD4A0", Offset = "0x1FAD4A0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ClearOptions()
		{
			throw null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000021BB File Offset: 0x000003BB
		[global::Cpp2ILInjected.Token(Token = "0x600008D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAD50C", Offset = "0x1FAD50C", Length = "0x61C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_sortingLayerID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_sortingLayerID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Component))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Component))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "GetOrAddComponent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private void SetupTemplate(Canvas rootCanvas)
		{
			throw null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000021BE File Offset: 0x000003BE
		[global::Cpp2ILInjected.Token(Token = "0x600008E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1579A5C", Offset = "0x1579A5C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "SetupTemplate", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "CreateBlocker", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			throw null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000021C1 File Offset: 0x000003C1
		[global::Cpp2ILInjected.Token(Token = "0x600008F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FADB28", Offset = "0x1FADB28", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000021C4 File Offset: 0x000003C4
		[global::Cpp2ILInjected.Token(Token = "0x6000090")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAE63C", Offset = "0x1FAE63C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
		public virtual void OnSubmit(BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000021C7 File Offset: 0x000003C7
		[global::Cpp2ILInjected.Token(Token = "0x6000091")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAE640", Offset = "0x1FAE640", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnCancel(BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000021CA File Offset: 0x000003CA
		[global::Cpp2ILInjected.Token(Token = "0x6000092")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FADB2C", Offset = "0x1FADB2C", Length = "0xB10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "OnSubmit", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(bool),
			"System.Collections.Generic.List`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_isRootCanvas", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "SetupTemplate", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_min", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_max", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "AddItem", MemberParameters = new object[]
		{
			typeof(Dropdown.OptionData),
			typeof(bool),
			typeof(Dropdown.DropdownItem),
			typeof(List<Dropdown.DropdownItem>)
		}, ReturnType = typeof(Dropdown.DropdownItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<>), Member = "AddListener", MemberParameters = new object[] { "UnityEngine.Events.UnityAction`1<T0>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "set_navigation", MemberParameters = new object[] { typeof(Navigation) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "FlipLayoutOnAxis", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "AlphaFadeList", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public void Show()
		{
			throw null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000021CD File Offset: 0x000003CD
		[global::Cpp2ILInjected.Token(Token = "0x6000093")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAEB0C", Offset = "0x1FAEB0C", Length = "0x480")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_sortingLayerID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_sortingLayerID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Component))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Component))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "GetOrAddComponent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		protected virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			throw null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000021D0 File Offset: 0x000003D0
		[global::Cpp2ILInjected.Token(Token = "0x6000094")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAEF8C", Offset = "0x1FAEF8C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void DestroyBlocker(GameObject blocker)
		{
			throw null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000021D3 File Offset: 0x000003D3
		[global::Cpp2ILInjected.Token(Token = "0x6000095")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAEFE4", Offset = "0x1FAEFE4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual GameObject CreateDropdownList(GameObject template)
		{
			throw null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000021D6 File Offset: 0x000003D6
		[global::Cpp2ILInjected.Token(Token = "0x6000096")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAF050", Offset = "0x1FAF050", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void DestroyDropdownList(GameObject dropdownList)
		{
			throw null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000021D9 File Offset: 0x000003D9
		[global::Cpp2ILInjected.Token(Token = "0x6000097")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAF0A8", Offset = "0x1FAF0A8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate)
		{
			throw null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000021DC File Offset: 0x000003DC
		[global::Cpp2ILInjected.Token(Token = "0x6000098")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAF114", Offset = "0x1FAF114", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void DestroyItem(Dropdown.DropdownItem item)
		{
			throw null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000021DF File Offset: 0x000003DF
		[global::Cpp2ILInjected.Token(Token = "0x6000099")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAE748", Offset = "0x1FAE748", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items)
		{
			throw null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000021E2 File Offset: 0x000003E2
		[global::Cpp2ILInjected.Token(Token = "0x600009A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAF118", Offset = "0x1FAF118", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "Hide", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasGroup), Member = "get_alpha", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "AlphaFadeList", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void AlphaFadeList(float duration, float alpha)
		{
			throw null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000021E5 File Offset: 0x000003E5
		[global::Cpp2ILInjected.Token(Token = "0x600009B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAEA00", Offset = "0x1FAEA00", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "AlphaFadeList", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Equals", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatTween), Member = "AddOnChangedCallback", MemberParameters = new object[] { typeof(UnityAction<float>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TweenRunner<FloatTween>), Member = "StartTween", MemberParameters = new object[] { typeof(FloatTween) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void AlphaFadeList(float duration, float start, float end)
		{
			throw null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000021E8 File Offset: 0x000003E8
		[global::Cpp2ILInjected.Token(Token = "0x600009C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAF18C", Offset = "0x1FAF18C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasGroup), Member = "set_alpha", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void SetAlpha(float alpha)
		{
			throw null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000021EB File Offset: 0x000003EB
		[global::Cpp2ILInjected.Token(Token = "0x600009D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAE644", Offset = "0x1FAE644", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown.DropdownItem), Member = "OnCancel", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "OnSelectItem", MemberParameters = new object[] { typeof(Toggle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "AlphaFadeList", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "DelayedDestroyDropdownList", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(Coroutine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000021EE File Offset: 0x000003EE
		[global::Cpp2ILInjected.Token(Token = "0x600009E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAF234", Offset = "0x1FAF234", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "Hide", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator DelayedDestroyDropdownList(float delay)
		{
			throw null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000021F1 File Offset: 0x000003F1
		[global::Cpp2ILInjected.Token(Token = "0x600009F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FACFF4", Offset = "0x1FACFF4", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown.<DelayedDestroyDropdownList>d__75), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ImmediateDestroyDropdownList()
		{
			throw null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000021F4 File Offset: 0x000003F4
		[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAF2CC", Offset = "0x1FAF2CC", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown.<>c__DisplayClass63_0), Member = "<Show>b__0", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "Set", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "Hide", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnSelectItem(Toggle toggle)
		{
			throw null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000021F7 File Offset: 0x000003F7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FAF3F4", Offset = "0x1FAF3F4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Dropdown()
		{
			throw null;
		}

		// Token: 0x04000031 RID: 49
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private RectTransform m_Template;

		// Token: 0x04000032 RID: 50
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private Text m_CaptionText;

		// Token: 0x04000033 RID: 51
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private Image m_CaptionImage;

		// Token: 0x04000034 RID: 52
		[SerializeField]
		[Space]
		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private Text m_ItemText;

		// Token: 0x04000035 RID: 53
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private Image m_ItemImage;

		// Token: 0x04000036 RID: 54
		[SerializeField]
		[Space]
		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private int m_Value;

		// Token: 0x04000037 RID: 55
		[Space]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private Dropdown.OptionDataList m_Options;

		// Token: 0x04000038 RID: 56
		[Space]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private Dropdown.DropdownEvent m_OnValueChanged;

		// Token: 0x04000039 RID: 57
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private float m_AlphaFadeSpeed;

		// Token: 0x0400003A RID: 58
		[global::Cpp2ILInjected.Token(Token = "0x4000047")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private GameObject m_Dropdown;

		// Token: 0x0400003B RID: 59
		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private GameObject m_Blocker;

		// Token: 0x0400003C RID: 60
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private List<Dropdown.DropdownItem> m_Items;

		// Token: 0x0400003D RID: 61
		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		// Token: 0x0400003E RID: 62
		[global::Cpp2ILInjected.Token(Token = "0x400004B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private bool validTemplate;

		// Token: 0x0400003F RID: 63
		[global::Cpp2ILInjected.Token(Token = "0x400004C")]
		private const int kHighSortingLayer = 30000;

		// Token: 0x04000040 RID: 64
		[global::Cpp2ILInjected.Token(Token = "0x400004D")]
		private static Dropdown.OptionData s_NoOptionData;

		// Token: 0x02000084 RID: 132
		[global::Cpp2ILInjected.Token(Token = "0x2000014")]
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
		{
			// Token: 0x170001BC RID: 444
			// (get) Token: 0x0600066F RID: 1647 RVA: 0x000032E9 File Offset: 0x000014E9
			// (set) Token: 0x06000670 RID: 1648 RVA: 0x000032EC File Offset: 0x000014EC
			[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
			public Text text
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF464", Offset = "0x1FAF464", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF46C", Offset = "0x1FAF46C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170001BD RID: 445
			// (get) Token: 0x06000671 RID: 1649 RVA: 0x000032EF File Offset: 0x000014EF
			// (set) Token: 0x06000672 RID: 1650 RVA: 0x000032F2 File Offset: 0x000014F2
			[global::Cpp2ILInjected.Token(Token = "0x17000020")]
			public Image image
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF474", Offset = "0x1FAF474", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF47C", Offset = "0x1FAF47C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x06000673 RID: 1651 RVA: 0x000032F5 File Offset: 0x000014F5
			// (set) Token: 0x06000674 RID: 1652 RVA: 0x000032F8 File Offset: 0x000014F8
			[global::Cpp2ILInjected.Token(Token = "0x17000021")]
			public RectTransform rectTransform
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF484", Offset = "0x1FAF484", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF48C", Offset = "0x1FAF48C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x06000675 RID: 1653 RVA: 0x000032FB File Offset: 0x000014FB
			// (set) Token: 0x06000676 RID: 1654 RVA: 0x000032FE File Offset: 0x000014FE
			[global::Cpp2ILInjected.Token(Token = "0x17000022")]
			public Toggle toggle
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF494", Offset = "0x1FAF494", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF49C", Offset = "0x1FAF49C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06000677 RID: 1655 RVA: 0x00003301 File Offset: 0x00001501
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAF4A4", Offset = "0x1FAF4A4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public virtual void OnPointerEnter(PointerEventData eventData)
			{
				throw null;
			}

			// Token: 0x06000678 RID: 1656 RVA: 0x00003304 File Offset: 0x00001504
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAF518", Offset = "0x1FAF518", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "Hide", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public virtual void OnCancel(BaseEventData eventData)
			{
				throw null;
			}

			// Token: 0x06000679 RID: 1657 RVA: 0x00003307 File Offset: 0x00001507
			[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAF5BC", Offset = "0x1FAF5BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
			public DropdownItem()
			{
				throw null;
			}

			// Token: 0x04000256 RID: 598
			[SerializeField]
			[global::Cpp2ILInjected.Token(Token = "0x400004E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Text m_Text;

			// Token: 0x04000257 RID: 599
			[SerializeField]
			[global::Cpp2ILInjected.Token(Token = "0x400004F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Image m_Image;

			// Token: 0x04000258 RID: 600
			[SerializeField]
			[global::Cpp2ILInjected.Token(Token = "0x4000050")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private RectTransform m_RectTransform;

			// Token: 0x04000259 RID: 601
			[SerializeField]
			[global::Cpp2ILInjected.Token(Token = "0x4000051")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Toggle m_Toggle;
		}

		// Token: 0x02000085 RID: 133
		[global::Cpp2ILInjected.Token(Token = "0x2000015")]
		[Serializable]
		public class OptionData
		{
			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x0600067A RID: 1658 RVA: 0x0000330A File Offset: 0x0000150A
			// (set) Token: 0x0600067B RID: 1659 RVA: 0x0000330D File Offset: 0x0000150D
			[global::Cpp2ILInjected.Token(Token = "0x17000023")]
			public string text
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF5C4", Offset = "0x1FAF5C4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF5CC", Offset = "0x1FAF5CC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x0600067C RID: 1660 RVA: 0x00003310 File Offset: 0x00001510
			// (set) Token: 0x0600067D RID: 1661 RVA: 0x00003313 File Offset: 0x00001513
			[global::Cpp2ILInjected.Token(Token = "0x17000024")]
			public Sprite image
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF5D4", Offset = "0x1FAF5D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF5DC", Offset = "0x1FAF5DC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x0600067E RID: 1662 RVA: 0x00003316 File Offset: 0x00001516
			[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FABED8", Offset = "0x1FABED8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public OptionData()
			{
				throw null;
			}

			// Token: 0x0600067F RID: 1663 RVA: 0x00003319 File Offset: 0x00001519
			[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAD30C", Offset = "0x1FAD30C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public OptionData(string text)
			{
				throw null;
			}

			// Token: 0x06000680 RID: 1664 RVA: 0x0000331C File Offset: 0x0000151C
			[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAD478", Offset = "0x1FAD478", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public OptionData(Sprite image)
			{
				throw null;
			}

			// Token: 0x06000681 RID: 1665 RVA: 0x0000331F File Offset: 0x0000151F
			[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAF5E4", Offset = "0x1FAF5E4", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public OptionData(string text, Sprite image)
			{
				throw null;
			}

			// Token: 0x0400025A RID: 602
			[SerializeField]
			[global::Cpp2ILInjected.Token(Token = "0x4000052")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string m_Text;

			// Token: 0x0400025B RID: 603
			[SerializeField]
			[global::Cpp2ILInjected.Token(Token = "0x4000053")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Sprite m_Image;
		}

		// Token: 0x02000086 RID: 134
		[global::Cpp2ILInjected.Token(Token = "0x2000016")]
		[Serializable]
		public class OptionDataList
		{
			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x06000682 RID: 1666 RVA: 0x00003322 File Offset: 0x00001522
			// (set) Token: 0x06000683 RID: 1667 RVA: 0x00003325 File Offset: 0x00001525
			[global::Cpp2ILInjected.Token(Token = "0x17000025")]
			public List<Dropdown.OptionData> options
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF610", Offset = "0x1FAF610", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF618", Offset = "0x1FAF618", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06000684 RID: 1668 RVA: 0x00003328 File Offset: 0x00001528
			[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACD18", Offset = "0x1FACD18", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public OptionDataList()
			{
				throw null;
			}

			// Token: 0x0400025C RID: 604
			[SerializeField]
			[global::Cpp2ILInjected.Token(Token = "0x4000054")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private List<Dropdown.OptionData> m_Options;
		}

		// Token: 0x02000087 RID: 135
		[global::Cpp2ILInjected.Token(Token = "0x2000017")]
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
			// Token: 0x06000685 RID: 1669 RVA: 0x0000332B File Offset: 0x0000152B
			[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FACD98", Offset = "0x1FACD98", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public DropdownEvent()
			{
				throw null;
			}
		}

		// Token: 0x02000088 RID: 136
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000018")]
		private sealed class <>c__DisplayClass63_0
		{
			// Token: 0x06000686 RID: 1670 RVA: 0x0000332E File Offset: 0x0000152E
			[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAE740", Offset = "0x1FAE740", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass63_0()
			{
				throw null;
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x00003331 File Offset: 0x00001531
			[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAF620", Offset = "0x1FAF620", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "OnSelectItem", MemberParameters = new object[] { typeof(Toggle) }, ReturnType = typeof(void))]
			internal void <Show>b__0(bool x)
			{
				throw null;
			}

			// Token: 0x0400025D RID: 605
			[global::Cpp2ILInjected.Token(Token = "0x4000055")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Dropdown.DropdownItem item;

			// Token: 0x0400025E RID: 606
			[global::Cpp2ILInjected.Token(Token = "0x4000056")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Dropdown <>4__this;
		}

		// Token: 0x02000089 RID: 137
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000019")]
		private sealed class <DelayedDestroyDropdownList>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000688 RID: 1672 RVA: 0x00003334 File Offset: 0x00001534
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAF2A4", Offset = "0x1FAF2A4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <DelayedDestroyDropdownList>d__75(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x00003337 File Offset: 0x00001537
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAF62C", Offset = "0x1FAF62C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x0600068A RID: 1674 RVA: 0x0000333A File Offset: 0x0000153A
			[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAF630", Offset = "0x1FAF630", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitForSecondsRealtime), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dropdown), Member = "ImmediateDestroyDropdownList", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x0600068B RID: 1675 RVA: 0x0000333D File Offset: 0x0000153D
			[global::Cpp2ILInjected.Token(Token = "0x17000026")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF6D0", Offset = "0x1FAF6D0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600068C RID: 1676 RVA: 0x00003340 File Offset: 0x00001540
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAF6D8", Offset = "0x1FAF6D8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x0600068D RID: 1677 RVA: 0x00003343 File Offset: 0x00001543
			[global::Cpp2ILInjected.Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FAF710", Offset = "0x1FAF710", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400025F RID: 607
			[global::Cpp2ILInjected.Token(Token = "0x4000057")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000260 RID: 608
			[global::Cpp2ILInjected.Token(Token = "0x4000058")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04000261 RID: 609
			[global::Cpp2ILInjected.Token(Token = "0x4000059")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public float delay;

			// Token: 0x04000262 RID: 610
			[global::Cpp2ILInjected.Token(Token = "0x400005A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Dropdown <>4__this;
		}
	}
}
