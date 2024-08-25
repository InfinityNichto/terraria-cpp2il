using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	[AddComponentMenu("Event/Event Trigger")]
	[global::Cpp2ILInjected.Token(Token = "0x20000AB")]
	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
	{
		[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x17000198")]
		public List<EventTrigger.Entry> delegates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000602")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE5FDC", Offset = "0x1FE5FDC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000603")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE6058", Offset = "0x1FE6058", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000604")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6060", Offset = "0x1FE6060", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected EventTrigger()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000199")]
		public List<EventTrigger.Entry> triggers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000605")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE5FE0", Offset = "0x1FE5FE0", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
			{
				typeof(EventTriggerType),
				typeof(BaseEventData)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000606")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE6068", Offset = "0x1FE6068", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000607")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6070", Offset = "0x1FE6070", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnPointerEnter", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnPointerExit", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnDrop", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnPointerDown", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnPointerUp", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnPointerClick", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnSelect", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnDeselect", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnScroll", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnMove", MemberParameters = new object[] { typeof(AxisEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnUpdateSelected", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnInitializePotentialDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnBeginDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnEndDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnSubmit", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger), Member = "OnCancel", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "get_triggers", ReturnType = typeof(List<EventTrigger.Entry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = "Invoke", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Execute(EventTriggerType id, BaseEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000608")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6148", Offset = "0x1FE6148", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000609")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6154", Offset = "0x1FE6154", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600060A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6160", Offset = "0x1FE6160", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnDrag(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600060B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE616C", Offset = "0x1FE616C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnDrop(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600060C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6178", Offset = "0x1FE6178", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600060D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6184", Offset = "0x1FE6184", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600060E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6190", Offset = "0x1FE6190", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600060F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE619C", Offset = "0x1FE619C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnSelect(BaseEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000610")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE61A8", Offset = "0x1FE61A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnDeselect(BaseEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000611")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE61B4", Offset = "0x1FE61B4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnScroll(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000612")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE61C0", Offset = "0x1FE61C0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnMove(AxisEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000613")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE61CC", Offset = "0x1FE61CC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000614")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE61D8", Offset = "0x1FE61D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000615")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE61E4", Offset = "0x1FE61E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000616")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE61F0", Offset = "0x1FE61F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000617")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE61FC", Offset = "0x1FE61FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnSubmit(BaseEventData eventData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000618")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE6208", Offset = "0x1FE6208", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger), Member = "Execute", MemberParameters = new object[]
		{
			typeof(EventTriggerType),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		public virtual void OnCancel(BaseEventData eventData)
		{
			throw null;
		}

		[SerializeField]
		[FormerlySerializedAs("delegates")]
		[global::Cpp2ILInjected.Token(Token = "0x40002C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<EventTrigger.Entry> m_Delegates;

		[global::Cpp2ILInjected.Token(Token = "0x20000AC")]
		[Serializable]
		public class TriggerEvent : UnityEvent<BaseEventData>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000619")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE6214", Offset = "0x1FE6214", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventTrigger.Entry), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public TriggerEvent()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20000AD")]
		[Serializable]
		public class Entry
		{
			[global::Cpp2ILInjected.Token(Token = "0x600061A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE625C", Offset = "0x1FE625C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventTrigger.TriggerEvent), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Entry()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40002C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public EventTriggerType eventID;

			[global::Cpp2ILInjected.Token(Token = "0x40002C3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public EventTrigger.TriggerEvent callback;
		}
	}
}
