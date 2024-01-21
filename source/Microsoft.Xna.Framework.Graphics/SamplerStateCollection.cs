using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002C3")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x384E10", Offset = "0x384E10")]
public sealed class SamplerStateCollection
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002003")]
	private readonly GraphicsDevice _graphicsDevice;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002004")]
	private readonly SamplerState _samplerStateAnisotropicClamp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002005")]
	private readonly SamplerState _samplerStateAnisotropicWrap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002006")]
	private readonly SamplerState _samplerStateLinearClamp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002007")]
	private readonly SamplerState _samplerStateLinearWrap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002008")]
	private readonly SamplerState _samplerStatePointClamp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002009")]
	private readonly SamplerState _samplerStatePointWrap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400200A")]
	private readonly SamplerState[] _samplers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400200B")]
	private readonly SamplerState[] _actualSamplers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400200C")]
	private readonly bool _applyToVertexStage;

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public SamplerState Item
	{
		[Cpp2IlInjected.Token(Token = "0x60016CF")]
		[Cpp2IlInjected.Address(RVA = "0x1593CC8", Offset = "0x1593CC8", VA = "0x1593CC8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60016D0")]
		[Cpp2IlInjected.Address(RVA = "0x1593CD8", Offset = "0x1593CD8", VA = "0x1593CD8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60016CE")]
	[Cpp2IlInjected.Address(RVA = "0x1593A6C", Offset = "0x1593A6C", VA = "0x1593A6C")]
	internal SamplerStateCollection(GraphicsDevice device, int maxSamplers, bool applyToVertexStage)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016D1")]
	[Cpp2IlInjected.Address(RVA = "0x1593BA8", Offset = "0x1593BA8", VA = "0x1593BA8")]
	internal void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016D2")]
	[Cpp2IlInjected.Address(RVA = "0x1593F5C", Offset = "0x1593F5C", VA = "0x1593F5C")]
	internal void Dirty()
	{
	}
}
