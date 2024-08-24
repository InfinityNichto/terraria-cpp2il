using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Terraria;
using Terraria.Localization;
using Terraria.Utilities;

// Token: 0x02000157 RID: 343
[JsonObject(MemberSerialization.OptIn)]
[global::Cpp2ILInjected.Token(Token = "0x20001DC")]
public class InterfaceStyles_Layout : LayoutDefinition
{
	// Token: 0x06000B24 RID: 2852 RVA: 0x00023CB1 File Offset: 0x00021EB1
	[global::Cpp2ILInjected.Token(Token = "0x6000C37")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C8FAC", Offset = "0x9C8FAC", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00023CB4 File Offset: 0x00021EB4
	[global::Cpp2ILInjected.Token(Token = "0x17000155")]
	public static InterfaceProfile_Layout Active
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C38")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C9008", Offset = "0x9C9008", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 206)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00023CB7 File Offset: 0x00021EB7
	// (set) Token: 0x06000B27 RID: 2855 RVA: 0x00023CBA File Offset: 0x00021EBA
	[global::Cpp2ILInjected.Token(Token = "0x17000156")]
	public static InterfaceProfile_Layout _active
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C39")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C908C", Offset = "0x9C908C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000C3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C90D8", Offset = "0x9C90D8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x00023CBD File Offset: 0x00021EBD
	[global::Cpp2ILInjected.Token(Token = "0x6000C3B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C9128", Offset = "0x9C9128", Length = "0x414")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "SetActiveLayout", MemberParameters = new object[] { typeof(InterfaceProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawTemplate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawUITweaks", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "IsSame", MemberParameters = new object[]
	{
		typeof(InterfaceProfile_Layout),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "get_MinVerticalResolution", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "GetMinResolution", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "GetMaxResolution", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetDefaultVerticalResolution", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "OverrideVerticalResolution", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	public static void LoadUIResolution()
	{
		throw null;
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x00023CC0 File Offset: 0x00021EC0
	[global::Cpp2ILInjected.Token(Token = "0x6000C3C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C953C", Offset = "0x9C953C", Length = "0xC84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "AnyOpen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "InvalidateMinResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "GetCategoryGrouping", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "RefreshAllItems", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "OpenUI", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(GUIPageIcons.Category)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "ActivateController", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemFilter), Member = "SetSearchTerm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
	public static void SetActiveLayout(InterfaceProfile_Layout active)
	{
		throw null;
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x00023CC3 File Offset: 0x00021EC3
	[global::Cpp2ILInjected.Token(Token = "0x6000C3D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CA1C0", Offset = "0x9CA1C0", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public InterfaceProfile_Layout GetDefaultProfile(string profileName)
	{
		throw null;
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x00023CC6 File Offset: 0x00021EC6
	[global::Cpp2ILInjected.Token(Token = "0x6000C3E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CA22C", Offset = "0x9CA22C", Length = "0x248")]
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
	public void SaveConfiguration()
	{
		throw null;
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x00023CC9 File Offset: 0x00021EC9
	[global::Cpp2ILInjected.Token(Token = "0x6000C3F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CA474", Offset = "0x9CA474", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<LoadContent_Deferred>d__1863", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void RefreshProfileNames()
	{
		throw null;
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x00023CCC File Offset: 0x00021ECC
	[global::Cpp2ILInjected.Token(Token = "0x6000C40")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CA55C", Offset = "0x9CA55C", Length = "0x5E4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "GetDefaultProfile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "Copy", MemberParameters = new object[]
	{
		typeof(InterfaceProfile_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "Clean", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "RefreshProfileNames", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "PopulateObject", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object),
		typeof(JsonSerializerSettings)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
	public void LoadConfiguration(bool allowLoad)
	{
		throw null;
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00023CCF File Offset: 0x00021ECF
	[global::Cpp2ILInjected.Token(Token = "0x6000C41")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAB40", Offset = "0x9CAB40", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public InterfaceStyles_Layout()
	{
		throw null;
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x00023CD2 File Offset: 0x00021ED2
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000C42")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CABA0", Offset = "0x9CABA0", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	static InterfaceStyles_Layout()
	{
		throw null;
	}

	// Token: 0x04000D0D RID: 3341
	[global::Cpp2ILInjected.Token(Token = "0x4001110")]
	public static InterfaceStyles_Layout Instance;

	// Token: 0x04000D0E RID: 3342
	[global::Cpp2ILInjected.Token(Token = "0x4001111")]
	private static List<GUIPageIcons.Category> refreshCategories;

	// Token: 0x04000D0F RID: 3343
	[global::Cpp2ILInjected.Token(Token = "0x4001112")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public InterfaceProfile_Layout[] Profiles;

	// Token: 0x04000D10 RID: 3344
	[JsonProperty("Profiles")]
	[global::Cpp2ILInjected.Token(Token = "0x4001113")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public InterfaceProfile_Layout[] CustomProfiles;
}
