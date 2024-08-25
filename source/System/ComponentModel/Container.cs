using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003DC")]
	public class Container : IContainer, IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001A16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62AF8", Offset = "0x1E62AF8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62B98", Offset = "0x1E62B98", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Add(IComponent component)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62BA8", Offset = "0x1E62BA8", Length = "0x42C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public virtual void Add(IComponent component, string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62FD4", Offset = "0x1E62FD4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual ISite CreateSite(IComponent component, string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63080", Offset = "0x1E63080", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NestedContainer), Member = "OnOwnerDisposed", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E630EC", Offset = "0x1E630EC", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NestedContainer), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E633AC", Offset = "0x1E633AC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NestedContainer), Member = "GetService", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual object GetService(Type service)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005FD")]
		public virtual ComponentCollection Components
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E63444", Offset = "0x1E63444", Length = "0x32C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ComponentCollection), Member = ".ctor", MemberParameters = new object[] { typeof(IComponent[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63770", Offset = "0x1E63770", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Remove(IComponent component)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63778", Offset = "0x1E63778", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Container), Member = "RemoveWithoutUnsiting", MemberParameters = new object[] { typeof(IComponent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void Remove(IComponent component, bool preserveSite)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63A1C", Offset = "0x1E63A1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Container), Member = "Remove", MemberParameters = new object[]
		{
			typeof(IComponent),
			typeof(bool)
		}, ReturnType = typeof(void))]
		protected void RemoveWithoutUnsiting(IComponent component)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63A24", Offset = "0x1E63A24", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		protected virtual void ValidateName(IComponent component, string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63E64", Offset = "0x1E63E64", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NestedContainer), Member = ".ctor", MemberParameters = new object[] { typeof(IComponent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Container()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ISite[] sites;

		[global::Cpp2ILInjected.Token(Token = "0x40012FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int siteCount;

		[global::Cpp2ILInjected.Token(Token = "0x40012FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ComponentCollection components;

		[global::Cpp2ILInjected.Token(Token = "0x40012FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ContainerFilterService filter;

		[global::Cpp2ILInjected.Token(Token = "0x40012FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool checkedFilter;

		[global::Cpp2ILInjected.Token(Token = "0x4001300")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object syncObj;

		[global::Cpp2ILInjected.Token(Token = "0x20003DD")]
		private class Site : ISite, IServiceProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A23")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E63044", Offset = "0x1E63044", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal Site(IComponent component, Container container, string name)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005FE")]
			public IComponent Component
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001A24")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E63EC4", Offset = "0x1E63EC4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005FF")]
			public IContainer Container
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001A25")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E63ECC", Offset = "0x1E63ECC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001A26")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E63ED4", Offset = "0x1E63ED4", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public object GetService(Type service)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000600")]
			public bool DesignMode
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001A27")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E63F90", Offset = "0x1E63F90", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000601")]
			public string Name
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001A28")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E63F98", Offset = "0x1E63F98", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6001A29")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E63FA0", Offset = "0x1E63FA0", Length = "0x54")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001301")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private IComponent component;

			[global::Cpp2ILInjected.Token(Token = "0x4001302")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Container container;

			[global::Cpp2ILInjected.Token(Token = "0x4001303")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private string name;
		}
	}
}
