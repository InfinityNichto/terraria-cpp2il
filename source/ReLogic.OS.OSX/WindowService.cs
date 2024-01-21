using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace ReLogic.OS.OSX;

[Cpp2IlInjected.Token(Token = "0x200072D")]
internal class WindowService : IWindowService
{
	[Cpp2IlInjected.Token(Token = "0x60046EA")]
	[Cpp2IlInjected.Address(RVA = "0xF9265C", Offset = "0xF9265C", VA = "0xF9265C", Slot = "7")]
	public float GetScaling()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60046EB")]
	[Cpp2IlInjected.Address(RVA = "0xF92664", Offset = "0xF92664", VA = "0xF92664", Slot = "8")]
	public void SetQuickEditEnabled(bool enabled)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046EC")]
	[Cpp2IlInjected.Address(RVA = "0xF92668", Offset = "0xF92668", VA = "0xF92668", Slot = "4")]
	public void SetUnicodeTitle(GameWindow window, string title)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046ED")]
	[Cpp2IlInjected.Address(RVA = "0xF92678", Offset = "0xF92678", VA = "0xF92678", Slot = "5")]
	public void StartFlashingIcon(GameWindow window)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046EE")]
	[Cpp2IlInjected.Address(RVA = "0xF9267C", Offset = "0xF9267C", VA = "0xF9267C", Slot = "6")]
	public void StopFlashingIcon(GameWindow window)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046EF")]
	[Cpp2IlInjected.Address(RVA = "0xF92680", Offset = "0xF92680", VA = "0xF92680")]
	public WindowService()
	{
	}
}
