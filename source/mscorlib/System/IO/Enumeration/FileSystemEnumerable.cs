using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO.Enumeration
{
	[global::Cpp2ILInjected.Token(Token = "0x2000576")]
	public class FileSystemEnumerable<TResult> : global::System.Collections.Generic.IEnumerable<TResult>, global::System.Collections.IEnumerable
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002A1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A18B0", Offset = "0x16A18B0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001696")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private FileSystemEnumerable<TResult>.DelegateEnumerator _enumerator;

		[global::Cpp2ILInjected.Token(Token = "0x4001697")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly FileSystemEnumerable<TResult>.FindTransform _transform;

		[global::Cpp2ILInjected.Token(Token = "0x4001698")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly EnumerationOptions _options;

		[global::Cpp2ILInjected.Token(Token = "0x4001699")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _directory;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400169A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private FileSystemEnumerable<TResult>.FindPredicate <ShouldIncludePredicate>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400169B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private FileSystemEnumerable<TResult>.FindPredicate <ShouldRecursePredicate>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x2000577")]
		public delegate bool FindPredicate(ref FileSystemEntry entry);

		[global::Cpp2ILInjected.Token(Token = "0x2000578")]
		public delegate TResult FindTransform(ref FileSystemEntry entry);

		[global::Cpp2ILInjected.Token(Token = "0x2000579")]
		private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1923528", Offset = "0x1923528", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002A20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1923560", Offset = "0x1923560", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			protected override TResult TransformEntry(ref FileSystemEntry entry)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x400169C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly FileSystemEnumerable<TResult> _enumerable;
		}
	}
}
