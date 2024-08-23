using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000DB RID: 219
	[global::Cpp2ILInjected.Token(Token = "0x200010D")]
	[global::System.Serializable]
	public class Tuple<T1, T2> : global::System.Collections.IStructuralEquatable, global::System.Collections.IStructuralComparable, global::System.IComparable, global::System.ITupleInternal, global::System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00016019 File Offset: 0x00014219
		[global::Cpp2ILInjected.Token(Token = "0x170000B5")]
		public T1 Item1
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1883C38", Offset = "0x1883C38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0001601C File Offset: 0x0001421C
		[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
		public T2 Item2
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1883C40", Offset = "0x1883C40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0001601F File Offset: 0x0001421F
		[global::Cpp2ILInjected.Token(Token = "0x60009E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1883C48", Offset = "0x1883C48", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Tuple(T1 item1, T2 item2)
		{
			throw null;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00016022 File Offset: 0x00014222
		[global::Cpp2ILInjected.Token(Token = "0x60009E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1883C80", Offset = "0x1883C80", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00016025 File Offset: 0x00014225
		[global::Cpp2ILInjected.Token(Token = "0x60009EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1883D48", Offset = "0x1883D48", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private bool System.Collections.IStructuralEquatable.Equals(object other, global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00016028 File Offset: 0x00014228
		[global::Cpp2ILInjected.Token(Token = "0x60009EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1883F8C", Offset = "0x1883F8C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Comparer<object>), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int System.IComparable.CompareTo(object obj)
		{
			throw null;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0001602B File Offset: 0x0001422B
		[global::Cpp2ILInjected.Token(Token = "0x60009EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1884054", Offset = "0x1884054", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private int System.Collections.IStructuralComparable.CompareTo(object other, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0001602E File Offset: 0x0001422E
		[global::Cpp2ILInjected.Token(Token = "0x60009ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1884314", Offset = "0x1884314", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00016031 File Offset: 0x00014231
		[global::Cpp2ILInjected.Token(Token = "0x60009EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x18843D8", Offset = "0x18843D8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Tuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private int System.Collections.IStructuralEquatable.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00016034 File Offset: 0x00014234
		[global::Cpp2ILInjected.Token(Token = "0x60009EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1884568", Offset = "0x1884568", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00016037 File Offset: 0x00014237
		[global::Cpp2ILInjected.Token(Token = "0x60009F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1884640", Offset = "0x1884640", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private string System.ITupleInternal.ToString(global::System.Text.StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0001603A File Offset: 0x0001423A
		[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
		private int System.Runtime.CompilerServices.ITuple.Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1884738", Offset = "0x1884738", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400027D RID: 637
		[global::Cpp2ILInjected.Token(Token = "0x40003CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T1 m_Item1;

		// Token: 0x0400027E RID: 638
		[global::Cpp2ILInjected.Token(Token = "0x40003D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T2 m_Item2;
	}
}
