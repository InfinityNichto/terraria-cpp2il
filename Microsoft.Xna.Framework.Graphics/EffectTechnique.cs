using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002A6")]
public class EffectTechnique
{
	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	public EffectPassCollection Passes
	{
		[Cpp2IlInjected.Token(Token = "0x6001595")]
		[Cpp2IlInjected.Address(RVA = "0x139BDE0", Offset = "0x139BDE0", VA = "0x139BDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001596")]
		[Cpp2IlInjected.Address(RVA = "0x139BDE8", Offset = "0x139BDE8", VA = "0x139BDE8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000280")]
	public string Name
	{
		[Cpp2IlInjected.Token(Token = "0x6001597")]
		[Cpp2IlInjected.Address(RVA = "0x139BDF0", Offset = "0x139BDF0", VA = "0x139BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001598")]
		[Cpp2IlInjected.Address(RVA = "0x139BDF8", Offset = "0x139BDF8", VA = "0x139BDF8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001599")]
	[Cpp2IlInjected.Address(RVA = "0x139BE00", Offset = "0x139BE00", VA = "0x139BE00")]
	internal EffectTechnique(Effect effect, EffectTechnique cloneSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600159A")]
	[Cpp2IlInjected.Address(RVA = "0x139BE38", Offset = "0x139BE38", VA = "0x139BE38")]
	internal EffectTechnique(Effect effect, string name, EffectPassCollection passes)
	{
	}
}
