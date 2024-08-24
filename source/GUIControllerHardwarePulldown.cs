using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200007C RID: 124
[global::Cpp2ILInjected.Token(Token = "0x20000B3")]
public class GUIControllerHardwarePulldown : GUIControllerMappingEntryBase
{
	// Token: 0x060003A4 RID: 932 RVA: 0x00022631 File Offset: 0x00020831
	[global::Cpp2ILInjected.Token(Token = "0x600043E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8655C", Offset = "0xA8655C", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "Open", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public GUIControllerHardwarePulldown(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00022634 File Offset: 0x00020834
	[global::Cpp2ILInjected.Token(Token = "0x600043F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B60", Offset = "0xA87B60", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00022637 File Offset: 0x00020837
	[global::Cpp2ILInjected.Token(Token = "0x6000440")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B70", Offset = "0xA87B70", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override float GetElementHeight()
	{
		throw null;
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x0002263A File Offset: 0x0002083A
	[global::Cpp2ILInjected.Token(Token = "0x6000441")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B80", Offset = "0xA87B80", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void DrawOverlay()
	{
		throw null;
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x0002263D File Offset: 0x0002083D
	[global::Cpp2ILInjected.Token(Token = "0x6000442")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B90", Offset = "0xA87B90", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		throw null;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00022640 File Offset: 0x00020840
	[global::Cpp2ILInjected.Token(Token = "0x6000443")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B94", Offset = "0xA87B94", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void DeactivateOverlay()
	{
		throw null;
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00022643 File Offset: 0x00020843
	[global::Cpp2ILInjected.Token(Token = "0x6000444")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B98", Offset = "0xA87B98", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "RegisterOverlay", MemberParameters = new object[]
	{
		typeof(GUIControllerMappingEntryBase),
		typeof(Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void RegisterOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
		throw null;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00022646 File Offset: 0x00020846
	[global::Cpp2ILInjected.Token(Token = "0x6000445")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87C04", Offset = "0xA87C04", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "GetNumberOfOptions", ReturnType = typeof(int))]
	public int GetNumberOfOptions()
	{
		throw null;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00022649 File Offset: 0x00020849
	[global::Cpp2ILInjected.Token(Token = "0x6000446")]
	[global::Cpp2ILInjected.Address(RVA = "0xA85298", Offset = "0xA85298", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "CloseOptions", ReturnType = typeof(void))]
	public void CloseOptions()
	{
		throw null;
	}

	// Token: 0x040002C2 RID: 706
	[global::Cpp2ILInjected.Token(Token = "0x4000438")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIPulldownSetting Worker;
}
