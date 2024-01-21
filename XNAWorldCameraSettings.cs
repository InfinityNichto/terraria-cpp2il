using System;
using Cpp2IlInjected;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000253")]
public class XNAWorldCameraSettings : DeviceVPPICalculator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001C17")]
	public Camera MagnifyCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001C18")]
	public bool MagnifyActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001C19")]
	public Vector2 MagnifySrcRegionOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001C1A")]
	public Vector2 MagnifySrcRegionSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001C1B")]
	public Vector2 MagnifyDstRegionOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4001C1C")]
	public Vector2 MagnifyDstRegionSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4001C1D")]
	public Camera Camera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4001C1E")]
	public AnimationCurve UIScreenWorldOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4001C1F")]
	private Vector2 _lastScreenResolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4001C20")]
	private bool _lastVPPIOverridden;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4001C21")]
	private float _lastVPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4001C22")]
	private float _lastZoomScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4001C23")]
	private bool _wasInMenus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4001C24")]
	public int _cameraWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4001C25")]
	public int _cameraHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4001C26")]
	public Vector2 HorizontalSplitScreenResolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4001C27")]
	public Vector2 VertialSplitScreenResolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4001C28")]
	public Vector2 QuaterSplitScreenResolution;

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	private bool ScreenResolutionSettingsDirty
	{
		[Cpp2IlInjected.Token(Token = "0x6001112")]
		[Cpp2IlInjected.Address(RVA = "0x1504790", Offset = "0x1504790", VA = "0x1504790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public float MaxPixelScale
	{
		[Cpp2IlInjected.Token(Token = "0x6001114")]
		[Cpp2IlInjected.Address(RVA = "0x15045C8", Offset = "0x15045C8", VA = "0x15045C8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public float MinPixelScale
	{
		[Cpp2IlInjected.Token(Token = "0x6001115")]
		[Cpp2IlInjected.Address(RVA = "0x1504710", Offset = "0x1504710", VA = "0x1504710")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public int MaxWorldWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6001116")]
		[Cpp2IlInjected.Address(RVA = "0x150498C", Offset = "0x150498C", VA = "0x150498C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public int MaxWorldHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6001117")]
		[Cpp2IlInjected.Address(RVA = "0x15049D8", Offset = "0x15049D8", VA = "0x15049D8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	private int NativeWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6001118")]
		[Cpp2IlInjected.Address(RVA = "0x150484C", Offset = "0x150484C", VA = "0x150484C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public int NativeHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6001119")]
		[Cpp2IlInjected.Address(RVA = "0x15048EC", Offset = "0x15048EC", VA = "0x15048EC")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600110F")]
	[Cpp2IlInjected.Address(RVA = "0x1504344", Offset = "0x1504344", VA = "0x1504344")]
	public XNAWorldCameraSettings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001110")]
	[Cpp2IlInjected.Address(RVA = "0x15043CC", Offset = "0x15043CC", VA = "0x15043CC")]
	public XNAWorldCameraSettings(Camera camera, XNAWorldCameraSettings defaultSettings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001111")]
	[Cpp2IlInjected.Address(RVA = "0x1504498", Offset = "0x1504498", VA = "0x1504498", Slot = "4")]
	public override void UpdateViewport(Rect newVeiwport)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001113")]
	[Cpp2IlInjected.Address(RVA = "0x150456C", Offset = "0x150456C", VA = "0x150456C")]
	private void RecalculateVirtualScreen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600111A")]
	[Cpp2IlInjected.Address(RVA = "0x14FF258", Offset = "0x14FF258", VA = "0x14FF258")]
	public void ApplyCamera()
	{
	}
}
