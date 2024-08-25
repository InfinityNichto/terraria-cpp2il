using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000377")]
	public sealed class GraphicsAdapter
	{
		[global::Cpp2ILInjected.Token(Token = "0x170002BB")]
		public static int VirtualScreenSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600171E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0660", Offset = "0xAB0660", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600171F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB06B8", Offset = "0xAB06B8", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenWidth", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenHeight", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DisplayMode), Member = "UpdateSize", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001720")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB0800", Offset = "0xAB0800", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsAdapter), Member = "PlatformInitializeAdapters", MemberParameters = new object[] { typeof(ref ReadOnlyCollection<GraphicsAdapter>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static GraphicsAdapter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002BC")]
		public static GraphicsAdapter DefaultAdapter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001721")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0C58", Offset = "0xAB0C58", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "CacheSupportedDisplaySizes", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002BD")]
		public static ReadOnlyCollection<GraphicsAdapter> Adapters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001722")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0CCC", Offset = "0xAB0CCC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002BE")]
		public static bool UseReferenceDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001723")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0D24", Offset = "0xAB0D24", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001724")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0DB4", Offset = "0xAB0DB4", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002BF")]
		public static GraphicsAdapter.DriverType UseDriverType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001725")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0E44", Offset = "0xAB0E44", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001726")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0E9C", Offset = "0xAB0E9C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C0")]
		public static bool UseDebugLayers
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001727")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0EF8", Offset = "0xAB0EF8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001728")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0F50", Offset = "0xAB0F50", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C1")]
		public string Description
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001729")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0FAC", Offset = "0xAB0FAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600172A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0FB4", Offset = "0xAB0FB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C2")]
		public int DeviceId
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600172B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0FBC", Offset = "0xAB0FBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600172C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0FC4", Offset = "0xAB0FC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C3")]
		public string DeviceName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600172D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0FCC", Offset = "0xAB0FCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600172E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0FD4", Offset = "0xAB0FD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C4")]
		public int VendorId
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600172F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0FDC", Offset = "0xAB0FDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001730")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0FE4", Offset = "0xAB0FE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C5")]
		public bool IsDefaultAdapter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001731")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0FEC", Offset = "0xAB0FEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001732")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0FF4", Offset = "0xAB0FF4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C6")]
		public IntPtr MonitorHandle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001733")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1000", Offset = "0xAB1000", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001734")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1008", Offset = "0xAB1008", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C7")]
		public int Revision
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001735")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1010", Offset = "0xAB1010", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001736")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1018", Offset = "0xAB1018", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C8")]
		public int SubSystemId
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001737")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1020", Offset = "0xAB1020", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001738")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1028", Offset = "0xAB1028", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C9")]
		public DisplayModeCollection SupportedDisplayModes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001739")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1030", Offset = "0xAB1030", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002CA")]
		public DisplayMode CurrentDisplayMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600173A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1038", Offset = "0xAB1038", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002CB")]
		public bool IsWideScreen
		{
			[global::Cpp2ILInjected.Token(Token = "0x600173B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1040", Offset = "0xAB1040", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DisplayMode), Member = "get_AspectRatio", ReturnType = typeof(float))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600173C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB1068", Offset = "0xAB1068", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool QueryRenderTargetFormat(GraphicsProfile graphicsProfile, SurfaceFormat format, DepthFormat depthFormat, int multiSampleCount, out SurfaceFormat selectedFormat, out DepthFormat selectedDepthFormat, out int selectedMultiSampleCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600173D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB10E4", Offset = "0xAB10E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsProfileSupported(GraphicsProfile graphicsProfile)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600173E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB10EC", Offset = "0xAB10EC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600173F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB0884", Offset = "0xAB0884", Length = "0x3D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DisplayMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(SurfaceFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DisplayModeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(List<DisplayMode>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private static void PlatformInitializeAdapters(out ReadOnlyCollection<GraphicsAdapter> adaptersResults)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001740")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB10F0", Offset = "0xAB10F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GraphicsAdapter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40025BB")]
		private static int _virtualScreenSize;

		[global::Cpp2ILInjected.Token(Token = "0x40025BC")]
		private static readonly ReadOnlyCollection<GraphicsAdapter> _adapters;

		[global::Cpp2ILInjected.Token(Token = "0x40025BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DisplayModeCollection _supportedDisplayModes;

		[global::Cpp2ILInjected.Token(Token = "0x40025BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private DisplayMode _currentDisplayMode;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025BF")]
		private static GraphicsAdapter.DriverType <UseDriverType>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025C0")]
		private static bool <UseDebugLayers>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string <Description>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int <DeviceId>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string <DeviceName>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int <VendorId>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private bool <IsDefaultAdapter>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private IntPtr <MonitorHandle>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int <Revision>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int <SubSystemId>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x2000378")]
		public enum DriverType
		{
			[global::Cpp2ILInjected.Token(Token = "0x40025CA")]
			Hardware,
			[global::Cpp2ILInjected.Token(Token = "0x40025CB")]
			Reference,
			[global::Cpp2ILInjected.Token(Token = "0x40025CC")]
			FastSoftware
		}
	}
}
