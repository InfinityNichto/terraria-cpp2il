using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002A3")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x384D54", Offset = "0x384D54")]
public class EffectParameterCollection : IEnumerable<EffectParameter>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x4001EFC")]
	internal static readonly EffectParameterCollection Empty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001EFD")]
	private readonly EffectParameter[] _parameters;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001EFE")]
	private readonly Dictionary<string, int> _indexLookup;

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600157F")]
		[Cpp2IlInjected.Address(RVA = "0x139B36C", Offset = "0x139B36C", VA = "0x139B36C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public EffectParameter Item
	{
		[Cpp2IlInjected.Token(Token = "0x6001580")]
		[Cpp2IlInjected.Address(RVA = "0x139B378", Offset = "0x139B378", VA = "0x139B378")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public EffectParameter Item
	{
		[Cpp2IlInjected.Token(Token = "0x6001581")]
		[Cpp2IlInjected.Address(RVA = "0x139B388", Offset = "0x139B388", VA = "0x139B388")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600157C")]
	[Cpp2IlInjected.Address(RVA = "0x139B0F0", Offset = "0x139B0F0", VA = "0x139B0F0")]
	internal EffectParameterCollection(EffectParameter[] parameters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600157D")]
	[Cpp2IlInjected.Address(RVA = "0x139B1E8", Offset = "0x139B1E8", VA = "0x139B1E8")]
	private EffectParameterCollection(EffectParameter[] parameters, Dictionary<string, int> indexLookup)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600157E")]
	[Cpp2IlInjected.Address(RVA = "0x139B210", Offset = "0x139B210", VA = "0x139B210")]
	internal EffectParameterCollection Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001582")]
	[Cpp2IlInjected.Address(RVA = "0x139B418", Offset = "0x139B418", VA = "0x139B418", Slot = "4")]
	public IEnumerator<EffectParameter> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001583")]
	[Cpp2IlInjected.Address(RVA = "0x139B4D8", Offset = "0x139B4D8", VA = "0x139B4D8", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
