using Cpp2IlInjected;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20001F3")]
public class GUIToggleSetting : GUISettingEntry
{
	[Cpp2IlInjected.Token(Token = "0x400170A")]
	private static Texture2D ToggleOff;

	[Cpp2IlInjected.Token(Token = "0x400170B")]
	private static Texture2D ToggleOn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400170C")]
	private float scale;

	[Cpp2IlInjected.Token(Token = "0x6000E58")]
	[Cpp2IlInjected.Address(RVA = "0xEC4E60", Offset = "0xEC4E60", VA = "0xEC4E60")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E59")]
	[Cpp2IlInjected.Address(RVA = "0xEC4F0C", Offset = "0xEC4F0C", VA = "0xEC4F0C")]
	public GUIToggleSetting(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E5A")]
	[Cpp2IlInjected.Address(RVA = "0xEC4F14", Offset = "0xEC4F14", VA = "0xEC4F14", Slot = "7")]
	protected virtual SettingsOverlayToggle_Layout GetLayout()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E5B")]
	[Cpp2IlInjected.Address(RVA = "0xEC4F70", Offset = "0xEC4F70", VA = "0xEC4F70", Slot = "8")]
	protected virtual SettingsOverlayToggle_Layout GetDisabledLayout()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E5C")]
	[Cpp2IlInjected.Address(RVA = "0xEC4FCC", Offset = "0xEC4FCC", VA = "0xEC4FCC", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E5D")]
	[Cpp2IlInjected.Address(RVA = "0xEC9A38", Offset = "0xEC9A38", VA = "0xEC9A38", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E5E")]
	[Cpp2IlInjected.Address(RVA = "0xEC9844", Offset = "0xEC9844", VA = "0xEC9844")]
	private string GetOptionOn()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E5F")]
	[Cpp2IlInjected.Address(RVA = "0xEC962C", Offset = "0xEC962C", VA = "0xEC962C")]
	private string GetOptionOff()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E60")]
	[Cpp2IlInjected.Address(RVA = "0xEC542C", Offset = "0xEC542C", VA = "0xEC542C")]
	private string GetOption()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E61")]
	[Cpp2IlInjected.Address(RVA = "0xEC890C", Offset = "0xEC890C", VA = "0xEC890C")]
	private bool GetSelected()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E62")]
	[Cpp2IlInjected.Address(RVA = "0xEC7B08", Offset = "0xEC7B08", VA = "0xEC7B08")]
	private void Toggle()
	{
	}
}
