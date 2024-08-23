using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Graphics;
using Terraria;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002B4 RID: 692
	[global::Cpp2ILInjected.Token(Token = "0x200037F")]
	public abstract class GraphicsResource
	{
		// Token: 0x06001642 RID: 5698 RVA: 0x00025D4E File Offset: 0x00023F4E
		[global::Cpp2ILInjected.Token(Token = "0x60017B2")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB38A0", Offset = "0xAB38A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Effect), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Effect), Member = ".ctor", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Effect), Member = "Clone", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PixelShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = ".ctor", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DepthStencilState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DepthStencilState), Member = ".ctor", MemberParameters = new object[] { typeof(DepthStencilState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RasterizerState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RasterizerState), Member = ".ctor", MemberParameters = new object[] { typeof(RasterizerState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SamplerState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SamplerState), Member = ".ctor", MemberParameters = new object[] { typeof(SamplerState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal GraphicsResource()
		{
			throw null;
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00025D51 File Offset: 0x00023F51
		[global::Cpp2ILInjected.Token(Token = "0x60017B3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB38A8", Offset = "0xAB38A8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ReleaseTargets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicDebugDrawer), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00025D54 File Offset: 0x00023F54
		[global::Cpp2ILInjected.Token(Token = "0x60017B4")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB38AC", Offset = "0xAB38AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected internal virtual void GraphicsDeviceResetting()
		{
			throw null;
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06001645 RID: 5701 RVA: 0x00025D57 File Offset: 0x00023F57
		// (remove) Token: 0x06001646 RID: 5702 RVA: 0x00025D5A File Offset: 0x00023F5A
		[global::Cpp2ILInjected.Token(Token = "0x14000019")]
		public event EventHandler<EventArgs> Disposing
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017B5")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB38B0", Offset = "0xAB38B0", Length = "0xB0")]
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
			[global::Cpp2ILInjected.Token(Token = "0x60017B6")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3960", Offset = "0xAB3960", Length = "0xB0")]
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

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x00025D5D File Offset: 0x00023F5D
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x00025D60 File Offset: 0x00023F60
		[global::Cpp2ILInjected.Token(Token = "0x170002F1")]
		public GraphicsDevice GraphicsDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017B7")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3A10", Offset = "0xAB3A10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017B8")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3A18", Offset = "0xAB3A18", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Effect), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Effect), Member = ".ctor", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Effect), Member = "Clone", ReturnType = typeof(Effect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PixelShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlendState), Member = "BindToGraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DepthStencilState), Member = "BindToGraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RasterizerState), Member = "BindToGraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SamplerState), Member = "BindToGraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x00025D63 File Offset: 0x00023F63
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x00025D66 File Offset: 0x00023F66
		[global::Cpp2ILInjected.Token(Token = "0x170002F2")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017B9")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3A2C", Offset = "0xAB3A2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017BA")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3A34", Offset = "0xAB3A34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x00025D69 File Offset: 0x00023F69
		// (set) Token: 0x0600164C RID: 5708 RVA: 0x00025D6C File Offset: 0x00023F6C
		[global::Cpp2ILInjected.Token(Token = "0x170002F3")]
		public object Tag
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017BB")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3A3C", Offset = "0xAB3A3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017BC")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3A44", Offset = "0xAB3A44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00025D6F File Offset: 0x00023F6F
		[global::Cpp2ILInjected.Token(Token = "0x60017BD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3A4C", Offset = "0xAB3A4C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04001FD9 RID: 8153
		[global::Cpp2ILInjected.Token(Token = "0x400261F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private GraphicsDevice graphicsDevice;

		// Token: 0x04001FDA RID: 8154
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002620")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> Disposing;

		// Token: 0x04001FDB RID: 8155
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002621")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string <Name>k__BackingField;

		// Token: 0x04001FDC RID: 8156
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002622")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object <Tag>k__BackingField;
	}
}
