using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20000B3")]
public class GUIControllerHardwarePulldown : GUIControllerMappingEntryBase
{
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

	[global::Cpp2ILInjected.Token(Token = "0x600043F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B60", Offset = "0xA87B60", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void Draw()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000440")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B70", Offset = "0xA87B70", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override float GetElementHeight()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000441")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B80", Offset = "0xA87B80", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override void DrawOverlay()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000442")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B90", Offset = "0xA87B90", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000443")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87B94", Offset = "0xA87B94", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void DeactivateOverlay()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x6000445")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87C04", Offset = "0xA87C04", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "GetNumberOfOptions", ReturnType = typeof(int))]
	public int GetNumberOfOptions()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000446")]
	[global::Cpp2ILInjected.Address(RVA = "0xA85298", Offset = "0xA85298", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "CloseOptions", ReturnType = typeof(void))]
	public void CloseOptions()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000438")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIPulldownSetting Worker;
}
