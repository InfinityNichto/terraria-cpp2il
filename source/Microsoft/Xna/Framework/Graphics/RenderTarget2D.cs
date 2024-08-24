using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002BB RID: 699
	[global::Cpp2ILInjected.Token(Token = "0x2000386")]
	public class RenderTarget2D : Texture2D, IRenderTarget
	{
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00025DD2 File Offset: 0x00023FD2
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x00025DD5 File Offset: 0x00023FD5
		[global::Cpp2ILInjected.Token(Token = "0x17000303")]
		public DepthFormat DepthStencilFormat
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017E8")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3DCC", Offset = "0xAB3DCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017E9")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3DD4", Offset = "0xAB3DD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00025DD8 File Offset: 0x00023FD8
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x00025DDB File Offset: 0x00023FDB
		[global::Cpp2ILInjected.Token(Token = "0x17000304")]
		public int MultiSampleCount
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017EA")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3DDC", Offset = "0xAB3DDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017EB")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3DE4", Offset = "0xAB3DE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x00025DDE File Offset: 0x00023FDE
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x00025DE1 File Offset: 0x00023FE1
		[global::Cpp2ILInjected.Token(Token = "0x17000305")]
		public RenderTargetUsage RenderTargetUsage
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017EC")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3DEC", Offset = "0xAB3DEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017ED")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3DF4", Offset = "0xAB3DF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00025DE4 File Offset: 0x00023FE4
		[global::Cpp2ILInjected.Token(Token = "0x17000306")]
		public bool IsContentLost
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017EE")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3DFC", Offset = "0xAB3DFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600167F RID: 5759 RVA: 0x00025DE7 File Offset: 0x00023FE7
		// (remove) Token: 0x06001680 RID: 5760 RVA: 0x00025DEA File Offset: 0x00023FEA
		[global::Cpp2ILInjected.Token(Token = "0x1400001E")]
		public event EventHandler<EventArgs> ContentLost
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017EF")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3E04", Offset = "0xAB3E04", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017F0")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3EB4", Offset = "0xAB3EB4", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00025DED File Offset: 0x00023FED
		[global::Cpp2ILInjected.Token(Token = "0x60017F1")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3F64", Offset = "0xAB3F64", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool SuppressEventHandlerWarningsUntilEventsAreProperlyImplemented()
		{
			throw null;
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00025DF0 File Offset: 0x00023FF0
		[global::Cpp2ILInjected.Token(Token = "0x60017F2")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3F74", Offset = "0xAB3F74", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, bool shared, int arraySize)
		{
			throw null;
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00025DF3 File Offset: 0x00023FF3
		[global::Cpp2ILInjected.Token(Token = "0x60017F3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3FC8", Offset = "0xAB3FC8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, bool shared)
		{
			throw null;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00025DF6 File Offset: 0x00023FF6
		[global::Cpp2ILInjected.Token(Token = "0x60017F4")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB401C", Offset = "0xAB401C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage)
		{
			throw null;
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00025DF9 File Offset: 0x00023FF9
		[global::Cpp2ILInjected.Token(Token = "0x60017F5")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB406C", Offset = "0xAB406C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat)
		{
			throw null;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00025DFC File Offset: 0x00023FFC
		[global::Cpp2ILInjected.Token(Token = "0x60017F6")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB40B4", Offset = "0xAB40B4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public RenderTarget2D(GraphicsDevice device, int width, int height)
		{
			throw null;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00025DFF File Offset: 0x00023FFF
		[global::Cpp2ILInjected.Token(Token = "0x60017F7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB40F4", Offset = "0xAB40F4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType)
		}, ReturnType = typeof(void))]
		protected RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat format, DepthFormat depthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, Texture2D.SurfaceType surfaceType)
		{
			throw null;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00025E02 File Offset: 0x00024002
		[global::Cpp2ILInjected.Token(Token = "0x60017F8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4138", Offset = "0xAB4138", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "GraphicsDeviceResetting", ReturnType = typeof(void))]
		protected internal override void GraphicsDeviceResetting()
		{
			throw null;
		}

		// Token: 0x04001FEF RID: 8175
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002635")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private DepthFormat <DepthStencilFormat>k__BackingField;

		// Token: 0x04001FF0 RID: 8176
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002636")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		private int <MultiSampleCount>k__BackingField;

		// Token: 0x04001FF1 RID: 8177
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002637")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private RenderTargetUsage <RenderTargetUsage>k__BackingField;

		// Token: 0x04001FF2 RID: 8178
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002638")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private EventHandler<EventArgs> ContentLost;
	}
}
