using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x2000394")]
public abstract class OverlaySocialModule : ISocialModule
{
	[Cpp2IlInjected.Token(Token = "0x6002DC4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6002DC5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void Shutdown();

	[Cpp2IlInjected.Token(Token = "0x6002DC6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool IsGamepadTextInputActive();

	[Cpp2IlInjected.Token(Token = "0x6002DC7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool ShowGamepadTextInput(string description, uint maxLength, bool multiLine = false, string existingText = "", bool password = false);

	[Cpp2IlInjected.Token(Token = "0x6002DC8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract string GetGamepadText();

	[Cpp2IlInjected.Token(Token = "0x6002DC9")]
	[Cpp2IlInjected.Address(RVA = "0x14DFCA0", Offset = "0x14DFCA0", VA = "0x14DFCA0")]
	protected OverlaySocialModule()
	{
	}
}
