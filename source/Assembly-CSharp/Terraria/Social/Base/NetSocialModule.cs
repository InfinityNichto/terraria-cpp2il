using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Net;
using Terraria.Net.Sockets;

namespace Terraria.Social.Base
{
	// Token: 0x02000390 RID: 912
	[global::Cpp2ILInjected.Token(Token = "0x200052B")]
	public abstract class NetSocialModule : ISocialModule
	{
		// Token: 0x06002D7C RID: 11644
		[global::Cpp2ILInjected.Token(Token = "0x60031D5")]
		public abstract void Initialize();

		// Token: 0x06002D7D RID: 11645
		[global::Cpp2ILInjected.Token(Token = "0x60031D6")]
		public abstract void Shutdown();

		// Token: 0x06002D7E RID: 11646
		[global::Cpp2ILInjected.Token(Token = "0x60031D7")]
		public abstract void Close(RemoteAddress address);

		// Token: 0x06002D7F RID: 11647
		[global::Cpp2ILInjected.Token(Token = "0x60031D8")]
		public abstract bool IsConnected(RemoteAddress address);

		// Token: 0x06002D80 RID: 11648
		[global::Cpp2ILInjected.Token(Token = "0x60031D9")]
		public abstract void Connect(RemoteAddress address);

		// Token: 0x06002D81 RID: 11649
		[global::Cpp2ILInjected.Token(Token = "0x60031DA")]
		public abstract bool Send(RemoteAddress address, byte[] data, int length);

		// Token: 0x06002D82 RID: 11650
		[global::Cpp2ILInjected.Token(Token = "0x60031DB")]
		public abstract int Receive(RemoteAddress address, byte[] data, int offset, int length);

		// Token: 0x06002D83 RID: 11651
		[global::Cpp2ILInjected.Token(Token = "0x60031DC")]
		public abstract bool IsDataAvailable(RemoteAddress address);

		// Token: 0x06002D84 RID: 11652
		[global::Cpp2ILInjected.Token(Token = "0x60031DD")]
		public abstract void LaunchLocalServer(Process process, ServerMode mode);

		// Token: 0x06002D85 RID: 11653
		[global::Cpp2ILInjected.Token(Token = "0x60031DE")]
		public abstract bool CanInvite();

		// Token: 0x06002D86 RID: 11654
		[global::Cpp2ILInjected.Token(Token = "0x60031DF")]
		public abstract void OpenInviteInterface();

		// Token: 0x06002D87 RID: 11655
		[global::Cpp2ILInjected.Token(Token = "0x60031E0")]
		public abstract void CancelJoin();

		// Token: 0x06002D88 RID: 11656
		[global::Cpp2ILInjected.Token(Token = "0x60031E1")]
		public abstract bool StartListening(SocketConnectionAccepted callback);

		// Token: 0x06002D89 RID: 11657
		[global::Cpp2ILInjected.Token(Token = "0x60031E2")]
		public abstract void StopListening();

		// Token: 0x06002D8A RID: 11658
		[global::Cpp2ILInjected.Token(Token = "0x60031E3")]
		public abstract ulong GetLobbyId();

		// Token: 0x06002D8B RID: 11659 RVA: 0x0002A23F File Offset: 0x0002843F
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
