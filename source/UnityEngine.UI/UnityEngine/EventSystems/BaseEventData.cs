using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	[global::Cpp2ILInjected.Token(Token = "0x2000092")]
	public class BaseEventData : AbstractEventData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000589")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE391C", Offset = "0x1FE391C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BaseEventData(EventSystem eventSystem)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700016C")]
		public BaseInputModule currentInputModule
		{
			[global::Cpp2ILInjected.Token(Token = "0x600058A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE3968", Offset = "0x1FE3968", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700016D")]
		public GameObject selectedObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x600058B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE3974", Offset = "0x1FE3974", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600058C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE3980", Offset = "0x1FE3980", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "Navigate", MemberParameters = new object[]
			{
				typeof(AxisEventData),
				typeof(Selectable)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400028A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly EventSystem m_EventSystem;
	}
}
