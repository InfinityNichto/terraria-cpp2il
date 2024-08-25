using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000384")]
	public class PresentationParameters
	{
		[global::Cpp2ILInjected.Token(Token = "0x60017CE")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB1EBC", Offset = "0xAB1EBC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PresentationParameters), Member = "Clone", ReturnType = typeof(PresentationParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PresentationParameters), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PresentationParameters()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F7")]
		public SurfaceFormat BackBufferFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017CF")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3C54", Offset = "0xAB3C54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017D0")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3C5C", Offset = "0xAB3C5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F8")]
		public int BackBufferHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D1")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3C64", Offset = "0xAB3C64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017D2")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3C6C", Offset = "0xAB3C6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F9")]
		public int BackBufferWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D3")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3C74", Offset = "0xAB3C74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017D4")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3C7C", Offset = "0xAB3C7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FA")]
		public Rectangle Bounds
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D5")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3C84", Offset = "0xAB3C84", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FB")]
		public IntPtr DeviceWindowHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D6")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3CB8", Offset = "0xAB3CB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017D7")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3CC0", Offset = "0xAB3CC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FC")]
		public DepthFormat DepthStencilFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D8")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3CC8", Offset = "0xAB3CC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017D9")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3CD0", Offset = "0xAB3CD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FD")]
		public bool IsFullScreen
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017DA")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3CD8", Offset = "0xAB3CD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017DB")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3CE0", Offset = "0xAB3CE0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FE")]
		public bool HardwareModeSwitch
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017DC")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3CEC", Offset = "0xAB3CEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017DD")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3CF4", Offset = "0xAB3CF4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FF")]
		public int MultiSampleCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017DE")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3D00", Offset = "0xAB3D00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017DF")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3D08", Offset = "0xAB3D08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000300")]
		public PresentInterval PresentationInterval
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017E0")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3D10", Offset = "0xAB3D10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017E1")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3D18", Offset = "0xAB3D18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000301")]
		public DisplayOrientation DisplayOrientation
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017E2")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3D20", Offset = "0xAB3D20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017E3")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3D28", Offset = "0xAB3D28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000302")]
		public RenderTargetUsage RenderTargetUsage
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017E4")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3D30", Offset = "0xAB3D30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017E5")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3D38", Offset = "0xAB3D38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E6")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3BC4", Offset = "0xAB3BC4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PresentationParameters), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3D40", Offset = "0xAB3D40", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PresentationParameters), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PresentationParameters Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002624")]
		public const int DefaultPresentRate = 60;

		[global::Cpp2ILInjected.Token(Token = "0x4002625")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DepthFormat depthStencilFormat;

		[global::Cpp2ILInjected.Token(Token = "0x4002626")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private SurfaceFormat backBufferFormat;

		[global::Cpp2ILInjected.Token(Token = "0x4002627")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int backBufferHeight;

		[global::Cpp2ILInjected.Token(Token = "0x4002628")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int backBufferWidth;

		[global::Cpp2ILInjected.Token(Token = "0x4002629")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IntPtr deviceWindowHandle;

		[global::Cpp2ILInjected.Token(Token = "0x400262A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int multiSampleCount;

		[global::Cpp2ILInjected.Token(Token = "0x400262B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool isFullScreen;

		[global::Cpp2ILInjected.Token(Token = "0x400262C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
		private bool hardwareModeSwitch;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400262D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private PresentInterval <PresentationInterval>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400262E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private DisplayOrientation <DisplayOrientation>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400262F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private RenderTargetUsage <RenderTargetUsage>k__BackingField;
	}
}
