using System;
using Cpp2IlInjected;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000251")]
public class XNAUICameraSettings : DeviceVPPICalculator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001BE0")]
	public Camera Camera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001BE1")]
	private Vector2 _lastScreenResolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001BE2")]
	private bool _lastVPPIOverridden;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001BE3")]
	private float _lastVPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001BE4")]
	private float _lastZoomScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001BE5")]
	private Rect _lastSafeRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4001BE6")]
	public int _cameraWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4001BE7")]
	public int _cameraHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4001BE8")]
	private Rect _cameraSafeRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4001BE9")]
	public float _safeRegionMinX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4001BEA")]
	public float _safeRegionMinY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4001BEB")]
	public int realVirtualScreenWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4001BEC")]
	public int realVirtualScreenHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4001BED")]
	public int realVirtualScreenOffsetX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4001BEE")]
	public int realVirtualScreenOffsetY;

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	private bool ScreenResolutionSettingsDirty
	{
		[Cpp2IlInjected.Token(Token = "0x60010D7")]
		[Cpp2IlInjected.Address(RVA = "0x14FD460", Offset = "0x14FD460", VA = "0x14FD460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	private int NativeWidth
	{
		[Cpp2IlInjected.Token(Token = "0x60010DB")]
		[Cpp2IlInjected.Address(RVA = "0x14FD560", Offset = "0x14FD560", VA = "0x14FD560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	private int NativeHeight
	{
		[Cpp2IlInjected.Token(Token = "0x60010DC")]
		[Cpp2IlInjected.Address(RVA = "0x14FD600", Offset = "0x14FD600", VA = "0x14FD600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60010D3")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0E0", Offset = "0x14FD0E0", VA = "0x14FD0E0")]
	public XNAUICameraSettings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010D4")]
	[Cpp2IlInjected.Address(RVA = "0x14FD188", Offset = "0x14FD188", VA = "0x14FD188")]
	public XNAUICameraSettings(Camera camera, XNAUICameraSettings defaultSettings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010D5")]
	[Cpp2IlInjected.Address(RVA = "0x14FD26C", Offset = "0x14FD26C", VA = "0x14FD26C", Slot = "4")]
	public override void UpdateViewport(Rect newVeiwport)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010D6")]
	[Cpp2IlInjected.Address(RVA = "0x14FD2B8", Offset = "0x14FD2B8", VA = "0x14FD2B8")]
	private static bool RectRoughlyEqual(Rect a, Rect b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60010D8")]
	[Cpp2IlInjected.Address(RVA = "0x14FD910", Offset = "0x14FD910", VA = "0x14FD910")]
	public void RecalculateVirtualScreen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010D9")]
	[Cpp2IlInjected.Address(RVA = "0x14FD98C", Offset = "0x14FD98C", VA = "0x14FD98C")]
	public float GetMinResolution()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60010DA")]
	[Cpp2IlInjected.Address(RVA = "0x14FDAA0", Offset = "0x14FDAA0", VA = "0x14FDAA0")]
	public float GetMaxResolution()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60010DD")]
	[Cpp2IlInjected.Address(RVA = "0x14FD6A0", Offset = "0x14FD6A0", VA = "0x14FD6A0")]
	private new Rect GetViewportSafeRegion()
	{
		return default(Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x60010DE")]
	[Cpp2IlInjected.Address(RVA = "0x14FDB1C", Offset = "0x14FDB1C", VA = "0x14FDB1C")]
	public void ApplyCamera()
	{
	}
}
