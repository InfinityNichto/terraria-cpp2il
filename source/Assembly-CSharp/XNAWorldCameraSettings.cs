using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using UnityEngine;

// Token: 0x02000251 RID: 593
[global::Cpp2ILInjected.Token(Token = "0x200030E")]
[Serializable]
public class XNAWorldCameraSettings : DeviceVPPICalculator
{
	// Token: 0x060010F5 RID: 4341 RVA: 0x00024DC1 File Offset: 0x00022FC1
	[global::Cpp2ILInjected.Token(Token = "0x600124A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA773F4", Offset = "0xA773F4", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public XNAWorldCameraSettings()
	{
		throw null;
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00024DC4 File Offset: 0x00022FC4
	[global::Cpp2ILInjected.Token(Token = "0x600124B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA77450", Offset = "0xA77450", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public XNAWorldCameraSettings(Camera camera, XNAWorldCameraSettings defaultSettings)
	{
		throw null;
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00024DC7 File Offset: 0x00022FC7
	[global::Cpp2ILInjected.Token(Token = "0x600124C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA774E8", Offset = "0xA774E8", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "UpdateViewport", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_rect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "RecalculateVirtualScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MinPixelScale", ReturnType = typeof(float))]
	public override void UpdateViewport(Rect newVeiwport)
	{
		throw null;
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x060010F8 RID: 4344 RVA: 0x00024DCA File Offset: 0x00022FCA
	[global::Cpp2ILInjected.Token(Token = "0x170001C5")]
	private bool ScreenResolutionSettingsDirty
	{
		[global::Cpp2ILInjected.Token(Token = "0x600124D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA77770", Offset = "0xA77770", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeHeight", ReturnType = typeof(int))]
		get
		{
			throw null;
		}
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00024DCD File Offset: 0x00022FCD
	[global::Cpp2ILInjected.Token(Token = "0x600124E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA775A8", Offset = "0xA775A8", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "UpdateViewport", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "UpdatePixelScale", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	private void RecalculateVirtualScreen()
	{
		throw null;
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x060010FA RID: 4346 RVA: 0x00024DD0 File Offset: 0x00022FD0
	[global::Cpp2ILInjected.Token(Token = "0x170001C6")]
	public float MaxPixelScale
	{
		[global::Cpp2ILInjected.Token(Token = "0x600124F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA775F0", Offset = "0xA775F0", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "get_WorldScreenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "get_WorldScreenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "GetDefaultWorldZoomScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "LoadDefaultZoom", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "ApplyPixelZoom", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "UpdateViewport", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxWorldWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxWorldHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x060010FB RID: 4347 RVA: 0x00024DD3 File Offset: 0x00022FD3
	[global::Cpp2ILInjected.Token(Token = "0x170001C7")]
	public float MinPixelScale
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001250")]
		[global::Cpp2ILInjected.Address(RVA = "0xA77704", Offset = "0xA77704", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "UpdateViewport", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		get
		{
			throw null;
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x060010FC RID: 4348 RVA: 0x00024DD6 File Offset: 0x00022FD6
	[global::Cpp2ILInjected.Token(Token = "0x170001C8")]
	public int MaxWorldWidth
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001251")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7118C", Offset = "0xA7118C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "get_WorldScreenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DistortionRenderTargetManager), Member = "InitialiseCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterRenderTargetManager), Member = "InitialiseCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeWidth", ReturnType = typeof(int))]
		get
		{
			throw null;
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x060010FD RID: 4349 RVA: 0x00024DD9 File Offset: 0x00022FD9
	[global::Cpp2ILInjected.Token(Token = "0x170001C9")]
	public int MaxWorldHeight
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001252")]
		[global::Cpp2ILInjected.Address(RVA = "0xA711DC", Offset = "0xA711DC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "get_WorldScreenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DistortionRenderTargetManager), Member = "InitialiseCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterRenderTargetManager), Member = "InitialiseCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeHeight", ReturnType = typeof(int))]
		get
		{
			throw null;
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x060010FE RID: 4350 RVA: 0x00024DDC File Offset: 0x00022FDC
	[global::Cpp2ILInjected.Token(Token = "0x170001CA")]
	private int NativeWidth
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001253")]
		[global::Cpp2ILInjected.Address(RVA = "0xA777F8", Offset = "0xA777F8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "get_ScreenResolutionSettingsDirty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "RecalculateVirtualScreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "get_MinPixelScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxWorldWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x060010FF RID: 4351 RVA: 0x00024DDF File Offset: 0x00022FDF
	[global::Cpp2ILInjected.Token(Token = "0x170001CB")]
	public int NativeHeight
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001254")]
		[global::Cpp2ILInjected.Address(RVA = "0xA77880", Offset = "0xA77880", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "get_ScreenResolutionSettingsDirty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "RecalculateVirtualScreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "get_MinPixelScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxWorldHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00024DE2 File Offset: 0x00022FE2
	[global::Cpp2ILInjected.Token(Token = "0x6001255")]
	[global::Cpp2ILInjected.Address(RVA = "0xA73898", Offset = "0xA73898", Length = "0x498")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMagnify), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "ApplyPixelZoom", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "ApplyCameras", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "Awake", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "RecalculateVirtualScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIZoom), Member = "LoadDefaultZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "LoadDefaultZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_ScreenResolutionSettingsDirty", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_NativeWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new object[] { typeof(global::UnityEngine.Vector3) }, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Vector2),
		typeof(global::UnityEngine.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_rect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void ApplyCamera()
	{
		throw null;
	}

	// Token: 0x04001C0F RID: 7183
	[global::Cpp2ILInjected.Token(Token = "0x40021DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Camera MagnifyCamera;

	// Token: 0x04001C10 RID: 7184
	[global::Cpp2ILInjected.Token(Token = "0x40021DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public bool MagnifyActive;

	// Token: 0x04001C11 RID: 7185
	[global::Cpp2ILInjected.Token(Token = "0x40021DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public global::UnityEngine.Vector2 MagnifySrcRegionOffset;

	// Token: 0x04001C12 RID: 7186
	[global::Cpp2ILInjected.Token(Token = "0x40021DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public global::UnityEngine.Vector2 MagnifySrcRegionSize;

	// Token: 0x04001C13 RID: 7187
	[global::Cpp2ILInjected.Token(Token = "0x40021E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public global::UnityEngine.Vector2 MagnifyDstRegionOffset;

	// Token: 0x04001C14 RID: 7188
	[global::Cpp2ILInjected.Token(Token = "0x40021E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public global::UnityEngine.Vector2 MagnifyDstRegionSize;

	// Token: 0x04001C15 RID: 7189
	[global::Cpp2ILInjected.Token(Token = "0x40021E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Camera Camera;

	// Token: 0x04001C16 RID: 7190
	[global::Cpp2ILInjected.Token(Token = "0x40021E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public AnimationCurve UIScreenWorldOffset;

	// Token: 0x04001C17 RID: 7191
	[global::Cpp2ILInjected.Token(Token = "0x40021E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private global::UnityEngine.Vector2 _lastScreenResolution;

	// Token: 0x04001C18 RID: 7192
	[global::Cpp2ILInjected.Token(Token = "0x40021E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private bool _lastVPPIOverridden;

	// Token: 0x04001C19 RID: 7193
	[global::Cpp2ILInjected.Token(Token = "0x40021E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	private float _lastVPPI;

	// Token: 0x04001C1A RID: 7194
	[global::Cpp2ILInjected.Token(Token = "0x40021E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private float _lastZoomScale;

	// Token: 0x04001C1B RID: 7195
	[global::Cpp2ILInjected.Token(Token = "0x40021E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	private bool _wasInMenus;

	// Token: 0x04001C1C RID: 7196
	[global::Cpp2ILInjected.Token(Token = "0x40021E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public int _cameraWidth;

	// Token: 0x04001C1D RID: 7197
	[global::Cpp2ILInjected.Token(Token = "0x40021EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public int _cameraHeight;

	// Token: 0x04001C1E RID: 7198
	[global::Cpp2ILInjected.Token(Token = "0x40021EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public global::UnityEngine.Vector2 HorizontalSplitScreenResolution;

	// Token: 0x04001C1F RID: 7199
	[global::Cpp2ILInjected.Token(Token = "0x40021EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public global::UnityEngine.Vector2 VertialSplitScreenResolution;

	// Token: 0x04001C20 RID: 7200
	[global::Cpp2ILInjected.Token(Token = "0x40021ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public global::UnityEngine.Vector2 QuaterSplitScreenResolution;
}
