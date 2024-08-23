using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000015 RID: 21
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x200002C")]
	[Serializable]
	public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00004460 File Offset: 0x00002660
		[global::Cpp2ILInjected.Token(Token = "0x600012D")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B0F98", Offset = "0x16B0F98", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Text.StringReaderWrapExtension", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public HashSet()
		{
			throw null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004463 File Offset: 0x00002663
		[global::Cpp2ILInjected.Token(Token = "0x600012E")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B0FE4", Offset = "0x16B0FE4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HashSet(IEqualityComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004466 File Offset: 0x00002666
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B103C", Offset = "0x16B103C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public HashSet(IEnumerable<T> collection)
		{
			throw null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004469 File Offset: 0x00002669
		[global::Cpp2ILInjected.Token(Token = "0x6000130")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1090", Offset = "0x16B1090", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000446C File Offset: 0x0000266C
		[global::Cpp2ILInjected.Token(Token = "0x6000131")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B12D0", Offset = "0x16B12D0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected HashSet(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000446F File Offset: 0x0000266F
		[global::Cpp2ILInjected.Token(Token = "0x6000132")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B12F8", Offset = "0x16B12F8", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Collections.HashHelpers", Member = "ExpandPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void CopyFrom(HashSet<T> source)
		{
			throw null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004472 File Offset: 0x00002672
		[global::Cpp2ILInjected.Token(Token = "0x6000133")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B14FC", Offset = "0x16B14FC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.Generic.ICollection<T>.Add(T item)
		{
			throw null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004475 File Offset: 0x00002675
		[global::Cpp2ILInjected.Token(Token = "0x6000134")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1510", Offset = "0x16B1510", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004478 File Offset: 0x00002678
		[global::Cpp2ILInjected.Token(Token = "0x6000135")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1568", Offset = "0x16B1568", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Text.StringReaderWrapExtension", Member = "CanBreakBetween", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(CultureInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool Contains(T item)
		{
			throw null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000447B File Offset: 0x0000267B
		[global::Cpp2ILInjected.Token(Token = "0x6000136")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1708", Offset = "0x16B1708", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000447E File Offset: 0x0000267E
		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1720", Offset = "0x16B1720", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool Remove(T item)
		{
			throw null;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00004481 File Offset: 0x00002681
		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000138")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B1978", Offset = "0x16B1978", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004484 File Offset: 0x00002684
		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000139")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B1980", Offset = "0x16B1980", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004487 File Offset: 0x00002687
		[global::Cpp2ILInjected.Token(Token = "0x600013A")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1988", Offset = "0x16B1988", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.HashSet`1<T>" }, ReturnType = typeof(void))]
		public HashSet<T>.Enumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000448A File Offset: 0x0000268A
		[global::Cpp2ILInjected.Token(Token = "0x600013B")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B19A8", Offset = "0x16B19A8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.HashSet`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000448D File Offset: 0x0000268D
		[global::Cpp2ILInjected.Token(Token = "0x600013C")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1A10", Offset = "0x16B1A10", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.HashSet`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004490 File Offset: 0x00002690
		[global::Cpp2ILInjected.Token(Token = "0x600013D")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1A78", Offset = "0x16B1A78", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004493 File Offset: 0x00002693
		[global::Cpp2ILInjected.Token(Token = "0x600013E")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1C90", Offset = "0x16B1C90", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public virtual void OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004496 File Offset: 0x00002696
		[global::Cpp2ILInjected.Token(Token = "0x600013F")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1F98", Offset = "0x16B1F98", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Text.StringReaderWrapExtension", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 70)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Add(T item)
		{
			throw null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004499 File Offset: 0x00002699
		[global::Cpp2ILInjected.Token(Token = "0x6000140")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B1FAC", Offset = "0x16B1FAC", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void UnionWith(IEnumerable<T> other)
		{
			throw null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000449C File Offset: 0x0000269C
		[global::Cpp2ILInjected.Token(Token = "0x6000141")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B22DC", Offset = "0x16B22DC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(T[] array)
		{
			throw null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000449F File Offset: 0x0000269F
		[global::Cpp2ILInjected.Token(Token = "0x6000142")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B22F8", Offset = "0x16B22F8", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
			throw null;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000044A2 File Offset: 0x000026A2
		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		public IEqualityComparer<T> Comparer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000143")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B24C4", Offset = "0x16B24C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000044A5 File Offset: 0x000026A5
		[global::Cpp2ILInjected.Token(Token = "0x6000144")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B24CC", Offset = "0x16B24CC", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Collections.HashHelpers", Member = "GetPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void TrimExcess()
		{
			throw null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000044A8 File Offset: 0x000026A8
		[global::Cpp2ILInjected.Token(Token = "0x6000145")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B2634", Offset = "0x16B2634", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Collections.HashHelpers", Member = "GetPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private int Initialize(int capacity)
		{
			throw null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000044AB File Offset: 0x000026AB
		[global::Cpp2ILInjected.Token(Token = "0x6000146")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B26F4", Offset = "0x16B26F4", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Collections.HashHelpers", Member = "ExpandPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void IncreaseCapacity()
		{
			throw null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000044AE File Offset: 0x000026AE
		[global::Cpp2ILInjected.Token(Token = "0x6000147")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B27CC", Offset = "0x16B27CC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void SetCapacity(int newSize)
		{
			throw null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000044B1 File Offset: 0x000026B1
		[global::Cpp2ILInjected.Token(Token = "0x6000148")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B28B8", Offset = "0x16B28B8", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool AddIfNotPresent(T value)
		{
			throw null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000044B4 File Offset: 0x000026B4
		[global::Cpp2ILInjected.Token(Token = "0x6000149")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B2B28", Offset = "0x16B2B28", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AddValue(int index, int hashCode, T value)
		{
			throw null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000044B7 File Offset: 0x000026B7
		[global::Cpp2ILInjected.Token(Token = "0x600014A")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B2B68", Offset = "0x16B2B68", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
		{
			throw null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000044BA File Offset: 0x000026BA
		[global::Cpp2ILInjected.Token(Token = "0x600014B")]
		[global::Cpp2ILInjected.Address(RVA = "0x16B2C44", Offset = "0x16B2C44", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int InternalGetHashCode(T item)
		{
			throw null;
		}

		// Token: 0x0400002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x40000A4")]
		private const int Lower31BitMask = 2147483647;

		// Token: 0x0400002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x40000A5")]
		private const int StackAllocThreshold = 100;

		// Token: 0x0400002C RID: 44
		[global::Cpp2ILInjected.Token(Token = "0x40000A6")]
		private const int ShrinkThreshold = 3;

		// Token: 0x0400002D RID: 45
		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		private const string CapacityName = "Capacity";

		// Token: 0x0400002E RID: 46
		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		private const string ElementsName = "Elements";

		// Token: 0x0400002F RID: 47
		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		private const string ComparerName = "Comparer";

		// Token: 0x04000030 RID: 48
		[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
		private const string VersionName = "Version";

		// Token: 0x04000031 RID: 49
		[global::Cpp2ILInjected.Token(Token = "0x40000AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int[] _buckets;

		// Token: 0x04000032 RID: 50
		[global::Cpp2ILInjected.Token(Token = "0x40000AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private HashSet<T>.Slot[] _slots;

		// Token: 0x04000033 RID: 51
		[global::Cpp2ILInjected.Token(Token = "0x40000AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _count;

		// Token: 0x04000034 RID: 52
		[global::Cpp2ILInjected.Token(Token = "0x40000AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _lastIndex;

		// Token: 0x04000035 RID: 53
		[global::Cpp2ILInjected.Token(Token = "0x40000AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _freeList;

		// Token: 0x04000036 RID: 54
		[global::Cpp2ILInjected.Token(Token = "0x40000B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IEqualityComparer<T> _comparer;

		// Token: 0x04000037 RID: 55
		[global::Cpp2ILInjected.Token(Token = "0x40000B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _version;

		// Token: 0x04000038 RID: 56
		[global::Cpp2ILInjected.Token(Token = "0x40000B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private SerializationInfo _siInfo;

		// Token: 0x0200003A RID: 58
		[global::Cpp2ILInjected.Token(Token = "0x200002D")]
		internal struct Slot
		{
			// Token: 0x040000CC RID: 204
			[global::Cpp2ILInjected.Token(Token = "0x40000B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int hashCode;

			// Token: 0x040000CD RID: 205
			[global::Cpp2ILInjected.Token(Token = "0x40000B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int next;

			// Token: 0x040000CE RID: 206
			[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal T value;
		}

		// Token: 0x0200003B RID: 59
		[global::Cpp2ILInjected.Token(Token = "0x200002E")]
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06000152 RID: 338 RVA: 0x000046A0 File Offset: 0x000028A0
			[global::Cpp2ILInjected.Token(Token = "0x600014C")]
			[global::Cpp2ILInjected.Address(RVA = "0x16455D0", Offset = "0x16455D0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashSet<>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashSet<>), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashSet<>), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			internal Enumerator(HashSet<T> set)
			{
				throw null;
			}

			// Token: 0x06000153 RID: 339 RVA: 0x000046A3 File Offset: 0x000028A3
			[global::Cpp2ILInjected.Token(Token = "0x600014D")]
			[global::Cpp2ILInjected.Address(RVA = "0x16455E8", Offset = "0x16455E8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x06000154 RID: 340 RVA: 0x000046A6 File Offset: 0x000028A6
			[global::Cpp2ILInjected.Token(Token = "0x600014E")]
			[global::Cpp2ILInjected.Address(RVA = "0x16455EC", Offset = "0x16455EC", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000155 RID: 341 RVA: 0x000046A9 File Offset: 0x000028A9
			[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
			public T Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600014F")]
				[global::Cpp2ILInjected.Address(RVA = "0x16456C0", Offset = "0x16456C0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000156 RID: 342 RVA: 0x000046AC File Offset: 0x000028AC
			[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000150")]
				[global::Cpp2ILInjected.Address(RVA = "0x16456C8", Offset = "0x16456C8", Length = "0xC4")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000157 RID: 343 RVA: 0x000046AF File Offset: 0x000028AF
			[global::Cpp2ILInjected.Token(Token = "0x6000151")]
			[global::Cpp2ILInjected.Address(RVA = "0x164578C", Offset = "0x164578C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x040000CF RID: 207
			[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private HashSet<T> _set;

			// Token: 0x040000D0 RID: 208
			[global::Cpp2ILInjected.Token(Token = "0x40000B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x040000D1 RID: 209
			[global::Cpp2ILInjected.Token(Token = "0x40000B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x040000D2 RID: 210
			[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T _current;
		}
	}
}
