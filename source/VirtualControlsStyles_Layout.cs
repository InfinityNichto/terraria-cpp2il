using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Terraria;
using Terraria.IO;
using Terraria.Utilities;

// Token: 0x020001BC RID: 444
[JsonObject(MemberSerialization.OptIn)]
[global::Cpp2ILInjected.Token(Token = "0x200024F")]
public class VirtualControlsStyles_Layout : LayoutDefinition
{
	// Token: 0x06000C2C RID: 3116 RVA: 0x00023FC9 File Offset: 0x000221C9
	[global::Cpp2ILInjected.Token(Token = "0x6000D46")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D676C", Offset = "0x9D676C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00023FCC File Offset: 0x000221CC
	[global::Cpp2ILInjected.Token(Token = "0x17000172")]
	public VirtualControlsProfile_Layout ActiveProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D47")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D67B8", Offset = "0x9D67B8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 107)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetProfile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsProfile_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "SetActiveProfile", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x00023FCF File Offset: 0x000221CF
	[global::Cpp2ILInjected.Token(Token = "0x6000D48")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D68C0", Offset = "0x9D68C0", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIProfileSwitch), Member = "CycleNextProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIProfileSwitch), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "LoadControlPositions", ReturnType = typeof(void))]
	public void SetActiveProfile(VirtualControlsProfile_Layout profile)
	{
		throw null;
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x00023FD2 File Offset: 0x000221D2
	[global::Cpp2ILInjected.Token(Token = "0x6000D49")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D65E0", Offset = "0x9D65E0", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ControlsItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawSlotsGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public VirtualControlsButtonConfiguration_Layout GetButtonConfiguration(string Id)
	{
		throw null;
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x00023FD5 File Offset: 0x000221D5
	[global::Cpp2ILInjected.Token(Token = "0x6000D4A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D6700", Offset = "0x9D6700", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ControlsItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawSlotsGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public VirtualControlsAxisConfiguration_Layout GetAxisConfiguration(string Id)
	{
		throw null;
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x00023FD8 File Offset: 0x000221D8
	[global::Cpp2ILInjected.Token(Token = "0x6000D4B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D6320", Offset = "0x9D6320", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawHardware", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public VirtualControlsHardwareConfiguration_Layout GetHardwareConfiguration(string id)
	{
		throw null;
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x00023FDB File Offset: 0x000221DB
	[global::Cpp2ILInjected.Token(Token = "0x6000D4C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D6854", Offset = "0x9D6854", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIProfileSwitch), Member = "CycleNextProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIProfileSwitch), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Backup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "GetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public VirtualControlsProfile_Layout GetProfile(string id)
	{
		throw null;
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x00023FDE File Offset: 0x000221DE
	[global::Cpp2ILInjected.Token(Token = "0x6000D4D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D68E4", Offset = "0x9D68E4", Length = "0x248")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_TypeNameHandling", MemberParameters = new object[] { typeof(TypeNameHandling) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_MetadataPropertyHandling", MemberParameters = new object[] { typeof(MetadataPropertyHandling) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringEnumConverter), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
	{
		typeof(object),
		typeof(Formatting),
		typeof(JsonSerializerSettings)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
	public void SaveConfiguration(Preferences preferences)
	{
		throw null;
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x00023FE1 File Offset: 0x000221E1
	[global::Cpp2ILInjected.Token(Token = "0x6000D4E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D6B2C", Offset = "0x9D6B2C", Length = "0x634")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetHardwareConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "LoadDefaultProfilePositions", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_TypeNameHandling", MemberParameters = new object[] { typeof(TypeNameHandling) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_MetadataPropertyHandling", MemberParameters = new object[] { typeof(MetadataPropertyHandling) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringEnumConverter), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "PopulateObject", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object),
		typeof(JsonSerializerSettings)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetProfile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
	public void LoadConfiguration(Preferences preferences)
	{
		throw null;
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x00023FE4 File Offset: 0x000221E4
	[global::Cpp2ILInjected.Token(Token = "0x6000D4F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7160", Offset = "0x9D7160", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public VirtualControlsStyles_Layout()
	{
		throw null;
	}

	// Token: 0x04001380 RID: 4992
	[global::Cpp2ILInjected.Token(Token = "0x400185B")]
	public static VirtualControlsStyles_Layout Instance;

	// Token: 0x04001381 RID: 4993
	[global::Cpp2ILInjected.Token(Token = "0x400185C")]
	public static string LastUsedProfile;

	// Token: 0x04001382 RID: 4994
	[global::Cpp2ILInjected.Token(Token = "0x400185D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public VirtualControlsButtonConfiguration_Layout[] ButtonTypes;

	// Token: 0x04001383 RID: 4995
	[global::Cpp2ILInjected.Token(Token = "0x400185E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public VirtualControlsAxisConfiguration_Layout[] AxisTypes;

	// Token: 0x04001384 RID: 4996
	[JsonProperty("Hardware")]
	[global::Cpp2ILInjected.Token(Token = "0x400185F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public VirtualControlsHardwareConfiguration_Layout[] HardwareStyles;

	// Token: 0x04001385 RID: 4997
	[JsonProperty("Profiles")]
	[global::Cpp2ILInjected.Token(Token = "0x4001860")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public VirtualControlsProfile_Layout[] Profiles;

	// Token: 0x04001386 RID: 4998
	[global::Cpp2ILInjected.Token(Token = "0x4001861")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private VirtualControlsProfile_Layout _activeProfile;
}
