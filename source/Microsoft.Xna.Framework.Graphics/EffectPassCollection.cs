using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002A5")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x384D88", Offset = "0x384D88")]
public class EffectPassCollection : IEnumerable<EffectPass>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200081A")]
	public struct Enumerator : IEnumerator<EffectPass>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007D8F")]
		private readonly EffectPass[] _array;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007D90")]
		private int _index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007D91")]
		private EffectPass _current;

		[Cpp2IlInjected.Token(Token = "0x1700084A")]
		public EffectPass Current
		{
			[Cpp2IlInjected.Token(Token = "0x600496D")]
			[Cpp2IlInjected.Address(RVA = "0x39EA3C", Offset = "0x39EA3C", VA = "0x39EA3C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600496E")]
			[Cpp2IlInjected.Address(RVA = "0x39EA44", Offset = "0x39EA44", VA = "0x39EA44", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600496B")]
		[Cpp2IlInjected.Address(RVA = "0x39E9E0", Offset = "0x39E9E0", VA = "0x39E9E0")]
		internal Enumerator(EffectPass[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600496C")]
		[Cpp2IlInjected.Address(RVA = "0x39E9F4", Offset = "0x39E9F4", VA = "0x39E9F4", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600496F")]
		[Cpp2IlInjected.Address(RVA = "0x39EA4C", Offset = "0x39EA4C", VA = "0x39EA4C", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004970")]
		[Cpp2IlInjected.Address(RVA = "0x39EA5C", Offset = "0x39EA5C", VA = "0x39EA5C", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001F07")]
	private readonly EffectPass[] _passes;

	[Cpp2IlInjected.Token(Token = "0x1700027C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3990D4", Offset = "0x3990D4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3990D4", Offset = "0x3990D4")]
	public EffectPass Item
	{
		[Cpp2IlInjected.Token(Token = "0x600158F")]
		[Cpp2IlInjected.Address(RVA = "0x139BB84", Offset = "0x139BB84", VA = "0x139BB84")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027D")]
	public EffectPass Item
	{
		[Cpp2IlInjected.Token(Token = "0x6001590")]
		[Cpp2IlInjected.Address(RVA = "0x139BB94", Offset = "0x139BB94", VA = "0x139BB94")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027E")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6001591")]
		[Cpp2IlInjected.Address(RVA = "0x139BBF0", Offset = "0x139BBF0", VA = "0x139BBF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600158D")]
	[Cpp2IlInjected.Address(RVA = "0x139BA44", Offset = "0x139BA44", VA = "0x139BA44")]
	internal EffectPassCollection(EffectPass[] passes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600158E")]
	[Cpp2IlInjected.Address(RVA = "0x139BA64", Offset = "0x139BA64", VA = "0x139BA64")]
	internal EffectPassCollection Clone(Effect effect)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001592")]
	[Cpp2IlInjected.Address(RVA = "0x139BBFC", Offset = "0x139BBFC", VA = "0x139BBFC")]
	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6001593")]
	[Cpp2IlInjected.Address(RVA = "0x139BC20", Offset = "0x139BC20", VA = "0x139BC20", Slot = "4")]
	IEnumerator<EffectPass> IEnumerable<EffectPass>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001594")]
	[Cpp2IlInjected.Address(RVA = "0x139BCE0", Offset = "0x139BCE0", VA = "0x139BCE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
