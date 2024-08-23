using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x0200012B RID: 299
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000152")]
	public interface INotificationReceiver
	{
		// Token: 0x06000617 RID: 1559
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600064F")]
		void OnNotify(Playable origin, INotification notification, object context);
	}
}
