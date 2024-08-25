using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	[global::Cpp2ILInjected.Token(Token = "0x20000BC")]
	public abstract class BaseRaycaster : UIBehaviour
	{
		[global::Cpp2ILInjected.Token(Token = "0x60006C9")]
		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

		[global::Cpp2ILInjected.Token(Token = "0x170001C5")]
		public abstract Camera eventCamera
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006CA")]
			get;
		}

		[Obsolete("Please use sortOrderPriority and renderOrderPriority", false)]
		[global::Cpp2ILInjected.Token(Token = "0x170001C6")]
		public virtual int priority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FED55C", Offset = "0x1FED55C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C7")]
		public virtual int sortOrderPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FED564", Offset = "0x1FED564", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRaycaster), Member = "get_sortOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C8")]
		public virtual int renderOrderPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FED56C", Offset = "0x1FED56C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRaycaster), Member = "get_renderOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C9")]
		public BaseRaycaster rootRaycaster
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE54A0", Offset = "0x1FE54A0", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventSystem), Member = "RaycastComparer", MemberParameters = new object[]
			{
				typeof(RaycastResult),
				typeof(RaycastResult)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED574", Offset = "0x1FED574", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED7D4", Offset = "0x1FED7D4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RaycasterManager), Member = "AddRaycaster", MemberParameters = new object[] { typeof(BaseRaycaster) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnEnable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED828", Offset = "0x1FED828", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RaycasterManager), Member = "RemoveRaycasters", MemberParameters = new object[] { typeof(BaseRaycaster) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDisable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED87C", Offset = "0x1FED87C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void OnCanvasHierarchyChanged()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED888", Offset = "0x1FED888", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void OnTransformParentChanged()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED894", Offset = "0x1FED894", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRaycaster), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected BaseRaycaster()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000317")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BaseRaycaster m_RootRaycaster;
	}
}
