using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000018 RID: 24
	[AddComponentMenu("UI/Legacy/Input Field", 103)]
	[global::Cpp2ILInjected.Token(Token = "0x200002C")]
	public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002437 File Offset: 0x00000637
		[global::Cpp2ILInjected.Token(Token = "0x17000067")]
		private BaseInput input
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000187")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBCFC8", Offset = "0x1FBCFC8", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000243A File Offset: 0x0000063A
		[global::Cpp2ILInjected.Token(Token = "0x17000068")]
		private string compositionString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000188")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD0C8", Offset = "0x1FBD0C8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 83)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000243D File Offset: 0x0000063D
		[global::Cpp2ILInjected.Token(Token = "0x6000189")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBD154", Offset = "0x1FBD154", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField.SubmitEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField.EndEditEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField.OnChangeEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected InputField()
		{
			throw null;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002440 File Offset: 0x00000640
		[global::Cpp2ILInjected.Token(Token = "0x17000069")]
		protected Mesh mesh
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD44C", Offset = "0x1FBD44C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002443 File Offset: 0x00000643
		[global::Cpp2ILInjected.Token(Token = "0x1700006A")]
		protected TextGenerator cachedInputTextGenerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD4EC", Offset = "0x1FBD4EC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002449 File Offset: 0x00000649
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002446 File Offset: 0x00000646
		[global::Cpp2ILInjected.Token(Token = "0x1700006B")]
		public bool shouldHideMobileInput
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD5A8", Offset = "0x1FBD5A8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600018C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD550", Offset = "0x1FBD550", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000244F File Offset: 0x0000064F
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000244C File Offset: 0x0000064C
		[global::Cpp2ILInjected.Token(Token = "0x1700006C")]
		public virtual bool shouldActivateOnSelect
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD5FC", Offset = "0x1FBD5FC", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600018E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD5F0", Offset = "0x1FBD5F0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002452 File Offset: 0x00000652
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002455 File Offset: 0x00000655
		[global::Cpp2ILInjected.Token(Token = "0x1700006D")]
		public string text
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000190")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD628", Offset = "0x1FBD628", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000191")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD630", Offset = "0x1FBD630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002458 File Offset: 0x00000658
		[global::Cpp2ILInjected.Token(Token = "0x6000192")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBD91C", Offset = "0x1FBD91C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void SetTextWithoutNotify(string input)
		{
			throw null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000245B File Offset: 0x0000065B
		[global::Cpp2ILInjected.Token(Token = "0x6000193")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBD638", Offset = "0x1FBD638", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetTextWithoutNotify", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField.OnValidateInput), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void SetText(string value, bool sendCallback = true)
		{
			throw null;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000245E File Offset: 0x0000065E
		[global::Cpp2ILInjected.Token(Token = "0x1700006E")]
		public bool isFocused
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000194")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBDE40", Offset = "0x1FBDE40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002461 File Offset: 0x00000661
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002464 File Offset: 0x00000664
		[global::Cpp2ILInjected.Token(Token = "0x1700006F")]
		public float caretBlinkRate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000195")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBDE48", Offset = "0x1FBDE48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000196")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBDE50", Offset = "0x1FBDE50", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00002467 File Offset: 0x00000667
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0000246A File Offset: 0x0000066A
		[global::Cpp2ILInjected.Token(Token = "0x17000070")]
		public int caretWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000197")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBDF20", Offset = "0x1FBDF20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000198")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBDF28", Offset = "0x1FBDF28", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000246D File Offset: 0x0000066D
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002470 File Offset: 0x00000670
		[global::Cpp2ILInjected.Token(Token = "0x17000071")]
		public Text textComponent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000199")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBDFF4", Offset = "0x1FBDFF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600019A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBDFFC", Offset = "0x1FBDFFC", Length = "0x270")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "UnregisterDirtyMaterialCallback", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "RegisterDirtyMaterialCallback", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00002473 File Offset: 0x00000673
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002476 File Offset: 0x00000676
		[global::Cpp2ILInjected.Token(Token = "0x17000072")]
		public Graphic placeholder
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE26C", Offset = "0x1FBE26C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600019C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE274", Offset = "0x1FBE274", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00002479 File Offset: 0x00000679
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0000247C File Offset: 0x0000067C
		[global::Cpp2ILInjected.Token(Token = "0x17000073")]
		public Color caretColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE2CC", Offset = "0x1FBE2CC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600019E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE308", Offset = "0x1FBE308", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetColor", MemberParameters = new object[]
			{
				typeof(ref Color),
				typeof(Color)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000247F File Offset: 0x0000067F
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002482 File Offset: 0x00000682
		[global::Cpp2ILInjected.Token(Token = "0x17000074")]
		public bool customCaretColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE334", Offset = "0x1FBE334", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE33C", Offset = "0x1FBE33C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00002485 File Offset: 0x00000685
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00002488 File Offset: 0x00000688
		[global::Cpp2ILInjected.Token(Token = "0x17000075")]
		public Color selectionColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE358", Offset = "0x1FBE358", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE36C", Offset = "0x1FBE36C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetColor", MemberParameters = new object[]
			{
				typeof(ref Color),
				typeof(Color)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000248B File Offset: 0x0000068B
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0000248E File Offset: 0x0000068E
		[global::Cpp2ILInjected.Token(Token = "0x17000076")]
		public InputField.EndEditEvent onEndEdit
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE398", Offset = "0x1FBE398", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE3A0", Offset = "0x1FBE3A0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00002491 File Offset: 0x00000691
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002494 File Offset: 0x00000694
		[global::Cpp2ILInjected.Token(Token = "0x17000077")]
		public InputField.SubmitEvent onSubmit
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE3F8", Offset = "0x1FBE3F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE400", Offset = "0x1FBE400", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00002497 File Offset: 0x00000697
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0000249A File Offset: 0x0000069A
		[Obsolete("onValueChange has been renamed to onValueChanged")]
		[global::Cpp2ILInjected.Token(Token = "0x17000078")]
		public InputField.OnChangeEvent onValueChange
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE458", Offset = "0x1FBE458", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE460", Offset = "0x1FBE460", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000249D File Offset: 0x0000069D
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000024A0 File Offset: 0x000006A0
		[global::Cpp2ILInjected.Token(Token = "0x17000079")]
		public InputField.OnChangeEvent onValueChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE4BC", Offset = "0x1FBE4BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE464", Offset = "0x1FBE464", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000024A3 File Offset: 0x000006A3
		// (set) Token: 0x0600017F RID: 383 RVA: 0x000024A6 File Offset: 0x000006A6
		[global::Cpp2ILInjected.Token(Token = "0x1700007A")]
		public InputField.OnValidateInput onValidateInput
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE4C4", Offset = "0x1FBE4C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE4CC", Offset = "0x1FBE4CC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000024A9 File Offset: 0x000006A9
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000024AC File Offset: 0x000006AC
		[global::Cpp2ILInjected.Token(Token = "0x1700007B")]
		public int characterLimit
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE524", Offset = "0x1FBE524", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE52C", Offset = "0x1FBE52C", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_characterLimit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000024AF File Offset: 0x000006AF
		// (set) Token: 0x06000183 RID: 387 RVA: 0x000024B2 File Offset: 0x000006B2
		[global::Cpp2ILInjected.Token(Token = "0x1700007C")]
		public InputField.ContentType contentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE5EC", Offset = "0x1FBE5EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE5F4", Offset = "0x1FBE5F4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_inputType", MemberParameters = new object[] { typeof(InputField.InputType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_keyboardType", MemberParameters = new object[] { typeof(TouchScreenKeyboardType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_characterValidation", MemberParameters = new object[] { typeof(InputField.CharacterValidation) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetToCustomIfContentTypeIsNot", MemberParameters = new object[] { typeof(InputField.ContentType[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetToCustom", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000024B5 File Offset: 0x000006B5
		// (set) Token: 0x06000185 RID: 389 RVA: 0x000024B8 File Offset: 0x000006B8
		[global::Cpp2ILInjected.Token(Token = "0x1700007D")]
		public InputField.LineType lineType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE724", Offset = "0x1FBE724", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE72C", Offset = "0x1FBE72C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SetToCustomIfContentTypeIsNot", MemberParameters = new object[] { typeof(InputField.ContentType[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000024BB File Offset: 0x000006BB
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000024BE File Offset: 0x000006BE
		[global::Cpp2ILInjected.Token(Token = "0x1700007E")]
		public InputField.InputType inputType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE818", Offset = "0x1FBE818", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE820", Offset = "0x1FBE820", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new object[] { typeof(InputField.ContentType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000024C1 File Offset: 0x000006C1
		[global::Cpp2ILInjected.Token(Token = "0x1700007F")]
		public TouchScreenKeyboard touchScreenKeyboard
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE8BC", Offset = "0x1FBE8BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000024C4 File Offset: 0x000006C4
		// (set) Token: 0x0600018A RID: 394 RVA: 0x000024C7 File Offset: 0x000006C7
		[global::Cpp2ILInjected.Token(Token = "0x17000080")]
		public TouchScreenKeyboardType keyboardType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE8C4", Offset = "0x1FBE8C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE8CC", Offset = "0x1FBE8CC", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new object[] { typeof(InputField.ContentType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000024CA File Offset: 0x000006CA
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000024CD File Offset: 0x000006CD
		[global::Cpp2ILInjected.Token(Token = "0x17000081")]
		public InputField.CharacterValidation characterValidation
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE950", Offset = "0x1FBE950", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE958", Offset = "0x1FBE958", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new object[] { typeof(InputField.ContentType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000024D0 File Offset: 0x000006D0
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000024D3 File Offset: 0x000006D3
		[global::Cpp2ILInjected.Token(Token = "0x17000082")]
		public bool readOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE9DC", Offset = "0x1FBE9DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE9E4", Offset = "0x1FBE9E4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000024D6 File Offset: 0x000006D6
		[global::Cpp2ILInjected.Token(Token = "0x17000083")]
		public bool multiLine
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBE9F0", Offset = "0x1FBE9F0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000024D9 File Offset: 0x000006D9
		// (set) Token: 0x06000191 RID: 401 RVA: 0x000024DC File Offset: 0x000006DC
		[global::Cpp2ILInjected.Token(Token = "0x17000084")]
		public char asteriskChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEA04", Offset = "0x1FBEA04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEA0C", Offset = "0x1FBEA0C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[]
			{
				typeof(ref char),
				typeof(char)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000024DF File Offset: 0x000006DF
		[global::Cpp2ILInjected.Token(Token = "0x17000085")]
		public bool wasCanceled
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEA80", Offset = "0x1FBEA80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000024E2 File Offset: 0x000006E2
		[global::Cpp2ILInjected.Token(Token = "0x60001C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBEA88", Offset = "0x1FBEA88", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void ClampPos(ref int pos)
		{
			throw null;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000024E5 File Offset: 0x000006E5
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000024E8 File Offset: 0x000006E8
		[global::Cpp2ILInjected.Token(Token = "0x17000086")]
		protected int caretPositionInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEAB0", Offset = "0x1FBEAB0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEACC", Offset = "0x1FBEACC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000024EB File Offset: 0x000006EB
		// (set) Token: 0x06000197 RID: 407 RVA: 0x000024EE File Offset: 0x000006EE
		[global::Cpp2ILInjected.Token(Token = "0x17000087")]
		protected int caretSelectPositionInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEAF4", Offset = "0x1FBEAF4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEB10", Offset = "0x1FBEB10", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000198 RID: 408 RVA: 0x000024F1 File Offset: 0x000006F1
		[global::Cpp2ILInjected.Token(Token = "0x17000088")]
		private bool hasSelection
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEB38", Offset = "0x1FBEB38", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField.<CaretBlink>d__172), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GetSelectedString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveRight", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveLeft", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000024F4 File Offset: 0x000006F4
		// (set) Token: 0x0600019A RID: 410 RVA: 0x000024F7 File Offset: 0x000006F7
		[global::Cpp2ILInjected.Token(Token = "0x17000089")]
		public int caretPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEB78", Offset = "0x1FBEB78", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEB94", Offset = "0x1FBEB94", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "set_selectionAnchorPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "set_selectionFocusPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000024FA File Offset: 0x000006FA
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000024FD File Offset: 0x000006FD
		[global::Cpp2ILInjected.Token(Token = "0x1700008A")]
		public int selectionAnchorPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEC5C", Offset = "0x1FBEC5C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEBBC", Offset = "0x1FBEBBC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_caretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00002500 File Offset: 0x00000700
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002503 File Offset: 0x00000703
		[global::Cpp2ILInjected.Token(Token = "0x1700008B")]
		public int selectionFocusPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEC78", Offset = "0x1FBEC78", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBEC0C", Offset = "0x1FBEC0C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_caretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002506 File Offset: 0x00000706
		[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBEC94", Offset = "0x1FBEC94", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "Awake", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "get_deviceModel", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002509 File Offset: 0x00000709
		[global::Cpp2ILInjected.Token(Token = "0x60001CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBED54", Offset = "0x1FBED54", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(Texture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "RegisterDirtyMaterialCallback", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000250C File Offset: 0x0000070C
		[global::Cpp2ILInjected.Token(Token = "0x60001CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBEF9C", Offset = "0x1FBEF9C", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "UnregisterDirtyMaterialCallback", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "DisableCanvasElementForRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000250F File Offset: 0x0000070F
		[global::Cpp2ILInjected.Token(Token = "0x60001CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF330", Offset = "0x1FBF330", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDestroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002512 File Offset: 0x00000712
		[global::Cpp2ILInjected.Token(Token = "0x60001D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF394", Offset = "0x1FBF394", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator CaretBlink()
		{
			throw null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002515 File Offset: 0x00000715
		[global::Cpp2ILInjected.Token(Token = "0x60001D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF41C", Offset = "0x1FBF41C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SetCaretActive", ReturnType = typeof(void))]
		private void SetCaretVisible()
		{
			throw null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002518 File Offset: 0x00000718
		[global::Cpp2ILInjected.Token(Token = "0x60001D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBDECC", Offset = "0x1FBDECC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "CaretBlink", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(Coroutine))]
		private void SetCaretActive()
		{
			throw null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000251B File Offset: 0x0000071B
		[global::Cpp2ILInjected.Token(Token = "0x60001D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF454", Offset = "0x1FBF454", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(Texture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void UpdateCaretMaterial()
		{
			throw null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000251E File Offset: 0x0000071E
		[global::Cpp2ILInjected.Token(Token = "0x60001D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF558", Offset = "0x1FBF558", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void OnFocus()
		{
			throw null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002521 File Offset: 0x00000721
		[global::Cpp2ILInjected.Token(Token = "0x60001D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF57C", Offset = "0x1FBF57C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void SelectAll()
		{
			throw null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002524 File Offset: 0x00000724
		[global::Cpp2ILInjected.Token(Token = "0x60001D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF5A0", Offset = "0x1FBF5A0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		public void MoveTextEnd(bool shift)
		{
			throw null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002527 File Offset: 0x00000727
		[global::Cpp2ILInjected.Token(Token = "0x60001D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF60C", Offset = "0x1FBF60C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		public void MoveTextStart(bool shift)
		{
			throw null;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000252A File Offset: 0x0000072A
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000252D File Offset: 0x0000072D
		[global::Cpp2ILInjected.Token(Token = "0x1700008C")]
		private static string clipboard
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBF688", Offset = "0x1FBF688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBF690", Offset = "0x1FBF690", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002530 File Offset: 0x00000730
		[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF698", Offset = "0x1FBF698", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool TouchScreenKeyboardShouldBeUsed()
		{
			throw null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002533 File Offset: 0x00000733
		[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF718", Offset = "0x1FBF718", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		private bool InPlaceEditing()
		{
			throw null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002536 File Offset: 0x00000736
		[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF748", Offset = "0x1FBF748", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool InPlaceEditingChanged()
		{
			throw null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002539 File Offset: 0x00000739
		[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF7CC", Offset = "0x1FBF7CC", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_selection", ReturnType = typeof(RangeInt))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RangeInt), Member = "get_end", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		private void UpdateCaretFromKeyboard()
		{
			throw null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000253C File Offset: 0x0000073C
		[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF8B0", Offset = "0x1FBF8B0", Length = "0x604")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "InPlaceEditingChanged", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_mesh", ReturnType = typeof(Mesh))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_status", ReturnType = typeof(TouchScreenKeyboard.Status))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canSetSelection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RangeInt), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new object[] { typeof(RangeInt) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_canGetSelection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "Validate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SendOnSubmit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000253F File Offset: 0x0000073F
		[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC0D98", Offset = "0x1FC0D98", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Ray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Plane), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Plane), Member = "Raycast", MemberParameters = new object[]
		{
			typeof(Ray),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Vector2 ScreenToLocal(Vector2 screen)
		{
			throw null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002542 File Offset: 0x00000742
		[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC0FD8", Offset = "0x1FC0FD8", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(IList<UILineInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator)
		{
			throw null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002545 File Offset: 0x00000745
		[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC11D0", Offset = "0x1FC11D0", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(TextGenerator)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(IList<UILineInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new object[]
		{
			typeof(TextGenerator),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(IList<UICharInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected int GetCharacterIndexFromPosition(Vector2 pos)
		{
			throw null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002548 File Offset: 0x00000748
		[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC15A8", Offset = "0x1FC15A8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnBeginDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnEndDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool MayDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000254B File Offset: 0x0000074B
		[global::Cpp2ILInjected.Token(Token = "0x60001E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC1678", Offset = "0x1FC1678", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(bool))]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000254E File Offset: 0x0000074E
		[global::Cpp2ILInjected.Token(Token = "0x60001E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC1698", Offset = "0x1FC1698", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MouseDragOutsideRect", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(Coroutine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void OnDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002551 File Offset: 0x00000751
		[global::Cpp2ILInjected.Token(Token = "0x60001E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC186C", Offset = "0x1FC186C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002554 File Offset: 0x00000754
		[global::Cpp2ILInjected.Token(Token = "0x60001E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC1900", Offset = "0x1FC1900", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(bool))]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002557 File Offset: 0x00000757
		[global::Cpp2ILInjected.Token(Token = "0x60001E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC191C", Offset = "0x1FC191C", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MayDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000255A File Offset: 0x0000075A
		[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC1AE8", Offset = "0x1FC1AE8", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ProcessEvent", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "get_operatingSystemFamily", ReturnType = typeof(OperatingSystemFamily))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveRight", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveLeft", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GetSelectedString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveTextStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveTextEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "IsValidChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected InputField.EditState KeyPressed(Event evt)
		{
			throw null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000255D File Offset: 0x0000075D
		[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC2580", Offset = "0x1FC2580", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Font), Member = "HasCharacter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		private bool IsValidChar(char c)
		{
			throw null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002560 File Offset: 0x00000760
		[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC25E4", Offset = "0x1FC25E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		public void ProcessEvent(Event e)
		{
			throw null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002563 File Offset: 0x00000763
		[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC25E8", Offset = "0x1FC25E8", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "PopEvent", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SendOnSubmit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002566 File Offset: 0x00000766
		[global::Cpp2ILInjected.Token(Token = "0x60001EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC2078", Offset = "0x1FC2078", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string GetSelectedString()
		{
			throw null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002569 File Offset: 0x00000769
		[global::Cpp2ILInjected.Token(Token = "0x60001ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC2768", Offset = "0x1FC2768", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveRight", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int FindtNextWordBegin()
		{
			throw null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000256C File Offset: 0x0000076C
		[global::Cpp2ILInjected.Token(Token = "0x60001EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC244C", Offset = "0x1FC244C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField.<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "FindtNextWordBegin", ReturnType = typeof(int))]
		private void MoveRight(bool shift, bool ctrl)
		{
			throw null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000256F File Offset: 0x0000076F
		[global::Cpp2ILInjected.Token(Token = "0x60001EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC282C", Offset = "0x1FC282C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveLeft", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int FindtPrevWordBegin()
		{
			throw null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002572 File Offset: 0x00000772
		[global::Cpp2ILInjected.Token(Token = "0x60001F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC2330", Offset = "0x1FC2330", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField.<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "FindtPrevWordBegin", ReturnType = typeof(int))]
		private void MoveLeft(bool shift, bool ctrl)
		{
			throw null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002575 File Offset: 0x00000775
		[global::Cpp2ILInjected.Token(Token = "0x60001F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC28D4", Offset = "0x1FC28D4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(IList<UILineInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int DetermineCharacterLine(int charPos, TextGenerator generator)
		{
			throw null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002578 File Offset: 0x00000778
		[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC29D8", Offset = "0x1FC29D8", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(IList<UICharInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextGenerator)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(IList<UILineInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			throw null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000257B File Offset: 0x0000077B
		[global::Cpp2ILInjected.Token(Token = "0x60001F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC2D00", Offset = "0x1FC2D00", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(IList<UICharInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextGenerator)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new object[]
		{
			typeof(TextGenerator),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(IList<UILineInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			throw null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000257E File Offset: 0x0000077E
		[global::Cpp2ILInjected.Token(Token = "0x60001F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC2574", Offset = "0x1FC2574", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void MoveDown(bool shift)
		{
			throw null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002581 File Offset: 0x00000781
		[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC2F94", Offset = "0x1FC2F94", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField.<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		private void MoveDown(bool shift, bool goToLastChar)
		{
			throw null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002584 File Offset: 0x00000784
		[global::Cpp2ILInjected.Token(Token = "0x60001F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC2568", Offset = "0x1FC2568", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void MoveUp(bool shift)
		{
			throw null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002587 File Offset: 0x00000787
		[global::Cpp2ILInjected.Token(Token = "0x60001F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC30B0", Offset = "0x1FC30B0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField.<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "LineUpCharacterPosition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
			throw null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000258A File Offset: 0x0000078A
		[global::Cpp2ILInjected.Token(Token = "0x60001F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC210C", Offset = "0x1FC210C", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Insert", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		private void Delete()
		{
			throw null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000258D File Offset: 0x0000078D
		[global::Cpp2ILInjected.Token(Token = "0x60001F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC1FE0", Offset = "0x1FC1FE0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		private void ForwardSpace()
		{
			throw null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002590 File Offset: 0x00000790
		[global::Cpp2ILInjected.Token(Token = "0x60001FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC1ED0", Offset = "0x1FC1ED0", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private void Backspace()
		{
			throw null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002593 File Offset: 0x00000793
		[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC31D8", Offset = "0x1FC31D8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "Delete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
		private void Insert(char c)
		{
			throw null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002596 File Offset: 0x00000796
		[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC22F0", Offset = "0x1FC22F0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Insert", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private void UpdateTouchKeyboardFromEditChanges()
		{
			throw null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002599 File Offset: 0x00000799
		[global::Cpp2ILInjected.Token(Token = "0x60001FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC0D80", Offset = "0x1FC0D80", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SendOnValueChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		private void SendOnValueChangedAndUpdateLabel()
		{
			throw null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000259C File Offset: 0x0000079C
		[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBD9FC", Offset = "0x1FBD9FC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Insert", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = "Invoke", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SendOnValueChanged()
		{
			throw null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000259F File Offset: 0x0000079F
		[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC32AC", Offset = "0x1FC32AC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = "Invoke", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void SendOnEndEdit()
		{
			throw null;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000025A2 File Offset: 0x000007A2
		[global::Cpp2ILInjected.Token(Token = "0x6000200")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC064C", Offset = "0x1FC064C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = "Invoke", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void SendOnSubmit()
		{
			throw null;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000025A5 File Offset: 0x000007A5
		[global::Cpp2ILInjected.Token(Token = "0x6000201")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC332C", Offset = "0x1FC332C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		protected virtual void Append(string input)
		{
			throw null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000025A8 File Offset: 0x000007A8
		[global::Cpp2ILInjected.Token(Token = "0x6000202")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC33E0", Offset = "0x1FC33E0", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "Validate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "Insert", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual void Append(char input)
		{
			throw null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000025AB File Offset: 0x000007AB
		[global::Cpp2ILInjected.Token(Token = "0x6000203")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBDA7C", Offset = "0x1FBDA7C", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField.<MouseDragOutsideRect>d__194), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_characterLimit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_asteriskChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveTextEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "MoveTextStart", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = typeof(InputField.EditState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ForwardSpace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Backspace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SendOnValueChangedAndUpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ForceLabelUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(TextGenerationSettings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "PopulateWithErrors", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings),
			typeof(GameObject)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected void UpdateLabel()
		{
			throw null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000025AE File Offset: 0x000007AE
		[global::Cpp2ILInjected.Token(Token = "0x6000204")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC4168", Offset = "0x1FC4168", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		private bool IsSelectionVisible()
		{
			throw null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000025B1 File Offset: 0x000007B1
		[global::Cpp2ILInjected.Token(Token = "0x6000205")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC41F8", Offset = "0x1FC41F8", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(IList<UILineInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int GetLineStartPosition(TextGenerator gen, int line)
		{
			throw null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000025B4 File Offset: 0x000007B4
		[global::Cpp2ILInjected.Token(Token = "0x6000206")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC1448", Offset = "0x1FC1448", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LineDownCharacterPosition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(IList<UILineInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int GetLineEndPosition(TextGenerator gen, int line)
		{
			throw null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000025B7 File Offset: 0x000007B7
		[global::Cpp2ILInjected.Token(Token = "0x6000207")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC3668", Offset = "0x1FC3668", Length = "0xB00")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_rectExtents", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(IList<UILineInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextGenerator)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new object[]
		{
			typeof(TextGenerator),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(IList<UICharInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characterCountVisible", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GetLineStartPosition", MemberParameters = new object[]
		{
			typeof(TextGenerator),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private void SetDrawRangeToContainCaretPosition(int caretPos)
		{
			throw null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000025BA File Offset: 0x000007BA
		[global::Cpp2ILInjected.Token(Token = "0x6000208")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC4340", Offset = "0x1FC4340", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		public void ForceLabelUpdate()
		{
			throw null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000025BD File Offset: 0x000007BD
		[global::Cpp2ILInjected.Token(Token = "0x6000209")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBDF9C", Offset = "0x1FBDF9C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField.<CaretBlink>d__172), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_caretColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_customCaretColor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_selectionColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void MarkGeometryAsDirty()
		{
			throw null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000025C0 File Offset: 0x000007C0
		[global::Cpp2ILInjected.Token(Token = "0x600020A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC4344", Offset = "0x1FC4344", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Rebuild(CanvasUpdate update)
		{
			throw null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000025C3 File Offset: 0x000007C3
		[global::Cpp2ILInjected.Token(Token = "0x600020B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC4764", Offset = "0x1FC4764", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void LayoutComplete()
		{
			throw null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000025C6 File Offset: 0x000007C6
		[global::Cpp2ILInjected.Token(Token = "0x600020C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC4768", Offset = "0x1FC4768", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void GraphicUpdateComplete()
		{
			throw null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000025C9 File Offset: 0x000007C9
		[global::Cpp2ILInjected.Token(Token = "0x600020D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC4354", Offset = "0x1FC4354", Length = "0x410")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new object[] { typeof(HideFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "SetAsFirstSibling", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(Texture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_mesh", ReturnType = typeof(Mesh))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void UpdateGeometry()
		{
			throw null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000025CC File Offset: 0x000007CC
		[global::Cpp2ILInjected.Token(Token = "0x600020E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC0210", Offset = "0x1FC0210", Length = "0x43C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new object[] { typeof(Quaternion) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AssignPositioningIfNeeded()
		{
			throw null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000025CF File Offset: 0x000007CF
		[global::Cpp2ILInjected.Token(Token = "0x600020F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC476C", Offset = "0x1FC476C", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "PixelAdjustPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void OnFillVBO(Mesh vbo)
		{
			throw null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000025D2 File Offset: 0x000007D2
		[global::Cpp2ILInjected.Token(Token = "0x6000210")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC49CC", Offset = "0x1FC49CC", Length = "0x890")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "CreateCursorVerts", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(IList<UICharInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextGenerator)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(IList<UILineInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_caretColor", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new object[] { typeof(UIVertex[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_targetDisplay", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "WorldToScreenPoint", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Vector3)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
			throw null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000025D5 File Offset: 0x000007D5
		[global::Cpp2ILInjected.Token(Token = "0x6000211")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC5C60", Offset = "0x1FC5C60", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void CreateCursorVerts()
		{
			throw null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000025D8 File Offset: 0x000007D8
		[global::Cpp2ILInjected.Token(Token = "0x6000212")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC525C", Offset = "0x1FC525C", Length = "0xA04")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lineCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "DetermineCharacterLine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TextGenerator)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "GetLineEndPosition", MemberParameters = new object[]
		{
			typeof(TextGenerator),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characterCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_characters", ReturnType = typeof(IList<UICharInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_lines", ReturnType = typeof(IList<UILineInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[] { typeof(UIVertex) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset)
		{
			throw null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000025DB File Offset: 0x000007DB
		[global::Cpp2ILInjected.Token(Token = "0x6000213")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC06CC", Offset = "0x1FC06CC", Length = "0x6B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_compositionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected char Validate(string text, int pos, char ch)
		{
			throw null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000025DE File Offset: 0x000007DE
		[global::Cpp2ILInjected.Token(Token = "0x6000214")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC5D78", Offset = "0x1FC5D78", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnSelect", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnPointerClick", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void ActivateInputField()
		{
			throw null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000025E1 File Offset: 0x000007E1
		[global::Cpp2ILInjected.Token(Token = "0x6000215")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBFEB4", Offset = "0x1FBFEB4", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isInPlaceEditingAllowed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_hideInput", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TouchScreenKeyboardType),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(TouchScreenKeyboard))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveTextEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SetCaretVisible", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void ActivateInputFieldInternal()
		{
			throw null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000025E4 File Offset: 0x000007E4
		[global::Cpp2ILInjected.Token(Token = "0x6000216")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC5E88", Offset = "0x1FC5E88", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSelect", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
		public override void OnSelect(BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000025E7 File Offset: 0x000007E7
		[global::Cpp2ILInjected.Token(Token = "0x6000217")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC5EC4", Offset = "0x1FC5EC4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000025EA File Offset: 0x000007EA
		[global::Cpp2ILInjected.Token(Token = "0x6000218")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBF1C0", Offset = "0x1FBF1C0", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnUpdateSelected", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnDeselect", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "SendOnEndEdit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "set_active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DeactivateInputField()
		{
			throw null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000025ED File Offset: 0x000007ED
		[global::Cpp2ILInjected.Token(Token = "0x6000219")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC5ED4", Offset = "0x1FC5ED4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "DeactivateInputField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnDeselect", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		public override void OnDeselect(BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000025F0 File Offset: 0x000007F0
		[global::Cpp2ILInjected.Token(Token = "0x600021A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC5F00", Offset = "0x1FC5F00", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnSubmit(BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000025F3 File Offset: 0x000007F3
		[global::Cpp2ILInjected.Token(Token = "0x600021B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBE668", Offset = "0x1FBE668", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void EnforceContentType()
		{
			throw null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000025F6 File Offset: 0x000007F6
		[global::Cpp2ILInjected.Token(Token = "0x600021C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBD3C0", Offset = "0x1FBD3C0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_lineType", MemberParameters = new object[] { typeof(InputField.LineType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "EnforceContentType", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "set_horizontalOverflow", MemberParameters = new object[] { typeof(HorizontalWrapMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnforceTextHOverflow()
		{
			throw null;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000025F9 File Offset: 0x000007F9
		[global::Cpp2ILInjected.Token(Token = "0x600021D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBE7D4", Offset = "0x1FBE7D4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_lineType", MemberParameters = new object[] { typeof(InputField.LineType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new object[] { typeof(InputField.ContentType) }, ReturnType = typeof(void))]
		private void SetToCustomIfContentTypeIsNot(params InputField.ContentType[] allowedContentTypes)
		{
			throw null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000025FC File Offset: 0x000007FC
		[global::Cpp2ILInjected.Token(Token = "0x600021E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBE8A4", Offset = "0x1FBE8A4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new object[] { typeof(InputField.ContentType) }, ReturnType = typeof(void))]
		private void SetToCustom()
		{
			throw null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000025FF File Offset: 0x000007FF
		[global::Cpp2ILInjected.Token(Token = "0x600021F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC5F48", Offset = "0x1FC5F48", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "DoStateTransition", MemberParameters = new object[]
		{
			typeof(Selectable.SelectionState),
			typeof(bool)
		}, ReturnType = typeof(void))]
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			throw null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002602 File Offset: 0x00000802
		[global::Cpp2ILInjected.Token(Token = "0x6000220")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC5F74", Offset = "0x1FC5F74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CalculateLayoutInputHorizontal()
		{
			throw null;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002605 File Offset: 0x00000805
		[global::Cpp2ILInjected.Token(Token = "0x6000221")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC5F78", Offset = "0x1FC5F78", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CalculateLayoutInputVertical()
		{
			throw null;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002608 File Offset: 0x00000808
		[global::Cpp2ILInjected.Token(Token = "0x1700008D")]
		public virtual float minWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000222")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC5F7C", Offset = "0x1FC5F7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000260B File Offset: 0x0000080B
		[global::Cpp2ILInjected.Token(Token = "0x1700008E")]
		public virtual float preferredWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000223")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC5F84", Offset = "0x1FC5F84", Length = "0x138")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(TextGenerationSettings))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new object[]
			{
				typeof(string),
				typeof(TextGenerationSettings)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000260E File Offset: 0x0000080E
		[global::Cpp2ILInjected.Token(Token = "0x1700008F")]
		public virtual float flexibleWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000224")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC60BC", Offset = "0x1FC60BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00002611 File Offset: 0x00000811
		[global::Cpp2ILInjected.Token(Token = "0x17000090")]
		public virtual float minHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000225")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC60C4", Offset = "0x1FC60C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002614 File Offset: 0x00000814
		[global::Cpp2ILInjected.Token(Token = "0x17000091")]
		public virtual float preferredHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000226")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC60CC", Offset = "0x1FC60CC", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(TextGenerationSettings))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new object[]
			{
				typeof(string),
				typeof(TextGenerationSettings)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00002617 File Offset: 0x00000817
		[global::Cpp2ILInjected.Token(Token = "0x17000092")]
		public virtual float flexibleHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000227")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC6200", Offset = "0x1FC6200", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000261A File Offset: 0x0000081A
		[global::Cpp2ILInjected.Token(Token = "0x17000093")]
		public virtual int layoutPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000228")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC6208", Offset = "0x1FC6208", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000261D File Offset: 0x0000081D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000229")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC6210", Offset = "0x1FC6210", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static InputField()
		{
			throw null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002620 File Offset: 0x00000820
		[global::Cpp2ILInjected.Token(Token = "0x600022A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC62B0", Offset = "0x1FC62B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			throw null;
		}

		// Token: 0x04000085 RID: 133
		[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		protected TouchScreenKeyboard m_Keyboard;

		// Token: 0x04000086 RID: 134
		[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
		private static readonly char[] kSeparators;

		// Token: 0x04000087 RID: 135
		[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
		private static bool s_IsQuestDeviceEvaluated;

		// Token: 0x04000088 RID: 136
		[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
		private static bool s_IsQuestDevice;

		// Token: 0x04000089 RID: 137
		[FormerlySerializedAs("text")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		protected Text m_TextComponent;

		// Token: 0x0400008A RID: 138
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		protected Graphic m_Placeholder;

		// Token: 0x0400008B RID: 139
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private InputField.ContentType m_ContentType;

		// Token: 0x0400008C RID: 140
		[SerializeField]
		[FormerlySerializedAs("inputType")]
		[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
		private InputField.InputType m_InputType;

		// Token: 0x0400008D RID: 141
		[FormerlySerializedAs("asteriskChar")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private char m_AsteriskChar;

		// Token: 0x0400008E RID: 142
		[FormerlySerializedAs("keyboardType")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
		private TouchScreenKeyboardType m_KeyboardType;

		// Token: 0x0400008F RID: 143
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private InputField.LineType m_LineType;

		// Token: 0x04000090 RID: 144
		[FormerlySerializedAs("hideMobileInput")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
		private bool m_HideMobileInput;

		// Token: 0x04000091 RID: 145
		[FormerlySerializedAs("validation")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private InputField.CharacterValidation m_CharacterValidation;

		// Token: 0x04000092 RID: 146
		[SerializeField]
		[FormerlySerializedAs("characterLimit")]
		[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
		private int m_CharacterLimit;

		// Token: 0x04000093 RID: 147
		[FormerlySerializedAs("m_EndEdit")]
		[FormerlySerializedAs("m_OnSubmit")]
		[FormerlySerializedAs("onSubmit")]
		[SerializeField]
		[FormerlySerializedAs("m_OnEndEdit")]
		[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private InputField.SubmitEvent m_OnSubmit;

		// Token: 0x04000094 RID: 148
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private InputField.EndEditEvent m_OnDidEndEdit;

		// Token: 0x04000095 RID: 149
		[SerializeField]
		[FormerlySerializedAs("m_OnValueChange")]
		[FormerlySerializedAs("onValueChange")]
		[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private InputField.OnChangeEvent m_OnValueChanged;

		// Token: 0x04000096 RID: 150
		[SerializeField]
		[FormerlySerializedAs("onValidateInput")]
		[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private InputField.OnValidateInput m_OnValidateInput;

		// Token: 0x04000097 RID: 151
		[FormerlySerializedAs("selectionColor")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Color m_CaretColor;

		// Token: 0x04000098 RID: 152
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private bool m_CustomCaretColor;

		// Token: 0x04000099 RID: 153
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
		private Color m_SelectionColor;

		// Token: 0x0400009A RID: 154
		[SerializeField]
		[Multiline]
		[FormerlySerializedAs("mValue")]
		[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		protected string m_Text;

		// Token: 0x0400009B RID: 155
		[SerializeField]
		[Range(0f, 4f)]
		[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private float m_CaretBlinkRate;

		// Token: 0x0400009C RID: 156
		[SerializeField]
		[Range(1f, 5f)]
		[global::Cpp2ILInjected.Token(Token = "0x40000DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x184")]
		private int m_CaretWidth;

		// Token: 0x0400009D RID: 157
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private bool m_ReadOnly;

		// Token: 0x0400009E RID: 158
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x189")]
		private bool m_ShouldActivateOnSelect;

		// Token: 0x0400009F RID: 159
		[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18C")]
		protected int m_CaretPosition;

		// Token: 0x040000A0 RID: 160
		[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		protected int m_CaretSelectPosition;

		// Token: 0x040000A1 RID: 161
		[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		private RectTransform caretRectTrans;

		// Token: 0x040000A2 RID: 162
		[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		protected UIVertex[] m_CursorVerts;

		// Token: 0x040000A3 RID: 163
		[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		private TextGenerator m_InputTextCache;

		// Token: 0x040000A4 RID: 164
		[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		private CanvasRenderer m_CachedInputRenderer;

		// Token: 0x040000A5 RID: 165
		[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		private bool m_PreventFontCallback;

		// Token: 0x040000A6 RID: 166
		[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		[NonSerialized]
		protected Mesh m_Mesh;

		// Token: 0x040000A7 RID: 167
		[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		private bool m_AllowInput;

		// Token: 0x040000A8 RID: 168
		[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C9")]
		private bool m_ShouldActivateNextUpdate;

		// Token: 0x040000A9 RID: 169
		[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1CA")]
		private bool m_UpdateDrag;

		// Token: 0x040000AA RID: 170
		[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1CB")]
		private bool m_DragPositionOutOfBounds;

		// Token: 0x040000AB RID: 171
		[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
		private const float kHScrollSpeed = 0.05f;

		// Token: 0x040000AC RID: 172
		[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
		private const float kVScrollSpeed = 0.1f;

		// Token: 0x040000AD RID: 173
		[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1CC")]
		protected bool m_CaretVisible;

		// Token: 0x040000AE RID: 174
		[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		private Coroutine m_BlinkCoroutine;

		// Token: 0x040000AF RID: 175
		[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
		private float m_BlinkStartTime;

		// Token: 0x040000B0 RID: 176
		[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1DC")]
		protected int m_DrawStart;

		// Token: 0x040000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
		protected int m_DrawEnd;

		// Token: 0x040000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
		private Coroutine m_DragCoroutine;

		// Token: 0x040000B3 RID: 179
		[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
		private string m_OriginalText;

		// Token: 0x040000B4 RID: 180
		[global::Cpp2ILInjected.Token(Token = "0x40000F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
		private bool m_WasCanceled;

		// Token: 0x040000B5 RID: 181
		[global::Cpp2ILInjected.Token(Token = "0x40000F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F9")]
		private bool m_HasDoneFocusTransition;

		// Token: 0x040000B6 RID: 182
		[global::Cpp2ILInjected.Token(Token = "0x40000F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
		private WaitForSecondsRealtime m_WaitForSecondsRealtime;

		// Token: 0x040000B7 RID: 183
		[global::Cpp2ILInjected.Token(Token = "0x40000F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
		private bool m_TouchKeyboardAllowsInPlaceEditing;

		// Token: 0x040000B8 RID: 184
		[global::Cpp2ILInjected.Token(Token = "0x40000F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x209")]
		private bool m_IsCompositionActive;

		// Token: 0x040000B9 RID: 185
		[global::Cpp2ILInjected.Token(Token = "0x40000FA")]
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		// Token: 0x040000BA RID: 186
		[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
		private const string kOculusQuestDeviceModel = "Oculus Quest";

		// Token: 0x040000BB RID: 187
		[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
		private Event m_ProcessingEvent;

		// Token: 0x040000BC RID: 188
		[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
		private const int k_MaxTextLength = 16382;

		// Token: 0x02000093 RID: 147
		[global::Cpp2ILInjected.Token(Token = "0x200002D")]
		public enum ContentType
		{
			// Token: 0x0400028B RID: 651
			[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
			Standard,
			// Token: 0x0400028C RID: 652
			[global::Cpp2ILInjected.Token(Token = "0x4000100")]
			Autocorrected,
			// Token: 0x0400028D RID: 653
			[global::Cpp2ILInjected.Token(Token = "0x4000101")]
			IntegerNumber,
			// Token: 0x0400028E RID: 654
			[global::Cpp2ILInjected.Token(Token = "0x4000102")]
			DecimalNumber,
			// Token: 0x0400028F RID: 655
			[global::Cpp2ILInjected.Token(Token = "0x4000103")]
			Alphanumeric,
			// Token: 0x04000290 RID: 656
			[global::Cpp2ILInjected.Token(Token = "0x4000104")]
			Name,
			// Token: 0x04000291 RID: 657
			[global::Cpp2ILInjected.Token(Token = "0x4000105")]
			EmailAddress,
			// Token: 0x04000292 RID: 658
			[global::Cpp2ILInjected.Token(Token = "0x4000106")]
			Password,
			// Token: 0x04000293 RID: 659
			[global::Cpp2ILInjected.Token(Token = "0x4000107")]
			Pin,
			// Token: 0x04000294 RID: 660
			[global::Cpp2ILInjected.Token(Token = "0x4000108")]
			Custom
		}

		// Token: 0x02000094 RID: 148
		[global::Cpp2ILInjected.Token(Token = "0x200002E")]
		public enum InputType
		{
			// Token: 0x04000296 RID: 662
			[global::Cpp2ILInjected.Token(Token = "0x400010A")]
			Standard,
			// Token: 0x04000297 RID: 663
			[global::Cpp2ILInjected.Token(Token = "0x400010B")]
			AutoCorrect,
			// Token: 0x04000298 RID: 664
			[global::Cpp2ILInjected.Token(Token = "0x400010C")]
			Password
		}

		// Token: 0x02000095 RID: 149
		[global::Cpp2ILInjected.Token(Token = "0x200002F")]
		public enum CharacterValidation
		{
			// Token: 0x0400029A RID: 666
			[global::Cpp2ILInjected.Token(Token = "0x400010E")]
			None,
			// Token: 0x0400029B RID: 667
			[global::Cpp2ILInjected.Token(Token = "0x400010F")]
			Integer,
			// Token: 0x0400029C RID: 668
			[global::Cpp2ILInjected.Token(Token = "0x4000110")]
			Decimal,
			// Token: 0x0400029D RID: 669
			[global::Cpp2ILInjected.Token(Token = "0x4000111")]
			Alphanumeric,
			// Token: 0x0400029E RID: 670
			[global::Cpp2ILInjected.Token(Token = "0x4000112")]
			Name,
			// Token: 0x0400029F RID: 671
			[global::Cpp2ILInjected.Token(Token = "0x4000113")]
			EmailAddress
		}

		// Token: 0x02000096 RID: 150
		[global::Cpp2ILInjected.Token(Token = "0x2000030")]
		public enum LineType
		{
			// Token: 0x040002A1 RID: 673
			[global::Cpp2ILInjected.Token(Token = "0x4000115")]
			SingleLine,
			// Token: 0x040002A2 RID: 674
			[global::Cpp2ILInjected.Token(Token = "0x4000116")]
			MultiLineSubmit,
			// Token: 0x040002A3 RID: 675
			[global::Cpp2ILInjected.Token(Token = "0x4000117")]
			MultiLineNewline
		}

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000692 RID: 1682
		[global::Cpp2ILInjected.Token(Token = "0x2000031")]
		public delegate char OnValidateInput(string text, int charIndex, char addedChar);

		// Token: 0x02000098 RID: 152
		[global::Cpp2ILInjected.Token(Token = "0x2000032")]
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
			// Token: 0x06000695 RID: 1685 RVA: 0x0000334F File Offset: 0x0000154F
			[global::Cpp2ILInjected.Token(Token = "0x600022F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD2E8", Offset = "0x1FBD2E8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public SubmitEvent()
			{
				throw null;
			}
		}

		// Token: 0x02000099 RID: 153
		[global::Cpp2ILInjected.Token(Token = "0x2000033")]
		[Serializable]
		public class EndEditEvent : UnityEvent<string>
		{
			// Token: 0x06000696 RID: 1686 RVA: 0x00003352 File Offset: 0x00001552
			[global::Cpp2ILInjected.Token(Token = "0x6000230")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD330", Offset = "0x1FBD330", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public EndEditEvent()
			{
				throw null;
			}
		}

		// Token: 0x0200009A RID: 154
		[global::Cpp2ILInjected.Token(Token = "0x2000034")]
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
			// Token: 0x06000697 RID: 1687 RVA: 0x00003355 File Offset: 0x00001555
			[global::Cpp2ILInjected.Token(Token = "0x6000231")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBD378", Offset = "0x1FBD378", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public OnChangeEvent()
			{
				throw null;
			}
		}

		// Token: 0x0200009B RID: 155
		[global::Cpp2ILInjected.Token(Token = "0x2000035")]
		protected enum EditState
		{
			// Token: 0x040002A5 RID: 677
			[global::Cpp2ILInjected.Token(Token = "0x4000119")]
			Continue,
			// Token: 0x040002A6 RID: 678
			[global::Cpp2ILInjected.Token(Token = "0x400011A")]
			Finish
		}

		// Token: 0x0200009C RID: 156
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000036")]
		private sealed class <CaretBlink>d__172 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000698 RID: 1688 RVA: 0x00003358 File Offset: 0x00001558
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000232")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBF3F4", Offset = "0x1FBF3F4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <CaretBlink>d__172(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000699 RID: 1689 RVA: 0x0000335B File Offset: 0x0000155B
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000233")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC63AC", Offset = "0x1FC63AC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x0600069A RID: 1690 RVA: 0x0000335E File Offset: 0x0000155E
			[global::Cpp2ILInjected.Token(Token = "0x6000234")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC63B0", Offset = "0x1FC63B0", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "get_hasSelection", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MarkGeometryAsDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170001C5 RID: 453
			// (get) Token: 0x0600069B RID: 1691 RVA: 0x00003361 File Offset: 0x00001561
			[global::Cpp2ILInjected.Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000235")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FC6498", Offset = "0x1FC6498", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600069C RID: 1692 RVA: 0x00003364 File Offset: 0x00001564
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000236")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC64A0", Offset = "0x1FC64A0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x0600069D RID: 1693 RVA: 0x00003367 File Offset: 0x00001567
			[global::Cpp2ILInjected.Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000237")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FC64D8", Offset = "0x1FC64D8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040002A7 RID: 679
			[global::Cpp2ILInjected.Token(Token = "0x400011B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040002A8 RID: 680
			[global::Cpp2ILInjected.Token(Token = "0x400011C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040002A9 RID: 681
			[global::Cpp2ILInjected.Token(Token = "0x400011D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public InputField <>4__this;
		}

		// Token: 0x0200009D RID: 157
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000037")]
		private sealed class <MouseDragOutsideRect>d__194 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600069E RID: 1694 RVA: 0x0000336A File Offset: 0x0000156A
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000238")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC18D8", Offset = "0x1FC18D8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <MouseDragOutsideRect>d__194(int <>1__state)
			{
				throw null;
			}

			// Token: 0x0600069F RID: 1695 RVA: 0x0000336D File Offset: 0x0000156D
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000239")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC64E0", Offset = "0x1FC64E0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x060006A0 RID: 1696 RVA: 0x00003370 File Offset: 0x00001570
			[global::Cpp2ILInjected.Token(Token = "0x600023A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC64E4", Offset = "0x1FC64E4", Length = "0x28C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new object[]
			{
				typeof(PointerEventData),
				typeof(ref Vector2)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(Vector2),
				typeof(Camera),
				typeof(ref Vector2)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveUp", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveLeft", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveDown", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "MoveRight", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitForSecondsRealtime), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00003373 File Offset: 0x00001573
			[global::Cpp2ILInjected.Token(Token = "0x17000096")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600023B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FC6770", Offset = "0x1FC6770", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060006A2 RID: 1698 RVA: 0x00003376 File Offset: 0x00001576
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600023C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC6778", Offset = "0x1FC6778", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00003379 File Offset: 0x00001579
			[global::Cpp2ILInjected.Token(Token = "0x17000097")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600023D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FC67B0", Offset = "0x1FC67B0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040002AA RID: 682
			[global::Cpp2ILInjected.Token(Token = "0x400011E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040002AB RID: 683
			[global::Cpp2ILInjected.Token(Token = "0x400011F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040002AC RID: 684
			[global::Cpp2ILInjected.Token(Token = "0x4000120")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public PointerEventData eventData;

			// Token: 0x040002AD RID: 685
			[global::Cpp2ILInjected.Token(Token = "0x4000121")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public InputField <>4__this;
		}
	}
}
