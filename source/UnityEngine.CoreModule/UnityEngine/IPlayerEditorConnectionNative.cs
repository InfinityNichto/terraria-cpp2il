using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x2000076")]
	internal interface IPlayerEditorConnectionNative
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
		void Initialize();

		[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
		void DisconnectAll();

		[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
		void SendMessage(Guid messageId, byte[] data, int playerId);

		[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
		bool TrySendMessage(Guid messageId, byte[] data, int playerId);

		[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
		void Poll();

		[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
		void RegisterInternal(Guid messageId);

		[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
		void UnregisterInternal(Guid messageId);

		[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
		bool IsConnected();
	}
}
