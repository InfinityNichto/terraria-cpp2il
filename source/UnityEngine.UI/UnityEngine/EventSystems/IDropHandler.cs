using System;
using Cpp2ILInjected;

namespace UnityEngine.EventSystems
{
	[global::Cpp2ILInjected.Token(Token = "0x20000A2")]
	public interface IDropHandler : IEventSystemHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005D9")]
		void OnDrop(PointerEventData eventData);
	}
}
