using System;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

// Token: 0x02000210 RID: 528
[global::Cpp2ILInjected.Token(Token = "0x20002B6")]
public class MPSessionMetaData
{
	// Token: 0x06000EE6 RID: 3814 RVA: 0x000247AF File Offset: 0x000229AF
	[global::Cpp2ILInjected.Token(Token = "0x6001016")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B8C0", Offset = "0xA3B8C0", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "StartBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public MPSessionMetaData()
	{
		throw null;
	}

	// Token: 0x04001867 RID: 6247
	[global::Cpp2ILInjected.Token(Token = "0x4001D93")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string WorldName;

	// Token: 0x04001868 RID: 6248
	[global::Cpp2ILInjected.Token(Token = "0x4001D94")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public IPAddress ServerAddress;

	// Token: 0x04001869 RID: 6249
	[global::Cpp2ILInjected.Token(Token = "0x4001D95")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int ServerPort;

	// Token: 0x0400186A RID: 6250
	[global::Cpp2ILInjected.Token(Token = "0x4001D96")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public ushort WorldXSize;

	// Token: 0x0400186B RID: 6251
	[global::Cpp2ILInjected.Token(Token = "0x4001D97")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int NumberOfPlayers;

	// Token: 0x0400186C RID: 6252
	[global::Cpp2ILInjected.Token(Token = "0x4001D98")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int MaxPlayers;

	// Token: 0x0400186D RID: 6253
	[global::Cpp2ILInjected.Token(Token = "0x4001D99")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public short GameMode;

	// Token: 0x0400186E RID: 6254
	[global::Cpp2ILInjected.Token(Token = "0x4001D9A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
	public bool Corruption;

	// Token: 0x0400186F RID: 6255
	[global::Cpp2ILInjected.Token(Token = "0x4001D9B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x33")]
	public bool HardMode;

	// Token: 0x04001870 RID: 6256
	[global::Cpp2ILInjected.Token(Token = "0x4001D9C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public string HostName;

	// Token: 0x04001871 RID: 6257
	[global::Cpp2ILInjected.Token(Token = "0x4001D9D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public bool InviteOnly;
}
