using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002B0")]
public sealed class GraphicsAdapter
{
	[Cpp2IlInjected.Token(Token = "0x2000820")]
	public enum DriverType
	{
		[Cpp2IlInjected.Token(Token = "0x4007DEE")]
		Hardware,
		[Cpp2IlInjected.Token(Token = "0x4007DEF")]
		Reference,
		[Cpp2IlInjected.Token(Token = "0x4007DF0")]
		FastSoftware
	}

	[Cpp2IlInjected.Token(Token = "0x4001F7F")]
	private static int _virtualScreenSize;

	[Cpp2IlInjected.Token(Token = "0x4001F80")]
	private static readonly ReadOnlyCollection<GraphicsAdapter> _adapters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001F81")]
	private DisplayModeCollection _supportedDisplayModes;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001F82")]
	private DisplayMode _currentDisplayMode;

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	public static int VirtualScreenSize
	{
		[Cpp2IlInjected.Token(Token = "0x60015E6")]
		[Cpp2IlInjected.Address(RVA = "0x13A0400", Offset = "0x13A0400", VA = "0x13A0400")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60015E7")]
		[Cpp2IlInjected.Address(RVA = "0x13A0478", Offset = "0x13A0478", VA = "0x13A0478")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public static GraphicsAdapter DefaultAdapter
	{
		[Cpp2IlInjected.Token(Token = "0x60015E9")]
		[Cpp2IlInjected.Address(RVA = "0x13A09CC", Offset = "0x13A09CC", VA = "0x13A09CC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public static ReadOnlyCollection<GraphicsAdapter> Adapters
	{
		[Cpp2IlInjected.Token(Token = "0x60015EA")]
		[Cpp2IlInjected.Address(RVA = "0x13A0A5C", Offset = "0x13A0A5C", VA = "0x13A0A5C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public static bool UseReferenceDevice
	{
		[Cpp2IlInjected.Token(Token = "0x60015EB")]
		[Cpp2IlInjected.Address(RVA = "0x13A0AD4", Offset = "0x13A0AD4", VA = "0x13A0AD4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60015EC")]
		[Cpp2IlInjected.Address(RVA = "0x13A0BAC", Offset = "0x13A0BAC", VA = "0x13A0BAC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public static DriverType UseDriverType
	{
		[Cpp2IlInjected.Token(Token = "0x60015ED")]
		[Cpp2IlInjected.Address(RVA = "0x13A0C7C", Offset = "0x13A0C7C", VA = "0x13A0C7C")]
		[CompilerGenerated]
		get
		{
			return default(DriverType);
		}
		[Cpp2IlInjected.Token(Token = "0x60015EE")]
		[Cpp2IlInjected.Address(RVA = "0x13A0CF4", Offset = "0x13A0CF4", VA = "0x13A0CF4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000298")]
	public static bool UseDebugLayers
	{
		[Cpp2IlInjected.Token(Token = "0x60015EF")]
		[Cpp2IlInjected.Address(RVA = "0x13A0D70", Offset = "0x13A0D70", VA = "0x13A0D70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60015F0")]
		[Cpp2IlInjected.Address(RVA = "0x13A0DE8", Offset = "0x13A0DE8", VA = "0x13A0DE8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000299")]
	public string Description
	{
		[Cpp2IlInjected.Token(Token = "0x60015F1")]
		[Cpp2IlInjected.Address(RVA = "0x13A0E64", Offset = "0x13A0E64", VA = "0x13A0E64")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60015F2")]
		[Cpp2IlInjected.Address(RVA = "0x13A0E6C", Offset = "0x13A0E6C", VA = "0x13A0E6C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029A")]
	public int DeviceId
	{
		[Cpp2IlInjected.Token(Token = "0x60015F3")]
		[Cpp2IlInjected.Address(RVA = "0x13A0E74", Offset = "0x13A0E74", VA = "0x13A0E74")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60015F4")]
		[Cpp2IlInjected.Address(RVA = "0x13A0E7C", Offset = "0x13A0E7C", VA = "0x13A0E7C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029B")]
	public string DeviceName
	{
		[Cpp2IlInjected.Token(Token = "0x60015F5")]
		[Cpp2IlInjected.Address(RVA = "0x13A0E84", Offset = "0x13A0E84", VA = "0x13A0E84")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60015F6")]
		[Cpp2IlInjected.Address(RVA = "0x13A0E8C", Offset = "0x13A0E8C", VA = "0x13A0E8C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public int VendorId
	{
		[Cpp2IlInjected.Token(Token = "0x60015F7")]
		[Cpp2IlInjected.Address(RVA = "0x13A0E94", Offset = "0x13A0E94", VA = "0x13A0E94")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60015F8")]
		[Cpp2IlInjected.Address(RVA = "0x13A0E9C", Offset = "0x13A0E9C", VA = "0x13A0E9C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public bool IsDefaultAdapter
	{
		[Cpp2IlInjected.Token(Token = "0x60015F9")]
		[Cpp2IlInjected.Address(RVA = "0x13A0EA4", Offset = "0x13A0EA4", VA = "0x13A0EA4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60015FA")]
		[Cpp2IlInjected.Address(RVA = "0x13A0EAC", Offset = "0x13A0EAC", VA = "0x13A0EAC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public IntPtr MonitorHandle
	{
		[Cpp2IlInjected.Token(Token = "0x60015FB")]
		[Cpp2IlInjected.Address(RVA = "0x13A0EB4", Offset = "0x13A0EB4", VA = "0x13A0EB4")]
		[CompilerGenerated]
		get
		{
			return default(IntPtr);
		}
		[Cpp2IlInjected.Token(Token = "0x60015FC")]
		[Cpp2IlInjected.Address(RVA = "0x13A0EBC", Offset = "0x13A0EBC", VA = "0x13A0EBC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public int Revision
	{
		[Cpp2IlInjected.Token(Token = "0x60015FD")]
		[Cpp2IlInjected.Address(RVA = "0x13A0EC4", Offset = "0x13A0EC4", VA = "0x13A0EC4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60015FE")]
		[Cpp2IlInjected.Address(RVA = "0x13A0ECC", Offset = "0x13A0ECC", VA = "0x13A0ECC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public int SubSystemId
	{
		[Cpp2IlInjected.Token(Token = "0x60015FF")]
		[Cpp2IlInjected.Address(RVA = "0x13A0ED4", Offset = "0x13A0ED4", VA = "0x13A0ED4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001600")]
		[Cpp2IlInjected.Address(RVA = "0x13A0EDC", Offset = "0x13A0EDC", VA = "0x13A0EDC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public DisplayModeCollection SupportedDisplayModes
	{
		[Cpp2IlInjected.Token(Token = "0x6001601")]
		[Cpp2IlInjected.Address(RVA = "0x13A0EE4", Offset = "0x13A0EE4", VA = "0x13A0EE4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public DisplayMode CurrentDisplayMode
	{
		[Cpp2IlInjected.Token(Token = "0x6001602")]
		[Cpp2IlInjected.Address(RVA = "0x13A0EEC", Offset = "0x13A0EEC", VA = "0x13A0EEC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public bool IsWideScreen
	{
		[Cpp2IlInjected.Token(Token = "0x6001603")]
		[Cpp2IlInjected.Address(RVA = "0x13A0EF4", Offset = "0x13A0EF4", VA = "0x13A0EF4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60015E8")]
	[Cpp2IlInjected.Address(RVA = "0x13A05E0", Offset = "0x13A05E0", VA = "0x13A05E0")]
	static GraphicsAdapter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001604")]
	[Cpp2IlInjected.Address(RVA = "0x13A0F28", Offset = "0x13A0F28", VA = "0x13A0F28")]
	public bool QueryRenderTargetFormat(GraphicsProfile graphicsProfile, SurfaceFormat format, DepthFormat depthFormat, int multiSampleCount, out SurfaceFormat selectedFormat, out DepthFormat selectedDepthFormat, out int selectedMultiSampleCount)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001605")]
	[Cpp2IlInjected.Address(RVA = "0x13A0FA4", Offset = "0x13A0FA4", VA = "0x13A0FA4")]
	public bool IsProfileSupported(GraphicsProfile graphicsProfile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001606")]
	[Cpp2IlInjected.Address(RVA = "0x13A0FAC", Offset = "0x13A0FAC", VA = "0x13A0FAC")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001607")]
	[Cpp2IlInjected.Address(RVA = "0x13A0678", Offset = "0x13A0678", VA = "0x13A0678")]
	private static void PlatformInitializeAdapters(out ReadOnlyCollection<GraphicsAdapter> adaptersResults)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001608")]
	[Cpp2IlInjected.Address(RVA = "0x13A0FB0", Offset = "0x13A0FB0", VA = "0x13A0FB0")]
	public GraphicsAdapter()
	{
	}
}
