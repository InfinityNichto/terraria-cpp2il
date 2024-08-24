using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000053 RID: 83
[global::Cpp2ILInjected.Token(Token = "0x200007D")]
public class GUIControllerPulldownEntry : GUIControllerMappingEntryBase
{
	// Token: 0x06000242 RID: 578 RVA: 0x00022217 File Offset: 0x00020417
	[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD264", Offset = "0x9BD264", Length = "0x19C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntryBase), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting.ActivateOverlayCallback), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting.DeactivateOverlayCallback), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting.RegisterOverlay), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(GUISettingID),
		typeof(GUIPulldownSetting.ActivateOverlayCallback),
		typeof(GUIPulldownSetting.DeactivateOverlayCallback),
		typeof(GUIPulldownSetting.RegisterOverlay)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerMappingsCategories_Layout), Member = "GetCategorySetup", MemberParameters = new object[]
	{
		typeof(GUISettingID),
		typeof(ref ControllerMappingsCategories_Layout.Category),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public GUIControllerPulldownEntry(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x06000243 RID: 579 RVA: 0x0002221A File Offset: 0x0002041A
	[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD400", Offset = "0x9BD400", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0002221D File Offset: 0x0002041D
	[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD410", Offset = "0x9BD410", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override float GetElementHeight()
	{
		throw null;
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00022220 File Offset: 0x00020420
	[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD420", Offset = "0x9BD420", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void DrawOverlay()
	{
		throw null;
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00022223 File Offset: 0x00020423
	[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD430", Offset = "0x9BD430", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingOverlay), Member = "ActivateOverlay", MemberParameters = new object[]
	{
		typeof(GUIControllerPulldownEntry),
		typeof(Rectangle),
		typeof(int),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		throw null;
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00022226 File Offset: 0x00020426
	[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD4C4", Offset = "0x9BD4C4", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingOverlay), Member = "DeactivateOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void DeactivateOverlay()
	{
		throw null;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00022229 File Offset: 0x00020429
	[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD518", Offset = "0x9BD518", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "RegisterOverlay", MemberParameters = new object[]
	{
		typeof(GUIControllerMappingEntryBase),
		typeof(Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void RegisterOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
		throw null;
	}

	// Token: 0x06000249 RID: 585 RVA: 0x0002222C File Offset: 0x0002042C
	[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD588", Offset = "0x9BD588", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingOverlay), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "GetNumberOfOptions", ReturnType = typeof(int))]
	public int GetNumberOfOptions()
	{
		throw null;
	}

	// Token: 0x04000212 RID: 530
	[global::Cpp2ILInjected.Token(Token = "0x4000324")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIPulldownSetting Worker;
}
