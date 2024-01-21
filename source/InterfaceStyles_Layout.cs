using System.Collections.Generic;
using Cpp2IlInjected;
using Newtonsoft.Json;

[Cpp2IlInjected.Token(Token = "0x2000158")]
[JsonObject]
public class InterfaceStyles_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000D16")]
	public static InterfaceStyles_Layout Instance;

	[Cpp2IlInjected.Token(Token = "0x4000D17")]
	private static List<GUIPageIcons.Category> refreshCategories;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000D18")]
	public InterfaceProfile_Layout[] Profiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000D19")]
	[JsonProperty]
	public InterfaceProfile_Layout[] CustomProfiles;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public static InterfaceProfile_Layout Active
	{
		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x117527C", Offset = "0x117527C", VA = "0x117527C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public static InterfaceProfile_Layout _active
	{
		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x1176ACC", Offset = "0x1176ACC", VA = "0x1176ACC")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x1176B28", Offset = "0x1176B28", VA = "0x1176B28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B36")]
	[Cpp2IlInjected.Address(RVA = "0x1176A50", Offset = "0x1176A50", VA = "0x1176A50")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3A")]
	[Cpp2IlInjected.Address(RVA = "0x1176B88", Offset = "0x1176B88", VA = "0x1176B88")]
	public static void LoadUIResolution()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3B")]
	[Cpp2IlInjected.Address(RVA = "0x1177064", Offset = "0x1177064", VA = "0x1177064")]
	public static void SetActiveLayout(InterfaceProfile_Layout active)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3C")]
	[Cpp2IlInjected.Address(RVA = "0x1177C98", Offset = "0x1177C98", VA = "0x1177C98")]
	public InterfaceProfile_Layout GetDefaultProfile(string profileName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3D")]
	[Cpp2IlInjected.Address(RVA = "0x1177D08", Offset = "0x1177D08", VA = "0x1177D08")]
	public void SaveConfiguration()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3E")]
	[Cpp2IlInjected.Address(RVA = "0x1177F5C", Offset = "0x1177F5C", VA = "0x1177F5C")]
	public void RefreshProfileNames()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3F")]
	[Cpp2IlInjected.Address(RVA = "0x1178058", Offset = "0x1178058", VA = "0x1178058")]
	public void LoadConfiguration(bool allowLoad)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B40")]
	[Cpp2IlInjected.Address(RVA = "0x11786C0", Offset = "0x11786C0", VA = "0x11786C0")]
	public InterfaceStyles_Layout()
	{
	}
}
