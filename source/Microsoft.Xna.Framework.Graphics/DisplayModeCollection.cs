using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002A0")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x384CEC", Offset = "0x384CEC")]
public class DisplayModeCollection : IEnumerable<DisplayMode>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001EF6")]
	private readonly List<DisplayMode> _modes;

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public IEnumerable<DisplayMode> Item
	{
		[Cpp2IlInjected.Token(Token = "0x6001560")]
		[Cpp2IlInjected.Address(RVA = "0x139A8F0", Offset = "0x139A8F0", VA = "0x139A8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001561")]
	[Cpp2IlInjected.Address(RVA = "0x139AA4C", Offset = "0x139AA4C", VA = "0x139AA4C", Slot = "4")]
	public IEnumerator<DisplayMode> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001562")]
	[Cpp2IlInjected.Address(RVA = "0x139AAD8", Offset = "0x139AAD8", VA = "0x139AAD8", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001563")]
	[Cpp2IlInjected.Address(RVA = "0x139AB64", Offset = "0x139AB64", VA = "0x139AB64")]
	internal DisplayModeCollection(List<DisplayMode> modes)
	{
	}
}
