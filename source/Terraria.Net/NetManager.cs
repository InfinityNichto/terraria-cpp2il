using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;

namespace Terraria.Net;

[Cpp2IlInjected.Token(Token = "0x2000499")]
public class NetManager
{
	[Cpp2IlInjected.Token(Token = "0x2000933")]
	private class PacketTypeStorage<T> where T : NetModule
	{
		[Cpp2IlInjected.Token(Token = "0x4008AC9")]
		public static ushort Id;

		[Cpp2IlInjected.Token(Token = "0x4008ACA")]
		public static T Module;

		[Cpp2IlInjected.Token(Token = "0x6004CE2")]
		[Cpp2IlInjected.Address(RVA = "0x164555C", Offset = "0x164555C", VA = "0x164555C")]
		public PacketTypeStorage()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000934")]
	public delegate bool BroadcastCondition(int clientIndex);

	[Cpp2IlInjected.Token(Token = "0x400653B")]
	public static NetManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400653C")]
	private Dictionary<ushort, NetModule> _modules;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400653D")]
	private ushort _moduleCount;

	[Cpp2IlInjected.Token(Token = "0x400653E")]
	public static bool LoopbackClientSends;

	[Cpp2IlInjected.Token(Token = "0x600337B")]
	[Cpp2IlInjected.Address(RVA = "0x142B1CC", Offset = "0x142B1CC", VA = "0x142B1CC")]
	private NetManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600337C")]
	[Cpp2IlInjected.Address(RVA = "0x15A6CF0", Offset = "0x15A6CF0", VA = "0x15A6CF0")]
	public void Register<T>() where T : NetModule, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600337D")]
	[Cpp2IlInjected.Address(RVA = "0x206EFBC", Offset = "0x206EFBC", VA = "0x206EFBC")]
	public NetModule GetModule<T>() where T : NetModule
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600337E")]
	[Cpp2IlInjected.Address(RVA = "0x1606A00", Offset = "0x1606A00", VA = "0x1606A00")]
	public ushort GetId<T>() where T : NetModule
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600337F")]
	[Cpp2IlInjected.Address(RVA = "0x142B250", Offset = "0x142B250", VA = "0x142B250")]
	public void Read(BinaryReader reader, int userId, int readLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003380")]
	[Cpp2IlInjected.Address(RVA = "0x142B3C8", Offset = "0x142B3C8", VA = "0x142B3C8")]
	public void Broadcast(NetPacket packet, int ignoreClient = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003381")]
	[Cpp2IlInjected.Address(RVA = "0x142B810", Offset = "0x142B810", VA = "0x142B810")]
	public void Broadcast(NetPacket packet, BroadcastCondition conditionToBroadcast, int ignoreClient = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003382")]
	[Cpp2IlInjected.Address(RVA = "0x142BC00", Offset = "0x142BC00", VA = "0x142BC00")]
	public void SendToSelf(NetPacket packet)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003383")]
	[Cpp2IlInjected.Address(RVA = "0x142BE4C", Offset = "0x142BE4C", VA = "0x142BE4C")]
	public void BroadcastOrLoopback(NetPacket packet)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003384")]
	[Cpp2IlInjected.Address(RVA = "0x142BF44", Offset = "0x142BF44", VA = "0x142BF44")]
	public void SendToServerOrLoopback(NetPacket packet)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003385")]
	[Cpp2IlInjected.Address(RVA = "0x142C05C", Offset = "0x142C05C", VA = "0x142C05C")]
	public void SendToServerAndSelf(NetPacket packet)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003386")]
	[Cpp2IlInjected.Address(RVA = "0x142C03C", Offset = "0x142C03C", VA = "0x142C03C")]
	public void SendToServer(NetPacket packet)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003387")]
	[Cpp2IlInjected.Address(RVA = "0x142B4E4", Offset = "0x142B4E4", VA = "0x142B4E4")]
	public void SendToClient(NetPacket packet, int clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003388")]
	[Cpp2IlInjected.Address(RVA = "0x142BDC8", Offset = "0x142BDC8", VA = "0x142BDC8")]
	public static void SendCallback(object state)
	{
	}
}
