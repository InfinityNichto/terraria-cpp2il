using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000055 RID: 85
[global::Cpp2ILInjected.Token(Token = "0x200007F")]
public class GUIControllerToggleEntry : GUIControllerMappingEntryBase
{
	// Token: 0x0600024E RID: 590 RVA: 0x0002223B File Offset: 0x0002043B
	[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD670", Offset = "0x9BD670", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntryBase), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIToggleSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerMappingsCategories_Layout), Member = "GetCategorySetup", MemberParameters = new object[]
	{
		typeof(GUISettingID),
		typeof(ref ControllerMappingsCategories_Layout.Category),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public GUIControllerToggleEntry(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x0600024F RID: 591 RVA: 0x0002223E File Offset: 0x0002043E
	[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD71C", Offset = "0x9BD71C", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00022241 File Offset: 0x00020441
	[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD72C", Offset = "0x9BD72C", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override float GetElementHeight()
	{
		throw null;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00022244 File Offset: 0x00020444
	[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD73C", Offset = "0x9BD73C", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void DrawOverlay()
	{
		throw null;
	}

	// Token: 0x04000214 RID: 532
	[global::Cpp2ILInjected.Token(Token = "0x4000326")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIToggleSetting Worker;
}
