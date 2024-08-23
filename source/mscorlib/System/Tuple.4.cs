using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000DD RID: 221
	[global::Cpp2ILInjected.Token(Token = "0x200010F")]
	[global::System.Serializable]
	public class Tuple<T1, T2, T3, T4> : global::System.Collections.IStructuralEquatable, global::System.Collections.IStructuralComparable, global::System.IComparable, global::System.ITupleInternal, global::System.Runtime.CompilerServices.ITuple
	{
		// Token: 0x06000957 RID: 2391 RVA: 0x00016064 File Offset: 0x00014264
		[global::Cpp2ILInjected.Token(Token = "0x60009FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1891CA8", Offset = "0x1891CA8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = ".ctor", MemberParameters = new object[] { "System.Xml.XmlNameTable" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			throw null;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00016067 File Offset: 0x00014267
		[global::Cpp2ILInjected.Token(Token = "0x6000A00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1891CEC", Offset = "0x1891CEC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0001606A File Offset: 0x0001426A
		[global::Cpp2ILInjected.Token(Token = "0x6000A01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1891DB4", Offset = "0x1891DB4", Length = "0x3D4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private bool System.Collections.IStructuralEquatable.Equals(object other, global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0001606D File Offset: 0x0001426D
		[global::Cpp2ILInjected.Token(Token = "0x6000A02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1892188", Offset = "0x1892188", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Comparer<object>), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int System.IComparable.CompareTo(object obj)
		{
			throw null;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00016070 File Offset: 0x00014270
		[global::Cpp2ILInjected.Token(Token = "0x6000A03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1892250", Offset = "0x1892250", Length = "0x450")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private int System.Collections.IStructuralComparable.CompareTo(object other, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00016073 File Offset: 0x00014273
		[global::Cpp2ILInjected.Token(Token = "0x6000A04")]
		[global::Cpp2ILInjected.Address(RVA = "0x18926A0", Offset = "0x18926A0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00016076 File Offset: 0x00014276
		[global::Cpp2ILInjected.Token(Token = "0x6000A05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1892764", Offset = "0x1892764", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Tuple), Member = "CombineHashCodes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private int System.Collections.IStructuralEquatable.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00016079 File Offset: 0x00014279
		[global::Cpp2ILInjected.Token(Token = "0x6000A06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1892A3C", Offset = "0x1892A3C", Length = "0xD8")]
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

		// Token: 0x0600095F RID: 2399 RVA: 0x0001607C File Offset: 0x0001427C
		[global::Cpp2ILInjected.Token(Token = "0x6000A07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1892B14", Offset = "0x1892B14", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private string System.ITupleInternal.ToString(global::System.Text.StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0001607F File Offset: 0x0001427F
		[global::Cpp2ILInjected.Token(Token = "0x170000BC")]
		private int System.Runtime.CompilerServices.ITuple.Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1892C9C", Offset = "0x1892C9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000282 RID: 642
		[global::Cpp2ILInjected.Token(Token = "0x40003D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T1 m_Item1;

		// Token: 0x04000283 RID: 643
		[global::Cpp2ILInjected.Token(Token = "0x40003D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T2 m_Item2;

		// Token: 0x04000284 RID: 644
		[global::Cpp2ILInjected.Token(Token = "0x40003D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T3 m_Item3;

		// Token: 0x04000285 RID: 645
		[global::Cpp2ILInjected.Token(Token = "0x40003D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T4 m_Item4;
	}
}
