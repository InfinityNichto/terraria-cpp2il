﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003A RID: 58
	[AddComponentMenu("UI/Toggle", 30)]
	[RequireComponent(typeof(RectTransform))]
	[global::Cpp2ILInjected.Token(Token = "0x2000073")]
	public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00002D31 File Offset: 0x00000F31
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00002D34 File Offset: 0x00000F34
		[global::Cpp2ILInjected.Token(Token = "0x1700014E")]
		public ToggleGroup group
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDDD5C", Offset = "0x1FDDD5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDDD64", Offset = "0x1FDDD64", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new object[]
			{
				typeof(ToggleGroup),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002D37 File Offset: 0x00000F37
		[global::Cpp2ILInjected.Token(Token = "0x60004CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDDF6C", Offset = "0x1FDDF6C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle.ToggleEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected Toggle()
		{
			throw null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002D3A File Offset: 0x00000F3A
		[global::Cpp2ILInjected.Token(Token = "0x60004CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE040", Offset = "0x1FDE040", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Rebuild(CanvasUpdate executing)
		{
			throw null;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002D3D File Offset: 0x00000F3D
		[global::Cpp2ILInjected.Token(Token = "0x60004D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE044", Offset = "0x1FDE044", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void LayoutComplete()
		{
			throw null;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002D40 File Offset: 0x00000F40
		[global::Cpp2ILInjected.Token(Token = "0x60004D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE048", Offset = "0x1FDE048", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void GraphicUpdateComplete()
		{
			throw null;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002D43 File Offset: 0x00000F43
		[global::Cpp2ILInjected.Token(Token = "0x60004D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE04C", Offset = "0x1FDE04C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDestroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002D46 File Offset: 0x00000F46
		[global::Cpp2ILInjected.Token(Token = "0x60004D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE484", Offset = "0x1FDE484", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new object[]
		{
			typeof(ToggleGroup),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002D49 File Offset: 0x00000F49
		[global::Cpp2ILInjected.Token(Token = "0x60004D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE4B0", Offset = "0x1FDE4B0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new object[]
		{
			typeof(ToggleGroup),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnDisable", ReturnType = typeof(void))]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002D4C File Offset: 0x00000F4C
		[global::Cpp2ILInjected.Token(Token = "0x60004D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE4D0", Offset = "0x1FDE4D0", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "GetColor", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "OnSetProperty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void OnDidApplyAnimationProperties()
		{
			throw null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002D4F File Offset: 0x00000F4F
		[global::Cpp2ILInjected.Token(Token = "0x60004D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDDD84", Offset = "0x1FDDD84", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "set_group", MemberParameters = new object[] { typeof(ToggleGroup) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "UnregisterToggle", MemberParameters = new object[] { typeof(Toggle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "RegisterToggle", MemberParameters = new object[] { typeof(Toggle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new object[]
		{
			typeof(Toggle),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue)
		{
			throw null;
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00002D52 File Offset: 0x00000F52
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00002D55 File Offset: 0x00000F55
		[global::Cpp2ILInjected.Token(Token = "0x1700014F")]
		public bool isOn
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDE99C", Offset = "0x1FDE99C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDE9A4", Offset = "0x1FDE9A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateToggle", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "AddItem", MemberParameters = new object[]
			{
				typeof(Dropdown.OptionData),
				typeof(bool),
				typeof(Dropdown.DropdownItem),
				typeof(List<Dropdown.DropdownItem>)
			}, ReturnType = typeof(Dropdown.DropdownItem))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "OnSelectItem", MemberParameters = new object[] { typeof(Toggle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002D58 File Offset: 0x00000F58
		[global::Cpp2ILInjected.Token(Token = "0x60004D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE9B0", Offset = "0x1FDE9B0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void SetIsOnWithoutNotify(bool value)
		{
			throw null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002D5B File Offset: 0x00000F5B
		[global::Cpp2ILInjected.Token(Token = "0x60004DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE5E8", Offset = "0x1FDE5E8", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "SetIsOnWithoutNotify", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "InternalToggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new object[]
		{
			typeof(Toggle),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "SetAllTogglesOff", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new object[]
		{
			typeof(Toggle),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "AnyTogglesOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<>), Member = "Invoke", MemberParameters = new object[] { "T0" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Set(bool value, bool sendCallback = true)
		{
			throw null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002D5E File Offset: 0x00000F5E
		[global::Cpp2ILInjected.Token(Token = "0x60004DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDDEB0", Offset = "0x1FDDEB0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "set_group", MemberParameters = new object[] { typeof(ToggleGroup) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void PlayEffect(bool instant)
		{
			throw null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002D61 File Offset: 0x00000F61
		[global::Cpp2ILInjected.Token(Token = "0x60004DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEAF4", Offset = "0x1FDEAF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "PlayEffect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002D64 File Offset: 0x00000F64
		[global::Cpp2ILInjected.Token(Token = "0x60004DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEAFC", Offset = "0x1FDEAFC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "OnPointerClick", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "OnSubmit", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void InternalToggle()
		{
			throw null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002D67 File Offset: 0x00000F67
		[global::Cpp2ILInjected.Token(Token = "0x60004DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEB50", Offset = "0x1FDEB50", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "InternalToggle", ReturnType = typeof(void))]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002D6A File Offset: 0x00000F6A
		[global::Cpp2ILInjected.Token(Token = "0x60004DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEB60", Offset = "0x1FDEB60", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "InternalToggle", ReturnType = typeof(void))]
		public virtual void OnSubmit(BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002D6D File Offset: 0x00000F6D
		[global::Cpp2ILInjected.Token(Token = "0x60004E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEB64", Offset = "0x1FDEB64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			throw null;
		}

		// Token: 0x04000177 RID: 375
		[global::Cpp2ILInjected.Token(Token = "0x400024A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public Toggle.ToggleTransition toggleTransition;

		// Token: 0x04000178 RID: 376
		[global::Cpp2ILInjected.Token(Token = "0x400024B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public Graphic graphic;

		// Token: 0x04000179 RID: 377
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400024C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private ToggleGroup m_Group;

		// Token: 0x0400017A RID: 378
		[global::Cpp2ILInjected.Token(Token = "0x400024D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public Toggle.ToggleEvent onValueChanged;

		// Token: 0x0400017B RID: 379
		[Tooltip("Is the toggle currently on or off?")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400024E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private bool m_IsOn;

		// Token: 0x020000B8 RID: 184
		[global::Cpp2ILInjected.Token(Token = "0x2000074")]
		public enum ToggleTransition
		{
			// Token: 0x0400031D RID: 797
			[global::Cpp2ILInjected.Token(Token = "0x4000250")]
			None,
			// Token: 0x0400031E RID: 798
			[global::Cpp2ILInjected.Token(Token = "0x4000251")]
			Fade
		}

		// Token: 0x020000B9 RID: 185
		[global::Cpp2ILInjected.Token(Token = "0x2000075")]
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
			// Token: 0x060006C8 RID: 1736 RVA: 0x000033E8 File Offset: 0x000015E8
			[global::Cpp2ILInjected.Token(Token = "0x60004E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDDFF8", Offset = "0x1FDDFF8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public ToggleEvent()
			{
				throw null;
			}
		}
	}
}