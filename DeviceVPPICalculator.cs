using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200024B")]
public class DeviceVPPICalculator
{
	[Cpp2IlInjected.Token(Token = "0x200080F")]
	public class EditorMobileEmuEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007D5F")]
		public readonly string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007D60")]
		public readonly int Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007D61")]
		public readonly int Height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007D62")]
		public readonly float DPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007D63")]
		public readonly Rect SafeRegion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007D64")]
		public readonly int AllowedPlatforms;

		[Cpp2IlInjected.Token(Token = "0x6004958")]
		[Cpp2IlInjected.Address(RVA = "0x20CC038", Offset = "0x20CC038", VA = "0x20CC038")]
		public EditorMobileEmuEntry(string id, int width, int height, float dpi, int allowedPlatforms = 65535)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004959")]
		[Cpp2IlInjected.Address(RVA = "0x20CC0D8", Offset = "0x20CC0D8", VA = "0x20CC0D8")]
		public EditorMobileEmuEntry(string id, int width, int height, float dpi, Rect safeRegion, int allowedPlatforms = 65535)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001BA8")]
	private DeviceOrientation _cachedOrientation;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001BA9")]
	private bool DeviceDPISectup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001BAA")]
	private float DeviceDPI;

	[Cpp2IlInjected.Token(Token = "0x4001BAB")]
	private static float DefaultResolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001BAC")]
	protected Rect _viewport;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001BAD")]
	public AnimationCurve PhysicalToVPPICurve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001BAE")]
	public AnimationCurve PhysicalToResolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001BAF")]
	public float PhysicalHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001BB0")]
	public float VPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001BB1")]
	public float DPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001BB2")]
	public float PixelScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001BB3")]
	public bool VPPIOverridden;

	[Cpp2IlInjected.Token(Token = "0x4001BB4")]
	public static Rect SafeArea;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001BB5")]
	private float _zoomScale;

	[Cpp2IlInjected.Token(Token = "0x4001BB6")]
	private static float DefaultPhysicalHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001BB7")]
	private EditorMobileEmuEntry[] MobileResolutionEntries;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001BB8")]
	private EditorMobileEmuEntry _forceEMUEntry;

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public DeviceOrientation deviceOrientation
	{
		[Cpp2IlInjected.Token(Token = "0x600109A")]
		[Cpp2IlInjected.Address(RVA = "0x20C9C68", Offset = "0x20C9C68", VA = "0x20C9C68")]
		get
		{
			return default(DeviceOrientation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public Rect Viewport
	{
		[Cpp2IlInjected.Token(Token = "0x600109C")]
		[Cpp2IlInjected.Address(RVA = "0x20C9DA0", Offset = "0x20C9DA0", VA = "0x20C9DA0")]
		get
		{
			return default(Rect);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public float ZoomScale
	{
		[Cpp2IlInjected.Token(Token = "0x60010A8")]
		[Cpp2IlInjected.Address(RVA = "0x20CB800", Offset = "0x20CB800", VA = "0x20CB800")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60010A9")]
		[Cpp2IlInjected.Address(RVA = "0x20CB808", Offset = "0x20CB808", VA = "0x20CB808")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600109B")]
	[Cpp2IlInjected.Address(RVA = "0x20C9CA8", Offset = "0x20C9CA8", VA = "0x20C9CA8")]
	private float GetDeviceDPI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600109D")]
	[Cpp2IlInjected.Address(RVA = "0x20C9DB0", Offset = "0x20C9DB0", VA = "0x20C9DB0", Slot = "4")]
	public virtual void UpdateViewport(Rect newVeiwport)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600109E")]
	[Cpp2IlInjected.Address(RVA = "0x20C9E54", Offset = "0x20C9E54", VA = "0x20C9E54")]
	public float GetDefaultVerticalResolution(bool safeRegion = false)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600109F")]
	[Cpp2IlInjected.Address(RVA = "0x20CA2EC", Offset = "0x20CA2EC", VA = "0x20CA2EC")]
	protected void UpdatePixelScale(bool safeRegion = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010A0")]
	[Cpp2IlInjected.Address(RVA = "0x20CA68C", Offset = "0x20CA68C", VA = "0x20CA68C")]
	public Rect GetDefaultSafeArea()
	{
		return default(Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x60010A1")]
	[Cpp2IlInjected.Address(RVA = "0x20CA77C", Offset = "0x20CA77C", VA = "0x20CA77C")]
	private bool IsSafeAreaValid()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60010A2")]
	[Cpp2IlInjected.Address(RVA = "0x20CA088", Offset = "0x20CA088", VA = "0x20CA088")]
	public Rect GetViewportSafeRegion()
	{
		return default(Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x60010A3")]
	[Cpp2IlInjected.Address(RVA = "0x20CAC24", Offset = "0x20CAC24", VA = "0x20CAC24")]
	public Rect GetSafeArea()
	{
		return default(Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x60010A4")]
	[Cpp2IlInjected.Address(RVA = "0x20CB23C", Offset = "0x20CB23C", VA = "0x20CB23C")]
	public void ResetSafeArea()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010A5")]
	[Cpp2IlInjected.Address(RVA = "0x20CB2DC", Offset = "0x20CB2DC", VA = "0x20CB2DC")]
	public void SetSafeArea(Rect area)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010A6")]
	[Cpp2IlInjected.Address(RVA = "0x20CA570", Offset = "0x20CA570", VA = "0x20CA570")]
	private void UpdateForcedEmulation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010A7")]
	[Cpp2IlInjected.Address(RVA = "0x20CB7E0", Offset = "0x20CB7E0", VA = "0x20CB7E0")]
	public void OverrideVerticalResolution(int verticalResolution)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010AA")]
	[Cpp2IlInjected.Address(RVA = "0x20CB810", Offset = "0x20CB810", VA = "0x20CB810")]
	public DeviceVPPICalculator()
	{
	}
}
