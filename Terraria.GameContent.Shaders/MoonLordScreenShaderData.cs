using Cpp2IlInjected;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders;

[Cpp2IlInjected.Token(Token = "0x200058B")]
public class MoonLordScreenShaderData : ScreenShaderData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4006B0E")]
	private int _moonLordIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4006B0F")]
	private bool _aimAtPlayer;

	[Cpp2IlInjected.Token(Token = "0x6003BD8")]
	[Cpp2IlInjected.Address(RVA = "0x11A6258", Offset = "0x11A6258", VA = "0x11A6258")]
	public MoonLordScreenShaderData(string passName, bool aimAtPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BD9")]
	[Cpp2IlInjected.Address(RVA = "0x11A6284", Offset = "0x11A6284", VA = "0x11A6284")]
	private void UpdateMoonLordIndex()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BDA")]
	[Cpp2IlInjected.Address(RVA = "0x11A6434", Offset = "0x11A6434", VA = "0x11A6434", Slot = "5")]
	public override void Apply()
	{
	}
}
