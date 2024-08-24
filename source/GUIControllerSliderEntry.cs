using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000054 RID: 84
[global::Cpp2ILInjected.Token(Token = "0x200007E")]
public class GUIControllerSliderEntry : GUIControllerMappingEntryBase
{
	// Token: 0x0600024A RID: 586 RVA: 0x0002222F File Offset: 0x0002042F
	[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD594", Offset = "0x9BD594", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntryBase), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerMappingsCategories_Layout), Member = "GetCategorySetup", MemberParameters = new object[]
	{
		typeof(GUISettingID),
		typeof(ref ControllerMappingsCategories_Layout.Category),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public GUIControllerSliderEntry(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00022232 File Offset: 0x00020432
	[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD640", Offset = "0x9BD640", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00022235 File Offset: 0x00020435
	[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD650", Offset = "0x9BD650", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override float GetElementHeight()
	{
		throw null;
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00022238 File Offset: 0x00020438
	[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD660", Offset = "0x9BD660", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void DrawOverlay()
	{
		throw null;
	}

	// Token: 0x04000213 RID: 531
	[global::Cpp2ILInjected.Token(Token = "0x4000325")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUISliderSetting Worker;
}
