using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x20002A6")]
	public class UnicastIPAddressInformationCollection : ICollection<UnicastIPAddressInformation>, IEnumerable<UnicastIPAddressInformation>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x600128F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CB60", Offset = "0x1E1CB60", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnixIPInterfaceProperties), Member = "get_UnicastAddresses", ReturnType = typeof(UnicastIPAddressInformationCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected internal UnicastIPAddressInformationCollection()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001290")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CBDC", Offset = "0x1E1CBDC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "CopyTo", MemberParameters = new object[]
		{
			"T[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void CopyTo(UnicastIPAddressInformation[] array, int offset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000449")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001291")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1CC3C", Offset = "0x1E1CC3C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700044A")]
		public virtual bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001292")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1CC84", Offset = "0x1E1CC84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001293")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CC8C", Offset = "0x1E1CC8C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void Add(UnicastIPAddressInformation address)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001294")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CCE4", Offset = "0x1E1CCE4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnixIPInterfaceProperties), Member = "get_UnicastAddresses", ReturnType = typeof(UnicastIPAddressInformationCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InternalAdd(UnicastIPAddressInformation address)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001295")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CD3C", Offset = "0x1E1CD3C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "Contains", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool Contains(UnicastIPAddressInformation address)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001296")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CD94", Offset = "0x1E1CD94", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001297")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CDA4", Offset = "0x1E1CDA4", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual IEnumerator<UnicastIPAddressInformation> GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CDEC", Offset = "0x1E1CDEC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual bool Remove(UnicastIPAddressInformation address)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001299")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CE44", Offset = "0x1E1CE44", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Collection<UnicastIPAddressInformation> addresses;
	}
}
