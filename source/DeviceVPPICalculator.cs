using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.IO;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000302")]
public class DeviceVPPICalculator
{
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

	[global::Cpp2ILInjected.Token(Token = "0x60011DA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7017C", Offset = "0xA7017C", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetDefaultSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void ResetSafeArea()
	{
		throw null;
	}

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

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60011E1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA70D70", Offset = "0xA70D70", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	static DeviceVPPICalculator()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4002153")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private DeviceOrientation _cachedOrientation;

	[global::Cpp2ILInjected.Token(Token = "0x4002154")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private bool DeviceDPISectup;

	[global::Cpp2ILInjected.Token(Token = "0x4002155")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float DeviceDPI;

	[global::Cpp2ILInjected.Token(Token = "0x4002156")]
	private static float DefaultResolution;

	[global::Cpp2ILInjected.Token(Token = "0x4002157")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	protected Rect _viewport;

	[global::Cpp2ILInjected.Token(Token = "0x4002158")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public AnimationCurve PhysicalToVPPICurve;

	[global::Cpp2ILInjected.Token(Token = "0x4002159")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public AnimationCurve PhysicalToResolution;

	[global::Cpp2ILInjected.Token(Token = "0x400215A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float PhysicalHeight;

	[global::Cpp2ILInjected.Token(Token = "0x400215B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float VPPI;

	[global::Cpp2ILInjected.Token(Token = "0x400215C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float DPI;

	[global::Cpp2ILInjected.Token(Token = "0x400215D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float PixelScale;

	[global::Cpp2ILInjected.Token(Token = "0x400215E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public bool VPPIOverridden;

	[global::Cpp2ILInjected.Token(Token = "0x400215F")]
	public static Rect SafeArea;

	[global::Cpp2ILInjected.Token(Token = "0x4002160")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private float _zoomScale;

	[global::Cpp2ILInjected.Token(Token = "0x4002161")]
	private static float DefaultPhysicalHeight;

	[global::Cpp2ILInjected.Token(Token = "0x4002162")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private DeviceVPPICalculator.EditorMobileEmuEntry[] MobileResolutionEntries;

	[global::Cpp2ILInjected.Token(Token = "0x4002163")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private DeviceVPPICalculator.EditorMobileEmuEntry _forceEMUEntry;

	[global::Cpp2ILInjected.Token(Token = "0x2000303")]
	public class EditorMobileEmuEntry
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60011E3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA70CF4", Offset = "0xA70CF4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EditorMobileEmuEntry(string id, int width, int height, float dpi, Rect safeRegion, int allowedPlatforms = 65535)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002164")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string Id;

		[global::Cpp2ILInjected.Token(Token = "0x4002165")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int Width;

		[global::Cpp2ILInjected.Token(Token = "0x4002166")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public readonly int Height;

		[global::Cpp2ILInjected.Token(Token = "0x4002167")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly float DPI;

		[global::Cpp2ILInjected.Token(Token = "0x4002168")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public readonly Rect SafeRegion;

		[global::Cpp2ILInjected.Token(Token = "0x4002169")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public readonly int AllowedPlatforms;
	}
}
