using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.ObjectModel
{
	// Token: 0x0200050D RID: 1293
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(global::System.Collections.Generic.ICollectionDebugView<>))]
	[global::Cpp2ILInjected.Token(Token = "0x200061F")]
	[global::System.Serializable]
	public class ReadOnlyCollection<T> : global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, IEnumerable, IList, ICollection, global::System.Collections.Generic.IReadOnlyList<T>, global::System.Collections.Generic.IReadOnlyCollection<T>
	{
		// Token: 0x06002BAC RID: 11180 RVA: 0x0001BEBD File Offset: 0x0001A0BD
		[global::Cpp2ILInjected.Token(Token = "0x6002FEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FA58", Offset = "0x181FA58", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		public ReadOnlyCollection(global::System.Collections.Generic.IList<T> list)
		{
			throw null;
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
		[global::Cpp2ILInjected.Token(Token = "0x170007A0")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FED")]
			[global::Cpp2ILInjected.Address(RVA = "0x181FA90", Offset = "0x181FA90", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006BF RID: 1727
		[global::Cpp2ILInjected.Token(Token = "0x170007A1")]
		public T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x181FB10", Offset = "0x181FB10", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x0001BEC6 File Offset: 0x0001A0C6
		[global::Cpp2ILInjected.Token(Token = "0x6002FEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FBA4", Offset = "0x181FBA4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Contains(T value)
		{
			throw null;
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x0001BEC9 File Offset: 0x0001A0C9
		[global::Cpp2ILInjected.Token(Token = "0x6002FF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FC44", Offset = "0x181FC44", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyTo(T[] array, int index)
		{
			throw null;
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x0001BECC File Offset: 0x0001A0CC
		[global::Cpp2ILInjected.Token(Token = "0x6002FF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FCE4", Offset = "0x181FCE4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x0001BECF File Offset: 0x0001A0CF
		[global::Cpp2ILInjected.Token(Token = "0x6002FF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FD64", Offset = "0x181FD64", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int IndexOf(T value)
		{
			throw null;
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x0001BED2 File Offset: 0x0001A0D2
		[global::Cpp2ILInjected.Token(Token = "0x170007A2")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FF3")]
			[global::Cpp2ILInjected.Address(RVA = "0x181FE04", Offset = "0x181FE04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x0001BED5 File Offset: 0x0001A0D5
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x0001BED8 File Offset: 0x0001A0D8
		[global::Cpp2ILInjected.Token(Token = "0x170007A3")]
		private T System.Collections.Generic.IList<T>.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FF4")]
			[global::Cpp2ILInjected.Address(RVA = "0x181FE0C", Offset = "0x181FE0C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002FF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x181FEA0", Offset = "0x181FEA0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x0001BEDB File Offset: 0x0001A0DB
		[global::Cpp2ILInjected.Token(Token = "0x6002FF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FEAC", Offset = "0x181FEAC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private void System.Collections.Generic.ICollection<T>.Add(T value)
		{
			throw null;
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x0001BEDE File Offset: 0x0001A0DE
		[global::Cpp2ILInjected.Token(Token = "0x6002FF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FEB8", Offset = "0x181FEB8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private void System.Collections.Generic.ICollection<T>.Clear()
		{
			throw null;
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0001BEE1 File Offset: 0x0001A0E1
		[global::Cpp2ILInjected.Token(Token = "0x6002FF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FEC4", Offset = "0x181FEC4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private void System.Collections.Generic.IList<T>.Insert(int index, T value)
		{
			throw null;
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x0001BEE4 File Offset: 0x0001A0E4
		[global::Cpp2ILInjected.Token(Token = "0x6002FF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FED0", Offset = "0x181FED0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private bool System.Collections.Generic.ICollection<T>.Remove(T value)
		{
			throw null;
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x0001BEE7 File Offset: 0x0001A0E7
		[global::Cpp2ILInjected.Token(Token = "0x6002FFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FEEC", Offset = "0x181FEEC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private void System.Collections.Generic.IList<T>.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x0001BEEA File Offset: 0x0001A0EA
		[global::Cpp2ILInjected.Token(Token = "0x6002FFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x181FEF8", Offset = "0x181FEF8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x0001BEED File Offset: 0x0001A0ED
		[global::Cpp2ILInjected.Token(Token = "0x170007A4")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x181FF90", Offset = "0x181FF90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x0001BEF0 File Offset: 0x0001A0F0
		[global::Cpp2ILInjected.Token(Token = "0x170007A5")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x181FF98", Offset = "0x181FF98", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x0001BEF3 File Offset: 0x0001A0F3
		[global::Cpp2ILInjected.Token(Token = "0x6002FFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1820098", Offset = "0x1820098", Length = "0x46C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x0001BEF6 File Offset: 0x0001A0F6
		[global::Cpp2ILInjected.Token(Token = "0x170007A6")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1820504", Offset = "0x1820504", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x0001BEF9 File Offset: 0x0001A0F9
		[global::Cpp2ILInjected.Token(Token = "0x170007A7")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003000")]
			[global::Cpp2ILInjected.Address(RVA = "0x182050C", Offset = "0x182050C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x0001BEFC File Offset: 0x0001A0FC
		// (set) Token: 0x06002BC2 RID: 11202 RVA: 0x0001BEFF File Offset: 0x0001A0FF
		[global::Cpp2ILInjected.Token(Token = "0x170007A8")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003001")]
			[global::Cpp2ILInjected.Address(RVA = "0x1820514", Offset = "0x1820514", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003002")]
			[global::Cpp2ILInjected.Address(RVA = "0x18205DC", Offset = "0x18205DC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x0001BF02 File Offset: 0x0001A102
		[global::Cpp2ILInjected.Token(Token = "0x6003003")]
		[global::Cpp2ILInjected.Address(RVA = "0x18205E8", Offset = "0x18205E8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x0001BF05 File Offset: 0x0001A105
		[global::Cpp2ILInjected.Token(Token = "0x6003004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1820604", Offset = "0x1820604", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private void System.Collections.IList.Clear()
		{
			throw null;
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x0001BF08 File Offset: 0x0001A108
		[global::Cpp2ILInjected.Token(Token = "0x6003005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1820610", Offset = "0x1820610", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool IsCompatibleObject(object value)
		{
			throw null;
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x0001BF0B File Offset: 0x0001A10B
		[global::Cpp2ILInjected.Token(Token = "0x6003006")]
		[global::Cpp2ILInjected.Address(RVA = "0x18206C0", Offset = "0x18206C0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x0001BF0E File Offset: 0x0001A10E
		[global::Cpp2ILInjected.Token(Token = "0x6003007")]
		[global::Cpp2ILInjected.Address(RVA = "0x182077C", Offset = "0x182077C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x0001BF11 File Offset: 0x0001A111
		[global::Cpp2ILInjected.Token(Token = "0x6003008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1820838", Offset = "0x1820838", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x0001BF14 File Offset: 0x0001A114
		[global::Cpp2ILInjected.Token(Token = "0x6003009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1820844", Offset = "0x1820844", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x0001BF17 File Offset: 0x0001A117
		[global::Cpp2ILInjected.Token(Token = "0x600300A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1820850", Offset = "0x1820850", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		private void System.Collections.IList.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x040015F9 RID: 5625
		[global::Cpp2ILInjected.Token(Token = "0x4001A42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Collections.Generic.IList<T> list;

		// Token: 0x040015FA RID: 5626
		[global::Cpp2ILInjected.Token(Token = "0x4001A43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.NonSerialized]
		private object _syncRoot;
	}
}
