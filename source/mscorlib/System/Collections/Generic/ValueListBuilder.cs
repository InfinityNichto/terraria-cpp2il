using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000523 RID: 1315
	[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::System.Reflection.DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x200063C")]
	internal ref struct ValueListBuilder<T>
	{
		// Token: 0x06002C67 RID: 11367 RVA: 0x0001C097 File Offset: 0x0001A297
		[global::Cpp2ILInjected.Token(Token = "0x60030DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AB2A4", Offset = "0x18AB2A4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public ValueListBuilder(global::System.Span<T> initialSpan)
		{
			throw null;
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x0001C09A File Offset: 0x0001A29A
		[global::Cpp2ILInjected.Token(Token = "0x170007E1")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60030E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AB2B4", Offset = "0x18AB2B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x0001C09D File Offset: 0x0001A29D
		[global::Cpp2ILInjected.Token(Token = "0x60030E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AB2BC", Offset = "0x18AB2BC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public void Append(T item)
		{
			throw null;
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x0001C0A0 File Offset: 0x0001A2A0
		[global::Cpp2ILInjected.Token(Token = "0x60030E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AB334", Offset = "0x18AB334", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public global::System.ReadOnlySpan<T> AsSpan()
		{
			throw null;
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x0001C0A3 File Offset: 0x0001A2A3
		[global::Cpp2ILInjected.Token(Token = "0x60030E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AB3F4", Offset = "0x18AB3F4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(256)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x0001C0A6 File Offset: 0x0001A2A6
		[global::Cpp2ILInjected.Token(Token = "0x60030E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AB4AC", Offset = "0x18AB4AC", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(ref ValueListBuilder<int>),
			typeof(ref ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueListBuilder<>), Member = "Append", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<int>), Member = "TryCopyTo", MemberParameters = new object[] { typeof(global::System.Span<int>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void Grow()
		{
			throw null;
		}

		// Token: 0x04001619 RID: 5657
		[global::Cpp2ILInjected.Token(Token = "0x4001A79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Span<T> _span;

		// Token: 0x0400161A RID: 5658
		[global::Cpp2ILInjected.Token(Token = "0x4001A7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T[] _arrayFromPool;

		// Token: 0x0400161B RID: 5659
		[global::Cpp2ILInjected.Token(Token = "0x4001A7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _pos;
	}
}
