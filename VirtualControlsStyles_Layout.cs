using Cpp2IlInjected;
using Newtonsoft.Json;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20001BD")]
[JsonObject]
public class VirtualControlsStyles_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001389")]
	public static VirtualControlsStyles_Layout Instance;

	[Cpp2IlInjected.Token(Token = "0x400138A")]
	public static string LastUsedProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400138B")]
	public VirtualControlsButtonConfiguration_Layout[] ButtonTypes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400138C")]
	public VirtualControlsAxisConfiguration_Layout[] AxisTypes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400138D")]
	[JsonProperty]
	public VirtualControlsHardwareConfiguration_Layout[] HardwareStyles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400138E")]
	[JsonProperty]
	public VirtualControlsProfile_Layout[] Profiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400138F")]
	private VirtualControlsProfile_Layout _activeProfile;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public VirtualControlsProfile_Layout ActiveProfile
	{
		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0xE8DDF4", Offset = "0xE8DDF4", VA = "0xE8DDF4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3F")]
	[Cpp2IlInjected.Address(RVA = "0xE8DD98", Offset = "0xE8DD98", VA = "0xE8DD98")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C41")]
	[Cpp2IlInjected.Address(RVA = "0xE8DF1C", Offset = "0xE8DF1C", VA = "0xE8DF1C")]
	public void SetActiveProfile(VirtualControlsProfile_Layout profile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C42")]
	[Cpp2IlInjected.Address(RVA = "0xE8DBD8", Offset = "0xE8DBD8", VA = "0xE8DBD8")]
	public VirtualControlsButtonConfiguration_Layout GetButtonConfiguration(string Id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C43")]
	[Cpp2IlInjected.Address(RVA = "0xE8DD28", Offset = "0xE8DD28", VA = "0xE8DD28")]
	public VirtualControlsAxisConfiguration_Layout GetAxisConfiguration(string Id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C44")]
	[Cpp2IlInjected.Address(RVA = "0xE8D8D0", Offset = "0xE8D8D0", VA = "0xE8D8D0")]
	public VirtualControlsHardwareConfiguration_Layout GetHardwareConfiguration(string id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C45")]
	[Cpp2IlInjected.Address(RVA = "0xE8DEAC", Offset = "0xE8DEAC", VA = "0xE8DEAC")]
	public VirtualControlsProfile_Layout GetProfile(string id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C46")]
	[Cpp2IlInjected.Address(RVA = "0xE8DF40", Offset = "0xE8DF40", VA = "0xE8DF40")]
	public void SaveConfiguration(Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0xE8E194", Offset = "0xE8E194", VA = "0xE8E194")]
	public void LoadConfiguration(Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0xE8E7E8", Offset = "0xE8E7E8", VA = "0xE8E7E8")]
	public VirtualControlsStyles_Layout()
	{
	}
}
