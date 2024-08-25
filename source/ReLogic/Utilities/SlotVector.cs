using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Skies;

namespace ReLogic.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B09")]
	public sealed class SlotVector<T> : IEnumerable<SlotVector<T>.ItemPair>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008E4")]
		public T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005299")]
			[global::Cpp2ILInjected.Address(RVA = "0x18679D0", Offset = "0x18679D0", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_IsActive", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600529A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1867A84", Offset = "0x1867A84", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_IsActive", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>.ItemPair), Member = ".ctor", MemberParameters = new object[]
			{
				"T",
				typeof(SlotId)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008E5")]
		public T this[SlotId id]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600529B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1867B74", Offset = "0x1867B74", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "GetActiveSound", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(ActiveSound))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_Index", ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_IsActive", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(SlotId),
				typeof(SlotId)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600529C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1867C9C", Offset = "0x1867C9C", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_Index", ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_IsActive", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(SlotId),
				typeof(SlotId)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>.ItemPair), Member = ".ctor", MemberParameters = new object[]
			{
				"T",
				typeof(SlotId)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008E6")]
		public int Count
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600529D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1867DF8", Offset = "0x1867DF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600529E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1867E00", Offset = "0x1867E00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008E7")]
		public int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x600529F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1867E08", Offset = "0x1867E08", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1867E14", Offset = "0x1867E14", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SlotVector(int capacity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1867E74", Offset = "0x1867E74", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "Play", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "PlayLooped", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2),
			typeof(ActiveSound.LoopedPlayCondition)
		}, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "Play", MemberParameters = new object[] { typeof(SoundStyle) }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_Index", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "ToActive", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>.ItemPair), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(SlotId)
		}, ReturnType = typeof(void))]
		public SlotId Add(T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1867F78", Offset = "0x1867F78", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "StopAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>.ItemPair), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(SlotId)
		}, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x186806C", Offset = "0x186806C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_IsActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_Index", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "ToInactive", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>.ItemPair), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(SlotId)
		}, ReturnType = typeof(void))]
		public bool Remove(SlotId id)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1868140", Offset = "0x1868140", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "GetActiveSound", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(ActiveSound))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_Index", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_IsActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(SlotId),
			typeof(SlotId)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Has(SlotId id)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1868210", Offset = "0x1868210", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotId), Member = "get_IsActive", ReturnType = typeof(bool))]
		public bool Has(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1868258", Offset = "0x1868258", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>.ItemPair), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(SlotId)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SlotVector<T>.ItemPair GetPair(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1868320", Offset = "0x1868320", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1868384", Offset = "0x1868384", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<SlotVector<T>.ItemPair> System.Collections.Generic.IEnumerable<ReLogic.Utilities.SlotVector<T>.ItemPair>.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008AD5")]
		private const uint MAX_INDEX = 65535U;

		[global::Cpp2ILInjected.Token(Token = "0x4008AD6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly SlotVector<T>.ItemPair[] _array;

		[global::Cpp2ILInjected.Token(Token = "0x4008AD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private uint _freeHead;

		[global::Cpp2ILInjected.Token(Token = "0x4008AD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private uint _usedSpaceLength;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008AD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int <Count>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x2000B0A")]
		public sealed class Enumerator : IEnumerator<SlotVector<T>.ItemPair>, IEnumerator, IDisposable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x16488F8", Offset = "0x16488F8", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Enumerator(SlotVector<T> slotVector)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170008E8")]
			private SlotVector<T>.ItemPair System.Collections.Generic.IEnumerator<ReLogic.Utilities.SlotVector<T>.ItemPair>.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60052AA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1648928", Offset = "0x1648928", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170008E9")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60052AB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1648948", Offset = "0x1648948", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x60052AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x16489A4", Offset = "0x16489A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60052AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x16489B0", Offset = "0x16489B0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60052AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1648A10", Offset = "0x1648A10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008ADA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private SlotVector<T> _slotVector;

			[global::Cpp2ILInjected.Token(Token = "0x4008ADB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000B0B")]
		public struct ItemPair
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x17123FC", Offset = "0x17123FC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				"T"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(SlotId),
				"T"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(SlotId))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Clear", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Remove", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "GetPair", MemberParameters = new object[] { typeof(int) }, ReturnType = "ItemPair<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			public ItemPair(T value, SlotId id)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008ADC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly T Value;

			[global::Cpp2ILInjected.Token(Token = "0x4008ADD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly SlotId Id;
		}
	}
}
