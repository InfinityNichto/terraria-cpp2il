using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000152")]
	public interface INotificationReceiver
	{
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600064F")]
		void OnNotify(Playable origin, INotification notification, object context);
	}
}
