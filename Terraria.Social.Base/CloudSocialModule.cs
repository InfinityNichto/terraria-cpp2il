using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x2000391")]
public abstract class CloudSocialModule : ISocialModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031D4")]
	public bool EnabledByDefault;

	[Cpp2IlInjected.Token(Token = "0x6002DA0")]
	[Cpp2IlInjected.Address(RVA = "0x14DF964", Offset = "0x14DF964", VA = "0x14DF964", Slot = "6")]
	public virtual void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DA1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void Shutdown();

	[Cpp2IlInjected.Token(Token = "0x6002DA2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract IEnumerable<string> GetFiles();

	[Cpp2IlInjected.Token(Token = "0x6002DA3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool Write(string path, byte[] data, int length);

	[Cpp2IlInjected.Token(Token = "0x6002DA4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void Read(string path, byte[] buffer, int length);

	[Cpp2IlInjected.Token(Token = "0x6002DA5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract bool HasFile(string path);

	[Cpp2IlInjected.Token(Token = "0x6002DA6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract int GetFileSize(string path);

	[Cpp2IlInjected.Token(Token = "0x6002DA7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool Delete(string path);

	[Cpp2IlInjected.Token(Token = "0x6002DA8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract bool Forget(string path);

	[Cpp2IlInjected.Token(Token = "0x6002DA9")]
	[Cpp2IlInjected.Address(RVA = "0x14DFA7C", Offset = "0x14DFA7C", VA = "0x14DFA7C")]
	public byte[] Read(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002DAA")]
	[Cpp2IlInjected.Address(RVA = "0x14DFB28", Offset = "0x14DFB28", VA = "0x14DFB28")]
	public void Read(string path, byte[] buffer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DAB")]
	[Cpp2IlInjected.Address(RVA = "0x14DFB54", Offset = "0x14DFB54", VA = "0x14DFB54")]
	public bool Write(string path, byte[] data)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002DAC")]
	[Cpp2IlInjected.Address(RVA = "0x14DFB80", Offset = "0x14DFB80", VA = "0x14DFB80")]
	protected CloudSocialModule()
	{
	}
}
