using Cpp2IlInjected;
using Newtonsoft.Json.Linq;
using Terraria.IO;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200036E")]
public class WorldGenConfiguration : GameConfiguration
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003176")]
	private readonly JObject _biomeRoot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003177")]
	private readonly JObject _passRoot;

	[Cpp2IlInjected.Token(Token = "0x4003178")]
	private static string resource;

	[Cpp2IlInjected.Token(Token = "0x6002CAB")]
	[Cpp2IlInjected.Address(RVA = "0xA11528", Offset = "0xA11528", VA = "0xA11528")]
	public WorldGenConfiguration(JObject configurationRoot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CAC")]
	[Cpp2IlInjected.Address(RVA = "0x15F1CA4", Offset = "0x15F1CA4", VA = "0x15F1CA4")]
	public T CreateBiome<T>() where T : MicroBiome, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002CAD")]
	[Cpp2IlInjected.Address(RVA = "0x15F1D54", Offset = "0x15F1D54", VA = "0x15F1D54")]
	public T CreateBiome<T>(string name) where T : MicroBiome, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002CAE")]
	[Cpp2IlInjected.Address(RVA = "0xA1167C", Offset = "0xA1167C", VA = "0xA1167C")]
	public GameConfiguration GetPassConfiguration(string name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002CAF")]
	[Cpp2IlInjected.Address(RVA = "0xA117AC", Offset = "0xA117AC", VA = "0xA117AC")]
	private static void LoadOnMainThread(object nullObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CB0")]
	[Cpp2IlInjected.Address(RVA = "0xA11830", Offset = "0xA11830", VA = "0xA11830")]
	public static WorldGenConfiguration FromEmbeddedPath(string path)
	{
		return null;
	}
}
