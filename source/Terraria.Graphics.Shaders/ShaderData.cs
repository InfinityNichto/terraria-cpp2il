using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders;

[Cpp2IlInjected.Token(Token = "0x20004F4")]
public class ShaderData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006780")]
	private readonly Ref<Effect> _shader;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006781")]
	protected string _passName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006782")]
	public EffectPass _effectPass;

	[Cpp2IlInjected.Token(Token = "0x170006E9")]
	public Effect Shader
	{
		[Cpp2IlInjected.Token(Token = "0x600376D")]
		[Cpp2IlInjected.Address(RVA = "0x1246F00", Offset = "0x1246F00", VA = "0x1246F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600376E")]
	[Cpp2IlInjected.Address(RVA = "0x1246ED8", Offset = "0x1246ED8", VA = "0x1246ED8")]
	public ShaderData(Ref<Effect> shader, string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600376F")]
	[Cpp2IlInjected.Address(RVA = "0x124B434", Offset = "0x124B434", VA = "0x124B434", Slot = "4")]
	public virtual void Apply(Entity entity, [Optional] DrawData? drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003770")]
	[Cpp2IlInjected.Address(RVA = "0x1249A20", Offset = "0x1249A20", VA = "0x1249A20", Slot = "5")]
	public virtual void Apply()
	{
	}
}
