using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Net;
using Terraria.Net.Sockets;

namespace Terraria.Social.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x200052B")]
	public abstract class NetSocialModule : ISocialModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031D5")]
		public abstract void Initialize();

		[global::Cpp2ILInjected.Token(Token = "0x60031D6")]
		public abstract void Shutdown();

		[global::Cpp2ILInjected.Token(Token = "0x60031D7")]
		public abstract void Close(RemoteAddress address);

		[global::Cpp2ILInjected.Token(Token = "0x60031D8")]
		public abstract bool IsConnected(RemoteAddress address);

		[global::Cpp2ILInjected.Token(Token = "0x60031D9")]
		public abstract void Connect(RemoteAddress address);

		[global::Cpp2ILInjected.Token(Token = "0x60031DA")]
		public abstract bool Send(RemoteAddress address, byte[] data, int length);

		[global::Cpp2ILInjected.Token(Token = "0x60031DB")]
		public abstract int Receive(RemoteAddress address, byte[] data, int offset, int length);

		[global::Cpp2ILInjected.Token(Token = "0x60031DC")]
		public abstract bool IsDataAvailable(RemoteAddress address);

		[global::Cpp2ILInjected.Token(Token = "0x60031DD")]
		public abstract void LaunchLocalServer(Process process, ServerMode mode);

		[global::Cpp2ILInjected.Token(Token = "0x60031DE")]
		public abstract bool CanInvite();

		[global::Cpp2ILInjected.Token(Token = "0x60031DF")]
		public abstract void OpenInviteInterface();

		[global::Cpp2ILInjected.Token(Token = "0x60031E0")]
		public abstract void CancelJoin();

		[global::Cpp2ILInjected.Token(Token = "0x60031E1")]
		public abstract bool StartListening(SocketConnectionAccepted callback);

		[global::Cpp2ILInjected.Token(Token = "0x60031E2")]
		public abstract void StopListening();

		[global::Cpp2ILInjected.Token(Token = "0x60031E3")]
		public abstract ulong GetLobbyId();

		[global::Cpp2ILInjected.Token(Token = "0x60031E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ADD0", Offset = "0x132ADD0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected NetSocialModule()
		{
			throw null;
		}
	}
}
