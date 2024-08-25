using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000074")]
public class GUIControllerMappingEntryBase : GUISettingEntry
{
	[global::Cpp2ILInjected.Token(Token = "0x6000288")]
	[global::Cpp2ILInjected.Address(RVA = "0x71199C", Offset = "0x71199C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPulldownEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerSliderEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerToggleEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(GUIControllerHardwareProfileEntry.BindingId),
		typeof(ControllerDevice)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwarePulldown), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	public GUIControllerMappingEntryBase(GUISettingID id)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000241")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public ControllerMappingsCategories_Layout.Category Category;

	[global::Cpp2ILInjected.Token(Token = "0x4000242")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int SortOrder;
}
