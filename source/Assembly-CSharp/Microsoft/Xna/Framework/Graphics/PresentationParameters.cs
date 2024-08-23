using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002B9 RID: 697
	[global::Cpp2ILInjected.Token(Token = "0x2000384")]
	public class PresentationParameters
	{
		// Token: 0x0600165E RID: 5726 RVA: 0x00025D84 File Offset: 0x00023F84
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

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00025D87 File Offset: 0x00023F87
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00025D8A File Offset: 0x00023F8A
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

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00025D8D File Offset: 0x00023F8D
		// (set) Token: 0x06001662 RID: 5730 RVA: 0x00025D90 File Offset: 0x00023F90
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

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x00025D93 File Offset: 0x00023F93
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x00025D96 File Offset: 0x00023F96
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

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00025D99 File Offset: 0x00023F99
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00025D9C File Offset: 0x00023F9C
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x00025D9F File Offset: 0x00023F9F
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

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x00025DA2 File Offset: 0x00023FA2
		// (set) Token: 0x06001669 RID: 5737 RVA: 0x00025DA5 File Offset: 0x00023FA5
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

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x00025DA8 File Offset: 0x00023FA8
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x00025DAB File Offset: 0x00023FAB
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00025DAE File Offset: 0x00023FAE
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00025DB1 File Offset: 0x00023FB1
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

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00025DB4 File Offset: 0x00023FB4
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x00025DB7 File Offset: 0x00023FB7
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x00025DBA File Offset: 0x00023FBA
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x00025DBD File Offset: 0x00023FBD
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

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00025DC0 File Offset: 0x00023FC0
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x00025DC3 File Offset: 0x00023FC3
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

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00025DC6 File Offset: 0x00023FC6
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x00025DC9 File Offset: 0x00023FC9
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

		// Token: 0x06001676 RID: 5750 RVA: 0x00025DCC File Offset: 0x00023FCC
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

		// Token: 0x06001677 RID: 5751 RVA: 0x00025DCF File Offset: 0x00023FCF
		[global::Cpp2ILInjected.Token(Token = "0x60017E7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3D40", Offset = "0xAB3D40", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PresentationParameters), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PresentationParameters Clone()
		{
			throw null;
		}

		// Token: 0x04001FDE RID: 8158
		[global::Cpp2ILInjected.Token(Token = "0x4002624")]
		public const int DefaultPresentRate = 60;

		// Token: 0x04001FDF RID: 8159
		[global::Cpp2ILInjected.Token(Token = "0x4002625")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DepthFormat depthStencilFormat;

		// Token: 0x04001FE0 RID: 8160
		[global::Cpp2ILInjected.Token(Token = "0x4002626")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private SurfaceFormat backBufferFormat;

		// Token: 0x04001FE1 RID: 8161
		[global::Cpp2ILInjected.Token(Token = "0x4002627")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int backBufferHeight;

		// Token: 0x04001FE2 RID: 8162
		[global::Cpp2ILInjected.Token(Token = "0x4002628")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int backBufferWidth;

		// Token: 0x04001FE3 RID: 8163
		[global::Cpp2ILInjected.Token(Token = "0x4002629")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IntPtr deviceWindowHandle;

		// Token: 0x04001FE4 RID: 8164
		[global::Cpp2ILInjected.Token(Token = "0x400262A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int multiSampleCount;

		// Token: 0x04001FE5 RID: 8165
		[global::Cpp2ILInjected.Token(Token = "0x400262B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool isFullScreen;

		// Token: 0x04001FE6 RID: 8166
		[global::Cpp2ILInjected.Token(Token = "0x400262C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
		private bool hardwareModeSwitch;

		// Token: 0x04001FE7 RID: 8167
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400262D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private PresentInterval <PresentationInterval>k__BackingField;

		// Token: 0x04001FE8 RID: 8168
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400262E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private DisplayOrientation <DisplayOrientation>k__BackingField;

		// Token: 0x04001FE9 RID: 8169
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400262F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private RenderTargetUsage <RenderTargetUsage>k__BackingField;
	}
}
