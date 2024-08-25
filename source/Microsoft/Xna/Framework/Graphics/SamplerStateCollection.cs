using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x200038B")]
	public sealed class SamplerStateCollection
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600180A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB470C", Offset = "0xAB470C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Dirty()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002643")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly GraphicsDevice _graphicsDevice;

		[global::Cpp2ILInjected.Token(Token = "0x4002644")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly SamplerState _samplerStateAnisotropicClamp;

		[global::Cpp2ILInjected.Token(Token = "0x4002645")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly SamplerState _samplerStateAnisotropicWrap;

		[global::Cpp2ILInjected.Token(Token = "0x4002646")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly SamplerState _samplerStateLinearClamp;

		[global::Cpp2ILInjected.Token(Token = "0x4002647")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly SamplerState _samplerStateLinearWrap;

		[global::Cpp2ILInjected.Token(Token = "0x4002648")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly SamplerState _samplerStatePointClamp;

		[global::Cpp2ILInjected.Token(Token = "0x4002649")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly SamplerState _samplerStatePointWrap;

		[global::Cpp2ILInjected.Token(Token = "0x400264A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly SamplerState[] _samplers;

		[global::Cpp2ILInjected.Token(Token = "0x400264B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly SamplerState[] _actualSamplers;

		[global::Cpp2ILInjected.Token(Token = "0x400264C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly bool _applyToVertexStage;
	}
}
