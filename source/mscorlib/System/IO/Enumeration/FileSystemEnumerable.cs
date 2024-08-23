using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO.Enumeration
{
	// Token: 0x0200049F RID: 1183
	[global::Cpp2ILInjected.Token(Token = "0x2000576")]
	public class FileSystemEnumerable<TResult> : global::System.Collections.Generic.IEnumerable<TResult>, global::System.Collections.IEnumerable
	{
		// Token: 0x060026F8 RID: 9976 RVA: 0x0001B18B File Offset: 0x0001938B
		[global::Cpp2ILInjected.Token(Token = "0x6002A15")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A16BC", Offset = "0x16A16BC", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "UserFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "UserDirectories", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "UserEntries", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EnumerationOptions)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public FileSystemEnumerable(string directory, FileSystemEnumerable<TResult>.FindTransform transform, EnumerationOptions options = null)
		{
			throw null;
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x0001B18E File Offset: 0x0001938E
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x0001B191 File Offset: 0x00019391
		[global::Cpp2ILInjected.Token(Token = "0x1700060D")]
		public FileSystemEnumerable<TResult>.FindPredicate ShouldIncludePredicate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002A16")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A1830", Offset = "0x16A1830", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002A17")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A1838", Offset = "0x16A1838", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x0001B194 File Offset: 0x00019394
		[global::Cpp2ILInjected.Token(Token = "0x1700060E")]
		public FileSystemEnumerable<TResult>.FindPredicate ShouldRecursePredicate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002A18")]
			[global::Cpp2ILInjected.Address(RVA = "0x16A1840", Offset = "0x16A1840", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x0001B197 File Offset: 0x00019397
		[global::Cpp2ILInjected.Token(Token = "0x6002A19")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A1848", Offset = "0x16A1848", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public global::System.Collections.Generic.IEnumerator<TResult> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x0001B19A File Offset: 0x0001939A
		[global::Cpp2ILInjected.Token(Token = "0x6002A1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A18B0", Offset = "0x16A18B0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04001346 RID: 4934
		[global::Cpp2ILInjected.Token(Token = "0x4001696")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private FileSystemEnumerable<TResult>.DelegateEnumerator _enumerator;

		// Token: 0x04001347 RID: 4935
		[global::Cpp2ILInjected.Token(Token = "0x4001697")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly FileSystemEnumerable<TResult>.FindTransform _transform;

		// Token: 0x04001348 RID: 4936
		[global::Cpp2ILInjected.Token(Token = "0x4001698")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly EnumerationOptions _options;

		// Token: 0x04001349 RID: 4937
		[global::Cpp2ILInjected.Token(Token = "0x4001699")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _directory;

		// Token: 0x0400134A RID: 4938
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400169A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private FileSystemEnumerable<TResult>.FindPredicate <ShouldIncludePredicate>k__BackingField;

		// Token: 0x0400134B RID: 4939
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400169B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private FileSystemEnumerable<TResult>.FindPredicate <ShouldRecursePredicate>k__BackingField;

		// Token: 0x02000621 RID: 1569
		// (Invoke) Token: 0x060041F2 RID: 16882
		[global::Cpp2ILInjected.Token(Token = "0x2000577")]
		public delegate bool FindPredicate(ref FileSystemEntry entry);

		// Token: 0x02000622 RID: 1570
		// (Invoke) Token: 0x060041F4 RID: 16884
		[global::Cpp2ILInjected.Token(Token = "0x2000578")]
		public delegate TResult FindTransform(ref FileSystemEntry entry);

		// Token: 0x02000623 RID: 1571
		[global::Cpp2ILInjected.Token(Token = "0x2000579")]
		private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
		{
			// Token: 0x060041F5 RID: 16885 RVA: 0x00020039 File Offset: 0x0001E239
			[global::Cpp2ILInjected.Token(Token = "0x6002A1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1923528", Offset = "0x1923528", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable)
			{
				throw null;
			}

			// Token: 0x060041F6 RID: 16886 RVA: 0x0002003C File Offset: 0x0001E23C
			[global::Cpp2ILInjected.Token(Token = "0x6002A20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1923560", Offset = "0x1923560", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			protected override TResult TransformEntry(ref FileSystemEntry entry)
			{
				throw null;
			}

			// Token: 0x060041F7 RID: 16887 RVA: 0x0002003F File Offset: 0x0001E23F
			[global::Cpp2ILInjected.Token(Token = "0x6002A21")]
			[global::Cpp2ILInjected.Address(RVA = "0x192357C", Offset = "0x192357C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
			{
				throw null;
			}

			// Token: 0x060041F8 RID: 16888 RVA: 0x00020042 File Offset: 0x0001E242
			[global::Cpp2ILInjected.Token(Token = "0x6002A22")]
			[global::Cpp2ILInjected.Address(RVA = "0x19235DC", Offset = "0x19235DC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			protected override bool ShouldIncludeEntry(ref FileSystemEntry entry)
			{
				throw null;
			}

			// Token: 0x040019D6 RID: 6614
			[global::Cpp2ILInjected.Token(Token = "0x400169C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly FileSystemEnumerable<TResult> _enumerable;
		}
	}
}
