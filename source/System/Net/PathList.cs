using System;
using System.Collections;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000217")]
	[Serializable]
	internal class PathList
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F332B4", Offset = "0x1F332B4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList), Member = ".ctor", MemberParameters = new object[] { typeof(IComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList), Member = "Synchronized", MemberParameters = new object[] { typeof(SortedList) }, ReturnType = typeof(SortedList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public PathList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C5")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F339C0", Offset = "0x1F339C0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F33354", Offset = "0x1F33354", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public int GetCookiesCount()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C6")]
		public ICollection Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F33874", Offset = "0x1F33874", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C7")]
		public object this[string s]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F33768", Offset = "0x1F33768", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3377C", Offset = "0x1F3377C", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
			{
				typeof(Cookie),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F354BC", Offset = "0x1F354BC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002C8")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F33754", Offset = "0x1F33754", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000B4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SortedList m_list;

		[global::Cpp2ILInjected.Token(Token = "0x2000218")]
		[Serializable]
		private class PathListComparer : IComparer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D50")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F35C7C", Offset = "0x1F35C7C", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieParser), Member = "CheckQuoted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private int System.Collections.IComparer.Compare(object ol, object or)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000D51")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F35DD8", Offset = "0x1F35DD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PathListComparer()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000D52")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F35DE0", Offset = "0x1F35DE0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static PathListComparer()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000B4F")]
			internal static readonly PathList.PathListComparer StaticInstance;
		}
	}
}
