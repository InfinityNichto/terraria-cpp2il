using System;
using Cpp2ILInjected;

namespace UnityEngine.EventSystems
{
	[global::Cpp2ILInjected.Token(Token = "0x20000A3")]
	public interface IScrollHandler : IEventSystemHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005DA")]
		void OnScroll(PointerEventData eventData);
	}
}
