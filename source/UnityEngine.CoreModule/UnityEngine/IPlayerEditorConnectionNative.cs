using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	// Token: 0x02000070 RID: 112
	[global::Cpp2ILInjected.Token(Token = "0x2000076")]
	internal interface IPlayerEditorConnectionNative
	{
		// Token: 0x060001CF RID: 463
		[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
		void Initialize();

		// Token: 0x060001D0 RID: 464
		[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
		void DisconnectAll();

		// Token: 0x060001D1 RID: 465
		[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
		void SendMessage(Guid messageId, byte[] data, int playerId);

		// Token: 0x060001D2 RID: 466
		[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
		bool TrySendMessage(Guid messageId, byte[] data, int playerId);

		// Token: 0x060001D3 RID: 467
		[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
		void Poll();

		// Token: 0x060001D4 RID: 468
		[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
		void RegisterInternal(Guid messageId);

		// Token: 0x060001D5 RID: 469
		[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
		void UnregisterInternal(Guid messageId);

		// Token: 0x060001D6 RID: 470
		[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
		bool IsConnected();
	}
}
