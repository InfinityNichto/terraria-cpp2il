using System.Diagnostics;
using Cpp2IlInjected;
using Terraria.Net;
using Terraria.Net.Sockets;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x2000393")]
public abstract class NetSocialModule : ISocialModule
{
	[Cpp2IlInjected.Token(Token = "0x6002DB4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6002DB5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void Shutdown();

	[Cpp2IlInjected.Token(Token = "0x6002DB6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void Close(RemoteAddress address);

	[Cpp2IlInjected.Token(Token = "0x6002DB7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool IsConnected(RemoteAddress address);

	[Cpp2IlInjected.Token(Token = "0x6002DB8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void Connect(RemoteAddress address);

	[Cpp2IlInjected.Token(Token = "0x6002DB9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract bool Send(RemoteAddress address, byte[] data, int length);

	[Cpp2IlInjected.Token(Token = "0x6002DBA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract int Receive(RemoteAddress address, byte[] data, int offset, int length);

	[Cpp2IlInjected.Token(Token = "0x6002DBB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool IsDataAvailable(RemoteAddress address);

	[Cpp2IlInjected.Token(Token = "0x6002DBC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract void LaunchLocalServer(Process process, ServerMode mode);

	[Cpp2IlInjected.Token(Token = "0x6002DBD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract bool CanInvite();

	[Cpp2IlInjected.Token(Token = "0x6002DBE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract void OpenInviteInterface();

	[Cpp2IlInjected.Token(Token = "0x6002DBF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract void CancelJoin();

	[Cpp2IlInjected.Token(Token = "0x6002DC0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract bool StartListening(SocketConnectionAccepted callback);

	[Cpp2IlInjected.Token(Token = "0x6002DC1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void StopListening();

	[Cpp2IlInjected.Token(Token = "0x6002DC2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract ulong GetLobbyId();

	[Cpp2IlInjected.Token(Token = "0x6002DC3")]
	[Cpp2IlInjected.Address(RVA = "0x14DFC98", Offset = "0x14DFC98", VA = "0x14DFC98")]
	protected NetSocialModule()
	{
	}
}
