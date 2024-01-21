using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002A1")]
public class Effect : GraphicsResource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001EF9")]
	private readonly bool _isClone;

	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public EffectParameterCollection Parameters
	{
		[Cpp2IlInjected.Token(Token = "0x6001564")]
		[Cpp2IlInjected.Address(RVA = "0x139AD88", Offset = "0x139AD88", VA = "0x139AD88")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001565")]
		[Cpp2IlInjected.Address(RVA = "0x139AD90", Offset = "0x139AD90", VA = "0x139AD90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public EffectTechnique CurrentTechnique
	{
		[Cpp2IlInjected.Token(Token = "0x6001566")]
		[Cpp2IlInjected.Address(RVA = "0x139AD98", Offset = "0x139AD98", VA = "0x139AD98")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001567")]
		[Cpp2IlInjected.Address(RVA = "0x139ADA0", Offset = "0x139ADA0", VA = "0x139ADA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001568")]
	[Cpp2IlInjected.Address(RVA = "0x139ADA8", Offset = "0x139ADA8", VA = "0x139ADA8")]
	internal Effect(GraphicsDevice graphicsDevice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001569")]
	[Cpp2IlInjected.Address(RVA = "0x139ADD0", Offset = "0x139ADD0", VA = "0x139ADD0")]
	protected Effect(Effect cloneSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600156A")]
	[Cpp2IlInjected.Address(RVA = "0x139AE04", Offset = "0x139AE04", VA = "0x139AE04", Slot = "5")]
	public virtual void ApplyValuesToMaterial(EffectPass pass, Material material)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600156B")]
	[Cpp2IlInjected.Address(RVA = "0x139AE00", Offset = "0x139AE00", VA = "0x139AE00")]
	private void Clone(Effect cloneSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600156C")]
	[Cpp2IlInjected.Address(RVA = "0x139AE08", Offset = "0x139AE08", VA = "0x139AE08", Slot = "6")]
	public virtual Effect Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600156D")]
	[Cpp2IlInjected.Address(RVA = "0x139AE88", Offset = "0x139AE88", VA = "0x139AE88", Slot = "7")]
	protected internal virtual void OnApply()
	{
	}
}
