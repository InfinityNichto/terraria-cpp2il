using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003CF")]
public class FishingInfo_OldMobile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40032B4")]
	private short currentQuest;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40032B5")]
	private bool questCompletedToday;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40032B6")]
	private List<string> playersCompleted;

	[Cpp2IlInjected.Token(Token = "0x6002FD1")]
	[Cpp2IlInjected.Address(RVA = "0xE3D9B4", Offset = "0xE3D9B4", VA = "0xE3D9B4")]
	public bool Load(BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FD2")]
	[Cpp2IlInjected.Address(RVA = "0xE3DABC", Offset = "0xE3DABC", VA = "0xE3DABC")]
	public FishingInfo_OldMobile()
	{
	}
}
