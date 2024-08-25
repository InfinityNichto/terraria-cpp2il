using System;
using Cpp2ILInjected;

namespace UnityEngine.EventSystems
{
	[global::Cpp2ILInjected.Token(Token = "0x20000A9")]
	public interface ICancelHandler : IEventSystemHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005E0")]
		void OnCancel(BaseEventData eventData);
	}
}
