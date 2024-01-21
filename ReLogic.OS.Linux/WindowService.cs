using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace ReLogic.OS.Linux;

[Cpp2IlInjected.Token(Token = "0x2000730")]
internal class WindowService : IWindowService
{
	[Cpp2IlInjected.Token(Token = "0x60046F6")]
	[Cpp2IlInjected.Address(RVA = "0xF92090", Offset = "0xF92090", VA = "0xF92090", Slot = "4")]
	public void SetUnicodeTitle(GameWindow window, string title)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046F7")]
	[Cpp2IlInjected.Address(RVA = "0xF920A0", Offset = "0xF920A0", VA = "0xF920A0", Slot = "5")]
	public void StartFlashingIcon(GameWindow window)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046F8")]
	[Cpp2IlInjected.Address(RVA = "0xF920A4", Offset = "0xF920A4", VA = "0xF920A4", Slot = "6")]
	public void StopFlashingIcon(GameWindow window)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046F9")]
	[Cpp2IlInjected.Address(RVA = "0xF920A8", Offset = "0xF920A8", VA = "0xF920A8", Slot = "7")]
	public float GetScaling()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60046FA")]
	[Cpp2IlInjected.Address(RVA = "0xF920B0", Offset = "0xF920B0", VA = "0xF920B0", Slot = "8")]
	public void SetQuickEditEnabled(bool enabled)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046FB")]
	[Cpp2IlInjected.Address(RVA = "0xF920B4", Offset = "0xF920B4", VA = "0xF920B4")]
	public WindowService()
	{
	}
}
