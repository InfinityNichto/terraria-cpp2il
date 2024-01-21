using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003C9")]
public class GameConfiguration
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003292")]
	private readonly JObject _root;

	[Cpp2IlInjected.Token(Token = "0x6002F87")]
	[Cpp2IlInjected.Address(RVA = "0xE3DB40", Offset = "0xE3DB40", VA = "0xE3DB40")]
	public GameConfiguration(JObject configurationRoot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F88")]
	[Cpp2IlInjected.Address(RVA = "0x15F03A4", Offset = "0x15F03A4", VA = "0x15F03A4")]
	public T Get<T>(string entry)
	{
		return (T)null;
	}
}
