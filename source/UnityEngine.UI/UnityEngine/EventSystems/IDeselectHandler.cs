using System;
using Cpp2ILInjected;

namespace UnityEngine.EventSystems
{
	[global::Cpp2ILInjected.Token(Token = "0x20000A6")]
	public interface IDeselectHandler : IEventSystemHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005DD")]
		void OnDeselect(BaseEventData eventData);
	}
}
