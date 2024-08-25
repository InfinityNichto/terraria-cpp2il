using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B0C")]
	internal class TypeInstanceCollection<BaseType> : IDisposable where BaseType : class
	{
		[global::Cpp2ILInjected.Token(Token = "0x60052B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C6164", Offset = "0x14C6164", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Register<T>(T instance) where T : BaseType
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C5DD8", Offset = "0x14C5DD8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T Get<T>() where T : BaseType
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C6254", Offset = "0x14C6254", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Remove<T>() where T : BaseType
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C5EC0", Offset = "0x14C5EC0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Has<T>() where T : BaseType
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1893E54", Offset = "0x1893E54", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Has(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C5F4C", Offset = "0x14C5F4C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void IfHas<T>(Action<T> callback) where T : BaseType
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C6054", Offset = "0x14C6054", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public U IfHas<T, U>(Func<T, U> callback) where T : BaseType
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1893E6C", Offset = "0x1893E6C", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1894058", Offset = "0x1894058", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60052B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1894068", Offset = "0x1894068", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TypeInstanceCollection()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008ADE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Dictionary<Type, BaseType> _services;

		[global::Cpp2ILInjected.Token(Token = "0x4008ADF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _disposedValue;
	}
}
