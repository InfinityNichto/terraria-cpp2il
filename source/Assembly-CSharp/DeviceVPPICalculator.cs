using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.IO;
using UnityEngine;

// Token: 0x02000249 RID: 585
[global::Cpp2ILInjected.Token(Token = "0x2000302")]
public class DeviceVPPICalculator
{
	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06001081 RID: 4225 RVA: 0x00024C65 File Offset: 0x00022E65
	[global::Cpp2ILInjected.Token(Token = "0x170001A0")]
	public DeviceOrientation deviceOrientation
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011D0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6F0E4", Offset = "0xA6F0E4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_deviceOrientation", ReturnType = typeof(DeviceOrientation))]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x00024C68 File Offset: 0x00022E68
	[global::Cpp2ILInjected.Token(Token = "0x60011D1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6F118", Offset = "0xA6F118", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = "GetDefaultVerticalResolution", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = "UpdatePixelScale", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_dpi", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private float GetDeviceDPI()
	{
		throw null;
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06001083 RID: 4227 RVA: 0x00024C6B File Offset: 0x00022E6B
	[global::Cpp2ILInjected.Token(Token = "0x170001A1")]
	public Rect Viewport
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011D2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6F1D8", Offset = "0xA6F1D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x00024C6E File Offset: 0x00022E6E
	[global::Cpp2ILInjected.Token(Token = "0x60011D3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6F1E4", Offset = "0xA6F1E4", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "UpdateViewport", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "UpdateViewport", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public virtual void UpdateViewport(Rect newVeiwport)
	{
		throw null;
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x00024C71 File Offset: 0x00022E71
	[global::Cpp2ILInjected.Token(Token = "0x60011D4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6F26C", Offset = "0xA6F26C", Length = "0x1A4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetDeviceDPI", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public float GetDefaultVerticalResolution(bool safeRegion = false)
	{
		throw null;
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00024C74 File Offset: 0x00022E74
	[global::Cpp2ILInjected.Token(Token = "0x60011D5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6F5FC", Offset = "0xA6F5FC", Length = "0x1DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "RecalculateVirtualScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "RecalculateVirtualScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "UpdateForcedEmulation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetDeviceDPI", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	protected void UpdatePixelScale(bool safeRegion = false)
	{
		throw null;
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00024C77 File Offset: 0x00022E77
	[global::Cpp2ILInjected.Token(Token = "0x60011D6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6F88C", Offset = "0xA6F88C", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = "GetSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = "ResetSafeArea", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = "SetSafeArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_safeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_yMin", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_yMax", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rect GetDefaultSafeArea()
	{
		throw null;
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x00024C7A File Offset: 0x00022E7A
	[global::Cpp2ILInjected.Token(Token = "0x60011D7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6F93C", Offset = "0xA6F93C", Length = "0x330")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = "GetSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private bool IsSafeAreaValid()
	{
		throw null;
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x00024C7D File Offset: 0x00022E7D
	[global::Cpp2ILInjected.Token(Token = "0x60011D8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6F418", Offset = "0xA6F418", Length = "0x1E4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "get_MinVerticalResolution", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = "GetDefaultVerticalResolution", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = "UpdatePixelScale", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rect GetViewportSafeRegion()
	{
		throw null;
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x00024C80 File Offset: 0x00022E80
	[global::Cpp2ILInjected.Token(Token = "0x60011D9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6FC74", Offset = "0xA6FC74", Length = "0x508")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Backup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "DrawBacking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawBacking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "UpdateViewPorts", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "IsSafeAreaValid", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetDefaultSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_xMin", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_xMax", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_yMin", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_yMax", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Configuration", ReturnType = typeof(Preferences))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences[]), Member = "Get", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
	{
		typeof(string),
		typeof(float)
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_deviceOrientation", ReturnType = typeof(DeviceOrientation))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public Rect GetSafeArea()
	{
		throw null;
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00024C83 File Offset: 0x00022E83
	[global::Cpp2ILInjected.Token(Token = "0x60011DA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7017C", Offset = "0xA7017C", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetDefaultSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void ResetSafeArea()
	{
		throw null;
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00024C86 File Offset: 0x00022E86
	[global::Cpp2ILInjected.Token(Token = "0x60011DB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA70204", Offset = "0xA70204", Length = "0x350")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetDefaultSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_deviceOrientation", ReturnType = typeof(DeviceOrientation))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public void SetSafeArea(Rect area)
	{
		throw null;
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x00024C89 File Offset: 0x00022E89
	[global::Cpp2ILInjected.Token(Token = "0x60011DC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6F7D8", Offset = "0xA6F7D8", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = "UpdatePixelScale", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void UpdateForcedEmulation()
	{
		throw null;
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x00024C8C File Offset: 0x00022E8C
	[global::Cpp2ILInjected.Token(Token = "0x60011DD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA70554", Offset = "0xA70554", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ClampUIScale", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void OverrideVerticalResolution(int verticalResolution)
	{
		throw null;
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x0600108F RID: 4239 RVA: 0x00024C8F File Offset: 0x00022E8F
	// (set) Token: 0x06001090 RID: 4240 RVA: 0x00024C92 File Offset: 0x00022E92
	[global::Cpp2ILInjected.Token(Token = "0x170001A2")]
	public float ZoomScale
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011DE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA70570", Offset = "0xA70570", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60011DF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA70578", Offset = "0xA70578", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00024C95 File Offset: 0x00022E95
	[global::Cpp2ILInjected.Token(Token = "0x60011E0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA70580", Offset = "0xA70580", Length = "0x6E4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Camera),
		typeof(XNAUICameraSettings)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Camera),
		typeof(XNAWorldCameraSettings)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator.EditorMobileEmuEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
	public DeviceVPPICalculator()
	{
		throw null;
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x00024C98 File Offset: 0x00022E98
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60011E1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA70D70", Offset = "0xA70D70", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	static DeviceVPPICalculator()
	{
		throw null;
	}

	// Token: 0x04001B9F RID: 7071
	[global::Cpp2ILInjected.Token(Token = "0x4002153")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private DeviceOrientation _cachedOrientation;

	// Token: 0x04001BA0 RID: 7072
	[global::Cpp2ILInjected.Token(Token = "0x4002154")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private bool DeviceDPISectup;

	// Token: 0x04001BA1 RID: 7073
	[global::Cpp2ILInjected.Token(Token = "0x4002155")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float DeviceDPI;

	// Token: 0x04001BA2 RID: 7074
	[global::Cpp2ILInjected.Token(Token = "0x4002156")]
	private static float DefaultResolution;

	// Token: 0x04001BA3 RID: 7075
	[global::Cpp2ILInjected.Token(Token = "0x4002157")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	protected Rect _viewport;

	// Token: 0x04001BA4 RID: 7076
	[global::Cpp2ILInjected.Token(Token = "0x4002158")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public AnimationCurve PhysicalToVPPICurve;

	// Token: 0x04001BA5 RID: 7077
	[global::Cpp2ILInjected.Token(Token = "0x4002159")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public AnimationCurve PhysicalToResolution;

	// Token: 0x04001BA6 RID: 7078
	[global::Cpp2ILInjected.Token(Token = "0x400215A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float PhysicalHeight;

	// Token: 0x04001BA7 RID: 7079
	[global::Cpp2ILInjected.Token(Token = "0x400215B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float VPPI;

	// Token: 0x04001BA8 RID: 7080
	[global::Cpp2ILInjected.Token(Token = "0x400215C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float DPI;

	// Token: 0x04001BA9 RID: 7081
	[global::Cpp2ILInjected.Token(Token = "0x400215D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float PixelScale;

	// Token: 0x04001BAA RID: 7082
	[global::Cpp2ILInjected.Token(Token = "0x400215E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public bool VPPIOverridden;

	// Token: 0x04001BAB RID: 7083
	[global::Cpp2ILInjected.Token(Token = "0x400215F")]
	public static Rect SafeArea;

	// Token: 0x04001BAC RID: 7084
	[global::Cpp2ILInjected.Token(Token = "0x4002160")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private float _zoomScale;

	// Token: 0x04001BAD RID: 7085
	[global::Cpp2ILInjected.Token(Token = "0x4002161")]
	private static float DefaultPhysicalHeight;

	// Token: 0x04001BAE RID: 7086
	[global::Cpp2ILInjected.Token(Token = "0x4002162")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private DeviceVPPICalculator.EditorMobileEmuEntry[] MobileResolutionEntries;

	// Token: 0x04001BAF RID: 7087
	[global::Cpp2ILInjected.Token(Token = "0x4002163")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private DeviceVPPICalculator.EditorMobileEmuEntry _forceEMUEntry;

	// Token: 0x02000818 RID: 2072
	[global::Cpp2ILInjected.Token(Token = "0x2000303")]
	public class EditorMobileEmuEntry
	{
		// Token: 0x06004922 RID: 18722 RVA: 0x0002EF7F File Offset: 0x0002D17F
		[global::Cpp2ILInjected.Token(Token = "0x60011E2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA70C64", Offset = "0xA70C64", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceVPPICalculator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenshotSetup), Member = "get_EmulationEntry", ReturnType = typeof(DeviceVPPICalculator.EditorMobileEmuEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EditorMobileEmuEntry(string id, int width, int height, float dpi, int allowedPlatforms = 65535)
		{
			throw null;
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x0002EF82 File Offset: 0x0002D182
		[global::Cpp2ILInjected.Token(Token = "0x60011E3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA70CF4", Offset = "0xA70CF4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EditorMobileEmuEntry(string id, int width, int height, float dpi, Rect safeRegion, int allowedPlatforms = 65535)
		{
			throw null;
		}

		// Token: 0x04007D72 RID: 32114
		[global::Cpp2ILInjected.Token(Token = "0x4002164")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string Id;

		// Token: 0x04007D73 RID: 32115
		[global::Cpp2ILInjected.Token(Token = "0x4002165")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int Width;

		// Token: 0x04007D74 RID: 32116
		[global::Cpp2ILInjected.Token(Token = "0x4002166")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public readonly int Height;

		// Token: 0x04007D75 RID: 32117
		[global::Cpp2ILInjected.Token(Token = "0x4002167")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly float DPI;

		// Token: 0x04007D76 RID: 32118
		[global::Cpp2ILInjected.Token(Token = "0x4002168")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public readonly Rect SafeRegion;

		// Token: 0x04007D77 RID: 32119
		[global::Cpp2ILInjected.Token(Token = "0x4002169")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public readonly int AllowedPlatforms;
	}
}
