using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200024F RID: 591
[global::Cpp2ILInjected.Token(Token = "0x200030A")]
[Serializable]
public class XNAUICameraSettings : DeviceVPPICalculator
{
	// Token: 0x060010B9 RID: 4281 RVA: 0x00024D0D File Offset: 0x00022F0D
	[global::Cpp2ILInjected.Token(Token = "0x600120A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72968", Offset = "0xA72968", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public XNAUICameraSettings()
	{
		throw null;
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x00024D10 File Offset: 0x00022F10
	[global::Cpp2ILInjected.Token(Token = "0x600120B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA729D8", Offset = "0xA729D8", Length = "0xA4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public XNAUICameraSettings(Camera camera, XNAUICameraSettings defaultSettings)
	{
		throw null;
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x00024D13 File Offset: 0x00022F13
	[global::Cpp2ILInjected.Token(Token = "0x600120C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72A7C", Offset = "0xA72A7C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "UpdateViewport", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_rect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	public override void UpdateViewport(Rect newVeiwport)
	{
		throw null;
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x00024D16 File Offset: 0x00022F16
	[global::Cpp2ILInjected.Token(Token = "0x600120D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72AC8", Offset = "0xA72AC8", Length = "0x14C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "get_ScreenResolutionSettingsDirty", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_min", ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_max", ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private static bool RectRoughlyEqual(Rect a, Rect b)
	{
		throw null;
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x060010BD RID: 4285 RVA: 0x00024D19 File Offset: 0x00022F19
	[global::Cpp2ILInjected.Token(Token = "0x170001B1")]
	private bool ScreenResolutionSettingsDirty
	{
		[global::Cpp2ILInjected.Token(Token = "0x600120E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA72C14", Offset = "0xA72C14", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "get_NativeWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "get_NativeHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "RectRoughlyEqual", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(Rect)
		}, ReturnType = typeof(bool))]
		get
		{
			throw null;
		}
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x00024D1C File Offset: 0x00022F1C
	[global::Cpp2ILInjected.Token(Token = "0x600120F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72FD4", Offset = "0xA72FD4", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "get_NativeWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "get_NativeHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "UpdatePixelScale", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	public void RecalculateVirtualScreen()
	{
		throw null;
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x00024D1F File Offset: 0x00022F1F
	[global::Cpp2ILInjected.Token(Token = "0x6001210")]
	[global::Cpp2ILInjected.Address(RVA = "0xA73028", Offset = "0xA73028", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public float GetMinResolution()
	{
		throw null;
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x00024D22 File Offset: 0x00022F22
	[global::Cpp2ILInjected.Token(Token = "0x6001211")]
	[global::Cpp2ILInjected.Address(RVA = "0xA73108", Offset = "0xA73108", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "get_keys", ReturnType = typeof(Keyframe[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyframe), Member = "get_time", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyframe), Member = "get_value", ReturnType = typeof(float))]
	public float GetMaxResolution()
	{
		throw null;
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00024D25 File Offset: 0x00022F25
	[global::Cpp2ILInjected.Token(Token = "0x170001B2")]
	private int NativeWidth
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001212")]
		[global::Cpp2ILInjected.Address(RVA = "0xA72CE0", Offset = "0xA72CE0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "get_ScreenResolutionSettingsDirty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "RecalculateVirtualScreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00024D28 File Offset: 0x00022F28
	[global::Cpp2ILInjected.Token(Token = "0x170001B3")]
	private int NativeHeight
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001213")]
		[global::Cpp2ILInjected.Address(RVA = "0xA72D68", Offset = "0xA72D68", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "get_ScreenResolutionSettingsDirty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "RecalculateVirtualScreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x00024D2B File Offset: 0x00022F2B
	[global::Cpp2ILInjected.Token(Token = "0x6001214")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72DF0", Offset = "0xA72DF0", Length = "0x1E4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "get_ScreenResolutionSettingsDirty", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "RecalculateVirtualScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "GetMinResolution", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUICameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
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
	private new Rect GetViewportSafeRegion()
	{
		throw null;
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x00024D2E File Offset: 0x00022F2E
	[global::Cpp2ILInjected.Token(Token = "0x6001215")]
	[global::Cpp2ILInjected.Address(RVA = "0xA73168", Offset = "0xA73168", Length = "0x4CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "ApplyCameras", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "Awake", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "get_ScreenResolutionSettingsDirty", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "RecalculateVirtualScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "RectRoughlyEqual", MemberParameters = new object[]
	{
		typeof(Rect),
		typeof(Rect)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "get_NativeHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "get_NativeWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix4x4), Member = "Ortho", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(Matrix4x4))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_projectionMatrix", MemberParameters = new object[] { typeof(Matrix4x4) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void ApplyCamera()
	{
		throw null;
	}

	// Token: 0x04001BD7 RID: 7127
	[global::Cpp2ILInjected.Token(Token = "0x4002195")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Camera Camera;

	// Token: 0x04001BD8 RID: 7128
	[global::Cpp2ILInjected.Token(Token = "0x4002196")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private Vector2 _lastScreenResolution;

	// Token: 0x04001BD9 RID: 7129
	[global::Cpp2ILInjected.Token(Token = "0x4002197")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private bool _lastVPPIOverridden;

	// Token: 0x04001BDA RID: 7130
	[global::Cpp2ILInjected.Token(Token = "0x4002198")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	private float _lastVPPI;

	// Token: 0x04001BDB RID: 7131
	[global::Cpp2ILInjected.Token(Token = "0x4002199")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private float _lastZoomScale;

	// Token: 0x04001BDC RID: 7132
	[global::Cpp2ILInjected.Token(Token = "0x400219A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	private Rect _lastSafeRegion;

	// Token: 0x04001BDD RID: 7133
	[global::Cpp2ILInjected.Token(Token = "0x400219B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public int _cameraWidth;

	// Token: 0x04001BDE RID: 7134
	[global::Cpp2ILInjected.Token(Token = "0x400219C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public int _cameraHeight;

	// Token: 0x04001BDF RID: 7135
	[global::Cpp2ILInjected.Token(Token = "0x400219D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	private Rect _cameraSafeRegion;

	// Token: 0x04001BE0 RID: 7136
	[global::Cpp2ILInjected.Token(Token = "0x400219E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	public float _safeRegionMinX;

	// Token: 0x04001BE1 RID: 7137
	[global::Cpp2ILInjected.Token(Token = "0x400219F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public float _safeRegionMinY;

	// Token: 0x04001BE2 RID: 7138
	[global::Cpp2ILInjected.Token(Token = "0x40021A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public int realVirtualScreenWidth;

	// Token: 0x04001BE3 RID: 7139
	[global::Cpp2ILInjected.Token(Token = "0x40021A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public int realVirtualScreenHeight;

	// Token: 0x04001BE4 RID: 7140
	[global::Cpp2ILInjected.Token(Token = "0x40021A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public int realVirtualScreenOffsetX;

	// Token: 0x04001BE5 RID: 7141
	[global::Cpp2ILInjected.Token(Token = "0x40021A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public int realVirtualScreenOffsetY;
}
