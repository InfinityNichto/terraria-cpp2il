using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace ReLogic.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000715")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x385530", Offset = "0x385530")]
public sealed class SlotVector<T> : IEnumerable<SlotVector<T>.ItemPair>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000ACA")]
	public sealed class Enumerator : IEnumerator<ItemPair>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F7B")]
		private SlotVector<T> _slotVector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F7C")]
		private int _index;

		[Cpp2IlInjected.Token(Token = "0x1700090C")]
		private ItemPair System_002ECollections_002EGeneric_002EIEnumerator_003CReLogic_002EUtilities_002ESlotVector_003CT_003E_002EItemPair_003E_002ECurrent
		{
			[Cpp2IlInjected.Token(Token = "0x6005304")]
			[Cpp2IlInjected.Address(RVA = "0x1977298", Offset = "0x1977298", VA = "0x1977298", Slot = "4")]
			get
			{
				return default(ItemPair);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700090D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6005305")]
			[Cpp2IlInjected.Address(RVA = "0x19772E0", Offset = "0x19772E0", VA = "0x19772E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005303")]
		[Cpp2IlInjected.Address(RVA = "0x197726C", Offset = "0x197726C", VA = "0x197726C")]
		public Enumerator(SlotVector<T> slotVector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005306")]
		[Cpp2IlInjected.Address(RVA = "0x1977350", Offset = "0x1977350", VA = "0x1977350", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005307")]
		[Cpp2IlInjected.Address(RVA = "0x197735C", Offset = "0x197735C", VA = "0x197735C", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005308")]
		[Cpp2IlInjected.Address(RVA = "0x19773B8", Offset = "0x19773B8", VA = "0x19773B8", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000ACB")]
	public struct ItemPair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F7D")]
		public readonly T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F7E")]
		public readonly SlotId Id;

		[Cpp2IlInjected.Token(Token = "0x6005309")]
		[Cpp2IlInjected.Address(RVA = "0x3B4908", Offset = "0x3B4908", VA = "0x3B4908")]
		public ItemPair(T value, SlotId id)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4007154")]
	private const uint MAX_INDEX = 65535u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4007155")]
	private readonly ItemPair[] _array;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4007156")]
	private uint _freeHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4007157")]
	private uint _usedSpaceLength;

	[Cpp2IlInjected.Token(Token = "0x170007E4")]
	public T Item
	{
		[Cpp2IlInjected.Token(Token = "0x6004638")]
		[Cpp2IlInjected.Address(RVA = "0x1977560", Offset = "0x1977560", VA = "0x1977560")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004639")]
		[Cpp2IlInjected.Address(RVA = "0x1977654", Offset = "0x1977654", VA = "0x1977654")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007E5")]
	public T Item
	{
		[Cpp2IlInjected.Token(Token = "0x600463A")]
		[Cpp2IlInjected.Address(RVA = "0x197774C", Offset = "0x197774C", VA = "0x197774C")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600463B")]
		[Cpp2IlInjected.Address(RVA = "0x19778A4", Offset = "0x19778A4", VA = "0x19778A4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007E6")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600463C")]
		[Cpp2IlInjected.Address(RVA = "0x1977A04", Offset = "0x1977A04", VA = "0x1977A04")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600463D")]
		[Cpp2IlInjected.Address(RVA = "0x1977A0C", Offset = "0x1977A0C", VA = "0x1977A0C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007E7")]
	public int Capacity
	{
		[Cpp2IlInjected.Token(Token = "0x600463E")]
		[Cpp2IlInjected.Address(RVA = "0x1977A14", Offset = "0x1977A14", VA = "0x1977A14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600463F")]
	[Cpp2IlInjected.Address(RVA = "0x1977A20", Offset = "0x1977A20", VA = "0x1977A20")]
	public SlotVector(int capacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004640")]
	[Cpp2IlInjected.Address(RVA = "0x1977A88", Offset = "0x1977A88", VA = "0x1977A88")]
	public SlotId Add(T value)
	{
		return default(SlotId);
	}

	[Cpp2IlInjected.Token(Token = "0x6004641")]
	[Cpp2IlInjected.Address(RVA = "0x1977B58", Offset = "0x1977B58", VA = "0x1977B58")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004642")]
	[Cpp2IlInjected.Address(RVA = "0x1977BDC", Offset = "0x1977BDC", VA = "0x1977BDC")]
	public bool Remove(SlotId id)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004643")]
	[Cpp2IlInjected.Address(RVA = "0x1977C8C", Offset = "0x1977C8C", VA = "0x1977C8C")]
	public bool Has(SlotId id)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004644")]
	[Cpp2IlInjected.Address(RVA = "0x1977D80", Offset = "0x1977D80", VA = "0x1977D80")]
	public bool Has(int index)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004645")]
	[Cpp2IlInjected.Address(RVA = "0x1977DD0", Offset = "0x1977DD0", VA = "0x1977DD0")]
	public ItemPair GetPair(int index)
	{
		return default(ItemPair);
	}

	[Cpp2IlInjected.Token(Token = "0x6004646")]
	[Cpp2IlInjected.Address(RVA = "0x1977E9C", Offset = "0x1977E9C", VA = "0x1977E9C", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004647")]
	[Cpp2IlInjected.Address(RVA = "0x1977EFC", Offset = "0x1977EFC", VA = "0x1977EFC", Slot = "4")]
	private IEnumerator<ItemPair> System_002ECollections_002EGeneric_002EIEnumerable_003CReLogic_002EUtilities_002ESlotVector_003CT_003E_002EItemPair_003E_002EGetEnumerator()
	{
		return null;
	}
}
