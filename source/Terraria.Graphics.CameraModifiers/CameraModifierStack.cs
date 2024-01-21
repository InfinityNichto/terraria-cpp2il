using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers;

[Cpp2IlInjected.Token(Token = "0x200050C")]
public class CameraModifierStack
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006806")]
	private List<ICameraModifier> _modifiers;

	[Cpp2IlInjected.Token(Token = "0x6003807")]
	[Cpp2IlInjected.Address(RVA = "0x1312354", Offset = "0x1312354", VA = "0x1312354")]
	public void Add(ICameraModifier modifier)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003808")]
	[Cpp2IlInjected.Address(RVA = "0x13123C4", Offset = "0x13123C4", VA = "0x13123C4")]
	private void RemoveIdenticalModifiers(ICameraModifier modifier)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003809")]
	[Cpp2IlInjected.Address(RVA = "0x1312588", Offset = "0x1312588", VA = "0x1312588")]
	public void ApplyTo(ref Vector2 cameraPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600380A")]
	[Cpp2IlInjected.Address(RVA = "0x13126E0", Offset = "0x13126E0", VA = "0x13126E0")]
	private void ClearFinishedModifiers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600380B")]
	[Cpp2IlInjected.Address(RVA = "0x1312810", Offset = "0x1312810", VA = "0x1312810")]
	public CameraModifierStack()
	{
	}
}
