using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002C0 RID: 704
	[global::Cpp2ILInjected.Token(Token = "0x200038B")]
	public sealed class SamplerStateCollection
	{
		// Token: 0x06001696 RID: 5782 RVA: 0x00025E2C File Offset: 0x0002402C
		[global::Cpp2ILInjected.Token(Token = "0x6001806")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB42C8", Offset = "0xAB42C8", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SamplerState), Member = "Clone", ReturnType = typeof(SamplerState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal SamplerStateCollection(GraphicsDevice device, int maxSamplers, bool applyToVertexStage)
		{
			throw null;
		}

		// Token: 0x170002E3 RID: 739
		[global::Cpp2ILInjected.Token(Token = "0x1700030D")]
		public SamplerState this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001807")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB44FC", Offset = "0xAB44FC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001808")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB450C", Offset = "0xAB450C", Length = "0x200")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SamplerState), Member = "BindToGraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00025E35 File Offset: 0x00024035
		[global::Cpp2ILInjected.Token(Token = "0x6001809")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4410", Offset = "0xAB4410", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SamplerState), Member = "BindToGraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void Clear()
		{
			throw null;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00025E38 File Offset: 0x00024038
		[global::Cpp2ILInjected.Token(Token = "0x600180A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB470C", Offset = "0xAB470C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Dirty()
		{
			throw null;
		}

		// Token: 0x04001FFD RID: 8189
		[global::Cpp2ILInjected.Token(Token = "0x4002643")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly GraphicsDevice _graphicsDevice;

		// Token: 0x04001FFE RID: 8190
		[global::Cpp2ILInjected.Token(Token = "0x4002644")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly SamplerState _samplerStateAnisotropicClamp;

		// Token: 0x04001FFF RID: 8191
		[global::Cpp2ILInjected.Token(Token = "0x4002645")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly SamplerState _samplerStateAnisotropicWrap;

		// Token: 0x04002000 RID: 8192
		[global::Cpp2ILInjected.Token(Token = "0x4002646")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly SamplerState _samplerStateLinearClamp;

		// Token: 0x04002001 RID: 8193
		[global::Cpp2ILInjected.Token(Token = "0x4002647")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly SamplerState _samplerStateLinearWrap;

		// Token: 0x04002002 RID: 8194
		[global::Cpp2ILInjected.Token(Token = "0x4002648")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly SamplerState _samplerStatePointClamp;

		// Token: 0x04002003 RID: 8195
		[global::Cpp2ILInjected.Token(Token = "0x4002649")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly SamplerState _samplerStatePointWrap;

		// Token: 0x04002004 RID: 8196
		[global::Cpp2ILInjected.Token(Token = "0x400264A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly SamplerState[] _samplers;

		// Token: 0x04002005 RID: 8197
		[global::Cpp2ILInjected.Token(Token = "0x400264B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly SamplerState[] _actualSamplers;

		// Token: 0x04002006 RID: 8198
		[global::Cpp2ILInjected.Token(Token = "0x400264C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly bool _applyToVertexStage;
	}
}
